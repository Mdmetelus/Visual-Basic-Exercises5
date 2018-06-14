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
        Me.lblSlices = New System.Windows.Forms.Label()
        Me.txtSlices = New System.Windows.Forms.TextBox()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.lstDisplay = New System.Windows.Forms.ListBox()
        Me.lblFries = New System.Windows.Forms.Label()
        Me.lblDrinks = New System.Windows.Forms.Label()
        Me.txtFries = New System.Windows.Forms.TextBox()
        Me.txtSodas = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblSlices
        '
        Me.lblSlices.AutoSize = True
        Me.lblSlices.Location = New System.Drawing.Point(13, 24)
        Me.lblSlices.Name = "lblSlices"
        Me.lblSlices.Size = New System.Drawing.Size(123, 13)
        Me.lblSlices.TabIndex = 0
        Me.lblSlices.Text = "How Many Pizza Slices?"
        '
        'txtSlices
        '
        Me.txtSlices.Location = New System.Drawing.Point(242, 24)
        Me.txtSlices.Name = "txtSlices"
        Me.txtSlices.Size = New System.Drawing.Size(128, 20)
        Me.txtSlices.TabIndex = 1
        '
        'btnCompute
        '
        Me.btnCompute.Location = New System.Drawing.Point(396, 12)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(148, 153)
        Me.btnCompute.TabIndex = 2
        Me.btnCompute.Text = "Compute Total Cost"
        Me.btnCompute.UseVisualStyleBackColor = True
        '
        'lstDisplay
        '
        Me.lstDisplay.FormattingEnabled = True
        Me.lstDisplay.Location = New System.Drawing.Point(12, 181)
        Me.lstDisplay.Name = "lstDisplay"
        Me.lstDisplay.Size = New System.Drawing.Size(532, 186)
        Me.lstDisplay.TabIndex = 3
        '
        'lblFries
        '
        Me.lblFries.AutoSize = True
        Me.lblFries.Location = New System.Drawing.Point(13, 79)
        Me.lblFries.Name = "lblFries"
        Me.lblFries.Size = New System.Drawing.Size(89, 13)
        Me.lblFries.TabIndex = 4
        Me.lblFries.Text = "How Many Fries?"
        '
        'lblDrinks
        '
        Me.lblDrinks.AutoSize = True
        Me.lblDrinks.Location = New System.Drawing.Point(13, 142)
        Me.lblDrinks.Name = "lblDrinks"
        Me.lblDrinks.Size = New System.Drawing.Size(119, 13)
        Me.lblDrinks.TabIndex = 5
        Me.lblDrinks.Text = "How Many Soft Drinks?"
        '
        'txtFries
        '
        Me.txtFries.Location = New System.Drawing.Point(242, 79)
        Me.txtFries.Name = "txtFries"
        Me.txtFries.Size = New System.Drawing.Size(128, 20)
        Me.txtFries.TabIndex = 6
        '
        'txtSodas
        '
        Me.txtSodas.Location = New System.Drawing.Point(242, 142)
        Me.txtSodas.Name = "txtSodas"
        Me.txtSodas.Size = New System.Drawing.Size(128, 20)
        Me.txtSodas.TabIndex = 7
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(12, 398)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(532, 23)
        Me.btnClose.TabIndex = 8
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 451)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.txtSodas)
        Me.Controls.Add(Me.txtFries)
        Me.Controls.Add(Me.lblDrinks)
        Me.Controls.Add(Me.lblFries)
        Me.Controls.Add(Me.lstDisplay)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.txtSlices)
        Me.Controls.Add(Me.lblSlices)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSlices As System.Windows.Forms.Label
    Friend WithEvents txtSlices As System.Windows.Forms.TextBox
    Friend WithEvents btnCompute As System.Windows.Forms.Button
    Friend WithEvents lstDisplay As System.Windows.Forms.ListBox
    Friend WithEvents lblFries As System.Windows.Forms.Label
    Friend WithEvents lblDrinks As System.Windows.Forms.Label
    Friend WithEvents txtFries As System.Windows.Forms.TextBox
    Friend WithEvents txtSodas As System.Windows.Forms.TextBox
    Friend WithEvents btnClose As System.Windows.Forms.Button

End Class
