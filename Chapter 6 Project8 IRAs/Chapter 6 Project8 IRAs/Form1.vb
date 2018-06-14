Public Class IRA
   
    Private Sub IRA_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Setup variable
        Dim Deposit As Decimal = 5000
        Dim Rate As Double = 0.04
        Dim EarlTotDep As Decimal = 0
        Dim LarryTotDep As Decimal = 0
        Dim EarlTotAmount As Decimal = 0
        Dim LarryTotAmount As Decimal = 0

        'Calculate Earl Ira

        For Yr = 2016 To 2031
            EarlTotAmount *= CDec(1 + Rate)
            EarlTotAmount += Deposit
            EarlTotDep += Deposit
        Next
        For Yr = 2032 To 2064
            EarlTotAmount *= +CDec(1 + Rate)
        Next

        'Display Earl's Amounts
        txtEarlDep.Text = EarlTotDep.ToString("C")
        txtEarlEndAmount.Text = EarlTotAmount.ToString("C")


        'Calculate Larry Ira

        For Yr = 2031 To 2064
            LarryTotAmount *= CDec(1 + Rate)
            LarryTotAmount += Deposit
            LarryTotDep += Deposit
        Next
        'Display Larry's Amounts
        txtLarryDep.Text = LarryTotDep.ToString("C")
        txtLarryEndAmount.Text = LarryTotAmount.ToString("C")

    End Sub





    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        MessageBox.Show("Have A Nice Day")
        Me.Close()
    End Sub




End Class
