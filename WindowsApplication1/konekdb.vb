Imports MySql.Data.MySqlClient
Module konekdb
    Public cn As MySqlConnection
    Public cmd As MySqlCommand
    Public da As MySqlDataAdapter
    Public dr As MySqlDataReader
    Public tb As DataTable
    Public Sub koneksi()
        cn = New MySqlConnection("host='localhost';username='root';password=;database='rekammedis';Convert Zero Datetime='True'")
        cn.Open()
        MsgBox("Berhasil Terkoneksi !")

    End Sub
End Module
