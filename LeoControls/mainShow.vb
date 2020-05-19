Public Class mainShow
    Public no As Byte

    Private Sub mainShow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = 140
        Me.Height = 80
    End Sub



    Public Sub SetResult(ByVal unit As Integer, ByVal type As Byte, ByVal isrc As Boolean,
                         ByVal volt As Byte, ByVal status As Byte, ByVal no As String)

        lblUnit.Text = "单元" & unit
        lblNo.Text = no
        If isrc Then
            Label1.Text = "额定电流"
            Select Case volt
                Case 1
                    lblVolt.Text = "10mA"
                Case 2
                    lblVolt.Text = "20mA"
                Case 3
                    lblVolt.Text = "30mA"
            End Select
        Else
            Label1.Text = "额定电压"
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
        End If

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

End Class
