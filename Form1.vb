Public Class Form1

    Dim state As Integer = 0
    Dim seconds As Integer = 0
    Dim pedestrianRequest As Boolean = False

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        pnlRed.BackColor = Color.Red
        pnlYellow.BackColor = Color.Gray
        pnlGreen.BackColor = Color.Gray

        pnlPedRed.BackColor = Color.Red
        pnlPedGreen.BackColor = Color.Gray

        lblTrafficStatus.Text = "Status: Ready"
        lblCountdown.Text = "Seconds: 0"
        lblPhase.Text = "Current Phase: RED"

    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Timer1.Start()
        lblTrafficStatus.Text = "Traffic Running"
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        Timer1.Stop()
        lblTrafficStatus.Text = "Traffic Stopped"
    End Sub

    Private Sub btnPedestrian_Click(sender As Object, e As EventArgs) Handles btnPedestrian.Click
        pedestrianRequest = True
        lblTrafficStatus.Text = "Pedestrian Waiting"
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        Timer1.Stop()

        state = 0
        seconds = 0
        pedestrianRequest = False

        pnlRed.BackColor = Color.Red
        pnlYellow.BackColor = Color.Gray
        pnlGreen.BackColor = Color.Gray

        pnlPedRed.BackColor = Color.Red
        pnlPedGreen.BackColor = Color.Gray

        lblTrafficStatus.Text = "Status: Reset"
        lblCountdown.Text = "Seconds: 0"
        lblPhase.Text = "Current Phase: RED"

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        seconds += 1
        lblCountdown.Text = "Seconds: " & seconds

        Select Case state

            Case 0 ' GREEN

                pnlRed.BackColor = Color.Gray
                pnlYellow.BackColor = Color.Gray
                pnlGreen.BackColor = Color.Lime

                lblTrafficStatus.Text = "GREEN"
                lblPhase.Text = "Current Phase: GREEN"

                pnlPedRed.BackColor = Color.Red
                pnlPedGreen.BackColor = Color.Gray

                If seconds >= 5 Then
                    state = 1
                    seconds = 0
                End If

            Case 1 ' YELLOW

                pnlRed.BackColor = Color.Gray
                pnlYellow.BackColor = Color.Yellow
                pnlGreen.BackColor = Color.Gray

                lblTrafficStatus.Text = "YELLOW"
                lblPhase.Text = "Current Phase: YELLOW"

                If seconds >= 2 Then
                    state = 2
                    seconds = 0
                End If

            Case 2 ' RED

                pnlRed.BackColor = Color.Red
                pnlYellow.BackColor = Color.Gray
                pnlGreen.BackColor = Color.Gray

                lblTrafficStatus.Text = "RED"
                lblPhase.Text = "Current Phase: RED"

                If pedestrianRequest Then
                    pnlPedRed.BackColor = Color.Gray
                    pnlPedGreen.BackColor = Color.Lime
                    lblTrafficStatus.Text = "PEDESTRIAN CROSSING"
                Else
                    pnlPedRed.BackColor = Color.Red
                    pnlPedGreen.BackColor = Color.Gray
                End If

                If seconds >= 5 Then
                    pedestrianRequest = False
                    state = 0
                    seconds = 0
                End If

        End Select

    End Sub

End Class