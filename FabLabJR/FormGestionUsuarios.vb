Public Class FormGestionUsuarios
    Dim id As Integer
    Dim nombre As String
    Dim apellidos As String
    Dim fechaNacimiento As Date
    Dim telefono As String
    Dim email As String
    Dim direccionPostal As String
    Dim organizacion As String
    Dim tipo As String

    'Metodo para que cuando carge el formulario aparezca la tabla rellena con los usuarios de la base de datos
    Private Sub FormGestionUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TablaGestionUsuarioDataGridView.DataSource = UsuariosDatos.ObtenerTablaGestionUsuario()
    End Sub

    'Metodo para cargar la base de datos con la busqueda por nombre
    Private Sub BuscarGestionUsuarioButton_Click(sender As Object, e As EventArgs) Handles BuscarGestionUsuarioButton.Click
        TablaGestionUsuarioDataGridView.DataSource = UsuariosDatos.ObtenerTablaGestionUsuarioPorNombre(BuscadorGestionUsuarioTextBox.Text.Trim())
    End Sub

    'Implementacion del evento click en Consultar
    Private Sub ConsultaGestionUsuarioButton_Click(sender As Object, e As EventArgs) Handles ConsultaGestionUsuarioButton.Click
        Dim formNuevoUsuario As New NuevoUsuario("Consultar")
        formNuevoUsuario.MdiParent = Me.MdiParent
        formNuevoUsuario.Text = "Consultar Usuario"

        ObtenerUsuarioDeTabla()

        formNuevoUsuario.RecibirUsuario(id, nombre, apellidos, fechaNacimiento, telefono, email, direccionPostal, organizacion, tipo)
        formNuevoUsuario.Show()
    End Sub

    'Metodo para obtener los datos del datagridview para pasarselo a las funciones de consultar y editar maquina
    Private Sub ObtenerUsuarioDeTabla()
        id = Integer.Parse(TablaGestionUsuarioDataGridView.SelectedRows(0).Cells(0).Value.ToString)
        nombre = TablaGestionUsuarioDataGridView.SelectedRows(0).Cells(1).Value.ToString
        apellidos = TablaGestionUsuarioDataGridView.SelectedRows(0).Cells(2).Value.ToString
        fechaNacimiento = Date.Parse(TablaGestionUsuarioDataGridView.SelectedRows(0).Cells(3).Value.ToString)
        telefono = TablaGestionUsuarioDataGridView.SelectedRows(0).Cells(4).Value.ToString
        email = TablaGestionUsuarioDataGridView.SelectedRows(0).Cells(5).Value.ToString
        direccionPostal = TablaGestionUsuarioDataGridView.SelectedRows(0).Cells(6).Value.ToString
        organizacion = TablaGestionUsuarioDataGridView.SelectedRows(0).Cells(7).Value.ToString
        tipo = TablaGestionUsuarioDataGridView.SelectedRows(0).Cells(8).Value.ToString
    End Sub

    'Implementacion del evento click en Editar
    Private Sub EditarGestionUsuarioButton_Click(sender As Object, e As EventArgs) Handles EditarGestionUsuarioButton.Click
        Dim formNuevoUsuario As New NuevoUsuario("Editar")
        formNuevoUsuario.MdiParent = Me.MdiParent
        formNuevoUsuario.Text = "Editar Usuario"

        ObtenerUsuarioDeTabla()

        formNuevoUsuario.RecibirUsuario(id, nombre, apellidos, fechaNacimiento, telefono, email, direccionPostal, organizacion, tipo)
        formNuevoUsuario.Show()
    End Sub

    'Implementacion del evento click en Eliminar
    Private Sub EliminarGestionUsuarioButton_Click(sender As Object, e As EventArgs) Handles EliminarGestionUsuarioButton.Click
        id = Integer.Parse(TablaGestionUsuarioDataGridView.SelectedRows(0).Cells(0).Value.ToString)

        UsuariosDatos.EliminarUsuarioPorId(id)

        MessageBox.Show("El usuario se ha eliminado correctamente")

        TablaGestionUsuarioDataGridView.DataSource = UsuariosDatos.ObtenerTablaGestionUsuario
    End Sub

    'Implementacion del evento click en Nueva Maquina
    Private Sub NuevoUsuarioGestionUsuarioButton_Click(sender As Object, e As EventArgs) Handles NuevoUsuarioGestionUsuarioButton.Click
        Dim formNuevoUsuario As New NuevoUsuario("Nuevo")
        formNuevoUsuario.MdiParent = Me.MdiParent
        formNuevoUsuario.Text = "Nuevo Usuario"
        formNuevoUsuario.Show()
    End Sub
End Class