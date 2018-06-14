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
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtEarlDep = New System.Windows.Forms.TextBox()
        Me.txtLarryDep = New System.Windows.Forms.TextBox()
        Me.txtEarlEndAmount = New System.Windows.Forms.TextBox()
        Me.txtLarryEndAmount = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lstDisplay = New System.Windows.Forms.ListBox()
        Me.lstDisplay1 = New System.Windows.Forms.ListBox()
        Me.lstDisplay2 = New System.Windows.Forms.ListBox()
        Me.lstDisplay3 = New System.Windows.Forms.ListBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnCalculate.Location = New System.Drawing.Point(15, 337)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(419, 44)
        Me.btnCalculate.TabIndex = 0
        Me.btnCalculate.Text = "Calculate Amount"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(20, 147)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Person A"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(239, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Person B"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(10, 290)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Person A"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(229, 290)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 18)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Person B"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(88, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(286, 33)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Amounts Deposited"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Green
        Me.Label6.Location = New System.Drawing.Point(2, 225)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(459, 33)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Amounts In IRA Upon Retirment"
        '
        'txtEarlDep
        '
        Me.txtEarlDep.Location = New System.Drawing.Point(104, 145)
        Me.txtEarlDep.Name = "txtEarlDep"
        Me.txtEarlDep.Size = New System.Drawing.Size(100, 20)
        Me.txtEarlDep.TabIndex = 7
        '
        'txtLarryDep
        '
        Me.txtLarryDep.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtLarryDep.Location = New System.Drawing.Point(334, 145)
        Me.txtLarryDep.Name = "txtLarryDep"
        Me.txtLarryDep.Size = New System.Drawing.Size(100, 20)
        Me.txtLarryDep.TabIndex = 8
        '
        'txtEarlEndAmount
        '
        Me.txtEarlEndAmount.Location = New System.Drawing.Point(94, 288)
        Me.txtEarlEndAmount.Name = "txtEarlEndAmount"
        Me.txtEarlEndAmount.Size = New System.Drawing.Size(100, 20)
        Me.txtEarlEndAmount.TabIndex = 9
        '
        'txtLarryEndAmount
        '
        Me.txtLarryEndAmount.Location = New System.Drawing.Point(324, 288)
        Me.txtLarryEndAmount.Name = "txtLarryEndAmount"
        Me.txtLarryEndAmount.Size = New System.Drawing.Size(100, 20)
        Me.txtLarryEndAmount.TabIndex = 10
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Purple
        Me.btnClose.Location = New System.Drawing.Point(8, 520)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(197, 30)
        Me.btnClose.TabIndex = 11
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label7.Location = New System.Drawing.Point(43, 29)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(381, 37)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "This Is an IRA  Example"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Green
        Me.Button1.Location = New System.Drawing.Point(50, 417)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(343, 30)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Would You Like to Try For Yourself?"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(624, 496)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 18)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Person A"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Chocolate
        Me.Label9.ForeColor = System.Drawing.Color.Gold
        Me.Label9.Location = New System.Drawing.Point(497, 520)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(352, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Deposited For 15 years then allows the Interest to Accumulate over Time."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(1079, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 18)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Person B"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Chocolate
        Me.Label11.ForeColor = System.Drawing.Color.Gold
        Me.Label11.Location = New System.Drawing.Point(913, 33)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(390, 13)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Waits 15 Years then deposit the same annual amount every year until Retirement."
        '
        'lstDisplay
        '
        Me.lstDisplay.FormattingEnabled = True
        Me.lstDisplay.Location = New System.Drawing.Point(467, 29)
        Me.lstDisplay.Name = "lstDisplay"
        Me.lstDisplay.Size = New System.Drawing.Size(188, 446)
        Me.lstDisplay.TabIndex = 18
        '
        'lstDisplay1
        '
        Me.lstDisplay1.FormattingEnabled = True
        Me.lstDisplay1.Location = New System.Drawing.Point(661, 29)
        Me.lstDisplay1.Name = "lstDisplay1"
        Me.lstDisplay1.Size = New System.Drawing.Size(206, 446)
        Me.lstDisplay1.TabIndex = 19
        '
        'lstDisplay2
        '
        Me.lstDisplay2.FormattingEnabled = True
        Me.lstDisplay2.Location = New System.Drawing.Point(873, 84)
        Me.lstDisplay2.Name = "lstDisplay2"
        Me.lstDisplay2.Size = New System.Drawing.Size(232, 446)
        Me.lstDisplay2.TabIndex = 20
        '
        'lstDisplay3
        '
        Me.lstDisplay3.FormattingEnabled = True
        Me.lstDisplay3.Location = New System.Drawing.Point(1113, 84)
        Me.lstDisplay3.Name = "lstDisplay3"
        Me.lstDisplay3.Size = New System.Drawing.Size(232, 446)
        Me.lstDisplay3.TabIndex = 21
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(464, 5)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(77, 18)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Person A"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(658, 5)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(77, 18)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "Person A"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(870, 60)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(78, 18)
        Me.Label14.TabIndex = 24
        Me.Label14.Text = "Person B"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(1110, 60)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(78, 18)
        Me.Label15.TabIndex = 25
        Me.Label15.Text = "Person B"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label16.Location = New System.Drawing.Point(151, 181)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(166, 18)
        Me.Label16.TabIndex = 26
        Me.Label16.Text = "Rate Assumed @ 4%"
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Perpetua Titling MT", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Button3.Location = New System.Drawing.Point(215, 520)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(246, 30)
        Me.Button3.TabIndex = 27
        Me.Button3.Text = "Contact Us"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.Green
        Me.Button6.Location = New System.Drawing.Point(50, 472)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(343, 30)
        Me.Button6.TabIndex = 34
        Me.Button6.Text = "Please Fill Out this Survey Question."
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1357, 564)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lstDisplay3)
        Me.Controls.Add(Me.lstDisplay2)
        Me.Controls.Add(Me.lstDisplay1)
        Me.Controls.Add(Me.lstDisplay)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.txtLarryEndAmount)
        Me.Controls.Add(Me.txtEarlEndAmount)
        Me.Controls.Add(Me.txtLarryDep)
        Me.Controls.Add(Me.txtEarlDep)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCalculate)
        Me.Name = "Form1"
        Me.Text = "IRA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtEarlDep As System.Windows.Forms.TextBox
    Friend WithEvents txtLarryDep As System.Windows.Forms.TextBox
    Friend WithEvents txtEarlEndAmount As System.Windows.Forms.TextBox
    Friend WithEvents txtLarryEndAmount As System.Windows.Forms.TextBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lstDisplay As System.Windows.Forms.ListBox
    Friend WithEvents lstDisplay1 As System.Windows.Forms.ListBox
    Friend WithEvents lstDisplay2 As System.Windows.Forms.ListBox
    Friend WithEvents lstDisplay3 As System.Windows.Forms.ListBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button

End Class
