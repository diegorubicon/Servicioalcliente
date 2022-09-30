<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDesbloquearBitacoraVendedor
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmdCerrar = New System.Windows.Forms.Button
        Me.cmdDesbloquear = New System.Windows.Forms.Button
        Me.lvGestiones = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.Ejecutivo = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.SuspendLayout()
        '
        'cmdCerrar
        '
        Me.cmdCerrar.Location = New System.Drawing.Point(341, 472)
        Me.cmdCerrar.Name = "cmdCerrar"
        Me.cmdCerrar.Size = New System.Drawing.Size(134, 31)
        Me.cmdCerrar.TabIndex = 5
        Me.cmdCerrar.Text = "Cerrar"
        Me.cmdCerrar.UseVisualStyleBackColor = True
        '
        'cmdDesbloquear
        '
        Me.cmdDesbloquear.Location = New System.Drawing.Point(201, 472)
        Me.cmdDesbloquear.Name = "cmdDesbloquear"
        Me.cmdDesbloquear.Size = New System.Drawing.Size(134, 31)
        Me.cmdDesbloquear.TabIndex = 4
        Me.cmdDesbloquear.Text = "Desbloquear"
        Me.cmdDesbloquear.UseVisualStyleBackColor = True
        '
        'lvGestiones
        '
        Me.lvGestiones.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.Ejecutivo, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lvGestiones.FullRowSelect = True
        Me.lvGestiones.GridLines = True
        Me.lvGestiones.Location = New System.Drawing.Point(12, 12)
        Me.lvGestiones.Name = "lvGestiones"
        Me.lvGestiones.Size = New System.Drawing.Size(660, 450)
        Me.lvGestiones.TabIndex = 3
        Me.lvGestiones.UseCompatibleStateImageBehavior = False
        Me.lvGestiones.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Vendedor"
        Me.ColumnHeader1.Width = 65
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nombre"
        Me.ColumnHeader2.Width = 275
        '
        'Ejecutivo
        '
        Me.Ejecutivo.Text = "Ejecutivo"
        Me.Ejecutivo.Width = 94
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Gestion"
        Me.ColumnHeader3.Width = 80
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Fecha Ini."
        Me.ColumnHeader4.Width = 93
        '
        'frmDesbloquearBitacoraVendedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(680, 515)
        Me.Controls.Add(Me.cmdCerrar)
        Me.Controls.Add(Me.cmdDesbloquear)
        Me.Controls.Add(Me.lvGestiones)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmDesbloquearBitacoraVendedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Desbloquear Bitacora Vendedor"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdCerrar As System.Windows.Forms.Button
    Friend WithEvents cmdDesbloquear As System.Windows.Forms.Button
    Friend WithEvents lvGestiones As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Ejecutivo As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
End Class
