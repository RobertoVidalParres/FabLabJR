Public Class Form1
    'LLamada al form Nueva Maquina
    Private Sub NuevaMaquinaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevaMaquinaToolStripMenuItem.Click
        Dim documento As FormTratarMaquina = New FormTratarMaquina
        documento.MdiParent = Me
        documento.Text = "Nueva Maquina"
        documento.QuienMeLLama("Insertar")
        documento.Show()
    End Sub

    'LLamada al form Gestion Usuarios
    Private Sub GestionUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionUsuarioToolStripMenuItem.Click
        Dim documento As FormGestionUsuarios = New FormGestionUsuarios
        documento.MdiParent = Me
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
End Class
