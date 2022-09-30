<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFiltroActividades
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
        Me.cmbActividades = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmdCerrar = New System.Windows.Forms.Button
        Me.cmdVistaPrevia = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'cmbActividades
        '
        Me.cmbActividades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbActividades.FormattingEnabled = True
        Me.cmbActividades.Location = New System.Drawing.Point(69, 19)
        Me.cmbActividades.Name = "cmbActividades"
        Me.cmbActividades.Size = New System.Drawing.Size(368, 21)
        Me.cmbActividades.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Actividad"
        '
        'cmdCerrar
        '
        Me.cmdCerrar.Location = New System.Drawing.Point(231, 77)
        Me.cmdCerrar.Name = "cmdCerrar"
        Me.cmdCerrar.Size = New System.Drawing.Size(108, 31)
        Me.cmdCerrar.TabIndex = 10
        Me.cmdCerrar.Text = "Cerrar"
        Me.cmdCerrar.UseVisualStyleBackColor = True
        '
        'cmdVistaPrevia
        '
        Me.cmdVistaPrevia.Image = Global.ServicioalCliente.My.Resources.Resources.printer
        Me.cmdVistaPrevia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdVistaPrevia.Location = New System.Drawing.Point(117, 77)
        Me.cmdVistaPrevia.Name = "cmdVistaPrevia"
        Me.cmdVistaPrevia.Size = New System.Drawing.Size(108, 31)
        Me.cmdVistaPrevia.TabIndex = 9
        Me.cmdVistaPrevia.Text = "Vista Previa"
        Me.cmdVistaPrevia.UseVisualStyleBackColor = True
        '
        'frmFiltroActividades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(455, 129)
        Me.Controls.Add(Me.cmdCerrar)
        Me.Controls.Add(Me.cmdVistaPrevia)
        Me.Controls.Add(Me.cmbActividades)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFiltroActividades"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Informe de Actividades"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbActividades As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdCerrar As System.Windows.Forms.Button
    Friend WithEvents cmdVistaPrevia As System.Windows.Forms.Button
End Class
