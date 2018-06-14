Public Class Form5

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles radNavajo.CheckedChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter
    '    If radNavajo.Checked Then
    '        MessageBox.Show(" The Novajo Nation Like You Too!")
    '    ElseIf radLakota.Checked Then
    '        MessageBox.Show("The Lakota Nation Like Likes You Too!")
    '    ElseIf radOsage.Checked Then
    '        MessageBox.Show("The Osage Nation Like Likes You Too!")
    '    ElseIf radHupa.Checked Then
    '        MessageBox.Show("The Hupa Nation Like Likes You Too!")
    '    ElseIf radBuffalos.Checked Then
    '        MessageBox.Show("The Love to Eat Buffalo Too! Come Break Bread With Us Soon.")
    '    ElseIf radPowwow.Checked Then
    '        MessageBox.Show("Theres notheing better than A Powwwow. Come Monthly Powwow Gathering.")
    '    ElseIf RadNone.Checked Then
    '        MessageBox.Show("Unbelievable! We will offer you the worst Rates!!!")
    '    End If
    'End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If radNavajo.Checked Then
            MessageBox.Show(" The Novajo Nation Likes You Too!")
        ElseIf radLakota.Checked Then
            MessageBox.Show("The Lakota Nation Likes Likes You Too!")
        ElseIf radOsage.Checked Then
            MessageBox.Show("The Osage Nation Likes Likes You Too!")
        ElseIf radHupa.Checked Then
            MessageBox.Show("The Hupa Nation Likes You Too!")
        ElseIf radBuffalos.Checked Then
            MessageBox.Show("We Love to Eat Buffalo Too! Come Break Bread With Us Soon.")
        ElseIf radPowwow.Checked Then
            MessageBox.Show("There's notheing better than A Powwwow! Come to Our Monthly Powwow Gathering.")
        ElseIf RadNone.Checked Then
            MessageBox.Show("Unbelievable! We will offer you the worst Rates!!!")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        MessageBox.Show("Have A Nice Day")
        Me.Close()
    End Sub
End Class