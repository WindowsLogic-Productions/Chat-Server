Public Class Main
    Dim user As String = Nothing
    Dim disconected As String = Nothing
    Dim disconnSock As String = Nothing
    Dim sendall As String = Nothing
    Dim exclude_sock As Integer
    Dim new_sock As Integer
    Dim privSock As Integer
    Dim privSock2 As Integer
    Dim privSock3 As Integer
    Dim privString As String = Nothing
    Dim list As String = Nothing
    Dim list1 As String = Nothing
    Dim list2 As String = Nothing
    Dim countListItems As Integer


    Public Sub sendPriv()

        Server.Send(privSock2, "@code1847@" & privString & "   " & CStr(privSock3))
        Server.Send(privSock3, "@code1847@" & privString & "   " & CStr(privSock2))
        privSock3 = Nothing
        privSock2 = Nothing
        privString = Nothing

    End Sub
    Public Sub dodaj_korisnika() 'ADD USER
        UserListBox.Items.Add(user + "   " + CStr(privSock))
        countListItems += 1
        user = Nothing
    End Sub
    Public Sub izbrisi_korisnika() 'REMOvE USER
        For i As Integer = 0 To UserListBox.Items.Count - 1
            If UserListBox.Items.Item(i).ToString = disconected & "   " & disconnSock Then
                UserListBox.Items.RemoveAt(i)
                Exit For
            End If
        Next
        disconected = Nothing
    End Sub
    Public Sub senditall()
        serverSendToAllConnected2("", sendall)
        sendall = Nothing
    End Sub
    Public Sub usersUpdate()
        serverSendToAllConnected3("", sendall)
    End Sub
    Public Sub userLeave()
        serverSendToAllConnected4("", sendall)
    End Sub
    Private Sub serverSendToAllConnected4(ByVal User As String, ByVal Message As String, Optional ByVal ExceptSock As Integer = -1)
        If isArraySafe(InUse) Then
            For i As Integer = 0 To InUse.Length - 1

                If Not (i = ExceptSock) Then
                    If InUse(i) Then

                        list2 = ""
                        For b As Integer = 0 To UserListBox.Items.Count - 1 ' nema potrebe izvrtjeti sve korisnike ponovo i za one kojima su veæ uploadani
                            ' OVAJ DIO JE ZA NOVOULOGIRANE KORISNIKE
                            list2 = list2 & UserListBox.Items.Item(b).ToString + vbCrLf
                        Next
                        Server.Send(i, "@code1840@" & list2)

                    End If
                End If
            Next
        End If
        list2 = Nothing
    End Sub
    Private Sub serverSendToAllConnected3(ByVal User As String, ByVal Message As String, Optional ByVal ExceptSock As Integer = -1)
        If isArraySafe(InUse) Then
            For i As Integer = 0 To InUse.Length - 1

                If Not (i = ExceptSock) Then
                    If InUse(i) Then
                        If new_sock = i Then
                            list1 = ""
                            For b As Integer = 0 To UserListBox.Items.Count - 1 ' nema potrebe izvrtjeti sve korisnike ponovo i za one kojima su veæ uploadani
                                ' OVAJ DIO JE ZA NOVOULOGIRANE KORISNIKE
                                list1 = list1 & UserListBox.Items.Item(b).ToString + vbCrLf
                            Next
                            Server.Send(i, "@code1841@" & list1)
                        Else
                            Server.Send(i, "@code1841@" & list & "   " & CStr(privSock))             ' OVO JE LAGANI UPDATE POPISA KORISNIKA ZA ONE KOJI SU VEÆ TU
                        End If
                    End If
                End If
            Next
        End If
        list = Nothing
        list1 = Nothing
        new_sock = Nothing
    End Sub
    Private Sub serverSendToAllConnected2(ByVal User As String, ByVal Message As String, Optional ByVal ExceptSock As Integer = -1)
        If isArraySafe(InUse) Then
            For i As Integer = 0 To InUse.Length - 1
                If i <> exclude_sock Then
                    If Not (i = ExceptSock) Then
                        If InUse(i) Then
                            Server.Send(i, "" & Message)
                        End If
                    End If
                End If
            Next
        End If
    End Sub
#Region "Server Code"
    Private Server As socketServer
    Private ServerOn As Boolean = False
    Private InUse() As Boolean


    Private Sub serverLogMessage(ByVal Message As String) 'ADD MESSAGE TO RICH BOX!
        Delegates.RichTextBoxes.appendText(Me, ChatHistory, vbCrLf & Message)

        If Message = "/" Then
            sendall = "Underconstruction, Please try again later for more commands and bitch slaps"
        End If


    End Sub

    Private Sub serverSendToAllConnected(ByVal User As String, ByVal Message As String, Optional ByVal ExceptSock As Integer = -1)
        If isArraySafe(InUse) Then
            For i As Integer = 0 To InUse.Length - 1
                If Not (i = ExceptSock) Then
                    If InUse(i) Then
                        Server.Send(i, "Server:  " & Message)
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub txtServeSend_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ChatSender.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            If Server IsNot Nothing Then
                serverSendToAllConnected("Server", ChatSender.Text)
                serverLogMessage("Server:  " & ChatSender.Text)
                ChatSender.Text = ""
            End If
        End If
    End Sub

    Private Sub btnStopServe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StopButton.Click
        If Server Is Nothing Then
            Exit Sub
        Else
            If ServerOn = False Then
                Exit Sub
            Else
                Server.stopListen(True)
                serverLogMessage("No longer serving.")
                ServerOn = False
            End If
        End If
    End Sub
    '#################################  FOR LONG IP ADDRESS  -  NEBITNO ######################################
    Public Function Dotted2LongIP(ByVal DottedIP As String) As Object
        ' errors will result in a zero value
        On Error Resume Next

        Dim i As Byte, pos As Integer
        Dim PrevPos As Integer, num As Integer

        ' string cruncher
        For i = 1 To 4
            ' Parse the position of the dot
            pos = InStr(PrevPos + 1, DottedIP, ".", 1)

            ' If its past the 4th dot then set pos to the last
            'position + 1

            If i = 4 Then pos = Len(DottedIP) + 1

            ' Parse the number from between the dots

            num = Int(Mid(DottedIP, PrevPos + 1, pos - PrevPos - 1))

            ' Set the previous dot position
            PrevPos = pos

            ' No dot value should ever be larger than 255
            ' Technically it is allowed to be over 255 -it just
            ' rolls over e.g.
            '256 => 0 -note the (4 - i) that's the 
            'proper exponent for this calculation


            Dotted2LongIP = ((num Mod 256) * (256 ^ (4 - i))) + Dotted2LongIP

        Next
        Return Dotted2LongIP
    End Function
    '#############################################################################################
    Private Sub btnServe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartButton.Click

        If Server Is Nothing Then
            Server = New socketServer()
        Else
            If ServerOn = False Then
                Server = New socketServer()
            Else
                Exit Sub
            End If
        End If

        ServerOn = True

        AddHandler Server.IncomingData, AddressOf handleServerIncomingData
        AddHandler Server.Connected, AddressOf handleServerConnected
        AddHandler Server.ConnectionError, AddressOf handleServerConnectionError
        AddHandler Server.ConnectionRefused, AddressOf handleServerConnectionRefused
        AddHandler Server.Disconnected, AddressOf handleServerDisconnected
        AddHandler Server.DisconnectError, AddressOf handleServerDisconnectError
        AddHandler Server.IncomingDataError, AddressOf handleServerIncomingDataError
        AddHandler Server.ListenError, AddressOf handleServerListenError
        AddHandler Server.SendDataError, AddressOf handleServerSendDataError

        ReDim InUse(63)

        Server.Listen(64, PortTextBox.Text)

        serverLogMessage("Now serving.")
    End Sub

    '************************************************************
    'Primary Socket Functionality
    '************************************************************
    Public Sub handleServerIncomingData(ByVal Sock As Integer, ByRef Data As String)
        If InStr(Data, "@code1843@") > 0 And Data.Length > 0 Then
            Data$ = Replace(Data$, "@code1843@", "")
            user = Data
            list = Data
            list1 = Data
            new_sock = Sock
            privSock = Sock
        ElseIf InStr(Data, "@code1842@") > 0 And Data.Length > 0 Then
            Data$ = Replace(Data$, "@code1842@", "")
            disconected = Trim(Mid(Data, 1, Data.Length))
            disconnSock = CStr(Sock)
        ElseIf InStr(Data, "@code1839@") > 0 And Data.Length > 0 Then
            Data$ = Replace(Data$, "@code1839@", "")
            privString = LSet(Data, Data.Length - 2)
            privSock2 = CInt(Trim(Mid(Data, Data.Length - 2)))
            privSock3 = Sock
            sendPriv()
        Else
            If Data.Length > 0 Then
                serverLogMessage(Data)
                sendall = Data
                exclude_sock = Sock
            End If
        End If
    End Sub

    Private Sub handleServerConnected(ByVal Sock As Integer, ByVal RemoteAddress As String)
        serverLogMessage("Connection from " & RemoteAddress & " to socket space " & Sock & ".")
        InUse(Sock) = True
    End Sub

    Private Sub handleServerConnectionRefused(ByVal Message As String)
        serverLogMessage(Message)
    End Sub

    Private Sub handleServerDisconnected(ByVal Sock As Integer)
        serverLogMessage("Socket " & Sock & ":  Disconnected.")
        InUse(Sock) = False
    End Sub

    '************************************************************
    'Functional Error Reporting (Below)
    '************************************************************
    Private Sub handleServerConnectionError(ByVal Sock As Integer, ByVal Message As String)
        serverLogMessage("Socket " & Sock & ":  " & Message)
    End Sub

    Private Sub handleServerDisconnectError(ByVal Sock As Integer, ByVal Message As String)
        serverLogMessage("Socket " & Sock & ":  " & Message)
    End Sub

    Private Sub handleServerIncomingDataError(ByVal Sock As Integer, ByVal Message As String)
        serverLogMessage("Socket " & Sock & ":  " & Message)
    End Sub

    Private Sub handleServerListenError(ByVal Message As String)
        serverLogMessage("Error:  " & Message)
        ServerOn = False
    End Sub

    Private Sub handleServerSendDataError(ByVal Sock As Integer, ByVal Message As String)
        serverLogMessage("Socket " & Sock & ":  " & Message)
    End Sub
#End Region

    Private Sub Main_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Automatic updates.
        If My.Settings.Updates = 1 Then
            Try
                Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("http://hfs.windowslogic.co.uk:7659/Public/Update%20Repo/LB/LB.txt")
                Dim response As System.Net.HttpWebResponse = request.GetResponse()
                Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
                Dim newestversion As String = sr.ReadToEnd()
                Dim currentversion As String = Application.ProductVersion
                If newestversion.Contains(currentversion) Then

                Else
                    'UpdaterPrompt.Show()
                End If

            Catch
                Errordiag.Show()
                Errordiag.Label1.Text = "No connection to the update server."
            End Try
        End If

        If My.Settings.Updates = 2 Then
            If My.Settings.AdhocHandler = 1 Then
                Try
                    Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("http://hfs.windowslogic.co.uk:7659/Public/Update%20Repo/LB/LB.txt")
                    Dim response As System.Net.HttpWebResponse = request.GetResponse()
                    Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
                    Dim newestversion As String = sr.ReadToEnd()
                    Dim currentversion As String = Application.ProductVersion
                    If newestversion.Contains(currentversion) Then

                    Else
                        'UpdaterPrompt.Show()
                    End If

                Catch
                    Errordiag.Show()
                    Errordiag.Label1.Text = "No connection to the update server."
                End Try
            End If

            If My.Settings.AdhocHandler = 0 Then

            End If
        End If

        If My.Settings.Updates = 0 Then

        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles AboutButton.Click
        About.ShowDialog()
    End Sub

    Private Sub Main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

    End Sub
End Class