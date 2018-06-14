<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class trinketStore
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
        Me.lstBill = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lstBill
        '
        Me.lstBill.FormattingEnabled = True
        Me.lstBill.Location = New System.Drawing.Point(423, 103)
        Me.lstBill.Name = "lstBill"
        Me.lstBill.Size = New System.Drawing.Size(120, 95)
        Me.lstBill.TabIndex = 0
        '
        'trinketStore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(606, 342)
        Me.Controls.Add(Me.lstBill)
        Me.Name = "trinketStore"
        Me.Text = "Trinket Store"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstBill As System.Windows.Forms.ListBox

End Class
