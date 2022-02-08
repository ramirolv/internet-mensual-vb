Public Class ClassConecctionDB
    Public Conexion As OleDb.OleDbConnection
    Public Sub AbrirConexion()
        Conexion = New OleDb.OleDbConnection
        Conexion.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=./data.accdb"
        Conexion.Open()
    End Sub
    Public Function obtenerTabla(table As String)
        AbrirConexion()
        Dim dataTable As New OleDb.OleDbDataAdapter("SELECT * FROM " & table, Conexion)
        Dim dataSet As New DataSet
        dataTable.Fill(dataSet)
        If dataSet.Tables(0).Rows.Count > 0 Then
            Return dataSet.Tables(0)
        Else
            Return Nothing
        End If
        Conexion.Close()
    End Function
End Class
