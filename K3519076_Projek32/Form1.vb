Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim source As String
        source = New System.Net.WebClient().DownloadString(TextBox1.Text)
        RichTextBox1.Text = source
    End Sub
End Class
