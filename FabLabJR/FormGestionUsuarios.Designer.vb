<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGestionUsuarios
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
        Me.BuscadorGestionUsuarioTextBox = New System.Windows.Forms.TextBox()
        Me.NuevoUsuarioGestionUsuarioButton = New System.Windows.Forms.Button()
        Me.ConsultaGestionUsuarioButton = New System.Windows.Forms.Button()
        Me.EditarGestionUsuarioButton = New System.Windows.Forms.Button()
        Me.EliminarGestionUsuarioButton = New System.Windows.Forms.Button()
        Me.TablaGestionUsuarioDataGridView = New System.Windows.Forms.DataGridView()
        Me.BuscarGestionUsuarioLabel = New System.Windows.Forms.Label()
        Me.BuscarGestionUsuarioButton = New System.Windows.Forms.Button()
        CType(Me.TablaGestionUsuarioDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BuscadorGestionUsuarioTextBox
        '
        Me.BuscadorGestionUsuarioTextBox.Location = New System.Drawing.Point(33, 55)
        Me.BuscadorGestionUsuarioTextBox.Name = "BuscadorGestionUsuarioTextBox"
        Me.BuscadorGestionUsuarioTextBox.Size = New System.Drawing.Size(279, 20)
        Me.BuscadorGestionUsuarioTextBox.TabIndex = 0
        '
        'NuevoUsuarioGestionUsuarioButton
        '
        Me.NuevoUsuarioGestionUsuarioButton.Location = New System.Drawing.Point(622, 52)
        Me.NuevoUsuarioGestionUsuarioButton.Name = "NuevoUsuarioGestionUsuarioButton"
        Me.NuevoUsuarioGestionUsuarioButton.Size = New System.Drawing.Size(114, 23)
        Me.NuevoUsuarioGestionUsuarioButton.TabIndex = 1
        Me.NuevoUsuarioGestionUsuarioButton.Text = "Nuevo Usuario"
        Me.NuevoUsuarioGestionUsuarioButton.UseVisualStyleBackColor = True
        '
        'ConsultaGestionUsuarioButton
        '
        Me.ConsultaGestionUsuarioButton.Location = New System.Drawing.Point(482, 408)
        Me.ConsultaGestionUsuarioButton.Name = "ConsultaGestionUsuarioButton"
        Me.ConsultaGestionUsuarioButton.Size = New System.Drawing.Size(75, 23)
        Me.ConsultaGestionUsuarioButton.TabIndex = 2
        Me.ConsultaGestionUsuarioButton.Text = "Consultar"
        Me.ConsultaGestionUsuarioButton.UseVisualStyleBackColor = True
        '
        'EditarGestionUsuarioButton
        '
        Me.EditarGestionUsuarioButton.Location = New System.Drawing.Point(585, 408)
        Me.EditarGestionUsuarioButton.Name = "EditarGestionUsuarioButton"
        Me.EditarGestionUsuarioButton.Size = New System.Drawing.Size(75, 23)
        Me.EditarGestionUsuarioButton.TabIndex = 3
        Me.EditarGestionUsuarioButton.Text = "Editar"
        Me.EditarGestionUsuarioButton.UseVisualStyleBackColor = True
        '
        'EliminarGestionUsuarioButton
        '
        Me.EliminarGestionUsuarioButton.Location = New System.Drawing.Point(686, 408)
        Me.EliminarGestionUsuarioButton.Name = "EliminarGestionUsuarioButton"
        Me.EliminarGestionUsuarioButton.Size = New System.Drawing.Size(75, 23)
        Me.EliminarGestionUsuarioButton.TabIndex = 4
        Me.EliminarGestionUsuarioButton.Text = "Eliminar"
        Me.EliminarGestionUsuarioButton.UseVisualStyleBackColor = True
        '
        'TablaGestionUsuarioDataGridView
        '
        Me.TablaGestionUsuarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TablaGestionUsuarioDataGridView.Location = New System.Drawing.Point(33, 104)
        Me.TablaGestionUsuarioDataGridView.Name = "TablaGestionUsuarioDataGridView"
        Me.TablaGestionUsuarioDataGridView.ReadOnly = True
        Me.TablaGestionUsuarioDataGridView.Size = New System.Drawing.Size(728, 281)
        Me.TablaGestionUsuarioDataGridView.TabIndex = 5
        '
        'BuscarGestionUsuarioLabel
        '
        Me.BuscarGestionUsuarioLabel.AutoSize = True
        Me.BuscarGestionUsuarioLabel.Location = New System.Drawing.Point(30, 30)
        Me.BuscarGestionUsuarioLabel.Name = "BuscarGestionUsuarioLabel"
        Me.BuscarGestionUsuarioLabel.Size = New System.Drawing.Size(167, 13)
        Me.BuscarGestionUsuarioLabel.TabIndex = 6
        Me.BuscarGestionUsuarioLabel.Text = "Buscador por Nombre de Usuario:"
        '
        'BuscarGestionUsuarioButton
        '
        Me.BuscarGestionUsuarioButton.Location = New System.Drawing.Point(318, 52)
        Me.BuscarGestionUsuarioButton.Name = "BuscarGestionUsuarioButton"
        Me.BuscarGestionUsuarioButton.Size = New System.Drawing.Size(75, 23)
        Me.BuscarGestionUsuarioButton.TabIndex = 7
        Me.BuscarGestionUsuarioButton.Text = "Buscar"
        Me.BuscarGestionUsuarioButton.UseVisualStyleBackColor = True
        '
        'FormGestionUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(795, 475)
        Me.Controls.Add(Me.BuscarGestionUsuarioButton)
        Me.Controls.Add(Me.BuscarGestionUsuarioLabel)
        Me.Controls.Add(Me.TablaGestionUsuarioDataGridView)
        Me.Controls.Add(Me.EliminarGestionUsuarioButton)
        Me.Controls.Add(Me.EditarGestionUsuarioButton)
        Me.Controls.Add(Me.ConsultaGestionUsuarioButton)
        Me.Controls.Add(Me.NuevoUsuarioGestionUsuarioButton)
        Me.Controls.Add(Me.BuscadorGestionUsuarioTextBox)
        Me.Name = "FormGestionUsuarios"
        Me.Text = "FormGestionUsuarios"
        CType(Me.TablaGestionUsuarioDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BuscadorGestionUsuarioTextBox As TextBox
    Friend WithEvents NuevoUsuarioGestionUsuarioButton As Button
    Friend WithEvents ConsultaGestionUsuarioButton As Button
    Friend WithEvents EditarGestionUsuarioButton As Button
    Friend WithEvents EliminarGestionUsuarioButton As Button
    Friend WithEvents TablaGestionUsuarioDataGridView As DataGridView
    Friend WithEvents BuscarGestionUsuarioLabel As Label
    Friend WithEvents BuscarGestionUsuarioButton As Button
End Class
