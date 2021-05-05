Public Class Form1
    Dim I As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim N As String
        I = (I + 1) Mod 4
        N = InputBox("Enter Node")
        If N IsNot "" Then
            If TreeView1.SelectedNode Is Nothing Then
                TreeView1.Nodes.Add(N, N, I, I)
            Else
                TreeView1.SelectedNode.Nodes.Add(N, N, I, I)
            End If
        End If
    End Sub
End Class
