﻿Imports dRemote.My

Namespace Forms.OptionsPages
    Public Class TabsPanelsPage
        Public Overrides Property PageName() As String
            Get
                Return Language.strTabsAndPanels.Replace("&&", "&")
            End Get
            Set(value As String)
            End Set
        End Property

        Public Overrides Sub ApplyLanguage()
            MyBase.ApplyLanguage()

            chkAlwaysShowPanelTabs.Text = Language.strAlwaysShowPanelTabs
            chkOpenNewTabRightOfSelected.Text = Language.strOpenNewTabRight
            chkShowLogonInfoOnTabs.Text = Language.strShowLogonInfoOnTabs
            chkShowProtocolOnTabs.Text = Language.strShowProtocolOnTabs
            chkIdentifyQuickConnectTabs.Text = Language.strIdentifyQuickConnectTabs
            chkDoubleClickClosesTab.Text = Language.strDoubleClickTabClosesIt
            chkAlwaysShowPanelSelectionDlg.Text = Language.strAlwaysShowPanelSelection

            chkUseOnlyErrorsAndInfosPanel.Text = Language.strUseOnlyErrorsAndInfosPanel
            lblSwitchToErrorsAndInfos.Text = Language.strSwitchToErrorsAndInfos
            chkMCInformation.Text = Language.strInformations
            chkMCWarnings.Text = Language.strWarnings
            chkMCErrors.Text = Language.strErrors
        End Sub

        Public Overrides Sub LoadSettings()
            MyBase.SaveSettings()

            chkAlwaysShowPanelTabs.Checked = Settings.AlwaysShowPanelTabs
            chkEachNewPanelTab.Checked = Settings.EachNewPanelTab
            chkOpenNewTabRightOfSelected.Checked = Settings.OpenTabsRightOfSelected
            chkShowLogonInfoOnTabs.Checked = Settings.ShowLogonInfoOnTabs
            chkShowProtocolOnTabs.Checked = Settings.ShowProtocolOnTabs
            chkIdentifyQuickConnectTabs.Checked = Settings.IdentifyQuickConnectTabs
            chkDoubleClickClosesTab.Checked = Settings.DoubleClickOnTabClosesIt
            chkAlwaysShowPanelSelectionDlg.Checked = Settings.AlwaysShowPanelSelectionDlg
            chkGroupTabs.Checked = Settings.GroupTabs
            gbGroupTabs.Visible = chkGroupTabs.Checked

            Select Case Settings.GroupTabsDepend
                Case "parent"
                    rbParent.Checked = True
                Case "child"
                    rbChild.Checked = True
                Case "panel"
                    rbPanel.Checked = True
            End Select

            chkUseOnlyErrorsAndInfosPanel.Checked = Settings.ShowNoMessageBoxes
            chkMCInformation.Checked = Settings.SwitchToMCOnInformation
            chkMCWarnings.Checked = Settings.SwitchToMCOnWarning
            chkMCErrors.Checked = Settings.SwitchToMCOnError
        End Sub

        Public Overrides Sub SaveSettings()
            MyBase.SaveSettings()

            Settings.AlwaysShowPanelTabs = chkAlwaysShowPanelTabs.Checked
            Settings.EachNewPanelTab = chkEachNewPanelTab.Checked
            frmMain.ShowHidePanelTabs()

            Settings.OpenTabsRightOfSelected = chkOpenNewTabRightOfSelected.Checked
            Settings.ShowLogonInfoOnTabs = chkShowLogonInfoOnTabs.Checked
            Settings.ShowProtocolOnTabs = chkShowProtocolOnTabs.Checked
            Settings.IdentifyQuickConnectTabs = chkIdentifyQuickConnectTabs.Checked
            Settings.DoubleClickOnTabClosesIt = chkDoubleClickClosesTab.Checked
            Settings.AlwaysShowPanelSelectionDlg = chkAlwaysShowPanelSelectionDlg.Checked
            Settings.GroupTabs = chkGroupTabs.Checked
            Dim GroupTabsDepend As String = ""
            Select Case True
                Case rbParent.Checked
                    GroupTabsDepend = "parent"
                Case rbChild.Checked
                    GroupTabsDepend = "child"
                Case rbPanel.Checked
                    GroupTabsDepend = "panel"
            End Select
            Settings.GroupTabsDepend = GroupTabsDepend

            Settings.ShowNoMessageBoxes = chkUseOnlyErrorsAndInfosPanel.Checked
            Settings.SwitchToMCOnInformation = chkMCInformation.Checked
            Settings.SwitchToMCOnWarning = chkMCWarnings.Checked
            Settings.SwitchToMCOnError = chkMCErrors.Checked
            Settings.Save()
        End Sub

        Private Sub chkUseOnlyErrorsAndInfosPanel_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkUseOnlyErrorsAndInfosPanel.CheckedChanged
            chkMCInformation.Enabled = chkUseOnlyErrorsAndInfosPanel.Checked
            chkMCWarnings.Enabled = chkUseOnlyErrorsAndInfosPanel.Checked
            chkMCErrors.Enabled = chkUseOnlyErrorsAndInfosPanel.Checked
        End Sub

        Private Sub chkGroupTabs_CheckedChanged(sender As Object, e As EventArgs) Handles chkGroupTabs.CheckedChanged
            gbGroupTabs.Visible = chkGroupTabs.Checked
        End Sub

    End Class
End Namespace