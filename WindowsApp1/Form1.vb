Public Class FormTimer
    Dim EndTime As Integer
    Dim NowTime As Integer

    Private Sub ButtonStart_Click(sender As Object, e As EventArgs) Handles ButtonStart.Click

        If Integer.TryParse(TextSetTimer.Text, EndTime) = True Then
            EndTime = Integer.Parse(TextSetTimer.Text)
        Else
            EndTime = 1
        End If

        NowTime = 0

        TimerControl.Start()

    End Sub

    Private Sub TimerControl_Tick(sender As Object, e As EventArgs) Handles TimerControl.Tick

        Dim RemainingTime As Integer

        NowTime = NowTime + 1

        RemainingTime = EndTime - NowTime
        TextRemainingTime.Text = RemainingTime.ToString

        If EndTime = NowTime Then
            TimerControl.Stop()
            MessageBox.Show("時間になりました！")
        Else

        End If

    End Sub
End Class
