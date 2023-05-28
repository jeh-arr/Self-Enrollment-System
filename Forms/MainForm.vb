Public Class Main


    Private Sub ButtonInfo_Click(sender As Object, e As EventArgs) Handles ButtonInfo.Click
        StudentInfoForm.Show()
        Me.Close()
    End Sub
    Private Sub ButtonGrades_Click(sender As Object, e As EventArgs) Handles ButtonGrades.Click
        StudentGradesForm.Show()
        Me.Close()
    End Sub
    Private Sub ButtonEnroll_Click(sender As Object, e As EventArgs) Handles ButtonEnroll.Click
        If GlobalData.Enrolled = 1 Then
            StudentScheduleForm.Show()
        Else
            StudentEnrollForm.Show()
        End If

        Me.Close()
    End Sub
    Private Sub ButtonForm1_Click(sender As Object, e As EventArgs)
        StudentScheduleForm.Show()
        Me.Close()
    End Sub
    Private Sub ButtonLogout_Click(sender As Object, e As EventArgs) Handles ButtonLogout.Click
        LoginForm.Show()
        Me.Close()

    End Sub

    Private Sub main(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelIdNumber.Text = GlobalData.StudentID


        TableLayoutPanel3.BackColor = Color.FromArgb(200, 255, 255, 255)
        Connect()
        query = "SELECT CONCAT(Lastname,', ',Firstname) as full_name from stdinfo where ID = @studentid"

        With command
            .Connection = connection
            .CommandText = query
            With .Parameters
                .Clear()
                .AddWithValue("studentid", GlobalData.StudentID)

            End With
            reader = .ExecuteReader
            If reader.Read Then
                LabelFullName.Text = reader.GetString("full_name")
            End If
        End With

        If GlobalData.Enrolled = 1 Then
            ButtonEnroll.Image = My.Resources.Resources.form1iconlarge
            Label3.Text = "Form 1"
        End If

    End Sub


End Class
