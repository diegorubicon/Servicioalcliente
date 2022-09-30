<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDeactivateVendedor
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
        Me.txtVendedor = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtComentarios = New System.Windows.Forms.TextBox
        Me.cmdInactivar = New System.Windows.Forms.Button
        Me.cmdCerrar = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtVendedor
        '
        Me.txtVendedor.Location = New System.Drawing.Point(73, 12)
        Me.txtVendedor.Name = "txtVendedor"
        Me.txtVendedor.ReadOnly = True
        Me.txtVendedor.Size = New System.Drawing.Size(380, 21)
        Me.txtVendedor.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Vendedor"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtComentarios)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(438, 185)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Comentarios"
        '
        'txtComentarios
        '
        Me.txtComentarios.Location = New System.Drawing.Point(16, 29)
        Me.txtComentarios.Multiline = True
        Me.txtComentarios.Name = "txtComentarios"
        Me.txtComentarios.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtComentarios.Size = New System.Drawing.Size(407, 136)
        Me.txtComentarios.TabIndex = 0
        '
        'cmdInactivar
        '
        Me.cmdInactivar.Location = New System.Drawing.Point(125, 233)
        Me.cmdInactivar.Name = "cmdInactivar"
        Me.cmdInactivar.Size = New System.Drawing.Size(104, 27)
        Me.cmdInactivar.TabIndex = 3
        Me.cmdInactivar.Text = "Inactivar"
        Me.cmdInactivar.UseVisualStyleBackColor = True
        '
        'cmdCerrar
        '
        Me.cmdCerrar.Location = New System.Drawing.Point(235, 233)
        Me.cmdCerrar.Name = "cmdCerrar"
        Me.cmdCerrar.Size = New System.Drawing.Size(104, 27)
        Me.cmdCerrar.TabIndex = 4
        Me.cmdCerrar.Text = "Cerrar"
        Me.cmdCerrar.UseVisualStyleBackColor = True
        '
        'frmDeactivateVendedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 272)
        Me.Controls.Add(Me.cmdCerrar)
        Me.Controls.Add(Me.cmdInactivar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtVendedor)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDeactivateVendedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inactivar Vendedor"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtVendedor As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtComentarios As System.Windows.Forms.TextBox
    Friend WithEvents cmdInactivar As System.Windows.Forms.Button
    Friend WithEvents cmdCerrar As System.Windows.Forms.Button
End Class
