<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.pnlDock = New WeifenLuo.WinFormsUI.Docking.DockPanel()
        Me.msMain = New System.Windows.Forms.MenuStrip()
        Me.mMenFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mMenFileNewConnection = New System.Windows.Forms.ToolStripMenuItem()
        Me.mMenFileNewFolder = New System.Windows.Forms.ToolStripMenuItem()
        Me.mMenFileSep1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mMenFileNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.mMenFileLoad = New System.Windows.Forms.ToolStripMenuItem()
        Me.mMenFileSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.mMenFileSaveAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.mMenFileSep2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mMenFileDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.mMenFileRename = New System.Windows.Forms.ToolStripMenuItem()
        Me.mMenFileDuplicate = New System.Windows.Forms.ToolStripMenuItem()
        Me.mMenFileSep3 = New System.Windows.Forms.ToolStripSeparator()
        Me.mMenFileImport = New System.Windows.Forms.ToolStripMenuItem()
        Me.mMenFileImportFromFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mMenFileImportFromActiveDirectory = New System.Windows.Forms.ToolStripMenuItem()
        Me.mMenFileImportFromPortScan = New System.Windows.Forms.ToolStripMenuItem()
        Me.mMenFileExport = New System.Windows.Forms.ToolStripMenuItem()
        Me.mMenFileSep4 = New System.Windows.Forms.ToolStripSeparator()
        Me.mMenFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mMenView = New System.Windows.Forms.ToolStripMenuItem()
        Me.mMenViewAddConnectionPanel = New System.Windows.Forms.ToolStripMenuItem()
        Me.mMenViewConnectionPanels = New System.Windows.Forms.ToolStripMenuItem()
        Me.mMenViewSep1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mMenViewConnections = New System.Windows.Forms.ToolStripMenuItem()
        Me.mMenViewConfig = New System.Windows.Forms.ToolStripMenuItem()
        Me.mMenViewSessions = New System.Windows.Forms.ToolStripMenuItem()
        Me.mMenViewErrorsAndInfos = New System.Windows.Forms.ToolStripMenuItem()
        Me.mMenViewScreenshotManager = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mMenViewJumpTo = New System.Windows.Forms.ToolStripMenuItem()
        Me.mMenViewJumpToConnectionsConfig = New System.Windows.Forms.ToolStripMenuItem()
        Me.mMenViewJumpToSessionsScreenshots = New System.Windows.Forms.ToolStripMenuItem()
        Me.mMenViewJumpToErrorsInfos = New System.Windows.Forms.ToolStripMenuItem()
        Me.mMenViewResetLayout = New System.Windows.Forms.ToolStripMenuItem()
        Me.mMenViewSep2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mMenViewQuickConnectToolbar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mMenViewExtAppsToolbar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mMenViewSep3 = New System.Windows.Forms.ToolStripSeparator()
        Me.mMenViewFullscreen = New System.Windows.Forms.ToolStripMenuItem()
        Me.mMenTools = New System.Windows.Forms.ToolStripMenuItem()
        Me.mMenToolsSSHTransfer = New System.Windows.Forms.ToolStripMenuItem()
        Me.mMenToolsUVNCSC = New System.Windows.Forms.ToolStripMenuItem()
        Me.mMenToolsExternalApps = New System.Windows.Forms.ToolStripMenuItem()
        Me.mMenToolsPortScan = New System.Windows.Forms.ToolStripMenuItem()
        Me.mMenToolsSep1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mMenToolsComponentsCheck = New System.Windows.Forms.ToolStripMenuItem()
        Me.mMenToolsOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.mMenInfo = New System.Windows.Forms.ToolStripMenuItem()
        Me.mMenInfoHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mMenInfoSep1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mMenInfoWebsite = New System.Windows.Forms.ToolStripMenuItem()
        Me.mMenInfoDonate = New System.Windows.Forms.ToolStripMenuItem()
        Me.mMenInfoForum = New System.Windows.Forms.ToolStripMenuItem()
        Me.mMenInfoBugReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mMenToolsUpdate = New System.Windows.Forms.ToolStripMenuItem()
        Me.mMenInfoSep2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mMenInfoAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.DRemoteV2BetaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mMenSep3 = New System.Windows.Forms.ToolStripSeparator()
        Me.lblQuickConnect = New System.Windows.Forms.ToolStripLabel()
        Me.cmbQuickConnect = New dRemote.Controls.QuickConnectComboBox()
        Me.tsContainer = New System.Windows.Forms.ToolStripContainer()
        Me.tsQuickConnect = New System.Windows.Forms.ToolStrip()
        Me.btnQuickConnect = New dRemote.Controls.ToolStripSplitButton()
        Me.mnuQuickConnectProtocol = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.btnConnections = New System.Windows.Forms.ToolStripDropDownButton()
        Me.mnuConnections = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsExternalTools = New System.Windows.Forms.ToolStrip()
        Me.cMenExtAppsToolbar = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cMenToolbarShowText = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSplitButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmrAutoSave = New System.Windows.Forms.Timer(Me.components)
        Me.msMain.SuspendLayout()
        Me.tsContainer.ContentPanel.SuspendLayout()
        Me.tsContainer.TopToolStripPanel.SuspendLayout()
        Me.tsContainer.SuspendLayout()
        Me.tsQuickConnect.SuspendLayout()
        Me.cMenExtAppsToolbar.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlDock
        '
        Me.pnlDock.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDock.DockBackColor = System.Drawing.SystemColors.Control
        Me.pnlDock.DockLeftPortion = 230.0R
        Me.pnlDock.DockRightPortion = 230.0R
        Me.pnlDock.DocumentStyle = WeifenLuo.WinFormsUI.Docking.DocumentStyle.DockingSdi
        Me.pnlDock.Location = New System.Drawing.Point(0, 0)
        Me.pnlDock.Name = "pnlDock"
        Me.pnlDock.Size = New System.Drawing.Size(842, 449)
        Me.pnlDock.TabIndex = 13
        '
        'msMain
        '
        Me.msMain.Dock = System.Windows.Forms.DockStyle.None
        Me.msMain.GripMargin = New System.Windows.Forms.Padding(0)
        Me.msMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.msMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mMenFile, Me.mMenView, Me.mMenTools, Me.mMenInfo, Me.DRemoteV2BetaToolStripMenuItem})
        Me.msMain.Location = New System.Drawing.Point(3, 0)
        Me.msMain.Name = "msMain"
        Me.msMain.Padding = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.msMain.Size = New System.Drawing.Size(290, 24)
        Me.msMain.Stretch = False
        Me.msMain.TabIndex = 16
        Me.msMain.Text = "Main Toolbar"
        '
        'mMenFile
        '
        Me.mMenFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mMenFileNewConnection, Me.mMenFileNewFolder, Me.mMenFileSep1, Me.mMenFileNew, Me.mMenFileLoad, Me.mMenFileSave, Me.mMenFileSaveAs, Me.mMenFileSep2, Me.mMenFileDelete, Me.mMenFileRename, Me.mMenFileDuplicate, Me.mMenFileSep3, Me.mMenFileImport, Me.mMenFileExport, Me.mMenFileSep4, Me.mMenFileExit})
        Me.mMenFile.Name = "mMenFile"
        Me.mMenFile.Size = New System.Drawing.Size(37, 20)
        Me.mMenFile.Text = "&File"
        '
        'mMenFileNewConnection
        '
        Me.mMenFileNewConnection.Image = Global.dRemote.My.Resources.Resources.Connection_Add
        Me.mMenFileNewConnection.Name = "mMenFileNewConnection"
        Me.mMenFileNewConnection.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.mMenFileNewConnection.Size = New System.Drawing.Size(281, 22)
        Me.mMenFileNewConnection.Text = "New Connection"
        '
        'mMenFileNewFolder
        '
        Me.mMenFileNewFolder.Image = Global.dRemote.My.Resources.Resources.Folder_Add
        Me.mMenFileNewFolder.Name = "mMenFileNewFolder"
        Me.mMenFileNewFolder.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.mMenFileNewFolder.Size = New System.Drawing.Size(281, 22)
        Me.mMenFileNewFolder.Text = "New Folder"
        '
        'mMenFileSep1
        '
        Me.mMenFileSep1.Name = "mMenFileSep1"
        Me.mMenFileSep1.Size = New System.Drawing.Size(278, 6)
        '
        'mMenFileNew
        '
        Me.mMenFileNew.Image = Global.dRemote.My.Resources.Resources.Connections_New
        Me.mMenFileNew.Name = "mMenFileNew"
        Me.mMenFileNew.Size = New System.Drawing.Size(281, 22)
        Me.mMenFileNew.Text = "New Connection File"
        '
        'mMenFileLoad
        '
        Me.mMenFileLoad.Image = Global.dRemote.My.Resources.Resources.Connections_Load
        Me.mMenFileLoad.Name = "mMenFileLoad"
        Me.mMenFileLoad.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.mMenFileLoad.Size = New System.Drawing.Size(281, 22)
        Me.mMenFileLoad.Text = "Open Connection File..."
        '
        'mMenFileSave
        '
        Me.mMenFileSave.Image = Global.dRemote.My.Resources.Resources.Connections_Save
        Me.mMenFileSave.Name = "mMenFileSave"
        Me.mMenFileSave.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mMenFileSave.Size = New System.Drawing.Size(281, 22)
        Me.mMenFileSave.Text = "Save Connection File"
        '
        'mMenFileSaveAs
        '
        Me.mMenFileSaveAs.Image = Global.dRemote.My.Resources.Resources.Connections_SaveAs
        Me.mMenFileSaveAs.Name = "mMenFileSaveAs"
        Me.mMenFileSaveAs.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mMenFileSaveAs.Size = New System.Drawing.Size(281, 22)
        Me.mMenFileSaveAs.Text = "Save Connection File As..."
        '
        'mMenFileSep2
        '
        Me.mMenFileSep2.Name = "mMenFileSep2"
        Me.mMenFileSep2.Size = New System.Drawing.Size(278, 6)
        '
        'mMenFileDelete
        '
        Me.mMenFileDelete.Image = Global.dRemote.My.Resources.Resources.Delete
        Me.mMenFileDelete.Name = "mMenFileDelete"
        Me.mMenFileDelete.Size = New System.Drawing.Size(281, 22)
        Me.mMenFileDelete.Text = "Delete..."
        '
        'mMenFileRename
        '
        Me.mMenFileRename.Image = Global.dRemote.My.Resources.Resources.Rename
        Me.mMenFileRename.Name = "mMenFileRename"
        Me.mMenFileRename.Size = New System.Drawing.Size(281, 22)
        Me.mMenFileRename.Text = "Rename"
        '
        'mMenFileDuplicate
        '
        Me.mMenFileDuplicate.Image = Global.dRemote.My.Resources.Resources.page_copy
        Me.mMenFileDuplicate.Name = "mMenFileDuplicate"
        Me.mMenFileDuplicate.Size = New System.Drawing.Size(281, 22)
        Me.mMenFileDuplicate.Text = "Duplicate"
        '
        'mMenFileSep3
        '
        Me.mMenFileSep3.Name = "mMenFileSep3"
        Me.mMenFileSep3.Size = New System.Drawing.Size(278, 6)
        '
        'mMenFileImport
        '
        Me.mMenFileImport.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mMenFileImportFromFile, Me.mMenFileImportFromActiveDirectory, Me.mMenFileImportFromPortScan})
        Me.mMenFileImport.Name = "mMenFileImport"
        Me.mMenFileImport.Size = New System.Drawing.Size(281, 22)
        Me.mMenFileImport.Text = "&Import"
        '
        'mMenFileImportFromFile
        '
        Me.mMenFileImportFromFile.Name = "mMenFileImportFromFile"
        Me.mMenFileImportFromFile.Size = New System.Drawing.Size(235, 22)
        Me.mMenFileImportFromFile.Text = "Import from &File..."
        '
        'mMenFileImportFromActiveDirectory
        '
        Me.mMenFileImportFromActiveDirectory.Name = "mMenFileImportFromActiveDirectory"
        Me.mMenFileImportFromActiveDirectory.Size = New System.Drawing.Size(235, 22)
        Me.mMenFileImportFromActiveDirectory.Text = "Import from &Active Directory..."
        '
        'mMenFileImportFromPortScan
        '
        Me.mMenFileImportFromPortScan.Name = "mMenFileImportFromPortScan"
        Me.mMenFileImportFromPortScan.Size = New System.Drawing.Size(235, 22)
        Me.mMenFileImportFromPortScan.Text = "Import from &Port Scan..."
        '
        'mMenFileExport
        '
        Me.mMenFileExport.Name = "mMenFileExport"
        Me.mMenFileExport.Size = New System.Drawing.Size(281, 22)
        Me.mMenFileExport.Text = "&Export to File..."
        '
        'mMenFileSep4
        '
        Me.mMenFileSep4.Name = "mMenFileSep4"
        Me.mMenFileSep4.Size = New System.Drawing.Size(278, 6)
        '
        'mMenFileExit
        '
        Me.mMenFileExit.Image = Global.dRemote.My.Resources.Resources.Quit
        Me.mMenFileExit.Name = "mMenFileExit"
        Me.mMenFileExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.mMenFileExit.Size = New System.Drawing.Size(281, 22)
        Me.mMenFileExit.Text = "Exit"
        '
        'mMenView
        '
        Me.mMenView.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mMenViewAddConnectionPanel, Me.mMenViewConnectionPanels, Me.mMenViewSep1, Me.mMenViewConnections, Me.mMenViewConfig, Me.mMenViewSessions, Me.mMenViewErrorsAndInfos, Me.mMenViewScreenshotManager, Me.ToolStripSeparator1, Me.mMenViewJumpTo, Me.mMenViewResetLayout, Me.mMenViewSep2, Me.mMenViewQuickConnectToolbar, Me.mMenViewExtAppsToolbar, Me.mMenViewSep3, Me.mMenViewFullscreen})
        Me.mMenView.Name = "mMenView"
        Me.mMenView.Size = New System.Drawing.Size(44, 20)
        Me.mMenView.Text = "&View"
        '
        'mMenViewAddConnectionPanel
        '
        Me.mMenViewAddConnectionPanel.Image = Global.dRemote.My.Resources.Resources.Panel_Add
        Me.mMenViewAddConnectionPanel.Name = "mMenViewAddConnectionPanel"
        Me.mMenViewAddConnectionPanel.Size = New System.Drawing.Size(227, 22)
        Me.mMenViewAddConnectionPanel.Text = "Add Connection Panel"
        '
        'mMenViewConnectionPanels
        '
        Me.mMenViewConnectionPanels.Image = Global.dRemote.My.Resources.Resources.Panels
        Me.mMenViewConnectionPanels.Name = "mMenViewConnectionPanels"
        Me.mMenViewConnectionPanels.Size = New System.Drawing.Size(227, 22)
        Me.mMenViewConnectionPanels.Text = "Connection Panels"
        '
        'mMenViewSep1
        '
        Me.mMenViewSep1.Name = "mMenViewSep1"
        Me.mMenViewSep1.Size = New System.Drawing.Size(224, 6)
        '
        'mMenViewConnections
        '
        Me.mMenViewConnections.Checked = True
        Me.mMenViewConnections.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mMenViewConnections.Image = Global.dRemote.My.Resources.Resources.Root
        Me.mMenViewConnections.Name = "mMenViewConnections"
        Me.mMenViewConnections.Size = New System.Drawing.Size(227, 22)
        Me.mMenViewConnections.Text = "Connections"
        '
        'mMenViewConfig
        '
        Me.mMenViewConfig.Checked = True
        Me.mMenViewConfig.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mMenViewConfig.Image = Global.dRemote.My.Resources.Resources.cog
        Me.mMenViewConfig.Name = "mMenViewConfig"
        Me.mMenViewConfig.Size = New System.Drawing.Size(227, 22)
        Me.mMenViewConfig.Text = "Config"
        '
        'mMenViewSessions
        '
        Me.mMenViewSessions.Checked = True
        Me.mMenViewSessions.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mMenViewSessions.Image = CType(resources.GetObject("mMenViewSessions.Image"), System.Drawing.Image)
        Me.mMenViewSessions.Name = "mMenViewSessions"
        Me.mMenViewSessions.Size = New System.Drawing.Size(227, 22)
        Me.mMenViewSessions.Text = "Sessions"
        '
        'mMenViewErrorsAndInfos
        '
        Me.mMenViewErrorsAndInfos.Checked = True
        Me.mMenViewErrorsAndInfos.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mMenViewErrorsAndInfos.Image = Global.dRemote.My.Resources.Resources.ErrorsAndInfos
        Me.mMenViewErrorsAndInfos.Name = "mMenViewErrorsAndInfos"
        Me.mMenViewErrorsAndInfos.Size = New System.Drawing.Size(227, 22)
        Me.mMenViewErrorsAndInfos.Text = "Errors and Infos"
        '
        'mMenViewScreenshotManager
        '
        Me.mMenViewScreenshotManager.Image = CType(resources.GetObject("mMenViewScreenshotManager.Image"), System.Drawing.Image)
        Me.mMenViewScreenshotManager.Name = "mMenViewScreenshotManager"
        Me.mMenViewScreenshotManager.Size = New System.Drawing.Size(227, 22)
        Me.mMenViewScreenshotManager.Text = "Screenshot Manager"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(224, 6)
        '
        'mMenViewJumpTo
        '
        Me.mMenViewJumpTo.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mMenViewJumpToConnectionsConfig, Me.mMenViewJumpToSessionsScreenshots, Me.mMenViewJumpToErrorsInfos})
        Me.mMenViewJumpTo.Image = Global.dRemote.My.Resources.Resources.JumpTo
        Me.mMenViewJumpTo.Name = "mMenViewJumpTo"
        Me.mMenViewJumpTo.Size = New System.Drawing.Size(227, 22)
        Me.mMenViewJumpTo.Text = "Jump To"
        '
        'mMenViewJumpToConnectionsConfig
        '
        Me.mMenViewJumpToConnectionsConfig.Image = Global.dRemote.My.Resources.Resources.Root
        Me.mMenViewJumpToConnectionsConfig.Name = "mMenViewJumpToConnectionsConfig"
        Me.mMenViewJumpToConnectionsConfig.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.mMenViewJumpToConnectionsConfig.Size = New System.Drawing.Size(260, 22)
        Me.mMenViewJumpToConnectionsConfig.Text = "Connections && Config"
        '
        'mMenViewJumpToSessionsScreenshots
        '
        Me.mMenViewJumpToSessionsScreenshots.Image = Global.dRemote.My.Resources.Resources.Sessions
        Me.mMenViewJumpToSessionsScreenshots.Name = "mMenViewJumpToSessionsScreenshots"
        Me.mMenViewJumpToSessionsScreenshots.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mMenViewJumpToSessionsScreenshots.Size = New System.Drawing.Size(260, 22)
        Me.mMenViewJumpToSessionsScreenshots.Text = "Sessions && Screenshots"
        '
        'mMenViewJumpToErrorsInfos
        '
        Me.mMenViewJumpToErrorsInfos.Image = Global.dRemote.My.Resources.Resources.InformationSmall
        Me.mMenViewJumpToErrorsInfos.Name = "mMenViewJumpToErrorsInfos"
        Me.mMenViewJumpToErrorsInfos.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.mMenViewJumpToErrorsInfos.Size = New System.Drawing.Size(260, 22)
        Me.mMenViewJumpToErrorsInfos.Text = "Errors && Infos"
        '
        'mMenViewResetLayout
        '
        Me.mMenViewResetLayout.Image = Global.dRemote.My.Resources.Resources.application_side_tree
        Me.mMenViewResetLayout.Name = "mMenViewResetLayout"
        Me.mMenViewResetLayout.Size = New System.Drawing.Size(227, 22)
        Me.mMenViewResetLayout.Text = "Reset Layout"
        '
        'mMenViewSep2
        '
        Me.mMenViewSep2.Name = "mMenViewSep2"
        Me.mMenViewSep2.Size = New System.Drawing.Size(224, 6)
        '
        'mMenViewQuickConnectToolbar
        '
        Me.mMenViewQuickConnectToolbar.Image = Global.dRemote.My.Resources.Resources.Play_Quick
        Me.mMenViewQuickConnectToolbar.Name = "mMenViewQuickConnectToolbar"
        Me.mMenViewQuickConnectToolbar.Size = New System.Drawing.Size(227, 22)
        Me.mMenViewQuickConnectToolbar.Text = "Quick Connect Toolbar"
        '
        'mMenViewExtAppsToolbar
        '
        Me.mMenViewExtAppsToolbar.Image = Global.dRemote.My.Resources.Resources.ExtApp
        Me.mMenViewExtAppsToolbar.Name = "mMenViewExtAppsToolbar"
        Me.mMenViewExtAppsToolbar.Size = New System.Drawing.Size(227, 22)
        Me.mMenViewExtAppsToolbar.Text = "External Applications Toolbar"
        '
        'mMenViewSep3
        '
        Me.mMenViewSep3.Name = "mMenViewSep3"
        Me.mMenViewSep3.Size = New System.Drawing.Size(224, 6)
        '
        'mMenViewFullscreen
        '
        Me.mMenViewFullscreen.Image = Global.dRemote.My.Resources.Resources.arrow_out
        Me.mMenViewFullscreen.Name = "mMenViewFullscreen"
        Me.mMenViewFullscreen.ShortcutKeys = System.Windows.Forms.Keys.F11
        Me.mMenViewFullscreen.Size = New System.Drawing.Size(227, 22)
        Me.mMenViewFullscreen.Text = "Full Screen"
        '
        'mMenTools
        '
        Me.mMenTools.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mMenToolsSSHTransfer, Me.mMenToolsUVNCSC, Me.mMenToolsExternalApps, Me.mMenToolsPortScan, Me.mMenToolsSep1, Me.mMenToolsComponentsCheck, Me.mMenToolsOptions})
        Me.mMenTools.Name = "mMenTools"
        Me.mMenTools.Size = New System.Drawing.Size(47, 20)
        Me.mMenTools.Text = "&Tools"
        '
        'mMenToolsSSHTransfer
        '
        Me.mMenToolsSSHTransfer.Image = Global.dRemote.My.Resources.Resources.SSHTransfer
        Me.mMenToolsSSHTransfer.Name = "mMenToolsSSHTransfer"
        Me.mMenToolsSSHTransfer.Size = New System.Drawing.Size(184, 22)
        Me.mMenToolsSSHTransfer.Text = "SSH File Transfer"
        '
        'mMenToolsUVNCSC
        '
        Me.mMenToolsUVNCSC.Image = Global.dRemote.My.Resources.Resources.UVNC_SC
        Me.mMenToolsUVNCSC.Name = "mMenToolsUVNCSC"
        Me.mMenToolsUVNCSC.Size = New System.Drawing.Size(184, 22)
        Me.mMenToolsUVNCSC.Text = "UltraVNC SingleClick"
        Me.mMenToolsUVNCSC.Visible = False
        '
        'mMenToolsExternalApps
        '
        Me.mMenToolsExternalApps.Image = Global.dRemote.My.Resources.Resources.ExtApp
        Me.mMenToolsExternalApps.Name = "mMenToolsExternalApps"
        Me.mMenToolsExternalApps.Size = New System.Drawing.Size(184, 22)
        Me.mMenToolsExternalApps.Text = "External Applications"
        '
        'mMenToolsPortScan
        '
        Me.mMenToolsPortScan.Image = Global.dRemote.My.Resources.Resources.PortScan
        Me.mMenToolsPortScan.Name = "mMenToolsPortScan"
        Me.mMenToolsPortScan.Size = New System.Drawing.Size(184, 22)
        Me.mMenToolsPortScan.Text = "Port Scan"
        '
        'mMenToolsSep1
        '
        Me.mMenToolsSep1.Name = "mMenToolsSep1"
        Me.mMenToolsSep1.Size = New System.Drawing.Size(181, 6)
        '
        'mMenToolsComponentsCheck
        '
        Me.mMenToolsComponentsCheck.Image = Global.dRemote.My.Resources.Resources.cog_error
        Me.mMenToolsComponentsCheck.Name = "mMenToolsComponentsCheck"
        Me.mMenToolsComponentsCheck.Size = New System.Drawing.Size(184, 22)
        Me.mMenToolsComponentsCheck.Text = "Components Check"
        '
        'mMenToolsOptions
        '
        Me.mMenToolsOptions.Image = CType(resources.GetObject("mMenToolsOptions.Image"), System.Drawing.Image)
        Me.mMenToolsOptions.Name = "mMenToolsOptions"
        Me.mMenToolsOptions.Size = New System.Drawing.Size(184, 22)
        Me.mMenToolsOptions.Text = "Options"
        '
        'mMenInfo
        '
        Me.mMenInfo.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mMenInfoHelp, Me.mMenInfoSep1, Me.mMenInfoWebsite, Me.mMenInfoDonate, Me.mMenInfoForum, Me.mMenInfoBugReport, Me.ToolStripSeparator2, Me.mMenToolsUpdate, Me.mMenInfoSep2, Me.mMenInfoAbout})
        Me.mMenInfo.Name = "mMenInfo"
        Me.mMenInfo.Size = New System.Drawing.Size(44, 20)
        Me.mMenInfo.Text = "&Help"
        Me.mMenInfo.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'mMenInfoHelp
        '
        Me.mMenInfoHelp.Image = CType(resources.GetObject("mMenInfoHelp.Image"), System.Drawing.Image)
        Me.mMenInfoHelp.Name = "mMenInfoHelp"
        Me.mMenInfoHelp.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.mMenInfoHelp.Size = New System.Drawing.Size(171, 22)
        Me.mMenInfoHelp.Text = "dRemote Help"
        '
        'mMenInfoSep1
        '
        Me.mMenInfoSep1.Name = "mMenInfoSep1"
        Me.mMenInfoSep1.Size = New System.Drawing.Size(168, 6)
        '
        'mMenInfoWebsite
        '
        Me.mMenInfoWebsite.Image = CType(resources.GetObject("mMenInfoWebsite.Image"), System.Drawing.Image)
        Me.mMenInfoWebsite.Name = "mMenInfoWebsite"
        Me.mMenInfoWebsite.Size = New System.Drawing.Size(171, 22)
        Me.mMenInfoWebsite.Text = "Website"
        '
        'mMenInfoDonate
        '
        Me.mMenInfoDonate.Image = Global.dRemote.My.Resources.Resources.Donate
        Me.mMenInfoDonate.Name = "mMenInfoDonate"
        Me.mMenInfoDonate.Size = New System.Drawing.Size(171, 22)
        Me.mMenInfoDonate.Text = "Donate"
        '
        'mMenInfoForum
        '
        Me.mMenInfoForum.Image = Global.dRemote.My.Resources.Resources.user_comment
        Me.mMenInfoForum.Name = "mMenInfoForum"
        Me.mMenInfoForum.Size = New System.Drawing.Size(171, 22)
        Me.mMenInfoForum.Text = "Support Forum"
        '
        'mMenInfoBugReport
        '
        Me.mMenInfoBugReport.Image = Global.dRemote.My.Resources.Resources.Bug
        Me.mMenInfoBugReport.Name = "mMenInfoBugReport"
        Me.mMenInfoBugReport.Size = New System.Drawing.Size(171, 22)
        Me.mMenInfoBugReport.Text = "Report a Bug"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(168, 6)
        '
        'mMenToolsUpdate
        '
        Me.mMenToolsUpdate.Image = Global.dRemote.My.Resources.Resources.Update
        Me.mMenToolsUpdate.Name = "mMenToolsUpdate"
        Me.mMenToolsUpdate.Size = New System.Drawing.Size(171, 22)
        Me.mMenToolsUpdate.Text = "Check for Updates"
        '
        'mMenInfoSep2
        '
        Me.mMenInfoSep2.Name = "mMenInfoSep2"
        Me.mMenInfoSep2.Size = New System.Drawing.Size(168, 6)
        '
        'mMenInfoAbout
        '
        Me.mMenInfoAbout.Image = Global.dRemote.My.Resources.Resources.mRemote
        Me.mMenInfoAbout.Name = "mMenInfoAbout"
        Me.mMenInfoAbout.Size = New System.Drawing.Size(171, 22)
        Me.mMenInfoAbout.Text = "About dRemote"
        '
        'DRemoteV2BetaToolStripMenuItem
        '
        Me.DRemoteV2BetaToolStripMenuItem.Name = "DRemoteV2BetaToolStripMenuItem"
        Me.DRemoteV2BetaToolStripMenuItem.Size = New System.Drawing.Size(109, 20)
        Me.DRemoteV2BetaToolStripMenuItem.Text = "dRemoteV2 Beta!"
        '
        'mMenSep3
        '
        Me.mMenSep3.Name = "mMenSep3"
        Me.mMenSep3.Size = New System.Drawing.Size(211, 6)
        '
        'lblQuickConnect
        '
        Me.lblQuickConnect.Name = "lblQuickConnect"
        Me.lblQuickConnect.Size = New System.Drawing.Size(55, 22)
        Me.lblQuickConnect.Text = "&Connect:"
        '
        'cmbQuickConnect
        '
        Me.cmbQuickConnect.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbQuickConnect.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbQuickConnect.Margin = New System.Windows.Forms.Padding(1, 0, 3, 0)
        Me.cmbQuickConnect.Name = "cmbQuickConnect"
        Me.cmbQuickConnect.Size = New System.Drawing.Size(200, 25)
        '
        'tsContainer
        '
        '
        'tsContainer.BottomToolStripPanel
        '
        Me.tsContainer.BottomToolStripPanel.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        '
        'tsContainer.ContentPanel
        '
        Me.tsContainer.ContentPanel.Controls.Add(Me.pnlDock)
        Me.tsContainer.ContentPanel.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.tsContainer.ContentPanel.Size = New System.Drawing.Size(842, 449)
        Me.tsContainer.Dock = System.Windows.Forms.DockStyle.Fill
        '
        'tsContainer.LeftToolStripPanel
        '
        Me.tsContainer.LeftToolStripPanel.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.tsContainer.Location = New System.Drawing.Point(0, 0)
        Me.tsContainer.Name = "tsContainer"
        '
        'tsContainer.RightToolStripPanel
        '
        Me.tsContainer.RightToolStripPanel.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.tsContainer.Size = New System.Drawing.Size(842, 523)
        Me.tsContainer.TabIndex = 17
        Me.tsContainer.Text = "ToolStripContainer1"
        '
        'tsContainer.TopToolStripPanel
        '
        Me.tsContainer.TopToolStripPanel.Controls.Add(Me.msMain)
        Me.tsContainer.TopToolStripPanel.Controls.Add(Me.tsQuickConnect)
        Me.tsContainer.TopToolStripPanel.Controls.Add(Me.tsExternalTools)
        Me.tsContainer.TopToolStripPanel.Controls.Add(Me.ToolStrip1)
        Me.tsContainer.TopToolStripPanel.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        '
        'tsQuickConnect
        '
        Me.tsQuickConnect.Dock = System.Windows.Forms.DockStyle.None
        Me.tsQuickConnect.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblQuickConnect, Me.cmbQuickConnect, Me.btnQuickConnect, Me.btnConnections})
        Me.tsQuickConnect.Location = New System.Drawing.Point(3, 24)
        Me.tsQuickConnect.MaximumSize = New System.Drawing.Size(0, 25)
        Me.tsQuickConnect.Name = "tsQuickConnect"
        Me.tsQuickConnect.Size = New System.Drawing.Size(418, 25)
        Me.tsQuickConnect.TabIndex = 18
        '
        'btnQuickConnect
        '
        Me.btnQuickConnect.DropDown = Me.mnuQuickConnectProtocol
        Me.btnQuickConnect.Image = Global.dRemote.My.Resources.Resources.Play_Quick
        Me.btnQuickConnect.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnQuickConnect.Margin = New System.Windows.Forms.Padding(0, 1, 3, 2)
        Me.btnQuickConnect.Name = "btnQuickConnect"
        Me.btnQuickConnect.Size = New System.Drawing.Size(84, 22)
        Me.btnQuickConnect.Text = "Connect"
        '
        'mnuQuickConnectProtocol
        '
        Me.mnuQuickConnectProtocol.Name = "mnuQuickConnectProtocol"
        Me.mnuQuickConnectProtocol.OwnerItem = Me.btnQuickConnect
        Me.mnuQuickConnectProtocol.ShowCheckMargin = True
        Me.mnuQuickConnectProtocol.ShowImageMargin = False
        Me.mnuQuickConnectProtocol.Size = New System.Drawing.Size(61, 4)
        '
        'btnConnections
        '
        Me.btnConnections.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnConnections.DropDown = Me.mnuConnections
        Me.btnConnections.Image = Global.dRemote.My.Resources.Resources.Root
        Me.btnConnections.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnConnections.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnConnections.Name = "btnConnections"
        Me.btnConnections.Size = New System.Drawing.Size(29, 22)
        Me.btnConnections.Text = "Connections"
        '
        'mnuConnections
        '
        Me.mnuConnections.Name = "mnuConnections"
        Me.mnuConnections.OwnerItem = Me.btnConnections
        Me.mnuConnections.Size = New System.Drawing.Size(61, 4)
        '
        'tsExternalTools
        '
        Me.tsExternalTools.ContextMenuStrip = Me.cMenExtAppsToolbar
        Me.tsExternalTools.Dock = System.Windows.Forms.DockStyle.None
        Me.tsExternalTools.Location = New System.Drawing.Point(39, 49)
        Me.tsExternalTools.MaximumSize = New System.Drawing.Size(0, 25)
        Me.tsExternalTools.Name = "tsExternalTools"
        Me.tsExternalTools.Size = New System.Drawing.Size(111, 25)
        Me.tsExternalTools.TabIndex = 17
        '
        'cMenExtAppsToolbar
        '
        Me.cMenExtAppsToolbar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cMenToolbarShowText})
        Me.cMenExtAppsToolbar.Name = "cMenToolbar"
        Me.cMenExtAppsToolbar.Size = New System.Drawing.Size(128, 26)
        '
        'cMenToolbarShowText
        '
        Me.cMenToolbarShowText.Checked = True
        Me.cMenToolbarShowText.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cMenToolbarShowText.Name = "cMenToolbarShowText"
        Me.cMenToolbarShowText.Size = New System.Drawing.Size(127, 22)
        Me.cMenToolbarShowText.Text = "Show Text"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3, Me.ToolStripSplitButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 74)
        Me.ToolStrip1.MaximumSize = New System.Drawing.Size(0, 25)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(0, 25)
        Me.ToolStrip1.TabIndex = 19
        Me.ToolStrip1.Visible = False
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = Global.dRemote.My.Resources.Resources.Play
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(72, 22)
        Me.ToolStripButton1.Text = "Connect"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = Global.dRemote.My.Resources.Resources.Screenshot
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(85, 22)
        Me.ToolStripButton2.Text = "Screenshot"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Image = Global.dRemote.My.Resources.Resources.Refresh
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(66, 22)
        Me.ToolStripButton3.Text = "Refresh"
        '
        'ToolStripSplitButton1
        '
        Me.ToolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripSplitButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2})
        Me.ToolStripSplitButton1.Image = Global.dRemote.My.Resources.Resources.Keyboard
        Me.ToolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSplitButton1.Name = "ToolStripSplitButton1"
        Me.ToolStripSplitButton1.Size = New System.Drawing.Size(29, 22)
        Me.ToolStripSplitButton1.Text = "Special Keys"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(135, 22)
        Me.ToolStripMenuItem1.Text = "Ctrl-Alt-Del"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(135, 22)
        Me.ToolStripMenuItem2.Text = "Ctrl-Esc"
        '
        'tmrAutoSave
        '
        Me.tmrAutoSave.Interval = 10000
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(842, 523)
        Me.Controls.Add(Me.tsContainer)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.msMain
        Me.Name = "frmMain"
        Me.Opacity = 0R
        Me.Text = "dRemote"
        Me.msMain.ResumeLayout(False)
        Me.msMain.PerformLayout()
        Me.tsContainer.ContentPanel.ResumeLayout(False)
        Me.tsContainer.TopToolStripPanel.ResumeLayout(False)
        Me.tsContainer.TopToolStripPanel.PerformLayout()
        Me.tsContainer.ResumeLayout(False)
        Me.tsContainer.PerformLayout()
        Me.tsQuickConnect.ResumeLayout(False)
        Me.tsQuickConnect.PerformLayout()
        Me.cMenExtAppsToolbar.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlDock As WeifenLuo.WinFormsUI.Docking.DockPanel
    Friend WithEvents msMain As System.Windows.Forms.MenuStrip
    Friend WithEvents mMenFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mMenView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mMenTools As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblQuickConnect As System.Windows.Forms.ToolStripLabel
    Friend WithEvents mMenInfo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mMenFileNew As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mMenFileLoad As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mMenFileSave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mMenFileSaveAs As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mMenFileSep1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mMenFileExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mMenToolsSep1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mMenToolsOptions As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mMenInfoHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mMenInfoWebsite As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mMenInfoSep1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mMenInfoAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mMenViewConnectionPanels As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mMenViewSep1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mMenViewSessions As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mMenViewConnections As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mMenViewConfig As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mMenViewErrorsAndInfos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mMenViewScreenshotManager As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mMenViewAddConnectionPanel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmbQuickConnect As Controls.QuickConnectComboBox
    Friend WithEvents mMenViewSep2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mMenViewFullscreen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mMenToolsSSHTransfer As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsContainer As System.Windows.Forms.ToolStripContainer
    Friend WithEvents mMenToolsExternalApps As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tmrAutoSave As System.Windows.Forms.Timer
    Friend WithEvents tsExternalTools As System.Windows.Forms.ToolStrip
    Friend WithEvents mMenViewExtAppsToolbar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cMenExtAppsToolbar As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cMenToolbarShowText As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mMenToolsPortScan As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsQuickConnect As System.Windows.Forms.ToolStrip
    Friend WithEvents mMenViewQuickConnectToolbar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mMenSep3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mMenInfoDonate As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mMenViewSep3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnQuickConnect As Controls.ToolStripSplitButton
    Friend WithEvents mMenViewJumpTo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mMenViewJumpToConnectionsConfig As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mMenViewJumpToSessionsScreenshots As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mMenViewJumpToErrorsInfos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mMenToolsUVNCSC As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mMenToolsComponentsCheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mMenInfoSep2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mMenInfoBugReport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mMenInfoForum As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mMenToolsUpdate As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mMenViewResetLayout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mMenFileDuplicate As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mMenFileSep2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mMenFileNewConnection As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mMenFileNewFolder As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mMenFileSep3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mMenFileDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mMenFileRename As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mMenFileSep4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSplitButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuQuickConnectProtocol As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents btnConnections As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents mnuConnections As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mMenFileExport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mMenFileImportFromFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mMenFileImportFromActiveDirectory As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mMenFileImportFromPortScan As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mMenFileImport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DRemoteV2BetaToolStripMenuItem As ToolStripMenuItem
End Class
