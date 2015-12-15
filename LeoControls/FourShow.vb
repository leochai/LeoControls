Public Class FourShow

    Public Property ShowNum() As String
        Get
            Return lblNum.Text
        End Get
        Set(ByVal value As String)
            lblNum.Text = value
        End Set
    End Property


    Private Sub FourShow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Reset()
    End Sub

    Private Sub Reset()
        lblResultA.Text = "-.-- V, -.-- mW"
        lblResultB.Text = "-.-- V, -.-- mW"
        lblResultC.Text = "-.-- V, -.-- mW"
        lblResultD.Text = "-.-- V, -.-- mW"
    End Sub

    Public Sub SetResult(ByVal Volt As Single, ByVal Power As Single, ByVal pos As Byte)
        Select Case pos
            Case 0
                lblResultA.Text = Format(Volt, ".00") & " V, " & Format(Power, ".00") & " mW"
            Case 1
                lblResultB.Text = Format(Volt, ".00") & " V, " & Format(Power, ".00") & " mW"
            Case 2
                lblResultC.Text = Format(Volt, ".00") & " V, " & Format(Power, ".00") & " mW"
            Case 3
                lblResultD.Text = Format(Volt, ".00") & " V, " & Format(Power, ".00") & " mW"
        End Select
    End Sub
End Class
