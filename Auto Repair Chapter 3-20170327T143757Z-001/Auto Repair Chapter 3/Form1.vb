Public Class frmAutoRepair
    'Dim WHS As String
    'WHS = CDbl(txtWorkHrs.Text)
    '(WHS * 35).ToString("C")
    'Dim X As String
    'X = 35 * WHS

    '(WHS * 35).ToString("C")
    'Dim  As Double = CDbl(txtSupplyCost.Text)

    'wHS = CDbl(TxtWorkHrs.text )


    Private Sub txtWorkHrs_TextChanged(sender As Object, e As EventArgs) Handles txtWorkHrs.TextChanged

    End Sub

    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Dim x, y As Double
        x = CDbl(txtWorkHrs.Text)
        y = 35
        Dim answer As Double
        answer = x * y
        Dim z, u, answer2, answer3 As Double
        z = CDbl(txtSupplyCost.Text)
        u = 1.05
        answer2 = z * u
        answer3 = answer2 + answer
        lstTotal.Items.Clear()
        lstTotal.Items.Add("Customer Name:      " & txtName.Text)
        lstTotal.Items.Add("Labor Costs:    $" & answer)
        lstTotal.Items.Add("Parts Costs:    $" & answer2)
        lstTotal.Items.Add("Total Costs:    $" & answer3)
        'lstTotal.Items.Add("Customer Name:      "&""&_
        '                   "Labor Costs:    $" & &_
        '                   "Parts Costs:    $" & )

        'txtWorkHrs.Text() = C(txtWorkHrs)
        ' lstTotal.Items.Add(X)

        'WHS = CDbl(txtWorkHrs.Text)
        'WHS * 35 = X
        'lstTotal.Items.Clear()
        'lstTotal.Items.Add("Customer Name:      " & txtName.Text)
        ''lstTotal.Items.Add("Labor Costs:    $" & X) '(WHS * 35).ToString("C"))
        'lstTotal.Items.Add("Parts Costs:    $" & 8)
        'lstTotal.Items.Add("Total Costs:    $" & 9)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnCostomerInfo.Click
        lstTotal.Items.Clear()
        lstTotal.Items.Add("Customer Name:      " & txtName.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnLaborInfo.Click
        Dim x, y As Double
        x = CDbl(txtWorkHrs.Text)
        y = 35
        Dim answer As Double
        answer = x * y
        'txtWorkHrs.Text = x & " X " & y & " = " & answer
        lstTotal.Items.Clear()
        lstTotal.Items.Add("Labor Costs:    $" & answer)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnTotalCost.Click
        Dim x, y, z, u, answer, answer2, answer3 As Double
        x = CDbl(txtWorkHrs.Text)
        y = 35
        answer = x * y
        z = CDbl(txtSupplyCost.Text)
        u = 1.05
        answer2 = z * u
        answer3 = answer2 + answer

        lstTotal.Items.Clear()
        lstTotal.Items.Add("Labor Costs:    $" & answer)
        lstTotal.Items.Add("Parts Costs:    $" & answer2)
        lstTotal.Items.Add("Total Costs:    $" & answer3)
    End Sub

    Private Sub btnPartnSupplies_Click(sender As Object, e As EventArgs) Handles btnPartnSupplies.Click
        Dim z, u, answer2 As Double
        z = CDbl(txtSupplyCost.Text)
        u = 1.05
        answer2 = z * u
        lstTotal.Items.Clear()
        lstTotal.Items.Add("Parts Costs:    $" & answer2)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnClose.Click
        MessageBox.Show("Have A Nice Day")
        Close()
    End Sub
End Class