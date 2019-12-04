Public Class Form1

    Public Slide As SCON_Controller

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Slide = New SCON_Controller("COM7", 38400)
        Slide.Connect()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGetState.Click
        Slide.GetState()
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Slide.Home()
    End Sub

    Private Sub btnInchUp_Click(sender As Object, e As EventArgs) Handles btnInchUp.Click
        Slide.InchUp()
    End Sub

    Private Sub btnInchDn_Click(sender As Object, e As EventArgs) Handles btnInchDn.Click
        Slide.InchDn()
    End Sub

    Private Sub btnSON_Click(sender As Object, e As EventArgs) Handles btnSON.Click
        Slide.SetPower(True)
    End Sub

    Private Sub btnSOFF_Click(sender As Object, e As EventArgs) Handles btnSOFF.Click
        Slide.SetPower(False)
    End Sub

    Private Sub btnJogUp_MouseDown(sender As Object, e As MouseEventArgs) Handles btnJogUp.MouseDown
        Slide.JogUpStart()
    End Sub

    Private Sub btnJogDn_MouseDown(sender As Object, e As MouseEventArgs) Handles btnJogDn.MouseDown
        Slide.JogDnStart()
    End Sub

    Private Sub btnJogUpDn_MouseUp(sender As Object, e As MouseEventArgs) Handles btnJogUp.MouseUp, btnJogDn.MouseUp
        Slide.JogStop()
    End Sub
End Class
