Public Class FormTimeInOut
    Private Sub Timer2_Tick(sender As Object, e As EventArgs)
        ReloadAttendance()
    End Sub

    Private Sub btnTimeIn0ut_Click_1(sender As Object, e As EventArgs) Handles btnTimeIn0ut.Click
        LabelDate.Text = DateTime.Now.ToString("yyyy/M/dd")
    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        ReloadAttendance()
    End Sub

    Private Sub LabelDate_Click(sender As Object, e As EventArgs) Handles LabelDate.Click

    End Sub
End Class