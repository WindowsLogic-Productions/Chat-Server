Imports System.Net.Sockets
Imports System.Text
Public Class Main
    Dim sr As IO.StringReader
    Dim users As String = Nothing
    Dim refresh1 As String = Nothing
    Dim formNo As String = Nothing
    Dim poruka As String = Nothing
    Dim br As String = Nothing

    Public Sub addUsers()
        sr = New IO.StringReader(users)
        Do Until sr.Peek < 0
            ListBox1.Items.Add(sr.ReadLine)
        Loop
        users = Nothing
    End Sub
    Public Sub refUsers()
        ListBox1.Items.Clear()
        sr = New IO.StringReader(refresh1)
        Do Until sr.Peek < 0
            ListBox1.Items.Add(sr.ReadLine)

        Loop
        refresh1 = Nothing
    End Sub

#Region "Client Code"
    Private Client As socketClient

    Public Sub clientLogMessage(ByVal Message As String)
        Delegates.RichTextBoxes.appendText(Me, rtbClient, vbCrLf & Message)
    End Sub

    Public Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            If Client.isConnected Then
                Client.Send("@code1842@" & My.Settings.Username)
                clientLogMessage("Odlogirani ste!")
                txtClientSend.Text = ""
            End If
        Catch ex As Exception

        End Try
        Try
            Client.Disconnect()
        Catch ex As Exception

        End Try
    End Sub
    Public Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.Start, AudioPlayMode.Background)

    End Sub

    '************************************************************
    'Primary Socket Functionality
    '************************************************************
    Public Sub handleClientConnected()
        clientLogMessage("Connected as " & My.Settings.Username & ".")
        'Client.Send(My.Settings.Username & "has joined the server.")
    End Sub

    Public Sub handleClientDisconnected()
        'Client.Send(My.Settings.Username & "has left the server.")
        clientLogMessage("Disconnected!")
    End Sub

    Public Sub handleClientIncomingData(ByRef Data As String)
        If InStr(Data, "@code1841@") > 0 And Data.Length > 0 Then
            Data$ = Replace(Data$, "@code1841@", "")
            users = Data
        ElseIf InStr(Data, "@code1840@") > 0 And Data.Length > 0 Then
            Data$ = Replace(Data$, "@code1840@", "")
            refresh1 = Data
        ElseIf InStr(Data, "@code1847@") > 0 And Data.Length > 0 Then
            Data$ = Replace(Data$, "@code1847@", "")
            formNo = Trim(Mid(Data, Data.Length - 2))
            poruka = Mid(Data, 1, Data.Length - 2)
            br = Trim(Mid(Data, Data.Length - 2))
        Else
            If Data.Length > 0 Then
                clientLogMessage(Data)
            End If
        End If
    End Sub


    '************************************************************
    'Functional Error Reporting (Below)
    '************************************************************
    Public Sub handleClientConnectionError(ByVal Message As String)
        clientLogMessage(Message)
    End Sub

    Public Sub handleClientDisconnectError(ByVal Message As String)
        clientLogMessage(Message)
    End Sub

    Public Sub handleClientIncomingDataError(ByVal Message As String)
        clientLogMessage(Message)
    End Sub

    Public Sub handleClientSendDataError(ByVal Message As String)
        clientLogMessage(Message)
    End Sub
#End Region

    Public Sub txtClientSend_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtClientSend.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            If Client IsNot Nothing Then
                If Client.isConnected Then

                    Client.Send(my.settings.username & ":  " & txtClientSend.Text)
                    clientLogMessage(my.settings.username & ":  " & txtClientSend.Text)
                    txtClientSend.Text = ""
                    If txtClientSend.Text = "/" Then
                        Client.Send("In development, please check later for more commands.")
                    End If

                End If
            End If
        End If
    End Sub

    Public Sub AboutButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        About.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ConnectToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConnectToolStripMenuItem.Click
        SettingsPanelGeneral.Show()
    End Sub

    Private Sub DisconnectToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisconnectToolStripMenuItem.Click
        Try
            If Client.isConnected Then
                Client.Send("@code1842@" & My.Settings.Username)
                txtClientSend.Text = ""
            End If
        Catch ex As Exception

        End Try

        Client.Disconnect()

        ListBox1.Items.Clear()
    End Sub

    Private Sub SettingsPanelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SettingsPanelToolStripMenuItem.Click
        SettingsPanel.Show()
    End Sub

    Private Sub HelpDocumentationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpDocumentationToolStripMenuItem.Click
        Errordiag.Show()
        Errordiag.Label1.Text = "We're currently working on this..."
    End Sub

    Private Sub AboutHarmonyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutHarmonyToolStripMenuItem.Click
        About.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Client IsNot Nothing Then
            If Client.isConnected Then

                Client.Send(My.Settings.Username & ":  " & txtClientSend.Text)
                clientLogMessage(My.Settings.Username & ":  " & txtClientSend.Text)
                txtClientSend.Text = ""
                If txtClientSend.Text = "/" Then
                    Client.Send("In development, please check later for more commands.")
                End If

            End If
        End If
    End Sub
End Class
