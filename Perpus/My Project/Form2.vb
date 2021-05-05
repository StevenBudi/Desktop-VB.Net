Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim datamhs As New Dictionary(Of String, String)()
        'Data pada combobox
        datamhs.Add("1120120046", "Muhamad Aldi Mudin Batu Bara")
        datamhs.Add("1120120045", "Pak Ogah")
        datamhs.Add("1120120044", "Pak Raden")
        datamhs.Add("1120120043", "Pak Gatot")
        datamhs.Add("1120120042", "Pak Bima")
        ComboBox1.DataSource = New BindingSource(datamhs, Nothing)
        ComboBox1.DisplayMember = "Key"
        ComboBox1.ValueMember = "Value"
        'Dim key As String = DirectCast(ComboBox1.SelectedItem, KeyValuePair(Of String, String)).Key
        'Dim value As String = DirectCast(ComboBox1.SelectedItem, KeyValuePair(Of String, String)).Value
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Label9.Text = ComboBox2.SelectedItem.ToString()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim telat As Integer
        'Check input hari
        Try
            telat = Int(TextBox1.Text)
        Catch ex As Exception
            MessageBox.Show("Tolong masukkan Angka yang valid")
            TextBox1.Text = ""
        End Try
        Dim denda = (telat * 3000).ToString()
        Label10.Text = "Telat " + telat.ToString() + " Hari"
        Label16.Text = "Denda yang dibayarkan Rp. " + denda
        Label15.Text = "Rp. " + denda

    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Label7.Text = DirectCast(ComboBox1.SelectedItem, KeyValuePair(Of String, String)).Key
        Label3.Text = DirectCast(ComboBox1.SelectedItem, KeyValuePair(Of String, String)).Value
        Label8.Text = DirectCast(ComboBox1.SelectedItem, KeyValuePair(Of String, String)).Value

    End Sub
End Class