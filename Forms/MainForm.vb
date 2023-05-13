Public Class Main
    Private Sub ButtonInfo_Click(sender As Object, e As EventArgs) Handles ButtonInfo.Click
        StudentInfoForm.Show()
        Me.Close()


    End Sub

    Private Sub ButtonLogout_Click(sender As Object, e As EventArgs) Handles ButtonLogout.Click
        LoginForm.Show()
        Me.Close()

    End Sub

    Private Sub main(sender As Object, e As EventArgs) Handles MyBase.Load

        TableLayoutPanel3.BackColor = Color.FromArgb(200, 255, 255, 255)

    End Sub
End Class
