Imports System.Threading
Public Class LoginForm







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


            GlobalData.StudentID = TextBoxIdNumber.Text.Trim
            GlobalData.Enrolled = CInt(reader(3))
            TextBoxIdNumber.Clear()
            TextBoxPassword.Clear()
            Main.Show()
            Me.Hide()

        Else
            TextBoxIdNumber.Clear()
            TextBoxPassword.Clear()
            MsgBox("Wrong Credentials")

        End If
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles Me.Load

        Timer1.Start()


    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        PanelBackGround.BackgroundImage = My.Resources.Resources.login_bg1
        Timer1.Stop()
        Timer1.Start()
    End Sub
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        PanelBackGround.BackgroundImage = My.Resources.Resources.login_bg2
        Timer1.Stop()
        Timer1.Start()
    End Sub
    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        PanelBackGround.BackgroundImage = My.Resources.Resources.login_bg3
        Timer1.Stop()
        Timer1.Start()
    End Sub
    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        PanelBackGround.BackgroundImage = My.Resources.Resources.login_bg4
        Timer1.Stop()
        Timer1.Start()
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        PanelBackGround.BackgroundImage = My.Resources.Resources.login_bg5
        Timer1.Stop()
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If RadioButton1.Checked Then
            RadioButton2.Checked = True
        ElseIf RadioButton2.Checked Then
            RadioButton3.Checked = True
        ElseIf RadioButton3.Checked Then
            RadioButton4.Checked = True
        ElseIf RadioButton4.Checked Then
            RadioButton5.Checked = True
        ElseIf RadioButton5.Checked Then
            RadioButton1.Checked = True
        End If
    End Sub
End Class