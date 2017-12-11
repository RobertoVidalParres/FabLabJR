Module GestionarMaquina
    Public Sub Insertar(modelo As String, precioHora As Double, fechaCompra As Date, telefonoSAT As String, tipo As Integer, descripcion As String, caracteristicas As String)
        Dim gateway As New Gateway_Maquina

        gateway.Insertar(modelo, precioHora, fechaCompra, telefonoSAT, tipo, descripcion, caracteristicas)
    End Sub

    Public Sub ActualizarMaquina(id As Integer, modelo As String, precioHora As Double, fechaCompra As Date, telefonoSAT As String, tipo As Integer, descripcion As String, caracteristicas As String)
        Dim gateway As New Gateway_Maquina

        gateway.ActualizarMaquina(id, modelo, precioHora, fechaCompra, telefonoSAT, tipo, descripcion, caracteristicas)
    End Sub

    Public Sub EliminarMaquina(id As Integer)
        Dim gateway As New Gateway_Maquina

        gateway.EliminarMaquina(id)
    End Sub

    Public Function ComprobarDatos(modelo As String, precioHora As Double, fechaCompra As Date, telefonoSAT As String, tipo As Integer, descripcion As String, caracteristicas As String) As Boolean
        Dim resultado As Boolean

        If (String.IsNullOrEmpty(modelo)) Then
            Throw New ArgumentException("El modelo no puede estar vacio")
        ElseIf (Double.IsNegativeInfinity(precioHora)) Then
            Throw New ArgumentException("El precio/Hora no puede ser un numero negativo")
        ElseIf (IsNothing(precioHora)) Then
            Throw New ArgumentException("El precio/Hora no puede estar vacio")
        ElseIf (IsNothing(fechaCompra)) Then
            Throw New ArgumentException("La fecha de compra no puede estar vacio")
        ElseIf (IsNothing(tipo)) Then
            Throw New ArgumentException("El tipo no puede estar vacio")
        End If

        Dim gateway As Gateway_Maquina
        Dim tabla As DataTable

        tabla = gateway.SelectTodasMaquinas()

    End Function
End Module
