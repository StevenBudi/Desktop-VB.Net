Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim I As Integer = 0

        Do While (I < 10)
            MessageBox.Show("My Value is " & I)
            I += 2
        Loop
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim I As Integer = 0

        Do Until (I = 10)
            MessageBox.Show("My Value is " & I)
            I += 3
        Loop


    End Sub
End Class
