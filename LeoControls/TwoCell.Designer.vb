<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TwoCell
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtNum = New System.Windows.Forms.TextBox
        Me.picRight = New System.Windows.Forms.PictureBox
        Me.picMid = New System.Windows.Forms.PictureBox
        Me.picLeft = New System.Windows.Forms.PictureBox
        CType(Me.picRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(93, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(11, 12)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "1"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNum
        '
        Me.txtNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNum.Font = New System.Drawing.Font("SimSun", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtNum.Location = New System.Drawing.Point(51, 102)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Size = New System.Drawing.Size(95, 23)
        Me.txtNum.TabIndex = 4
        Me.txtNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'picRight
        '
        Me.picRight.Image = Global.LeoControls.My.Resources.Resources.二位器件右
        Me.picRight.Location = New System.Drawing.Point(124, 7)
        Me.picRight.Name = "picRight"
        Me.picRight.Size = New System.Drawing.Size(51, 74)
        Me.picRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picRight.TabIndex = 8
        Me.picRight.TabStop = False
        '
        'picMid
        '
        Me.picMid.Image = Global.LeoControls.My.Resources.Resources.二位器件中
        Me.picMid.Location = New System.Drawing.Point(74, 7)
        Me.picMid.Name = "picMid"
        Me.picMid.Size = New System.Drawing.Size(51, 74)
        Me.picMid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMid.TabIndex = 7
        Me.picMid.TabStop = False
        '
        'picLeft
        '
        Me.picLeft.Image = Global.LeoControls.My.Resources.Resources.二位器件左
        Me.picLeft.Location = New System.Drawing.Point(24, 7)
        Me.picLeft.Name = "picLeft"
        Me.picLeft.Size = New System.Drawing.Size(51, 74)
        Me.picLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLeft.TabIndex = 6
        Me.picLeft.TabStop = False
        '
        'TwoCell
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.picRight)
        Me.Controls.Add(Me.picMid)
        Me.Controls.Add(Me.picLeft)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNum)
        Me.Name = "TwoCell"
        Me.Size = New System.Drawing.Size(200, 130)
        CType(Me.picRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLeft, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNum As System.Windows.Forms.TextBox
    Friend WithEvents picLeft As System.Windows.Forms.PictureBox
    Friend WithEvents picMid As System.Windows.Forms.PictureBox
    Friend WithEvents picRight As System.Windows.Forms.PictureBox

End Class
