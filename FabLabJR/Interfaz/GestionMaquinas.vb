Public Class GestionMaquinas
    Private Sub GestionMaquinas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MaquinasDataGridView.DataSource = GestionarMaquina.ObtenerTablaGestionMaquina
    End Sub

    Private Sub BuscarMaquinaButton_Click(sender As Object, e As EventArgs) Handles BuscarMaquinaButton.Click
        MaquinasDataGridView.DataSource = GestionarMaquina.ObtenerTablaGestionMaquinaPorModelo(BuscadorTextbox.Text.Trim())
    End Sub
End Class