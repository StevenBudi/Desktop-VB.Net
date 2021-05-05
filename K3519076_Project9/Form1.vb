Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        expo(TextBox1.Text, TextBox2.Text)
    End Sub

    Private Sub expo(ByVal a As Integer, ByVal b As Integer)
        Dim res As Integer = a ^ b

        MessageBox.Show(res)
    End Sub
End Class
