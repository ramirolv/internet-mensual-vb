Public Class NewClient

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (TextBoxDpi.Text = "" Or TextBoxNombre.Text = "" Or TextBoxTelefono.Text = "") Then
            MsgBox("Datos incompletos")
        Else
            Me.Close()
        End If
    End Sub

    Private Sub NewClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormMain.Enabled = False
    End Sub

    Private Sub NewClient_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        FormMain.Enabled = Enabled
    End Sub
End Class