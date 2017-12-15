Public Class FormGestionUsuarios
    'Metodo para que cuando carge el formulario aparezca la tabla rellena con los usuarios de la base de datos
    Private Sub FormGestionUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TablaGestionUsuarioDataGridView.DataSource = UsuariosDatos.ObtenerTablaGestionUsuario()
    End Sub

    'Metodo para cargar la base de datos con la busqueda por nombre
    Private Sub BuscarGestionUsuarioButton_Click(sender As Object, e As EventArgs) Handles BuscarGestionUsuarioButton.Click
        TablaGestionUsuarioDataGridView.DataSource = UsuariosDatos.ObtenerTablaGestionUsuarioPorNombre(BuscadorGestionUsuarioTextBox.Text.Trim())
    End Sub

    Private Sub ConsultaGestionUsuarioButton_Click(sender As Object, e As EventArgs) Handles ConsultaGestionUsuarioButton.Click
    End Sub
End Class