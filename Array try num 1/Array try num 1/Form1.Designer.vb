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
        Me.btncmdPrevious = New System.Windows.Forms.Button()
        Me.btncmdNext = New System.Windows.Forms.Button()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.lblIndex = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btncmdPrevious
        '
        Me.btncmdPrevious.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncmdPrevious.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btncmdPrevious.Location = New System.Drawing.Point(12, 12)
        Me.btncmdPrevious.Name = "btncmdPrevious"
        Me.btncmdPrevious.Size = New System.Drawing.Size(160, 123)
        Me.btncmdPrevious.TabIndex = 0
        Me.btncmdPrevious.Text = "Previous"
        Me.btncmdPrevious.UseVisualStyleBackColor = True
        '
        'btncmdNext
        '
        Me.btncmdNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncmdNext.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btncmdNext.Location = New System.Drawing.Point(12, 210)
        Me.btncmdNext.Name = "btncmdNext"
        Me.btncmdNext.Size = New System.Drawing.Size(160, 121)
        Me.btncmdNext.TabIndex = 1
        Me.btncmdNext.Text = "Next"
        Me.btncmdNext.UseVisualStyleBackColor = True
        '
        'txtOutput
        '
        Me.txtOutput.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOutput.Location = New System.Drawing.Point(190, 28)
        Me.txtOutput.Multiline = True
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.Size = New System.Drawing.Size(450, 237)
        Me.txtOutput.TabIndex = 2
        '
        'lblIndex
        '
        Me.lblIndex.AutoSize = True
        Me.lblIndex.Font = New System.Drawing.Font("Perpetua Titling MT", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIndex.Location = New System.Drawing.Point(34, 156)
        Me.lblIndex.Name = "lblIndex"
        Me.lblIndex.Size = New System.Drawing.Size(116, 34)
        Me.lblIndex.TabIndex = 3
        Me.lblIndex.Text = "Index"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(234, 285)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(406, 46)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(660, 343)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblIndex)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.btncmdNext)
        Me.Controls.Add(Me.btncmdPrevious)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btncmdPrevious As System.Windows.Forms.Button
    Friend WithEvents btncmdNext As System.Windows.Forms.Button
    Friend WithEvents txtOutput As System.Windows.Forms.TextBox
    Friend WithEvents lblIndex As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
