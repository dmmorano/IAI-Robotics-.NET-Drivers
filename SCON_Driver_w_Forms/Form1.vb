Public Class Form1

    Public Slide As SCON_Controller

    Sub New()
        Slide = New SCON_Controller("COM7", 38400)
        Slide.Active = True
        Slide.Connect()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        tmrUpdateTextboxes.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
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

    Private Sub tmrUpdateTextboxes_Tick(sender As Object, e As EventArgs) Handles tmrUpdateTextboxes.Tick
        Dim st = Slide.State
        tbCurPos.Text = st.PNOW
        tbCurSpeed.Text = st.VNOW
        tbCurAmps.Text = st.CNOW
        tbAlrm.Text = st.ALMC
        lblSftySpeedOn.Visible = st.SFTY
        lblBrkRlsOn.Visible = st.BKRL
    End Sub

    Private Sub btnAbsoluteMove_Click(sender As Object, e As EventArgs) Handles btnAbsoluteMove.Click
        Slide.AbsoluteMove(tbAbsoluteMove.Text)
    End Sub

    Private Sub btnRelativeMove_Click(sender As Object, e As EventArgs) Handles btnRelativeMove.Click
        Slide.RelativeMove(tbRelativeMove.Text)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Slide.StopMotion()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Slide.PauseMotion(True)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Slide.PauseMotion(False)
    End Sub

    Private Sub chkSafetySpeed_CheckedChanged(sender As Object, e As EventArgs) Handles chkSafetySpeed.CheckedChanged
        Slide.SafetySpeed(chkSafetySpeed.Checked)
    End Sub

    Private Sub chkBrkRls_CheckedChanged(sender As Object, e As EventArgs) Handles chkBrkRls.CheckedChanged
        Slide.BreakRelease(chkBrkRls.Checked)
    End Sub

    Private Sub btnResetAlarm_Click(sender As Object, e As EventArgs) Handles btnResetAlarm.Click
        Slide.AlarmReset()
    End Sub

    Private Sub tbSpdSpec_ValueChanged(sender As Object, e As EventArgs) Handles tbSpdSpec.ValueChanged

        Slide.SetSpeed(tbSpdSpec.Value)

    End Sub

    Private Sub tbAccelSpec_ValueChanged(sender As Object, e As EventArgs) Handles tbAccelSpec.ValueChanged

        Slide.SetAccel(tbAccelSpec.Value)

    End Sub

End Class
