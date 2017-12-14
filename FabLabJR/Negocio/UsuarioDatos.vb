Imports System.Data.SqlClient
Module UsuariosDatos
    Public Function ObtenerTiposUsuario() As DataTable
        Dim gateWayTipoUsuarios As New Gateway_tipos_de_usuario()

        Return gateWayTipoUsuarios.SeleccionarTodos()
    End Function

    Public Sub InsertarTipoUsuario(ByVal nuevoTipoUsuario As String)
        Dim gateWayTipoUsuarios As New Gateway_tipos_de_usuario()
        gateWayTipoUsuarios.Insertar(nuevoTipoUsuario)
    End Sub

    Public Sub InsertarUsuario(ByVal nombre As String, ByVal apellidos As String, ByVal fechaNacimiento As Date, ByVal telefono As String, ByVal email As String, ByVal direccionPostal As String, ByVal organizacion As String, ByVal tipo As Integer)
        Dim gateWayUsuarios As New GatewayUsuarios(My.Settings.cadenaDeConexion)
        gateWayUsuarios.Insertar(nombre, apellidos, fechaNacimiento, telefono, email, direccionPostal, organizacion, tipo, Date.Now)
    End Sub

    'Metodo que llama al gateway Usuarios y devuelve un datatable para el GridView del formulario Gestion Usuarios
    Public Function ObtenerTablaGestionUsuario() As DataTable
        Dim gateway As GatewayUsuarios = New GatewayUsuarios(My.Settings.cadenaDeConexion)
        Dim tabla As DataTable = New DataTable

        tabla = gateway.SeleccionarTodos

        Return tabla
    End Function

    Public Function ObtenerTablaGestionUsuarioPorNombre(nombre As String) As DataTable
        Dim gateway As GatewayUsuarios = New GatewayUsuarios(My.Settings.cadenaDeConexion)

        Return gateway.SeleccionarNombre(nombre)
    End Function
End Module
