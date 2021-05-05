Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim I As Integer
        Do While I = 0 < 10
            Dim rn As New Random
            MessageBox.Show(rn.Next(0, 1000))
            I += 1
        Loop

    End Sub
End Class
