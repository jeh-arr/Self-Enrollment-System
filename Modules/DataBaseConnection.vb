Imports MySql.Data.MySqlClient
Module DataBaseConnection
    Public query As String
    Public command As New MySqlCommand
    Public connection As New MySqlConnection
    Public reader As MySqlDataReader
    Sub Connect()
        Try
            connection = New MySqlConnection("server=192.168.1.121; database=enrollmentsystem; username=admin; password=123456")
            connection.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Module
