Public Class PanelServicios
    Dim conexionDB As ClassConecctionDB

    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexionDB = New ClassConecctionDB
        DataGridViewClients.DataSource = conexionDB.obtenerTabla("Servicios")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnNewReg.Click
        Dim nuevoCliente As New NewClient
        nuevoCliente.Show()
    End Sub

    Private Sub BtnDeleteReg_Click(sender As Object, e As EventArgs) Handles BtnDeleteReg.Click
        Dim NumeroDeFilaSeleccionada As Integer

        If DataGridViewClients.SelectedRows.Count > 0 Then
            NumeroDeFilaSeleccionada = DataGridViewClients.CurrentRow.Index
        Else
            MessageBox.Show("Seleccione una fila")
        End If
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click

    End Sub
End Class