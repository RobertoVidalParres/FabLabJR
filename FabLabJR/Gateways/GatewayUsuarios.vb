Imports System.Data.SqlClient


Public Class GatewayUsuarios
    Private conexion As SqlConnection
    Private comando As SqlCommand

    Private Sub New(ByRef cadenaConexion As String)
        conexion = New SqlConnection(cadenaConexion)
        comando = New SqlCommand
    End Sub

    Public Function Insertar(id As Integer, nombre As String, apellidos As String, fecha_nacimiento As Date, email As String, direccion As String, organizacion As String, tipo As Integer, fecha_alta As Date)
        Dim filas As Integer
        Dim consulta As String = String.Format("INSERT INTO Usuarios(id, nombre, apellidos, fecha_nacimiento, email, direccion, organizacion, tipo, fecha_alta) VALUES ")
    End Function
End Class
