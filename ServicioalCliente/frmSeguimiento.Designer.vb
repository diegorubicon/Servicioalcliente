<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSeguimiento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSeguimiento))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lvArticulos = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.rbD = New System.Windows.Forms.RadioButton()
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
        Me.ColumnHeader23 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.rbC = New System.Windows.Forms.RadioButton()
        Me.rbB = New System.Windows.Forms.RadioButton()
        Me.rbA = New System.Windows.Forms.RadioButton()
        Me.txtObservacion = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lvOrdenesPendientes = New System.Windows.Forms.ListView()
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader17 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader18 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader19 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.lvOrdenesCanceladas = New System.Windows.Forms.ListView()
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader20 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader21 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader22 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader24 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader25 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader26 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmdCerrar = New System.Windows.Forms.Button()
        Me.cmdDesbloquear = New System.Windows.Forms.Button()
        Me.lbFactura = New System.Windows.Forms.Label()
        Me.lbCliente = New System.Windows.Forms.Label()
        Me.lbVendedor = New System.Windows.Forms.Label()
        Me.lbTelefonoVendedor = New System.Windows.Forms.Label()
        Me.lbFecha = New System.Windows.Forms.Label()
        Me.lbFechaVencimiento = New System.Windows.Forms.Label()
        Me.lbFechaCancelacion = New System.Windows.Forms.Label()
        Me.lbMontoTotal = New System.Windows.Forms.Label()
        Me.txtCorrectas = New System.Windows.Forms.TextBox()
        Me.txtFails = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmbTipo = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lbPlazo = New System.Windows.Forms.Label()
        Me.lbTelefono01 = New System.Windows.Forms.Label()
        Me.lbTelefono02 = New System.Windows.Forms.Label()
        Me.lbtelefono03 = New System.Windows.Forms.Label()
        Me.KryptonButton3 = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.KryptonButton1 = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.KryptonButton2 = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.KryptonButton4 = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.KryptonButton5 = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.KryptonButton6 = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Factura"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(193, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cliente"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Telefonos:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Vendedor"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(458, 114)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Telefonos:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(18, 143)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Fecha"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(204, 143)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Plazo"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(458, 143)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Fecha Cancelacion"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(18, 173)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Monto Total"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(204, 173)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Observacion"
        '
        'lvArticulos
        '
        Me.lvArticulos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lvArticulos.FullRowSelect = True
        Me.lvArticulos.HideSelection = False
        Me.lvArticulos.Location = New System.Drawing.Point(21, 203)
        Me.lvArticulos.Name = "lvArticulos"
        Me.lvArticulos.Size = New System.Drawing.Size(748, 73)
        Me.lvArticulos.TabIndex = 10
        Me.lvArticulos.UseCompatibleStateImageBehavior = False
        Me.lvArticulos.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Articulo"
        Me.ColumnHeader1.Width = 84
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Descripcion"
        Me.ColumnHeader2.Width = 394
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Cantidad"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Precio de Venta"
        Me.ColumnHeader4.Width = 91
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(21, 283)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(752, 238)
        Me.TabControl1.TabIndex = 11
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.rbD)
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
        Me.TabPage1.Size = New System.Drawing.Size(744, 212)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Bitacora"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'rbD
        '
        Me.rbD.AutoSize = True
        Me.rbD.Location = New System.Drawing.Point(218, 42)
        Me.rbD.Name = "rbD"
        Me.rbD.Size = New System.Drawing.Size(32, 17)
        Me.rbD.TabIndex = 10
        Me.rbD.TabStop = True
        Me.rbD.Text = "D"
        Me.ToolTip1.SetToolTip(Me.rbD, "Clientes no interesados, Orden desparecera de la lista")
        Me.rbD.UseVisualStyleBackColor = True
        '
        'dtProximaLlamada
        '
        Me.dtProximaLlamada.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtProximaLlamada.Location = New System.Drawing.Point(364, 40)
        Me.dtProximaLlamada.Name = "dtProximaLlamada"
        Me.dtProximaLlamada.Size = New System.Drawing.Size(134, 21)
        Me.dtProximaLlamada.TabIndex = 9
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(256, 46)
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
        Me.cmdAgregar.Location = New System.Drawing.Point(526, 23)
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(88, 36)
        Me.cmdAgregar.TabIndex = 6
        Me.cmdAgregar.Text = "Agregar"
        Me.cmdAgregar.UseVisualStyleBackColor = True
        '
        'lvObservaciones
        '
        Me.lvObservaciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvObservaciones.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader23})
        Me.lvObservaciones.FullRowSelect = True
        Me.lvObservaciones.HideSelection = False
        Me.lvObservaciones.Location = New System.Drawing.Point(9, 73)
        Me.lvObservaciones.Name = "lvObservaciones"
        Me.lvObservaciones.Size = New System.Drawing.Size(729, 133)
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
        Me.ColumnHeader6.Width = 279
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
        Me.ColumnHeader10.Width = 84
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Agente"
        Me.ColumnHeader11.Width = 75
        '
        'ColumnHeader23
        '
        Me.ColumnHeader23.Text = "Factura"
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
        Me.ToolTip1.SetToolTip(Me.rbC, "Clientes no interesados, Orden desparecera de la lista")
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
        Me.ToolTip1.SetToolTip(Me.rbB, "Reprogramar llamada")
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
        Me.ToolTip1.SetToolTip(Me.rbA, "Clientes interesados en realizar otra compra")
        Me.rbA.UseVisualStyleBackColor = True
        '
        'txtObservacion
        '
        Me.txtObservacion.Location = New System.Drawing.Point(106, 10)
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Size = New System.Drawing.Size(392, 21)
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
        Me.TabPage2.Controls.Add(Me.lvOrdenesPendientes)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(744, 212)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Ordenes Adicionales"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'lvOrdenesPendientes
        '
        Me.lvOrdenesPendientes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader14, Me.ColumnHeader16, Me.ColumnHeader17, Me.ColumnHeader18, Me.ColumnHeader19})
        Me.lvOrdenesPendientes.HideSelection = False
        Me.lvOrdenesPendientes.Location = New System.Drawing.Point(6, 15)
        Me.lvOrdenesPendientes.Name = "lvOrdenesPendientes"
        Me.lvOrdenesPendientes.Size = New System.Drawing.Size(628, 181)
        Me.lvOrdenesPendientes.TabIndex = 0
        Me.lvOrdenesPendientes.UseCompatibleStateImageBehavior = False
        Me.lvOrdenesPendientes.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Factura"
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Fecha"
        Me.ColumnHeader13.Width = 65
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "Vence"
        Me.ColumnHeader14.Width = 69
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "Descripcion"
        Me.ColumnHeader16.Width = 202
        '
        'ColumnHeader17
        '
        Me.ColumnHeader17.Text = "Ult. Pago"
        Me.ColumnHeader17.Width = 70
        '
        'ColumnHeader18
        '
        Me.ColumnHeader18.Text = "Monto Total"
        Me.ColumnHeader18.Width = 73
        '
        'ColumnHeader19
        '
        Me.ColumnHeader19.Text = "Saldo Factura"
        Me.ColumnHeader19.Width = 74
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.lvOrdenesCanceladas)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(744, 212)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Ordenes Canceladas"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'lvOrdenesCanceladas
        '
        Me.lvOrdenesCanceladas.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader15, Me.ColumnHeader20, Me.ColumnHeader21, Me.ColumnHeader22, Me.ColumnHeader24, Me.ColumnHeader25, Me.ColumnHeader26})
        Me.lvOrdenesCanceladas.HideSelection = False
        Me.lvOrdenesCanceladas.Location = New System.Drawing.Point(9, 13)
        Me.lvOrdenesCanceladas.Name = "lvOrdenesCanceladas"
        Me.lvOrdenesCanceladas.Size = New System.Drawing.Size(628, 181)
        Me.lvOrdenesCanceladas.TabIndex = 1
        Me.lvOrdenesCanceladas.UseCompatibleStateImageBehavior = False
        Me.lvOrdenesCanceladas.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "Factura"
        Me.ColumnHeader15.Width = 67
        '
        'ColumnHeader20
        '
        Me.ColumnHeader20.Text = "Fecha"
        Me.ColumnHeader20.Width = 89
        '
        'ColumnHeader21
        '
        Me.ColumnHeader21.Text = "Vence"
        Me.ColumnHeader21.Width = 84
        '
        'ColumnHeader22
        '
        Me.ColumnHeader22.Text = "Articulo"
        Me.ColumnHeader22.Width = 147
        '
        'ColumnHeader24
        '
        Me.ColumnHeader24.Text = "Ult. Pago"
        Me.ColumnHeader24.Width = 85
        '
        'ColumnHeader25
        '
        Me.ColumnHeader25.Text = "Monto Total"
        Me.ColumnHeader25.Width = 73
        '
        'ColumnHeader26
        '
        Me.ColumnHeader26.Text = "Saldo Factura"
        Me.ColumnHeader26.Width = 74
        '
        'cmdCerrar
        '
        Me.cmdCerrar.Image = CType(resources.GetObject("cmdCerrar.Image"), System.Drawing.Image)
        Me.cmdCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCerrar.Location = New System.Drawing.Point(217, 527)
        Me.cmdCerrar.Name = "cmdCerrar"
        Me.cmdCerrar.Size = New System.Drawing.Size(114, 27)
        Me.cmdCerrar.TabIndex = 12
        Me.cmdCerrar.Text = "Cerrar"
        Me.cmdCerrar.UseVisualStyleBackColor = True
        '
        'cmdDesbloquear
        '
        Me.cmdDesbloquear.Image = CType(resources.GetObject("cmdDesbloquear.Image"), System.Drawing.Image)
        Me.cmdDesbloquear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdDesbloquear.Location = New System.Drawing.Point(337, 527)
        Me.cmdDesbloquear.Name = "cmdDesbloquear"
        Me.cmdDesbloquear.Size = New System.Drawing.Size(114, 27)
        Me.cmdDesbloquear.TabIndex = 13
        Me.cmdDesbloquear.Text = "Desbloquear"
        Me.cmdDesbloquear.UseVisualStyleBackColor = True
        '
        'lbFactura
        '
        Me.lbFactura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbFactura.Location = New System.Drawing.Point(89, 20)
        Me.lbFactura.Name = "lbFactura"
        Me.lbFactura.Size = New System.Drawing.Size(96, 18)
        Me.lbFactura.TabIndex = 14
        '
        'lbCliente
        '
        Me.lbCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbCliente.Location = New System.Drawing.Point(245, 24)
        Me.lbCliente.Name = "lbCliente"
        Me.lbCliente.Size = New System.Drawing.Size(491, 18)
        Me.lbCliente.TabIndex = 15
        '
        'lbVendedor
        '
        Me.lbVendedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbVendedor.Location = New System.Drawing.Point(89, 113)
        Me.lbVendedor.Name = "lbVendedor"
        Me.lbVendedor.Size = New System.Drawing.Size(354, 18)
        Me.lbVendedor.TabIndex = 17
        '
        'lbTelefonoVendedor
        '
        Me.lbTelefonoVendedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbTelefonoVendedor.Location = New System.Drawing.Point(529, 113)
        Me.lbTelefonoVendedor.Name = "lbTelefonoVendedor"
        Me.lbTelefonoVendedor.Size = New System.Drawing.Size(207, 18)
        Me.lbTelefonoVendedor.TabIndex = 18
        '
        'lbFecha
        '
        Me.lbFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbFecha.Location = New System.Drawing.Point(89, 142)
        Me.lbFecha.Name = "lbFecha"
        Me.lbFecha.Size = New System.Drawing.Size(98, 18)
        Me.lbFecha.TabIndex = 19
        '
        'lbFechaVencimiento
        '
        Me.lbFechaVencimiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbFechaVencimiento.Location = New System.Drawing.Point(354, 142)
        Me.lbFechaVencimiento.Name = "lbFechaVencimiento"
        Me.lbFechaVencimiento.Size = New System.Drawing.Size(92, 18)
        Me.lbFechaVencimiento.TabIndex = 20
        '
        'lbFechaCancelacion
        '
        Me.lbFechaCancelacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbFechaCancelacion.Location = New System.Drawing.Point(574, 142)
        Me.lbFechaCancelacion.Name = "lbFechaCancelacion"
        Me.lbFechaCancelacion.Size = New System.Drawing.Size(89, 18)
        Me.lbFechaCancelacion.TabIndex = 21
        '
        'lbMontoTotal
        '
        Me.lbMontoTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbMontoTotal.Location = New System.Drawing.Point(101, 172)
        Me.lbMontoTotal.Name = "lbMontoTotal"
        Me.lbMontoTotal.Size = New System.Drawing.Size(86, 18)
        Me.lbMontoTotal.TabIndex = 22
        '
        'txtCorrectas
        '
        Me.txtCorrectas.Location = New System.Drawing.Point(295, 170)
        Me.txtCorrectas.Name = "txtCorrectas"
        Me.txtCorrectas.Size = New System.Drawing.Size(36, 21)
        Me.txtCorrectas.TabIndex = 23
        Me.ToolTip1.SetToolTip(Me.txtCorrectas, "Cuotas Canceladas antes o en la fecha correspondiente de la cuota")
        '
        'txtFails
        '
        Me.txtFails.Location = New System.Drawing.Point(337, 170)
        Me.txtFails.Name = "txtFails"
        Me.txtFails.Size = New System.Drawing.Size(39, 21)
        Me.txtFails.TabIndex = 24
        Me.ToolTip1.SetToolTip(Me.txtFails, "Cuotas Canceladas despues a fecha correspondiente de la cuota")
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Informacion"
        '
        'cmbTipo
        '
        Me.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipo.FormattingEnabled = True
        Me.cmbTipo.Location = New System.Drawing.Point(461, 170)
        Me.cmbTipo.Name = "cmbTipo"
        Me.cmbTipo.Size = New System.Drawing.Size(126, 21)
        Me.cmbTipo.TabIndex = 27
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(402, 173)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(49, 13)
        Me.Label14.TabIndex = 28
        Me.Label14.Text = "Interes"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(308, 143)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(41, 13)
        Me.Label15.TabIndex = 29
        Me.Label15.Text = "Vence"
        '
        'lbPlazo
        '
        Me.lbPlazo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbPlazo.Location = New System.Drawing.Point(243, 142)
        Me.lbPlazo.Name = "lbPlazo"
        Me.lbPlazo.Size = New System.Drawing.Size(59, 18)
        Me.lbPlazo.TabIndex = 30
        '
        'lbTelefono01
        '
        Me.lbTelefono01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbTelefono01.Location = New System.Drawing.Point(89, 59)
        Me.lbTelefono01.Name = "lbTelefono01"
        Me.lbTelefono01.Size = New System.Drawing.Size(150, 18)
        Me.lbTelefono01.TabIndex = 31
        '
        'lbTelefono02
        '
        Me.lbTelefono02.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbTelefono02.Location = New System.Drawing.Point(308, 59)
        Me.lbTelefono02.Name = "lbTelefono02"
        Me.lbTelefono02.Size = New System.Drawing.Size(150, 18)
        Me.lbTelefono02.TabIndex = 32
        '
        'lbtelefono03
        '
        Me.lbtelefono03.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbtelefono03.Location = New System.Drawing.Point(529, 60)
        Me.lbtelefono03.Name = "lbtelefono03"
        Me.lbtelefono03.Size = New System.Drawing.Size(150, 18)
        Me.lbtelefono03.TabIndex = 33
        '
        'KryptonButton3
        '
        Me.KryptonButton3.Location = New System.Drawing.Point(272, 53)
        Me.KryptonButton3.Name = "KryptonButton3"
        Me.KryptonButton3.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.KryptonButton3.Size = New System.Drawing.Size(30, 25)
        Me.KryptonButton3.TabIndex = 153
        Me.KryptonButton3.Values.Image = Global.ServicioalCliente.My.Resources.Resources.whatsapp_16
        Me.KryptonButton3.Values.Text = ""
        '
        'KryptonButton1
        '
        Me.KryptonButton1.Location = New System.Drawing.Point(493, 53)
        Me.KryptonButton1.Name = "KryptonButton1"
        Me.KryptonButton1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.KryptonButton1.Size = New System.Drawing.Size(30, 25)
        Me.KryptonButton1.TabIndex = 154
        Me.KryptonButton1.Values.Image = Global.ServicioalCliente.My.Resources.Resources.whatsapp_16
        Me.KryptonButton1.Values.Text = ""
        '
        'KryptonButton2
        '
        Me.KryptonButton2.Location = New System.Drawing.Point(721, 53)
        Me.KryptonButton2.Name = "KryptonButton2"
        Me.KryptonButton2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.KryptonButton2.Size = New System.Drawing.Size(30, 25)
        Me.KryptonButton2.TabIndex = 155
        Me.KryptonButton2.Values.Image = Global.ServicioalCliente.My.Resources.Resources.whatsapp_16
        Me.KryptonButton2.Values.Text = ""
        '
        'KryptonButton4
        '
        Me.KryptonButton4.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Gallery
        Me.KryptonButton4.Location = New System.Drawing.Point(245, 53)
        Me.KryptonButton4.Name = "KryptonButton4"
        Me.KryptonButton4.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.KryptonButton4.Size = New System.Drawing.Size(30, 25)
        Me.KryptonButton4.TabIndex = 156
        Me.KryptonButton4.Values.Image = Global.ServicioalCliente.My.Resources.Resources.phone_16
        Me.KryptonButton4.Values.Text = ""
        '
        'KryptonButton5
        '
        Me.KryptonButton5.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Gallery
        Me.KryptonButton5.Location = New System.Drawing.Point(464, 53)
        Me.KryptonButton5.Name = "KryptonButton5"
        Me.KryptonButton5.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.KryptonButton5.Size = New System.Drawing.Size(30, 25)
        Me.KryptonButton5.TabIndex = 157
        Me.KryptonButton5.Values.Image = Global.ServicioalCliente.My.Resources.Resources.phone_16
        Me.KryptonButton5.Values.Text = ""
        '
        'KryptonButton6
        '
        Me.KryptonButton6.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Gallery
        Me.KryptonButton6.Location = New System.Drawing.Point(685, 53)
        Me.KryptonButton6.Name = "KryptonButton6"
        Me.KryptonButton6.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.KryptonButton6.Size = New System.Drawing.Size(30, 25)
        Me.KryptonButton6.TabIndex = 158
        Me.KryptonButton6.Values.Image = Global.ServicioalCliente.My.Resources.Resources.phone_16
        Me.KryptonButton6.Values.Text = ""
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(18, 87)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(40, 13)
        Me.Label16.TabIndex = 159
        Me.Label16.Text = "Email:"
        '
        'txtEmail
        '
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmail.Location = New System.Drawing.Point(89, 86)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(590, 18)
        Me.txtEmail.TabIndex = 160
        '
        'frmSeguimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(785, 563)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.KryptonButton6)
        Me.Controls.Add(Me.KryptonButton5)
        Me.Controls.Add(Me.KryptonButton4)
        Me.Controls.Add(Me.KryptonButton2)
        Me.Controls.Add(Me.KryptonButton1)
        Me.Controls.Add(Me.KryptonButton3)
        Me.Controls.Add(Me.lbtelefono03)
        Me.Controls.Add(Me.lbTelefono02)
        Me.Controls.Add(Me.lbTelefono01)
        Me.Controls.Add(Me.lbPlazo)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.cmbTipo)
        Me.Controls.Add(Me.txtFails)
        Me.Controls.Add(Me.txtCorrectas)
        Me.Controls.Add(Me.lbMontoTotal)
        Me.Controls.Add(Me.lbFechaCancelacion)
        Me.Controls.Add(Me.lbFechaVencimiento)
        Me.Controls.Add(Me.lbFecha)
        Me.Controls.Add(Me.lbTelefonoVendedor)
        Me.Controls.Add(Me.lbVendedor)
        Me.Controls.Add(Me.lbCliente)
        Me.Controls.Add(Me.lbFactura)
        Me.Controls.Add(Me.cmdDesbloquear)
        Me.Controls.Add(Me.cmdCerrar)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.lvArticulos)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSeguimiento"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Post-Venta"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lvArticulos As System.Windows.Forms.ListView
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents cmdCerrar As System.Windows.Forms.Button
    Friend WithEvents cmdDesbloquear As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cmdAgregar As System.Windows.Forms.Button
    Friend WithEvents lvObservaciones As System.Windows.Forms.ListView
    Friend WithEvents rbC As System.Windows.Forms.RadioButton
    Friend WithEvents rbB As System.Windows.Forms.RadioButton
    Friend WithEvents rbA As System.Windows.Forms.RadioButton
    Friend WithEvents txtObservacion As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lbFactura As System.Windows.Forms.Label
    Friend WithEvents lbCliente As System.Windows.Forms.Label
    Friend WithEvents lbVendedor As System.Windows.Forms.Label
    Friend WithEvents lbTelefonoVendedor As System.Windows.Forms.Label
    Friend WithEvents lbFecha As System.Windows.Forms.Label
    Friend WithEvents lbFechaVencimiento As System.Windows.Forms.Label
    Friend WithEvents lbFechaCancelacion As System.Windows.Forms.Label
    Friend WithEvents lbMontoTotal As System.Windows.Forms.Label
    Friend WithEvents txtCorrectas As System.Windows.Forms.TextBox
    Friend WithEvents txtFails As System.Windows.Forms.TextBox
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents dtProximaLlamada As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents lvOrdenesPendientes As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader16 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader17 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader18 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader19 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvOrdenesCanceladas As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader20 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader21 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader22 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader24 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader25 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader26 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmbTipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lbPlazo As System.Windows.Forms.Label
    Friend WithEvents rbD As System.Windows.Forms.RadioButton
    Friend WithEvents lbTelefono01 As Label
    Friend WithEvents lbTelefono02 As Label
    Friend WithEvents lbtelefono03 As Label
    Friend WithEvents KryptonButton3 As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents KryptonButton1 As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents KryptonButton2 As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents KryptonButton4 As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents KryptonButton5 As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents KryptonButton6 As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents ColumnHeader23 As ColumnHeader
    Friend WithEvents Label16 As Label
    Friend WithEvents txtEmail As Label
End Class
