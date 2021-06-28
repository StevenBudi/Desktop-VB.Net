Public Class Form1

    Dim Transaction As String = "0"
    Dim restrict = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        End If
        DisplayBox.Text = Transaction
    End Sub

    Private Sub TripleZeroButton_Click(sender As Object, e As EventArgs) Handles TripleZeroButton.Click
        If Transaction <> "0" Then
            Transaction += "000"
        End If
        DisplayBox.Text = Transaction
    End Sub

    Private Sub CommaButton_Click(sender As Object, e As EventArgs) Handles CommaButton.Click
        If Transaction.Length > 0 Then
            If Transaction.Contains(",") Then
                Transaction += ""
            Else
                Transaction += ","
            End If
        Else
            Transaction += "0,"
        End If
        DisplayBox.Text = Transaction
    End Sub

    Private Sub ButtonOne_Click(sender As Object, e As EventArgs) Handles ButtonOne.Click
        If Transaction = "0" Then
            Transaction = "1"
        Else
            Transaction += "1"
        End If
        DisplayBox.Text = Transaction
    End Sub

    Private Sub ButtonTwo_Click(sender As Object, e As EventArgs) Handles ButtonTwo.Click
        If Transaction = "0" Then
            Transaction = "2"
        Else
            Transaction += "2"
        End If
        DisplayBox.Text = Transaction
    End Sub

    Private Sub ButtonThree_Click(sender As Object, e As EventArgs) Handles ButtonThree.Click
        If Transaction = "0" Then
            Transaction = "3"
        Else
            Transaction += "3"
        End If
        DisplayBox.Text = Transaction
    End Sub

    Private Sub ButtonFour_Click(sender As Object, e As EventArgs) Handles ButtonFour.Click
        If Transaction = "0" Then
            Transaction = "4"
        Else
            Transaction += "4"
        End If
        DisplayBox.Text = Transaction
    End Sub

    Private Sub ButtonFive_Click(sender As Object, e As EventArgs) Handles ButtonFive.Click
        If Transaction = "0" Then
            Transaction = "5"
        Else
            Transaction += "5"
        End If
        DisplayBox.Text = Transaction
    End Sub

    Private Sub ButtonSix_Click(sender As Object, e As EventArgs) Handles ButtonSix.Click
        If Transaction = "0" Then
            Transaction = "6"
        Else
            Transaction += "6"
        End If
        DisplayBox.Text = Transaction
    End Sub

    Private Sub ButtonSeven_Click(sender As Object, e As EventArgs) Handles ButtonSeven.Click
        If Transaction = "0" Then
            Transaction = "7"
        Else
            Transaction += "7"
        End If
        DisplayBox.Text = Transaction
    End Sub

    Private Sub ButtonEight_Click(sender As Object, e As EventArgs) Handles ButtonEight.Click
        If Transaction = "0" Then
            Transaction = "8"
        Else
            Transaction += "8"
        End If
        DisplayBox.Text = Transaction
    End Sub

    Private Sub ButtonNine_Click(sender As Object, e As EventArgs) Handles ButtonNine.Click
        If Transaction = "0" Then
            Transaction = "9"
        Else
            Transaction += "9"
        End If
        DisplayBox.Text = Transaction
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        Transaction = "0"
        DisplayBox.Text = Transaction
    End Sub

    Private Sub BackspaceButton_Click(sender As Object, e As EventArgs) Handles BackspaceButton.Click
        Transaction = Transaction.Substring(0, Transaction.Length - 1)
        DisplayBox.Text = Transaction
    End Sub

    Private Sub ModuloButton_Click(sender As Object, e As EventArgs) Handles ModuloButton.Click
        Calculate(Transaction)
        Transaction += "%"
        DisplayBox.Text = Transaction
    End Sub

    Private Sub DivideButton_Click(sender As Object, e As EventArgs) Handles DivideButton.Click
        Calculate(Transaction)
        Transaction += "/"
        DisplayBox.Text = Transaction
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        Calculate(Transaction)
        Transaction += "+"
        DisplayBox.Text = Transaction
    End Sub

    Private Sub SubstractButton_Click(sender As Object, e As EventArgs) Handles SubstractButton.Click
        Calculate(Transaction)
        Transaction += "-"
        DisplayBox.Text = Transaction
    End Sub

    Private Sub MultiplyButton_Click(sender As Object, e As EventArgs) Handles MultiplyButton.Click
        Calculate(Transaction)
        Transaction += "*"
        DisplayBox.Text = Transaction
    End Sub

    Sub AdvanceCalculate(Query As String, caseCalculation As String)
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
                Case "root"
                    res = Math.Sqrt(Integer.Parse(Query))
            End Select
        End If
        Transaction = res

    End Sub
    Sub Calculate(Query As String)
        Dim res = New DataTable().Compute(Query, Nothing)
        Transaction = res
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
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
End Class
