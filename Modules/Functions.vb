Module Functions

    'fill subject list table
    Sub FillTable(qry As String, dgvlist As DataGridView)

        Connect()

        With command
            .CommandText = qry
            .Connection = connection
            reader = .ExecuteReader

        End With
        dgvlist.Rows.Clear()
        While reader.Read
            dgvlist.Rows.Add(reader(0), reader(1), reader(2), reader(3), reader(4) + "-" + reader(5), reader(7), reader(8), reader(9), reader(10))
        End While
    End Sub


End Module
