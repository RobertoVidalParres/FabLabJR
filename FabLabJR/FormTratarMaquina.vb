Public Class FormTratarMaquina
    'Parametros para recibir la maquina del Form GestionMaquina
    Dim id As Integer
    Dim modelo As String
    Dim precioHora As Double
    Dim fechaCompra As Date
    Dim telefonoSAT As String
    Dim tipo As Integer
    Dim descripcion As String
    Dim caracteristicas As String
    Dim meLLama As String

    'Metodo Load para realizar operacion cuando inicie el Form
    Private Sub FormTratarMaquina_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'If que segun desde que boton haya sido llamado el form ejercutar los diferentes metodos
        If (meLLama = "Consultar") Then
            RellenarDatos()
            DeshabilitarControles()
            'CargarImagenes()
        ElseIf (meLLama = "Insertar") Then
            Dim lista As List(Of String)
            lista = GestionarMaquina.ObtenerTiposDeMaquina()

            'For Each para llenar el ComboBox con los diferentes tipos de maquina que exista en la base de datos
            For Each item As String In lista
                TipoMaquinaComboBox.Items.Add(item)
            Next

        ElseIf (meLLama = "Actualizar") Then
            RellenarDatos()
        End If
    End Sub

    'Metodo para saber desde que boton ha sido llamado el Form
    Public Sub QuienMeLLama(texto As String)
        meLLama = texto
    End Sub

    'Metodo para recibir los datos de una maquina
    Public Sub RecibirMaquina(id As Integer, modelo As String, precioHora As Double, fechaCompra As Date, telefonoSAT As String, tipo As Integer, descripcion As String, caracteristicas As String)
        Me.id = id
        Me.modelo = modelo
        Me.precioHora = precioHora
        Me.fechaCompra = fechaCompra
        Me.telefonoSAT = telefonoSAT
        Me.tipo = tipo
        Me.descripcion = descripcion
        Me.caracteristicas = caracteristicas
    End Sub

    'Metodo que deshabilita los controles del Form en este caso para cuando se realiza la consulta de una maquina
    Private Sub DeshabilitarControles()
        ImagenesMaquinaFlowLayoutPanel.Enabled = False
        CaracteristicasMaquinaTextBox.Enabled = False
        DescripcionMaquinaTextBox.Enabled = False
        FechaCompraMaquinaDateTimePicker.Enabled = False
        TipoMaquinaComboBox.Enabled = False
        TipoMaquinaPictureBox.Enabled = False
        PrecioHoraMaquinaTextBox.Enabled = False
        TelefonoSatMaquinaMaskedTextBox.Enabled = False
        ModeloMaquinaTextBox.Enabled = False
    End Sub

    'Metodo que rellena los controles con los datos de la maquina que se va a Actualizar
    Private Sub RellenarDatos()
        CaracteristicasMaquinaTextBox.Text = caracteristicas
        DescripcionMaquinaTextBox.Text = descripcion
        FechaCompraMaquinaDateTimePicker.Text = fechaCompra.ToString
        TipoMaquinaComboBox.Text = tipo.ToString
        PrecioHoraMaquinaTextBox.Text = precioHora.ToString
        TelefonoSatMaquinaMaskedTextBox.Text = telefonoSAT
        ModeloMaquinaTextBox.Text = modelo
    End Sub

    'Metodo para recoger los datos de los controles para insertar una maquina
    Private Sub RecolectarDatos()
        caracteristicas = CaracteristicasMaquinaTextBox.Text.Trim()
        descripcion = DescripcionMaquinaTextBox.Text
        fechaCompra = Date.Parse(FechaCompraMaquinaDateTimePicker.Text.Trim())
        tipo = Integer.Parse(TipoMaquinaComboBox.Text.Trim())
        precioHora = Double.Parse(PrecioHoraMaquinaTextBox.Text.Trim())
        telefonoSAT = TelefonoSatMaquinaMaskedTextBox.Text.Trim()
        modelo = ModeloMaquinaTextBox.Text.Trim()
    End Sub

    'Metodo para cuando se hace click en cancelar
    Private Sub CancelarMaquinaButton_Click(sender As Object, e As EventArgs) Handles CancelarMaquinaButton.Click
        Me.Close()
    End Sub

    'Metodo para cuando se hace click en aceptar y segun el modo en el que estemos realizar las diferentes operaciones
    Private Sub AceptarMaquinaButton_Click(sender As Object, e As EventArgs) Handles AceptarMaquinaButton.Click
        If (meLLama = "Consultar") Then
            Me.Close()
        ElseIf (meLLama = "Insertar") Then
            RecolectarDatos()
            If (GestionarMaquina.ComprobarDatos(modelo, precioHora, fechaCompra, telefonoSAT, tipo, descripcion, caracteristicas)) Then
                GestionarMaquina.Insertar(modelo, precioHora, fechaCompra, telefonoSAT, tipo, descripcion, caracteristicas)
            End If
        ElseIf (meLLama = "Actualizar") Then
            If (GestionarMaquina.ComprobarDatos(modelo, precioHora, fechaCompra, telefonoSAT, tipo, descripcion, caracteristicas)) Then
                GestionarMaquina.ActualizarMaquina(id, modelo, precioHora, fechaCompra, telefonoSAT, tipo, descripcion, caracteristicas)
            End If
        End If
    End Sub

    'Metodo para añadir tipo de maquina a la base de datos
    Private Sub TipoMaquinaPictureBox_Click(sender As Object, e As EventArgs) Handles TipoMaquinaPictureBox.Click
        GestionarMaquina.AñadirTipoMaquina(TipoMaquinaComboBox.Text.Trim())
    End Sub

    'Metodo para añadir imagenes de maquinas
    Private Sub ExaminarImagenesMaquinaButton_Click(sender As Object, e As EventArgs) Handles ExaminarImagenesMaquinaButton.Click

        Dim pictureBox As New PictureBox

        If (OpenFileDialog1.ShowDialog() = DialogResult.OK) Then

            pictureBox.Image = Image.FromFile(OpenFileDialog1.FileName)
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom

            Me.ImagenesMaquinaFlowLayoutPanel.Controls.Add(pictureBox)

            FileCopy(OpenFileDialog1.FileName, My.Settings.rutaImagenesMaquinas)
            My.Computer.FileSystem.RenameFile(My.Settings.rutaImagenesMaquinas & OpenFileDialog1.FileName, ModeloMaquinaTextBox.Text.Trim() & FechaCompraMaquinaDateTimePicker.Text.Trim() & ".jpg")

        Else

            MessageBox.Show("No has seleccionado ninguna imagen")

        End If
    End Sub

    'Metodo para cargar las imagenes de las maquina al consultar
    Private Sub CargarImagenes()
        Dim imagenes As String() = System.IO.Directory.GetFiles(My.Settings.rutaImagenesMaquinas, ModeloMaquinaTextBox.Text.Trim() & FechaCompraMaquinaDateTimePicker.Text.Trim() & "*")

        If (Not IsNothing(imagenes)) Then
            For index = 0 To imagenes.Count - 1
                Dim picturebox As New PictureBox()
                picturebox.Height = 60
                picturebox.Width = 60
                picturebox.SizeMode = PictureBoxSizeMode.StretchImage
                Me.ImagenesMaquinaFlowLayoutPanel.Controls.Add(picturebox)
            Next
        End If
    End Sub
End Class