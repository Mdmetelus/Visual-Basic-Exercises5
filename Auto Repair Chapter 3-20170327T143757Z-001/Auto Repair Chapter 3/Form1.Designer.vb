<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAutoRepair
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
        Me.lstTotal = New System.Windows.Forms.ListBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblFirst = New System.Windows.Forms.Label()
        Me.lblSecond = New System.Windows.Forms.Label()
        Me.lblthird = New System.Windows.Forms.Label()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.txtWorkHrs = New System.Windows.Forms.TextBox()
        Me.txtSupplyCost = New System.Windows.Forms.TextBox()
        Me.btnTotalCost = New System.Windows.Forms.Button()
        Me.btnLaborInfo = New System.Windows.Forms.Button()
        Me.btnCostomerInfo = New System.Windows.Forms.Button()
        Me.btnPartnSupplies = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstTotal
        '
        Me.lstTotal.FormattingEnabled = True
        Me.lstTotal.Location = New System.Drawing.Point(6, 134)
        Me.lstTotal.Name = "lstTotal"
        Me.lstTotal.Size = New System.Drawing.Size(270, 134)
        Me.lstTotal.TabIndex = 0
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(113, 13)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(163, 20)
        Me.txtName.TabIndex = 0
        '
        'lblFirst
        '
        Me.lblFirst.AutoSize = True
        Me.lblFirst.Location = New System.Drawing.Point(3, 13)
        Me.lblFirst.Name = "lblFirst"
        Me.lblFirst.Size = New System.Drawing.Size(104, 13)
        Me.lblFirst.TabIndex = 2
        Me.lblFirst.Text = "Customer Full Name:"
        '
        'lblSecond
        '
        Me.lblSecond.AutoSize = True
        Me.lblSecond.Location = New System.Drawing.Point(3, 52)
        Me.lblSecond.Name = "lblSecond"
        Me.lblSecond.Size = New System.Drawing.Size(80, 13)
        Me.lblSecond.TabIndex = 3
        Me.lblSecond.Text = "Hours of Labor:"
        '
        'lblthird
        '
        Me.lblthird.AutoSize = True
        Me.lblthird.Location = New System.Drawing.Point(3, 94)
        Me.lblthird.Name = "lblthird"
        Me.lblthird.Size = New System.Drawing.Size(129, 13)
        Me.lblthird.TabIndex = 4
        Me.lblthird.Text = "Cost Of Parts And Supply:"
        '
        'btnCompute
        '
        Me.btnCompute.Location = New System.Drawing.Point(298, 173)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(124, 23)
        Me.btnCompute.TabIndex = 6
        Me.btnCompute.Text = "Display Customer Bill"
        Me.btnCompute.UseVisualStyleBackColor = True
        '
        'txtWorkHrs
        '
        Me.txtWorkHrs.Location = New System.Drawing.Point(113, 49)
        Me.txtWorkHrs.Name = "txtWorkHrs"
        Me.txtWorkHrs.Size = New System.Drawing.Size(163, 20)
        Me.txtWorkHrs.TabIndex = 1
        '
        'txtSupplyCost
        '
        Me.txtSupplyCost.Location = New System.Drawing.Point(135, 91)
        Me.txtSupplyCost.Name = "txtSupplyCost"
        Me.txtSupplyCost.Size = New System.Drawing.Size(141, 20)
        Me.txtSupplyCost.TabIndex = 2
        '
        'btnTotalCost
        '
        Me.btnTotalCost.Location = New System.Drawing.Point(298, 134)
        Me.btnTotalCost.Name = "btnTotalCost"
        Me.btnTotalCost.Size = New System.Drawing.Size(124, 23)
        Me.btnTotalCost.TabIndex = 7
        Me.btnTotalCost.Text = "Display Costs Quote"
        Me.btnTotalCost.UseVisualStyleBackColor = True
        '
        'btnLaborInfo
        '
        Me.btnLaborInfo.Location = New System.Drawing.Point(298, 46)
        Me.btnLaborInfo.Name = "btnLaborInfo"
        Me.btnLaborInfo.Size = New System.Drawing.Size(124, 23)
        Me.btnLaborInfo.TabIndex = 8
        Me.btnLaborInfo.Text = "Display Labor Info"
        Me.btnLaborInfo.UseVisualStyleBackColor = True
        '
        'btnCostomerInfo
        '
        Me.btnCostomerInfo.Location = New System.Drawing.Point(298, 11)
        Me.btnCostomerInfo.Name = "btnCostomerInfo"
        Me.btnCostomerInfo.Size = New System.Drawing.Size(124, 23)
        Me.btnCostomerInfo.TabIndex = 9
        Me.btnCostomerInfo.Text = "Display Cust Info"
        Me.btnCostomerInfo.UseVisualStyleBackColor = True
        '
        'btnPartnSupplies
        '
        Me.btnPartnSupplies.Location = New System.Drawing.Point(298, 89)
        Me.btnPartnSupplies.Name = "btnPartnSupplies"
        Me.btnPartnSupplies.Size = New System.Drawing.Size(124, 23)
        Me.btnPartnSupplies.TabIndex = 10
        Me.btnPartnSupplies.Text = "Display Parts Cost"
        Me.btnPartnSupplies.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(298, 217)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(124, 23)
        Me.btnClose.TabIndex = 11
        Me.btnClose.Text = "Exit"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmAutoRepair
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(440, 314)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnPartnSupplies)
        Me.Controls.Add(Me.btnCostomerInfo)
        Me.Controls.Add(Me.btnLaborInfo)
        Me.Controls.Add(Me.btnTotalCost)
        Me.Controls.Add(Me.txtSupplyCost)
        Me.Controls.Add(Me.txtWorkHrs)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.lblthird)
        Me.Controls.Add(Me.lblSecond)
        Me.Controls.Add(Me.lblFirst)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lstTotal)
        Me.Name = "frmAutoRepair"
        Me.Text = "Auto Repair"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstTotal As System.Windows.Forms.ListBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblFirst As System.Windows.Forms.Label
    Friend WithEvents lblSecond As System.Windows.Forms.Label
    Friend WithEvents lblthird As System.Windows.Forms.Label
    Friend WithEvents btnCompute As System.Windows.Forms.Button
    Friend WithEvents txtWorkHrs As System.Windows.Forms.TextBox
    Friend WithEvents txtSupplyCost As System.Windows.Forms.TextBox
    Friend WithEvents btnTotalCost As System.Windows.Forms.Button
    Friend WithEvents btnLaborInfo As System.Windows.Forms.Button
    Friend WithEvents btnCostomerInfo As System.Windows.Forms.Button
    Friend WithEvents btnPartnSupplies As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button

End Class
