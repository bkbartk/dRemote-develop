Imports WeifenLuo.WinFormsUI.Docking
Namespace Forms
    Public Class frmGroupTabs
        Inherits DockContent

        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGroupTabs))
            Me.TabPage2 = New System.Windows.Forms.TabPage()
            Me.TabPage1 = New System.Windows.Forms.TabPage()
            Me.tcControl = New System.Windows.Forms.TabControl()
            Me.tcControl.SuspendLayout()
            Me.SuspendLayout()
            '
            'TabPage2
            '
            Me.TabPage2.Location = New System.Drawing.Point(4, 22)
            Me.TabPage2.Name = "TabPage2"
            Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage2.Size = New System.Drawing.Size(276, 235)
            Me.TabPage2.TabIndex = 1
            Me.TabPage2.Text = "TabPage2"
            Me.TabPage2.UseVisualStyleBackColor = True
            '
            'TabPage1
            '
            Me.TabPage1.Location = New System.Drawing.Point(4, 22)
            Me.TabPage1.Name = "TabPage1"
            Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
            Me.TabPage1.Size = New System.Drawing.Size(277, 233)
            Me.TabPage1.TabIndex = 0
            Me.TabPage1.Text = "TabPage1"
            Me.TabPage1.UseVisualStyleBackColor = True
            '
            'tcControl
            '
            Me.tcControl.Controls.Add(Me.TabPage1)
            Me.tcControl.Controls.Add(Me.TabPage2)
            Me.tcControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tcControl.Location = New System.Drawing.Point(0, 0)
            Me.tcControl.Name = "tcControl"
            Me.tcControl.SelectedIndex = 0
            Me.tcControl.Size = New System.Drawing.Size(285, 259)
            Me.tcControl.TabIndex = 6
            '
            'frmGroupTabs
            '
            Me.ClientSize = New System.Drawing.Size(285, 259)
            Me.Controls.Add(Me.tcControl)
            Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.IsMdiContainer = True
            Me.Name = "frmGroupTabs"
            Me.Text = "New Group Tab"
            Me.tcControl.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

        Private Sub frmGroupTabs_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        End Sub

        Friend WithEvents TabPage2 As TabPage
        Friend WithEvents TabPage1 As TabPage
        Friend WithEvents tcControl As TabControl
    End Class
End Namespace