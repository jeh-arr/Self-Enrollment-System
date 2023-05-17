Public Class StudentInfoForm
    Private Sub ButtonBack_Click(sender As Object, e As EventArgs) Handles ButtonBack.Click
        Me.Hide()
        Main.Show()


    End Sub
    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click
        'Contact details
        TextBoxPhone.Enabled = True
        TextBoxEmail.Enabled = True
        TextBoxAddress.Enabled = True
        'Emergency Contact
        TextBoxEname.Enabled = True
        TextBoxErelation.Enabled = True
        TextBoxEcontact.Enabled = True
        TextBoxEaddress.Enabled = True

        ButtonEdit.Hide()
        ButtonConfirm.Show()


    End Sub

    Private Sub ButtonConfirm_Click(sender As Object, e As EventArgs) Handles ButtonConfirm.Click

        MsgBox("Contact Details Update Request Sent to Administrator.")
        TextBoxPhone.Enabled = False
        TextBoxEmail.Enabled = False
        TextBoxAddress.Enabled = False
        'Emergency Contact
        TextBoxEname.Enabled = False
        TextBoxErelation.Enabled = False
        TextBoxEcontact.Enabled = False
        TextBoxEaddress.Enabled = False

        



        StudentInfoForm_Load(sender, e)
    End Sub
    Private Sub StudentInfoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MainPanel.BackColor = Color.FromArgb(150, 0, 0, 0)
        ButtonEdit.Show()
        ButtonConfirm.Hide()
        Connect()

        query = "SELECT * FROM stdinfo where ID = @studentid"

        With command
            .Connection = connection
            .CommandText = query
            With .Parameters
                .Clear()
                .AddWithValue("studentid", GlobalData.StudentID)

            End With
            reader = .ExecuteReader
            If reader.Read Then

                'Basic info
                TextBoxFname.Text = reader(1)
                TextMname.Text = reader(2)
                TextBoxLname.Text = reader(3)
                TextBoxSex.Text = reader(4)
                TextBoxBirth.Text = reader(5)
                'Course info
                TextBoxID.Text = reader(0)
                TextBoxCollege.Text = reader(6)
                TextBoxProgram.Text = reader(7)
                TextBoxYear.Text = reader(8)
                TextBoxBranch.Text = reader(9)
                'Contact details
                TextBoxPhone.Text = reader(10)
                TextBoxEmail.Text = reader(11)
                TextBoxAddress.Text = reader(12)
                'Emergency Contact
                TextBoxEname.Text = reader(13)
                TextBoxErelation.Text = reader(14)
                TextBoxEcontact.Text = reader(15)
                TextBoxEaddress.Text = reader(16)
            End If
        End With
    End Sub


End Class