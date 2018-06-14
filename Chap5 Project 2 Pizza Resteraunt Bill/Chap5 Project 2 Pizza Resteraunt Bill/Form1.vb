Public Class Form1
    Dim Quant1 As Integer
    Dim Quant2 As Integer
    Dim Quant3 As Integer
    Dim Price1 As Double = 1.75
    Dim Price2 As Double = 2.0
    Dim Price3 As Double = 1.25
    Dim SliceCost, FriesCost, DrinkCost As Double
    Function Grandtotal() As Double
        Return (Quant1 * Price1) + (Quant2 * Price2) + (Quant3 * Price3)
    End Function

    Function FindSubtotal2() As Double
        Return (Quant2 * Price2)
    End Function
    Function FindSubtotal3() As Double
        Return (Quant3 * Price3)
    End Function
    Function FindSubtotal1() As Double
        Return (Quant1 * Price1)
    End Function
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Quant1 += CInt(txtSlices.Text)
        Quant2 += CInt(txtFries.Text)
        Quant3 += CInt(txtSodas.Text)
        SliceCost = Quant1 * Price1
        FriesCost = Quant2 * Price2
        DrinkCost = Quant3 * Price3

        lstDisplay.Items.Clear()
        lstDisplay.Items.Add(Now())
        lstDisplay.Items.Add("")
        lstDisplay.Items.Add("ITEMS" & "                                    " & " QUANTITY " & "                   " & "PRICE")
        lstDisplay.Items.Add("")
        lstDisplay.Items.Add("Pizza Slices @ $1.75 Each:" & "                " & Quant1 & "                          " & "$" & SliceCost)
        lstDisplay.Items.Add("")
        lstDisplay.Items.Add("Fries @ $2.00 Each:" & "                            " & Quant2 & "                       " & "$" & FriesCost)
        lstDisplay.Items.Add("")
        lstDisplay.Items.Add("Soft Drinks @ $1.25 Each:" & "                   " & Quant3 & "                     " & "$" & DrinkCost)
        lstDisplay.Items.Add("")
        lstDisplay.Items.Add("The Grand Total Of your Order Is:" & "                                 " & "$" & Grandtotal())
        lstDisplay.Items.Add("")
        lstDisplay.Items.Add("Thank You For Your Order. Please Come Again Soon!")

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        MessageBox.Show("Enjoy Your Meal!")
        Me.Close()
    End Sub
End Class