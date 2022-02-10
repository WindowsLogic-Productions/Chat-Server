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

    Private Sub clientLogMessage(ByVal Message As String)
        Delegates.RichTextBoxes.appendText(Me, rtbClient, vbCrLf & Message)
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            If Client.isConnected Then
                Client.Send("@code1842@" & txtClientName.Text)
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
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.Start, AudioPlayMode.Background)
    End Sub

    Private Sub btnClientConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClientConnect.Click
        If InStr(txtClientName.Text, "@code1843@") > 0 Then
            MsgBox("Nickname is taken!")
        ElseIf InStr(txtClientName.Text, " ") > 0 Then
            MsgBox("Nickname cannot include spaces.")
        ElseIf txtClientName.Text = "" Then
            MsgBox("You must choose a nickname")
        Else
            btnClientConnect.Enabled = False
            btnClientDisconnect.Enabled = True
            Client = New socketClient()

            AddHandler Client.Connected, AddressOf handleClientConnected
            AddHandler Client.ConnectionError, AddressOf handleClientConnectionError
            AddHandler Client.Disconnected, AddressOf handleClientDisconnected
            AddHandler Client.DisconnectError, AddressOf handleClientDisconnectError
            AddHandler Client.IncomingData, AddressOf handleClientIncomingData
            AddHandler Client.IncomingDataError, AddressOf handleClientIncomingDataError
            AddHandler Client.SendDataError, AddressOf handleClientSendDataError

            Client.Connect(txtClientIP.Text, txtClientPort.Text)
            '#################################### information about new user ###########################
            If Client.isConnected Then
                Client.Send("@code1843@" & txtClientName.Text)
                clientLogMessage(txtClientName.Text)
                txtClientSend.Text = ""

                txtClientIP.Enabled = False
                txtClientName.Enabled = False
                txtClientPort.Enabled = False

            End If
            '###########################################################################################

        End If
    End Sub
    '************************************************************
    'Primary Socket Functionality
    '************************************************************
    Private Sub handleClientConnected()
        clientLogMessage("Connected as " & txtClientName.Text & ".")
        Client.Send(txtClientName.Text & "has joined the server.")
    End Sub

    Private Sub handleClientDisconnected()
        Client.Send(txtClientName.Text & "has left the server.")
        clientLogMessage("Disconnected!")
    End Sub

    Private Sub handleClientIncomingData(ByRef Data As String)
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
    Private Sub handleClientConnectionError(ByVal Message As String)
        clientLogMessage(Message)
    End Sub

    Private Sub handleClientDisconnectError(ByVal Message As String)
        clientLogMessage(Message)
    End Sub

    Private Sub handleClientIncomingDataError(ByVal Message As String)
        clientLogMessage(Message)
    End Sub

    Private Sub handleClientSendDataError(ByVal Message As String)
        clientLogMessage(Message)
    End Sub
#End Region

    Private Sub btnClientDisconnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClientDisconnect.Click
        Try
            If Client.isConnected Then
                Client.Send("@code1842@" & txtClientName.Text)
                txtClientSend.Text = ""
            End If
        Catch ex As Exception

        End Try

        btnClientConnect.Enabled = True
        btnClientDisconnect.Enabled = False
        Client.Disconnect()

        Try
            txtClientIP.Enabled = True
            txtClientName.Enabled = True
            txtClientPort.Enabled = True
        Catch ex As Exception

        End Try
        ListBox1.Items.Clear()
    End Sub

    Private Sub txtClientSend_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtClientSend.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            If Client IsNot Nothing Then
                If Client.isConnected Then

                    If txtClientSend.Text = "/red" Then
                        Client.Send(txtClientName.Text & ":  " & txtClientSend.Text)
                    Else
                        Client.Send(txtClientName.Text & ":  " & txtClientSend.Text)
                        clientLogMessage(txtClientName.Text & ":  " & txtClientSend.Text)
                        txtClientSend.Text = ""
                    End If

                End If
            End If
        End If
    End Sub

    Private Sub AboutButton_Click(sender As System.Object, e As System.EventArgs) Handles AboutButton.Click
        About.ShowDialog()
    End Sub
End Class
