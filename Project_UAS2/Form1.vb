Imports System.Data.OleDb
Imports System.Security.Cryptography
Imports System.Text
Public Class Form1
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\UAS_DB.accdb")
    Private Function SHA256(Content As String)
        Dim hash As New SHA256CryptoServiceProvider
        Dim byteString() As Byte = Encoding.ASCII.GetBytes(Content)
        byteString = hash.ComputeHash(byteString)
        Dim finalString As String = Nothing
        For Each bt As Byte In byteString
            finalString &= bt.ToString("x2")
        Next
        Return finalString
    End Function
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        TextBox2.PasswordChar = "*"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim query = "SELECT * FROM Master Where UserName ='" + TextBox1.Text + "' AND Password = '" + SHA256(TextBox2.Text) + "'"
        Try
            con.Open()
            Dim cmd As OleDbCommand = New OleDbCommand(query, con)
            Dim dat As OleDbDataReader = cmd.ExecuteReader()
            If (dat.Read() = True) Then
                Form2.Show()
            Else
                MsgBox("Login Gagal")
            End If
        Catch ex As Exception
            MsgBox(ex)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form2.Hide()
    End Sub
End Class
