'Form que muestra un datagridview con todas las reservas del usuario indicado
Public Class ReservasUsuariovb
    Dim id As Integer

    Sub New(id As Integer)
        InitializeComponent()
        Me.id = id
    End Sub
    'Metodo que llama a otro metodo que rellena el datagridview con las reservas del usuario que le pasamos
    Private Sub ReservasUsuariovb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TablaReservasDataGridView.DataSource = UsuariosDatos.ObtenerReservaPorUsuario(id)
    End Sub
End Class