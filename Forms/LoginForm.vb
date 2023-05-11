Public Class LoginForm
    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub
    Dim id As String
    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        Connect()
        query = "SELECT * FROM student WHERE studentid=@studentid AND password=@password"
        With command
            .Connection = connection
            .CommandText = query
            With .Parameters
                .Clear()
                .AddWithValue("studentid", TextBoxIdNumber.Text.Trim)
                .AddWithValue("password", TextBoxPassword.Text.Trim)
            End With
            reader = .ExecuteReader
        End With
        If reader.Read Then
            id = TextBoxIdNumber.Text.Trim
            TextBoxIdNumber.Clear()
            TextBoxPassword.Clear()
            Me.Hide()
            Main.Show()
        Else
            TextBoxIdNumber.Clear()
            TextBoxPassword.Clear()
            MsgBox("Wrong Credentials Po")
            
        End If
    End Sub
End Class