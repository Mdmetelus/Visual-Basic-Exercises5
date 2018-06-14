Public Class CoffeeAbsorption
    Const CoffElimRate As Double = 0.13
    Dim Bal As Integer = 65
    'Dim Bal, hour, hours As Integer
    'Dim OneTime, twotime, NewBal As Double
    
    Private Sub btncompute_Click(sender As Object, e As EventArgs) Handles btncompute.Click
        

        'Const CoffElimRate As Double = 0.13
        Dim Bal As Integer = 65
        Dim hours As Integer = 0
        For i As Integer = 65 To 0 Step -13%
            hours += 1
            lstDisplay.Items.Add("")
            lstDisplay.Items.Add(hours & " Hours")
            txtOunces.Text = CStr(hours) & " Hours"
        Next
        

        Dim mgs As Double = 130
        Dim mgs2 As Double = 130

        For i As Integer = 1 To 24 Step 1
            mgs2 = CDbl(mgs * 0.13)
            mgs = mgs - mgs2
            'lstDisplay.Items.Clear()
            lstDisplay2.Items.Add("")
            lstDisplay2.Items.Add(Math.Round(mgs, 3) & " mgs Left! " & i & " Hours have passed.")
            txtMgCaff.Text = (CStr(Math.Round(mgs, 2)) & "mgs Left")

        Next
        Dim mgs3 As Double = 130
        For i As Integer = 1 To 24 Step 1
            mgs2 = CDbl(mgs * 0.13)
            mgs = ((mgs - mgs2) + mgs3)

            lstDisplay3.Items.Add("")
            lstDisplay3.Items.Add(Math.Round(mgs, 3) & " mgs Left! " & i & " Hours have passed.")
            txtTime.Text = (CStr(Math.Round(mgs, 2)) & "mgs Left")
        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        MessageBox.Show("Time to Stop Counting And Buy Some Coffee!")
        MessageBox.Show("Have a Nice Day")
        Me.Close()
    End Sub
End Class
