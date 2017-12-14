Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class NuevoUsuario
    Public conexion As SqlConnection
    Public comandoTipoUsuario As SqlCommand
    Public adaptadorMaquinas As SqlDataAdapter

    Private Sub ExaminarButton_Click(sender As Object, e As EventArgs) Handles examinarButton.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            pictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
        Else
            MessageBox.Show("No has seleccionado ninguna imagen")
        End If
    End Sub

    Private Sub TipoComboBox_DropDown(sender As Object, e As EventArgs) Handles tipoComboBox.DropDown
        Dim resultado As New DataTable
        resultado = UsuariosDatos.ObtenerTiposUsuario()
        tipoComboBox.DataSource = resultado
        tipoComboBox.DisplayMember = "tipo"
    End Sub

    Private Sub AñadirPictureBox_Click(sender As Object, e As EventArgs) Handles AñadirPictureBox.Click
        AñadirTipoUsuarioTextBox.Show()
        AñadirTipoUsuarioButton.Show()
    End Sub

    Private Sub NuevoUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AñadirTipoUsuarioTextBox.Hide()
        AñadirTipoUsuarioButton.Hide()
    End Sub

    Private Sub AñadirTipoUsuarioButton_Click(sender As Object, e As EventArgs) Handles AñadirTipoUsuarioButton.Click
        UsuariosDatos.InsertarTipoUsuario(AñadirTipoUsuarioTextBox.Text)
        MessageBox.Show("Nuevo tipo de usuario registrado con éxito")
    End Sub

    Private Sub aceptarButton_Click(sender As Object, e As EventArgs) Handles aceptarButton.Click
        If telefonoTextBox.Text.Equals("") And emailTexBox.Text.Equals("") Then
            MessageBox.Show("Debes aportar almenos una forma de contacto")
        Else
            UsuariosDatos.InsertarUsuario(nombreTextBox.Text, apellidosTextBox.Text, DateTimePicker1.Value, telefonoTextBox.Text, emailTexBox.Text, direccionpostalTextBox.Text, organizacionTextBox.Text, tipoComboBox.SelectedIndex + 1)
            MessageBox.Show("Nuevo usuario registrado con éxito")
        End If
    End Sub

    Private Sub emailTexBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles emailTexBox.Validating
        Dim rgx As New Regex("\w*\d*@\w.\w$")
        If rgx.IsMatch(emailTexBox.Text) Then
            EmailErrorProvider.SetError(emailTexBox, "")
        Else
            EmailErrorProvider.SetError(emailTexBox, "Formato incorrecto")
        End If
    End Sub
End Class