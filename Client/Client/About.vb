Public Class About
#Region "Load Settings"
    Private Sub About_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        'Sound
        If My.Settings.Sounds = "ON" Then
            My.Computer.Audio.Play(My.Resources.About, AudioPlayMode.Background)
        End If

        If My.Settings.Sounds = "OFF" Then
        End If

        'Load personalisation settings.
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
        End If

        If My.Settings.BCE = 1 Then
            OKButton.BackColor = My.Settings.CustomButtonColour
            MoreButton.BackColor = My.Settings.CustomButtonColour
        End If

        'Load version number and licence.
        Variables.ParseVariables(verinfo)
    End Sub
#End Region
#Region "Other"
    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles OKButton.Click
        Me.Dispose()
    End Sub
#End Region

    Private Sub MoreButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MoreButton.Click
        Dedicate.ShowDialog()
    End Sub
End Class