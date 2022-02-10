Public Class Resetyesno
    Private Sub Resetyesno_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Load Personalisation settings.
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
        End If

        If My.Settings.BCE = 1 Then
            YesButton.BackColor = My.Settings.CustomButtonColour
            NoButton.BackColor = My.Settings.CustomButtonColour
        End If
    End Sub

    Private Sub YesButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YesButton.Click
        SettingsPanel.BackColor = Color.SlateBlue
        Main.BackColor = Color.SlateBlue
        My.Settings.CustomColour = Color.SlateBlue
        SettingsPanel.GeneralSettingsButton.BackColor = Color.MidnightBlue
        SettingsPanel.PersonaliseSettingsButton.BackColor = Color.MidnightBlue
        SettingsPanel.UpdatesSettingsButton.BackColor = Color.MidnightBlue
        My.Settings.CustomButtonColour = Color.MidnightBlue
        My.Settings.Sounds = "ON"
        My.Settings.Updates = 1
        Me.Dispose()
    End Sub

    Private Sub NoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NoButton.Click
        Me.Dispose()
    End Sub
End Class