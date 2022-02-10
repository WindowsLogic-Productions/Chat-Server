Public Class About

    Private Sub About_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.About, AudioPlayMode.Background)
    End Sub
End Class