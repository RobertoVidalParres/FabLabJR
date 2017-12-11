Imports System.Data.SqlClient
Module GestionarMaquina
    Public Sub Insertar(modelo As String, precioHora As Double, fechaCompra As Date, telefonoSAT As String, tipo As Integer, descripcion As String, caracteristicas As String)
        'Creacion del gateway de Maquina
        Dim gateway As New Gateway_Maquina
        'Llamada al metodo Insertar del Gateway
        gateway.Insertar(modelo, precioHora, fechaCompra, telefonoSAT, tipo, descripcion, caracteristicas)
    End Sub

    Public Sub ActualizarMaquina(id As Integer, modelo As String, precioHora As Double, fechaCompra As Date, telefonoSAT As String, tipo As Integer, descripcion As String, caracteristicas As String)
        'Creacion del gateway de Maquina
        Dim gateway As New Gateway_Maquina
        'LLamada al metodo Actualizar del Gateway
        gateway.ActualizarMaquina(id, modelo, precioHora, fechaCompra, telefonoSAT, tipo, descripcion, caracteristicas)
    End Sub

    Public Sub EliminarMaquina(id As Integer)
        'Creacion del gateway de Maquina
        Dim gateway As New Gateway_Maquina
        'LLamada al metodo Eliminar del Gateway
        gateway.EliminarMaquina(id)
    End Sub

    Public Function ComprobarDatos(modelo As String, precioHora As Double, fechaCompra As Date, telefonoSAT As String, tipo As Integer, descripcion As String, caracteristicas As String) As Boolean
        'Variable booleana para confirmar que los datos son correctos
        Dim resultado As Boolean
        resultado = True

        'Comprobando que las variables que en la base de datos son not null no sean nulas y que el precio/hora sea positivo
        If (String.IsNullOrEmpty(modelo)) Then
            resultado = False
            Throw New ArgumentException("El modelo no puede estar vacio")
        ElseIf (Double.IsNegativeInfinity(precioHora)) Then
            resultado = False
            Throw New ArgumentException("El precio/Hora no puede ser un numero negativo")
        ElseIf (IsNothing(precioHora)) Then
            resultado = False
            Throw New ArgumentException("El precio/Hora no puede estar vacio")
        ElseIf (IsNothing(fechaCompra)) Then
            resultado = False
            Throw New ArgumentException("La fecha de compra no puede estar vacio")
        ElseIf (IsNothing(tipo)) Then
            resultado = False
            Throw New ArgumentException("El tipo no puede estar vacio")
        End If

        'Creacion del gateway de Maquina
        Dim gateway As Gateway_Maquina
        'Variables creadas para la comprobacion que no existe una maquina con el mismo modelo y misma fecha de compra
        Dim tabla As SqlDataReader
        Dim modelos As String
        Dim fechas As Date

        'LLamada al gateway al metodo Select que devuelve todas las Maquinas de la base de datos
        tabla = gateway.SelectTodasMaquinas()

        'Bucle para comprobar que no existe una maquina con el mismo modelo y misma fecha de compra
        If (tabla.HasRows) Then
            Do While tabla.Read()
                modelos = tabla.Item("modelo").ToString
                fechas = Date.Parse(tabla.Item("fecha_compra").ToString)

                If (modelo = modelos And fechaCompra = fechas) Then
                    resultado = False
                    Throw New ArgumentException("Ya existe una maquina del mismo modelo con la misma fecha de compra")
                End If

            Loop
        End If

        Return resultado
    End Function

    Public Function ObtenerTiposDeMaquina() As List(Of String)
        Dim tipos As List(Of String)
        Dim gateway As Gateway_Tipo_de_Maquina
        Dim tabla As SqlDataReader

        tabla = gateway.SelectTiposMaquina()

        If (tabla.HasRows) Then
            Do While tabla.Read()
                tipos.Add(tabla.Item("tipo").ToString)
            Loop
        End If

        Return tipos
    End Function
End Module
