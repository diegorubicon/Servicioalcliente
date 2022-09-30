<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMakeMeeting
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtUbicacion = New System.Windows.Forms.TextBox()
        Me.txtfecha = New System.Windows.Forms.DateTimePicker()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.cmdCrearActividad = New System.Windows.Forms.Button()
        Me.cmdCerrar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.optActividadReclutamiento = New System.Windows.Forms.RadioButton()
        Me.optActividadVenta = New System.Windows.Forms.RadioButton()
        Me.optActividadMensual = New System.Windows.Forms.RadioButton()
        Me.optActividadDesarrollo = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Descripcion"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(107, 24)
        Me.txtDescripcion.MaxLength = 150
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(388, 21)
        Me.txtDescripcion.TabIndex = 1
        '
        'txtUbicacion
        '
        Me.txtUbicacion.Location = New System.Drawing.Point(107, 64)
        Me.txtUbicacion.MaxLength = 150
        Me.txtUbicacion.Name = "txtUbicacion"
        Me.txtUbicacion.Size = New System.Drawing.Size(388, 21)
        Me.txtUbicacion.TabIndex = 2
        '
        'txtfecha
        '
        Me.txtfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtfecha.Location = New System.Drawing.Point(107, 103)
        Me.txtfecha.Name = "txtfecha"
        Me.txtfecha.Size = New System.Drawing.Size(115, 21)
        Me.txtfecha.TabIndex = 3
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(107, 143)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservaciones.Size = New System.Drawing.Size(388, 154)
        Me.txtObservaciones.TabIndex = 4
        '
        'cmdCrearActividad
        '
        Me.cmdCrearActividad.Location = New System.Drawing.Point(129, 389)
        Me.cmdCrearActividad.Name = "cmdCrearActividad"
        Me.cmdCrearActividad.Size = New System.Drawing.Size(110, 23)
        Me.cmdCrearActividad.TabIndex = 5
        Me.cmdCrearActividad.Text = "Crear Actividad"
        Me.cmdCrearActividad.UseVisualStyleBackColor = True
        '
        'cmdCerrar
        '
        Me.cmdCerrar.Location = New System.Drawing.Point(245, 389)
        Me.cmdCerrar.Name = "cmdCerrar"
        Me.cmdCerrar.Size = New System.Drawing.Size(110, 23)
        Me.cmdCerrar.TabIndex = 6
        Me.cmdCerrar.Text = "Cerrar"
        Me.cmdCerrar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Ubicacion"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Fecha"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Observaciones"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 311)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Tipo"
        '
        'optActividadReclutamiento
        '
        Me.optActividadReclutamiento.AutoSize = True
        Me.optActividadReclutamiento.Location = New System.Drawing.Point(107, 311)
        Me.optActividadReclutamiento.Name = "optActividadReclutamiento"
        Me.optActividadReclutamiento.Size = New System.Drawing.Size(140, 17)
        Me.optActividadReclutamiento.TabIndex = 11
        Me.optActividadReclutamiento.TabStop = True
        Me.optActividadReclutamiento.Text = "Actividad Reclutamiento"
        Me.optActividadReclutamiento.UseVisualStyleBackColor = True
        '
        'optActividadVenta
        '
        Me.optActividadVenta.AutoSize = True
        Me.optActividadVenta.Location = New System.Drawing.Point(245, 311)
        Me.optActividadVenta.Name = "optActividadVenta"
        Me.optActividadVenta.Size = New System.Drawing.Size(115, 17)
        Me.optActividadVenta.TabIndex = 12
        Me.optActividadVenta.TabStop = True
        Me.optActividadVenta.Text = "Actividad de Venta"
        Me.optActividadVenta.UseVisualStyleBackColor = True
        '
        'optActividadMensual
        '
        Me.optActividadMensual.AutoSize = True
        Me.optActividadMensual.Location = New System.Drawing.Point(107, 346)
        Me.optActividadMensual.Name = "optActividadMensual"
        Me.optActividadMensual.Size = New System.Drawing.Size(111, 17)
        Me.optActividadMensual.TabIndex = 13
        Me.optActividadMensual.TabStop = True
        Me.optActividadMensual.Text = "Actividad Mensual"
        Me.optActividadMensual.UseVisualStyleBackColor = True
        '
        'optActividadDesarrollo
        '
        Me.optActividadDesarrollo.AutoSize = True
        Me.optActividadDesarrollo.Location = New System.Drawing.Point(360, 311)
        Me.optActividadDesarrollo.Name = "optActividadDesarrollo"
        Me.optActividadDesarrollo.Size = New System.Drawing.Size(135, 17)
        Me.optActividadDesarrollo.TabIndex = 14
        Me.optActividadDesarrollo.TabStop = True
        Me.optActividadDesarrollo.Text = "Actividad de Desarrollo"
        Me.optActividadDesarrollo.UseVisualStyleBackColor = True
        '
        'frmMakeMeeting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(522, 424)
        Me.Controls.Add(Me.optActividadDesarrollo)
        Me.Controls.Add(Me.optActividadMensual)
        Me.Controls.Add(Me.optActividadVenta)
        Me.Controls.Add(Me.optActividadReclutamiento)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmdCerrar)
        Me.Controls.Add(Me.cmdCrearActividad)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.txtfecha)
        Me.Controls.Add(Me.txtUbicacion)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMakeMeeting"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Crear Actividad"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtUbicacion As System.Windows.Forms.TextBox
    Friend WithEvents txtfecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents cmdCrearActividad As System.Windows.Forms.Button
    Friend WithEvents cmdCerrar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents optActividadReclutamiento As System.Windows.Forms.RadioButton
    Friend WithEvents optActividadVenta As System.Windows.Forms.RadioButton
    Friend WithEvents optActividadMensual As System.Windows.Forms.RadioButton
    Friend WithEvents optActividadDesarrollo As System.Windows.Forms.RadioButton
End Class
