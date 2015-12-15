<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OneShow
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.lblVolt = New System.Windows.Forms.Label
        Me.lblPower = New System.Windows.Forms.Label
        Me.lblNum = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lblVolt
        '
        Me.lblVolt.AutoSize = True
        Me.lblVolt.Font = New System.Drawing.Font("SimSun", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblVolt.Location = New System.Drawing.Point(11, 24)
        Me.lblVolt.Name = "lblVolt"
        Me.lblVolt.Size = New System.Drawing.Size(42, 14)
        Me.lblVolt.TabIndex = 0
        Me.lblVolt.Text = "-.--V"
        '
        'lblPower
        '
        Me.lblPower.AutoSize = True
        Me.lblPower.Font = New System.Drawing.Font("SimSun", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblPower.Location = New System.Drawing.Point(11, 56)
        Me.lblPower.Name = "lblPower"
        Me.lblPower.Size = New System.Drawing.Size(49, 14)
        Me.lblPower.TabIndex = 1
        Me.lblPower.Text = "-.--mW"
        '
        'lblNum
        '
        Me.lblNum.AutoSize = True
        Me.lblNum.Font = New System.Drawing.Font("SimSun", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblNum.Location = New System.Drawing.Point(28, 94)
        Me.lblNum.Name = "lblNum"
        Me.lblNum.Size = New System.Drawing.Size(14, 14)
        Me.lblNum.TabIndex = 2
        Me.lblNum.Text = "1"
        '
        'OneShow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.lblNum)
        Me.Controls.Add(Me.lblPower)
        Me.Controls.Add(Me.lblVolt)
        Me.Name = "OneShow"
        Me.Size = New System.Drawing.Size(68, 116)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblVolt As System.Windows.Forms.Label
    Friend WithEvents lblPower As System.Windows.Forms.Label
    Friend WithEvents lblNum As System.Windows.Forms.Label

End Class
