<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBitacoraVendedores
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBitacoraVendedores))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dtProximaLlamada = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmdAgregar = New System.Windows.Forms.Button()
        Me.lvObservaciones = New System.Windows.Forms.ListView()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.rbC = New System.Windows.Forms.RadioButton()
        Me.rbB = New System.Windows.Forms.RadioButton()
        Me.rbA = New System.Windows.Forms.RadioButton()
        Me.txtObservacion = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lvReclutas = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmdDesbloquear = New System.Windows.Forms.Button()
        Me.cmdCerrar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbNombreVendedor = New System.Windows.Forms.Label()
        Me.lbTelefono01 = New System.Windows.Forms.Label()
        Me.lbTelefono02 = New System.Windows.Forms.Label()
        Me.lbFechaIngreso = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtVentaPersonal = New System.Windows.Forms.TextBox()
        Me.txtVentaUnidad = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbUltimaVenta = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbCorreoElectronico = New System.Windows.Forms.Label()
        Me.cmdCorreoElectronico = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(8, 202)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(690, 268)
        Me.TabControl1.TabIndex = 12
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dtProximaLlamada)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.cmdAgregar)
        Me.TabPage1.Controls.Add(Me.lvObservaciones)
        Me.TabPage1.Controls.Add(Me.rbC)
        Me.TabPage1.Controls.Add(Me.rbB)
        Me.TabPage1.Controls.Add(Me.rbA)
        Me.TabPage1.Controls.Add(Me.txtObservacion)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(682, 242)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Bitacora"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dtProximaLlamada
        '
        Me.dtProximaLlamada.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtProximaLlamada.Location = New System.Drawing.Point(417, 42)
        Me.dtProximaLlamada.Name = "dtProximaLlamada"
        Me.dtProximaLlamada.Size = New System.Drawing.Size(134, 21)
        Me.dtProximaLlamada.TabIndex = 9
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(319, 46)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(87, 13)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "Proxima Llamada"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 46)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(82, 13)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Estado Llamada"
        '
        'cmdAgregar
        '
        Me.cmdAgregar.Image = CType(resources.GetObject("cmdAgregar.Image"), System.Drawing.Image)
        Me.cmdAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdAgregar.Location = New System.Drawing.Point(580, 13)
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(88, 36)
        Me.cmdAgregar.TabIndex = 6
        Me.cmdAgregar.Text = "Agregar"
        Me.cmdAgregar.UseVisualStyleBackColor = True
        '
        'lvObservaciones
        '
        Me.lvObservaciones.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11})
        Me.lvObservaciones.FullRowSelect = True
        Me.lvObservaciones.Location = New System.Drawing.Point(9, 79)
        Me.lvObservaciones.Name = "lvObservaciones"
        Me.lvObservaciones.Size = New System.Drawing.Size(659, 157)
        Me.lvObservaciones.TabIndex = 5
        Me.lvObservaciones.UseCompatibleStateImageBehavior = False
        Me.lvObservaciones.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Fecha"
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Comentario"
        Me.ColumnHeader6.Width = 394
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "A"
        Me.ColumnHeader7.Width = 31
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "B"
        Me.ColumnHeader8.Width = 36
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "C"
        Me.ColumnHeader9.Width = 32
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Proxima Llamada"
        Me.ColumnHeader10.Width = 101
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Agente"
        '
        'rbC
        '
        Me.rbC.AutoSize = True
        Me.rbC.Location = New System.Drawing.Point(184, 42)
        Me.rbC.Name = "rbC"
        Me.rbC.Size = New System.Drawing.Size(32, 17)
        Me.rbC.TabIndex = 4
        Me.rbC.TabStop = True
        Me.rbC.Text = "C"
        Me.ToolTip1.SetToolTip(Me.rbC, "No se contacto con el vendedor, proxima llamada programada" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "para el dia siguiente" & _
        ". ")
        Me.rbC.UseVisualStyleBackColor = True
        '
        'rbB
        '
        Me.rbB.AutoSize = True
        Me.rbB.Location = New System.Drawing.Point(147, 42)
        Me.rbB.Name = "rbB"
        Me.rbB.Size = New System.Drawing.Size(31, 17)
        Me.rbB.TabIndex = 3
        Me.rbB.TabStop = True
        Me.rbB.Text = "B"
        Me.ToolTip1.SetToolTip(Me.rbB, "Mensaje de Llamada, se dejo un mensaje en contestadora o con familiares." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Proxima" & _
        " Llamada: Maximo 8 dias.")
        Me.rbB.UseVisualStyleBackColor = True
        '
        'rbA
        '
        Me.rbA.AutoSize = True
        Me.rbA.Location = New System.Drawing.Point(106, 42)
        Me.rbA.Name = "rbA"
        Me.rbA.Size = New System.Drawing.Size(35, 17)
        Me.rbA.TabIndex = 2
        Me.rbA.TabStop = True
        Me.rbA.Text = "A "
        Me.ToolTip1.SetToolTip(Me.rbA, "Llamada Satisfactoria: Se comunico con el vendedor. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Proxima Llamada maximo 15 d" & _
        "ias")
        Me.rbA.UseVisualStyleBackColor = True
        '
        'txtObservacion
        '
        Me.txtObservacion.Location = New System.Drawing.Point(106, 10)
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Size = New System.Drawing.Size(445, 21)
        Me.txtObservacion.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 13)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(78, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Observaciones"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.lvReclutas)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(682, 242)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Reclutas"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'lvReclutas
        '
        Me.lvReclutas.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lvReclutas.GridLines = True
        Me.lvReclutas.Location = New System.Drawing.Point(13, 15)
        Me.lvReclutas.Name = "lvReclutas"
        Me.lvReclutas.Size = New System.Drawing.Size(598, 185)
        Me.lvReclutas.TabIndex = 0
        Me.lvReclutas.UseCompatibleStateImageBehavior = False
        Me.lvReclutas.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Recluta"
        Me.ColumnHeader1.Width = 136
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Vendedor"
        Me.ColumnHeader2.Width = 280
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Tipo"
        Me.ColumnHeader3.Width = 90
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Venta"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader4.Width = 78
        '
        'cmdDesbloquear
        '
        Me.cmdDesbloquear.Image = CType(resources.GetObject("cmdDesbloquear.Image"), System.Drawing.Image)
        Me.cmdDesbloquear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdDesbloquear.Location = New System.Drawing.Point(283, 476)
        Me.cmdDesbloquear.Name = "cmdDesbloquear"
        Me.cmdDesbloquear.Size = New System.Drawing.Size(144, 38)
        Me.cmdDesbloquear.TabIndex = 15
        Me.cmdDesbloquear.Text = "Desbloquear"
        Me.cmdDesbloquear.UseVisualStyleBackColor = True
        '
        'cmdCerrar
        '
        Me.cmdCerrar.Image = CType(resources.GetObject("cmdCerrar.Image"), System.Drawing.Image)
        Me.cmdCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCerrar.Location = New System.Drawing.Point(133, 476)
        Me.cmdCerrar.Name = "cmdCerrar"
        Me.cmdCerrar.Size = New System.Drawing.Size(144, 38)
        Me.cmdCerrar.TabIndex = 14
        Me.cmdCerrar.Text = "Cerrar"
        Me.cmdCerrar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Vendedor"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(431, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Telefonos:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(431, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Telefonos:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Fecha Ingreso"
        '
        'lbNombreVendedor
        '
        Me.lbNombreVendedor.AutoSize = True
        Me.lbNombreVendedor.Location = New System.Drawing.Point(119, 20)
        Me.lbNombreVendedor.Name = "lbNombreVendedor"
        Me.lbNombreVendedor.Size = New System.Drawing.Size(0, 13)
        Me.lbNombreVendedor.TabIndex = 21
        '
        'lbTelefono01
        '
        Me.lbTelefono01.AutoSize = True
        Me.lbTelefono01.Location = New System.Drawing.Point(502, 20)
        Me.lbTelefono01.Name = "lbTelefono01"
        Me.lbTelefono01.Size = New System.Drawing.Size(0, 13)
        Me.lbTelefono01.TabIndex = 22
        '
        'lbTelefono02
        '
        Me.lbTelefono02.AutoSize = True
        Me.lbTelefono02.Location = New System.Drawing.Point(502, 57)
        Me.lbTelefono02.Name = "lbTelefono02"
        Me.lbTelefono02.Size = New System.Drawing.Size(0, 13)
        Me.lbTelefono02.TabIndex = 23
        '
        'lbFechaIngreso
        '
        Me.lbFechaIngreso.AutoSize = True
        Me.lbFechaIngreso.Location = New System.Drawing.Point(119, 57)
        Me.lbFechaIngreso.Name = "lbFechaIngreso"
        Me.lbFechaIngreso.Size = New System.Drawing.Size(0, 13)
        Me.lbFechaIngreso.TabIndex = 24
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 108)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Ventas Personales"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 144)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 13)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Ventas Unidad"
        '
        'txtVentaPersonal
        '
        Me.txtVentaPersonal.AcceptsReturn = True
        Me.txtVentaPersonal.Location = New System.Drawing.Point(147, 100)
        Me.txtVentaPersonal.Name = "txtVentaPersonal"
        Me.txtVentaPersonal.Size = New System.Drawing.Size(100, 21)
        Me.txtVentaPersonal.TabIndex = 28
        '
        'txtVentaUnidad
        '
        Me.txtVentaUnidad.Location = New System.Drawing.Point(147, 136)
        Me.txtVentaUnidad.Name = "txtVentaUnidad"
        Me.txtVentaUnidad.Size = New System.Drawing.Size(100, 21)
        Me.txtVentaUnidad.TabIndex = 29
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(227, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 13)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Fecha Ult. Venta"
        '
        'lbUltimaVenta
        '
        Me.lbUltimaVenta.AutoSize = True
        Me.lbUltimaVenta.Location = New System.Drawing.Point(331, 57)
        Me.lbUltimaVenta.Name = "lbUltimaVenta"
        Me.lbUltimaVenta.Size = New System.Drawing.Size(0, 13)
        Me.lbUltimaVenta.TabIndex = 31
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 176)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 13)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Correo Electronico"
        '
        'lbCorreoElectronico
        '
        Me.lbCorreoElectronico.AutoSize = True
        Me.lbCorreoElectronico.Location = New System.Drawing.Point(144, 176)
        Me.lbCorreoElectronico.Name = "lbCorreoElectronico"
        Me.lbCorreoElectronico.Size = New System.Drawing.Size(0, 13)
        Me.lbCorreoElectronico.TabIndex = 33
        '
        'cmdCorreoElectronico
        '
        Me.cmdCorreoElectronico.Image = Global.ServicioalCliente.My.Resources.Resources.edit
        Me.cmdCorreoElectronico.Location = New System.Drawing.Point(639, 167)
        Me.cmdCorreoElectronico.Name = "cmdCorreoElectronico"
        Me.cmdCorreoElectronico.Size = New System.Drawing.Size(41, 31)
        Me.cmdCorreoElectronico.TabIndex = 34
        Me.ToolTip1.SetToolTip(Me.cmdCorreoElectronico, "Modifica el Correo electronico del Vendedor")
        Me.cmdCorreoElectronico.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = Global.ServicioalCliente.My.Resources.Resources.join
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(433, 476)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(144, 38)
        Me.Button1.TabIndex = 35
        Me.Button1.Text = "Asistencia Actividad"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.Button1, "Vendedor Asistira a una Actividad Programada")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Informacion"
        '
        'frmBitacoraVendedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(710, 521)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmdCorreoElectronico)
        Me.Controls.Add(Me.lbCorreoElectronico)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lbUltimaVenta)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtVentaUnidad)
        Me.Controls.Add(Me.txtVentaPersonal)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lbFechaIngreso)
        Me.Controls.Add(Me.lbTelefono02)
        Me.Controls.Add(Me.lbTelefono01)
        Me.Controls.Add(Me.lbNombreVendedor)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdDesbloquear)
        Me.Controls.Add(Me.cmdCerrar)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBitacoraVendedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bitacora Vendedores"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents dtProximaLlamada As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cmdAgregar As System.Windows.Forms.Button
    Friend WithEvents lvObservaciones As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents rbC As System.Windows.Forms.RadioButton
    Friend WithEvents rbB As System.Windows.Forms.RadioButton
    Friend WithEvents rbA As System.Windows.Forms.RadioButton
    Friend WithEvents txtObservacion As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cmdDesbloquear As System.Windows.Forms.Button
    Friend WithEvents cmdCerrar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbNombreVendedor As System.Windows.Forms.Label
    Friend WithEvents lbTelefono01 As System.Windows.Forms.Label
    Friend WithEvents lbTelefono02 As System.Windows.Forms.Label
    Friend WithEvents lbFechaIngreso As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtVentaPersonal As System.Windows.Forms.TextBox
    Friend WithEvents txtVentaUnidad As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents lvReclutas As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lbUltimaVenta As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lbCorreoElectronico As System.Windows.Forms.Label
    Friend WithEvents cmdCorreoElectronico As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
End Class
