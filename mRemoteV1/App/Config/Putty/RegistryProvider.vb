Imports System.Management
Imports dRemote.App
Imports dRemote.Messages
Imports Microsoft.Win32
Imports dRemote.Connection.Protocol
Imports System.Security.Principal

Namespace Config.Putty
    Public Class RegistryProvider
        Inherits Provider

#Region "Public Methods"
        Public Overrides Function GetSessionNames(Optional ByVal raw As Boolean = False) As String()
            Dim sessionsKey As RegistryKey = Registry.CurrentUser.OpenSubKey(PuttySessionsKey)
            If sessionsKey Is Nothing Then Return New String() {}

            Dim sessionNames As New List(Of String)
            For Each sessionName As String In sessionsKey.GetSubKeyNames()
                If raw Then
                    sessionNames.Add(sessionName)
                Else
                    sessionNames.Add(Web.HttpUtility.UrlDecode(sessionName.Replace("+", "%2B")))
                End If
            Next

            If raw Then
                If Not sessionNames.Contains("Default%20Settings") Then ' Do not localize
                    sessionNames.Insert(0, "Default%20Settings")
                End If
            Else
                If Not sessionNames.Contains("Default Settings") Then
                    sessionNames.Insert(0, "Default Settings")
                End If
            End If

            Return sessionNames.ToArray()
        End Function

        Public Function DeleteSession(ByVal name As String) As Boolean
            Dim sessionsKey As RegistryKey = Registry.CurrentUser.OpenSubKey(PuttySessionsKey, True)
            If sessionsKey Is Nothing Then Return False
            sessionsKey.DeleteSubKey(name)
            Return True
        End Function
        Public Function Rename(ByVal SessionName As String, ByVal Value As String) As Boolean
            Dim sessionsKey As RegistryKey = Registry.CurrentUser.OpenSubKey(PuttySessionsKey, True)
            If sessionsKey Is Nothing Then Return False
            RenameSubKey(sessionsKey, SessionName, Value)
            Return True
        End Function

        Public Function RenameSubKey(parentKey As RegistryKey, subKeyName As String, newSubKeyName As String) As Boolean
            CopyKey(parentKey, subKeyName, newSubKeyName)
            parentKey.DeleteSubKeyTree(subKeyName)
            Return True
        End Function

        ''' <summary>
        ''' Copy a registry key.  The parentKey must be writeable.
        ''' </summary>
        ''' <param name="parentKey"></param>
        ''' <param name="keyNameToCopy"></param>
        ''' <param name="newKeyName"></param>
        ''' <returns></returns>
        Public Function CopyKey(parentKey As RegistryKey, keyNameToCopy As String, newKeyName As String) As Boolean
            'Create new key
            Dim destinationKey As RegistryKey = parentKey.CreateSubKey(newKeyName)

            'Open the sourceKey we are copying from
            Dim sourceKey As RegistryKey = parentKey.OpenSubKey(keyNameToCopy)

            RecurseCopyKey(sourceKey, destinationKey)

            Return True
        End Function

        Private Sub RecurseCopyKey(sourceKey As RegistryKey, destinationKey As RegistryKey)
            'copy all the values
            For Each valueName As String In sourceKey.GetValueNames()
                Dim objValue As Object = sourceKey.GetValue(valueName)
                Dim valKind As RegistryValueKind = sourceKey.GetValueKind(valueName)
                destinationKey.SetValue(valueName, objValue, valKind)
            Next

            'For Each subKey 
            'Create a new subKey in destinationKey 
            'Call myself 
            For Each sourceSubKeyName As String In sourceKey.GetSubKeyNames()
                Dim sourceSubKey As RegistryKey = sourceKey.OpenSubKey(sourceSubKeyName)
                Dim destSubKey As RegistryKey = destinationKey.CreateSubKey(sourceSubKeyName)
                RecurseCopyKey(sourceSubKey, destSubKey)
            Next
        End Sub

        Public Function SaveSetting(ByVal SessionName As String, ByVal KeyName As String, ByVal Value As String) As Boolean
            Dim sessionsKey As RegistryKey = Registry.CurrentUser.OpenSubKey(PuttySessionsKey & "\" & SessionName, True)
            If sessionsKey Is Nothing Then Return False
            sessionsKey.SetValue(KeyName, Value)
            Return True
        End Function

        Public Overrides Function GetSession(ByVal sessionName As String) As Connection.PuttySession.Info
            Dim sessionsKey As RegistryKey = Registry.CurrentUser.OpenSubKey(PuttySessionsKey)
            If sessionsKey Is Nothing Then Return Nothing

            Dim sessionKey As RegistryKey = sessionsKey.OpenSubKey(sessionName)
            If sessionKey Is Nothing Then Return Nothing

            sessionName = Web.HttpUtility.UrlDecode(sessionName.Replace("+", "%2B"))

            Dim sessionInfo As New Connection.PuttySession.Info
            With sessionInfo
                .PuttySession = sessionName
                .Name = sessionName
                .Hostname = sessionKey.GetValue("HostName")
                .Username = sessionKey.GetValue("UserName")
                Dim protocol As String = sessionKey.GetValue("Protocol")
                If protocol Is Nothing Then protocol = "ssh"
                Select Case protocol.ToLowerInvariant()
                    Case "raw"
                        .Protocol = Protocols.RAW
                    Case "rlogin"
                        .Protocol = Protocols.Rlogin
                    Case "serial"
                        Return Nothing
                    Case "ssh"
                        Dim sshVersionObject As Object = sessionKey.GetValue("SshProt")
                        If sshVersionObject IsNot Nothing Then
                            Dim sshVersion As Integer = CType(sshVersionObject, Integer)
                            If sshVersion >= 2 Then
                                .Protocol = Protocols.SSH2
                            Else
                                .Protocol = Protocols.SSH1
                            End If
                        Else
                            .Protocol = Protocols.SSH2
                        End If
                    Case "telnet"
                        .Protocol = Protocols.Telnet
                    Case Else
                        Return Nothing
                End Select
                .Port = sessionKey.GetValue("PortNumber")
            End With

            Return sessionInfo
        End Function

        Public Overrides Sub StartWatcher()
            If _eventWatcher IsNot Nothing Then Return

            Try
                Dim currentUserSid As String = WindowsIdentity.GetCurrent().User.Value
                Dim key As String = String.Join("\", {currentUserSid, PuttySessionsKey}).Replace("\", "\\")
                Dim query As New WqlEventQuery(String.Format("SELECT * FROM RegistryTreeChangeEvent WHERE Hive = 'HKEY_USERS' AND RootPath = '{0}'", key))
                _eventWatcher = New ManagementEventWatcher(query)
                AddHandler _eventWatcher.EventArrived, AddressOf OnManagementEventArrived
                _eventWatcher.Start()
            Catch ex As Exception
                Runtime.MessageCollector.AddExceptionMessage("PuttySessions.Watcher.StartWatching() failed.", ex, MessageClass.WarningMsg, True)
            End Try
        End Sub

        Public Overrides Sub StopWatcher()
            If _eventWatcher Is Nothing Then Return
            _eventWatcher.Stop()
            _eventWatcher.Dispose()
            _eventWatcher = Nothing
        End Sub
#End Region

#Region "Private Fields"
        Private Const PuttySessionsKey As String = "Software\SimonTatham\PuTTY\Sessions"
        Private Shared _eventWatcher As ManagementEventWatcher
#End Region

#Region "Private Methods"
        Private Sub OnManagementEventArrived(ByVal sender As Object, ByVal e As EventArrivedEventArgs)
            OnSessionChanged(New SessionChangedEventArgs())
        End Sub
#End Region
    End Class
End Namespace

