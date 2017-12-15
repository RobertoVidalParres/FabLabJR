Imports System.Data.SqlClient
Module UsuariosDatos
    Dim id As Integer
    Dim nombre As String
    Dim apellidos As String
    Dim fechaNacimiento As Date
    Dim telefono As String
    Dim email As String
    Dim direccionPostal As String
    Dim organizacion As String
    Dim tipo As String
    Dim observaciones As String
    Public Function ObtenerTiposDeUsuario() As List(Of String)
        Dim tipos As List(Of String) = New List(Of String)
        Dim gateway As New Gateway_tipos_de_usuario
        Dim tabla As DataTable

        tabla = gateway.SeleccionarTodos()

        For index = 0 To tabla.Rows.Count - 1
            tipos.Add(tabla.Rows(index).Item("tipo").ToString)
        Next


        Return tipos
    End Function

    Public Sub InsertarTipoUsuario(ByVal nuevoTipoUsuario As String)
        Dim gateWayTipoUsuarios As New Gateway_tipos_de_usuario()
        gateWayTipoUsuarios.Insertar(nuevoTipoUsuario)
    End Sub

    Public Sub InsertarUsuario(ByVal nombre As String, ByVal apellidos As String, ByVal fechaNacimiento As Date, ByVal telefono As String, ByVal email As String, ByVal direccionPostal As String, ByVal organizacion As String, ByVal tipo As Integer, ByVal observaciones As String)
        Dim gateWayUsuarios As New GatewayUsuarios(My.Settings.cadenaDeConexion)
        gateWayUsuarios.Insertar(nombre, apellidos, fechaNacimiento, telefono, email, direccionPostal, organizacion, tipo, Date.Now, observaciones)
    End Sub

    'Metodo que llama al gateway Usuarios y devuelve un datatable para el GridView del formulario Gestion Usuarios
    Public Function ObtenerTablaGestionUsuario() As DataTable
        Dim gateway As GatewayUsuarios = New GatewayUsuarios(My.Settings.cadenaDeConexion)
        Dim tabla As DataTable = New DataTable

        tabla = gateway.SeleccionarTodos

        Return tabla
    End Function

    'Metodo que llama al gateway Usuarios y devuelve un datatable segun el texto del buscador
    Public Function ObtenerTablaGestionUsuarioPorNombre(nombre As String) As BindingSource
        Dim gateway As GatewayUsuarios = New GatewayUsuarios(My.Settings.cadenaDeConexion)

        Dim enlace As New BindingSource
        enlace = gateway.SeleccionarNombre(nombre)

        enlace.Filter = "nombre like '*" & nombre & "*'"

        Return enlace

    End Function

    'Metodo que llama al gateway Usuarios y devuelve un datatable segun la id
    Public Function ObtenerUsuarioPorId(id As Integer) As DataTable
        Dim gateway As GatewayUsuarios = New GatewayUsuarios(My.Settings.cadenaDeConexion)

        Return gateway.SeleccionarPorId(id)
    End Function

    'Metodo que llama al gateway Usuarios y elimina un usuario segun la id
    Public Sub EliminarUsuarioPorId(id As Integer)
        Dim gateway As GatewayUsuarios = New GatewayUsuarios(My.Settings.cadenaDeConexion)
        gateway.Eliminar(id)
    End Sub

    ''Metodo que llama al gateway Usuarios y devuelve un datatable con la reserva del usuario seleccionado en el datagridview
    Public Function ObtenerReservaPorUsuario(usuario As Integer) As DataTable
        Dim gateway As Gateway_reservas = New Gateway_reservas()
        Return gateway.SeleccionarPorUsuario(usuario)
    End Function
End Module
