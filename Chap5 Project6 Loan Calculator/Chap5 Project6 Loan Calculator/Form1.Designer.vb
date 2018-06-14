<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCalculateVal = New System.Windows.Forms.Button()
        Me.btnClearVal = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.radLoanAmouunt1 = New System.Windows.Forms.RadioButton()
        Me.radInterestRate2 = New System.Windows.Forms.RadioButton()
        Me.radLoanDuration3 = New System.Windows.Forms.RadioButton()
        Me.radMonthlypayment = New System.Windows.Forms.RadioButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.radMonthlypayment)
        Me.GroupBox1.Controls.Add(Me.radLoanDuration3)
        Me.GroupBox1.Controls.Add(Me.radInterestRate2)
        Me.GroupBox1.Controls.Add(Me.radLoanAmouunt1)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(584, 210)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'btnCalculateVal
        '
        Me.btnCalculateVal.Location = New System.Drawing.Point(13, 270)
        Me.btnCalculateVal.Name = "btnCalculateVal"
        Me.btnCalculateVal.Size = New System.Drawing.Size(288, 23)
        Me.btnCalculateVal.TabIndex = 1
        Me.btnCalculateVal.Text = "Calculate Value"
        Me.btnCalculateVal.UseVisualStyleBackColor = True
        '
        'btnClearVal
        '
        Me.btnClearVal.Location = New System.Drawing.Point(307, 270)
        Me.btnClearVal.Name = "btnClearVal"
        Me.btnClearVal.Size = New System.Drawing.Size(290, 23)
        Me.btnClearVal.TabIndex = 2
        Me.btnClearVal.Text = "Clear All Values"
        Me.btnClearVal.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(140, 317)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(335, 23)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Label1"
        '
        'radLoanAmouunt1
        '
        Me.radLoanAmouunt1.AutoSize = True
        Me.radLoanAmouunt1.Location = New System.Drawing.Point(6, 33)
        Me.radLoanAmouunt1.Name = "radLoanAmouunt1"
        Me.radLoanAmouunt1.Size = New System.Drawing.Size(90, 17)
        Me.radLoanAmouunt1.TabIndex = 0
        Me.radLoanAmouunt1.TabStop = True
        Me.radLoanAmouunt1.Text = "RadioButton1"
        Me.radLoanAmouunt1.UseVisualStyleBackColor = True
        '
        'radInterestRate2
        '
        Me.radInterestRate2.AutoSize = True
        Me.radInterestRate2.Location = New System.Drawing.Point(6, 85)
        Me.radInterestRate2.Name = "radInterestRate2"
        Me.radInterestRate2.Size = New System.Drawing.Size(90, 17)
        Me.radInterestRate2.TabIndex = 1
        Me.radInterestRate2.TabStop = True
        Me.radInterestRate2.Text = "RadioButton2"
        Me.radInterestRate2.UseVisualStyleBackColor = True
        '
        'radLoanDuration3
        '
        Me.radLoanDuration3.AutoSize = True
        Me.radLoanDuration3.Location = New System.Drawing.Point(6, 124)
        Me.radLoanDuration3.Name = "radLoanDuration3"
        Me.radLoanDuration3.Size = New System.Drawing.Size(90, 17)
        Me.radLoanDuration3.TabIndex = 2
        Me.radLoanDuration3.TabStop = True
        Me.radLoanDuration3.Text = "RadioButton3"
        Me.radLoanDuration3.UseVisualStyleBackColor = True
        '
        'radMonthlypayment
        '
        Me.radMonthlypayment.AutoSize = True
        Me.radMonthlypayment.Location = New System.Drawing.Point(6, 168)
        Me.radMonthlypayment.Name = "radMonthlypayment"
        Me.radMonthlypayment.Size = New System.Drawing.Size(90, 17)
        Me.radMonthlypayment.TabIndex = 3
        Me.radMonthlypayment.TabStop = True
        Me.radMonthlypayment.Text = "RadioButton4"
        Me.radMonthlypayment.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(294, 33)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(254, 20)
        Me.TextBox1.TabIndex = 4
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(294, 85)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(254, 20)
        Me.TextBox2.TabIndex = 5
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(294, 124)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(254, 20)
        Me.TextBox3.TabIndex = 6
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(294, 168)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(254, 20)
        Me.TextBox4.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(609, 352)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnClearVal)
        Me.Controls.Add(Me.btnCalculateVal)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents radMonthlypayment As System.Windows.Forms.RadioButton
    Friend WithEvents radLoanDuration3 As System.Windows.Forms.RadioButton
    Friend WithEvents radInterestRate2 As System.Windows.Forms.RadioButton
    Friend WithEvents radLoanAmouunt1 As System.Windows.Forms.RadioButton
    Friend WithEvents btnCalculateVal As System.Windows.Forms.Button
    Friend WithEvents btnClearVal As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
