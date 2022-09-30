<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVendedores
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVendedores))
        Me.lstImages = New System.Windows.Forms.ImageList(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ckDistrito = New System.Windows.Forms.CheckBox()
        Me.ckCanton = New System.Windows.Forms.CheckBox()
        Me.cmbDistrito = New System.Windows.Forms.ComboBox()
        Me.cmbCanton = New System.Windows.Forms.ComboBox()
        Me.cmbProvincia = New System.Windows.Forms.ComboBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tssLbCierre = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tspbLoading = New System.Windows.Forms.ToolStripProgressBar()
        Me.lvVendedores = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.popupEditVendedor = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ModificarCorreoElectronicoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.DesactivarVendedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.EstadoVerdeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstadoAmarilloToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstadoRojoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton8 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.txtBuscar = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSplitButton1 = New System.Windows.Forms.ToolStripSplitButton()
        Me.InformeDeSeguimientoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsistenciaActividadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VendedoresInactivosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.StatusStrip1.SuspendLayout()
        Me.popupEditVendedor.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstImages
        '
        Me.lstImages.ImageStream = CType(resources.GetObject("lstImages.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.lstImages.TransparentColor = System.Drawing.Color.Transparent
        Me.lstImages.Images.SetKeyName(0, "User-green-icon.png")
        Me.lstImages.Images.SetKeyName(1, "User-yellow-icon.png")
        Me.lstImages.Images.SetKeyName(2, "User-red-icon.png")
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(836, 48)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(117, 28)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Mostrar Todos"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ckDistrito
        '
        Me.ckDistrito.AutoSize = True
        Me.ckDistrito.Location = New System.Drawing.Point(521, 54)
        Me.ckDistrito.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ckDistrito.Name = "ckDistrito"
        Me.ckDistrito.Size = New System.Drawing.Size(15, 14)
        Me.ckDistrito.TabIndex = 18
        Me.ckDistrito.UseVisualStyleBackColor = True
        '
        'ckCanton
        '
        Me.ckCanton.AutoSize = True
        Me.ckCanton.Location = New System.Drawing.Point(255, 54)
        Me.ckCanton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ckCanton.Name = "ckCanton"
        Me.ckCanton.Size = New System.Drawing.Size(15, 14)
        Me.ckCanton.TabIndex = 17
        Me.ckCanton.UseVisualStyleBackColor = True
        '
        'cmbDistrito
        '
        Me.cmbDistrito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDistrito.Enabled = False
        Me.cmbDistrito.FormattingEnabled = True
        Me.cmbDistrito.Location = New System.Drawing.Point(546, 50)
        Me.cmbDistrito.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbDistrito.Name = "cmbDistrito"
        Me.cmbDistrito.Size = New System.Drawing.Size(234, 24)
        Me.cmbDistrito.TabIndex = 15
        '
        'cmbCanton
        '
        Me.cmbCanton.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCanton.Enabled = False
        Me.cmbCanton.FormattingEnabled = True
        Me.cmbCanton.Location = New System.Drawing.Point(280, 50)
        Me.cmbCanton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbCanton.Name = "cmbCanton"
        Me.cmbCanton.Size = New System.Drawing.Size(234, 24)
        Me.cmbCanton.TabIndex = 14
        '
        'cmbProvincia
        '
        Me.cmbProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProvincia.FormattingEnabled = True
        Me.cmbProvincia.Location = New System.Drawing.Point(14, 50)
        Me.cmbProvincia.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbProvincia.Name = "cmbProvincia"
        Me.cmbProvincia.Size = New System.Drawing.Size(234, 24)
        Me.cmbProvincia.TabIndex = 13
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tssLbCierre, Me.tspbLoading})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 612)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 16, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1275, 26)
        Me.StatusStrip1.TabIndex = 12
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tssLbCierre
        '
        Me.tssLbCierre.Name = "tssLbCierre"
        Me.tssLbCierre.Size = New System.Drawing.Size(0, 21)
        '
        'tspbLoading
        '
        Me.tspbLoading.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tspbLoading.Name = "tspbLoading"
        Me.tspbLoading.Size = New System.Drawing.Size(117, 20)
        Me.tspbLoading.Step = 1
        Me.tspbLoading.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        '
        'lvVendedores
        '
        Me.lvVendedores.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvVendedores.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader6, Me.ColumnHeader5, Me.ColumnHeader7})
        Me.lvVendedores.ContextMenuStrip = Me.popupEditVendedor
        Me.lvVendedores.FullRowSelect = True
        Me.lvVendedores.GridLines = True
        Me.lvVendedores.Location = New System.Drawing.Point(14, 99)
        Me.lvVendedores.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lvVendedores.Name = "lvVendedores"
        Me.lvVendedores.Size = New System.Drawing.Size(1256, 503)
        Me.lvVendedores.SmallImageList = Me.lstImages
        Me.lvVendedores.TabIndex = 11
        Me.lvVendedores.UseCompatibleStateImageBehavior = False
        Me.lvVendedores.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Vendedor"
        Me.ColumnHeader1.Width = 83
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Contrato"
        Me.ColumnHeader2.Width = 64
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Nombre"
        Me.ColumnHeader3.Width = 315
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Ult. Venta"
        Me.ColumnHeader4.Width = 85
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Llamada Ant."
        Me.ColumnHeader6.Width = 92
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Proxima Llamada"
        Me.ColumnHeader5.Width = 75
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Correo Electronico"
        Me.ColumnHeader7.Width = 230
        '
        'popupEditVendedor
        '
        Me.popupEditVendedor.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.popupEditVendedor.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModificarCorreoElectronicoToolStripMenuItem, Me.ToolStripSeparator9, Me.DesactivarVendedorToolStripMenuItem, Me.ToolStripSeparator8, Me.EstadoVerdeToolStripMenuItem, Me.EstadoAmarilloToolStripMenuItem, Me.EstadoRojoToolStripMenuItem})
        Me.popupEditVendedor.Name = "popupEditVendedor"
        Me.popupEditVendedor.Size = New System.Drawing.Size(227, 126)
        '
        'ModificarCorreoElectronicoToolStripMenuItem
        '
        Me.ModificarCorreoElectronicoToolStripMenuItem.Image = Global.ServicioalCliente.My.Resources.Resources.edit
        Me.ModificarCorreoElectronicoToolStripMenuItem.Name = "ModificarCorreoElectronicoToolStripMenuItem"
        Me.ModificarCorreoElectronicoToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.ModificarCorreoElectronicoToolStripMenuItem.Text = "Modificar Correo Electronico"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(223, 6)
        '
        'DesactivarVendedorToolStripMenuItem
        '
        Me.DesactivarVendedorToolStripMenuItem.Image = Global.ServicioalCliente.My.Resources.Resources.cancel
        Me.DesactivarVendedorToolStripMenuItem.Name = "DesactivarVendedorToolStripMenuItem"
        Me.DesactivarVendedorToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.DesactivarVendedorToolStripMenuItem.Text = "Vendedor Inactivo"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(223, 6)
        '
        'EstadoVerdeToolStripMenuItem
        '
        Me.EstadoVerdeToolStripMenuItem.Image = Global.ServicioalCliente.My.Resources.Resources.green
        Me.EstadoVerdeToolStripMenuItem.Name = "EstadoVerdeToolStripMenuItem"
        Me.EstadoVerdeToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.EstadoVerdeToolStripMenuItem.Text = "Estado Verde"
        '
        'EstadoAmarilloToolStripMenuItem
        '
        Me.EstadoAmarilloToolStripMenuItem.Image = Global.ServicioalCliente.My.Resources.Resources.yellow
        Me.EstadoAmarilloToolStripMenuItem.Name = "EstadoAmarilloToolStripMenuItem"
        Me.EstadoAmarilloToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.EstadoAmarilloToolStripMenuItem.Text = "Estado Amarillo"
        '
        'EstadoRojoToolStripMenuItem
        '
        Me.EstadoRojoToolStripMenuItem.Image = Global.ServicioalCliente.My.Resources.Resources.red
        Me.EstadoRojoToolStripMenuItem.Name = "EstadoRojoToolStripMenuItem"
        Me.EstadoRojoToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.EstadoRojoToolStripMenuItem.Text = "Estado Rojo"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripSeparator1, Me.ToolStripButton2, Me.ToolStripSeparator2, Me.ToolStripButton6, Me.ToolStripSeparator5, Me.ToolStripButton7, Me.ToolStripSeparator10, Me.ToolStripButton8, Me.ToolStripSeparator7, Me.ToolStripLabel1, Me.txtBuscar, Me.ToolStripButton4, Me.ToolStripSeparator6, Me.ToolStripButton3, Me.ToolStripSeparator3, Me.ToolStripSplitButton1, Me.ToolStripSeparator4, Me.ToolStripButton5})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1275, 25)
        Me.ToolStrip1.TabIndex = 21
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = Global.ServicioalCliente.My.Resources.Resources.edit
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(70, 22)
        Me.ToolStripButton1.Text = "Bitacora"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = Global.ServicioalCliente.My.Resources.Resources.unlock
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(93, 22)
        Me.ToolStripButton2.Text = "Desbloquear"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.Image = Global.ServicioalCliente.My.Resources.Resources.actividad
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New System.Drawing.Size(108, 22)
        Me.ToolStripButton6.Text = "Crear Actividad"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.Image = Global.ServicioalCliente.My.Resources.Resources.join
        Me.ToolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.Size = New System.Drawing.Size(133, 22)
        Me.ToolStripButton7.Text = "Asistencia Actividad"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton8
        '
        Me.ToolStripButton8.Image = Global.ServicioalCliente.My.Resources.Resources.actividad
        Me.ToolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton8.Name = "ToolStripButton8"
        Me.ToolStripButton8.Size = New System.Drawing.Size(88, 22)
        Me.ToolStripButton8.Text = "Actividades"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(42, 22)
        Me.ToolStripLabel1.Text = "Buscar"
        '
        'txtBuscar
        '
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(233, 25)
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = Global.ServicioalCliente.My.Resources.Resources.find2
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton4.Text = "Buscar"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Image = Global.ServicioalCliente.My.Resources.Resources.reload
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(75, 22)
        Me.ToolStripButton3.Text = "Refrescar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSplitButton1
        '
        Me.ToolStripSplitButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InformeDeSeguimientoToolStripMenuItem, Me.AsistenciaActividadToolStripMenuItem, Me.VendedoresInactivosToolStripMenuItem})
        Me.ToolStripSplitButton1.Image = Global.ServicioalCliente.My.Resources.Resources.printer
        Me.ToolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSplitButton1.Name = "ToolStripSplitButton1"
        Me.ToolStripSplitButton1.Size = New System.Drawing.Size(86, 22)
        Me.ToolStripSplitButton1.Text = "Informes"
        '
        'InformeDeSeguimientoToolStripMenuItem
        '
        Me.InformeDeSeguimientoToolStripMenuItem.Name = "InformeDeSeguimientoToolStripMenuItem"
        Me.InformeDeSeguimientoToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.InformeDeSeguimientoToolStripMenuItem.Text = "Seguimiento"
        '
        'AsistenciaActividadToolStripMenuItem
        '
        Me.AsistenciaActividadToolStripMenuItem.Name = "AsistenciaActividadToolStripMenuItem"
        Me.AsistenciaActividadToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.AsistenciaActividadToolStripMenuItem.Text = "Asistencia Actividad"
        '
        'VendedoresInactivosToolStripMenuItem
        '
        Me.VendedoresInactivosToolStripMenuItem.Name = "VendedoresInactivosToolStripMenuItem"
        Me.VendedoresInactivosToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.VendedoresInactivosToolStripMenuItem.Text = "Vendedores Inactivos"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.Image = Global.ServicioalCliente.My.Resources.Resources.door
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(59, 22)
        Me.ToolStripButton5.Text = "Cerrar"
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Image = Global.ServicioalCliente.My.Resources.Resources.viewmag
        Me.cmdBuscar.Location = New System.Drawing.Point(787, 47)
        Me.cmdBuscar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(42, 31)
        Me.cmdBuscar.TabIndex = 16
        Me.cmdBuscar.UseVisualStyleBackColor = True
        '
        'frmVendedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1275, 638)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ckDistrito)
        Me.Controls.Add(Me.ckCanton)
        Me.Controls.Add(Me.cmdBuscar)
        Me.Controls.Add(Me.cmbDistrito)
        Me.Controls.Add(Me.cmbCanton)
        Me.Controls.Add(Me.cmbProvincia)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.lvVendedores)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmVendedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seguimiento Vendedores"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.popupEditVendedor.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ckDistrito As System.Windows.Forms.CheckBox
    Friend WithEvents ckCanton As System.Windows.Forms.CheckBox
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents cmbDistrito As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCanton As System.Windows.Forms.ComboBox
    Friend WithEvents cmbProvincia As System.Windows.Forms.ComboBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents tssLbCierre As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tspbLoading As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents lvVendedores As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton6 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton7 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtBuscar As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSplitButton1 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents InformeDeSeguimientoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AsistenciaActividadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VendedoresInactivosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents popupEditVendedor As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ModificarCorreoElectronicoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DesactivarVendedorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EstadoVerdeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EstadoAmarilloToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EstadoRojoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton8 As System.Windows.Forms.ToolStripButton
    Friend WithEvents lstImages As System.Windows.Forms.ImageList
End Class
