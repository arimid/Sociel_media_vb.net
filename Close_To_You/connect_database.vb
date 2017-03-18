Imports MySql.Data.MySqlClient

Public Class connect_database
    Dim mysqlconnect As MySqlConnection
    Dim mysqlcmd As MySqlCommand

    Public Function get_data() As Boolean
        mysqlconnect = New MySqlConnection
        mysqlconnect.ConnectionString = "server=localhost;userid=root;password=aqwzsxedc;database=close;"
        Try
            mysqlconnect.Open()
            mysqlconnect.Close()
            mysqlconnect = Nothing
            Return True

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            mysqlconnect = Nothing
            mysqlcmd = Nothing
            Return False

        End Try

    End Function
End Class
