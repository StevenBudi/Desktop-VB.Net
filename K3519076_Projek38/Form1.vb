Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Computer.Network.DownloadFile(TextBox1.Text, "D:\\Test.jpg")
    End Sub
End Class
