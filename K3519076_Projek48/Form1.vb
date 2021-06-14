Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (TextBox1.Text = "123456") Then
            Form2.Show()
        End If
    End Sub
End Class
