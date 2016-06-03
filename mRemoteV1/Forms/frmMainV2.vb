
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

        'Dim cookiecr As CookieContainer = GetUriCookieContainer(New Uri(App.Info.General.UrlStart))

        'Dim cookie_string As String = ""
        'For Each cook As Net.Cookie In cookiecr.GetCookies

        '    cookie_string += cook.ToString() + ";"
        'Next

        brows.Url = New Uri(App.Info.General.UrlStart)

        DockPanel1.Controls.Add(brows)
        AddHandler brows.Navigating, AddressOf brows_Navigating

        'AddHandler brows.DocumentCompleted, AddressOf brows_DocumentCompleted
    End Sub

    Private Sub brows_Navigating(sender As Object, e As System.Windows.Forms.WebBrowserNavigatingEventArgs)
        Dim url As String = e.Url.ToString
        If url.StartsWith("res://") Then
            sender.Hide()
        ElseIf e.TargetFrameName = "" And Not url.StartsWith(App.Info.General.UrlStart) And url <> "about:blank" And Not url.Contains("doubleclick.net") And url <> "https://www.google.com/pagead/drt/ui" And Not url.Contains("clickserve.dartsearch.net") Then
            Process.Start(url)
            e.Cancel = True
            If Not sender.url.ToString.Contains("dremote") Then
                sender.Url = New Uri(App.Info.General.UrlStart)
            End If
        End If
    End Sub

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

        SaveConnections()
        SavePanelsToXML()
        My.Settings.Beta = False
        My.Settings.Save()
        Threading.Thread.Sleep(500)
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
        SaveConnections()
        SavePanelsToXML()
        System.Windows.Forms.Application.Exit()
    End Sub
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

    Private Sub DockPanel1_ActiveContentChanged(sender As Object, e As EventArgs) Handles DockPanel1.ActiveContentChanged

    End Sub

    Private Sub mainMenu_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles mainMenu.Opening

    End Sub
End Class

