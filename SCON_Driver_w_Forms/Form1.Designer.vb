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
        Me.btnGetState = New System.Windows.Forms.Button()
        Me.btnSON = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnSOFF = New System.Windows.Forms.Button()
        Me.btnInchUp = New System.Windows.Forms.Button()
        Me.btnInchDn = New System.Windows.Forms.Button()
        Me.btnJogDn = New System.Windows.Forms.Button()
        Me.btnJogUp = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnGetState
        '
        Me.btnGetState.Location = New System.Drawing.Point(51, 63)
        Me.btnGetState.Name = "btnGetState"
        Me.btnGetState.Size = New System.Drawing.Size(75, 23)
        Me.btnGetState.TabIndex = 0
        Me.btnGetState.Text = "Get State"
        Me.btnGetState.UseVisualStyleBackColor = True
        '
        'btnSON
        '
        Me.btnSON.Location = New System.Drawing.Point(51, 92)
        Me.btnSON.Name = "btnSON"
        Me.btnSON.Size = New System.Drawing.Size(75, 23)
        Me.btnSON.TabIndex = 1
        Me.btnSON.Text = "Servo ON"
        Me.btnSON.UseVisualStyleBackColor = True
        '
        'btnHome
        '
        Me.btnHome.Location = New System.Drawing.Point(51, 121)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(75, 23)
        Me.btnHome.TabIndex = 2
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'btnSOFF
        '
        Me.btnSOFF.Location = New System.Drawing.Point(132, 92)
        Me.btnSOFF.Name = "btnSOFF"
        Me.btnSOFF.Size = New System.Drawing.Size(75, 23)
        Me.btnSOFF.TabIndex = 3
        Me.btnSOFF.Text = "Servo OFF"
        Me.btnSOFF.UseVisualStyleBackColor = True
        '
        'btnInchUp
        '
        Me.btnInchUp.Location = New System.Drawing.Point(51, 175)
        Me.btnInchUp.Name = "btnInchUp"
        Me.btnInchUp.Size = New System.Drawing.Size(75, 23)
        Me.btnInchUp.TabIndex = 4
        Me.btnInchUp.Text = "<- Inch"
        Me.btnInchUp.UseVisualStyleBackColor = True
        '
        'btnInchDn
        '
        Me.btnInchDn.Location = New System.Drawing.Point(132, 175)
        Me.btnInchDn.Name = "btnInchDn"
        Me.btnInchDn.Size = New System.Drawing.Size(75, 23)
        Me.btnInchDn.TabIndex = 5
        Me.btnInchDn.Text = "Inch ->"
        Me.btnInchDn.UseVisualStyleBackColor = True
        '
        'btnJogDn
        '
        Me.btnJogDn.Location = New System.Drawing.Point(132, 204)
        Me.btnJogDn.Name = "btnJogDn"
        Me.btnJogDn.Size = New System.Drawing.Size(75, 23)
        Me.btnJogDn.TabIndex = 7
        Me.btnJogDn.Text = "Jog ->"
        Me.btnJogDn.UseVisualStyleBackColor = True
        '
        'btnJogUp
        '
        Me.btnJogUp.Location = New System.Drawing.Point(51, 204)
        Me.btnJogUp.Name = "btnJogUp"
        Me.btnJogUp.Size = New System.Drawing.Size(75, 23)
        Me.btnJogUp.TabIndex = 6
        Me.btnJogUp.Text = "<- Jog"
        Me.btnJogUp.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnJogDn)
        Me.Controls.Add(Me.btnJogUp)
        Me.Controls.Add(Me.btnInchDn)
        Me.Controls.Add(Me.btnInchUp)
        Me.Controls.Add(Me.btnSOFF)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.btnSON)
        Me.Controls.Add(Me.btnGetState)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnGetState As Button
    Friend WithEvents btnSON As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents btnSOFF As Button
    Friend WithEvents btnInchUp As Button
    Friend WithEvents btnInchDn As Button
    Friend WithEvents btnJogDn As Button
    Friend WithEvents btnJogUp As Button
End Class
