Imports System.Data.SqlClient

Public Class Gateway_Maquina
    Dim conexion As SqlConnection
    Dim comando As New SqlCommand

    Public Sub New(ByRef cadenaConexion As String)
        conexion = New SqlConnection(My.Settings.cadenaDeConexion)
        comando = New SqlCommand("", conexion)

        comando.Connection = conexion
    End Sub
End Class
