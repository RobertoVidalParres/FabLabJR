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
        Me.ImagenesFlowLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.CaracteristicasTextBox = New System.Windows.Forms.TextBox()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.TipoComboBox = New System.Windows.Forms.ComboBox()
        Me.FechaCompraDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TelefonoSatMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.PrecioHoraTextBox = New System.Windows.Forms.TextBox()
        Me.ModeloTextBox = New System.Windows.Forms.TextBox()
        Me.ImagenesLabel = New System.Windows.Forms.Label()
        Me.CaracteristicasLabel = New System.Windows.Forms.Label()
        Me.DescripcionLabel = New System.Windows.Forms.Label()
        Me.FechaCompraLabel = New System.Windows.Forms.Label()
        Me.TipoLabel = New System.Windows.Forms.Label()
        Me.PrecioHoraLabel = New System.Windows.Forms.Label()
        Me.TelefonoSatLabel = New System.Windows.Forms.Label()
        Me.ModeloLabelNuevaMaquina = New System.Windows.Forms.Label()
        Me.AceptarButton = New System.Windows.Forms.Button()
        Me.CancelarButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImagenesFlowLayoutPanel
        '
        Me.ImagenesFlowLayoutPanel.Location = New System.Drawing.Point(27, 280)
        Me.ImagenesFlowLayoutPanel.Name = "ImagenesFlowLayoutPanel"
        Me.ImagenesFlowLayoutPanel.Size = New System.Drawing.Size(685, 100)
        Me.ImagenesFlowLayoutPanel.TabIndex = 33
        '
        'CaracteristicasTextBox
        '
        Me.CaracteristicasTextBox.Location = New System.Drawing.Point(382, 138)
        Me.CaracteristicasTextBox.Multiline = True
        Me.CaracteristicasTextBox.Name = "CaracteristicasTextBox"
        Me.CaracteristicasTextBox.Size = New System.Drawing.Size(330, 99)
        Me.CaracteristicasTextBox.TabIndex = 32
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.Location = New System.Drawing.Point(27, 138)
        Me.DescripcionTextBox.Multiline = True
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(330, 99)
        Me.DescripcionTextBox.TabIndex = 31
        '
        'TipoComboBox
        '
        Me.TipoComboBox.FormattingEnabled = True
        Me.TipoComboBox.Location = New System.Drawing.Point(346, 66)
        Me.TipoComboBox.Name = "TipoComboBox"
        Me.TipoComboBox.Size = New System.Drawing.Size(100, 21)
        Me.TipoComboBox.TabIndex = 30
        '
        'FechaCompraDateTimePicker
        '
        Me.FechaCompraDateTimePicker.Location = New System.Drawing.Point(563, 35)
        Me.FechaCompraDateTimePicker.Name = "FechaCompraDateTimePicker"
        Me.FechaCompraDateTimePicker.Size = New System.Drawing.Size(198, 20)
        Me.FechaCompraDateTimePicker.TabIndex = 29
        '
        'TelefonoSatMaskedTextBox
        '
        Me.TelefonoSatMaskedTextBox.Location = New System.Drawing.Point(126, 66)
        Me.TelefonoSatMaskedTextBox.Name = "TelefonoSatMaskedTextBox"
        Me.TelefonoSatMaskedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TelefonoSatMaskedTextBox.TabIndex = 28
        '
        'PrecioHoraTextBox
        '
        Me.PrecioHoraTextBox.Location = New System.Drawing.Point(346, 35)
        Me.PrecioHoraTextBox.Name = "PrecioHoraTextBox"
        Me.PrecioHoraTextBox.Size = New System.Drawing.Size(62, 20)
        Me.PrecioHoraTextBox.TabIndex = 27
        '
        'ModeloTextBox
        '
        Me.ModeloTextBox.Location = New System.Drawing.Point(126, 32)
        Me.ModeloTextBox.Name = "ModeloTextBox"
        Me.ModeloTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ModeloTextBox.TabIndex = 26
        '
        'ImagenesLabel
        '
        Me.ImagenesLabel.AutoSize = True
        Me.ImagenesLabel.Location = New System.Drawing.Point(24, 255)
        Me.ImagenesLabel.Name = "ImagenesLabel"
        Me.ImagenesLabel.Size = New System.Drawing.Size(53, 13)
        Me.ImagenesLabel.TabIndex = 25
        Me.ImagenesLabel.Text = "Imágenes"
        '
        'CaracteristicasLabel
        '
        Me.CaracteristicasLabel.AutoSize = True
        Me.CaracteristicasLabel.Location = New System.Drawing.Point(379, 112)
        Me.CaracteristicasLabel.Name = "CaracteristicasLabel"
        Me.CaracteristicasLabel.Size = New System.Drawing.Size(121, 13)
        Me.CaracteristicasLabel.TabIndex = 24
        Me.CaracteristicasLabel.Text = "Características técnicas"
        '
        'DescripcionLabel
        '
        Me.DescripcionLabel.AutoSize = True
        Me.DescripcionLabel.Location = New System.Drawing.Point(24, 112)
        Me.DescripcionLabel.Name = "DescripcionLabel"
        Me.DescripcionLabel.Size = New System.Drawing.Size(63, 13)
        Me.DescripcionLabel.TabIndex = 23
        Me.DescripcionLabel.Text = "Descripción"
        '
        'FechaCompraLabel
        '
        Me.FechaCompraLabel.AutoSize = True
        Me.FechaCompraLabel.Location = New System.Drawing.Point(455, 38)
        Me.FechaCompraLabel.Name = "FechaCompraLabel"
        Me.FechaCompraLabel.Size = New System.Drawing.Size(90, 13)
        Me.FechaCompraLabel.TabIndex = 22
        Me.FechaCompraLabel.Text = "Fecha de compra"
        '
        'TipoLabel
        '
        Me.TipoLabel.AutoSize = True
        Me.TipoLabel.Location = New System.Drawing.Point(254, 69)
        Me.TipoLabel.Name = "TipoLabel"
        Me.TipoLabel.Size = New System.Drawing.Size(28, 13)
        Me.TipoLabel.TabIndex = 21
        Me.TipoLabel.Text = "Tipo"
        '
        'PrecioHoraLabel
        '
        Me.PrecioHoraLabel.AutoSize = True
        Me.PrecioHoraLabel.Location = New System.Drawing.Point(254, 35)
        Me.PrecioHoraLabel.Name = "PrecioHoraLabel"
        Me.PrecioHoraLabel.Size = New System.Drawing.Size(63, 13)
        Me.PrecioHoraLabel.TabIndex = 20
        Me.PrecioHoraLabel.Text = "Precio/hora"
        '
        'TelefonoSatLabel
        '
        Me.TelefonoSatLabel.AutoSize = True
        Me.TelefonoSatLabel.Location = New System.Drawing.Point(24, 69)
        Me.TelefonoSatLabel.Name = "TelefonoSatLabel"
        Me.TelefonoSatLabel.Size = New System.Drawing.Size(73, 13)
        Me.TelefonoSatLabel.TabIndex = 19
        Me.TelefonoSatLabel.Text = "Teléfono SAT"
        '
        'ModeloLabelNuevaMaquina
        '
        Me.ModeloLabelNuevaMaquina.AutoSize = True
        Me.ModeloLabelNuevaMaquina.Location = New System.Drawing.Point(24, 35)
        Me.ModeloLabelNuevaMaquina.Name = "ModeloLabelNuevaMaquina"
        Me.ModeloLabelNuevaMaquina.Size = New System.Drawing.Size(42, 13)
        Me.ModeloLabelNuevaMaquina.TabIndex = 18
        Me.ModeloLabelNuevaMaquina.Text = "Modelo"
        '
        'AceptarButton
        '
        Me.AceptarButton.Location = New System.Drawing.Point(653, 402)
        Me.AceptarButton.Name = "AceptarButton"
        Me.AceptarButton.Size = New System.Drawing.Size(75, 23)
        Me.AceptarButton.TabIndex = 36
        Me.AceptarButton.Text = "Aceptar"
        Me.AceptarButton.UseVisualStyleBackColor = True
        '
        'CancelarButton
        '
        Me.CancelarButton.Location = New System.Drawing.Point(743, 402)
        Me.CancelarButton.Name = "CancelarButton"
        Me.CancelarButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelarButton.TabIndex = 37
        Me.CancelarButton.Text = "Cancelar"
        Me.CancelarButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.FabLabJR.My.Resources.Resources.plus_TratarMaquina
        Me.PictureBox1.Location = New System.Drawing.Point(458, 66)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(28, 28)
        Me.PictureBox1.TabIndex = 38
        Me.PictureBox1.TabStop = False
        '
        'FormTratarMaquina
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(830, 437)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.CancelarButton)
        Me.Controls.Add(Me.AceptarButton)
        Me.Controls.Add(Me.ImagenesFlowLayoutPanel)
        Me.Controls.Add(Me.CaracteristicasTextBox)
        Me.Controls.Add(Me.DescripcionTextBox)
        Me.Controls.Add(Me.TipoComboBox)
        Me.Controls.Add(Me.FechaCompraDateTimePicker)
        Me.Controls.Add(Me.TelefonoSatMaskedTextBox)
        Me.Controls.Add(Me.PrecioHoraTextBox)
        Me.Controls.Add(Me.ModeloTextBox)
        Me.Controls.Add(Me.ImagenesLabel)
        Me.Controls.Add(Me.CaracteristicasLabel)
        Me.Controls.Add(Me.DescripcionLabel)
        Me.Controls.Add(Me.FechaCompraLabel)
        Me.Controls.Add(Me.TipoLabel)
        Me.Controls.Add(Me.PrecioHoraLabel)
        Me.Controls.Add(Me.TelefonoSatLabel)
        Me.Controls.Add(Me.ModeloLabelNuevaMaquina)
        Me.Name = "FormTratarMaquina"
        Me.Text = "FormTratarMaquina"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ImagenesFlowLayoutPanel As FlowLayoutPanel
    Friend WithEvents CaracteristicasTextBox As TextBox
    Friend WithEvents DescripcionTextBox As TextBox
    Friend WithEvents TipoComboBox As ComboBox
    Friend WithEvents FechaCompraDateTimePicker As DateTimePicker
    Friend WithEvents TelefonoSatMaskedTextBox As MaskedTextBox
    Friend WithEvents PrecioHoraTextBox As TextBox
    Friend WithEvents ModeloTextBox As TextBox
    Friend WithEvents ImagenesLabel As Label
    Friend WithEvents CaracteristicasLabel As Label
    Friend WithEvents DescripcionLabel As Label
    Friend WithEvents FechaCompraLabel As Label
    Friend WithEvents TipoLabel As Label
    Friend WithEvents PrecioHoraLabel As Label
    Friend WithEvents TelefonoSatLabel As Label
    Friend WithEvents ModeloLabelNuevaMaquina As Label
    Friend WithEvents AceptarButton As Button
    Friend WithEvents CancelarButton As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
