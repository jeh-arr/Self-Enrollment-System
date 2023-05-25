Public Class StudentEnrollForm

    Dim SelectedCode As String
    Dim SelectedTitle As String
    Dim SelectedSlot As Integer
    Private Sub StudentEnrollForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MainPanel.BackColor = Color.FromArgb(150, 0, 0, 0)

        query = "SELECT * FROM subjsched"
        FillTable(query, dgvSubjectlist)
        dgvSubjectlist.ClearSelection()

    End Sub

    'search specific subject
    Private Sub ButtonSearch_Click(sender As Object, e As EventArgs) Handles ButtonSearch.Click

        Dim subj As String = TextBoxSearch.Text.ToUpper.Trim
        dgvSubjectlist.Rows.Clear()
        query = "SELECT * FROM subjsched WHERE code = '" + subj + "' OR title LIKE '%" + subj + "%'"
        FillTable(query, dgvSubjectlist)

    End Sub

    'show recommended subjects
    Private Sub ButtonRecommend_Click(sender As Object, e As EventArgs) Handles ButtonRecommend.Click
        dgvSubjectlist.Rows.Clear()
        query = ""
        FillTable(query, dgvSubjectlist)
    End Sub

    'show all subjects
    Private Sub ButtonShowAll_Click(sender As Object, e As EventArgs) Handles ButtonShowAll.Click
        dgvSubjectlist.Rows.Clear()
        query = "SELECT * FROM subjsched"
        FillTable(query, dgvSubjectlist)
    End Sub
    'add selected subject from dgvSubjectlist to dgvEnlisted
    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click



        If (SelectedCode Is Nothing) Then
            MsgBox("Please select a subject")
        ElseIf SelectedSlot >= 50 Then
            MsgBox("Selected subject is already full")
        ElseIf CheckTotal(TotalUnit, dgvEnlisted) >= 7 Then
            MsgBox("Exceeds total units allowed")
        ElseIf CheckGrade(SelectedTitle) Then
            MsgBox("Selected subject is already completed")
        ElseIf Not CheckReq(SelectedTitle, Label2) Then
            MsgBox("Prerequisite have not been met")
        ElseIf CheckDuplicate(SelectedTitle, dgvEnlisted) Then
            MsgBox("Selected subject is already in Enlisted subject")


        Else
            query = "SELECT * FROM subjsched WHERE code = '" + SelectedCode + "'"
            FillTable(query, dgvEnlisted)
            CheckTotal(TotalUnit, dgvEnlisted)
        End If
        dgvSubjectlist.ClearSelection()
        dgvEnlisted.ClearSelection()
        SelectedCode = Nothing
        SelectedTitle = Nothing
        SelectedSlot = Nothing

    End Sub

    Private Sub dgvSubjectlist_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSubjectlist.CellContentClick
        Dim rowIndex As Integer = e.RowIndex

        If rowIndex >= 0 AndAlso rowIndex < dgvSubjectlist.Rows.Count Then
            Dim selectedRow As DataGridViewRow = dgvSubjectlist.Rows(rowIndex)

            SelectedCode = selectedRow.Cells("DataGridViewTextBoxColumn10").Value.ToString()
            SelectedTitle = selectedRow.Cells("DataGridViewTextBoxColumn11").Value.ToString()
            SelectedSlot = selectedRow.Cells("DataGridViewTextBoxColumn18").Value
        End If


    End Sub

    'remove selected subject in dgvEnlisted 
    Private Sub ButtonRemove_Click(sender As Object, e As EventArgs) Handles ButtonRemove.Click
        For Each row As DataGridViewRow In dgvEnlisted.SelectedRows
            dgvEnlisted.Rows.Remove(row)
        Next
        dgvEnlisted.ClearSelection()
        CheckTotal(TotalUnit, dgvEnlisted)
    End Sub

    'clear all subject in dgvEnlisted 
    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        dgvEnlisted.Rows.Clear()
        CheckTotal(TotalUnit, dgvEnlisted)
    End Sub

    'enroll all subject in dgvEnlisted 
    Private Sub ButtonEnroll_Click(sender As Object, e As EventArgs) Handles ButtonEnroll.Click

    End Sub
End Class