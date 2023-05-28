Imports System.Text.RegularExpressions

Module Functions





    'fill subject list table
    Sub SetEnrolled()
        Connect()

        With command
            .CommandText = "UPDATE `student` SET `enrolled`=@enrolled WHERE studentid = @id"
            .Connection = connection


            .Parameters.Clear()
            .Parameters.AddWithValue("id", GlobalData.StudentID)
            .Parameters.AddWithValue("enrolled", 1)

            .ExecuteNonQuery()


        End With
        GlobalData.Enrolled = 1

        connection.Close()
    End Sub
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
        connection.Close()
    End Sub


    '"Select code, title, descript, term, timestart, timeend, day, room, unit FROM stdenroll, subjsched WHERE subjsched.code = stdenroll.subjid And stdenroll.stdid = '"+user+"'";
    Sub FillTableGrade(sbj As List(Of String), dgvlist As DataGridView)


        Connect()
        With command
            .CommandText = "SELECT subject.title AS Title,
                            
                            CASE subject.title
                            WHEN @Subject1 THEN stdgrade.GE1
                            WHEN @Subject2 THEN stdgrade.GE2
                            WHEN @Subject3 THEN stdgrade.GE3
                            WHEN @Subject4 THEN stdgrade.GE4
                            WHEN @Subject5 THEN stdgrade.GE5
                            WHEN @Subject6 THEN stdgrade.GE6
                            WHEN @Subject7 THEN stdgrade.GE7
                            WHEN @Subject8 THEN stdgrade.GE8
                            WHEN @Subject9 THEN stdgrade.GE9
                            END AS Grade,
                            subject.units AS Unit,
                            subject.description AS Description
                            FROM stdgrade
                            JOIN
                            subject ON subject.title IN 
                            (@Subject1, @Subject2, @Subject3,@Subject4, @Subject5, @Subject6, @Subject7, @Subject8, @Subject9)
                            WHERE
                            stdgrade.gradeid = '" + GlobalData.StudentID + "'" 

            .Connection = connection
            With .Parameters
                .Clear()
                .AddWithValue("Subject1", sbj(0))
                .AddWithValue("Subject2", sbj(1))
                .AddWithValue("Subject3", sbj(2))
                .AddWithValue("Subject4", sbj(3))
                .AddWithValue("Subject5", sbj(4))
                .AddWithValue("Subject6", sbj(5))
                .AddWithValue("Subject7", sbj(6))
                .AddWithValue("Subject8", sbj(7))
                .AddWithValue("Subject9", sbj(8))
            End With
            reader = .ExecuteReader
        End With
        While reader.Read
            dgvlist.Rows.Add(reader(1), reader(0), reader(2), reader(3))
        End While
        connection.Close()
    End Sub

    Sub ShowRecommended(dgvlist As DataGridView)
        Connect()
        Dim titlelist As List(Of String) = New List(Of String)

        With command
            .CommandText = "SELECT title FROM subjsched GROUP BY title"
            .Connection = connection
            reader = .ExecuteReader
        End With

        While reader.Read
            titlelist.Add(reader(0))
        End While

        For Each j In titlelist
            If CheckReq(j) Then
                query = "SELECT * FROM subjsched WHERE title = '" + j + "'"
                FillTable(query, dgvlist)
            End If
        Next j
        connection.Close()

    End Sub
    'enroll all enlisted subject
    Sub Enroll(dgvlist As DataGridView)
        Dim EnrollList As List(Of String) = New List(Of String)()
        Dim subject As Integer

        Connect()

        With command
            .CommandText = "INSERT INTO stdenroll (stdid,subjid) VALUES (@id, @subject )"
            .Connection = connection

            For Each row As DataGridViewRow In dgvlist.Rows
                subject = CInt(row.Cells(0).Value)
                If Not subject = 0 Then
                    .Parameters.Clear()
                    .Parameters.AddWithValue("id", GlobalData.StudentID)
                    .Parameters.AddWithValue("subject", subject)

                    .ExecuteNonQuery()
                End If
            Next

        End With

        connection.Close()

    End Sub
    Sub Drop(code As String)
        Connect()

        With command
            .CommandText = "INSERT INTO stdsubdrop (ID,Code) VALUES (@id, @code )"
            .Connection = connection


            .Parameters.Clear()
            .Parameters.AddWithValue("id", GlobalData.StudentID)
            .Parameters.AddWithValue("code", code)

            .ExecuteNonQuery()


        End With

        connection.Close()
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
            If reader(3) Is "" Or Nothing Then
                connection.Close()
                Return False

            ElseIf reader(3) IsNot "" Then
                grade = reader(3)
                If CheckGrade(grade) Then
                    connection.Close()
                    Return True

                Else
                    connection.Close()
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
        connection.Close()
    End Function
    Function CheckDuplicate(title As String, dgvlist As DataGridView) As Boolean


        For Each row As DataGridViewRow In dgvlist.Rows




            If row.Cells.Item(1).Value Is title Then
                connection.Close()
                Return True

            Else
                connection.Close()
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
        connection.Close()
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
        connection.Close()
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
                If SchedA.termA = SchedB.termB Then
                    If SchedA.periodA = SchedB.periodB Then
                        Return True
                    ElseIf SchedA.termA = "SEM" Or SchedB.termB = "SEM" Then
                        Return True
                        Exit For
                    End If
                End If
            Else
                Return False
            End If




        Next

    End Function




End Module
