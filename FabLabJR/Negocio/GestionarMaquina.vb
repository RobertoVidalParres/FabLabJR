Imports System.Data.SqlClient
Module GestionarMaquina

    ''' <summary>
    ''' Inserta un nueva maquina en la base de datos
    ''' </summary>
    ''' <param name="modelo">modelo de la maquina</param>
    ''' <param name="precioHora">precio por hora</param>
    ''' <param name="fechaCompra">fecha de compra de la maquina</param>
    ''' <param name="telefonoSAT">telefono del departamento tecnico de la maquina</param>
    ''' <param name="tipo">tipo de la maquina</param>
    ''' <param name="descripcion">descripcion de la maquina</param>
    ''' <param name="caracteristicas">caracteristicas de la maquina</param>
    Public Sub Insertar(modelo As String, precioHora As Double, fechaCompra As Date, telefonoSAT As String, tipo As Integer, descripcion As String, caracteristicas As String)
        'Creacion del gateway de Maquina
        Dim gateway As Gateway_Maquina = New Gateway_Maquina
        'Llamada al metodo Insertar del Gateway
        gateway.Insertar(modelo, precioHora, fechaCompra, telefonoSAT, tipo, descripcion, caracteristicas)
    End Sub

    ''' <summary>
    ''' Actualizar una maquina en la base de datos
    ''' </summary>
    ''' <param name="modelo">modelo de la maquina</param>
    ''' <param name="precioHora">precio por hora</param>
    ''' <param name="fechaCompra">fecha de compra de la maquina</param>
    ''' <param name="telefonoSAT">telefono del departamento tecnico de la maquina</param>
    ''' <param name="tipo">tipo de la maquina</param>
    ''' <param name="descripcion">descripcion de la maquina</param>
    ''' <param name="caracteristicas">caracteristicas de la maquina</param>
    Public Sub ActualizarMaquina(id As Integer, modelo As String, precioHora As Double, fechaCompra As Date, telefonoSAT As String, tipo As Integer, descripcion As String, caracteristicas As String)
        'Creacion del gateway de Maquina
        Dim gateway As Gateway_Maquina = New Gateway_Maquina
        'LLamada al metodo Actualizar del Gateway
        gateway.ActualizarMaquina(id, modelo, precioHora, fechaCompra, telefonoSAT, tipo, descripcion, caracteristicas)
    End Sub

    ''' <summary>
    ''' Eliminar una maquina de la base de datos
    ''' </summary>
    ''' <param name="id">id de la maquina</param>
    Public Sub EliminarMaquina(id As Integer)
        'Creacion del gateway de Maquina
        Dim gateway As Gateway_Maquina = New Gateway_Maquina
        'LLamada al metodo Eliminar del Gateway
        gateway.EliminarMaquina(id)
    End Sub

    ''' <summary>
    ''' Comprueba que los datos son correctos
    ''' </summary>
    ''' <param name="modelo">modelo de la maquina</param>
    ''' <param name="precioHora">precio por hora</param>
    ''' <param name="fechaCompra">fecha de compra de la maquina</param>
    ''' <param name="telefonoSAT">telefono del departamento tecnico de la maquina</param>
    ''' <param name="tipo">tipo de la maquina</param>
    ''' <param name="descripcion">descripcion de la maquina</param>
    ''' <param name="caracteristicas">caracteristicas de la maquina</param>
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
        Dim gateway As Gateway_Maquina = New Gateway_Maquina
        'Variables creadas para la comprobacion que no existe una maquina con el mismo modelo y misma fecha de compra
        Dim tabla As DataTable
        Dim modelos As String
        Dim fechas As Date

        'LLamada al gateway al metodo Select que devuelve todas las Maquinas de la base de datos
        tabla = gateway.SelectTodasMaquinas()

        'Bucle para comprobar que no existe una maquina con el mismo modelo y misma fecha de compra

        For index = 0 To tabla.Rows.Count - 1
            modelos = tabla.Rows(index).Item("modelo").ToString
            fechas = Date.Parse(tabla.Rows(index).Item("fecha_compra").ToString)
        Next

        If (modelo = modelos And fechaCompra = fechas) Then
            resultado = False
            Throw New ArgumentException("Ya existe una maquina del mismo modelo con la misma fecha de compra")
        End If


        Return resultado
    End Function


    ''' <summary>
    ''' Obtiene los tipos de maquina de la base de datos
    ''' </summary>
    Public Function ObtenerTiposDeMaquina() As List(Of String)
        Dim tipos As List(Of String) = New List(Of String)
        Dim gateway As New Gateway_Tipo_de_Maquina
        Dim tabla As DataTable

        tabla = gateway.SelectTiposMaquina()

        For index = 0 To tabla.Rows.Count - 1
            tipos.Add(tabla.Rows(index).Item("tipo").ToString)
        Next


        Return tipos
    End Function

    ''' <summary>
    ''' Obtiene la tabla para cuando la Gestion de maquina se inicia
    ''' </summary>
    Public Function ObtenerTablaGestionMaquina() As DataTable
        Dim gateway As Gateway_Maquina = New Gateway_Maquina
        Dim tabla As DataTable = New DataTable

        tabla = gateway.SelectMaquinasParaGestionMaquinas()

        Return tabla
    End Function

    ''' <summary>
    ''' Obtiene la tabla para cuando la Gestion de maquina por modelo 
    ''' </summary>
    ''' <param name="modelo">modelo de la maquina</param>
    Public Function ObtenerTablaGestionMaquinaPorModelo(modelo As String) As DataTable
        Dim gateway As Gateway_Maquina = New Gateway_Maquina

        Return gateway.SelectMaquinasPorModelo(modelo)
    End Function

    Public Function AñadirTipoMaquina(tipo As String) As Integer
        Dim gateway As Gateway_Tipo_de_Maquina = New Gateway_Tipo_de_Maquina
        Dim filasModificadas As Integer
        filasModificadas = gateway.InsertarTipo(tipo)

        Return filasModificadas
    End Function

    Public Function ObtenerNumeroDeMaquinaBaseDeDatos() As Integer
        Dim gateway As Gateway_Maquina = New Gateway_Maquina
        Dim tabla As DataTable = New DataTable
        Dim numeroMaquinas As Integer = 0

        tabla = gateway.SelectMaquinasParaGestionMaquinas()

        For index = 0 To tabla.Rows.Count - 1
            numeroMaquinas = numeroMaquinas + 1
        Next

        Return numeroMaquinas
    End Function

    Public Function ObtenerNumeroDeUsuariosBaseDeDatos() As Integer
        Dim tabla As DataTable = New DataTable
        Dim numeroMaquinas As Integer = 0

        For index = 0 To tabla.Rows.Count - 1
            numeroMaquinas = numeroMaquinas + 1
        Next

        Return numeroMaquinas
    End Function
End Module
