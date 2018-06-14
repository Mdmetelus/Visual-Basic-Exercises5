<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IRA
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
        Me.SuspendLayout()
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnCalculate.Location = New System.Drawing.Point(111, 12)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(270, 44)
        Me.btnCalculate.TabIndex = 0
        Me.btnCalculate.Text = "Calculate Amount"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 138)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Earl"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(257, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Larry"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 280)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Earl"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(257, 280)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Larry"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(95, 69)
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
        Me.Label6.Location = New System.Drawing.Point(14, 213)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(459, 33)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Amounts In IRA Upon Retirment"
        '
        'txtEarlDep
        '
        Me.txtEarlDep.Location = New System.Drawing.Point(94, 138)
        Me.txtEarlDep.Name = "txtEarlDep"
        Me.txtEarlDep.Size = New System.Drawing.Size(100, 20)
        Me.txtEarlDep.TabIndex = 7
        '
        'txtLarryDep
        '
        Me.txtLarryDep.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtLarryDep.Location = New System.Drawing.Point(313, 138)
        Me.txtLarryDep.Name = "txtLarryDep"
        Me.txtLarryDep.Size = New System.Drawing.Size(100, 20)
        Me.txtLarryDep.TabIndex = 8
        '
        'txtEarlEndAmount
        '
        Me.txtEarlEndAmount.Location = New System.Drawing.Point(94, 280)
        Me.txtEarlEndAmount.Name = "txtEarlEndAmount"
        Me.txtEarlEndAmount.Size = New System.Drawing.Size(100, 20)
        Me.txtEarlEndAmount.TabIndex = 9
        '
        'txtLarryEndAmount
        '
        Me.txtLarryEndAmount.Location = New System.Drawing.Point(313, 280)
        Me.txtLarryEndAmount.Name = "txtLarryEndAmount"
        Me.txtLarryEndAmount.Size = New System.Drawing.Size(100, 20)
        Me.txtLarryEndAmount.TabIndex = 10
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Purple
        Me.btnClose.Location = New System.Drawing.Point(111, 321)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(270, 30)
        Me.btnClose.TabIndex = 11
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'IRA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(485, 363)
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
        Me.Name = "IRA"
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

End Class
