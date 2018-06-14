<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CoffeeAbsorption
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
        Me.txtOunces = New System.Windows.Forms.TextBox()
        Me.txtMgCaff = New System.Windows.Forms.TextBox()
        Me.txtTime = New System.Windows.Forms.TextBox()
        Me.Lblounces = New System.Windows.Forms.Label()
        Me.lblMgOfCaff = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.btncompute = New System.Windows.Forms.Button()
        Me.lstDisplay = New System.Windows.Forms.ListBox()
        Me.lstDisplay2 = New System.Windows.Forms.ListBox()
        Me.lstDisplay3 = New System.Windows.Forms.ListBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtOunces
        '
        Me.txtOunces.Location = New System.Drawing.Point(12, 82)
        Me.txtOunces.Name = "txtOunces"
        Me.txtOunces.Size = New System.Drawing.Size(225, 20)
        Me.txtOunces.TabIndex = 0
        '
        'txtMgCaff
        '
        Me.txtMgCaff.Location = New System.Drawing.Point(9, 156)
        Me.txtMgCaff.Name = "txtMgCaff"
        Me.txtMgCaff.Size = New System.Drawing.Size(225, 20)
        Me.txtMgCaff.TabIndex = 1
        '
        'txtTime
        '
        Me.txtTime.Location = New System.Drawing.Point(9, 245)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(222, 20)
        Me.txtTime.TabIndex = 2
        '
        'Lblounces
        '
        Me.Lblounces.AutoSize = True
        Me.Lblounces.Location = New System.Drawing.Point(12, 52)
        Me.Lblounces.Name = "Lblounces"
        Me.Lblounces.Size = New System.Drawing.Size(163, 13)
        Me.Lblounces.TabIndex = 3
        Me.Lblounces.Text = "One cup: When will 65mg rmain?"
        '
        'lblMgOfCaff
        '
        Me.lblMgOfCaff.AutoSize = True
        Me.lblMgOfCaff.Location = New System.Drawing.Point(9, 123)
        Me.lblMgOfCaff.Name = "lblMgOfCaff"
        Me.lblMgOfCaff.Size = New System.Drawing.Size(164, 13)
        Me.lblMgOfCaff.TabIndex = 4
        Me.lblMgOfCaff.Text = "One cup: Quantity after 24 hours:"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(12, 199)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(179, 13)
        Me.lblTime.TabIndex = 5
        Me.lblTime.Text = "Hourly cups: Quantity after 24 hours:"
        '
        'btncompute
        '
        Me.btncompute.Location = New System.Drawing.Point(12, 12)
        Me.btncompute.Name = "btncompute"
        Me.btncompute.Size = New System.Drawing.Size(225, 23)
        Me.btncompute.TabIndex = 7
        Me.btncompute.Text = "Compute Values"
        Me.btncompute.UseVisualStyleBackColor = True
        '
        'lstDisplay
        '
        Me.lstDisplay.FormattingEnabled = True
        Me.lstDisplay.Location = New System.Drawing.Point(255, 12)
        Me.lstDisplay.Name = "lstDisplay"
        Me.lstDisplay.Size = New System.Drawing.Size(89, 303)
        Me.lstDisplay.TabIndex = 8
        '
        'lstDisplay2
        '
        Me.lstDisplay2.FormattingEnabled = True
        Me.lstDisplay2.Location = New System.Drawing.Point(406, 12)
        Me.lstDisplay2.Name = "lstDisplay2"
        Me.lstDisplay2.Size = New System.Drawing.Size(249, 303)
        Me.lstDisplay2.TabIndex = 9
        '
        'lstDisplay3
        '
        Me.lstDisplay3.FormattingEnabled = True
        Me.lstDisplay3.Location = New System.Drawing.Point(717, 12)
        Me.lstDisplay3.Name = "lstDisplay3"
        Me.lstDisplay3.Size = New System.Drawing.Size(238, 303)
        Me.lstDisplay3.TabIndex = 10
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(9, 292)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(222, 23)
        Me.btnClose.TabIndex = 11
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'CoffeeAbsorption
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(982, 336)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lstDisplay3)
        Me.Controls.Add(Me.lstDisplay2)
        Me.Controls.Add(Me.lstDisplay)
        Me.Controls.Add(Me.btncompute)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblMgOfCaff)
        Me.Controls.Add(Me.Lblounces)
        Me.Controls.Add(Me.txtTime)
        Me.Controls.Add(Me.txtMgCaff)
        Me.Controls.Add(Me.txtOunces)
        Me.Name = "CoffeeAbsorption"
        Me.Text = "Coffeine Absorption Info"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtOunces As System.Windows.Forms.TextBox
    Friend WithEvents txtMgCaff As System.Windows.Forms.TextBox
    Friend WithEvents txtTime As System.Windows.Forms.TextBox
    Friend WithEvents Lblounces As System.Windows.Forms.Label
    Friend WithEvents lblMgOfCaff As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents btncompute As System.Windows.Forms.Button
    Friend WithEvents lstDisplay As System.Windows.Forms.ListBox
    Friend WithEvents lstDisplay2 As System.Windows.Forms.ListBox
    Friend WithEvents lstDisplay3 As System.Windows.Forms.ListBox
    Friend WithEvents btnClose As System.Windows.Forms.Button

End Class
