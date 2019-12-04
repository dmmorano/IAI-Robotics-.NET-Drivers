<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnSON = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnSOFF = New System.Windows.Forms.Button()
        Me.btnInchUp = New System.Windows.Forms.Button()
        Me.btnInchDn = New System.Windows.Forms.Button()
        Me.btnJogDn = New System.Windows.Forms.Button()
        Me.btnJogUp = New System.Windows.Forms.Button()
        Me.tbCurPos = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbCurSpeed = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbCurAmps = New System.Windows.Forms.TextBox()
        Me.tmrUpdateTextboxes = New System.Windows.Forms.Timer(Me.components)
        Me.btnAbsoluteMove = New System.Windows.Forms.Button()
        Me.tbAbsoluteMove = New System.Windows.Forms.TextBox()
        Me.tbRelativeMove = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.chkSafetySpeed = New System.Windows.Forms.CheckBox()
        Me.btnRelativeMove = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.chkBrkRls = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbAlrm = New System.Windows.Forms.TextBox()
        Me.btnResetAlarm = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblSftySpeedOn = New System.Windows.Forms.Label()
        Me.lblBrkRlsOn = New System.Windows.Forms.Label()
        Me.tbSpdSpec = New System.Windows.Forms.NumericUpDown()
        Me.tbAccelSpec = New System.Windows.Forms.NumericUpDown()
        CType(Me.tbSpdSpec, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbAccelSpec, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSON
        '
        Me.btnSON.Location = New System.Drawing.Point(28, 23)
        Me.btnSON.Name = "btnSON"
        Me.btnSON.Size = New System.Drawing.Size(75, 23)
        Me.btnSON.TabIndex = 1
        Me.btnSON.Text = "Servo ON"
        Me.btnSON.UseVisualStyleBackColor = True
        '
        'btnHome
        '
        Me.btnHome.Location = New System.Drawing.Point(28, 52)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(156, 23)
        Me.btnHome.TabIndex = 2
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'btnSOFF
        '
        Me.btnSOFF.Location = New System.Drawing.Point(109, 23)
        Me.btnSOFF.Name = "btnSOFF"
        Me.btnSOFF.Size = New System.Drawing.Size(75, 23)
        Me.btnSOFF.TabIndex = 3
        Me.btnSOFF.Text = "Servo OFF"
        Me.btnSOFF.UseVisualStyleBackColor = True
        '
        'btnInchUp
        '
        Me.btnInchUp.Location = New System.Drawing.Point(28, 81)
        Me.btnInchUp.Name = "btnInchUp"
        Me.btnInchUp.Size = New System.Drawing.Size(75, 23)
        Me.btnInchUp.TabIndex = 4
        Me.btnInchUp.Text = "<- Inch"
        Me.btnInchUp.UseVisualStyleBackColor = True
        '
        'btnInchDn
        '
        Me.btnInchDn.Location = New System.Drawing.Point(109, 81)
        Me.btnInchDn.Name = "btnInchDn"
        Me.btnInchDn.Size = New System.Drawing.Size(75, 23)
        Me.btnInchDn.TabIndex = 5
        Me.btnInchDn.Text = "Inch ->"
        Me.btnInchDn.UseVisualStyleBackColor = True
        '
        'btnJogDn
        '
        Me.btnJogDn.Location = New System.Drawing.Point(109, 110)
        Me.btnJogDn.Name = "btnJogDn"
        Me.btnJogDn.Size = New System.Drawing.Size(75, 23)
        Me.btnJogDn.TabIndex = 7
        Me.btnJogDn.Text = "Jog ->"
        Me.btnJogDn.UseVisualStyleBackColor = True
        '
        'btnJogUp
        '
        Me.btnJogUp.Location = New System.Drawing.Point(28, 110)
        Me.btnJogUp.Name = "btnJogUp"
        Me.btnJogUp.Size = New System.Drawing.Size(75, 23)
        Me.btnJogUp.TabIndex = 6
        Me.btnJogUp.Text = "<- Jog"
        Me.btnJogUp.UseVisualStyleBackColor = True
        '
        'tbCurPos
        '
        Me.tbCurPos.Location = New System.Drawing.Point(107, 358)
        Me.tbCurPos.Name = "tbCurPos"
        Me.tbCurPos.ReadOnly = True
        Me.tbCurPos.Size = New System.Drawing.Size(48, 20)
        Me.tbCurPos.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 361)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Current Position"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 387)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Current Speed"
        '
        'tbCurSpeed
        '
        Me.tbCurSpeed.Location = New System.Drawing.Point(107, 384)
        Me.tbCurSpeed.Name = "tbCurSpeed"
        Me.tbCurSpeed.ReadOnly = True
        Me.tbCurSpeed.Size = New System.Drawing.Size(48, 20)
        Me.tbCurSpeed.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 413)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Motor Draw"
        '
        'tbCurAmps
        '
        Me.tbCurAmps.Location = New System.Drawing.Point(107, 410)
        Me.tbCurAmps.Name = "tbCurAmps"
        Me.tbCurAmps.ReadOnly = True
        Me.tbCurAmps.Size = New System.Drawing.Size(48, 20)
        Me.tbCurAmps.TabIndex = 12
        '
        'tmrUpdateTextboxes
        '
        Me.tmrUpdateTextboxes.Interval = 25
        '
        'btnAbsoluteMove
        '
        Me.btnAbsoluteMove.Location = New System.Drawing.Point(28, 139)
        Me.btnAbsoluteMove.Name = "btnAbsoluteMove"
        Me.btnAbsoluteMove.Size = New System.Drawing.Size(75, 23)
        Me.btnAbsoluteMove.TabIndex = 14
        Me.btnAbsoluteMove.Text = "Goto:"
        Me.btnAbsoluteMove.UseVisualStyleBackColor = True
        '
        'tbAbsoluteMove
        '
        Me.tbAbsoluteMove.Location = New System.Drawing.Point(109, 141)
        Me.tbAbsoluteMove.Name = "tbAbsoluteMove"
        Me.tbAbsoluteMove.Size = New System.Drawing.Size(48, 20)
        Me.tbAbsoluteMove.TabIndex = 15
        Me.tbAbsoluteMove.Text = "100"
        '
        'tbRelativeMove
        '
        Me.tbRelativeMove.Location = New System.Drawing.Point(109, 170)
        Me.tbRelativeMove.Name = "tbRelativeMove"
        Me.tbRelativeMove.Size = New System.Drawing.Size(48, 20)
        Me.tbRelativeMove.TabIndex = 17
        Me.tbRelativeMove.Text = "50"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(161, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "mm"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(161, 173)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "mm"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(159, 361)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "mm"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(159, 387)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "mm/s"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(159, 413)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(22, 13)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "mA"
        '
        'chkSafetySpeed
        '
        Me.chkSafetySpeed.AutoSize = True
        Me.chkSafetySpeed.Location = New System.Drawing.Point(52, 311)
        Me.chkSafetySpeed.Name = "chkSafetySpeed"
        Me.chkSafetySpeed.Size = New System.Drawing.Size(90, 17)
        Me.chkSafetySpeed.TabIndex = 23
        Me.chkSafetySpeed.Text = "Safety Speed"
        Me.chkSafetySpeed.UseVisualStyleBackColor = True
        '
        'btnRelativeMove
        '
        Me.btnRelativeMove.Location = New System.Drawing.Point(28, 168)
        Me.btnRelativeMove.Name = "btnRelativeMove"
        Me.btnRelativeMove.Size = New System.Drawing.Size(75, 23)
        Me.btnRelativeMove.TabIndex = 16
        Me.btnRelativeMove.Text = "Shift:"
        Me.btnRelativeMove.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(28, 197)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(154, 25)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Stop"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(28, 228)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 25)
        Me.Button2.TabIndex = 25
        Me.Button2.Text = "Pause"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(107, 228)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 25)
        Me.Button3.TabIndex = 26
        Me.Button3.Text = "Resume"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'chkBrkRls
        '
        Me.chkBrkRls.AutoSize = True
        Me.chkBrkRls.Location = New System.Drawing.Point(52, 334)
        Me.chkBrkRls.Name = "chkBrkRls"
        Me.chkBrkRls.Size = New System.Drawing.Size(96, 17)
        Me.chkBrkRls.TabIndex = 27
        Me.chkBrkRls.Text = "Break Release"
        Me.chkBrkRls.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(37, 439)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 13)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Alarm Status"
        '
        'tbAlrm
        '
        Me.tbAlrm.Location = New System.Drawing.Point(107, 436)
        Me.tbAlrm.Name = "tbAlrm"
        Me.tbAlrm.ReadOnly = True
        Me.tbAlrm.Size = New System.Drawing.Size(85, 20)
        Me.tbAlrm.TabIndex = 28
        '
        'btnResetAlarm
        '
        Me.btnResetAlarm.Location = New System.Drawing.Point(28, 462)
        Me.btnResetAlarm.Name = "btnResetAlarm"
        Me.btnResetAlarm.Size = New System.Drawing.Size(154, 25)
        Me.btnResetAlarm.TabIndex = 30
        Me.btnResetAlarm.Text = "Reset Alarms"
        Me.btnResetAlarm.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(35, 262)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 13)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Speed Spec"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(165, 262)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(33, 13)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "mm/s"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(169, 288)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(15, 13)
        Me.Label12.TabIndex = 36
        Me.Label12.Text = "G"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(35, 288)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(62, 13)
        Me.Label13.TabIndex = 35
        Me.Label13.Text = "Accel Spec"
        '
        'lblSftySpeedOn
        '
        Me.lblSftySpeedOn.AutoSize = True
        Me.lblSftySpeedOn.BackColor = System.Drawing.Color.Lime
        Me.lblSftySpeedOn.Location = New System.Drawing.Point(23, 312)
        Me.lblSftySpeedOn.Name = "lblSftySpeedOn"
        Me.lblSftySpeedOn.Size = New System.Drawing.Size(23, 13)
        Me.lblSftySpeedOn.TabIndex = 37
        Me.lblSftySpeedOn.Text = "ON"
        Me.lblSftySpeedOn.Visible = False
        '
        'lblBrkRlsOn
        '
        Me.lblBrkRlsOn.AutoSize = True
        Me.lblBrkRlsOn.BackColor = System.Drawing.Color.Lime
        Me.lblBrkRlsOn.Location = New System.Drawing.Point(23, 334)
        Me.lblBrkRlsOn.Name = "lblBrkRlsOn"
        Me.lblBrkRlsOn.Size = New System.Drawing.Size(23, 13)
        Me.lblBrkRlsOn.TabIndex = 38
        Me.lblBrkRlsOn.Text = "ON"
        Me.lblBrkRlsOn.Visible = False
        '
        'tbSpdSpec
        '
        Me.tbSpdSpec.DecimalPlaces = 2
        Me.tbSpdSpec.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.tbSpdSpec.Location = New System.Drawing.Point(107, 260)
        Me.tbSpdSpec.Maximum = New Decimal(New Integer() {350, 0, 0, 0})
        Me.tbSpdSpec.Minimum = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.tbSpdSpec.Name = "tbSpdSpec"
        Me.tbSpdSpec.Size = New System.Drawing.Size(56, 20)
        Me.tbSpdSpec.TabIndex = 39
        Me.tbSpdSpec.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'tbAccelSpec
        '
        Me.tbAccelSpec.DecimalPlaces = 2
        Me.tbAccelSpec.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.tbAccelSpec.Location = New System.Drawing.Point(107, 285)
        Me.tbAccelSpec.Maximum = New Decimal(New Integer() {99, 0, 0, 131072})
        Me.tbAccelSpec.Minimum = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.tbAccelSpec.Name = "tbAccelSpec"
        Me.tbAccelSpec.Size = New System.Drawing.Size(56, 20)
        Me.tbAccelSpec.TabIndex = 40
        Me.tbAccelSpec.Value = New Decimal(New Integer() {1, 0, 0, 65536})
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(220, 526)
        Me.Controls.Add(Me.tbAccelSpec)
        Me.Controls.Add(Me.tbSpdSpec)
        Me.Controls.Add(Me.lblBrkRlsOn)
        Me.Controls.Add(Me.lblSftySpeedOn)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnResetAlarm)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.tbAlrm)
        Me.Controls.Add(Me.chkBrkRls)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.chkSafetySpeed)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbRelativeMove)
        Me.Controls.Add(Me.btnRelativeMove)
        Me.Controls.Add(Me.tbAbsoluteMove)
        Me.Controls.Add(Me.btnAbsoluteMove)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbCurAmps)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbCurSpeed)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbCurPos)
        Me.Controls.Add(Me.btnJogDn)
        Me.Controls.Add(Me.btnJogUp)
        Me.Controls.Add(Me.btnInchDn)
        Me.Controls.Add(Me.btnInchUp)
        Me.Controls.Add(Me.btnSOFF)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.btnSON)
        Me.Name = "Form1"
        Me.Text = "SCON Controller"
        CType(Me.tbSpdSpec, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbAccelSpec, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSON As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents btnSOFF As Button
    Friend WithEvents btnInchUp As Button
    Friend WithEvents btnInchDn As Button
    Friend WithEvents btnJogDn As Button
    Friend WithEvents btnJogUp As Button
    Friend WithEvents tbCurPos As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbCurSpeed As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbCurAmps As TextBox
    Friend WithEvents tmrUpdateTextboxes As Timer
    Friend WithEvents btnAbsoluteMove As Button
    Friend WithEvents tbAbsoluteMove As TextBox
    Friend WithEvents tbRelativeMove As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents chkSafetySpeed As CheckBox
    Friend WithEvents btnRelativeMove As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents chkBrkRls As CheckBox
    Friend WithEvents Label9 As Label
    Friend WithEvents tbAlrm As TextBox
    Friend WithEvents btnResetAlarm As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lblSftySpeedOn As Label
    Friend WithEvents lblBrkRlsOn As Label
    Friend WithEvents tbSpdSpec As NumericUpDown
    Friend WithEvents tbAccelSpec As NumericUpDown
End Class
