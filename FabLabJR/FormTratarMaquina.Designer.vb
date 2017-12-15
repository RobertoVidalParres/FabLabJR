<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTratarMaquina
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
        Me.ImagenesMaquinaFlowLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.CaracteristicasMaquinaTextBox = New System.Windows.Forms.TextBox()
        Me.DescripcionMaquinaTextBox = New System.Windows.Forms.TextBox()
        Me.TipoMaquinaComboBox = New System.Windows.Forms.ComboBox()
        Me.FechaCompraMaquinaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TelefonoSatMaquinaMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.PrecioHoraMaquinaTextBox = New System.Windows.Forms.TextBox()
        Me.ModeloMaquinaTextBox = New System.Windows.Forms.TextBox()
        Me.ImagenesMaquinaLabel = New System.Windows.Forms.Label()
        Me.CaracteristicasMaquinaLabel = New System.Windows.Forms.Label()
        Me.DescripcionMaquinaLabel = New System.Windows.Forms.Label()
        Me.FechaCompraMaquinaLabel = New System.Windows.Forms.Label()
        Me.TipoMaquinaLabel = New System.Windows.Forms.Label()
        Me.PrecioHoraMaquinaLabel = New System.Windows.Forms.Label()
        Me.TelefonoSatMaquinaLabel = New System.Windows.Forms.Label()
        Me.ModeloMaquinaLabel = New System.Windows.Forms.Label()
        Me.AceptarMaquinaButton = New System.Windows.Forms.Button()
        Me.CancelarMaquinaButton = New System.Windows.Forms.Button()
        Me.TipoMaquinaPictureBox = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ExaminarImagenesMaquinaButton = New System.Windows.Forms.Button()
        CType(Me.TipoMaquinaPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImagenesMaquinaFlowLayoutPanel
        '
        Me.ImagenesMaquinaFlowLayoutPanel.AutoScroll = True
        Me.ImagenesMaquinaFlowLayoutPanel.Location = New System.Drawing.Point(27, 280)
        Me.ImagenesMaquinaFlowLayoutPanel.Name = "ImagenesMaquinaFlowLayoutPanel"
        Me.ImagenesMaquinaFlowLayoutPanel.Size = New System.Drawing.Size(685, 100)
        Me.ImagenesMaquinaFlowLayoutPanel.TabIndex = 33
        '
        'CaracteristicasMaquinaTextBox
        '
        Me.CaracteristicasMaquinaTextBox.Location = New System.Drawing.Point(382, 138)
        Me.CaracteristicasMaquinaTextBox.Multiline = True
        Me.CaracteristicasMaquinaTextBox.Name = "CaracteristicasMaquinaTextBox"
        Me.CaracteristicasMaquinaTextBox.Size = New System.Drawing.Size(330, 99)
        Me.CaracteristicasMaquinaTextBox.TabIndex = 32
        '
        'DescripcionMaquinaTextBox
        '
        Me.DescripcionMaquinaTextBox.Location = New System.Drawing.Point(27, 138)
        Me.DescripcionMaquinaTextBox.Multiline = True
        Me.DescripcionMaquinaTextBox.Name = "DescripcionMaquinaTextBox"
        Me.DescripcionMaquinaTextBox.Size = New System.Drawing.Size(330, 99)
        Me.DescripcionMaquinaTextBox.TabIndex = 31
        '
        'TipoMaquinaComboBox
        '
        Me.TipoMaquinaComboBox.FormattingEnabled = True
        Me.TipoMaquinaComboBox.Location = New System.Drawing.Point(346, 66)
        Me.TipoMaquinaComboBox.Name = "TipoMaquinaComboBox"
        Me.TipoMaquinaComboBox.Size = New System.Drawing.Size(100, 21)
        Me.TipoMaquinaComboBox.TabIndex = 30
        '
        'FechaCompraMaquinaDateTimePicker
        '
        Me.FechaCompraMaquinaDateTimePicker.Location = New System.Drawing.Point(563, 35)
        Me.FechaCompraMaquinaDateTimePicker.Name = "FechaCompraMaquinaDateTimePicker"
        Me.FechaCompraMaquinaDateTimePicker.Size = New System.Drawing.Size(198, 20)
        Me.FechaCompraMaquinaDateTimePicker.TabIndex = 29
        '
        'TelefonoSatMaquinaMaskedTextBox
        '
        Me.TelefonoSatMaquinaMaskedTextBox.Location = New System.Drawing.Point(126, 66)
        Me.TelefonoSatMaquinaMaskedTextBox.Mask = "(999)000-0000"
        Me.TelefonoSatMaquinaMaskedTextBox.Name = "TelefonoSatMaquinaMaskedTextBox"
        Me.TelefonoSatMaquinaMaskedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TelefonoSatMaquinaMaskedTextBox.TabIndex = 28
        '
        'PrecioHoraMaquinaTextBox
        '
        Me.PrecioHoraMaquinaTextBox.Location = New System.Drawing.Point(346, 35)
        Me.PrecioHoraMaquinaTextBox.Name = "PrecioHoraMaquinaTextBox"
        Me.PrecioHoraMaquinaTextBox.Size = New System.Drawing.Size(62, 20)
        Me.PrecioHoraMaquinaTextBox.TabIndex = 27
        '
        'ModeloMaquinaTextBox
        '
        Me.ModeloMaquinaTextBox.Location = New System.Drawing.Point(126, 32)
        Me.ModeloMaquinaTextBox.Name = "ModeloMaquinaTextBox"
        Me.ModeloMaquinaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ModeloMaquinaTextBox.TabIndex = 26
        '
        'ImagenesMaquinaLabel
        '
        Me.ImagenesMaquinaLabel.AutoSize = True
        Me.ImagenesMaquinaLabel.Location = New System.Drawing.Point(24, 255)
        Me.ImagenesMaquinaLabel.Name = "ImagenesMaquinaLabel"
        Me.ImagenesMaquinaLabel.Size = New System.Drawing.Size(53, 13)
        Me.ImagenesMaquinaLabel.TabIndex = 25
        Me.ImagenesMaquinaLabel.Text = "Imágenes"
        '
        'CaracteristicasMaquinaLabel
        '
        Me.CaracteristicasMaquinaLabel.AutoSize = True
        Me.CaracteristicasMaquinaLabel.Location = New System.Drawing.Point(379, 112)
        Me.CaracteristicasMaquinaLabel.Name = "CaracteristicasMaquinaLabel"
        Me.CaracteristicasMaquinaLabel.Size = New System.Drawing.Size(121, 13)
        Me.CaracteristicasMaquinaLabel.TabIndex = 24
        Me.CaracteristicasMaquinaLabel.Text = "Características técnicas"
        '
        'DescripcionMaquinaLabel
        '
        Me.DescripcionMaquinaLabel.AutoSize = True
        Me.DescripcionMaquinaLabel.Location = New System.Drawing.Point(24, 112)
        Me.DescripcionMaquinaLabel.Name = "DescripcionMaquinaLabel"
        Me.DescripcionMaquinaLabel.Size = New System.Drawing.Size(63, 13)
        Me.DescripcionMaquinaLabel.TabIndex = 23
        Me.DescripcionMaquinaLabel.Text = "Descripción"
        '
        'FechaCompraMaquinaLabel
        '
        Me.FechaCompraMaquinaLabel.AutoSize = True
        Me.FechaCompraMaquinaLabel.Location = New System.Drawing.Point(455, 38)
        Me.FechaCompraMaquinaLabel.Name = "FechaCompraMaquinaLabel"
        Me.FechaCompraMaquinaLabel.Size = New System.Drawing.Size(90, 13)
        Me.FechaCompraMaquinaLabel.TabIndex = 22
        Me.FechaCompraMaquinaLabel.Text = "Fecha de compra"
        '
        'TipoMaquinaLabel
        '
        Me.TipoMaquinaLabel.AutoSize = True
        Me.TipoMaquinaLabel.Location = New System.Drawing.Point(254, 69)
        Me.TipoMaquinaLabel.Name = "TipoMaquinaLabel"
        Me.TipoMaquinaLabel.Size = New System.Drawing.Size(28, 13)
        Me.TipoMaquinaLabel.TabIndex = 21
        Me.TipoMaquinaLabel.Text = "Tipo"
        '
        'PrecioHoraMaquinaLabel
        '
        Me.PrecioHoraMaquinaLabel.AutoSize = True
        Me.PrecioHoraMaquinaLabel.Location = New System.Drawing.Point(254, 35)
        Me.PrecioHoraMaquinaLabel.Name = "PrecioHoraMaquinaLabel"
        Me.PrecioHoraMaquinaLabel.Size = New System.Drawing.Size(63, 13)
        Me.PrecioHoraMaquinaLabel.TabIndex = 20
        Me.PrecioHoraMaquinaLabel.Text = "Precio/hora"
        '
        'TelefonoSatMaquinaLabel
        '
        Me.TelefonoSatMaquinaLabel.AutoSize = True
        Me.TelefonoSatMaquinaLabel.Location = New System.Drawing.Point(24, 69)
        Me.TelefonoSatMaquinaLabel.Name = "TelefonoSatMaquinaLabel"
        Me.TelefonoSatMaquinaLabel.Size = New System.Drawing.Size(73, 13)
        Me.TelefonoSatMaquinaLabel.TabIndex = 19
        Me.TelefonoSatMaquinaLabel.Text = "Teléfono SAT"
        '
        'ModeloMaquinaLabel
        '
        Me.ModeloMaquinaLabel.AutoSize = True
        Me.ModeloMaquinaLabel.Location = New System.Drawing.Point(24, 35)
        Me.ModeloMaquinaLabel.Name = "ModeloMaquinaLabel"
        Me.ModeloMaquinaLabel.Size = New System.Drawing.Size(42, 13)
        Me.ModeloMaquinaLabel.TabIndex = 18
        Me.ModeloMaquinaLabel.Text = "Modelo"
        '
        'AceptarMaquinaButton
        '
        Me.AceptarMaquinaButton.Location = New System.Drawing.Point(653, 402)
        Me.AceptarMaquinaButton.Name = "AceptarMaquinaButton"
        Me.AceptarMaquinaButton.Size = New System.Drawing.Size(75, 23)
        Me.AceptarMaquinaButton.TabIndex = 36
        Me.AceptarMaquinaButton.Text = "Aceptar"
        Me.AceptarMaquinaButton.UseVisualStyleBackColor = True
        '
        'CancelarMaquinaButton
        '
        Me.CancelarMaquinaButton.Location = New System.Drawing.Point(743, 402)
        Me.CancelarMaquinaButton.Name = "CancelarMaquinaButton"
        Me.CancelarMaquinaButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelarMaquinaButton.TabIndex = 37
        Me.CancelarMaquinaButton.Text = "Cancelar"
        Me.CancelarMaquinaButton.UseVisualStyleBackColor = True
        '
        'TipoMaquinaPictureBox
        '
        Me.TipoMaquinaPictureBox.Image = Global.FabLabJR.My.Resources.Resources.plus_TratarMaquina
        Me.TipoMaquinaPictureBox.Location = New System.Drawing.Point(458, 66)
        Me.TipoMaquinaPictureBox.Name = "TipoMaquinaPictureBox"
        Me.TipoMaquinaPictureBox.Size = New System.Drawing.Size(28, 28)
        Me.TipoMaquinaPictureBox.TabIndex = 38
        Me.TipoMaquinaPictureBox.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ExaminarImagenesMaquinaButton
        '
        Me.ExaminarImagenesMaquinaButton.Location = New System.Drawing.Point(102, 250)
        Me.ExaminarImagenesMaquinaButton.Name = "ExaminarImagenesMaquinaButton"
        Me.ExaminarImagenesMaquinaButton.Size = New System.Drawing.Size(75, 23)
        Me.ExaminarImagenesMaquinaButton.TabIndex = 39
        Me.ExaminarImagenesMaquinaButton.Text = "Examinar"
        Me.ExaminarImagenesMaquinaButton.UseVisualStyleBackColor = True
        '
        'FormTratarMaquina
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(841, 451)
        Me.Controls.Add(Me.ExaminarImagenesMaquinaButton)
        Me.Controls.Add(Me.TipoMaquinaPictureBox)
        Me.Controls.Add(Me.CancelarMaquinaButton)
        Me.Controls.Add(Me.AceptarMaquinaButton)
        Me.Controls.Add(Me.ImagenesMaquinaFlowLayoutPanel)
        Me.Controls.Add(Me.CaracteristicasMaquinaTextBox)
        Me.Controls.Add(Me.DescripcionMaquinaTextBox)
        Me.Controls.Add(Me.TipoMaquinaComboBox)
        Me.Controls.Add(Me.FechaCompraMaquinaDateTimePicker)
        Me.Controls.Add(Me.TelefonoSatMaquinaMaskedTextBox)
        Me.Controls.Add(Me.PrecioHoraMaquinaTextBox)
        Me.Controls.Add(Me.ModeloMaquinaTextBox)
        Me.Controls.Add(Me.ImagenesMaquinaLabel)
        Me.Controls.Add(Me.CaracteristicasMaquinaLabel)
        Me.Controls.Add(Me.DescripcionMaquinaLabel)
        Me.Controls.Add(Me.FechaCompraMaquinaLabel)
        Me.Controls.Add(Me.TipoMaquinaLabel)
        Me.Controls.Add(Me.PrecioHoraMaquinaLabel)
        Me.Controls.Add(Me.TelefonoSatMaquinaLabel)
        Me.Controls.Add(Me.ModeloMaquinaLabel)
        Me.Name = "FormTratarMaquina"
        Me.Text = "FormTratarMaquina"
        CType(Me.TipoMaquinaPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ImagenesMaquinaFlowLayoutPanel As FlowLayoutPanel
    Friend WithEvents CaracteristicasMaquinaTextBox As TextBox
    Friend WithEvents DescripcionMaquinaTextBox As TextBox
    Friend WithEvents TipoMaquinaComboBox As ComboBox
    Friend WithEvents FechaCompraMaquinaDateTimePicker As DateTimePicker
    Friend WithEvents TelefonoSatMaquinaMaskedTextBox As MaskedTextBox
    Friend WithEvents PrecioHoraMaquinaTextBox As TextBox
    Friend WithEvents ModeloMaquinaTextBox As TextBox
    Friend WithEvents ImagenesMaquinaLabel As Label
    Friend WithEvents CaracteristicasMaquinaLabel As Label
    Friend WithEvents DescripcionMaquinaLabel As Label
    Friend WithEvents FechaCompraMaquinaLabel As Label
    Friend WithEvents TipoMaquinaLabel As Label
    Friend WithEvents PrecioHoraMaquinaLabel As Label
    Friend WithEvents TelefonoSatMaquinaLabel As Label
    Friend WithEvents ModeloMaquinaLabel As Label
    Friend WithEvents AceptarMaquinaButton As Button
    Friend WithEvents CancelarMaquinaButton As Button
    Friend WithEvents TipoMaquinaPictureBox As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ExaminarImagenesMaquinaButton As Button
End Class
