<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NuevoUsuario
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
        Me.components = New System.ComponentModel.Container()
        Me.NombreLabel = New System.Windows.Forms.Label()
        Me.TelefonoLabel = New System.Windows.Forms.Label()
        Me.OrganizacionLabel = New System.Windows.Forms.Label()
        Me.nombreTextBox = New System.Windows.Forms.TextBox()
        Me.telefonoTextBox = New System.Windows.Forms.TextBox()
        Me.organizacionTextBox = New System.Windows.Forms.TextBox()
        Me.emailTexBox = New System.Windows.Forms.TextBox()
        Me.apellidosTextBox = New System.Windows.Forms.TextBox()
        Me.TipoLabel = New System.Windows.Forms.Label()
        Me.EmailLabel = New System.Windows.Forms.Label()
        Me.ApellidosLabel = New System.Windows.Forms.Label()
        Me.direccionpostalTextBox = New System.Windows.Forms.TextBox()
        Me.DirPostalLabel = New System.Windows.Forms.Label()
        Me.FechaNacLabel = New System.Windows.Forms.Label()
        Me.obersacionesTextBox = New System.Windows.Forms.TextBox()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ObservacionesLabel = New System.Windows.Forms.Label()
        Me.FotoLabel = New System.Windows.Forms.Label()
        Me.examinarButton = New System.Windows.Forms.Button()
        Me.tipoComboBox = New System.Windows.Forms.ComboBox()
        Me.AñadirPictureBox = New System.Windows.Forms.PictureBox()
        Me.aceptarButton = New System.Windows.Forms.Button()
        Me.cancelarButton = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.AñadirTipoUsuarioTextBox = New System.Windows.Forms.TextBox()
        Me.AñadirTipoUsuarioButton = New System.Windows.Forms.Button()
        Me.EmailErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AñadirPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmailErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NombreLabel
        '
        Me.NombreLabel.AutoSize = True
        Me.NombreLabel.Location = New System.Drawing.Point(29, 28)
        Me.NombreLabel.Name = "NombreLabel"
        Me.NombreLabel.Size = New System.Drawing.Size(44, 13)
        Me.NombreLabel.TabIndex = 0
        Me.NombreLabel.Text = "Nombre"
        '
        'TelefonoLabel
        '
        Me.TelefonoLabel.AutoSize = True
        Me.TelefonoLabel.Location = New System.Drawing.Point(29, 94)
        Me.TelefonoLabel.Name = "TelefonoLabel"
        Me.TelefonoLabel.Size = New System.Drawing.Size(49, 13)
        Me.TelefonoLabel.TabIndex = 1
        Me.TelefonoLabel.Text = "Teléfono"
        '
        'OrganizacionLabel
        '
        Me.OrganizacionLabel.AutoSize = True
        Me.OrganizacionLabel.Location = New System.Drawing.Point(29, 169)
        Me.OrganizacionLabel.Name = "OrganizacionLabel"
        Me.OrganizacionLabel.Size = New System.Drawing.Size(69, 13)
        Me.OrganizacionLabel.TabIndex = 2
        Me.OrganizacionLabel.Text = "Organización"
        '
        'nombreTextBox
        '
        Me.nombreTextBox.Location = New System.Drawing.Point(104, 21)
        Me.nombreTextBox.Name = "nombreTextBox"
        Me.nombreTextBox.Size = New System.Drawing.Size(100, 20)
        Me.nombreTextBox.TabIndex = 1
        '
        'telefonoTextBox
        '
        Me.telefonoTextBox.Location = New System.Drawing.Point(104, 87)
        Me.telefonoTextBox.Name = "telefonoTextBox"
        Me.telefonoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.telefonoTextBox.TabIndex = 4
        '
        'organizacionTextBox
        '
        Me.organizacionTextBox.Location = New System.Drawing.Point(104, 162)
        Me.organizacionTextBox.Name = "organizacionTextBox"
        Me.organizacionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.organizacionTextBox.TabIndex = 7
        '
        'emailTexBox
        '
        Me.emailTexBox.Location = New System.Drawing.Point(344, 88)
        Me.emailTexBox.Name = "emailTexBox"
        Me.emailTexBox.Size = New System.Drawing.Size(100, 20)
        Me.emailTexBox.TabIndex = 5
        '
        'apellidosTextBox
        '
        Me.apellidosTextBox.Location = New System.Drawing.Point(344, 22)
        Me.apellidosTextBox.Name = "apellidosTextBox"
        Me.apellidosTextBox.Size = New System.Drawing.Size(100, 20)
        Me.apellidosTextBox.TabIndex = 2
        '
        'TipoLabel
        '
        Me.TipoLabel.AutoSize = True
        Me.TipoLabel.Location = New System.Drawing.Point(270, 174)
        Me.TipoLabel.Name = "TipoLabel"
        Me.TipoLabel.Size = New System.Drawing.Size(28, 13)
        Me.TipoLabel.TabIndex = 8
        Me.TipoLabel.Text = "Tipo"
        '
        'EmailLabel
        '
        Me.EmailLabel.AutoSize = True
        Me.EmailLabel.Location = New System.Drawing.Point(270, 95)
        Me.EmailLabel.Name = "EmailLabel"
        Me.EmailLabel.Size = New System.Drawing.Size(35, 13)
        Me.EmailLabel.TabIndex = 7
        Me.EmailLabel.Text = "E-mail"
        '
        'ApellidosLabel
        '
        Me.ApellidosLabel.AutoSize = True
        Me.ApellidosLabel.Location = New System.Drawing.Point(270, 29)
        Me.ApellidosLabel.Name = "ApellidosLabel"
        Me.ApellidosLabel.Size = New System.Drawing.Size(49, 13)
        Me.ApellidosLabel.TabIndex = 6
        Me.ApellidosLabel.Text = "Apellidos"
        '
        'direccionpostalTextBox
        '
        Me.direccionpostalTextBox.Location = New System.Drawing.Point(611, 94)
        Me.direccionpostalTextBox.Name = "direccionpostalTextBox"
        Me.direccionpostalTextBox.Size = New System.Drawing.Size(100, 20)
        Me.direccionpostalTextBox.TabIndex = 6
        '
        'DirPostalLabel
        '
        Me.DirPostalLabel.AutoSize = True
        Me.DirPostalLabel.Location = New System.Drawing.Point(506, 99)
        Me.DirPostalLabel.Name = "DirPostalLabel"
        Me.DirPostalLabel.Size = New System.Drawing.Size(83, 13)
        Me.DirPostalLabel.TabIndex = 12
        Me.DirPostalLabel.Text = "Dirección postal"
        '
        'FechaNacLabel
        '
        Me.FechaNacLabel.AutoSize = True
        Me.FechaNacLabel.Location = New System.Drawing.Point(506, 29)
        Me.FechaNacLabel.Name = "FechaNacLabel"
        Me.FechaNacLabel.Size = New System.Drawing.Size(106, 13)
        Me.FechaNacLabel.TabIndex = 11
        Me.FechaNacLabel.Text = "Fecha de nacimiento"
        '
        'obersacionesTextBox
        '
        Me.obersacionesTextBox.Location = New System.Drawing.Point(397, 269)
        Me.obersacionesTextBox.Multiline = True
        Me.obersacionesTextBox.Name = "obersacionesTextBox"
        Me.obersacionesTextBox.Size = New System.Drawing.Size(314, 211)
        Me.obersacionesTextBox.TabIndex = 11
        '
        'pictureBox1
        '
        Me.pictureBox1.Location = New System.Drawing.Point(32, 269)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(328, 211)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox1.TabIndex = 17
        Me.pictureBox1.TabStop = False
        '
        'ObservacionesLabel
        '
        Me.ObservacionesLabel.AutoSize = True
        Me.ObservacionesLabel.Location = New System.Drawing.Point(394, 237)
        Me.ObservacionesLabel.Name = "ObservacionesLabel"
        Me.ObservacionesLabel.Size = New System.Drawing.Size(78, 13)
        Me.ObservacionesLabel.TabIndex = 18
        Me.ObservacionesLabel.Text = "Observaciones"
        '
        'FotoLabel
        '
        Me.FotoLabel.AutoSize = True
        Me.FotoLabel.Location = New System.Drawing.Point(29, 237)
        Me.FotoLabel.Name = "FotoLabel"
        Me.FotoLabel.Size = New System.Drawing.Size(28, 13)
        Me.FotoLabel.TabIndex = 19
        Me.FotoLabel.Text = "Foto"
        '
        'examinarButton
        '
        Me.examinarButton.Location = New System.Drawing.Point(63, 227)
        Me.examinarButton.Name = "examinarButton"
        Me.examinarButton.Size = New System.Drawing.Size(75, 23)
        Me.examinarButton.TabIndex = 10
        Me.examinarButton.Text = "Examinar"
        Me.examinarButton.UseVisualStyleBackColor = True
        '
        'tipoComboBox
        '
        Me.tipoComboBox.FormattingEnabled = True
        Me.tipoComboBox.Location = New System.Drawing.Point(344, 166)
        Me.tipoComboBox.Name = "tipoComboBox"
        Me.tipoComboBox.Size = New System.Drawing.Size(100, 21)
        Me.tipoComboBox.TabIndex = 8
        '
        'AñadirPictureBox
        '
        Me.AñadirPictureBox.Image = Global.FabLabJR.My.Resources.Resources._32360
        Me.AñadirPictureBox.Location = New System.Drawing.Point(450, 162)
        Me.AñadirPictureBox.Name = "AñadirPictureBox"
        Me.AñadirPictureBox.Size = New System.Drawing.Size(33, 30)
        Me.AñadirPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.AñadirPictureBox.TabIndex = 22
        Me.AñadirPictureBox.TabStop = False
        '
        'aceptarButton
        '
        Me.aceptarButton.Location = New System.Drawing.Point(537, 488)
        Me.aceptarButton.Name = "aceptarButton"
        Me.aceptarButton.Size = New System.Drawing.Size(75, 23)
        Me.aceptarButton.TabIndex = 12
        Me.aceptarButton.Text = "Aceptar"
        Me.aceptarButton.UseVisualStyleBackColor = True
        '
        'cancelarButton
        '
        Me.cancelarButton.Location = New System.Drawing.Point(636, 487)
        Me.cancelarButton.Name = "cancelarButton"
        Me.cancelarButton.Size = New System.Drawing.Size(75, 23)
        Me.cancelarButton.TabIndex = 24
        Me.cancelarButton.Text = "Cancelar"
        Me.cancelarButton.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(611, 23)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(100, 20)
        Me.DateTimePicker1.TabIndex = 3
        '
        'AñadirTipoUsuarioTextBox
        '
        Me.AñadirTipoUsuarioTextBox.Location = New System.Drawing.Point(344, 199)
        Me.AñadirTipoUsuarioTextBox.Name = "AñadirTipoUsuarioTextBox"
        Me.AñadirTipoUsuarioTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AñadirTipoUsuarioTextBox.TabIndex = 9
        '
        'AñadirTipoUsuarioButton
        '
        Me.AñadirTipoUsuarioButton.Location = New System.Drawing.Point(450, 198)
        Me.AñadirTipoUsuarioButton.Name = "AñadirTipoUsuarioButton"
        Me.AñadirTipoUsuarioButton.Size = New System.Drawing.Size(75, 23)
        Me.AñadirTipoUsuarioButton.TabIndex = 27
        Me.AñadirTipoUsuarioButton.Text = "Añadir"
        Me.AñadirTipoUsuarioButton.UseVisualStyleBackColor = True
        '
        'EmailErrorProvider
        '
        Me.EmailErrorProvider.ContainerControl = Me
        '
        'NuevoUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(751, 521)
        Me.Controls.Add(Me.AñadirTipoUsuarioButton)
        Me.Controls.Add(Me.AñadirTipoUsuarioTextBox)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.cancelarButton)
        Me.Controls.Add(Me.aceptarButton)
        Me.Controls.Add(Me.AñadirPictureBox)
        Me.Controls.Add(Me.tipoComboBox)
        Me.Controls.Add(Me.examinarButton)
        Me.Controls.Add(Me.FotoLabel)
        Me.Controls.Add(Me.ObservacionesLabel)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.obersacionesTextBox)
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
        Me.Name = "NuevoUsuario"
        Me.Text = "NuevoUsuario"
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AñadirPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmailErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NombreLabel As Label
    Friend WithEvents TelefonoLabel As Label
    Friend WithEvents OrganizacionLabel As Label
    Friend WithEvents nombreTextBox As TextBox
    Friend WithEvents telefonoTextBox As TextBox
    Friend WithEvents organizacionTextBox As TextBox
    Friend WithEvents emailTexBox As TextBox
    Friend WithEvents apellidosTextBox As TextBox
    Friend WithEvents TipoLabel As Label
    Friend WithEvents EmailLabel As Label
    Friend WithEvents ApellidosLabel As Label
    Friend WithEvents direccionpostalTextBox As TextBox
    Friend WithEvents DirPostalLabel As Label
    Friend WithEvents FechaNacLabel As Label
    Friend WithEvents obersacionesTextBox As TextBox
    Friend WithEvents pictureBox1 As PictureBox
    Friend WithEvents ObservacionesLabel As Label
    Friend WithEvents FotoLabel As Label
    Friend WithEvents examinarButton As Button
    Friend WithEvents tipoComboBox As ComboBox
    Friend WithEvents AñadirPictureBox As PictureBox
    Friend WithEvents aceptarButton As Button
    Friend WithEvents cancelarButton As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents AñadirTipoUsuarioTextBox As TextBox
    Friend WithEvents AñadirTipoUsuarioButton As Button
    Friend WithEvents EmailErrorProvider As ErrorProvider
End Class
