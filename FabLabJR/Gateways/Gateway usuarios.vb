Imports System.Data.SqlClient

Public Class GatewayUsuarios
    Private conexion As SqlConnection
    Private comando As SqlCommand

    Public Sub New(ByRef cadenaConexion As String)
        conexion = New SqlConnection(cadenaConexion)
        comando = New SqlCommand
        comando.Connection = conexion
    End Sub

    Public Function Insertar(nombre As String, apellidos As String, fecha_nacimiento As Date, telefono As String, email As String, direccion As String, organizacion As String, tipo As Integer, fecha_alta As Date, observaciones As String) As Integer
        Dim filas As Integer
        Dim consulta As String = String.Format("INSERT INTO Usuarios(nombre, apellidos, fecha_nacimiento, telefono, email, direccion, organizacion, tipo, fecha_alta, observaciones) VALUES (@nombre, @apellidos, @fecha_nacimiento, @telefono, @email, @direccion, @organizacion, @tipo, @fecha_alta, @observaciones)")
        comando.Parameters.Add("@nombre", SqlDbType.VarChar)
        comando.Parameters.Add("@apellidos", SqlDbType.VarChar)
        comando.Parameters.Add("@fecha_nacimiento", SqlDbType.Date)
        comando.Parameters.Add("@telefono", SqlDbType.VarChar)
        comando.Parameters.Add("@email", SqlDbType.VarChar)
        comando.Parameters.Add("@direccion", SqlDbType.VarChar)
        comando.Parameters.Add("@organizacion", SqlDbType.VarChar)
        comando.Parameters.Add("@tipo", SqlDbType.Int)
        comando.Parameters.Add("@fecha_alta", SqlDbType.Date)
        comando.Parameters.Add("@observaciones", SqlDbType.Text)

        comando.Parameters("@nombre").Value = nombre
        comando.Parameters("@apellidos").Value = apellidos
        comando.Parameters("@fecha_nacimiento").Value = fecha_nacimiento
        comando.Parameters("@telefono").Value = telefono
        comando.Parameters("@email").Value = email
        comando.Parameters("@direccion").Value = direccion
        comando.Parameters("@organizacion").Value = organizacion
        comando.Parameters("@tipo").Value = tipo
        comando.Parameters("@fecha_alta").Value = fecha_alta
        comando.Parameters("@observaciones").Value = observaciones
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

    Public Function Actualizar(id As Integer, nombre As String, apellidos As String, fecha_nacimiento As Date, email As String, direccion As String, organizacion As String, tipo As Integer, fecha_alta As Date, observaciones As String) As Integer
        Dim filas As Integer
        Dim consulta As String = String.Format("UPDATE Usuario SET nombre='{0}',apellidos='{1}',fecha_nacimiento='{2}', telefono='{3}',email='{4}',direccion='{5}',organizacion='{6}',tipo='{7}',fecha_alta='{8}',observaciones='{9}' WHERE id={4})", nombre, apellidos, fecha_nacimiento, email, direccion, organizacion, tipo, fecha_alta, observaciones)

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
        Dim consulta As String = String.Format("DELETE FROM Usuarios WHERE id={0}", id)

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

    Public Function SeleccionarNombre(nombre As String) As BindingSource
        Dim consulta As String = String.Format("SELECT * FROM Usuarios WHERE nombre='{0}'", nombre)
        Dim adapter As New SqlDataAdapter(consulta, conexion)
        Dim commandBuilder As New SqlCommandBuilder(adapter)
        Dim dataSet As New DataSet
        Dim resultado As BindingSource

        If nombre = "" Or nombre Is Nothing Then
            Throw New ArgumentException("El nombre no puede estar vacío")
        End If

        Try
            conexion.Open()
            adapter.Fill(dataSet, "Usuarios")
            resultado = New BindingSource(dataSet, "Usuarios")
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        Finally
            If (conexion IsNot Nothing) Then
                conexion.Close()
            End If
        End Try

        Return resultado
    End Function

    Public Function SeleccionarPorId(id As Integer) As DataTable
        Dim consulta As String = String.Format("SELECT * FROM Usuarios WHERE id='{0}'", id)
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
