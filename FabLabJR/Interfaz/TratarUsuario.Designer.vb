﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TratarUsuario
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TratarUsuario))
        Me.AñadirTipoUsuarioButton = New System.Windows.Forms.Button()
        Me.AñadirTipoUsuarioTextBox = New System.Windows.Forms.TextBox()
        Me.FechaNacimientoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.cancelarButton = New System.Windows.Forms.Button()
        Me.aceptarButton = New System.Windows.Forms.Button()
        Me.AñadirPictureBox = New System.Windows.Forms.PictureBox()
        Me.tipoComboBox = New System.Windows.Forms.ComboBox()
        Me.examinarButton = New System.Windows.Forms.Button()
        Me.FotoLabel = New System.Windows.Forms.Label()
        Me.ObservacionesLabel = New System.Windows.Forms.Label()
        Me.FotoUsuariopictureBox = New System.Windows.Forms.PictureBox()
        Me.observacionesTextBox = New System.Windows.Forms.TextBox()
        Me.direccionpostalTextBox = New System.Windows.Forms.TextBox()
        Me.DirPostalLabel = New System.Windows.Forms.Label()
        Me.FechaNacLabel = New System.Windows.Forms.Label()
        Me.emailTexBox = New System.Windows.Forms.TextBox()
        Me.apellidosTextBox = New System.Windows.Forms.TextBox()
        Me.TipoLabel = New System.Windows.Forms.Label()
        Me.EmailLabel = New System.Windows.Forms.Label()
        Me.ApellidosLabel = New System.Windows.Forms.Label()
        Me.organizacionTextBox = New System.Windows.Forms.TextBox()
        Me.telefonoTextBox = New System.Windows.Forms.TextBox()
        Me.nombreTextBox = New System.Windows.Forms.TextBox()
        Me.OrganizacionLabel = New System.Windows.Forms.Label()
        Me.TelefonoLabel = New System.Windows.Forms.Label()
        Me.NombreLabel = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.EmailErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider2 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.AñadirPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FotoUsuariopictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmailErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AñadirTipoUsuarioButton
        '
        Me.AñadirTipoUsuarioButton.Location = New System.Drawing.Point(430, 199)
        Me.AñadirTipoUsuarioButton.Name = "AñadirTipoUsuarioButton"
        Me.AñadirTipoUsuarioButton.Size = New System.Drawing.Size(75, 23)
        Me.AñadirTipoUsuarioButton.TabIndex = 53
        Me.AñadirTipoUsuarioButton.Text = "Añadir"
        Me.AñadirTipoUsuarioButton.UseVisualStyleBackColor = True
        '
        'AñadirTipoUsuarioTextBox
        '
        Me.AñadirTipoUsuarioTextBox.Location = New System.Drawing.Point(324, 200)
        Me.AñadirTipoUsuarioTextBox.Name = "AñadirTipoUsuarioTextBox"
        Me.AñadirTipoUsuarioTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AñadirTipoUsuarioTextBox.TabIndex = 42
        '
        'FechaNacimientoDateTimePicker
        '
        Me.FechaNacimientoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaNacimientoDateTimePicker.Location = New System.Drawing.Point(591, 24)
        Me.FechaNacimientoDateTimePicker.Name = "FechaNacimientoDateTimePicker"
        Me.FechaNacimientoDateTimePicker.Size = New System.Drawing.Size(100, 20)
        Me.FechaNacimientoDateTimePicker.TabIndex = 33
        '
        'cancelarButton
        '
        Me.cancelarButton.Location = New System.Drawing.Point(616, 488)
        Me.cancelarButton.Name = "cancelarButton"
        Me.cancelarButton.Size = New System.Drawing.Size(75, 23)
        Me.cancelarButton.TabIndex = 52
        Me.cancelarButton.Text = "Cancelar"
        Me.cancelarButton.UseVisualStyleBackColor = True
        '
        'aceptarButton
        '
        Me.aceptarButton.Location = New System.Drawing.Point(517, 489)
        Me.aceptarButton.Name = "aceptarButton"
        Me.aceptarButton.Size = New System.Drawing.Size(75, 23)
        Me.aceptarButton.TabIndex = 47
        Me.aceptarButton.Text = "Aceptar"
        Me.aceptarButton.UseVisualStyleBackColor = True
        '
        'AñadirPictureBox
        '
        Me.AñadirPictureBox.ErrorImage = CType(resources.GetObject("AñadirPictureBox.ErrorImage"), System.Drawing.Image)
        Me.AñadirPictureBox.Image = CType(resources.GetObject("AñadirPictureBox.Image"), System.Drawing.Image)
        Me.AñadirPictureBox.Location = New System.Drawing.Point(430, 163)
        Me.AñadirPictureBox.Name = "AñadirPictureBox"
        Me.AñadirPictureBox.Size = New System.Drawing.Size(33, 30)
        Me.AñadirPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.AñadirPictureBox.TabIndex = 51
        Me.AñadirPictureBox.TabStop = False
        '
        'tipoComboBox
        '
        Me.tipoComboBox.FormattingEnabled = True
        Me.tipoComboBox.Location = New System.Drawing.Point(324, 167)
        Me.tipoComboBox.Name = "tipoComboBox"
        Me.tipoComboBox.Size = New System.Drawing.Size(100, 21)
        Me.tipoComboBox.TabIndex = 40
        '
        'examinarButton
        '
        Me.examinarButton.Location = New System.Drawing.Point(43, 228)
        Me.examinarButton.Name = "examinarButton"
        Me.examinarButton.Size = New System.Drawing.Size(75, 23)
        Me.examinarButton.TabIndex = 43
        Me.examinarButton.Text = "Examinar"
        Me.examinarButton.UseVisualStyleBackColor = True
        '
        'FotoLabel
        '
        Me.FotoLabel.AutoSize = True
        Me.FotoLabel.Location = New System.Drawing.Point(9, 238)
        Me.FotoLabel.Name = "FotoLabel"
        Me.FotoLabel.Size = New System.Drawing.Size(28, 13)
        Me.FotoLabel.TabIndex = 50
        Me.FotoLabel.Text = "Foto"
        '
        'ObservacionesLabel
        '
        Me.ObservacionesLabel.AutoSize = True
        Me.ObservacionesLabel.Location = New System.Drawing.Point(374, 238)
        Me.ObservacionesLabel.Name = "ObservacionesLabel"
        Me.ObservacionesLabel.Size = New System.Drawing.Size(78, 13)
        Me.ObservacionesLabel.TabIndex = 49
        Me.ObservacionesLabel.Text = "Observaciones"
        '
        'FotoUsuariopictureBox
        '
        Me.FotoUsuariopictureBox.Location = New System.Drawing.Point(12, 270)
        Me.FotoUsuariopictureBox.Name = "FotoUsuariopictureBox"
        Me.FotoUsuariopictureBox.Size = New System.Drawing.Size(328, 211)
        Me.FotoUsuariopictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.FotoUsuariopictureBox.TabIndex = 48
        Me.FotoUsuariopictureBox.TabStop = False
        '
        'observacionesTextBox
        '
        Me.observacionesTextBox.Location = New System.Drawing.Point(377, 270)
        Me.observacionesTextBox.Multiline = True
        Me.observacionesTextBox.Name = "observacionesTextBox"
        Me.observacionesTextBox.Size = New System.Drawing.Size(314, 211)
        Me.observacionesTextBox.TabIndex = 44
        '
        'direccionpostalTextBox
        '
        Me.direccionpostalTextBox.Location = New System.Drawing.Point(591, 95)
        Me.direccionpostalTextBox.Name = "direccionpostalTextBox"
        Me.direccionpostalTextBox.Size = New System.Drawing.Size(100, 20)
        Me.direccionpostalTextBox.TabIndex = 37
        '
        'DirPostalLabel
        '
        Me.DirPostalLabel.AutoSize = True
        Me.DirPostalLabel.Location = New System.Drawing.Point(486, 100)
        Me.DirPostalLabel.Name = "DirPostalLabel"
        Me.DirPostalLabel.Size = New System.Drawing.Size(83, 13)
        Me.DirPostalLabel.TabIndex = 46
        Me.DirPostalLabel.Text = "Dirección postal"
        '
        'FechaNacLabel
        '
        Me.FechaNacLabel.AutoSize = True
        Me.FechaNacLabel.Location = New System.Drawing.Point(486, 30)
        Me.FechaNacLabel.Name = "FechaNacLabel"
        Me.FechaNacLabel.Size = New System.Drawing.Size(106, 13)
        Me.FechaNacLabel.TabIndex = 45
        Me.FechaNacLabel.Text = "Fecha de nacimiento"
        '
        'emailTexBox
        '
        Me.emailTexBox.Location = New System.Drawing.Point(324, 89)
        Me.emailTexBox.Name = "emailTexBox"
        Me.emailTexBox.Size = New System.Drawing.Size(100, 20)
        Me.emailTexBox.TabIndex = 35
        '
        'apellidosTextBox
        '
        Me.apellidosTextBox.Location = New System.Drawing.Point(324, 23)
        Me.apellidosTextBox.Name = "apellidosTextBox"
        Me.apellidosTextBox.Size = New System.Drawing.Size(100, 20)
        Me.apellidosTextBox.TabIndex = 32
        '
        'TipoLabel
        '
        Me.TipoLabel.AutoSize = True
        Me.TipoLabel.Location = New System.Drawing.Point(250, 175)
        Me.TipoLabel.Name = "TipoLabel"
        Me.TipoLabel.Size = New System.Drawing.Size(28, 13)
        Me.TipoLabel.TabIndex = 41
        Me.TipoLabel.Text = "Tipo"
        '
        'EmailLabel
        '
        Me.EmailLabel.AutoSize = True
        Me.EmailLabel.Location = New System.Drawing.Point(250, 96)
        Me.EmailLabel.Name = "EmailLabel"
        Me.EmailLabel.Size = New System.Drawing.Size(35, 13)
        Me.EmailLabel.TabIndex = 38
        Me.EmailLabel.Text = "E-mail"
        '
        'ApellidosLabel
        '
        Me.ApellidosLabel.AutoSize = True
        Me.ApellidosLabel.Location = New System.Drawing.Point(250, 30)
        Me.ApellidosLabel.Name = "ApellidosLabel"
        Me.ApellidosLabel.Size = New System.Drawing.Size(49, 13)
        Me.ApellidosLabel.TabIndex = 36
        Me.ApellidosLabel.Text = "Apellidos"
        '
        'organizacionTextBox
        '
        Me.organizacionTextBox.Location = New System.Drawing.Point(84, 163)
        Me.organizacionTextBox.Name = "organizacionTextBox"
        Me.organizacionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.organizacionTextBox.TabIndex = 39
        '
        'telefonoTextBox
        '
        Me.telefonoTextBox.Location = New System.Drawing.Point(84, 88)
        Me.telefonoTextBox.Name = "telefonoTextBox"
        Me.telefonoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.telefonoTextBox.TabIndex = 34
        '
        'nombreTextBox
        '
        Me.nombreTextBox.Location = New System.Drawing.Point(84, 22)
        Me.nombreTextBox.Name = "nombreTextBox"
        Me.nombreTextBox.Size = New System.Drawing.Size(100, 20)
        Me.nombreTextBox.TabIndex = 29
        '
        'OrganizacionLabel
        '
        Me.OrganizacionLabel.AutoSize = True
        Me.OrganizacionLabel.Location = New System.Drawing.Point(9, 170)
        Me.OrganizacionLabel.Name = "OrganizacionLabel"
        Me.OrganizacionLabel.Size = New System.Drawing.Size(69, 13)
        Me.OrganizacionLabel.TabIndex = 31
        Me.OrganizacionLabel.Text = "Organización"
        '
        'TelefonoLabel
        '
        Me.TelefonoLabel.AutoSize = True
        Me.TelefonoLabel.Location = New System.Drawing.Point(9, 95)
        Me.TelefonoLabel.Name = "TelefonoLabel"
        Me.TelefonoLabel.Size = New System.Drawing.Size(49, 13)
        Me.TelefonoLabel.TabIndex = 30
        Me.TelefonoLabel.Text = "Teléfono"
        '
        'NombreLabel
        '
        Me.NombreLabel.AutoSize = True
        Me.NombreLabel.Location = New System.Drawing.Point(9, 29)
        Me.NombreLabel.Name = "NombreLabel"
        Me.NombreLabel.Size = New System.Drawing.Size(44, 13)
        Me.NombreLabel.TabIndex = 28
        Me.NombreLabel.Text = "Nombre"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'EmailErrorProvider
        '
        Me.EmailErrorProvider.ContainerControl = Me
        '
        'ErrorProvider2
        '
        Me.ErrorProvider2.ContainerControl = Me
        '
        'TratarUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(707, 535)
        Me.Controls.Add(Me.AñadirTipoUsuarioButton)
        Me.Controls.Add(Me.AñadirTipoUsuarioTextBox)
        Me.Controls.Add(Me.FechaNacimientoDateTimePicker)
        Me.Controls.Add(Me.cancelarButton)
        Me.Controls.Add(Me.aceptarButton)
        Me.Controls.Add(Me.AñadirPictureBox)
        Me.Controls.Add(Me.tipoComboBox)
        Me.Controls.Add(Me.examinarButton)
        Me.Controls.Add(Me.FotoLabel)
        Me.Controls.Add(Me.ObservacionesLabel)
        Me.Controls.Add(Me.FotoUsuariopictureBox)
        Me.Controls.Add(Me.observacionesTextBox)
        Me.Controls.Add(Me.direccionpostalTextBox)
        Me.Controls.Add(Me.DirPostalLabel)
        Me.Controls.Add(Me.FechaNacLabel)
        Me.Controls.Add(Me.emailTexBox)
        Me.Controls.Add(Me.apellidosTextBox)
        Me.Controls.Add(Me.TipoLabel)
        Me.Controls.Add(Me.EmailLabel)
        Me.Controls.Add(Me.ApellidosLabel)
        Me.Controls.Add(Me.organizacionTextBox)
        Me.Controls.Add(Me.telefonoTextBox)
        Me.Controls.Add(Me.nombreTextBox)
        Me.Controls.Add(Me.OrganizacionLabel)
        Me.Controls.Add(Me.TelefonoLabel)
        Me.Controls.Add(Me.NombreLabel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "TratarUsuario"
        Me.Text = "Tratar usuario"
        CType(Me.AñadirPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FotoUsuariopictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmailErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AñadirTipoUsuarioButton As Button
    Friend WithEvents AñadirTipoUsuarioTextBox As TextBox
    Friend WithEvents FechaNacimientoDateTimePicker As DateTimePicker
    Friend WithEvents cancelarButton As Button
    Friend WithEvents aceptarButton As Button
    Friend WithEvents AñadirPictureBox As PictureBox
    Friend WithEvents tipoComboBox As ComboBox
    Friend WithEvents examinarButton As Button
    Friend WithEvents FotoLabel As Label
    Friend WithEvents ObservacionesLabel As Label
    Friend WithEvents FotoUsuariopictureBox As PictureBox
    Friend WithEvents observacionesTextBox As TextBox
    Friend WithEvents direccionpostalTextBox As TextBox
    Friend WithEvents DirPostalLabel As Label
    Friend WithEvents FechaNacLabel As Label
    Friend WithEvents emailTexBox As TextBox
    Friend WithEvents apellidosTextBox As TextBox
    Friend WithEvents TipoLabel As Label
    Friend WithEvents EmailLabel As Label
    Friend WithEvents ApellidosLabel As Label
    Friend WithEvents organizacionTextBox As TextBox
    Friend WithEvents telefonoTextBox As TextBox
    Friend WithEvents nombreTextBox As TextBox
    Friend WithEvents OrganizacionLabel As Label
    Friend WithEvents TelefonoLabel As Label
    Friend WithEvents NombreLabel As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents EmailErrorProvider As ErrorProvider
    Friend WithEvents ErrorProvider2 As ErrorProvider
End Class
