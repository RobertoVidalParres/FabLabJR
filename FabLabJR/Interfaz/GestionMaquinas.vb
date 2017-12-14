Public Class GestionMaquinas
    Private Sub GestionMaquinas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MaquinasDataGridView.DataSource = GestionarMaquina.ObtenerTablaGestionMaquina
    End Sub

    Private Sub BuscadorTextbox_TextChanged(sender As Object, e As EventArgs) Handles BuscadorTextbox.TextChanged
        MaquinasDataGridView.DataSource = GestionarMaquina.ObtenerTablaGestionMaquinaPorModelo("Roland")
    End Sub
End Class