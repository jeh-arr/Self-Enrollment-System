Public Class StudentGradesForm

    Private Sub StudentInfoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MainPanel.BackColor = Color.FromArgb(150, 0, 0, 0)

        Dim subject As List(Of String) = New List(Of String) From
        {"GE2", "GE1", "GE4", "CEE100", "BCHE111/L", "CPE111", "CPE112/L", "CPE113/L", "GPE1"}

        '1st year
        FillTableGrade(subject, dgv1st1st)
        subject.Clear()
        subject.AddRange({"UGE1", "GE5", "CEE101", "GEFIL1", "CPE121/L", "GE3", "GE6", "GPE2", ""})
        FillTableGrade(subject, dgv1st2)
        '2nd year
        subject.Clear()
        subject.AddRange({"CEE102/L", "CEE105", "CEE103", "CPE211/L", "GE8", "CPE122", "DRAW102/L", "GPE3", ""})
        FillTableGrade(subject, dgv21)
        subject.Clear()
        subject.AddRange({"CEE104", "BEE212/L", "CEE109", "GE9", "CPE223/L", "CEE112", "GE7", "GPE4", ""})
        FillTableGrade(subject, dgv22)
        subject.Clear()
        subject.AddRange({"CEE115", "BECE225", "", "", "", "", "", "", ""})
        FillTableGrade(subject, dgv2s)
        '3rd year
        subject.Clear()
        subject.AddRange({"CPE222", "CPE315", "CPE312", "CPE328", "NSTP1", "CPE317", "CPE224", "CPE313", ""})
        FillTableGrade(subject, dgv31)
        subject.Clear()
        subject.AddRange({"CPE326", "CPE421", "NSTP2", "CPE314", "CPE311", "CPE316", "CPE324", "CPE325", ""})
        FillTableGrade(subject, dgv32)
        subject.Clear()
        subject.AddRange({"GE15", "CPE333", "CPE329", "", "", "", "", "", ""})
        FillTableGrade(subject, dgv3s)
        '4th year
        subject.Clear()
        subject.AddRange({"GE11", "CPE412", "CPE415", "CPE413", "CPE417", "CPE414", "", "", ""})
        FillTableGrade(subject, dgv41)
        subject.Clear()
        subject.AddRange({"CAED500C", "CEE108", "CPE416", "GE20", "CPE422", "", "", "", ""})
        FillTableGrade(subject, dgv42)


    End Sub

    Private Sub ButtonBack_Click(sender As Object, e As EventArgs) Handles ButtonBack.Click
        Main.Show()
        Me.Close()
    End Sub
End Class