Public Class Variables
    Public Shared ver As String = My.Application.Info.Version.ToString + ".main.dev.Jan17"
    Public Shared user As String = System.Windows.Forms.SystemInformation.UserName
    Public Shared appname As String = "Chat Server"

    Public Shared Sub ParseVariables(input As Label)
        input.Text = input.Text.Replace("%ver%", Variables.ver).Replace("%user%", Variables.user).Replace("%appname%", Variables.appname)
    End Sub

    Public Shared Sub Update_Settings()
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
End Class
