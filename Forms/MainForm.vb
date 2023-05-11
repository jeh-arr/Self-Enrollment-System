Public Class Main
    Private Sub ButtonInfo_Click(sender As Object, e As EventArgs) Handles ButtonInfo.Click
        Me.Hide()
        StudentInfoForm.Show()

    End Sub

    Private Sub ButtonLogout_Click(sender As Object, e As EventArgs) Handles ButtonLogout.Click
        Me.Hide()
        LoginForm.Show()
    End Sub
End Class
