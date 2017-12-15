<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReservasUsuariovb
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
        Me.TablaReservasDataGridView = New System.Windows.Forms.DataGridView()
        CType(Me.TablaReservasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TablaReservasDataGridView
        '
        Me.TablaReservasDataGridView.AllowUserToAddRows = False
        Me.TablaReservasDataGridView.AllowUserToDeleteRows = False
        Me.TablaReservasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TablaReservasDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TablaReservasDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.TablaReservasDataGridView.Name = "TablaReservasDataGridView"
        Me.TablaReservasDataGridView.ReadOnly = True
        Me.TablaReservasDataGridView.Size = New System.Drawing.Size(598, 317)
        Me.TablaReservasDataGridView.TabIndex = 6
        '
        'ReservasUsuariovb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(598, 317)
        Me.Controls.Add(Me.TablaReservasDataGridView)
        Me.Name = "ReservasUsuariovb"
        Me.Text = "ReservasUsuariovb"
        CType(Me.TablaReservasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TablaReservasDataGridView As DataGridView
End Class
