Imports System.Net.Sockets
Imports System.Text
Public Class SettingsPanelGeneral

    Private Client As socketClient
    Dim sr As IO.StringReader
    Dim users As String = Nothing
    Dim refresh1 As String = Nothing
    Dim formNo As String = Nothing
    Dim poruka As String = Nothing
    Dim br As String = Nothing

    Private Sub SettingsPanelGeneral_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'User name settings.
        UserNameTextBox.Text = My.Settings.Username
        My.Settings.Username = UserNameTextBox.Text
        My.Settings.Save()
    End Sub

    Private Sub BackButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackButton.Click
        SettingsPanel.Show()
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If InStr(My.Settings.Username, "@code1843@") > 0 Then
            MsgBox("Nickname is taken!")
        ElseIf InStr(My.Settings.Username, " ") > 0 Then
            MsgBox("Nickname cannot include spaces.")
        ElseIf My.Settings.Username = "" Then
            MsgBox("You must choose a nickname")
        Else
            Main.DisconnectToolStripMenuItem.Enabled = True
            Client = New socketClient()

            AddHandler Client.Connected, AddressOf Main.handleClientConnected
            AddHandler Client.ConnectionError, AddressOf Main.handleClientConnectionError
            AddHandler Client.Disconnected, AddressOf Main.handleClientDisconnected
            AddHandler Client.DisconnectError, AddressOf Main.handleClientDisconnectError
            AddHandler Client.IncomingData, AddressOf Main.handleClientIncomingData
            AddHandler Client.IncomingDataError, AddressOf Main.handleClientIncomingDataError
            AddHandler Client.SendDataError, AddressOf Main.handleClientSendDataError

            Client.Connect(IPTextBox.Text, PortTextBox.Text)
            '#################################### information about new user ###########################
            If Client.isConnected Then
                Client.Send("@code1843@" & My.Settings.Username)
                Main.clientLogMessage(My.Settings.Username)
                Main.txtClientSend.Text = ""
            End If
            '###########################################################################################
        End If
    End Sub
End Class