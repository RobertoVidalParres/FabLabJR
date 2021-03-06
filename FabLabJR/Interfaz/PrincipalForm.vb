﻿Public Class PrincipalForm
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim numeroMaquinas As Integer
        Dim numeroUsuarios As Integer
        Dim textoMaquinasSatusStrip As String
        Dim textoUsuariosStatusStrip As String

        numeroMaquinas = GestionarMaquina.ObtenerNumeroDeMaquinaBaseDeDatos
        numeroUsuarios = UsuariosDatos.ObtenerTablaGestionUsuario().Rows.Count
        textoMaquinasSatusStrip = UsuariosToolStripStatusLabel.Text.Trim() & numeroMaquinas.ToString
        textoUsuariosStatusStrip = MaquinaToolStripStatusLabel.Text.Trim() & numeroUsuarios.ToString

        MaquinaToolStripStatusLabel.Text = textoMaquinasSatusStrip
        UsuariosToolStripStatusLabel.Text = textoUsuariosStatusStrip
    End Sub

    'LLamada al form Nueva Maquina
    Private Sub NuevaMaquinaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevaMaquinaToolStripMenuItem.Click, ToolStripButton1.Click
        Dim documento As FormTratarMaquina = New FormTratarMaquina
        documento.MdiParent = Me
        documento.Text = "Nueva Maquina"
        documento.QuienMeLLama("Insertar")
        documento.Show()
    End Sub

    'LLamada al form Gestion Usuarios
    Private Sub GestionUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionUsuarioToolStripMenuItem.Click, EliminarUsuarioToolStripButton.Click
        Dim documento As FormGestionUsuarios = New FormGestionUsuarios
        documento.MdiParent = Me
        documento.Text = "Gestion usuarios"
        documento.Show()
    End Sub

    'LLamada a form Acerca de
    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        Dim documento As AcerdaDeForm = New AcerdaDeForm
        documento.MdiParent = Me
        documento.Show()
    End Sub

    'Minimización de las ventanas 
    Private Sub MinimizarTodasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MinimizarTodasToolStripMenuItem.Click
        For Each ventana In Me.MdiChildren
            ventana.WindowState = FormWindowState.Minimized
        Next
    End Sub

    'Metodo para ordenar las ventas de forma vertical
    Private Sub OrganizarVerticalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrganizarVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    'Metodo para ordenar las ventas de forma horizontal
    Private Sub OrganizarHorizontalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrganizarHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    'Metodo para ordenar las ventas de forma cascada
    Private Sub OrganizarCascadaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrganizarCascadaToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    'Llamada al form de nuevo usuario al hacer click en el item del menu "Nuevo usuario"
    Private Sub NuevoUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoUsuarioToolStripMenuItem.Click, NuevoUsuarioToolStripButton.Click
        Dim nuevoUsuario As New TratarUsuario("")
        nuevoUsuario.MdiParent = Me
        nuevoUsuario.Text = "Nuevo usuario"
        nuevoUsuario.Show()
    End Sub

    'Llamada al form de gestion de maquinas al hacer click en el item del menu "Gestion de Maquinas"
    Private Sub GestionMaquinaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionMaquinaToolStripMenuItem.Click, ToolStripButton2.Click
        Dim gestionMaquina As New GestionMaquinas
        gestionMaquina.MdiParent = Me
        gestionMaquina.Text = "Gestion maquina"
        gestionMaquina.Show()
    End Sub
End Class
