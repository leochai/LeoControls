<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FourCell
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
        Me.txtNum = New System.Windows.Forms.TextBox
        Me.picUsed = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.picUsed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNum
        '
        Me.txtNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNum.Font = New System.Drawing.Font("SimSun", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtNum.Location = New System.Drawing.Point(51, 105)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Size = New System.Drawing.Size(95, 23)
        Me.txtNum.TabIndex = 1
        Me.txtNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'picUsed
        '
        Me.picUsed.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.picUsed.Image = Global.LeoControls.My.Resources.Resources.器件
        Me.picUsed.Location = New System.Drawing.Point(23, 7)
        Me.picUsed.Name = "picUsed"
        Me.picUsed.Size = New System.Drawing.Size(154, 74)
        Me.picUsed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picUsed.TabIndex = 0
        Me.picUsed.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(92, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(11, 12)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "1"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FourCell
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNum)
        Me.Controls.Add(Me.picUsed)
        Me.Name = "FourCell"
        Me.Size = New System.Drawing.Size(202, 132)
        CType(Me.picUsed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picUsed As System.Windows.Forms.PictureBox
    Friend WithEvents txtNum As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
