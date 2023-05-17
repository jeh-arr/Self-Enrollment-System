Public Class StudentGradesForm

    Private Sub StudentInfoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MainPanel.BackColor = Color.FromArgb(150, 0, 0, 0)
        'ButtonEdit.Show()
        'ButtonConfirm.Hide()
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


            End If
        End With
    End Sub


End Class