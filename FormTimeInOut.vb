Public Class FormTimeInOut
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LabelDate.Text = DateTime.Now.ToString("yyyy/M/dd")
    End Sub

    Private Sub btnTimeInOut_Click(sender As Object, e As EventArgs) Handles btnTimeInOut.Click
        Try
            If EMPLOYEEID.Text = "" Then
                MessageBox.Show("Please enter Employee ID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                reloadtxt("SELECT * FROM table_employee WHERE EMPLOYEEID='" & EMPLOYEEID.Text & "'")
                If dt.Rows.Count > 0 Then
                    reloadtxt("SELECT * FROM table_attendance WHERE EMPLOYEEID='" & EMPLOYEEID.Text & "' AND LOGDATE='" & LabelDate.Text & "' AND AM_STATUS='Time In' AND PM_STATUS='Time Out'")
                    If dt.Rows.Count > 0 Then
                        MessageBox.Show("You have already time in and timeout for today", "Already", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        reloadtxt("SELECT * FROM table_attendance WHERE EMPLOYEEID ='" & EMPLOYEEID.Text & "' AND LOGDATE='" & LabelDate.Text & "' AND AM_STATUS='Time In'")
                        If dt.Rows.Count > 0 Then
                            updatesLogged("UPDATE table_attendance SET TIMEOUT='" & TimeOfDay & "', PM_STATUS='Time Out',TOTALHOURS=TIMEOUT-TIMEIN  WHERE EMPLOYEEID='" & EMPLOYEEID.Text & "' AND LOGDATE='" & LabelDate.Text & "'")
                            MessageBox.Show("Successfully Time Out", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            createLogged("INSERT INTO table_attendance(EMPLOYEEID,LOGDATE,TIMEIN,AM_STATUS)VALUES('" & EMPLOYEEID.Text & "','" & LabelDate.Text & "','" & TimeOfDay & "','Time In')")
                            MessageBox.Show("Successfully Time In", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End If
                Else
                    MessageBox.Show("Employeed ID not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub FormTimeInOut_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReloadAttendance()
    End Sub
    Public Sub ReloadAttendance()
        Try
            reload("SELECT CONCAT(FIRSTNAME,' ',LASTNAME) AS FULLNAME,LOGDATE,TIMEIN,AM_STATUS,TIMEOUT,PM_STATUS,TOTALHOURS FROM table_attendance INNER JOIN table_employee ON table_attendance.EMPLOYEEID=table_employee.EMPLOYEEID", DataGridView1)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        ReloadAttendance()
    End Sub
End Class