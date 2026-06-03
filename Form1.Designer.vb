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
        Me.pnlRed = New System.Windows.Forms.Panel()
        Me.pnlYellow = New System.Windows.Forms.Panel()
        Me.pnlGreen = New System.Windows.Forms.Panel()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnPedestrian = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pnlPedRed = New System.Windows.Forms.Panel()
        Me.pnlPedGreen = New System.Windows.Forms.Panel()
        Me.lblCountdown = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblTrafficStatus = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.lblPhase = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'pnlRed
        '
        Me.pnlRed.BackColor = System.Drawing.Color.Red
        Me.pnlRed.Location = New System.Drawing.Point(100, 50)
        Me.pnlRed.Name = "pnlRed"
        Me.pnlRed.Size = New System.Drawing.Size(60, 60)
        Me.pnlRed.TabIndex = 0
        '
        'pnlYellow
        '
        Me.pnlYellow.BackColor = System.Drawing.Color.Yellow
        Me.pnlYellow.Location = New System.Drawing.Point(100, 120)
        Me.pnlYellow.Name = "pnlYellow"
        Me.pnlYellow.Size = New System.Drawing.Size(60, 60)
        Me.pnlYellow.TabIndex = 1
        '
        'pnlGreen
        '
        Me.pnlGreen.BackColor = System.Drawing.Color.Green
        Me.pnlGreen.Location = New System.Drawing.Point(100, 190)
        Me.pnlGreen.Name = "pnlGreen"
        Me.pnlGreen.Size = New System.Drawing.Size(60, 60)
        Me.pnlGreen.TabIndex = 2
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(220, 50)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 23)
        Me.btnStart.TabIndex = 3
        Me.btnStart.Text = "START"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(220, 100)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(75, 23)
        Me.btnStop.TabIndex = 4
        Me.btnStop.Text = "STOP"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'btnPedestrian
        '
        Me.btnPedestrian.Location = New System.Drawing.Point(220, 150)
        Me.btnPedestrian.Name = "btnPedestrian"
        Me.btnPedestrian.Size = New System.Drawing.Size(150, 70)
        Me.btnPedestrian.TabIndex = 5
        Me.btnPedestrian.Text = "PEDESTRIAN"
        Me.btnPedestrian.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.Location = New System.Drawing.Point(100, 280)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(200, 30)
        Me.lblStatus.TabIndex = 6
        Me.lblStatus.Text = "Traffic Light Ready"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'pnlPedRed
        '
        Me.pnlPedRed.BackColor = System.Drawing.Color.Red
        Me.pnlPedRed.Location = New System.Drawing.Point(100, 300)
        Me.pnlPedRed.Name = "pnlPedRed"
        Me.pnlPedRed.Size = New System.Drawing.Size(60, 60)
        Me.pnlPedRed.TabIndex = 7
        '
        'pnlPedGreen
        '
        Me.pnlPedGreen.BackColor = System.Drawing.Color.Gray
        Me.pnlPedGreen.Location = New System.Drawing.Point(170, 300)
        Me.pnlPedGreen.Name = "pnlPedGreen"
        Me.pnlPedGreen.Size = New System.Drawing.Size(60, 60)
        Me.pnlPedGreen.TabIndex = 8
        '
        'lblCountdown
        '
        Me.lblCountdown.AutoSize = True
        Me.lblCountdown.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountdown.Location = New System.Drawing.Point(250, 250)
        Me.lblCountdown.Name = "lblCountdown"
        Me.lblCountdown.Size = New System.Drawing.Size(122, 25)
        Me.lblCountdown.TabIndex = 9
        Me.lblCountdown.Text = "Seconds: 0"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(30, 10)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(551, 32)
        Me.lblTitle.TabIndex = 10
        Me.lblTitle.Text = "TRAFFIC LIGHT SIMULATION SYSTEM"
        '
        'lblTrafficStatus
        '
        Me.lblTrafficStatus.AutoSize = True
        Me.lblTrafficStatus.Location = New System.Drawing.Point(425, 203)
        Me.lblTrafficStatus.Name = "lblTrafficStatus"
        Me.lblTrafficStatus.Size = New System.Drawing.Size(91, 16)
        Me.lblTrafficStatus.TabIndex = 11
        Me.lblTrafficStatus.Text = "Status: Ready"
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(505, 100)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 12
        Me.btnReset.Text = "RESET"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'lblPhase
        '
        Me.lblPhase.AutoSize = True
        Me.lblPhase.Location = New System.Drawing.Point(505, 300)
        Me.lblPhase.Name = "lblPhase"
        Me.lblPhase.Size = New System.Drawing.Size(126, 16)
        Me.lblPhase.TabIndex = 13
        Me.lblPhase.Text = "Current Phase: RED"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblPhase)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.lblTrafficStatus)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblCountdown)
        Me.Controls.Add(Me.pnlPedGreen)
        Me.Controls.Add(Me.pnlPedRed)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnPedestrian)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.pnlGreen)
        Me.Controls.Add(Me.pnlYellow)
        Me.Controls.Add(Me.pnlRed)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlRed As Panel
    Friend WithEvents pnlYellow As Panel
    Friend WithEvents pnlGreen As Panel
    Friend WithEvents btnStart As Button
    Friend WithEvents btnStop As Button
    Friend WithEvents btnPedestrian As Button
    Friend WithEvents lblStatus As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents pnlPedRed As Panel
    Friend WithEvents pnlPedGreen As Panel
    Friend WithEvents lblCountdown As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblTrafficStatus As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents lblPhase As Label
End Class
