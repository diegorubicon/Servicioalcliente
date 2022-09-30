<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNiveles
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
        Me.lbNivel = New System.Windows.Forms.Label
        Me.lvPosiciones = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.cmdCerrar = New System.Windows.Forms.Button
        Me.lbVendedor = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lbNivel
        '
        Me.lbNivel.AutoSize = True
        Me.lbNivel.Location = New System.Drawing.Point(18, 56)
        Me.lbNivel.Name = "lbNivel"
        Me.lbNivel.Size = New System.Drawing.Size(67, 13)
        Me.lbNivel.TabIndex = 0
        Me.lbNivel.Text = "Nivel Actual:"
        '
        'lvPosiciones
        '
        Me.lvPosiciones.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lvPosiciones.GridLines = True
        Me.lvPosiciones.Location = New System.Drawing.Point(21, 82)
        Me.lvPosiciones.Name = "lvPosiciones"
        Me.lvPosiciones.Size = New System.Drawing.Size(473, 311)
        Me.lvPosiciones.TabIndex = 1
        Me.lvPosiciones.UseCompatibleStateImageBehavior = False
        Me.lvPosiciones.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Cierre"
        Me.ColumnHeader1.Width = 116
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Posicion"
        Me.ColumnHeader2.Width = 102
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Descripcion"
        Me.ColumnHeader3.Width = 248
        '
        'cmdCerrar
        '
        Me.cmdCerrar.Location = New System.Drawing.Point(205, 399)
        Me.cmdCerrar.Name = "cmdCerrar"
        Me.cmdCerrar.Size = New System.Drawing.Size(105, 22)
        Me.cmdCerrar.TabIndex = 2
        Me.cmdCerrar.Text = "Cerrar"
        Me.cmdCerrar.UseVisualStyleBackColor = True
        '
        'lbVendedor
        '
        Me.lbVendedor.AutoSize = True
        Me.lbVendedor.Location = New System.Drawing.Point(18, 23)
        Me.lbVendedor.Name = "lbVendedor"
        Me.lbVendedor.Size = New System.Drawing.Size(57, 13)
        Me.lbVendedor.TabIndex = 3
        Me.lbVendedor.Text = "Vendedor:"
        '
        'frmNiveles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(515, 433)
        Me.Controls.Add(Me.lbVendedor)
        Me.Controls.Add(Me.cmdCerrar)
        Me.Controls.Add(Me.lvPosiciones)
        Me.Controls.Add(Me.lbNivel)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNiveles"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmNiveles"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbNivel As System.Windows.Forms.Label
    Friend WithEvents lvPosiciones As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmdCerrar As System.Windows.Forms.Button
    Friend WithEvents lbVendedor As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
End Class
