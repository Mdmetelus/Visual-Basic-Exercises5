Public Class Form1
    Dim CharmBracelet, X, Charms, Sandwich, Fries, Drink, orderTotal As Double
    'X = CDbl(txtQuantity2.Text)
    Dim I, J, K, L, Z As Double
    Dim CITotal, PriceTotal, Tax, TaxAmout, TaxAmount, Shipping, TotalCharge, TotalCharge2 As Double
    Dim A, B, C, D, H, F As Double
    Dim orderTotalCharms As Double
    Dim CrochetedItem, Hat, Gloves, Scarf, Wrap, ItemColor, O As String

    Function InfoButton1() As Double
        Tax = 0.0875
        If IsNumeric(TxtQuantity.Text) Then
            Z = CDbl(TxtQuantity.Text)
        ElseIf TxtQuantity.Text = "" Then
            Z = 0
        Else
            MessageBox.Show("Please put in a Number Value Here")
            txtQuantity2.Focus()
            Close()
        End If

        Z = CDbl(TxtQuantity.Text)
        If radHandCI.Checked And rad1Hat.Checked Then
            I = 10
            J = 0.0
            K = 0.0
            L = 0.0
        ElseIf radHandCI.Checked And rad2Gloves.Checked Then
            I = 0.0
            J = 12.0
            K = 0.0
            L = 0.0
        ElseIf radHandCI.Checked And rad3Scarf.Checked Then
            I = 0.0
            J = 0.0
            K = 12.0
            L = 0.0
        ElseIf radHandCI.Checked And Rad4Wrap.Checked Then
            I = 0.0
            J = 0.0
            K = 0.0
            L = 25.0
        Else
            I = 0.0
            J = 0.0
            K = 0.0
            L = 0.0
        End If


        PriceTotal = (I * Z) + (J * Z) + (K * Z) + (L * Z)

        Dim CrochetedItem As String
        If radHandCI.Checked And rad1Hat.Checked Then
            CrochetedItem = "Hat"
        ElseIf radHandCI.Checked And rad2Gloves.Checked Then
            CrochetedItem = "Gloves"
        ElseIf radHandCI.Checked And rad3Scarf.Checked Then
            CrochetedItem = "Scarf"
        ElseIf radHandCI.Checked And Rad4Wrap.Checked Then
            CrochetedItem = "Wrap"
        Else
            CrochetedItem = O
            MessageBox.Show("Pleae Choose A Crochered  Item,If you'd Like to Make A Purchace.")
        End If

        TaxAmout = PriceTotal * Tax

        If radHandCI.Checked And radStandardShip.Checked Then
            Shipping = 2.95
        ElseIf radHandCI.Checked And radShipPriority.Checked Then
            Shipping = 9.95
        ElseIf radHandCI.Checked And radShipNextDay.Checked Then
            Shipping = 14.95
        Else
            Shipping = 0
        End If

        TotalCharge = PriceTotal + TaxAmout + Shipping

        Dim ItemColor As String
        If radHandCI.Checked And radCBlack.Checked Then
            ItemColor = "Black"
        ElseIf radHandCI.Checked And radCBlue.Checked Then
            ItemColor = "Blue"
        ElseIf radHandCI.Checked And radCGray.Checked Then
            ItemColor = "Gray"
        ElseIf radHandCI.Checked And radCWhite.Checked Then
            ItemColor = "White"
        ElseIf radHandCI.Checked And radCRed.Checked Then
            ItemColor = "Red"
        Else
            ItemColor = O
            MessageBox.Show("Pleae Choose A Crochered Item, If you'd Like to Make A Purchace.")
        End If

        Return TotalCharge
    End Function

    Function InfoButton11() As String
        Dim CrochetedItem As String
        If radHandCI.Checked And rad1Hat.Checked Then
            CrochetedItem = "Hat"
        ElseIf radHandCI.Checked And rad2Gloves.Checked Then
            CrochetedItem = "Gloves"
        ElseIf radHandCI.Checked And rad3Scarf.Checked Then
            CrochetedItem = "Scarf"
        ElseIf radHandCI.Checked And Rad4Wrap.Checked Then
            CrochetedItem = "Wrap"
        Else
            CrochetedItem = O
            MessageBox.Show("Pleae Choose A Crochered  Item,If you'd Like to Make A Purchace.")
        End If

        Return CrochetedItem
    End Function

    Function InfoButton111() As String


        Dim ItemColor As String
        If radHandCI.Checked And radCBlack.Checked Then
            ItemColor = "Black"
        ElseIf radHandCI.Checked And radCBlue.Checked Then
            ItemColor = "Blue"
        ElseIf radHandCI.Checked And radCGray.Checked Then
            ItemColor = "Gray"
        ElseIf radHandCI.Checked And radCWhite.Checked Then
            ItemColor = "White"
        ElseIf radHandCI.Checked And radCRed.Checked Then
            ItemColor = "Red"
        Else
            ItemColor = O
            MessageBox.Show("Pleae Choose A Crochered  Item,If you'd Like to Make A Purchace.")
        End If
        Return ItemColor
    End Function

    Function InfoButton2() As Double

        Tax = 0.0875
        If IsNumeric(TxtQuantity.Text) Then
            Z = CDbl(TxtQuantity.Text)
        ElseIf TxtQuantity.Text = "" Then
            Z = 0
        Else
            MessageBox.Show("Please put in a Number Value Here")
            txtQuantity2.Focus()
            Close()
        End If

        Z = CDbl(TxtQuantity.Text)
        If radHandCI.Checked And rad1Hat.Checked Then
            I = 10
            J = 0.0
            K = 0.0
            L = 0.0
        ElseIf radHandCI.Checked And rad2Gloves.Checked Then
            I = 0.0
            J = 12.0
            K = 0.0
            L = 0.0
        ElseIf radHandCI.Checked And rad3Scarf.Checked Then
            I = 0.0
            J = 0.0
            K = 12.0
            L = 0.0
        ElseIf radHandCI.Checked And Rad4Wrap.Checked Then
            I = 0.0
            J = 0.0
            K = 0.0
            L = 25.0
        Else
            I = 0.0
            J = 0.0
            K = 0.0
            L = 0.0
        End If


        PriceTotal = (I * Z) + (J * Z) + (K * Z) + (L * Z)

        Dim CrochetedItem As String
        If radHandCI.Checked And rad1Hat.Checked Then
            CrochetedItem = "Hat"
        ElseIf radHandCI.Checked And rad2Gloves.Checked Then
            CrochetedItem = "Gloves"
        ElseIf radHandCI.Checked And rad3Scarf.Checked Then
            CrochetedItem = "Scarf"
        ElseIf radHandCI.Checked And Rad4Wrap.Checked Then
            CrochetedItem = "Wrap"
        Else
            CrochetedItem = O
            MessageBox.Show("Pleae Choose A Crochered  Item,If you'd Like to Make A Purchace.")
        End If

        TaxAmout = PriceTotal * Tax

        If radHandCI.Checked And radStandardShip.Checked Then
            Shipping = 2.95
        ElseIf radHandCI.Checked And radShipPriority.Checked Then
            Shipping = 9.95
        ElseIf radHandCI.Checked And radShipNextDay.Checked Then
            Shipping = 14.95
        Else
            Shipping = 0
        End If

        TotalCharge = PriceTotal + TaxAmout + Shipping

        Dim ItemColor As String
        If radHandCI.Checked And radCBlack.Checked Then
            ItemColor = "Black"
        ElseIf radHandCI.Checked And radCBlue.Checked Then
            ItemColor = "Blue"
        ElseIf radHandCI.Checked And radCGray.Checked Then
            ItemColor = "Gray"
        ElseIf radHandCI.Checked And radCWhite.Checked Then
            ItemColor = "White"
        ElseIf radHandCI.Checked And radCRed.Checked Then
            ItemColor = "Red"
        Else
            ItemColor = O
            MessageBox.Show("Pleae Choose A Crochered Item, If you'd Like to Make A Purchace.")
        End If

        Return TotalCharge
    End Function

    Function InfoButton22() As String

        Dim CrochetedItem As String
        If radHandCI.Checked And rad1Hat.Checked Then
            CrochetedItem = "Hat"
        ElseIf radHandCI.Checked And rad2Gloves.Checked Then
            CrochetedItem = "Gloves"
        ElseIf radHandCI.Checked And rad3Scarf.Checked Then
            CrochetedItem = "Scarf"
        ElseIf radHandCI.Checked And Rad4Wrap.Checked Then
            CrochetedItem = "Wrap"
        Else
            CrochetedItem = O
            MessageBox.Show("Pleae Choose A Crochered  Item,If you'd Like to Make A Purchace.")
        End If

        Return CrochetedItem
    End Function

    Function InfoButton222() As String

        Dim ItemColor As String
        If radHandCI.Checked And radCBlack.Checked Then
            ItemColor = "Black"
        ElseIf radHandCI.Checked And radCBlue.Checked Then
            ItemColor = "Blue"
        ElseIf radHandCI.Checked And radCGray.Checked Then
            ItemColor = "Gray"
        ElseIf radHandCI.Checked And radCWhite.Checked Then
            ItemColor = "White"
        ElseIf radHandCI.Checked And radCRed.Checked Then
            ItemColor = "Red"
        Else
            ItemColor = O
            MessageBox.Show("Pleae Choose A Crochered  Item,If you'd Like to Make A Purchace.")
        End If

        Return ItemColor
    End Function



    Function InfoButton5() As Double
        Dim Y As Double
        Tax = 0.0875
        If IsNumeric(txtQuantity2.Text) Then
            Y = CDbl(txtQuantity2.Text)
        ElseIf txtQuantity2.Text = "" Then
            Y = 0
        Else
            MessageBox.Show("Please put in a Number Value Here")
            txtQuantity2.Focus()
            Close()
        End If

        If (radCharmBrace.Checked) Then
            CharmBracelet = 10.0
        Else
            CharmBracelet = 0.0
        End If

        'Dim A, B, C, D, H, F As Double
        'Dim orderTotalCharms As Double
        If radCharmBrace.Checked And chk1Cat.Checked Then
            A = 2
        Else
            A = 0
        End If
        If radCharmBrace.Checked And chk2Dog.Checked Then
            B = 2
        Else
            B = 0
        End If
        If radCharmBrace.Checked And chk3Flower.Checked Then
            C = 2
        Else
            C = 0
        End If
        If radCharmBrace.Checked And chk4Rabbit.Checked Then
            D = 2
        Else
            D = 0
        End If
        If radCharmBrace.Checked And chk5SnowFlake.Checked Then
            H = 2
        Else
            H = 0
        End If
        If radCharmBrace.Checked And chk6Star.Checked Then
            F = 2
        Else
            F = 0
        End If
        Charms = ((A * Y) + (B * Y) + (C * Y) + (D * Y) + (H * Y) + (F * Y))

        orderTotalCharms = CDbl(CharmBracelet + Charms)

        TaxAmount = orderTotalCharms * Tax

        If radCharmBrace.Checked And radStandardShip.Checked Then
            Shipping = 2.95
        ElseIf radCharmBrace.Checked And radShipPriority.Checked Then
            Shipping = 9.95
        ElseIf radCharmBrace.Checked And radShipNextDay.Checked Then
            Shipping = 14.95
        Else
            Shipping = 0
        End If

        TotalCharge2 = orderTotalCharms + TaxAmount + Shipping

        Return TotalCharge2

    End Function

    Function InfoButton4() As Double
        Tax = 0.0875

        Dim Y As Double
        If IsNumeric(txtQuantity2.Text) Then
            Y = CDbl(txtQuantity2.Text)
        ElseIf txtQuantity2.Text = "" Then
            Y = 0
        Else
            MessageBox.Show("Please put in a Number Value Here")
            txtQuantity2.Focus()
            Close()
        End If

        Y = CDbl(txtQuantity2.Text)

        If (radCharmBrace.Checked) Then
            CharmBracelet = 10.0
        Else
            CharmBracelet = 0.0
        End If


        'Dim A, B, C, D, H, F As Double
        'Dim orderTotalCharms As Double
        If radCharmBrace.Checked And chk1Cat.Checked Then
            A = 2
        Else
            A = 0
        End If
        If radCharmBrace.Checked And chk2Dog.Checked Then
            B = 2
        Else
            B = 0
        End If
        If radCharmBrace.Checked And chk3Flower.Checked Then
            C = 2
        Else
            C = 0
        End If
        If radCharmBrace.Checked And chk4Rabbit.Checked Then
            D = 2
        Else
            D = 0
        End If
        If radCharmBrace.Checked And chk5SnowFlake.Checked Then
            H = 2
        Else
            H = 0
        End If
        If radCharmBrace.Checked And chk6Star.Checked Then
            F = 2
        Else
            F = 0
        End If
        Charms = ((A * Y) + (B * Y) + (C * Y) + (D * Y) + (H * Y) + (F * Y))

        orderTotalCharms = CDbl(CharmBracelet + Charms)

        TaxAmount = orderTotalCharms * Tax

        If radCharmBrace.Checked And radStandardShip.Checked Then
            Shipping = 2.95
        ElseIf radCharmBrace.Checked And radShipPriority.Checked Then
            Shipping = 9.95
        ElseIf radCharmBrace.Checked And radShipNextDay.Checked Then
            Shipping = 14.95
        Else
            Shipping = 0
        End If

        TotalCharge2 = orderTotalCharms + TaxAmount + Shipping

        Return TotalCharge2
    End Function


    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter



    End Sub


    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub chk3Flower_CheckedChanged(sender As Object, e As EventArgs) Handles chk3Flower.CheckedChanged

    End Sub

    Private Sub chk4Rabbit_CheckedChanged(sender As Object, e As EventArgs) Handles chk4Rabbit.CheckedChanged

    End Sub



    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter


    End Sub

    Private Sub radHandCI_CheckedChanged(sender As Object, e As EventArgs) Handles radHandCI.CheckedChanged
        'Visibility Of items to Purchace Conditional On Section A Choice or Section B Choice
        If radHandCI.Checked Then
            GroupBox2.Visible = True
            GroupBox4.Visible = True
            lblQuantity.Visible = True
            TxtQuantity.Visible = True
            btnClose1.Visible = True
            btnATCnContinue.Visible = True
            btnATCnOut.Visible = True

            GroupBox3.Visible = False
            btnClose2.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            lblQuantity2.Visible = False
            txtQuantity2.Visible = False
        Else
            radCharmBrace.Checked = True
        End If

    End Sub

    Private Sub radCGray_CheckedChanged(sender As Object, e As EventArgs) Handles radCGray.CheckedChanged

    End Sub

    Private Sub radCWhite_CheckedChanged(sender As Object, e As EventArgs) Handles radCWhite.CheckedChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub radCharmBrace_CheckedChanged(sender As Object, e As EventArgs) Handles radCharmBrace.CheckedChanged
        If radCharmBrace.Checked Then
            GroupBox2.Visible = False
            GroupBox4.Visible = False
            lblQuantity.Visible = False
            TxtQuantity.Visible = False
            btnClose1.Visible = False
            btnATCnContinue.Visible = False
            btnATCnOut.Visible = False

            GroupBox3.Visible = True
            btnClose2.Visible = True
            Button4.Visible = True
            Button5.Visible = True
            txtQuantity2.Visible = True
            lblQuantity2.Visible = True
        Else
            radHandCI.Checked = True
        End If
    End Sub

    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs) Handles GroupBox4.Enter

    End Sub

    Private Sub rad1Hat_CheckedChanged(sender As Object, e As EventArgs) Handles rad1Hat.CheckedChanged

    End Sub

    Private Sub GroupBox5_Enter(sender As Object, e As EventArgs) Handles GroupBox5.Enter

    End Sub

    Private Sub btnClose2_Click(sender As Object, e As EventArgs) Handles btnClose2.Click
        'Create close program button with a Kind message.
        MessageBox.Show("Thank You For Ordering, We Appreciate Your Patronage.")
        MessageBox.Show("Have a Nice Day!")
        Close()
    End Sub

    Private Sub txtQuantity2_TextChanged(sender As Object, e As EventArgs) Handles txtQuantity2.TextChanged

    End Sub

    Private Sub lbl_Click(sender As Object, e As EventArgs) Handles lbl.Click

    End Sub

    Private Sub btnClose1_Click(sender As Object, e As EventArgs) Handles btnClose1.Click
        'Create close program button with a Kind message.
        MessageBox.Show("Thank You For Ordering, We Appreciate Your Patronage.")
        MessageBox.Show("Have a Nice Day!")
        Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim BB As Double
        BB = InfoButton4()

        lstDisplay.Items.Clear()
        lstDisplay.Items.Add(CStr(Now))
        lstDisplay.Items.Add("  Your Total Is $ " & orderTotalCharms & " For The Charm Bracelet, & Charms.")
        'lstDisplay.Items.Add("  You've Ordered A CharmBracelet And the Selected Charms. " & )
        lstDisplay.Items.Add("  You Total Tax Will Be:$ " & TaxAmount)
        lstDisplay.Items.Add("  The Shipping Charge will Be:$ " & Shipping)
        lstDisplay.Items.Add("  You Total Charge will Be: $ " & TotalCharge2)
    End Sub

    Private Sub lstDisplay_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstDisplay.SelectedIndexChanged

    End Sub

    Private Sub chk1Cat_CheckedChanged(sender As Object, e As EventArgs) Handles chk1Cat.CheckedChanged

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim AB As Double
        AB = InfoButton5()
        'A Function For the Button
        
        lstDisplay.Items.Clear()
        lstDisplay.Items.Add(CStr(Now))
        lstDisplay.Items.Add("  Your Total Is $ " & orderTotalCharms & " For The Charm Bracelet, & Charms.")
        'lstDisplay.Items.Add("  You've Ordered A CharmBracelet And the Selected Charms. " & )
        lstDisplay.Items.Add("  You Total Tax Will Be:$ " & TaxAmount)
        lstDisplay.Items.Add("  The Shipping Charge will Be:$ " & Shipping)
        lstDisplay.Items.Add("  You Total Charge will Be: $ " & TotalCharge2)
    End Sub

    Private Sub btnATCnContinue_Click(sender As Object, e As EventArgs) Handles btnATCnContinue.Click
        Dim cd As Double
        cd = InfoButton1()

        Dim dc, dcc As String
        dc = InfoButton11()
        dcc = InfoButton111()

       

        lstDisplay.Items.Clear()
        lstDisplay.Items.Add(CStr(Now))
        lstDisplay.Items.Add("  Your Total Is:  $ " & PriceTotal)
        lstDisplay.Items.Add("  You Have Ordered: " & TxtQuantity.Text & " , " & dc & "'s. In the Color " & dcc & ". ")
        lstDisplay.Items.Add("  Your Tax Will Be:  $ " & TaxAmout)
        lstDisplay.Items.Add("  The Shipping Charge will Be: $ " & Shipping)
        lstDisplay.Items.Add("  You Total Charge will Be: $ " & TotalCharge)
    End Sub

    Private Sub btnATCnOut_Click(sender As Object, e As EventArgs) Handles btnATCnOut.Click
        Dim Dd As Double
        Dd = InfoButton2()

        Dim Ddd, Dddd As String
        Ddd = InfoButton22()
        Dddd = InfoButton222()

        lstDisplay.Items.Clear()
        lstDisplay.Items.Add(CStr(Now))
        lstDisplay.Items.Add("  Your Total Is:  $ " & PriceTotal)
        lstDisplay.Items.Add("  You Have Ordered: " & TxtQuantity.Text & " , " & Ddd & "'s. In the Color " & Dddd & ". ")
        lstDisplay.Items.Add("  Your Tax Will Be:  $ " & TaxAmout)
        lstDisplay.Items.Add("  The Shipping Charge will Be: $ " & Shipping)
        lstDisplay.Items.Add("  You Total Charge will Be: $ " & TotalCharge)
    End Sub

    Private Sub radStandardShip_CheckedChanged(sender As Object, e As EventArgs) Handles radStandardShip.CheckedChanged

    End Sub
End Class
