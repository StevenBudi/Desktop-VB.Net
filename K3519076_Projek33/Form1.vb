Imports System.Text
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim street As String = TextBox1.Text
        Dim city As String = TextBox2.Text
        Dim state As String = TextBox3.Text
        Dim zip As String = TextBox4.Text

        Try
            Dim queryAddress As New StringBuilder
            queryAddress.Append("https://maps.google.com/maps?q=")
            If TextBox1.Text <> String.Empty Then
                queryAddress.Append(street + "," & ",")
            End If
            If TextBox2.Text <> String.Empty Then
                queryAddress.Append(city + "," & ",")
            End If
            If TextBox3.Text <> String.Empty Then
                queryAddress.Append(state + "," & ",")
            End If
            If TextBox4.Text <> String.Empty Then
                queryAddress.Append(zip + "," & ",")
            End If
            WebBrowser1.Navigate(queryAddress.ToString)
        Catch ex As Exception
            MessageBox.Show("Unable to retrieve data")
        End Try
    End Sub
End Class
