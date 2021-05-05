Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result As Integer = expo(TextBox1.Text, TextBox2.Text)
        MessageBox.Show("The Result is : " & result)
    End Sub

    Private Function expo(ByVal num1 As Integer, ByVal num2 As Integer)
        Return num1 ^ num2

    End Function
End Class
