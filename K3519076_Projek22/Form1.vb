Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Chart1.Series("Age").Points.AddXY("Mark", 33)
        Me.Chart1.Series("Mark").Points.AddXY("Mark", 70)
        Me.Chart1.Series("Age").Points.AddXY("John", 44)
        Me.Chart1.Series("Mark").Points.AddXY("John", 72)
        Me.Chart1.Series("Age").Points.AddXY("Markus", 31)
        Me.Chart1.Series("Mark").Points.AddXY("Markus", 87)
        Me.Chart1.Series("Age").Points.AddXY("Bruce", 42)
        Me.Chart1.Series("Mark").Points.AddXY("Bruce", 72)
    End Sub
End Class
