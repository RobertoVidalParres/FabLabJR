<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionMaquinas
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
        Me.NuevaMaquinaButton = New System.Windows.Forms.Button()
        Me.BuscadorTextbox = New System.Windows.Forms.TextBox()
        Me.EliminarMaquinaButton = New System.Windows.Forms.Button()
        Me.EditarMaquinaButton = New System.Windows.Forms.Button()
        Me.ConsultarMaquinaButton = New System.Windows.Forms.Button()
        Me.MaquinasDataGridView = New System.Windows.Forms.DataGridView()
        CType(Me.MaquinasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NuevaMaquinaButton
        '
        Me.NuevaMaquinaButton.Location = New System.Drawing.Point(410, 38)
        Me.NuevaMaquinaButton.Name = "NuevaMaquinaButton"
        Me.NuevaMaquinaButton.Size = New System.Drawing.Size(101, 23)
        Me.NuevaMaquinaButton.TabIndex = 11
        Me.NuevaMaquinaButton.Text = "Nueva maquina"
        Me.NuevaMaquinaButton.UseVisualStyleBackColor = True
        '
        'BuscadorTextbox
        '
        Me.BuscadorTextbox.Location = New System.Drawing.Point(29, 38)
        Me.BuscadorTextbox.Name = "BuscadorTextbox"
        Me.BuscadorTextbox.Size = New System.Drawing.Size(100, 20)
        Me.BuscadorTextbox.TabIndex = 10
        '
        'EliminarMaquinaButton
        '
        Me.EliminarMaquinaButton.Location = New System.Drawing.Point(437, 319)
        Me.EliminarMaquinaButton.Name = "EliminarMaquinaButton"
        Me.EliminarMaquinaButton.Size = New System.Drawing.Size(75, 23)
        Me.EliminarMaquinaButton.TabIndex = 9
        Me.EliminarMaquinaButton.Text = "Eliminar"
        Me.EliminarMaquinaButton.UseVisualStyleBackColor = True
        '
        'EditarMaquinaButton
        '
        Me.EditarMaquinaButton.Location = New System.Drawing.Point(355, 318)
        Me.EditarMaquinaButton.Name = "EditarMaquinaButton"
        Me.EditarMaquinaButton.Size = New System.Drawing.Size(75, 23)
        Me.EditarMaquinaButton.TabIndex = 8
        Me.EditarMaquinaButton.Text = "Editar"
        Me.EditarMaquinaButton.UseVisualStyleBackColor = True
        '
        'ConsultarMaquinaButton
        '
        Me.ConsultarMaquinaButton.Location = New System.Drawing.Point(273, 318)
        Me.ConsultarMaquinaButton.Name = "ConsultarMaquinaButton"
        Me.ConsultarMaquinaButton.Size = New System.Drawing.Size(75, 23)
        Me.ConsultarMaquinaButton.TabIndex = 7
        Me.ConsultarMaquinaButton.Text = "Consultar"
        Me.ConsultarMaquinaButton.UseVisualStyleBackColor = True
        '
        'MaquinasDataGridView
        '
        Me.MaquinasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MaquinasDataGridView.Location = New System.Drawing.Point(28, 73)
        Me.MaquinasDataGridView.Name = "MaquinasDataGridView"
        Me.MaquinasDataGridView.Size = New System.Drawing.Size(483, 239)
        Me.MaquinasDataGridView.TabIndex = 6
        '
        'GestionMaquinas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 358)
        Me.Controls.Add(Me.NuevaMaquinaButton)
        Me.Controls.Add(Me.BuscadorTextbox)
        Me.Controls.Add(Me.EliminarMaquinaButton)
        Me.Controls.Add(Me.EditarMaquinaButton)
        Me.Controls.Add(Me.ConsultarMaquinaButton)
        Me.Controls.Add(Me.MaquinasDataGridView)
        Me.Name = "GestionMaquinas"
        Me.Text = "GestionMaquinas"
        CType(Me.MaquinasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NuevaMaquinaButton As Button
    Friend WithEvents BuscadorTextbox As TextBox
    Friend WithEvents EliminarMaquinaButton As Button
    Friend WithEvents EditarMaquinaButton As Button
    Friend WithEvents ConsultarMaquinaButton As Button
    Friend WithEvents MaquinasDataGridView As DataGridView
End Class
