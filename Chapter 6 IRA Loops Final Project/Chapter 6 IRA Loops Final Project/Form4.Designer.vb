<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lstDisplay4 = New System.Windows.Forms.ListBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.chkyouContact = New System.Windows.Forms.CheckBox()
        Me.chkWeContact = New System.Windows.Forms.CheckBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtNum = New System.Windows.Forms.TextBox()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstDisplay4
        '
        Me.lstDisplay4.FormattingEnabled = True
        Me.lstDisplay4.Location = New System.Drawing.Point(427, 86)
        Me.lstDisplay4.Name = "lstDisplay4"
        Me.lstDisplay4.Size = New System.Drawing.Size(303, 407)
        Me.lstDisplay4.TabIndex = 3
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Purple
        Me.btnClose.Location = New System.Drawing.Point(22, 469)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(351, 30)
        Me.btnClose.TabIndex = 12
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Green
        Me.Button2.Location = New System.Drawing.Point(22, 283)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(351, 30)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Would You Like to Try For Yourself?"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Green
        Me.Button3.Location = New System.Drawing.Point(22, 351)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(351, 30)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "Would You Like To See An Example?"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Green
        Me.Button1.Location = New System.Drawing.Point(22, 403)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(351, 30)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Please Fill Out this Survey Question."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnDisplay
        '
        Me.btnDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplay.ForeColor = System.Drawing.Color.Crimson
        Me.btnDisplay.Location = New System.Drawing.Point(17, 53)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(351, 31)
        Me.btnDisplay.TabIndex = 2
        Me.btnDisplay.Text = "Click To Recieve our Contact Info"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'chkyouContact
        '
        Me.chkyouContact.AutoSize = True
        Me.chkyouContact.ForeColor = System.Drawing.Color.MediumBlue
        Me.chkyouContact.Location = New System.Drawing.Point(90, 19)
        Me.chkyouContact.Name = "chkyouContact"
        Me.chkyouContact.Size = New System.Drawing.Size(176, 17)
        Me.chkyouContact.TabIndex = 19
        Me.chkyouContact.Text = "Would You Like to Contact Us?"
        Me.chkyouContact.UseVisualStyleBackColor = True
        '
        'chkWeContact
        '
        Me.chkWeContact.AutoSize = True
        Me.chkWeContact.ForeColor = System.Drawing.Color.MediumBlue
        Me.chkWeContact.Location = New System.Drawing.Point(470, 19)
        Me.chkWeContact.Name = "chkWeContact"
        Me.chkWeContact.Size = New System.Drawing.Size(197, 17)
        Me.chkWeContact.TabIndex = 20
        Me.chkWeContact.Text = "Would You Like Us to contact You?"
        Me.chkWeContact.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Crimson
        Me.Button4.Location = New System.Drawing.Point(6, 14)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(351, 31)
        Me.Button4.TabIndex = 21
        Me.Button4.Text = "Click To Submit Contact Info"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtEmail)
        Me.GroupBox1.Controls.Add(Me.txtNum)
        Me.GroupBox1.Controls.Add(Me.btnDisplay)
        Me.GroupBox1.Controls.Add(Me.chkyouContact)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 117)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(374, 160)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkWeContact)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(736, 68)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'txtNum
        '
        Me.txtNum.Location = New System.Drawing.Point(115, 93)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.ReadOnly = True
        Me.txtNum.Size = New System.Drawing.Size(126, 20)
        Me.txtNum.TabIndex = 20
        Me.txtNum.Visible = False
        '
        'TxtEmail
        '
        Me.TxtEmail.Location = New System.Drawing.Point(77, 119)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.ReadOnly = True
        Me.TxtEmail.Size = New System.Drawing.Size(200, 20)
        Me.TxtEmail.TabIndex = 21
        Me.TxtEmail.Visible = False
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(758, 511)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lstDisplay4)
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstDisplay4 As System.Windows.Forms.ListBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnDisplay As System.Windows.Forms.Button
    Friend WithEvents chkyouContact As System.Windows.Forms.CheckBox
    Friend WithEvents chkWeContact As System.Windows.Forms.CheckBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtNum As System.Windows.Forms.TextBox
End Class
