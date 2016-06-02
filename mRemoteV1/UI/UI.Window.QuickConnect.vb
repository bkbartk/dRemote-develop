Imports WeifenLuo.WinFormsUI.Docking
Imports System.IO
Imports dRemote.App.Runtime
Imports System.Reflection

Namespace UI
    Namespace Window
        Public Class QuickConnect
            Inherits UI.Window.Base

            Friend WithEvents tsQuickConnect As ToolStrip
            Friend WithEvents lblQuickConnect As ToolStripLabel
            Friend WithEvents cmbQuickConnect As Controls.QuickConnectComboBox
            Friend WithEvents btnQuickConnect As Controls.ToolStripSplitButton
            Friend WithEvents mnuQuickConnectProtocol As ContextMenuStrip
            Private components As System.ComponentModel.IContainer
            Friend WithEvents btnConnections As ToolStripDropDownButton

#Region "Form Init"

            Private Sub InitializeComponent()
                Me.components = New System.ComponentModel.Container()
                Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(QuickConnect))
                Me.tsQuickConnect = New System.Windows.Forms.ToolStrip()
                Me.lblQuickConnect = New System.Windows.Forms.ToolStripLabel()
                Me.cmbQuickConnect = New dRemote.Controls.QuickConnectComboBox()
                Me.btnQuickConnect = New dRemote.Controls.ToolStripSplitButton()
                Me.mnuQuickConnectProtocol = New System.Windows.Forms.ContextMenuStrip(Me.components)
                Me.btnConnections = New System.Windows.Forms.ToolStripDropDownButton()
                Me.tsQuickConnect.SuspendLayout()
                Me.SuspendLayout()
                '
                'tsQuickConnect
                '
                Me.tsQuickConnect.Dock = System.Windows.Forms.DockStyle.None
                Me.tsQuickConnect.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblQuickConnect, Me.cmbQuickConnect, Me.btnQuickConnect, Me.btnConnections})
                Me.tsQuickConnect.Location = New System.Drawing.Point(0, 0)
                Me.tsQuickConnect.MaximumSize = New System.Drawing.Size(0, 25)
                Me.tsQuickConnect.Name = "tsQuickConnect"
                Me.tsQuickConnect.Size = New System.Drawing.Size(418, 25)
                Me.tsQuickConnect.TabIndex = 19
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
                Me.mnuQuickConnectProtocol.Size = New System.Drawing.Size(153, 26)
                '
                'btnConnections
                '
                Me.btnConnections.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
                Me.btnConnections.Image = Global.dRemote.My.Resources.Resources.Root
                Me.btnConnections.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
                Me.btnConnections.ImageTransparentColor = System.Drawing.Color.Magenta
                Me.btnConnections.Name = "btnConnections"
                Me.btnConnections.Size = New System.Drawing.Size(29, 22)
                Me.btnConnections.Text = "Connections"
                '
                'QuickConnect
                '
                Me.BackColor = System.Drawing.SystemColors.Control
                Me.ClientSize = New System.Drawing.Size(408, 22)
                Me.Controls.Add(Me.tsQuickConnect)
                Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                Me.ForeColor = System.Drawing.SystemColors.ControlText
                Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
                Me.HideOnClose = True
                Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
                Me.MaximumSize = New System.Drawing.Size(20000, 10000)
                Me.Name = "QuickConnect"
                Me.TabText = "QuickConnect"
                Me.Text = "QuickConnect"
                Me.tsQuickConnect.ResumeLayout(False)
                Me.tsQuickConnect.PerformLayout()
                Me.ResumeLayout(False)
                Me.PerformLayout()

            End Sub
#End Region


            Public Sub New()
                Me.WindowType = Type.About
                'Me.DockPnl = Panel
                Me.InitializeComponent()
                App.Runtime.FontOverride(Me)
            End Sub
            Public Sub New(ByVal Panel As DockContent)
                Me.WindowType = Type.About
                Me.DockPnl = Panel
                Me.InitializeComponent()
                App.Runtime.FontOverride(Me)
            End Sub

            Private Sub QuickConnect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
                PopulateQuickConnectProtocolMenu()
            End Sub

            Private Sub PopulateQuickConnectProtocolMenu()
                Try
                    mnuQuickConnectProtocol.Items.Clear()
                    For Each fieldInfo As FieldInfo In GetType(dRemote.Connection.Protocol.Protocols).GetFields
                        If Not (fieldInfo.Name = "value__" Or fieldInfo.Name = "IntApp") Then
                            Dim menuItem As New ToolStripMenuItem(fieldInfo.Name)
                            If fieldInfo.Name = My.Settings.QuickConnectProtocol Then
                                menuItem.Checked = True
                                btnQuickConnect.Text = My.Settings.QuickConnectProtocol
                            End If
                            mnuQuickConnectProtocol.Items.Add(menuItem)
                        End If
                    Next
                Catch ex As Exception
                    MessageCollector.AddExceptionMessage("PopulateQuickConnectProtocolMenu() failed.", ex, Messages.MessageClass.ErrorMsg, True)
                End Try
            End Sub
            Private Sub lblQuickConnect_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles lblQuickConnect.Click
                cmbQuickConnect.Focus()
            End Sub

            Private Sub cmbQuickConnect_ConnectRequested(ByVal sender As Object, ByVal e As Controls.QuickConnectComboBox.ConnectRequestedEventArgs) Handles cmbQuickConnect.ConnectRequested
                btnQuickConnect_ButtonClick(sender, e)
            End Sub
            Private Sub btnQuickConnect_ButtonClick(sender As Object, e As EventArgs) Handles btnQuickConnect.ButtonClick
                Try
                    Dim connectionInfo As dRemote.Connection.Info = CreateQuickConnect(cmbQuickConnect.Text.Trim(), dRemote.Connection.Protocol.Converter.StringToProtocol(My.Settings.QuickConnectProtocol))
                    If connectionInfo Is Nothing Then
                        cmbQuickConnect.Focus()
                        Return
                    End If

                    cmbQuickConnect.Add(connectionInfo)
                    OpenConnectionV2(connectionInfo, sender, dRemote.Connection.Info.Force.DoNotJump)
                Catch ex As Exception
                    MessageCollector.AddExceptionMessage("btnQuickConnect_ButtonClick() failed.", ex, Messages.MessageClass.ErrorMsg, True)
                End Try
            End Sub
            Private Sub btnQuickConnect_DropDownItemClicked(sender As System.Object, e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles btnQuickConnect.DropDownItemClicked
                SetQuickConnectProtocol(e.ClickedItem.Text)
            End Sub
            Private Sub SetQuickConnectProtocol(ByVal protocol As String)
                My.Settings.QuickConnectProtocol = protocol
                btnQuickConnect.Text = protocol
                For Each menuItem As ToolStripMenuItem In mnuQuickConnectProtocol.Items
                    If menuItem.Text = protocol Then
                        menuItem.Checked = True
                    Else
                        menuItem.Checked = False
                    End If
                Next
            End Sub
            Private Sub btnConnections_Click(sender As Object, e As EventArgs) Handles btnConnections.Click
                btnConnections.DropDownItems.Clear()

                For Each treeNode As TreeNode In Windows.treeForm.tvConnections.Nodes
                    AddNodeToMenu(treeNode.Nodes, btnConnections)
                Next
            End Sub
            Private Shared Sub AddNodeToMenu(ByVal treeNodeCollection As TreeNodeCollection, ByVal toolStripMenuItem As ToolStripDropDownItem)
                Try
                    For Each treeNode As TreeNode In treeNodeCollection
                        Dim menuItem As New ToolStripMenuItem()
                        menuItem.Text = treeNode.Text
                        menuItem.Tag = treeNode

                        If dRemote.Tree.Node.GetNodeType(treeNode) = dRemote.Tree.Node.Type.Container Then
                            menuItem.Image = My.Resources.Folder
                            menuItem.Tag = treeNode.Tag

                            toolStripMenuItem.DropDownItems.Add(menuItem)
                            AddNodeToMenu(treeNode.Nodes, menuItem)
                        ElseIf dRemote.Tree.Node.GetNodeType(treeNode) = dRemote.Tree.Node.Type.Connection Or
                               dRemote.Tree.Node.GetNodeType(treeNode) = dRemote.Tree.Node.Type.PuttySession Then
                            menuItem.Image = Windows.treeForm.imgListTree.Images(treeNode.ImageIndex)
                            menuItem.Tag = treeNode.Tag

                            toolStripMenuItem.DropDownItems.Add(menuItem)
                        End If

                        AddHandler menuItem.MouseUp, AddressOf ConnectionsMenuItem_MouseUp
                    Next
                Catch ex As Exception
                    MessageCollector.AddExceptionMessage("frmMain.AddNodeToMenu() failed", ex, Messages.MessageClass.ErrorMsg, True)
                End Try
            End Sub
            Private Shared Sub ConnectionsMenuItem_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
                If e.Button = MouseButtons.Left Then
                    If TypeOf sender.Tag Is dRemote.Connection.Info Then
                        OpenConnectionV2(sender.Tag, sender)
                    End If
                End If
            End Sub

        End Class
    End Namespace
End Namespace