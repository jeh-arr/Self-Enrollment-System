Public Class Main


    Private Sub ButtonInfo_Click(sender As Object, e As EventArgs) Handles ButtonInfo.Click
        StudentInfoForm.Show()
        Me.Close()


    End Sub
    Private Sub ButtonGrades_Click(sender As Object, e As EventArgs) Handles ButtonGrades.Click
        StudentGradesForm.Show()
    End Sub
    Private Sub ButtonEnroll_Click(sender As Object, e As EventArgs) Handles ButtonEnroll.Click

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



    End Sub


End Class
