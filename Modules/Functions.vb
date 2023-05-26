Imports System.Text.RegularExpressions

Module Functions

    'fill subject list table
    Sub FillTable(qry As String, dgvlist As DataGridView)
        Connect()
        With command
            .CommandText = qry
            .Connection = connection
            reader = .ExecuteReader
        End With
        While reader.Read
            dgvlist.Rows.Add(reader(0), reader(1), reader(2), reader(3), reader(4) + "-" + reader(5), reader(7), reader(8), reader(9), reader(10))
        End While
    End Sub

    'checks requisite subject if passed
    Function CheckReq(Reqsubject As String) As Boolean
        Connect()
        Dim grade As String
        query = "SELECT * FROM subject WHERE title = '" + Reqsubject + "'"
        With command
            .CommandText = query
            .Connection = connection
            reader = .ExecuteReader
        End With
        While reader.Read
            If reader(3) Is "" Then
                Return True

            ElseIf reader(3) IsNot "" Then
                grade = reader(3)
                If CheckGrade(grade) Then
                    Return True

                Else
                    Return False
                End If

            End If
        End While
    End Function
    'checks subjects grade if passed 
    Function CheckGrade(subject As String) As Boolean
        query = "SELECT * FROM stdgrade WHERE gradeid = '" + GlobalData.StudentID + "'"
        Connect()
        With command
            .CommandText = query
            .Connection = connection
            reader = .ExecuteReader
        End With
        While reader.Read
            If reader("" + subject + "") Is "" Then
                Return False
            ElseIf reader("" + subject + "") >= 1 And reader("" + subject + "") <= 3.5 Then
                Return True
            End If
        End While
    End Function
    Function CheckDuplicate(title As String, dgvlist As DataGridView) As Boolean
        For Each row As DataGridViewRow In dgvlist.Rows
            If row.Cells.Item("DataGridViewTextBoxColumn2").Value = title Then
                Return True
                Exit For
            Else
                Return False

            End If
        Next

    End Function

    'check and update total unit
    Function CheckTotal(labelsum As Label, dgvlist As DataGridView) As Decimal
        Dim sum As Decimal
        For i = 0 To dgvlist.Rows.Count - 1
            sum += dgvlist.Rows(i).Cells(7).Value
        Next
        labelsum.Text = "Total Units = " + sum.ToString
        Return sum
    End Function

    'get schedule of selected subject
    Public Function GetTimeA(codeA As String) As (timeStartA As Integer, timeEndA As Integer, periodA As String, termA As String)
        Dim timeStart, timeEnd As Integer
        Dim period, term As String
        Connect()
        With command
            .CommandText = "SELECT * FROM subjsched WHERE code = '" + codeA + "'"
            .Connection = connection
            reader = .ExecuteReader
        End With
        While reader.Read
            timeStart = Convert.ToInt32(Regex.Replace(reader(4), "[^\d]", ""))
            timeEnd = Convert.ToInt32(Regex.Replace(reader(5), "[^\d]", ""))
            period = reader(6).ToString
            term = reader(3).ToString
        End While

        Return (timeStart, timeEnd, period, term)
    End Function

    'get schedule of enlisted subject
    Public Function GetTimeB(codeB As String) As (timeStartB As Integer, timeEndB As Integer, periodB As String, termB As String)
        Dim timeStart, timeEnd As Integer
        Dim period, term As String
        Connect()
        With command
            .CommandText = "SELECT * FROM subjsched WHERE code = '" + codeB + "'"
            .Connection = connection
            reader = .ExecuteReader
        End With
        While reader.Read
            timeStart = Convert.ToInt32(Regex.Replace(reader(4), "[^\d]", ""))
            timeEnd = Convert.ToInt32(Regex.Replace(reader(5), "[^\d]", ""))
            period = reader(6).ToString
            term = reader(3).ToString
        End While

        Return (timeStart, timeEnd, period, term)
    End Function

    'compare schedule of selected subject to enlisted subject 
    Function CheckTime(codeA As String, dgvlist As DataGridView) As Boolean
        Dim SchedA = GetTimeA(codeA)
        'Dim SchedB
        Dim codeB As String

        For i = 0 To dgvlist.Rows.Count - 1

            codeB = dgvlist.Rows(i).Cells(0).Value
            If codeB Is Nothing Then
                Return False
            End If

            Dim SchedB = GetTimeB(codeB)
            If (SchedA.timeStartA <= SchedB.timeEndB) And (SchedA.timeEndA >= SchedB.timeStartB) Then
                If SchedA.periodA = SchedB.periodB Then
                    If SchedA.periodA = SchedB.periodB Then
                        If SchedA.termA = "SEM" Or SchedB.termB = "SEM" Then
                            Return True
                            Exit For
                        End If
                    End If


                End If
            Else
                Return False
            End If

        Next

    End Function

End Module
