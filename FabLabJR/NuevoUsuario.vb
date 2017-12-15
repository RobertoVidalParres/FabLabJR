Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class NuevoUsuario

    Public conexion As SqlConnection
    Public comandoTipoUsuario As SqlCommand
    Public adaptadorMaquinas As SqlDataAdapter
    Dim tipoAccion As String
    Dim id As Integer
    Dim nombre As String
    Dim apellidos As String
    Dim fechaNacimiento As Date
    Dim telefono As String
    Dim email As String
    Dim direccionPostal As String
    Dim organizacion As String
    Dim tipo As String

    'Constructor que recibirá el tipo de accion a realizar que usara el load del formulario
    Sub New(tipoAccion As String)
        InitializeComponent()
        Me.tipoAccion = tipoAccion
    End Sub

    'Load que segun el tipo de accion realizara una cosa u otra
    Private Sub NuevoUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AñadirTipoUsuarioTextBox.Hide()
        AñadirTipoUsuarioButton.Hide()
        'Si recibe "consultar" rellenara todos los campos y los deshabilitara para que no puedan ser editados
        If tipoAccion = "Consultar" Then
            RellenarDatos()
            DeshabilitarControles()
        ElseIf tipoAccion = "Editar" Then
            RellenarDatos()
        Else

        End If
    End Sub

    'Te abre un dialogo para seleccionar una imagen
    Private Sub ExaminarButton_Click(sender As Object, e As EventArgs) Handles examinarButton.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            pictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
        Else
            MessageBox.Show("No has seleccionado ninguna imagen")
        End If
    End Sub

    'Al desplegar el comboBox apereceran los distintos tipos de usuario
    Private Sub TipoComboBox_DropDown(sender As Object, e As EventArgs) Handles tipoComboBox.DropDown
        Dim resultado As List(Of String)
        resultado = UsuariosDatos.ObtenerTiposDeUsuario()
        tipoComboBox.DataSource = resultado
        tipoComboBox.DisplayMember = "tipo"
    End Sub

    'Boton para añadir un tipo de usuario nuevo que te mostrara dos nuevos controles
    Private Sub AñadirPictureBox_Click(sender As Object, e As EventArgs) Handles AñadirPictureBox.Click
        AñadirTipoUsuarioTextBox.Show()
        AñadirTipoUsuarioButton.Show()
    End Sub

    'Este metodo en caso de que el tipo de accion sea consultar o editar rellenara todos los campos
    Private Sub RellenarDatos()
        nombreTextBox.Text = nombre
        apellidosTextBox.Text = apellidos
        FechaNacimientoDateTimePicker.Value = fechaNacimiento
        telefonoTextBox.Text = telefono
        emailTexBox.Text = email
        direccionpostalTextBox.Text = direccionPostal
        organizacionTextBox.Text = organizacion
        tipoComboBox.SelectedValue = tipo
    End Sub

    'Deshabilita todos los campos, cosa que necesitaremos a la hora de consultar los datos del usuario
    Private Sub DeshabilitarControles()
        nombreTextBox.Enabled = False
        apellidosTextBox.Enabled = False
        FechaNacimientoDateTimePicker.Enabled = False
        telefonoTextBox.Enabled = False
        emailTexBox.Enabled = False
        direccionpostalTextBox.Enabled = False
        organizacionTextBox.Enabled = False
        tipoComboBox.Enabled = False
    End Sub

    'Este control que solo se muestra si le damos al icono de "+" nos permitira añadir en la base de datos un nuevo tipo de usuario
    Private Sub AñadirTipoUsuarioButton_Click(sender As Object, e As EventArgs) Handles AñadirTipoUsuarioButton.Click
        UsuariosDatos.InsertarTipoUsuario(AñadirTipoUsuarioTextBox.Text)
        MessageBox.Show("Nuevo tipo de usuario registrado con éxito")
    End Sub

    'Boton que permite insertar un nuevo registro de usuario o edicion a nuestra base de datos.
    Private Sub aceptarButton_Click(sender As Object, e As EventArgs) Handles aceptarButton.Click
        If telefonoTextBox.Text.Equals("") And emailTexBox.Text.Equals("") Then
            MessageBox.Show("Debes aportar almenos una forma de contacto")
        Else
            UsuariosDatos.InsertarUsuario(nombreTextBox.Text, apellidosTextBox.Text, FechaNacimientoDateTimePicker.Value, telefonoTextBox.Text, emailTexBox.Text, direccionpostalTextBox.Text, organizacionTextBox.Text, tipoComboBox.SelectedIndex + 1)
            MessageBox.Show("Nuevo usuario registrado con éxito")
        End If
    End Sub

    'Controla que el formato del correo electronico sea el correcto
    Private Sub emailTexBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles emailTexBox.Validating
        Dim rgx As New Regex("\w*\d*@\w.\w$")
        If rgx.IsMatch(emailTexBox.Text) Then
            EmailErrorProvider.SetError(emailTexBox, "")
        Else
            EmailErrorProvider.SetError(emailTexBox, "Formato incorrecto")
        End If
    End Sub

    'Este metodo nos permite recoger los datos del usuario seleccionado en el dataGridView del formulario de gestion de maquinas para trabajor con ellos aqui
    Public Sub RecibirUsuario(id As Integer, nombre As String, apellidos As String, fechaNacimiento As Date, telefono As String, email As String, direccionPostal As String, organizacion As String, tipo As String)
        Me.id = id
        Me.nombre = nombre
        Me.apellidos = apellidos
        Me.fechaNacimiento = fechaNacimiento
        Me.telefono = telefono
        Me.email = email
        Me.direccionPostal = direccionPostal
        Me.organizacion = organizacion
        Me.tipo = tipo
    End Sub
End Class