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
    Function CheckReq(Reqsubject As String, TextBoxSearch As Label) As Boolean
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
                    TextBoxSearch.Text = reader(3)
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

End Module
