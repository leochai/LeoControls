Public Class OneShow

    Public Property ShowNum() As String
        Get
            Return lblNum.Text
        End Get
        Set(ByVal value As String)
            lblNum.Text = value
        End Set
    End Property

    Private Sub OneShow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Reset()
    End Sub

    Public Sub Reset()
        lblVolt.Text = "-.-- V"
        lblPower.Text = "-.-- mW"
    End Sub

    Public Sub SetResult(ByVal Volt As Single, ByVal Power As Single)
        lblVolt.Text = Format(Volt, "0.00") & " V"
        lblPower.Text = Format(Power, "0.00") & " mW"
    End Sub

End Class
