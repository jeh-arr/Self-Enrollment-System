Public Class StudentEnrollForm

    Private Sub StudentEnrollForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MainPanel.BackColor = Color.FromArgb(150, 0, 0, 0)

        query = "SELECT * FROM subjsched"
        FillTable(query, dgvSubjectlist)

    End Sub
    'search specific subject
    Private Sub ButtonSearch_Click(sender As Object, e As EventArgs) Handles ButtonSearch.Click

        Dim subj As String = TextBoxSearch.Text.ToUpper.Trim
        query = "SELECT * FROM subjsched WHERE code = '" + subj + "' OR title LIKE '%" + subj + "%'"
        FillTable(query, dgvSubjectlist)

    End Sub

    'show recommended subjects
    Private Sub ButtonRecommend_Click(sender As Object, e As EventArgs) Handles ButtonRecommend.Click
        query = ""
        FillTable(query, dgvSubjectlist)
    End Sub
    'show all subjects
    Private Sub ButtonShowAll_Click(sender As Object, e As EventArgs) Handles ButtonShowAll.Click
        query = "SELECT * FROM subjsched"
        FillTable(query, dgvSubjectlist)
    End Sub
End Class