Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        WebBrowser1.DocumentText = RichTextBox1.Text
    End Sub
End Class
