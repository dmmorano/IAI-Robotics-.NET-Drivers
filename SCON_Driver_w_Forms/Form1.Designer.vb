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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnRelativeMove = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
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
        Me.tbCurPos.Location = New System.Drawing.Point(109, 196)
        Me.tbCurPos.Name = "tbCurPos"
        Me.tbCurPos.ReadOnly = True
        Me.tbCurPos.Size = New System.Drawing.Size(48, 20)
        Me.tbCurPos.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 199)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Current Position"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 225)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Current Speed"
        '
        'tbCurSpeed
        '
        Me.tbCurSpeed.Location = New System.Drawing.Point(109, 222)
        Me.tbCurSpeed.Name = "tbCurSpeed"
        Me.tbCurSpeed.ReadOnly = True
        Me.tbCurSpeed.Size = New System.Drawing.Size(48, 20)
        Me.tbCurSpeed.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 251)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Motor Draw"
        '
        'tbCurAmps
        '
        Me.tbCurAmps.Location = New System.Drawing.Point(109, 248)
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
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(109, 170)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(48, 20)
        Me.TextBox1.TabIndex = 17
        Me.TextBox1.Text = "50"
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
        Me.Label6.Location = New System.Drawing.Point(161, 199)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "mm"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(161, 225)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "mm/s"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(161, 251)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(22, 13)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "mA"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(214, 296)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox1)
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
        Me.Text = "Form1"
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
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnRelativeMove As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class
