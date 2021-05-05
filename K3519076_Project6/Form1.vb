Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim activities(3) As String
        activities(0) = "Eat"
        activities(1) = "Pray"
        activities(2) = "Code"
        activities(3) = "Sleep"

        For I = 0 To activities.Length - 1
            MessageBox.Show(activities(I))
        Next

    End Sub
End Class
