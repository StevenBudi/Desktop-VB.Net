Imports MySql.Data.MySqlClient
Public Class Form1

    Dim Transaction As String = "0"
    Dim TransactionLog = ""
    Dim restrict = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        openConnection()
        DisplayBox.Padding = New Padding(5, 5, 5, 5)
        DisplayBox.AutoSize = False
        DisplayBox.Text = Transaction
    End Sub
    Private Sub DisplayBox_TextChanged(sender As Object, e As EventArgs) Handles DisplayBox.TextChanged
        Dim temp As String = DisplayBox.Text
        Dim letter As String
        For i As Integer = 0 To DisplayBox.Text.Length - 1
            letter = DisplayBox.Text.Substring(i, 1)
            If restrict.Contains(letter) Then
                temp = DisplayBox.Text.Replace(letter, String.Empty)
            End If
        Next
        DisplayBox.Text = temp
        Transaction = DisplayBox.Text
    End Sub

    Private Sub SingleZeroButton_Click(sender As Object, e As EventArgs) Handles SingleZeroButton.Click
        If Transaction <> "0" Then
            Transaction += "0"
            TransactionLog += "0"
        End If
        DisplayBox.Text = Transaction
    End Sub

    Private Sub TripleZeroButton_Click(sender As Object, e As EventArgs) Handles TripleZeroButton.Click
        If Transaction <> "0" Then
            Transaction += "000"
            TransactionLog += "000"
        End If
        DisplayBox.Text = Transaction
    End Sub

    Private Sub CommaButton_Click(sender As Object, e As EventArgs) Handles CommaButton.Click
        If Transaction.Length > 0 Then
            If Transaction.Contains(",") Then
                Transaction += ""
                TransactionLog += ""
            Else
                Transaction += ","
                TransactionLog += ","
            End If
        Else
            Transaction += "0,"
            TransactionLog += "0,"
        End If
        DisplayBox.Text = Transaction
    End Sub

    Private Sub ButtonOne_Click(sender As Object, e As EventArgs) Handles ButtonOne.Click
        If Transaction = "0" Then
            Transaction = "1"
        Else
            Transaction += "1"
        End If
        TransactionLog += "1"
        DisplayBox.Text = Transaction
    End Sub

    Private Sub ButtonTwo_Click(sender As Object, e As EventArgs) Handles ButtonTwo.Click
        If Transaction = "0" Then
            Transaction = "2"
        Else
            Transaction += "2"
        End If
        TransactionLog += "2"
        DisplayBox.Text = Transaction
    End Sub

    Private Sub ButtonThree_Click(sender As Object, e As EventArgs) Handles ButtonThree.Click
        If Transaction = "0" Then
            Transaction = "3"
        Else
            Transaction += "3"
        End If
        TransactionLog += "3"
        DisplayBox.Text = Transaction
    End Sub

    Private Sub ButtonFour_Click(sender As Object, e As EventArgs) Handles ButtonFour.Click
        If Transaction = "0" Then
            Transaction = "4"
        Else
            Transaction += "4"
        End If
        TransactionLog += "4"
        DisplayBox.Text = Transaction
    End Sub

    Private Sub ButtonFive_Click(sender As Object, e As EventArgs) Handles ButtonFive.Click
        If Transaction = "0" Then
            Transaction = "5"
        Else
            Transaction += "5"
        End If
        TransactionLog += "5"
        DisplayBox.Text = Transaction
    End Sub

    Private Sub ButtonSix_Click(sender As Object, e As EventArgs) Handles ButtonSix.Click
        If Transaction = "0" Then
            Transaction = "6"
        Else
            Transaction += "6"
        End If
        TransactionLog += "6"
        DisplayBox.Text = Transaction
    End Sub

    Private Sub ButtonSeven_Click(sender As Object, e As EventArgs) Handles ButtonSeven.Click
        If Transaction = "0" Then
            Transaction = "7"
        Else
            Transaction += "7"
        End If
        TransactionLog += "7"
        DisplayBox.Text = Transaction
    End Sub

    Private Sub ButtonEight_Click(sender As Object, e As EventArgs) Handles ButtonEight.Click
        If Transaction = "0" Then
            Transaction = "8"
        Else
            Transaction += "8"
        End If
        TransactionLog += "8"
        DisplayBox.Text = Transaction
    End Sub

    Private Sub ButtonNine_Click(sender As Object, e As EventArgs) Handles ButtonNine.Click
        If Transaction = "0" Then
            Transaction = "9"
        Else
            Transaction += "9"
        End If
        TransactionLog += "9"
        DisplayBox.Text = Transaction
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        Dim confirmationBox As DialogResult = MessageBox.Show("Simpan Ke Database", "Konfirmasi", MessageBoxButtons.YesNo)
        If confirmationBox = DialogResult.Yes Then
            Try
                insertData(TransactionLog, Transaction)
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
        End If
        Transaction = "0"
        Transaction = Transaction
        DisplayBox.Text = Transaction
    End Sub

    Private Sub BackspaceButton_Click(sender As Object, e As EventArgs) Handles BackspaceButton.Click
        Transaction = Transaction.Substring(0, Transaction.Length - 1)
        TransactionLog = Transaction
        DisplayBox.Text = Transaction
    End Sub

    Private Sub ModuloButton_Click(sender As Object, e As EventArgs) Handles ModuloButton.Click
        Calculate(Transaction)
        Transaction += "%"
        TransactionLog += "%"
        DisplayBox.Text = Transaction
    End Sub

    Private Sub DivideButton_Click(sender As Object, e As EventArgs) Handles DivideButton.Click
        Calculate(Transaction)
        Transaction += "/"
        TransactionLog += "/"
        DisplayBox.Text = Transaction
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        Calculate(Transaction)
        Transaction += "+"
        TransactionLog += "+"
        DisplayBox.Text = Transaction
    End Sub

    Private Sub SubstractButton_Click(sender As Object, e As EventArgs) Handles SubstractButton.Click
        Calculate(Transaction)
        Transaction += "-"
        TransactionLog += "-"
        DisplayBox.Text = Transaction
    End Sub

    Private Sub MultiplyButton_Click(sender As Object, e As EventArgs) Handles MultiplyButton.Click
        Calculate(Transaction)
        Transaction += "*"
        TransactionLog += "*"
        DisplayBox.Text = Transaction
    End Sub

    Sub AdvanceCalculate(Query As String, caseCalculation As String)
        Query = Query.Replace(",", ".")
        Dim calculationRestrict = "+/%x-"
        Dim res = Transaction
        Dim able = 0
        For i As Integer = 0 To calculationRestrict.Length - 1
            If Not Query.Contains(calculationRestrict(i)) Then
                able += 1
            End If
        Next

        If able = 5 Then
            Select Case [caseCalculation]
                Case "power"
                    res = Math.Pow(Integer.Parse(Query), 2)
                    TransactionLog += "^2"
                Case "root"
                    res = Math.Sqrt(Integer.Parse(Query))
                    TransactionLog = "√(" & TransactionLog & ")"
                Case "log"
                    res = Math.Log(Integer.Parse(Query))
                    TransactionLog = "log(" & TransactionLog & ")"
                Case "sin"
                    res = Math.Round(Math.Sin(Double.Parse(res) * 4 * Math.Atan(1) / 180), 4)
                    TransactionLog = "sin(" & TransactionLog & ")"
                Case "cos"
                    res = Math.Round(Math.Cos(Double.Parse(res) * 4 * Math.Atan(1) / 180), 4)
                    TransactionLog = "cos(" & TransactionLog & ")"
                Case "tan"
                    res = Math.Round(Math.Tan(Double.Parse(res) * 4 * Math.Atan(1) / 180), 4)
                    TransactionLog = "tan(" & TransactionLog & ")"
                Case "sinh"
                    res = Math.Round(Math.Sinh(Double.Parse(res) * 4 * Math.Atan(1) / 180), 4)
                    TransactionLog = "sinh(" & TransactionLog & ")"
                Case "cosh"
                    res = Math.Round(Math.Cosh(Double.Parse(res) * 4 * Math.Atan(1) / 180), 4)
                    TransactionLog = "cosh(" & TransactionLog & ")"
                Case "tanh"
                    res = Math.Round(Math.Tanh(Double.Parse(res) * 4 * Math.Atan(1) / 180), 4)
                    TransactionLog = "tanh(" & TransactionLog & ")"
            End Select
        End If
        Transaction = res

    End Sub
    Sub Calculate(Query As String)
        Query = Query.Replace(",", ".")
        Dim res = New DataTable().Compute(Query, Nothing)
        Transaction = res
    End Sub

    Private Sub Equal_Click(sender As Object, e As EventArgs) Handles Equal.Click
        Calculate(Transaction)
        DisplayBox.Text = Transaction
    End Sub

    Private Sub ExponentButton_Click(sender As Object, e As EventArgs) Handles ExponentButton.Click
        AdvanceCalculate(Transaction, "power")
        DisplayBox.Text = Transaction
    End Sub

    Private Sub RootButton_Click(sender As Object, e As EventArgs) Handles RootButton.Click
        AdvanceCalculate(Transaction, "root")
        DisplayBox.Text = Transaction
    End Sub

    Private Sub LogButton_Click(sender As Object, e As EventArgs) Handles LogButton.Click
        AdvanceCalculate(Transaction, "log")
        DisplayBox.Text = Transaction
    End Sub

    Private Sub TanButton_Click(sender As Object, e As EventArgs) Handles TanButton.Click
        AdvanceCalculate(Transaction, "tan")
        DisplayBox.Text = Transaction
    End Sub

    Private Sub SinButton_Click(sender As Object, e As EventArgs) Handles SinButton.Click
        AdvanceCalculate(Transaction, "sin")
        DisplayBox.Text = Transaction
    End Sub

    Private Sub CosButton_Click(sender As Object, e As EventArgs) Handles CosButton.Click
        AdvanceCalculate(Transaction, "cos")
        DisplayBox.Text = Transaction
    End Sub

    Private Sub CosMinButton_Click(sender As Object, e As EventArgs) Handles CosMinButton.Click
        AdvanceCalculate(Transaction, "cosh")
        DisplayBox.Text = Transaction
    End Sub

    Private Sub SinMinButton_Click(sender As Object, e As EventArgs) Handles SinMinButton.Click
        AdvanceCalculate(Transaction, "sinh")
        DisplayBox.Text = Transaction
    End Sub

    Private Sub TanMinButton_Click(sender As Object, e As EventArgs) Handles TanMinButton.Click
        AdvanceCalculate(Transaction, "tanh")
        DisplayBox.Text = Transaction
    End Sub

    Private Sub HistoryButton_Click(sender As Object, e As EventArgs) Handles HistoryButton.Click
        Form2.Show()
    End Sub
End Class
