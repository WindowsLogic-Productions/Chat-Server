Public Class SettingsPanel
#Region "Load Settings"
    Private Sub Form3_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        'Load personalisation settings.
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
        End If

        If My.Settings.BCE = 1 Then
            GeneralSettingsButton.BackColor = My.Settings.CustomButtonColour
            PersonaliseSettingsButton.BackColor = My.Settings.CustomButtonColour
            UpdatesSettingsButton.BackColor = My.Settings.CustomButtonColour
            ResetButton.BackColor = My.Settings.CustomButtonColour
            HelpButton.BackColor = My.Settings.CustomButtonColour
        End If
    End Sub
#End Region
#Region "Buttons"
    Private Sub GeneralSettingsButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GeneralSettingsButton.Click
        SettingsPanelGeneral.Show()
        Me.Dispose()
    End Sub

    Private Sub PersonaliseSettingsButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PersonaliseSettingsButton.Click
        SettingsPanelPersonalise.Show()
        Me.Dispose()
    End Sub

    Private Sub UpdatesSettingsButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdatesSettingsButton.Click
        SettingsPanelUpdates.Show()
        Me.Dispose()
    End Sub

    Private Sub ResetButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetButton.Click
        Resetyesno.ShowDialog()
    End Sub

    Private Sub HelpButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpButton.Click
        errordiag.Show()
        errordiag.Label1.Text = "We're currently working on this..."
    End Sub
#End Region
End Class