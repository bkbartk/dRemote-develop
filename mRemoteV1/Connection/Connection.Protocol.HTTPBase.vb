﻿Imports dRemote.App.Runtime
Imports dRemote.Tools.LocalizedAttributes
'Imports CefSharp.WinForms
'Imports CefSharp

Namespace Connection
    Namespace Protocol
        Public Class HTTPBase
            Inherits Connection.Protocol.Base

#Region "Private Properties"
            Private wBrowser As Control
            Public httpOrS As String
            Public defaultPort As Integer
            Private tabTitle As String
#End Region

#Region "Public Methods"
            Public Sub New(ByVal RenderingEngine As RenderingEngine, ByVal i As Connection.Info)
                Try
                    'If RenderingEngine = RenderingEngine.Gecko Then
                    '    Dim strHost As String = i.Hostname
                    '    Me.Control = New ChromiumWebBrowser(strHost)
                    'Else
                    Me.Control = New WebBrowser
                    'End If
                    'Me.Control = New WebBrowser

                    NewExtended()
                Catch ex As Exception
                    MessageCollector.AddMessage(Messages.MessageClass.ErrorMsg, My.Language.strHttpConnectionFailed & vbNewLine & ex.Message, True)
                End Try
            End Sub

            Public Overridable Sub NewExtended()
            End Sub

            Public Overrides Function SetProps() As Boolean
                MyBase.SetProps()

                Try
                    Dim objTabPage As Crownwood.Magic.Controls.TabPage = TryCast(Me.InterfaceControl.Parent, Crownwood.Magic.Controls.TabPage)
                    Me.tabTitle = objTabPage.Title
                Catch ex As Exception
                    Me.tabTitle = ""
                End Try

                Try
                    Me.wBrowser = Me.Control

                    'If InterfaceControl.Info.RenderingEngine = RenderingEngine.Gecko Then
                    '    Dim objMiniGeckoBrowser As ChromiumWebBrowser = TryCast(wBrowser, ChromiumWebBrowser)
                    '    'wBrowser = New ChromiumWebBrowser("http://www.dremote.nl")


                    '    AddHandler objMiniGeckoBrowser.TitleChanged, AddressOf wBrowser_DocumentTitleChanged
                    '    'AddHandler objMiniGeckoBrowser.LastTabRemoved, AddressOf wBrowser_LastTabRemoved
                    'Else
                    Dim objWebBrowser As WebBrowser = TryCast(wBrowser, WebBrowser)
                        Dim objAxWebBrowser As SHDocVw.WebBrowser = DirectCast(objWebBrowser.ActiveXInstance, SHDocVw.WebBrowser)

                        objWebBrowser.ScrollBarsEnabled = True

                        AddHandler objWebBrowser.Navigated, AddressOf wBrowser_Navigated
                        AddHandler objWebBrowser.DocumentTitleChanged, AddressOf wBrowser_DocumentTitleChanged
                        AddHandler objAxWebBrowser.NewWindow3, AddressOf wBrowser_NewWindow3
                    'End If

                    Return True
                Catch ex As Exception
                    MessageCollector.AddMessage(Messages.MessageClass.ErrorMsg, My.Language.strHttpSetPropsFailed & vbNewLine & ex.Message, True)
                    Return False
                End Try
            End Function

            Public Overrides Function Connect() As Boolean
                Try
                    Dim strHost As String = Me.InterfaceControl.Info.Hostname
                    Dim strAuth As String = ""

                    If Not ((Force And Info.Force.NoCredentials) = Info.Force.NoCredentials) And Not String.IsNullOrEmpty(InterfaceControl.Info.Username) And Not String.IsNullOrEmpty(InterfaceControl.Info.Password) Then
                        strAuth = "Authorization: Basic " + Convert.ToBase64String(System.Text.Encoding.ASCII.GetBytes(Me.InterfaceControl.Info.Username & ":" & Me.InterfaceControl.Info.Password)) & vbNewLine
                    End If

                    If Me.InterfaceControl.Info.Port <> defaultPort Then
                        If strHost.EndsWith("/") Then
                            strHost = strHost.Substring(0, strHost.Length - 1)
                        End If

                        If strHost.Contains(httpOrS & "://") = False Then
                            strHost = httpOrS & "://" & strHost
                        End If

                        'If InterfaceControl.Info.RenderingEngine = RenderingEngine.Gecko Then
                        '    TryCast(wBrowser, ChromiumWebBrowser).Load(strHost & ":" & Me.InterfaceControl.Info.Port)
                        'Else
                        TryCast(wBrowser, WebBrowser).Navigate(strHost & ":" & Me.InterfaceControl.Info.Port, Nothing, Nothing, strAuth)
                        'End If
                    Else
                        If strHost.Contains(httpOrS & "://") = False Then
                            strHost = httpOrS & "://" & strHost
                        End If

                        'If InterfaceControl.Info.RenderingEngine = RenderingEngine.Gecko Then
                        '    TryCast(wBrowser, ChromiumWebBrowser).Load(strHost)
                        'Else
                        TryCast(wBrowser, WebBrowser).Navigate(strHost, Nothing, Nothing, strAuth)
                        'End If
                    End If

                    MyBase.Connect()
                    Return True
                Catch ex As Exception
                    MessageCollector.AddMessage(Messages.MessageClass.ErrorMsg, My.Language.strHttpConnectFailed & vbNewLine & ex.Message, True)
                    Return False
                End Try
            End Function
#End Region

#Region "Private Methods"

#End Region

#Region "Events"
            Private Sub wBrowser_Navigated(sender As Object, e As System.Windows.Forms.WebBrowserNavigatedEventArgs)
                Dim objWebBrowser As WebBrowser = TryCast(wBrowser, WebBrowser)
                If objWebBrowser Is Nothing Then Return

                ' This can only be set once the WebBrowser control is shown, it will throw a COM exception otherwise.
                objWebBrowser.AllowWebBrowserDrop = False

                RemoveHandler objWebBrowser.Navigated, AddressOf wBrowser_Navigated
            End Sub

            Private Sub wBrowser_NewWindow3(ByRef ppDisp As Object, ByRef Cancel As Boolean, ByVal dwFlags As Long, ByVal bstrUrlContext As String, ByVal bstrUrl As String)
                If (dwFlags And NWMF.NWMF_OVERRIDEKEY) Then
                    Cancel = False
                Else
                    Cancel = True
                End If
            End Sub

            Private Sub wBrowser_LastTabRemoved(ByVal sender As Object)
                Me.Close()
            End Sub

            Private Sub wBrowser_DocumentTitleChanged()
                Try
                    Dim tabP As Crownwood.Magic.Controls.TabPage
                    tabP = TryCast(InterfaceControl.Parent, Crownwood.Magic.Controls.TabPage)

                    If tabP IsNot Nothing Then
                        Dim shortTitle As String = ""

                        'If Me.InterfaceControl.Info.RenderingEngine = RenderingEngine.Gecko Then
                        '    If TryCast(wBrowser, ChromiumWebBrowser).Name.Length >= 30 Then
                        '        shortTitle = TryCast(wBrowser, ChromiumWebBrowser).Name.Substring(0, 29) & " ..."
                        '    Else
                        '        shortTitle = TryCast(wBrowser, ChromiumWebBrowser).Name
                        '    End If
                        'Else
                        If TryCast(wBrowser, WebBrowser).DocumentTitle.Length >= 30 Then
                                shortTitle = TryCast(wBrowser, WebBrowser).DocumentTitle.Substring(0, 29) & " ..."
                            Else
                                shortTitle = TryCast(wBrowser, WebBrowser).DocumentTitle
                            End If
                        'End If

                        If Me.tabTitle <> "" Then
                            tabP.Title = tabTitle & " - " & shortTitle
                        Else
                            tabP.Title = shortTitle
                        End If
                    End If
                Catch ex As Exception
                    MessageCollector.AddMessage(Messages.MessageClass.WarningMsg, My.Language.strHttpDocumentTileChangeFailed & vbNewLine & ex.Message, True)
                End Try
            End Sub
#End Region

#Region "Enums"
            Public Enum RenderingEngine
                <LocalizedDescription("strHttpInternetExplorer")> _
                IE = 1
                <LocalizedDescription("strHttpGecko")> _
                Gecko = 2
            End Enum

            Private Enum NWMF
                ' ReSharper disable InconsistentNaming
                NWMF_UNLOADING = &H1
                NWMF_USERINITED = &H2
                NWMF_FIRST = &H4
                NWMF_OVERRIDEKEY = &H8
                NWMF_SHOWHELP = &H10
                NWMF_HTMLDIALOG = &H20
                NWMF_FROMDIALOGCHILD = &H40
                NWMF_USERREQUESTED = &H80
                NWMF_USERALLOWED = &H100
                NWMF_FORCEWINDOW = &H10000
                NWMF_FORCETAB = &H20000
                NWMF_SUGGESTWINDOW = &H40000
                NWMF_SUGGESTTAB = &H80000
                NWMF_INACTIVETAB = &H100000
                ' ReSharper restore InconsistentNaming
            End Enum
#End Region
        End Class
    End Namespace
End Namespace