Public Class TwoCell
    Public isUsed As Boolean
    Public whichPos As Integer  '无0左1中2右3

    Public Property CellNum() As String
        Get
            Return txtNum.Text
        End Get
        Set(ByVal value As String)
            txtNum.Text = value
        End Set
    End Property

    Public WriteOnly Property CellLabel() As String
        Set(ByVal value As String)
            Label1.Text = value
        End Set
    End Property

    Private Sub TwoCell_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Reset()
    End Sub

    Public Sub Reset()
        isUsed = False
        whichPos = 0
        SetColor()
    End Sub
    Private Sub SetColor()
        If Not isUsed Then
            picLeft.BackColor = Color.FromArgb(255, 192, 192)
            picMid.BackColor = Color.FromArgb(255, 192, 192)
            picRight.BackColor = Color.FromArgb(255, 192, 192)
            txtNum.Text = ""
            txtNum.Enabled = False
        Else
            Select Case whichPos
                Case 1
                    picLeft.BackColor = Color.FromArgb(192, 255, 192)
                    picMid.BackColor = Color.FromArgb(255, 192, 192)
                    picRight.BackColor = Color.FromArgb(255, 192, 192)
                    txtNum.Enabled = True
                Case 2
                    picLeft.BackColor = Color.FromArgb(255, 192, 192)
                    picMid.BackColor = Color.FromArgb(192, 255, 192)
                    picRight.BackColor = Color.FromArgb(255, 192, 192)
                    txtNum.Enabled = True
                Case 3
                    picLeft.BackColor = Color.FromArgb(255, 192, 192)
                    picMid.BackColor = Color.FromArgb(255, 192, 192)
                    picRight.BackColor = Color.FromArgb(192, 255, 192)
                    txtNum.Enabled = True
            End Select
        End If
    End Sub

    Private Sub picLeft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picLeft.Click
        If Not isUsed Then
            isUsed = True
            whichPos = 1
        Else
            Select Case whichPos
                Case 1
                    whichPos = 0
                    isUsed = False
                Case 2
                    whichPos = 1
                Case 3
                    whichPos = 1
            End Select
        End If
        SetColor()
    End Sub

    Private Sub picMid_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles picMid.Click
        If Not isUsed Then
            isUsed = True
            whichPos = 2
        Else
            Select Case whichPos
                Case 1
                    whichPos = 2
                Case 2
                    whichPos = 0
                    isUsed = False
                Case 3
                    whichPos = 2
            End Select
        End If
        SetColor()
    End Sub

    Private Sub picRight_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles picRight.Click
        If Not isUsed Then
            isUsed = True
            whichPos = 3
        Else
            Select Case whichPos
                Case 1
                    whichPos = 3
                Case 2
                    whichPos = 3
                Case 3
                    whichPos = 0
                    isUsed = False
            End Select
        End If
        SetColor()
    End Sub

    Private Sub txtNum_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNum.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(8) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class
