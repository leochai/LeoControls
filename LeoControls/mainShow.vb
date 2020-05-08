﻿Public Class mainShow
    Public no As Byte

    Private Sub mainShow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = 140
        Me.Height = 80
    End Sub


    Public Sub SetResult(ByVal unit As Integer, ByVal type As Byte, ByVal volt As Byte,
                         ByVal status As Byte, ByVal no As String)
        lblUnit.Text = "单元" & unit
        lblNo.Text = no
        Select Case volt
            Case 0
                lblVolt.Text = "21V"
            Case 1
                lblVolt.Text = "25V"
            Case 2
                lblVolt.Text = "28V"
            Case 3
                lblVolt.Text = "16V"
            Case 4
                lblVolt.Text = "5.5V"
        End Select
        Select Case status
            Case &H0
                lblStatus.Text = "试验进行中"
                lblStatus.ForeColor = Color.Blue
            Case &H3
                lblStatus.Text = "请求参数"
                'lblStatus.ForeColor = Color.Blue
            Case &HC
                lblStatus.Text = "340,点击继续"
                lblStatus.ForeColor = Color.Red
            Case &H30
                lblStatus.Text = "停止"
                lblStatus.ForeColor = Color.Red
        End Select

        Select Case type
            Case 0
                lblType.Text = "一位插座"
            Case 1
                lblType.Text = "四位插座"
        End Select
    End Sub

    Private Sub lblStatus_Click(sender As Object, e As EventArgs) Handles lblStatus.Click
        If lblStatus.Text = "340暂停，点击继续" Then

        End If
    End Sub
End Class