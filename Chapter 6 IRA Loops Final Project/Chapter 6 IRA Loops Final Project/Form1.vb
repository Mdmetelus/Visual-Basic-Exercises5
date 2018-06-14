Public Class Form1

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
            lstDisplay.Items.Add("")
            lstDisplay.Items.Add("Yr: " & Yr & " ---" & " Deposit Amount:  $" & CDec(Deposit))

        Next
        For Yr = 2032 To 2064
            EarlTotAmount *= +CDec(1 + Rate)
            lstDisplay1.Items.Add("")
            lstDisplay1.Items.Add("Yr: " & Yr & "--- $ " & CInt(EarlTotAmount) & " Total Amount")
        Next

        'Display Earl's Amounts
        txtEarlDep.Text = EarlTotDep.ToString("C")
        txtEarlEndAmount.Text = EarlTotAmount.ToString("C")
        lstDisplay.Items.Add("")
        lstDisplay.Items.Add("Total Amount Deposited: $" & EarlTotAmount)


        'Calculate Larry Ira

        For Yr = 2031 To 2064
            LarryTotAmount *= CDec(1 + Rate)
            LarryTotAmount += Deposit
            LarryTotDep += Deposit
            lstDisplay2.Items.Add("")
            lstDisplay2.Items.Add("Yr: " & Yr & " ---" & " Deposit Amount:  $" & CDec(Deposit))
            lstDisplay3.Items.Add("")
            lstDisplay3.Items.Add("Yr: " & Yr & "--- $ " & CInt(EarlTotAmount) & " Total Amount")
        Next
        'Display Larry's Amounts
        txtLarryDep.Text = LarryTotDep.ToString("C")
        txtLarryEndAmount.Text = LarryTotAmount.ToString("C")
        lstDisplay2.Items.Add("")
        lstDisplay2.Items.Add("Total Amount Deposited: $" & LarryTotAmount)
    End Sub





    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        MessageBox.Show("Have A Nice Day")
        Me.Close()
    End Sub




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Form3.Show()
    End Sub

    Private Sub lstDisplay_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstDisplay.SelectedIndexChanged

    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstDisplay3.SelectedIndexChanged

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        Form4.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
        Form5.Show()
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub txtEarlDep_TextChanged(sender As Object, e As EventArgs) Handles txtEarlDep.TextChanged

    End Sub
End Class
