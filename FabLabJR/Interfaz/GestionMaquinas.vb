'Form que muestra un datagridview con todas las maquinas y sus respectivos campos
Public Class GestionMaquinas
    'Variables para el paso de valores de la maquina de la tabla
    Dim id As Integer
    Dim modelo As String
    Dim tipo As Integer
    Dim precioHora As Double
    Dim fechaCompra As Date
    Dim telefonoSAT As String
    Dim descripcion As String
    Dim caracteristicas As String

    Private Sub GestionMaquinas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MaquinasDataGridView.DataSource = GestionarMaquina.ObtenerTablaGestionMaquina
    End Sub

    Private Sub BuscarMaquinaButton_Click(sender As Object, e As EventArgs) Handles BuscarMaquinaButton.Click
        'Condicion que comprueba si el buscador de maquinas esta vacio al hacer click en buscar
        If BuscadorTextbox.Text = "" Or BuscadorTextbox.Text Is Nothing Then
            MessageBox.Show("El modelo no puede estar vacio")
        Else
            MaquinasDataGridView.DataSource = GestionarMaquina.ObtenerTablaGestionMaquinaPorModelo(BuscadorTextbox.Text.Trim())
        End If

    End Sub

    'Implementacion del evento click en Nueva Maquina
    Private Sub NuevaMaquinaButton_Click(sender As Object, e As EventArgs) Handles NuevaMaquinaButton.Click
        Dim documento As FormTratarMaquina = New FormTratarMaquina
        documento.MdiParent = Me.MdiParent
        documento.Text = "Nueva Maquina"
        documento.QuienMeLLama("Insertar")
        documento.Show()
    End Sub

    'Implementacion del evento click en Consultar
    Private Sub ConsultarMaquinaButton_Click(sender As Object, e As EventArgs) Handles ConsultarMaquinaButton.Click
        Dim documento As FormTratarMaquina = New FormTratarMaquina
        documento.MdiParent = Me.MdiParent
        documento.Text = "Consultar Maquina"
        documento.QuienMeLLama("Consultar")

        ObtenerMaquinaDeTabla()

        documento.RecibirMaquina(id, modelo, precioHora, fechaCompra, telefonoSAT, tipo, descripcion, caracteristicas)
        documento.Show()
    End Sub

    'Implementacion del evento click en Editar
    Private Sub EditarMaquinaButton_Click(sender As Object, e As EventArgs) Handles EditarMaquinaButton.Click
        Dim documento As FormTratarMaquina = New FormTratarMaquina
        documento.MdiParent = Me.MdiParent
        documento.Text = "Actualizar Maquina"
        documento.QuienMeLLama("Actualizar")

        ObtenerMaquinaDeTabla()

        documento.RecibirMaquina(id, modelo, precioHora, fechaCompra, telefonoSAT, tipo, descripcion, caracteristicas)
        documento.Show()
    End Sub

    'Implementacion del evento click en Eliminar
    Private Sub EliminarMaquinaButton_Click(sender As Object, e As EventArgs) Handles EliminarMaquinaButton.Click
        id = Integer.Parse(MaquinasDataGridView.SelectedRows(0).Cells(0).Value.ToString)

        GestionarMaquina.EliminarMaquina(id)

        MessageBox.Show("La maquina se ha eliminado correctamente")

        MaquinasDataGridView.DataSource = GestionarMaquina.ObtenerTablaGestionMaquina()
    End Sub

    'Metodo para obtener los datos del datagridview para pasarselo a las funciones de consultar y editar maquina
    Private Sub ObtenerMaquinaDeTabla()
        id = Integer.Parse(MaquinasDataGridView.SelectedRows(0).Cells(0).Value.ToString)
        modelo = MaquinasDataGridView.SelectedRows(0).Cells(1).Value.ToString
        precioHora = Double.Parse(MaquinasDataGridView.SelectedRows(0).Cells(2).Value.ToString)
        fechaCompra = Date.Parse(MaquinasDataGridView.SelectedRows(0).Cells(3).Value.ToString)
        telefonoSAT = MaquinasDataGridView.SelectedRows(0).Cells(4).Value.ToString
        tipo = Integer.Parse(MaquinasDataGridView.SelectedRows(0).Cells(5).Value.ToString)
        descripcion = MaquinasDataGridView.SelectedRows(0).Cells(6).Value.ToString
        caracteristicas = MaquinasDataGridView.SelectedRows(0).Cells(7).Value.ToString
    End Sub

End Class