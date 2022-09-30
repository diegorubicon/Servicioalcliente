<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFiltroSeguimientoLlamadas
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
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ckFecha = New System.Windows.Forms.CheckBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdCerrar = New System.Windows.Forms.Button()
        Me.cmdVistaPrevia = New System.Windows.Forms.Button()
        Me.ckTipoLlamada = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbProvincia = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbCanton = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbDistrito = New System.Windows.Forms.ComboBox()
        Me.cb_Provincias = New System.Windows.Forms.CheckBox()
        Me.cb_canton = New System.Windows.Forms.CheckBox()
        Me.cb_distrito = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(86, 45)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(104, 21)
        Me.DateTimePicker1.TabIndex = 0
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(205, 45)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(104, 21)
        Me.DateTimePicker2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(104, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Desde"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(239, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Hasta"
        '
        'ckFecha
        '
        Me.ckFecha.AutoSize = True
        Me.ckFecha.Location = New System.Drawing.Point(86, 72)
        Me.ckFecha.Name = "ckFecha"
        Me.ckFecha.Size = New System.Drawing.Size(55, 17)
        Me.ckFecha.TabIndex = 4
        Me.ckFecha.Text = "Todas"
        Me.ckFecha.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Tipo A", "Tipo B", "Tipo C", "No Contactados"})
        Me.ComboBox1.Location = New System.Drawing.Point(86, 295)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(216, 21)
        Me.ComboBox1.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(159, 279)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Tipo Llamada"
        '
        'cmdCerrar
        '
        Me.cmdCerrar.Location = New System.Drawing.Point(196, 360)
        Me.cmdCerrar.Name = "cmdCerrar"
        Me.cmdCerrar.Size = New System.Drawing.Size(108, 31)
        Me.cmdCerrar.TabIndex = 8
        Me.cmdCerrar.Text = "Cerrar"
        Me.cmdCerrar.UseVisualStyleBackColor = True
        '
        'cmdVistaPrevia
        '
        Me.cmdVistaPrevia.Image = Global.ServicioalCliente.My.Resources.Resources.printer
        Me.cmdVistaPrevia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdVistaPrevia.Location = New System.Drawing.Point(82, 360)
        Me.cmdVistaPrevia.Name = "cmdVistaPrevia"
        Me.cmdVistaPrevia.Size = New System.Drawing.Size(108, 31)
        Me.cmdVistaPrevia.TabIndex = 7
        Me.cmdVistaPrevia.Text = "Vista Previa"
        Me.cmdVistaPrevia.UseVisualStyleBackColor = True
        '
        'ckTipoLlamada
        '
        Me.ckTipoLlamada.AutoSize = True
        Me.ckTipoLlamada.Checked = True
        Me.ckTipoLlamada.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckTipoLlamada.Location = New System.Drawing.Point(91, 322)
        Me.ckTipoLlamada.Name = "ckTipoLlamada"
        Me.ckTipoLlamada.Size = New System.Drawing.Size(55, 17)
        Me.ckTipoLlamada.TabIndex = 9
        Me.ckTipoLlamada.Text = "Todas"
        Me.ckTipoLlamada.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(159, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Provincia"
        '
        'cmbProvincia
        '
        Me.cmbProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProvincia.FormattingEnabled = True
        Me.cmbProvincia.Items.AddRange(New Object() {"Tipo A", "Tipo B", "Tipo C"})
        Me.cmbProvincia.Location = New System.Drawing.Point(86, 114)
        Me.cmbProvincia.Name = "cmbProvincia"
        Me.cmbProvincia.Size = New System.Drawing.Size(216, 21)
        Me.cmbProvincia.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(159, 160)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Canton"
        '
        'cmbCanton
        '
        Me.cmbCanton.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCanton.FormattingEnabled = True
        Me.cmbCanton.Location = New System.Drawing.Point(86, 176)
        Me.cmbCanton.Name = "cmbCanton"
        Me.cmbCanton.Size = New System.Drawing.Size(216, 21)
        Me.cmbCanton.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(159, 220)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Distrito"
        '
        'cmbDistrito
        '
        Me.cmbDistrito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDistrito.FormattingEnabled = True
        Me.cmbDistrito.Location = New System.Drawing.Point(86, 236)
        Me.cmbDistrito.Name = "cmbDistrito"
        Me.cmbDistrito.Size = New System.Drawing.Size(216, 21)
        Me.cmbDistrito.TabIndex = 14
        '
        'cb_Provincias
        '
        Me.cb_Provincias.AutoSize = True
        Me.cb_Provincias.Checked = True
        Me.cb_Provincias.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cb_Provincias.Location = New System.Drawing.Point(86, 140)
        Me.cb_Provincias.Name = "cb_Provincias"
        Me.cb_Provincias.Size = New System.Drawing.Size(55, 17)
        Me.cb_Provincias.TabIndex = 16
        Me.cb_Provincias.Text = "Todas"
        Me.cb_Provincias.UseVisualStyleBackColor = True
        '
        'cb_canton
        '
        Me.cb_canton.AutoSize = True
        Me.cb_canton.Checked = True
        Me.cb_canton.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cb_canton.Location = New System.Drawing.Point(86, 203)
        Me.cb_canton.Name = "cb_canton"
        Me.cb_canton.Size = New System.Drawing.Size(55, 17)
        Me.cb_canton.TabIndex = 17
        Me.cb_canton.Text = "Todas"
        Me.cb_canton.UseVisualStyleBackColor = True
        '
        'cb_distrito
        '
        Me.cb_distrito.AutoSize = True
        Me.cb_distrito.Checked = True
        Me.cb_distrito.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cb_distrito.Location = New System.Drawing.Point(91, 263)
        Me.cb_distrito.Name = "cb_distrito"
        Me.cb_distrito.Size = New System.Drawing.Size(55, 17)
        Me.cb_distrito.TabIndex = 18
        Me.cb_distrito.Text = "Todas"
        Me.cb_distrito.UseVisualStyleBackColor = True
        '
        'frmFiltroSeguimientoLlamadas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 410)
        Me.Controls.Add(Me.cb_distrito)
        Me.Controls.Add(Me.cb_canton)
        Me.Controls.Add(Me.cb_Provincias)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbDistrito)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbCanton)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbProvincia)
        Me.Controls.Add(Me.ckTipoLlamada)
        Me.Controls.Add(Me.cmdCerrar)
        Me.Controls.Add(Me.cmdVistaPrevia)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.ckFecha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFiltroSeguimientoLlamadas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte Seguimiento Llamadas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ckFecha As System.Windows.Forms.CheckBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdVistaPrevia As System.Windows.Forms.Button
    Friend WithEvents cmdCerrar As System.Windows.Forms.Button
    Friend WithEvents ckTipoLlamada As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbProvincia As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbCanton As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbDistrito As System.Windows.Forms.ComboBox
    Friend WithEvents cb_Provincias As System.Windows.Forms.CheckBox
    Friend WithEvents cb_canton As System.Windows.Forms.CheckBox
    Friend WithEvents cb_distrito As System.Windows.Forms.CheckBox
End Class
