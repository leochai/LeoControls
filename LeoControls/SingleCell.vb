Public Class SingleCell
    Public isUsedL As Boolean
    Public isUsedR As Boolean

    Public Property CellLNum() As String
        Get
            Return txtNum1.Text
        End Get
        Set(ByVal value As String)
            txtNum1.Text = value
        End Set
    End Property
    Public Property CellRNum() As String
        Get
            Return txtNum2.Text
        End Get
        Set(ByVal value As String)
            txtNum2.Text = value
        End Set
    End Property

    Public WriteOnly Property CellLabel() As String
        Set(ByVal value As String)
            Label1.Text = value
        End Set
    End Property

    Private Sub SingleCell_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Reset()
    End Sub

    Public Sub Reset()
        isUsedL = False
        isUsedR = False
        SetColor()
    End Sub
    Private Sub SetColor()
        If Not isUsedL Then
            picL.BackColor = Color.FromArgb(255, 192, 192)
            txtNum1.Text = ""
            txtNum1.Enabled = False
        Else
            picL.BackColor = Color.FromArgb(192, 255, 192)
            txtNum1.Enabled = True
        End If
        If Not isUsedR Then
            picR.BackColor = Color.FromArgb(255, 192, 192)
            txtNum2.Text = ""
            txtNum2.Enabled = False
        Else
            picR.BackColor = Color.FromArgb(192, 255, 192)
            txtNum2.Enabled = True
        End If

    End Sub

    Private Sub picL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picL.Click
        isUsedL = Not isUsedL
        SetColor()
    End Sub


    Private Sub picR_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles picR.Click
        isUsedR = Not isUsedR
        SetColor()
    End Sub

    Private Sub txtNum1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNum1.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(8) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtNum2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNum2.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(8) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Sub SetTrue()
        isUsedL = True
        picL.BackColor = Color.FromArgb(192, 255, 192)
        txtNum1.Enabled = True
        isUsedR = True
        picR.BackColor = Color.FromArgb(192, 255, 192)
        txtNum2.Enabled = True
    End Sub
End Class
