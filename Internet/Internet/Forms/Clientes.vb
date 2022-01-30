Public Class Clientes


    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataDataSet.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.DataDataSet.Clientes)
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
            MessageBox.Show("Selecciona una fila")
        End If
    End Sub
End Class