Public Class OneCell
    Public isUsed As Boolean

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

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        If isUsed Then
            isUsed = False
            PictureBox1.BackColor = Color.FromArgb(255, 192, 192)
            txtNum.Text = ""
            txtNum.Enabled = False
        Else
            isUsed = True
            PictureBox1.BackColor = Color.FromArgb(192, 255, 192)
            txtNum.Enabled = True
        End If
    End Sub

    Private Sub OneCell_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        isUsed = False
        PictureBox1.BackColor = Color.FromArgb(255, 192, 192)
        txtNum.Enabled = False
    End Sub

    Public Sub Reset()
        isUsed = False
        PictureBox1.BackColor = Color.FromArgb(255, 192, 192)
        txtNum.Text = ""
        txtNum.Enabled = False
    End Sub

    Private Sub txtNum_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNum.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(8) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Sub SetTrue()
        isUsed = True
        PictureBox1.BackColor = Color.FromArgb(192, 255, 192)
        txtNum.Enabled = True
    End Sub
End Class
