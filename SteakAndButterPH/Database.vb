Imports MySql.Data.MySqlClient

Module Database
    Public Connection As New MySqlConnection
    Public Command As New MySqlCommand
    Public Adapter As New MySqlDataAdapter
    Public Data As New DataSet
    Public NETable, CSTable, SLTable, PTable, STable, WTable, DTable, ETable, ELTable, ATable As New DataTable
    Sub OpenConnection()
        Connection.ConnectionString = "server=127.0.0.1;port=3306;username=root;password=;database=steak_and_butter_ph;Convert Zero Datetime=True;Persist Security Info=True"
        Connection.Open()
    End Sub

End Module

