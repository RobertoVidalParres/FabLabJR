Imports System.Data.SqlClient
Public Class Gateway_tipos_de_usuario
    Dim conexion As SqlConnection
    Dim comando As New SqlCommand

    Public Sub New()
        conexion = New SqlConnection(My.Settings.cadenaDeConexion)
        comando = New SqlCommand("", conexion)

        comando.Connection = conexion
    End Sub

    Public Function Insertar(tipo As String) As Integer
        Dim filas As Integer
        Dim consulta As String = String.Format("INSERT INTO TiposUsuario(tipo) VALUES ('{0}')", tipo)

        If tipo = "" Or tipo Is Nothing Then
            Throw New ArgumentException("El tipo no puede estar vacío")
        End If

        Try
            conexion.Open()
            comando.CommandText = consulta
            filas = comando.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        Finally
            If (conexion IsNot Nothing) Then
                conexion.Close()
            End If
        End Try

        Return filas
    End Function

    Public Function Actualizar(id As Integer, tipo As String) As Integer
        Dim filas As Integer
        Dim consulta As String = String.Format("UPDATE TiposUsuario SET tipo='{0}' WHERE id={4})", tipo, id)

        If id = 0 Then
            Throw New ArgumentException("El identificador no puede ser 0")
        End If

        If tipo = "" Or tipo Is Nothing Then
            Throw New ArgumentException("El tipo no puede estar vacío")
        End If

        Try
            conexion.Open()
            comando.CommandText = consulta
            filas = comando.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        Finally
            If (conexion IsNot Nothing) Then
                conexion.Close()
            End If
        End Try

        Return filas
    End Function

    Public Function Eliminar(id As Integer) As Integer
        Dim filas As Integer
        Dim consulta As String = String.Format("DELETE FROM Telefonos WHERE id={0})", id)

        If id = 0 Then
            Throw New ArgumentException("El identificador no puede estar vacío")
        End If

        Try
            conexion.Open()
            comando.CommandText = consulta
            filas = comando.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        Finally
            If (conexion IsNot Nothing) Then
                conexion.Close()
            End If
        End Try

        Return filas
    End Function

    Public Function SeleccionarTodos() As DataTable
        Dim consulta As String = String.Format("SELECT tipo FROM TiposUsuario")
        Dim resultado As New DataTable
        Dim lector As SqlDataReader

        Try
            conexion.Open()
            comando.CommandText = consulta
            lector = comando.ExecuteReader()

            resultado.Load(lector)
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        Finally
            If (conexion IsNot Nothing) Then
                conexion.Close()
            End If
        End Try

        Return resultado

    End Function
End Class
