Imports System.Data.OleDb
Module Koneksi

    Public cn As OleDbConnection
    Public cmd As OleDbCommand
    Public ds As New DataSet
    Public rd As OleDbDataReader
    Public da As OleDbDataAdapter
    Public LokasiData As String

    Sub Connect()
        LokasiData = "provider=Microsoft.jet.oledb.4.0;data source=dbpenitipan.mdb"
        cn = New OleDbConnection(LokasiData)
        If cn.State = ConnectionState.Closed Then
            cn.Open()
        End If
    End Sub
End Module
