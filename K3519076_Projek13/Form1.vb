Public Class Form1
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim gender As String = "Unknown"
        Dim age As String = "Unknown"
        If CheckBox1.Checked Then
            age = "under 18"
        End If
        If CheckBox2.Checked Then
            age = "over 18"
        End If
        If RadioButton1.Checked Then
            gender = "Male"
        End If
        If RadioButton2.Checked Then
            gender = "Female"
        End If
        MessageBox.Show(String.Format("User gender is {0} and age {1}", gender, age))

    End Sub
End Class
