﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PrincipalForm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PrincipalForm))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaquinasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevaMaquinaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionMaquinaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentanaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrganizarVentanasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrganizarVerticalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrganizarHorizontalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrganizarCascadaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MinimizarTodasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.NuevoUsuarioToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.EliminarUsuarioToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.UsuariosToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MaquinaToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsuariosToolStripMenuItem, Me.MaquinasToolStripMenuItem, Me.VentanaToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.MdiWindowListItem = Me.VentanaToolStripMenuItem
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(918, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoUsuarioToolStripMenuItem, Me.GestionUsuarioToolStripMenuItem})
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'NuevoUsuarioToolStripMenuItem
        '
        Me.NuevoUsuarioToolStripMenuItem.Name = "NuevoUsuarioToolStripMenuItem"
        Me.NuevoUsuarioToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.NuevoUsuarioToolStripMenuItem.Text = "Nuevo Usuario"
        '
        'GestionUsuarioToolStripMenuItem
        '
        Me.GestionUsuarioToolStripMenuItem.Name = "GestionUsuarioToolStripMenuItem"
        Me.GestionUsuarioToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.GestionUsuarioToolStripMenuItem.Text = "Gestión de usuarios"
        '
        'MaquinasToolStripMenuItem
        '
        Me.MaquinasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevaMaquinaToolStripMenuItem, Me.GestionMaquinaToolStripMenuItem})
        Me.MaquinasToolStripMenuItem.Name = "MaquinasToolStripMenuItem"
        Me.MaquinasToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.MaquinasToolStripMenuItem.Text = "Máquinas"
        '
        'NuevaMaquinaToolStripMenuItem
        '
        Me.NuevaMaquinaToolStripMenuItem.Name = "NuevaMaquinaToolStripMenuItem"
        Me.NuevaMaquinaToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.NuevaMaquinaToolStripMenuItem.Text = "Nueva Máquina"
        '
        'GestionMaquinaToolStripMenuItem
        '
        Me.GestionMaquinaToolStripMenuItem.Name = "GestionMaquinaToolStripMenuItem"
        Me.GestionMaquinaToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.GestionMaquinaToolStripMenuItem.Text = "Gestión de Máquinas"
        '
        'VentanaToolStripMenuItem
        '
        Me.VentanaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OrganizarVentanasToolStripMenuItem, Me.MinimizarTodasToolStripMenuItem})
        Me.VentanaToolStripMenuItem.Name = "VentanaToolStripMenuItem"
        Me.VentanaToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.VentanaToolStripMenuItem.Text = "Ventana"
        '
        'OrganizarVentanasToolStripMenuItem
        '
        Me.OrganizarVentanasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OrganizarVerticalToolStripMenuItem, Me.OrganizarHorizontalToolStripMenuItem, Me.OrganizarCascadaToolStripMenuItem})
        Me.OrganizarVentanasToolStripMenuItem.Name = "OrganizarVentanasToolStripMenuItem"
        Me.OrganizarVentanasToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.OrganizarVentanasToolStripMenuItem.Text = "Organizar ventanas"
        '
        'OrganizarVerticalToolStripMenuItem
        '
        Me.OrganizarVerticalToolStripMenuItem.Name = "OrganizarVerticalToolStripMenuItem"
        Me.OrganizarVerticalToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.OrganizarVerticalToolStripMenuItem.Text = "Organizar de Forma Vertical"
        '
        'OrganizarHorizontalToolStripMenuItem
        '
        Me.OrganizarHorizontalToolStripMenuItem.Name = "OrganizarHorizontalToolStripMenuItem"
        Me.OrganizarHorizontalToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.OrganizarHorizontalToolStripMenuItem.Text = "Organizar de Forma Horizontal"
        '
        'OrganizarCascadaToolStripMenuItem
        '
        Me.OrganizarCascadaToolStripMenuItem.Name = "OrganizarCascadaToolStripMenuItem"
        Me.OrganizarCascadaToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.OrganizarCascadaToolStripMenuItem.Text = "Organizar de Forma Cascada"
        '
        'MinimizarTodasToolStripMenuItem
        '
        Me.MinimizarTodasToolStripMenuItem.Name = "MinimizarTodasToolStripMenuItem"
        Me.MinimizarTodasToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.MinimizarTodasToolStripMenuItem.Text = "Minimizar"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcercaDeToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoUsuarioToolStripButton, Me.EliminarUsuarioToolStripButton, Me.ToolStripButton1, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(918, 25)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'NuevoUsuarioToolStripButton
        '
        Me.NuevoUsuarioToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NuevoUsuarioToolStripButton.Image = CType(resources.GetObject("NuevoUsuarioToolStripButton.Image"), System.Drawing.Image)
        Me.NuevoUsuarioToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NuevoUsuarioToolStripButton.Name = "NuevoUsuarioToolStripButton"
        Me.NuevoUsuarioToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.NuevoUsuarioToolStripButton.Text = "Nuevo usuario"
        '
        'EliminarUsuarioToolStripButton
        '
        Me.EliminarUsuarioToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EliminarUsuarioToolStripButton.Image = CType(resources.GetObject("EliminarUsuarioToolStripButton.Image"), System.Drawing.Image)
        Me.EliminarUsuarioToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EliminarUsuarioToolStripButton.Name = "EliminarUsuarioToolStripButton"
        Me.EliminarUsuarioToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.EliminarUsuarioToolStripButton.Text = "Gestionar usuarios"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "Nueva maquina"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "Gestionar maquinas"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsuariosToolStripStatusLabel, Me.MaquinaToolStripStatusLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 447)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(918, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'UsuariosToolStripStatusLabel
        '
        Me.UsuariosToolStripStatusLabel.Name = "UsuariosToolStripStatusLabel"
        Me.UsuariosToolStripStatusLabel.Size = New System.Drawing.Size(58, 17)
        Me.UsuariosToolStripStatusLabel.Text = "Usuarios: "
        '
        'MaquinaToolStripStatusLabel
        '
        Me.MaquinaToolStripStatusLabel.Name = "MaquinaToolStripStatusLabel"
        Me.MaquinaToolStripStatusLabel.Size = New System.Drawing.Size(57, 17)
        Me.MaquinaToolStripStatusLabel.Text = "Maquina:"
        '
        'PrincipalForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(918, 469)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "PrincipalForm"
        Me.Text = "FabLabJR - VentanaPrincipal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents UsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MaquinasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentanaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevaMaquinaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionMaquinaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevoUsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionUsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrganizarVentanasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MinimizarTodasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuariosToolStripStatusLabel As ToolStripStatusLabel
    Friend WithEvents MaquinaToolStripStatusLabel As ToolStripStatusLabel
    Friend WithEvents OrganizarVerticalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrganizarHorizontalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrganizarCascadaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevoUsuarioToolStripButton As ToolStripButton
    Friend WithEvents EliminarUsuarioToolStripButton As ToolStripButton
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
End Class
