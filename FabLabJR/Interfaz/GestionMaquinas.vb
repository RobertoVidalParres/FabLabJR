Public Class GestionMaquinas
    Private Sub GestionMaquinas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MaquinasDataGridView.DataSource = MaquinasDatos.ObtenerMaquinas()
    End Sub

    Private Sub MaquinasDataGridView_SelectionChanged(sender As Object, e As EventArgs) Handles MaquinasDataGridView.SelectionChanged
        MaquinasDataGridView.Rows.Item
    End Sub
End Class