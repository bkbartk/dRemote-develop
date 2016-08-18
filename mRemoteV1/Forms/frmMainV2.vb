
Imports TheCodeKing.ActiveButtons.Controls
Imports WeifenLuo.WinFormsUI.Docking

Imports System.IO
Imports dRemote.App
Imports dRemote.My
Imports SharedLibraryNG
Imports System.Text
Imports dRemote.App.Runtime
Imports System.Reflection
Imports System.Runtime.InteropServices
Imports Crownwood
Imports dRemote.App.Native
Imports PSTaskDialog
Imports dRemote.Config
Imports dRemote.Themes
Imports System.Net
Imports System.ComponentModel

Public Class frmMainV2
    Dim QuickConnectWindow As UI.Window.QuickConnect
    Public Sub New()
        InitializeComponent()


        Windows.treeForm = New UI.Window.Tree()
        Windows.configForm = New UI.Window.Config()
        Windows.errorsForm = New UI.Window.ErrorsAndInfos()
        QuickConnectWindow = New UI.Window.QuickConnect()

        'Windows.configForm = New UI.Window.Config(Windows.configPanel)
        'Windows.configPanel = Windows.configForm

        'Windows.treeForm = New UI.Window.Tree(Windows.treePanel)
        'Windows.treePanel = Windows.treeForm
        Windows.dockPanel = DockPanel1
        Dim newPath As String = App.Info.Settings.SettingsPath & "\2" & App.Info.Settings.LayoutFileName
        If File.Exists(newPath) Then
            Try
                'resetLayout()
                DockPanel1.LoadFromXml(newPath, AddressOf GetContentFromPersistString)
            Catch
                resetLayout()
            End Try
        Else
            resetLayout()
        End If

    End Sub
    Private Function GetContentFromPersistString(ByVal persistString As String) As IDockContent
        ' pnlLayout.xml persistence XML fix for refactoring to dRemote
        Try
            Select Case persistString
                Case GetType(UI.Window.Config).ToString
                    Return Windows.configForm
                Case GetType(UI.Window.Tree).ToString
                    Return Windows.treeForm
                Case GetType(UI.Window.ErrorsAndInfos).ToString
                    Return Windows.errorsForm
                Case GetType(UI.Window.Sessions).ToString
                    Return Windows.sessionsForm
                Case GetType(UI.Window.ScreenshotManager).ToString
                    Return Windows.screenshotPanel
                Case GetType(UI.Window.QuickConnect).ToString
                    Return QuickConnectWindow

            End Select

        Catch ex As Exception
            Log.Error("GetContentFromPersistString failed" & vbNewLine & ex.Message)
        End Try

        Return Nothing
    End Function

    'Public Shared Sub CreatePanels()
    '    Windows.configForm = New UI.Window.Config(Windows.configPanel)
    '    Windows.configPanel = Windows.configForm

    '    Windows.treeForm = New UI.Window.Tree(Windows.treePanel)
    '    Windows.treePanel = Windows.treeForm
    '    Tree.Node.TreeView = Windows.treeForm.tvConnections

    '    Windows.errorsForm = New UI.Window.ErrorsAndInfos(Windows.errorsPanel)
    '    Windows.errorsPanel = Windows.errorsForm

    '    Windows.sessionsForm = New UI.Window.Sessions(Windows.sessionsPanel)
    '    Windows.sessionsPanel = Windows.sessionsForm

    '    Windows.screenshotForm = New UI.Window.ScreenshotManager(Windows.screenshotPanel)
    '    Windows.screenshotPanel = Windows.screenshotForm

    '    Windows.updateForm = New UI.Window.Update(Windows.updatePanel)
    '    Windows.updatePanel = Windows.updateForm

    '    Windows.AnnouncementForm = New UI.Window.Announcement(Windows.AnnouncementPanel)
    '    Windows.AnnouncementPanel = Windows.AnnouncementForm
    'End Sub


    Private Sub frmMainV2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'If My.Settings.FirstLoadAfterUpdate Then
        '    My.Settings.FirstLoadAfterUpdate = False
        '    My.Settings.Save()
        '    Threading.Thread.Sleep(500)
        '    System.Windows.Forms.Application.Restart()
        'End If


        Me.Location = My.Settings.MainFormLocation
        Me.Size = My.Settings.MainFormSize
        Me.WindowState = My.Settings.MainFormState
        Dim menu As IActiveMenu = ActiveMenu.GetInstance(Me)

        Dim mnubutton As New ActiveButton()
        mnubutton.BackColor = Color.Transparent
        mnubutton.Text = "Menu"
        AddHandler mnubutton.Click, AddressOf mnubutton_MouseClick
        menu.Items.Add(mnubutton)

        Dim btnV1 As New ActiveButton()
        btnV1.BackColor = Color.Transparent
        btnV1.Text = "dRemote classic"
        AddHandler btnV1.Click, AddressOf btnV1_Click
        menu.Items.Add(btnV1)

        Startup.CreateLogger()
        MessageCollector = New Messages.Collector(Windows.errorsForm)
        Dim SettingsLoad As New Config.Settings.Load()

        SettingsLoad.LoadExternalAppsFromXML()

        ' Load GUI Configuration
        SettingsLoad.Load(Me)
        Startup.GetConnectionIcons()


        Dim brows As New WebBrowser

        brows.ScrollBarsEnabled = False
        brows.Dock = Dock.Fill
        brows.ScriptErrorsSuppressed = True

        brows.Url = New Uri(App.Info.General.UrlStart & "&interface=2")

        DockPanel1.Controls.Add(brows)
        AddHandler brows.Navigating, AddressOf brows_Navigating

        'AddHandler brows.DocumentCompleted, AddressOf brows_DocumentCompleted
    End Sub

    'Private Sub brows_Navigating(sender As Object, e As System.Windows.Forms.WebBrowserNavigatingEventArgs)
    '    Dim url As String = e.Url.ToString
    '    If url.StartsWith("res://") And Not url.Contains("doubleclick.net") Then
    '        sender.Hide()
    '    ElseIf e.TargetFrameName = "" And Not url.StartsWith(App.Info.General.UrlStart) And url <> "about:blank" And Not url.Contains("doubleclick.net") And url <> "https://www.google.com/pagead/drt/ui" _
    '        And Not url.Contains("clickserve.dartsearch.net") _
    '        And Not url.Contains("jsiframe") Then
    '        Process.Start(url)
    '        e.Cancel = True
    '        If Not sender.url.ToString.Contains("dremote") Then
    '            sender.Url = New Uri(App.Info.General.UrlStart)
    '        End If
    '    End If
    'End Sub

    'Private Sub brows_DocumentCompleted(sender As Object, e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs)
    '    sender.Document.Cookie = GetUriCookieContainer(New Uri(App.Info.General.UrlStart))
    'End Sub
    '<DllImport("wininet.dll", SetLastError:=True)>
    'Public Shared Function InternetGetCookieEx(url As String, cookieName As String, cookieData As StringBuilder, ByRef size As Integer, dwFlags As Int32, lpReserved As IntPtr) As Boolean
    'End Function

    'Private Const InternetCookieHttponly As Int32 = &H2000

    '''' <summary>
    '''' Gets the URI cookie container.
    '''' </summary>
    '''' <param name="uri">The URI.</param>
    '''' <returns></returns>
    'Public Shared Function GetUriCookieContainer(uri As Uri) As String
    '    Dim cookies As String = ""
    '    ' Determine the size of the cookie
    '    Dim datasize As Integer = 8192 * 16
    '    Dim cookieData As New StringBuilder(datasize)
    '    If Not InternetGetCookieEx(uri.ToString(), Nothing, cookieData, datasize, InternetCookieHttponly, IntPtr.Zero) Then
    '        If datasize < 0 Then
    '            Return Nothing
    '        End If
    '        ' Allocate stringbuilder large enough to hold the cookie
    '        cookieData = New StringBuilder(datasize)
    '        If Not InternetGetCookieEx(uri.ToString(), Nothing, cookieData, datasize, InternetCookieHttponly, IntPtr.Zero) Then
    '            Return Nothing
    '        End If
    '    End If
    '    If cookieData.Length > 0 Then
    '        'cookies = New CookieContainer()
    '        'cookies.SetCookies(uri, cookieData.ToString().Replace(";"c, ","c))
    '        cookies += cookieData.ToString() + ";"
    '    End If
    '    Return cookies
    'End Function


    Private Sub mnubutton_MouseClick(sender As ActiveButton, e As MouseEventArgs)
        Dim left As Integer = Me.Width + Me.Left - sender.Left - 200
        Dim top As Integer = Me.Top + 30
        mainMenu.Show(left, top)

    End Sub

    Private Sub btnV1_Click(sender As Object, e As EventArgs)

        'frmMain.Show()
        'Me.Hide()
        'My.Settings.Beta = False
        'Select Case MsgBox("Save Connection?", MsgBoxStyle.YesNoCancel Or MsgBoxStyle.Question)
        '    Case MsgBoxResult.Yes
        '        SaveConnections()
        '    Case MsgBoxResult.Cancel
        '        Return
        'End Select
        If NotificationAreaIcon IsNot Nothing Then
            If NotificationAreaIcon.Disposed = False Then
                NotificationAreaIcon.Dispose()
            End If
        End If
        SaveConnections()
        SavePanelsToXML()
        My.Settings.Beta = False
        My.Settings.Save()
        'Threading.Thread.Sleep(500)
        System.Windows.Forms.Application.Restart()
        'Application.Exit()
        'Process.Start(Application.ExecutablePath)

    End Sub
    Private Sub frmMainV2_Resize(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Resize
        If WindowState = FormWindowState.Minimized Then
            If My.Settings.MinimizeToTray Then
                If NotificationAreaIcon Is Nothing Then
                    NotificationAreaIcon = New Tools.Controls.NotificationAreaIcon(Me)
                End If
                Hide()
            End If
        Else
            App.Runtime.PreviousWindowState = WindowState
        End If
    End Sub
    Private Sub frmMainV2_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        'Select Case MsgBox("Save Connection?", MsgBoxStyle.YesNoCancel Or MsgBoxStyle.Question)
        '    Case MsgBoxResult.Yes
        '        SaveConnections()
        '    Case MsgBoxResult.Cancel
        '        Return
        'End Select
        'SaveConnections()
        My.Settings.MainFormLocation = Me.Location
        My.Settings.MainFormSize = Me.Size
        My.Settings.MainFormState = Me.WindowState
        My.Settings.Save()
        SavePanelsToXML()
        If NotificationAreaIcon IsNot Nothing Then
            If NotificationAreaIcon.Disposed = False Then
                NotificationAreaIcon.Dispose()
            End If
        End If
        System.Windows.Forms.Application.Exit()
    End Sub

    Private Sub ActivateConnection(ByRef sender As Object)
        If TypeOf DockPanel1.ActiveDocument Is dRemote.Forms.frmConnections Then
            Dim cW As dRemote.Forms.frmConnections = DockPanel1.ActiveDocument
            If cW.Controls.Count > 0 Then
                Dim ctrl As Control = cW.Controls(0)
                Dim ifc As Connection.InterfaceControl = TryCast(ctrl, Connection.InterfaceControl)
                If Not IsNothing(ifc) AndAlso TypeOf ifc.Protocol Is dRemote.Connection.Protocol.PuttyBase Then
                    sender.ActiveDocument.Select()
                    ifc.Protocol.Focus()
                End If

            End If
        End If
    End Sub

    Private Sub pnlDock_ActiveDocumentChanged(ByVal sender As Object, ByVal e As EventArgs) Handles DockPanel1.ActivePaneChanged
        'If Not IsNothing(sender.ActiveDocument) AndAlso sender.ActiveDocument.controls.count > 0 Then
        '    sender.ActiveDocument.Select()
        'End If

        ActivateConnection(sender)

    End Sub

    'Private Sub pnlDock_ActiveDocumentChanged(ByVal sender As Object, ByVal e As EventArgs) Handles DockPanel1.ActiveDocumentChanged
    '    Dim connectionWindow As dRemote.Forms.frmConnections = TryCast(DockPanel1.ActiveDocument, dRemote.Forms.frmConnections)
    '    If connectionWindow IsNot Nothing AndAlso connectionWindow.Controls.Count > 0 Then
    '        Dim ifc As Connection.InterfaceControl = TryCast(connectionWindow.Controls(0), Connection.InterfaceControl)
    '        ifc.Protocol.Focus()
    '    End If
    'End Sub
    'Private Sub frmMainV2_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
    '    Shutdown.Cleanup()
    'End Sub
    Public Shared Sub SavePanelsToXML()
        Try
            If Not Directory.Exists(App.Info.Settings.SettingsPath) Then
                Directory.CreateDirectory(App.Info.Settings.SettingsPath)
            End If
            Windows.dockPanel.SaveAsXml(App.Info.Settings.SettingsPath & "\2" & App.Info.Settings.LayoutFileName)
        Catch ex As Exception
            MessageCollector.AddMessage(Messages.MessageClass.ErrorMsg, "SavePanelsToXML failed" & vbNewLine & vbNewLine & ex.Message, False)
        End Try
    End Sub

    Private Sub btnAmout_Click(sender As Object, e As EventArgs) Handles btnAmout.Click
        Dim frmAbout As New UI.Window.About
        frmAbout.Show(DockPanel1, DockState.Document)
    End Sub

    Private Sub mMenToolsOptions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mMenToolsOptions.Click
        Using optionsForm As New Forms.OptionsForm()
            optionsForm.ShowDialog(Me)
        End Using
    End Sub
    Private Sub mMenToolsUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mMenToolsUpdate.Click
        App.Runtime.Windows.Show(UI.Window.Type.Update)
    End Sub
    Private Sub mMenViewResetLayout_Click(sender As Object, e As EventArgs) Handles mMenViewResetLayout.Click
        If MsgBox(My.Language.strConfirmResetLayout, MsgBoxStyle.Question Or MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            resetLayout()
        End If
    End Sub
    Sub resetLayout()
        QuickConnectWindow.Hide()
        Windows.errorsForm.Hide()
        Windows.treeForm.Show(DockPanel1, DockState.DockLeft)
        Windows.configForm.Show(DockPanel1)
        Windows.configForm.DockTo(Windows.treeForm.Pane, DockStyle.Bottom, -1)

    End Sub

    Private Sub mMenViewConnections_Click(sender As Object, e As EventArgs) Handles mMenViewConnections.Click
        mMenViewConnections.Checked = Not mMenViewConnections.Checked
        If mMenViewConnections.Checked Then
            Windows.treeForm.Show()
        Else
            Windows.treeForm.Hide()
        End If

    End Sub

    Private Sub mMenViewConfig_Click(sender As Object, e As EventArgs) Handles mMenViewConfig.Click
        mMenViewConfig.Checked = Not mMenViewConfig.Checked
        If mMenViewConfig.Checked Then
            Windows.configForm.Show()
        Else
            Windows.configForm.Hide()
        End If
    End Sub


    Private Sub cMenLayout_DropDownOpening(sender As Object, e As EventArgs) Handles cMenLayout.DropDownOpening
        mMenViewConnections.Checked = Not Windows.treeForm.IsHidden
        mMenViewConfig.Checked = Not Windows.configForm.IsHidden
        mMenViewQuickConnectToolbar.Checked = Not QuickConnectWindow.IsHidden
        mMenViewErrorsAndInfos.Checked = Not Windows.errorsForm.IsHidden
    End Sub

    Private Sub mMenToolsSSHTransfer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mMenToolsSSHTransfer.Click
        App.Runtime.Windows.Show(UI.Window.Type.SSHTransfer)
    End Sub

    Private Sub mMenToolsUVNCSC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mMenToolsUVNCSC.Click
        App.Runtime.Windows.Show(UI.Window.Type.UltraVNCSC)
    End Sub

    Private Sub mMenToolsExternalApps_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mMenToolsExternalApps.Click
        App.Runtime.Windows.Show(UI.Window.Type.ExternalApps)
    End Sub

    Private Sub mMenToolsPortScan_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles mMenToolsPortScan.Click
        App.Runtime.Windows.Show(UI.Window.Type.PortScan, False)
    End Sub


    Private Sub mMenViewQuickConnectToolbar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mMenViewQuickConnectToolbar.Click
        mMenViewQuickConnectToolbar.Checked = Not mMenViewQuickConnectToolbar.Checked
        If mMenViewQuickConnectToolbar.Checked Then

            'QuickConnectWindow.Height = 61
            'QuickConnectWindow.Width = 424
            'QuickConnectWindow.Size = New Drawing.Size(424, 61)
            QuickConnectWindow.Show(DockPanel1, DockState.DockTop)
        Else
            QuickConnectWindow.Hide()
        End If
    End Sub

    Private Sub mMenViewErrorsAndInfos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mMenViewErrorsAndInfos.Click
        mMenViewErrorsAndInfos.Checked = Not mMenViewErrorsAndInfos.Checked
        If mMenViewErrorsAndInfos.Checked Then
            Windows.errorsForm.Show(DockPanel1, DockState.DockBottomAutoHide)
        Else
            Windows.errorsForm.Hide()
        End If
    End Sub

    Public Fullscreen As New Tools.Misc.Fullscreen(Me)
    Private Sub mMenViewFullscreen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mMenViewFullscreen.Click
        Fullscreen.Value = Not Fullscreen.Value
        mMenViewFullscreen.Checked = Fullscreen.Value
    End Sub
End Class

