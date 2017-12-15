Imports System.Data.SqlClient
Public Class Gateway_reservas
    Dim conexion As SqlConnection
    Dim comando As New SqlCommand

    Public Sub New()
        conexion = New SqlConnection(My.Settings.cadenaDeConexion)
        comando = New SqlCommand("", conexion)

        comando.Connection = conexion
    End Sub

    Public Function Insertar(fecha As Date, hora As Timer, usuario As Integer, proyecto As String) As Integer
        Dim filas As Integer
        'Creamos la sentencia SQL de inserción
        Dim consulta As String = String.Format("INSERT INTO Telefonos(fecha,hora,usuario,proyecto) VALUES ('{0}','{1}','{2}','{3}')", fecha, hora, usuario, proyecto)

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

    Public Function Actualizar(id As Integer, fecha As Date, hora As Timer, usuario As Integer, proyecto As String) As Integer
        Dim filas As Integer
        'Creamos la sentencia SQL de inserción
        Dim consulta As String = String.Format("UPDATE Reservas SET fecha='{0}',hora='{1}',usuario='{2}',proyecto='{3}' WHERE id={4})", fecha, hora, usuario, proyecto, id)

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
        Dim consulta As String = String.Format("DELETE FROM Reservas WHERE id={0})", id)

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
        Dim consulta As String = String.Format("SELECT * FROM Reservas")
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

    Public Function SeleccionarPorUsuario(usuario As Integer) As DataTable
        Dim consulta As String = String.Format("SELECT * FROM Reservas WHERE usuario = '{0}'", usuario)
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
