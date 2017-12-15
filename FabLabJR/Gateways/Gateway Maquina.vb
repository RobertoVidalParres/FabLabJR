Imports System.Data.SqlClient

Public Class Gateway_Maquina
    Dim conexion As SqlConnection
    Dim comando As New SqlCommand

    'Inicializacion de la conexion
    Public Sub New()
        conexion = New SqlConnection(My.Settings.cadenaDeConexion)
        comando = New SqlCommand("", conexion)

        comando.Connection = conexion
    End Sub

    'Metodo para la insercion de una nueva maquina
    Public Function Insertar(modelo As String, precioHora As Double, fechaCompra As Date, telefonoSAT As String, tipo As Integer, descripcion As String, caracteristicas As String) As Integer

        'Variables para la consultas y las filas afectadas por la misma
        Dim consulta As String
        Dim filas_afectadas As Integer

        'Consulta con parametros para la insercion de una nueva maquina
        consulta = "INSERT INTO Maquinas (modelo,precio_hora,fecha_compra,telefono_sat,tipo,descripcion,caracteristicas) VALUES (@modelo,@precio,@fecha,@telefono,@tipo,@descripcion,@caracteristicas)"
        comando.CommandText = consulta

        'Indicacion del tipo de parametro
        comando.Parameters.Add("@modelo", SqlDbType.VarChar)
        comando.Parameters.Add("@precio", SqlDbType.Money)
        comando.Parameters.Add("@fecha", SqlDbType.Date)
        comando.Parameters.Add("@telefono", SqlDbType.VarChar)
        comando.Parameters.Add("@tipo", SqlDbType.Int)
        comando.Parameters.Add("@descripcion", SqlDbType.Text)
        comando.Parameters.Add("@caracteristicas", SqlDbType.Text)

        'Comprobacion de datos nulos
        If modelo = "" Or modelo Is Nothing Then
            MessageBox.Show("El modelo no puede estar vacio")
        End If

        If Not IsDate(fechaCompra) Or IsNothing(fechaCompra) Then
            MessageBox.Show("La fecha de compra no puede estar vacio")
        End If

        If Not IsNumeric(tipo) Or IsNothing(tipo) Then
            MessageBox.Show("El tipo no puede estar vacio")
        End If

        'paso del parametro
        comando.Parameters("@modelo").Value = modelo
        comando.Parameters("@precio").Value = precioHora
        comando.Parameters("@fecha").Value = fechaCompra
        comando.Parameters("@telefono").Value = telefonoSAT
        comando.Parameters("@tipo").Value = tipo
        comando.Parameters("@descripcion").Value = descripcion
        comando.Parameters("@caracteristicas").Value = caracteristicas

        'Ejecutamos la consulta
        Try
            conexion.Open()
            filas_afectadas = comando.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If (conexion IsNot Nothing) Then
                conexion.Close()
            End If
        End Try

        'Devolvemos el número de filas afectadas
        Return filas_afectadas

    End Function

    'Metodo para la seleccion de maquina para Gestion de Maquinas
    Public Function SelectMaquinasParaGestionMaquinas() As DataTable
        Dim consulta As String

        'Consulta para la seleccion de todas las maquinas
        consulta = "SELECT id,modelo,tipo,fecha_compra FROM Maquinas"
        comando.CommandText = consulta

        'Comparacion de las fechas de la base de datos con la introducida

        'Ejecutamos la consulta
        Try
            conexion.Open()

            Dim lector As SqlDataReader = comando.ExecuteReader

            Dim resultado As New DataTable

            resultado.Load(lector)

            Return resultado

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If (conexion IsNot Nothing) Then
                conexion.Close()
            End If
        End Try
    End Function

    'Metodo para la seleccion de todas las maquinas
    Public Function SelectTodasMaquinas() As DataTable

        Dim consulta As String

        'Consulta para la seleccion de todas las maquinas
        consulta = "SELECT * FROM Maquinas"
        comando.CommandText = consulta


        'Comparacion de las fechas de la base de datos con la introducida

        'Ejecutamos la consulta
        Try
            conexion.Open()

            Dim lector As SqlDataReader = comando.ExecuteReader

            Dim resultado As New DataTable

            resultado.Load(lector)

            Return resultado

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If (conexion IsNot Nothing) Then
                conexion.Close()
            End If
        End Try

    End Function

    'Metodo para la seleccion de las maquina por modelo
    Public Function SelectMaquinasPorModelo(modelo As String) As DataTable

        Dim consulta As String

        'Consulta para la seleccion de todas las maquinas
        consulta = "SELECT * FROM Maquinas Where modelo = @modelo"
        comando.CommandText = consulta

        'Indicacion del tipo de parametro
        comando.Parameters.Add("@modelo", SqlDbType.VarChar)

        'paso del parametro
        comando.Parameters("@modelo").Value = modelo

        'Comparacion de las fechas de la base de datos con la introducida

        'Ejecutamos la consulta
        Try
            conexion.Open()

            Dim lector As SqlDataReader = comando.ExecuteReader
            Dim resultado As New DataTable

            resultado.Load(lector)

            Return resultado

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If (conexion IsNot Nothing) Then
                conexion.Close()
            End If
        End Try

    End Function

    'Metodo para la actualizacion de una maquina
    Public Function ActualizarMaquina(id As Integer, modelo As String, precioHora As Double, fechaCompra As Date, telefonoSAT As String, tipo As Integer, descripcion As String, caracteristicas As String) As Integer

        'Variables para la consultas y las filas afectadas por la misma
        Dim consulta As String
        Dim filas_afectadas As Integer

        'Consulta con parametros para actualizar una maquina
        consulta = "UPDATE Maquinas SET modelo = @modelo,precio_hora = @precio,fecha_compra = @fecha,telefono_sat = @telefono,tipo = @tipo,descripcion = @descripcion,caracteristicas = @caracteristicas WHERE id = @id"
        comando.CommandText = consulta

        'Indicacion del tipo de parametro
        comando.Parameters.Add("@id", SqlDbType.Int)
        comando.Parameters.Add("@modelo", SqlDbType.VarChar)
        comando.Parameters.Add("@precio", SqlDbType.Money)
        comando.Parameters.Add("@fecha", SqlDbType.Date)
        comando.Parameters.Add("@telefono", SqlDbType.VarChar)
        comando.Parameters.Add("@tipo", SqlDbType.Int)
        comando.Parameters.Add("@descripcion", SqlDbType.Text)
        comando.Parameters.Add("@caracteristicas", SqlDbType.Text)

        'Comprobacion de datos nulos
        If modelo = "" Or modelo Is Nothing Then
            Throw New ArgumentException("El modelo no puede estar vacio")
        End If

        If Not IsDate(fechaCompra) Or IsNothing(fechaCompra) Then
            Throw New ArgumentException("La fecha de compra no puede estar vacio")
        End If

        If Not IsNumeric(tipo) Or IsNothing(tipo) Then
            Throw New ArgumentException("El tipo no puede estar vacio")
        End If

        'paso del parametro
        comando.Parameters("@id").Value = id
        comando.Parameters("@modelo").Value = modelo
        comando.Parameters("@precio").Value = precioHora
        comando.Parameters("@fecha").Value = fechaCompra
        comando.Parameters("@telefono").Value = telefonoSAT
        comando.Parameters("@tipo").Value = tipo
        comando.Parameters("@descripcion").Value = descripcion
        comando.Parameters("@caracteristicas").Value = caracteristicas

        'Ejecutamos la consulta
        Try
            conexion.Open()
            filas_afectadas = comando.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If (conexion IsNot Nothing) Then
                conexion.Close()
            End If
        End Try

        'Devolvemos el número de filas afectadas
        Return filas_afectadas
    End Function

    'Metodo para la eliminicación de una maquina
    Public Function EliminarMaquina(id As Integer) As Integer

        'Variables para la consultas y las filas afectadas por la misma
        Dim consulta As String
        Dim filas_afectadas As Integer

        'Consulta con parametros para eliminar una maquina
        consulta = "DELETE FROM Maquinas WHERE id = @id"
        comando.CommandText = consulta

        'Indicacion del tipo de parametro
        comando.Parameters.Add("@id", SqlDbType.Int)

        'paso del parametro
        comando.Parameters("@id").Value = id

        'Ejecutamos la consulta
        Try
            conexion.Open()
            filas_afectadas = comando.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If (conexion IsNot Nothing) Then
                conexion.Close()
            End If
        End Try

        'Devolvemos el número de filas afectadas
        Return filas_afectadas

    End Function

End Class
