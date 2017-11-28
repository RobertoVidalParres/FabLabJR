Imports System.Data.SqlClient

Public Class Gateway_Maquina
    Dim conexion As SqlConnection
    Dim comando As New SqlCommand

    Public Sub New()
        conexion = New SqlConnection(My.Settings.cadenaDeConexion)
        comando = New SqlCommand("", conexion)

        comando.Connection = conexion
    End Sub

    Public Function Insertar(modelo As String, precioHora As Double, fechaCompra As Date, telefonoSAT As String, tipo As Integer, descripcion As String, caracteristicas As String) As Integer

        'Variables para la consultas y las filas afectadas por la misma
        Dim consulta As String
        Dim filas_afectadas As Integer

        'Consulta con parametros
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

        'Comprobacion de los datos
        If precioHora <= 0 Then
            Throw New ArgumentException("El precio debe ser un número positivo mayor que cero")
        End If

        If DiferenteFechaDeCompra(modelo, fechaCompra) Then
            Throw New ArgumentException("Ya existe una maquina del mismo modelo con la misma fecha de compra")
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
            comando.CommandText = consulta
            filas_afectadas = comando.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        Finally
            If (conexion IsNot Nothing) Then
                conexion.Close()
            End If
        End Try

        'Devolvemos el número de filas afectadas
        Return filas_afectadas

    End Function

    Public Function DiferenteFechaDeCompra(modelo As String, fechaCompra As Date) As Boolean

        Dim consulta As String

        'Consulta con parametros
        consulta = "SELECT fecha_compra FROM Maquina Where modelo = @modelo"
        comando.CommandText = consulta

        comando.Parameters.Add("@modelo", SqlDbType.VarChar)

        'Falta apartado comprobacion de las fechas

    End Function
End Class
