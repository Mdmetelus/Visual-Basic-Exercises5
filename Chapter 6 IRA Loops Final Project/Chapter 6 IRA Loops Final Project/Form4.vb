Public Class Form4
    Dim prompt, title, fullName, prompt1, title1, emailNmae, prompt2 As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        MessageBox.Show(" Please Call Us At 1(800) 555 - 1234")
        MessageBox.Show(" You Can Also Email us At: Questions@1492BuffaloBanking.com")
        txtNum.Visible = True
        TxtEmail.Visible = True
        txtNum.Text = "1(800) 555 - 1234"
        TxtEmail.Text = "Questions@1492BuffaloBanking.com"

        'Dim Prompt, title, fullName As String
        'title = "Contact Information"

        'Prompt = " Enter your Full Name, Phone Number, and Full Email Address"

        'Select Case chkyouContact.Checked
        '    Case chkyouContact.Checked And chkWeContact.Checked = False
        '        lstDisplay4.Visible = False
        '        MessageBox.Show(" Please Call Us At 1(800) 555 1234")
        '        MessageBox.Show(" You Can Also Email us At: Questions@1492BuffaloBAnking.com")
        '    Case chkWeContact.Checked = True
        '        lstDisplay4.Visible = True
        '        fullName = InputBox(Prompt, title)


        '        lstDisplay4.Items.Add("")
        '        lstDisplay4.Items.Add(Now)
        '        lstDisplay4.Items.Add("Contact Info: " & fullName)
        '        '                'lstDisplay4.Items.Add(""&)
        '        '                'lstDisplay4.Items.Add(""&)
        '        '                'lstDisplay4.Items.Add(""&)
        '        '                'lstDisplay4.Items.Add(""&)
        '    Case chkWeContact.Checked = True And chkyouContact.Checked = True
        '        MessageBox.Show(" Please Call Us At 1(800) 555 1234")
        '        MessageBox.Show(" You Can Also Email us At: Questions@1492BuffaloBAnking.com")
        '        lstDisplay4.Visible = True
        '        fullName = InputBox(Prompt, title)
        '        lstDisplay4.Items.Add("")
        '        lstDisplay4.Items.Add(Now)
        '        lstDisplay4.Items.Add("Contact Info: " & fullName)

        '    Case chkWeContact.Checked = False And chkWeContact.Checked = False
        '        lstDisplay4.Visible = False
        'End Select

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstDisplay4.SelectedIndexChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        MessageBox.Show("Have A Nice Day")
        Me.Close()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form5.Show()
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click

    End Sub

    Private Sub chkWeContact_CheckedChanged(sender As Object, e As EventArgs) Handles chkWeContact.CheckedChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim Prompt, title, fullName As String
        title = "Contact Information"

        Prompt = " Enter your Full Name(then A Space), Phone Number(then A Space), and Full Email Address"



        lstDisplay4.Visible = True
        fullName = InputBox(prompt, title)
        lstDisplay4.Items.Add("")
        lstDisplay4.Items.Add(Now)
        lstDisplay4.Items.Add("Contact Info: " & fullName)
    End Sub
End Class