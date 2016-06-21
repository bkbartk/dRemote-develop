Namespace Forms.OptionsPages
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class AdvancedPage
        Inherits OptionsPage

        'UserControl overrides dispose to clean up the component list.
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdvancedPage))
            Me.chkAutomaticallyGetSessionInfo = New System.Windows.Forms.CheckBox()
            Me.lblXulRunnerPath = New System.Windows.Forms.Label()
            Me.lblMaximumPuttyWaitTime = New System.Windows.Forms.Label()
            Me.chkEncryptCompleteFile = New System.Windows.Forms.CheckBox()
            Me.chkAutomaticReconnect = New System.Windows.Forms.CheckBox()
            Me.btnBrowseXulRunnerPath = New System.Windows.Forms.Button()
            Me.numPuttyWaitTime = New System.Windows.Forms.NumericUpDown()
            Me.chkUseCustomPuttyPath = New System.Windows.Forms.CheckBox()
            Me.lblConfigurePuttySessions = New System.Windows.Forms.Label()
            Me.txtXULrunnerPath = New System.Windows.Forms.TextBox()
            Me.numUVNCSCPort = New System.Windows.Forms.NumericUpDown()
            Me.txtCustomPuttyPath = New System.Windows.Forms.TextBox()
            Me.btnLaunchPutty = New System.Windows.Forms.Button()
            Me.lblUVNCSCPort = New System.Windows.Forms.Label()
            Me.lblSeconds = New System.Windows.Forms.Label()
            Me.btnBrowseCustomPuttyPath = New System.Windows.Forms.Button()
            Me.txtExtraPuttyParameters = New System.Windows.Forms.TextBox()
            Me.lblExtraPuttyParameters = New System.Windows.Forms.Label()
            Me.chkmRemoteNGCompatible = New System.Windows.Forms.CheckBox()
            CType(Me.numPuttyWaitTime, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.numUVNCSCPort, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'chkAutomaticallyGetSessionInfo
            '
            Me.chkAutomaticallyGetSessionInfo.AutoSize = True
            Me.chkAutomaticallyGetSessionInfo.Location = New System.Drawing.Point(3, 45)
            Me.chkAutomaticallyGetSessionInfo.Name = "chkAutomaticallyGetSessionInfo"
            Me.chkAutomaticallyGetSessionInfo.Size = New System.Drawing.Size(198, 17)
            Me.chkAutomaticallyGetSessionInfo.TabIndex = 19
            Me.chkAutomaticallyGetSessionInfo.Text = "Automatically get session information"
            Me.chkAutomaticallyGetSessionInfo.UseVisualStyleBackColor = True
            '
            'lblXulRunnerPath
            '
            Me.lblXulRunnerPath.AutoSize = True
            Me.lblXulRunnerPath.Location = New System.Drawing.Point(3, 247)
            Me.lblXulRunnerPath.Name = "lblXulRunnerPath"
            Me.lblXulRunnerPath.Size = New System.Drawing.Size(85, 13)
            Me.lblXulRunnerPath.TabIndex = 29
            Me.lblXulRunnerPath.Text = "XULrunner path:"
            '
            'lblMaximumPuttyWaitTime
            '
            Me.lblMaximumPuttyWaitTime.Location = New System.Drawing.Point(3, 184)
            Me.lblMaximumPuttyWaitTime.Name = "lblMaximumPuttyWaitTime"
            Me.lblMaximumPuttyWaitTime.Size = New System.Drawing.Size(364, 13)
            Me.lblMaximumPuttyWaitTime.TabIndex = 26
            Me.lblMaximumPuttyWaitTime.Text = "Maximum PuTTY wait time:"
            Me.lblMaximumPuttyWaitTime.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'chkEncryptCompleteFile
            '
            Me.chkEncryptCompleteFile.AutoSize = True
            Me.chkEncryptCompleteFile.Location = New System.Drawing.Point(3, 23)
            Me.chkEncryptCompleteFile.Name = "chkEncryptCompleteFile"
            Me.chkEncryptCompleteFile.Size = New System.Drawing.Size(180, 17)
            Me.chkEncryptCompleteFile.TabIndex = 18
            Me.chkEncryptCompleteFile.Text = "Encrypt complete connection file"
            Me.chkEncryptCompleteFile.UseVisualStyleBackColor = True
            '
            'chkAutomaticReconnect
            '
            Me.chkAutomaticReconnect.AutoSize = True
            Me.chkAutomaticReconnect.Location = New System.Drawing.Point(3, 68)
            Me.chkAutomaticReconnect.Name = "chkAutomaticReconnect"
            Me.chkAutomaticReconnect.Size = New System.Drawing.Size(399, 17)
            Me.chkAutomaticReconnect.TabIndex = 20
            Me.chkAutomaticReconnect.Text = "Automatically try to reconnect when disconnected from server (RDP && ICA only)"
            Me.chkAutomaticReconnect.UseVisualStyleBackColor = True
            '
            'btnBrowseXulRunnerPath
            '
            Me.btnBrowseXulRunnerPath.Location = New System.Drawing.Point(373, 263)
            Me.btnBrowseXulRunnerPath.Name = "btnBrowseXulRunnerPath"
            Me.btnBrowseXulRunnerPath.Size = New System.Drawing.Size(75, 23)
            Me.btnBrowseXulRunnerPath.TabIndex = 31
            Me.btnBrowseXulRunnerPath.Text = "Browse..."
            Me.btnBrowseXulRunnerPath.UseVisualStyleBackColor = True
            '
            'numPuttyWaitTime
            '
            Me.numPuttyWaitTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.numPuttyWaitTime.Location = New System.Drawing.Point(373, 182)
            Me.numPuttyWaitTime.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
            Me.numPuttyWaitTime.Name = "numPuttyWaitTime"
            Me.numPuttyWaitTime.Size = New System.Drawing.Size(49, 20)
            Me.numPuttyWaitTime.TabIndex = 27
            Me.numPuttyWaitTime.Value = New Decimal(New Integer() {5, 0, 0, 0})
            '
            'chkUseCustomPuttyPath
            '
            Me.chkUseCustomPuttyPath.AutoSize = True
            Me.chkUseCustomPuttyPath.Location = New System.Drawing.Point(3, 91)
            Me.chkUseCustomPuttyPath.Name = "chkUseCustomPuttyPath"
            Me.chkUseCustomPuttyPath.Size = New System.Drawing.Size(146, 17)
            Me.chkUseCustomPuttyPath.TabIndex = 21
            Me.chkUseCustomPuttyPath.Text = "Use custom PuTTY path:"
            Me.chkUseCustomPuttyPath.UseVisualStyleBackColor = True
            '
            'lblConfigurePuttySessions
            '
            Me.lblConfigurePuttySessions.Location = New System.Drawing.Point(3, 153)
            Me.lblConfigurePuttySessions.Name = "lblConfigurePuttySessions"
            Me.lblConfigurePuttySessions.Size = New System.Drawing.Size(364, 13)
            Me.lblConfigurePuttySessions.TabIndex = 24
            Me.lblConfigurePuttySessions.Text = "To configure PuTTY sessions click this button:"
            Me.lblConfigurePuttySessions.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'txtXULrunnerPath
            '
            Me.txtXULrunnerPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtXULrunnerPath.Location = New System.Drawing.Point(21, 265)
            Me.txtXULrunnerPath.Name = "txtXULrunnerPath"
            Me.txtXULrunnerPath.Size = New System.Drawing.Size(346, 20)
            Me.txtXULrunnerPath.TabIndex = 30
            '
            'numUVNCSCPort
            '
            Me.numUVNCSCPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.numUVNCSCPort.Location = New System.Drawing.Point(373, 306)
            Me.numUVNCSCPort.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
            Me.numUVNCSCPort.Name = "numUVNCSCPort"
            Me.numUVNCSCPort.Size = New System.Drawing.Size(72, 20)
            Me.numUVNCSCPort.TabIndex = 33
            Me.numUVNCSCPort.Value = New Decimal(New Integer() {5500, 0, 0, 0})
            Me.numUVNCSCPort.Visible = False
            '
            'txtCustomPuttyPath
            '
            Me.txtCustomPuttyPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtCustomPuttyPath.Enabled = False
            Me.txtCustomPuttyPath.Location = New System.Drawing.Point(21, 114)
            Me.txtCustomPuttyPath.Name = "txtCustomPuttyPath"
            Me.txtCustomPuttyPath.Size = New System.Drawing.Size(346, 20)
            Me.txtCustomPuttyPath.TabIndex = 22
            '
            'btnLaunchPutty
            '
            Me.btnLaunchPutty.Image = Global.dRemote.My.Resources.Resources.PuttyConfig
            Me.btnLaunchPutty.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnLaunchPutty.Location = New System.Drawing.Point(373, 148)
            Me.btnLaunchPutty.Name = "btnLaunchPutty"
            Me.btnLaunchPutty.Size = New System.Drawing.Size(110, 23)
            Me.btnLaunchPutty.TabIndex = 25
            Me.btnLaunchPutty.Text = "Launch PuTTY"
            Me.btnLaunchPutty.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnLaunchPutty.UseVisualStyleBackColor = True
            '
            'lblUVNCSCPort
            '
            Me.lblUVNCSCPort.Location = New System.Drawing.Point(3, 308)
            Me.lblUVNCSCPort.Name = "lblUVNCSCPort"
            Me.lblUVNCSCPort.Size = New System.Drawing.Size(364, 13)
            Me.lblUVNCSCPort.TabIndex = 32
            Me.lblUVNCSCPort.Text = "UltraVNC SingleClick Listening Port:"
            Me.lblUVNCSCPort.TextAlign = System.Drawing.ContentAlignment.TopRight
            Me.lblUVNCSCPort.Visible = False
            '
            'lblSeconds
            '
            Me.lblSeconds.AutoSize = True
            Me.lblSeconds.Location = New System.Drawing.Point(428, 184)
            Me.lblSeconds.Name = "lblSeconds"
            Me.lblSeconds.Size = New System.Drawing.Size(47, 13)
            Me.lblSeconds.TabIndex = 28
            Me.lblSeconds.Text = "seconds"
            '
            'btnBrowseCustomPuttyPath
            '
            Me.btnBrowseCustomPuttyPath.Enabled = False
            Me.btnBrowseCustomPuttyPath.Location = New System.Drawing.Point(373, 112)
            Me.btnBrowseCustomPuttyPath.Name = "btnBrowseCustomPuttyPath"
            Me.btnBrowseCustomPuttyPath.Size = New System.Drawing.Size(75, 23)
            Me.btnBrowseCustomPuttyPath.TabIndex = 23
            Me.btnBrowseCustomPuttyPath.Text = "Browse..."
            Me.btnBrowseCustomPuttyPath.UseVisualStyleBackColor = True
            '
            'txtExtraPuttyParameters
            '
            Me.txtExtraPuttyParameters.Location = New System.Drawing.Point(21, 224)
            Me.txtExtraPuttyParameters.Name = "txtExtraPuttyParameters"
            Me.txtExtraPuttyParameters.Size = New System.Drawing.Size(346, 20)
            Me.txtExtraPuttyParameters.TabIndex = 34
            '
            'lblExtraPuttyParameters
            '
            Me.lblExtraPuttyParameters.AutoSize = True
            Me.lblExtraPuttyParameters.Location = New System.Drawing.Point(3, 208)
            Me.lblExtraPuttyParameters.Name = "lblExtraPuttyParameters"
            Me.lblExtraPuttyParameters.Size = New System.Drawing.Size(114, 13)
            Me.lblExtraPuttyParameters.TabIndex = 35
            Me.lblExtraPuttyParameters.Text = "Extra Putty Parameters"
            '
            'chkmRemoteNGCompatible
            '
            Me.chkmRemoteNGCompatible.AutoSize = True
            Me.chkmRemoteNGCompatible.Location = New System.Drawing.Point(3, 3)
            Me.chkmRemoteNGCompatible.Name = "chkmRemoteNGCompatible"
            Me.chkmRemoteNGCompatible.Size = New System.Drawing.Size(142, 17)
            Me.chkmRemoteNGCompatible.TabIndex = 36
            Me.chkmRemoteNGCompatible.Text = "mRemoteNG Compatible"
            Me.chkmRemoteNGCompatible.UseVisualStyleBackColor = True
            '
            'AdvancedPage
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.chkmRemoteNGCompatible)
            Me.Controls.Add(Me.lblExtraPuttyParameters)
            Me.Controls.Add(Me.txtExtraPuttyParameters)
            Me.Controls.Add(Me.chkAutomaticallyGetSessionInfo)
            Me.Controls.Add(Me.lblXulRunnerPath)
            Me.Controls.Add(Me.lblMaximumPuttyWaitTime)
            Me.Controls.Add(Me.chkEncryptCompleteFile)
            Me.Controls.Add(Me.chkAutomaticReconnect)
            Me.Controls.Add(Me.btnBrowseXulRunnerPath)
            Me.Controls.Add(Me.numPuttyWaitTime)
            Me.Controls.Add(Me.chkUseCustomPuttyPath)
            Me.Controls.Add(Me.lblConfigurePuttySessions)
            Me.Controls.Add(Me.txtXULrunnerPath)
            Me.Controls.Add(Me.numUVNCSCPort)
            Me.Controls.Add(Me.txtCustomPuttyPath)
            Me.Controls.Add(Me.btnLaunchPutty)
            Me.Controls.Add(Me.lblUVNCSCPort)
            Me.Controls.Add(Me.lblSeconds)
            Me.Controls.Add(Me.btnBrowseCustomPuttyPath)
            Me.Name = "AdvancedPage"
            Me.PageIcon = CType(resources.GetObject("$this.PageIcon"), System.Drawing.Icon)
            Me.Size = New System.Drawing.Size(610, 489)
            CType(Me.numPuttyWaitTime, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.numUVNCSCPort, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents chkAutomaticallyGetSessionInfo As System.Windows.Forms.CheckBox
        Friend WithEvents lblXulRunnerPath As System.Windows.Forms.Label
        Friend WithEvents lblMaximumPuttyWaitTime As System.Windows.Forms.Label
        Friend WithEvents chkEncryptCompleteFile As System.Windows.Forms.CheckBox
        Friend WithEvents chkAutomaticReconnect As System.Windows.Forms.CheckBox
        Friend WithEvents btnBrowseXulRunnerPath As System.Windows.Forms.Button
        Friend WithEvents numPuttyWaitTime As System.Windows.Forms.NumericUpDown
        Friend WithEvents chkUseCustomPuttyPath As System.Windows.Forms.CheckBox
        Friend WithEvents lblConfigurePuttySessions As System.Windows.Forms.Label
        Friend WithEvents txtXULrunnerPath As System.Windows.Forms.TextBox
        Friend WithEvents numUVNCSCPort As System.Windows.Forms.NumericUpDown
        Friend WithEvents txtCustomPuttyPath As System.Windows.Forms.TextBox
        Friend WithEvents btnLaunchPutty As System.Windows.Forms.Button
        Friend WithEvents lblUVNCSCPort As System.Windows.Forms.Label
        Friend WithEvents lblSeconds As System.Windows.Forms.Label
        Friend WithEvents btnBrowseCustomPuttyPath As System.Windows.Forms.Button
        Friend WithEvents txtExtraPuttyParameters As TextBox
        Friend WithEvents lblExtraPuttyParameters As Label
        Friend WithEvents chkmRemoteNGCompatible As CheckBox
    End Class
End Namespace