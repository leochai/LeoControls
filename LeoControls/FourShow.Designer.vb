<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FourShow
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
        Me.lblNum = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblResultA = New System.Windows.Forms.Label
        Me.lblResultB = New System.Windows.Forms.Label
        Me.lblResultC = New System.Windows.Forms.Label
        Me.lblResultD = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lblNum
        '
        Me.lblNum.AutoSize = True
        Me.lblNum.Font = New System.Drawing.Font("SimSun", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblNum.Location = New System.Drawing.Point(60, 94)
        Me.lblNum.Name = "lblNum"
        Me.lblNum.Size = New System.Drawing.Size(14, 14)
        Me.lblNum.TabIndex = 0
        Me.lblNum.Text = "1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("SimSun", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(14, 14)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "A"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("SimSun", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(14, 14)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "B"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("SimSun", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(14, 14)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "C"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("SimSun", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(14, 14)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "D"
        '
        'lblResultA
        '
        Me.lblResultA.AutoSize = True
        Me.lblResultA.Font = New System.Drawing.Font("SimSun", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblResultA.Location = New System.Drawing.Point(26, 6)
        Me.lblResultA.Name = "lblResultA"
        Me.lblResultA.Size = New System.Drawing.Size(49, 14)
        Me.lblResultA.TabIndex = 5
        Me.lblResultA.Text = "Label5"
        '
        'lblResultB
        '
        Me.lblResultB.AutoSize = True
        Me.lblResultB.Font = New System.Drawing.Font("SimSun", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblResultB.Location = New System.Drawing.Point(26, 28)
        Me.lblResultB.Name = "lblResultB"
        Me.lblResultB.Size = New System.Drawing.Size(49, 14)
        Me.lblResultB.TabIndex = 6
        Me.lblResultB.Text = "Label5"
        '
        'lblResultC
        '
        Me.lblResultC.AutoSize = True
        Me.lblResultC.Font = New System.Drawing.Font("SimSun", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblResultC.Location = New System.Drawing.Point(26, 50)
        Me.lblResultC.Name = "lblResultC"
        Me.lblResultC.Size = New System.Drawing.Size(49, 14)
        Me.lblResultC.TabIndex = 7
        Me.lblResultC.Text = "Label5"
        '
        'lblResultD
        '
        Me.lblResultD.AutoSize = True
        Me.lblResultD.Font = New System.Drawing.Font("SimSun", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblResultD.Location = New System.Drawing.Point(26, 72)
        Me.lblResultD.Name = "lblResultD"
        Me.lblResultD.Size = New System.Drawing.Size(49, 14)
        Me.lblResultD.TabIndex = 8
        Me.lblResultD.Text = "Label5"
        '
        'FourShow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.lblResultD)
        Me.Controls.Add(Me.lblResultC)
        Me.Controls.Add(Me.lblResultB)
        Me.Controls.Add(Me.lblResultA)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblNum)
        Me.Name = "FourShow"
        Me.Size = New System.Drawing.Size(136, 116)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNum As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblResultA As System.Windows.Forms.Label
    Friend WithEvents lblResultB As System.Windows.Forms.Label
    Friend WithEvents lblResultC As System.Windows.Forms.Label
    Friend WithEvents lblResultD As System.Windows.Forms.Label

End Class
