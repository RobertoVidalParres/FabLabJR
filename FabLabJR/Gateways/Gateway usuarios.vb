﻿Public Class GatewayUsuarios
    Private conexion As SqlConnection
    Private comando As SqlCommand

    Private Sub New(ByRef cadenaConexion As String)
        conexion = New SqlConnection(cadenaConexion)
        comando = New SqlCommand
    End Sub

    Public Function Insertar(nombre As String, apellidos As String, fecha_nacimiento As Date, email As String, direccion As String, organizacion As String, tipo As Integer, fecha_alta As Date)
        Dim filas As Integer
        Dim consulta As String = String.Format("INSERT INTO Usuarios(nombre, apellidos, fecha_nacimiento, email, direccion, organizacion, tipo, fecha_alta) VALUES ")

        If nombre = "" Or nombre Is Nothing Then
            Throw New ArgumentException("El nombre no puede estar vacío")
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

    Public Function Actualizar(id As Integer, nombre As String, apellidos As String, fecha_nacimiento As Date, email As String, direccion As String, organizacion As String, tipo As Integer, fecha_alta As Date) As Integer
        Dim filas As Integer
        Dim consulta As String = String.Format("UPDATE Telefonos SET nombre='{0}',apellidos='{1}',fecha_nacimiento='{2}',email='{3}',direccion='{4}',organizacion='{5}',tipo='{6}',fecha_alta='{7}' WHERE id={4})", nombre, apellidos, fecha_nacimiento, email, direccion, organizacion, tipo, fecha_alta)

        If id = 0 Then
            Throw New ArgumentException("El identificador no puede ser 0")
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
        Dim consulta As String = String.Format("DELETE FROM Usuarios WHERE id={0})", id)

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
        Dim consulta As String = String.Format("SELECT * FROM Usuarios")
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

    Public Function SeleccionarNombre(nombre As String) As DataTable
        Dim consulta As String = String.Format("SELECT * FROM Usuarios WHERE nombre='{0}'", nombre)
        Dim resultado As New DataTable
        Dim lector As SqlDataReader

        If nombre = "" Or nombre Is Nothing Then
            Throw New ArgumentException("El nombre no puede estar vacío")
        End If

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
