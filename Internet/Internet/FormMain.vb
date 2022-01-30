Public Class FormMain

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataDataSet.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.DataDataSet.Clientes)

    End Sub

    Private Sub BtnCliente_Click(sender As Object, e As EventArgs) Handles BtnCliente.Click
        Dim cl As New Clientes
        ConvertFormToChild(cl)
    End Sub

    'Método que convierte un Formulario en un panel hijo para mostrar en un panel contenedor
    Private Sub ConvertFormToChild(panelHijo As Form)
        If (PanelCotainer.Controls.Count > 0) Then
            PanelCotainer.Controls.RemoveAt(0)
        End If
        panelHijo.FormBorderStyle = False
        panelHijo.TopLevel = False
        panelHijo.Dock = DockStyle.Fill
        PanelCotainer.Controls.Add(panelHijo)
        panelHijo.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
