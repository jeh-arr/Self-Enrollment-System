Public Class StudentScheduleForm


    Dim SelectedCode As String
    Private Sub ButtonBack_Click(sender As Object, e As EventArgs) Handles ButtonBack.Click
        Main.Show()
        Me.Close()
    End Sub

    Private Sub StudentSchedulForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MainPanel.BackColor = Color.FromArgb(150, 0, 0, 0)

        Connect()

        query = "SELECT code, title, descript, term, timestart, timeend, day, room, unit FROM stdenroll, subjsched 
                WHERE subjsched.code = stdenroll.subjid AND stdenroll.stdid = '" + GlobalData.StudentID + "' GROUP BY code"
        With command
            .CommandText = query
            .Connection = connection
            reader = .ExecuteReader

        End With

        While reader.Read
            dgvSubjectlist.Rows.Add(reader(0), reader(1), reader(2), reader(3), reader(4) + "-" + reader(5), reader(6), reader(7), reader(8))
            'LabelUnit.Text = ": " + reader(9).ToString
            'LabelUnitFee.Text = ": " + reader(10).ToString
        End While
        connection.Close()
        Connect()
        query = "SELECT CONCAT(Lastname,', ',Firstname) as full_name, Year from stdinfo where ID = '" + GlobalData.StudentID + "'"
        With command
            .CommandText = query
            .Connection = connection
            reader = .ExecuteReader
        End With
        While reader.Read
            LabelName.Text = ": " + reader(0)
            LabelID.Text = ": " + GlobalData.StudentID
            LabelYear.Text = ": " + reader(1)
        End While
        connection.Close()
        Connect()
        query = "SELECT SUM(unit), COUNT(stdid) FROM stdenroll, subjsched WHERE subjsched.code = stdenroll.subjid And stdenroll.stdid = 100002"
        With command
            .CommandText = query
            .Connection = connection
            reader = .ExecuteReader
        End With
        While reader.Read
            LabelUnit.Text = ": " + reader(0).ToString
            LabelUnitFee.Text = ": " + (reader(0) * 545).ToString
            LabelTotal.Text = ": " + (reader(0) * 545 + 8761).ToString
        End While
        connection.Close()
    End Sub
    Private Sub dgvSubjectlist_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSubjectlist.CellContentClick
        Dim rowIndex As Integer = e.RowIndex

        If rowIndex >= 0 AndAlso rowIndex < dgvSubjectlist.Rows.Count Then
            Dim selectedRow As DataGridViewRow = dgvSubjectlist.Rows(rowIndex)

            SelectedCode = selectedRow.Cells("DataGridViewTextBoxColumn10").Value.ToString()


        End If


    End Sub


    Private Sub ButtonRemove_Click(sender As Object, e As EventArgs) Handles ButtonRemove.Click
        'If (SelectedCode Is Nothing) Then
        '    MsgBox("Please select a subject")
        'Else

        '    Drop(SelectedCode)
        '    MsgBox("Drop request is sent to the Admin")
        'End If

        If (SelectedCode Is Nothing) Then
            MsgBox("Please select a subject")
        Else
            Dim result As DialogResult = MessageBox.Show("Are you sure to removed selected subject?", "Confirm Drop?", MessageBoxButtons.YesNo)

            If (result = DialogResult.Yes) Then

                Drop(SelectedCode)
                MsgBox("Drop request is sent to the Admin")
            Else

            End If

        End If
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click

        StudentEnrollForm.Show()
        Me.Close()
    End Sub
End Class