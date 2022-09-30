<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmJoinMeeting
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lbObservaciones = New System.Windows.Forms.Label
        Me.lbFecha = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.cmbActividades = New System.Windows.Forms.ComboBox
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Actividad"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbObservaciones)
        Me.GroupBox1.Controls.Add(Me.lbFecha)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(425, 185)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Observaciones"
        '
        'lbObservaciones
        '
        Me.lbObservaciones.AutoSize = True
        Me.lbObservaciones.Location = New System.Drawing.Point(6, 60)
        Me.lbObservaciones.Name = "lbObservaciones"
        Me.lbObservaciones.Size = New System.Drawing.Size(0, 13)
        Me.lbObservaciones.TabIndex = 1
        '
        'lbFecha
        '
        Me.lbFecha.AutoSize = True
        Me.lbFecha.Location = New System.Drawing.Point(6, 32)
        Me.lbFecha.Name = "lbFecha"
        Me.lbFecha.Size = New System.Drawing.Size(0, 13)
        Me.lbFecha.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(111, 257)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 27)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Asistencia"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(227, 257)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(110, 27)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Cerrar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'cmbActividades
        '
        Me.cmbActividades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbActividades.FormattingEnabled = True
        Me.cmbActividades.Location = New System.Drawing.Point(69, 24)
        Me.cmbActividades.Name = "cmbActividades"
        Me.cmbActividades.Size = New System.Drawing.Size(368, 21)
        Me.cmbActividades.TabIndex = 4
        '
        'FrmJoinMeeting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 296)
        Me.Controls.Add(Me.cmbActividades)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmJoinMeeting"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Asistencia Actividad"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents cmbActividades As System.Windows.Forms.ComboBox
    Friend WithEvents lbObservaciones As System.Windows.Forms.Label
    Friend WithEvents lbFecha As System.Windows.Forms.Label
End Class
