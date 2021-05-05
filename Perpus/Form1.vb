Public Class Form1
    'login credentials
    Dim db_name = "admin"
    Dim db_pass = "abcd1234"
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        TextBox2.PasswordChar = "*"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Username As String = TextBox1.Text
        Dim Password As String = TextBox2.Text
        If (Username = db_name And Password = db_pass) Then
            Form2.Show()
        Else
            MessageBox.Show("Username atau Password anda salah")
            TextBox1.Text = ""
            TextBox2.Text = ""
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
