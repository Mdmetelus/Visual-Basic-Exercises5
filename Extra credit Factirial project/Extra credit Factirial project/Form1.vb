Public Class factorialCalculator
    'Dim OneTime, twotime, NewBal As Double
    Dim Factorial, N, N1 As Integer

    Function FactorialFunction(N1 As Integer) As Integer
        Factorial = 1
        If N >= 0 Then
            For i = N To 1 Step -1

                Factorial = Factorial * i

                '    lstDisplay.Items.Add("")
                '    lstDisplay.Items.Add(" answer" & CStr(Z))
            Next
        Else
            Factorial = -1
        End If

        Return Factorial
    End Function
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtNumber.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btncompute.Click
        Dim Fact As Integer
        N = CInt(txtNumber.Text)
        Fact = FactorialFunction(N1)
        lstDisplay.Items.Add("")
        lstDisplay.Items.Add(Fact & " Is the Answer to The Factorial Of " & N & " .")
    End Sub
End Class
