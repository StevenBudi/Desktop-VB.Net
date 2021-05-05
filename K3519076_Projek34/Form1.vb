Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        WebBrowser1.Navigate("https://myanimelist.net/login.php")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        WebBrowser1.Document.GetElementById("loginUserName").SetAttribute("value", TextBox1.Text)
        WebBrowser1.Document.GetElementById("login-password").SetAttribute("value", TextBox2.Text)

        WebBrowser1.Document.GetElementById("loginUser").InvokeMember("click")
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        TextBox2.PasswordChar = "*"
    End Sub
End Class
