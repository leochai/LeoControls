Public Class SwitchLight
    Public Sub TurnOnOff(ByVal isTesting As Boolean)
        If isTesting Then
            PictureBox1.Image = My.Resources.Resources.绿灯
        Else
            PictureBox1.Image = My.Resources.Resources.红灯
        End If
    End Sub

    Private Sub SwitchLight_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        PictureBox1.Size = Me.Size
    End Sub

End Class
