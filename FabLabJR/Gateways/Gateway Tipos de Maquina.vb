Imports System.Data.SqlClient

Public Class Gateway_Tipo_de_Maquina
    Dim conexion As SqlConnection
    Dim comando As New SqlCommand

    Public Sub New()
        conexion = New SqlConnection(My.Settings.cadenaDeConexion)
        comando = New SqlCommand("", conexion)

        comando.Connection = conexion
    End Sub

    'Metodo para la insercion de un tipo de maquina nuevo
    Public Function InsertarTipo(tipo As String) As Integer

        'Variables para la consultas y las filas afectadas por la misma
        Dim consulta As String
        Dim filas_afectadas As Integer

        'Consulta con parametros para la insercion de una nueva maquina
        consulta = "INSERT INTO TiposMaquina (tipo) VALUES (@tipo)"
        comando.CommandText = consulta

        'Indicacion del tipo de parametro
        comando.Parameters.Add("@tipo", SqlDbType.VarChar)

        'Comprobacion de datos nulos
        If tipo = "" Or tipo Is Nothing Then
            Throw New ArgumentException("El modelo no puede estar vacio")
        End If

        'paso del parametro
        comando.Parameters("@tipo").Value = tipo

        'Ejecutamos la consulta
        Try
            conexion.Open()
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

    'Metodo para la seleccion de todos los tipos de maquina de la base de datos
    Public Function SelectTiposMaquina() As DataTable
        Dim consulta As String

        'Consulta para la seleccion de todas las maquinas
        consulta = "SELECT * FROM TiposMaquina"
        comando.CommandText = consulta


        'Comparacion de las fechas de la base de datos con la introducida

        'Ejecutamos la consulta
        Try
            conexion.Open()

            Dim lector As SqlDataReader = comando.ExecuteReader()

            Dim resultado As New DataTable

            resultado.Load(lector)

            Return resultado

        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        Finally
            If (conexion IsNot Nothing) Then
                conexion.Close()
            End If
        End Try
    End Function

End Class
