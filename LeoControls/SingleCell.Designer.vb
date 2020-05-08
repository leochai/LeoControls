<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SingleCell
    Inherits System.Windows.Forms.UserControl

    'UserControl 重写释放以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SingleCell))
        Me.picR = New System.Windows.Forms.PictureBox()
        Me.picL = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNum1 = New System.Windows.Forms.TextBox()
        Me.txtNum2 = New System.Windows.Forms.TextBox()
        CType(Me.picR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picR
        '
        Me.picR.Image = Global.LeoControls.My.Resources.Resources.独立器件右
        Me.picR.Location = New System.Drawing.Point(94, 12)
        Me.picR.Name = "picR"
        Me.picR.Size = New System.Drawing.Size(77, 130)
        Me.picR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picR.TabIndex = 1
        Me.picR.TabStop = False
        '
        'picL
        '
        Me.picL.Image = CType(resources.GetObject("picL.Image"), System.Drawing.Image)
        Me.picL.Location = New System.Drawing.Point(17, 12)
        Me.picL.Name = "picL"
        Me.picL.Size = New System.Drawing.Size(77, 130)
        Me.picL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picL.TabIndex = 0
        Me.picL.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(83, 156)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 21)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "1"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNum1
        '
        Me.txtNum1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNum1.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtNum1.Location = New System.Drawing.Point(22, 182)
        Me.txtNum1.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.txtNum1.Name = "txtNum1"
        Me.txtNum1.Size = New System.Drawing.Size(63, 35)
        Me.txtNum1.TabIndex = 4
        Me.txtNum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNum2
        '
        Me.txtNum2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNum2.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtNum2.Location = New System.Drawing.Point(101, 182)
        Me.txtNum2.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.txtNum2.Name = "txtNum2"
        Me.txtNum2.Size = New System.Drawing.Size(63, 35)
        Me.txtNum2.TabIndex = 5
        Me.txtNum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SingleCell
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.txtNum2)
        Me.Controls.Add(Me.txtNum1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picR)
        Me.Controls.Add(Me.picL)
        Me.Name = "SingleCell"
        Me.Size = New System.Drawing.Size(183, 228)
        CType(Me.picR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picL As PictureBox
    Friend WithEvents picR As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNum1 As TextBox
    Friend WithEvents txtNum2 As TextBox
End Class
