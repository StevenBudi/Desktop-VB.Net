Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim I As Integer = 0

        For I = 0 To 10
            If (I Mod 2 = 0) Then
                Continue For
            Else
                MessageBox.Show("My Value is " & I)
            End If


        Next
    End Sub
End Class
