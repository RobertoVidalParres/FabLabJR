Public Class FormTratarMaquina
    Dim id As Integer
    Dim modelo As String
    Dim precioHora As Double
    Dim fechaCompra As Date
    Dim telefonoSAT As String
    Dim tipo As Integer
    Dim descripcion As String
    Dim caracteristicas As String
    Dim meLLama As String

    Private Sub FormTratarMaquina_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (meLLama = "Consultar") Then
            RellenarDatos()
            DeshabilitarControles()
        ElseIf (meLLama = "Actualizar") Then
            RellenarDatos()
        End If
    End Sub

    Public Sub QuienMeLLama(texto As String)
        meLLama = texto
    End Sub

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

    Private Sub RellenarDatos()
        CaracteristicasMaquinaTextBox.Text = caracteristicas
        DescripcionMaquinaTextBox.Text = descripcion
        FechaCompraMaquinaDateTimePicker.Text = fechaCompra.ToString
        TipoMaquinaComboBox.Text = tipo.ToString
        PrecioHoraMaquinaTextBox.Text = precioHora.ToString
        TelefonoSatMaquinaMaskedTextBox.Text = telefonoSAT
        ModeloMaquinaTextBox.Text = modelo
    End Sub

    Private Sub RecolectarDatos()
        caracteristicas = CaracteristicasMaquinaTextBox.Text.Trim()
        descripcion = DescripcionMaquinaTextBox.Text
        fechaCompra = Date.Parse(FechaCompraMaquinaDateTimePicker.Text.Trim())
        tipo = Integer.Parse(TipoMaquinaComboBox.Text.Trim())
        precioHora = Double.Parse(PrecioHoraMaquinaTextBox.Text.Trim())
        telefonoSAT = TelefonoSatMaquinaMaskedTextBox.Text.Trim()
        modelo = ModeloMaquinaTextBox.Text.Trim()
    End Sub

    Private Sub CancelarMaquinaButton_Click(sender As Object, e As EventArgs) Handles CancelarMaquinaButton.Click
        Me.Close()
    End Sub

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
End Class