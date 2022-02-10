Public Class Errordiag
    Private Sub errordiag_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
        End If

        If My.Settings.BCE = 1 Then
            OKButton.BackColor = My.Settings.CustomButtonColour
        End If
    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Me.Dispose()
    End Sub
End Class