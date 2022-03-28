Public Class Form1
    Dim message As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Now.DayOfWeek = System.DayOfWeek.Monday Then
            message = "Have a nice week"
        Else
            If Now.DayOfWeek >= System.DayOfWeek.Tuesday And
            Now.DayOfWeek <= System.DayOfWeek.Friday Then
                message = "Welcome back!"
            Else
                message = "Have a nice weekend!"
            End If
        End If
        MessageBox.Show(message, "If Statement", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Select Case Now.DayOfWeek
            Case System.DayOfWeek.Monday
                message = "Have a nice week"
            Case System.DayOfWeek.Tuesday, System.DayOfWeek.Wednesday,
            System.DayOfWeek.Thursday, System.DayOfWeek.Friday
                message = "Welcome back!"
            Case System.DayOfWeek.Saturday, System.DayOfWeek.Sunday
                message = "Have a nice weekend!"
        End Select
        MessageBox.Show(message, "Case Statement", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
    End Sub
End Class
