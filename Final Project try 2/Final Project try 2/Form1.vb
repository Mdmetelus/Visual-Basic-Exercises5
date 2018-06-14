Public Class Form1
    'Setup variable
    Dim DepositA, DepositB As Decimal
    Dim RateA As Double = 0.0184
    Dim RateB As Double = 0.0184
    Dim MethodATotalDep, MethodBTotalDep As Decimal
    Dim MethodATotalAmount, MethodBTotalAmount As Decimal
    Dim MethodAYearBegin, MethodAYearEnd, MethodBYearBegin, MethodBYearEnd, MethodAYrRetire As Integer

    'Setup variable
    'Dim DepositB As Decimal
    'Dim RateB As Double

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ''Setup variable


        MethodAYearEnd = CInt(txtYrEndA.Text)
        MethodAYearBegin = CInt(txtyrBeginA.Text)
        MethodATotalAmount = CDec(txt1stDepA.Text)
        DepositA = CDec(txtAnnualAddA.Text)
        'Calculate MethodA Ira
        For Yr = MethodAYearBegin To MethodAYearEnd Step 1
            MethodATotalAmount *= CDec(1 + RateA)
            MethodATotalAmount += DepositA
            lstDisplay.Items.Add("")
            lstDisplay.Items.Add("Yr: " & Yr & " ---" & " Deposit Amount:  $" & CDec(DepositA))
        Next
        lstDisplay.Items.Add("")
        lstDisplay.Items.Add("Total Amount Deposited: $" & CDec(MethodATotalAmount))
        txtAEndAmount.Text = MethodATotalAmount.ToString("C")
        MethodAYrRetire = CInt(txtRetireA.Text)
        For Yr = MethodAYearEnd + 1 To MethodAYrRetire Step 1
            MethodATotalAmount *= CDec(1 + RateA)
            lstDisplay1.Items.Add("")
            lstDisplay1.Items.Add("Yr: " & Yr & "--- $ " & CInt(MethodATotalAmount) & " Total Amount")
        Next
        Dim Year = CInt(txtRetireA.Text)
        Dim Months As Integer
        Dim A As Decimal

        Do While MethodATotalAmount >= 0
            MethodATotalAmount -= CDec(txtAnnualOutA.Text)
            A = MethodATotalAmount * CDec(RateA / 12)
            MethodATotalAmount += A
            Months += 1
            lstDisplay4.Items.Add("")
            lstDisplay4.Items.Add("Month " & Months & "--- $ " & Math.Round(MethodATotalAmount, 2) & " Left")
            lstDisplay5.Items.Add("")
            lstDisplay5.Items.Add("Month: " & Months & " ---" & " WithDraw:  $" & CDec(txtAnnualOutA.Text))
        Loop
        Dim EndingMonth As Integer
        EndingMonth = CInt(Months) - 1


        txtTimeLastA.Text = CInt(EndingMonth).ToString("N")

        lstDisplay.Items.Add("")
        lstDisplay.Items.Add(" Initial Deposit: $" & CDec(txt1stDepA.Text))


    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        MessageBox.Show("Have A Nice Day")
        Me.Close()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        Me.Hide()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Me.Hide()

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        Me.Hide()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

    Private Sub TextBox12_TextChanged(sender As Object, e As EventArgs) Handles txtTimeLastA.TextChanged

    End Sub

    Private Sub BtnBOnly_Click(sender As Object, e As EventArgs) Handles BtnBOnly.Click

        MethodBYearEnd = CInt(txtYrEndB.Text)
        MethodBYearBegin = CInt(txtYrBeginB.Text)
        MethodBTotalAmount = CDec(txt1stDepB.Text)
        DepositB = CDec(txtAnnualAddB.Text)
        'Calculate MethodA Ira
        For Yr = MethodBYearBegin To MethodBYearEnd Step 1
            MethodBTotalAmount *= CDec(1 + RateB)
            MethodBTotalAmount += DepositB
            lstDisplay2.Items.Add("")
            lstDisplay2.Items.Add("Yr: " & Yr & " ---" & " Deposit Amount:  $" & CDec(DepositB))
        Next
        lstDisplay2.Items.Add("")
        lstDisplay2.Items.Add("Total Amount Deposited: $" & CDec(MethodBTotalAmount))
        txtBEndAmount.Text = MethodBTotalAmount.ToString("C")
        MethodAYrRetire = CInt(txtYrEndB.Text)
        For Yr = MethodBYearEnd + 1 To MethodBYearEnd Step 1
            MethodBTotalAmount *= CDec(1 + RateB)
            'lstDisplay3.Items.Add("")
            'lstDisplay3.Items.Add("Yr: " & Yr & "--- $ " & Math.Round(CInt(MethodBTotalAmount), 2) & " Total Amount")
        Next
        Dim YearB = CInt(txtYrEndB.Text)
        Dim MonthsB As Integer
        Dim AB As Decimal

        Do While MethodBTotalAmount >= 0
            MethodBTotalAmount -= CDec(txtAnnualOutB.Text)
            AB = MethodBTotalAmount * CDec(RateB / 12)
            MethodBTotalAmount += AB
            MonthsB += 1
            lstDisplay6.Items.Add("")
            lstDisplay6.Items.Add("Month " & MonthsB & "--- $ " & Math.Round(MethodBTotalAmount, 2) & " Left")
            lstDisplay7.Items.Add("")
            lstDisplay7.Items.Add("Month: " & MonthsB & " ---" & " WithDraw:  $" & CDec(txtAnnualOutB.Text))
        Loop
        Dim EndingMonthB As Integer
        EndingMonthB = CInt(MonthsB) - 1


        txtTimeLastB.Text = CInt(EndingMonthB).ToString("N")

        lstDisplay2.Items.Add("")
        lstDisplay2.Items.Add(" Initial Deposit: $" & CDec(txt1stDepB.Text))


    End Sub
End Class
