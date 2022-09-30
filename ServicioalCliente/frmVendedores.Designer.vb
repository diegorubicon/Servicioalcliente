<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmVendedores
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVendedores))
        Me.lstImages = New System.Windows.Forms.ImageList(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tssLbCierre = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tspbLoading = New System.Windows.Forms.ToolStripProgressBar()
        Me.tsslCancel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.popupEditVendedor = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ModificarCorreoElectronicoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.DesactivarVendedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.EstadoVerdeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstadoAmarilloToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstadoRojoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.EnviarWhatsAppToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.KryptonDropButton1 = New ComponentFactory.Krypton.Toolkit.KryptonDropButton()
        Me.KryptonContextMenu1 = New ComponentFactory.Krypton.Toolkit.KryptonContextMenu()
        Me.KryptonContextMenuHeading1 = New ComponentFactory.Krypton.Toolkit.KryptonContextMenuHeading()
        Me.KryptonContextMenuItems2 = New ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems()
        Me.KryptonContextMenuItem1 = New ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem()
        Me.KryptonContextMenuItem2 = New ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.lvVendedores = New System.Windows.Forms.ListView()
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ckDistrito = New System.Windows.Forms.CheckBox()
        Me.ckCanton = New System.Windows.Forms.CheckBox()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.cmbDistrito = New System.Windows.Forms.ComboBox()
        Me.cmbCanton = New System.Windows.Forms.ComboBox()
        Me.cmbProvincia = New System.Windows.Forms.ComboBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.bcpC = New Bunifu.Framework.UI.BunifuCircleProgressbar()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.bcpA = New Bunifu.Framework.UI.BunifuCircleProgressbar()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.bcpB = New Bunifu.Framework.UI.BunifuCircleProgressbar()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lvContactados = New System.Windows.Forms.ListView()
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.KryptonContextMenuItems1 = New ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems()
        Me.StatusStrip1.SuspendLayout()
        Me.popupEditVendedor.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
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
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tssLbCierre, Me.tspbLoading, Me.tsslCancel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 616)
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
        'tsslCancel
        '
        Me.tsslCancel.Image = Global.ServicioalCliente.My.Resources.Resources.cancel
        Me.tsslCancel.Name = "tsslCancel"
        Me.tsslCancel.Size = New System.Drawing.Size(16, 21)
        '
        'popupEditVendedor
        '
        Me.popupEditVendedor.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.popupEditVendedor.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModificarCorreoElectronicoToolStripMenuItem, Me.ToolStripSeparator9, Me.DesactivarVendedorToolStripMenuItem, Me.ToolStripSeparator8, Me.EstadoVerdeToolStripMenuItem, Me.EstadoAmarilloToolStripMenuItem, Me.EstadoRojoToolStripMenuItem, Me.ToolStripMenuItem1, Me.EnviarWhatsAppToolStripMenuItem})
        Me.popupEditVendedor.Name = "popupEditVendedor"
        Me.popupEditVendedor.Size = New System.Drawing.Size(227, 154)
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
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(223, 6)
        '
        'EnviarWhatsAppToolStripMenuItem
        '
        Me.EnviarWhatsAppToolStripMenuItem.Name = "EnviarWhatsAppToolStripMenuItem"
        Me.EnviarWhatsAppToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
        Me.EnviarWhatsAppToolStripMenuItem.Text = "Enviar WhatsApp"
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
        Me.InformeDeSeguimientoToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.InformeDeSeguimientoToolStripMenuItem.Text = "Seguimiento"
        '
        'AsistenciaActividadToolStripMenuItem
        '
        Me.AsistenciaActividadToolStripMenuItem.Name = "AsistenciaActividadToolStripMenuItem"
        Me.AsistenciaActividadToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.AsistenciaActividadToolStripMenuItem.Text = "Asistencia Actividad"
        '
        'VendedoresInactivosToolStripMenuItem
        '
        Me.VendedoresInactivosToolStripMenuItem.Name = "VendedoresInactivosToolStripMenuItem"
        Me.VendedoresInactivosToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
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
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 25)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1275, 591)
        Me.TabControl1.TabIndex = 22
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.KryptonDropButton1)
        Me.TabPage1.Controls.Add(Me.CheckBox2)
        Me.TabPage1.Controls.Add(Me.lvVendedores)
        Me.TabPage1.Controls.Add(Me.CheckBox1)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.ckDistrito)
        Me.TabPage1.Controls.Add(Me.ckCanton)
        Me.TabPage1.Controls.Add(Me.cmdBuscar)
        Me.TabPage1.Controls.Add(Me.cmbDistrito)
        Me.TabPage1.Controls.Add(Me.cmbCanton)
        Me.TabPage1.Controls.Add(Me.cmbProvincia)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1267, 562)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Listado de Vendedores"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'KryptonDropButton1
        '
        Me.KryptonDropButton1.KryptonContextMenu = Me.KryptonContextMenu1
        Me.KryptonDropButton1.Location = New System.Drawing.Point(1139, 51)
        Me.KryptonDropButton1.Name = "KryptonDropButton1"
        Me.KryptonDropButton1.Size = New System.Drawing.Size(108, 24)
        Me.KryptonDropButton1.TabIndex = 33
        Me.KryptonDropButton1.Values.Text = "Agrupar"
        '
        'KryptonContextMenu1
        '
        Me.KryptonContextMenu1.Items.AddRange(New ComponentFactory.Krypton.Toolkit.KryptonContextMenuItemBase() {Me.KryptonContextMenuHeading1, Me.KryptonContextMenuItems2})
        '
        'KryptonContextMenuHeading1
        '
        Me.KryptonContextMenuHeading1.ExtraText = ""
        Me.KryptonContextMenuHeading1.Text = "Agrupar Por"
        '
        'KryptonContextMenuItems2
        '
        Me.KryptonContextMenuItems2.Items.AddRange(New ComponentFactory.Krypton.Toolkit.KryptonContextMenuItemBase() {Me.KryptonContextMenuItem1, Me.KryptonContextMenuItem2})
        '
        'KryptonContextMenuItem1
        '
        Me.KryptonContextMenuItem1.Text = "Dias"
        '
        'KryptonContextMenuItem2
        '
        Me.KryptonContextMenuItem2.Text = "Años"
        '
        'CheckBox2
        '
        Me.CheckBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(1010, 20)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(237, 20)
        Me.CheckBox2.TabIndex = 32
        Me.CheckBox2.Text = "No mostrar vendedores en estado Rojo"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'lvVendedores
        '
        Me.lvVendedores.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvVendedores.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader8, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader6, Me.ColumnHeader5, Me.ColumnHeader7, Me.ColumnHeader10, Me.ColumnHeader11})
        Me.lvVendedores.ContextMenuStrip = Me.popupEditVendedor
        Me.lvVendedores.FullRowSelect = True
        Me.lvVendedores.GridLines = True
        Me.lvVendedores.HideSelection = False
        Me.lvVendedores.Location = New System.Drawing.Point(19, 82)
        Me.lvVendedores.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lvVendedores.Name = "lvVendedores"
        Me.lvVendedores.Size = New System.Drawing.Size(1228, 460)
        Me.lvVendedores.SmallImageList = Me.lstImages
        Me.lvVendedores.TabIndex = 23
        Me.lvVendedores.UseCompatibleStateImageBehavior = False
        Me.lvVendedores.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = ""
        Me.ColumnHeader8.Width = 18
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
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Ult. Estado"
        Me.ColumnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Dias sin contacto"
        Me.ColumnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader11.Width = 116
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(19, 21)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox1.TabIndex = 31
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(885, 13)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(117, 28)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "Mostrar Todos"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ckDistrito
        '
        Me.ckDistrito.AutoSize = True
        Me.ckDistrito.Location = New System.Drawing.Point(565, 21)
        Me.ckDistrito.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ckDistrito.Name = "ckDistrito"
        Me.ckDistrito.Size = New System.Drawing.Size(15, 14)
        Me.ckDistrito.TabIndex = 29
        Me.ckDistrito.UseVisualStyleBackColor = True
        '
        'ckCanton
        '
        Me.ckCanton.AutoSize = True
        Me.ckCanton.Location = New System.Drawing.Point(290, 21)
        Me.ckCanton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ckCanton.Name = "ckCanton"
        Me.ckCanton.Size = New System.Drawing.Size(15, 14)
        Me.ckCanton.TabIndex = 28
        Me.ckCanton.UseVisualStyleBackColor = True
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Image = Global.ServicioalCliente.My.Resources.Resources.viewmag
        Me.cmdBuscar.Location = New System.Drawing.Point(837, 12)
        Me.cmdBuscar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(42, 31)
        Me.cmdBuscar.TabIndex = 27
        Me.cmdBuscar.UseVisualStyleBackColor = True
        '
        'cmbDistrito
        '
        Me.cmbDistrito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDistrito.Enabled = False
        Me.cmbDistrito.FormattingEnabled = True
        Me.cmbDistrito.Location = New System.Drawing.Point(586, 16)
        Me.cmbDistrito.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbDistrito.Name = "cmbDistrito"
        Me.cmbDistrito.Size = New System.Drawing.Size(234, 24)
        Me.cmbDistrito.TabIndex = 26
        '
        'cmbCanton
        '
        Me.cmbCanton.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCanton.Enabled = False
        Me.cmbCanton.FormattingEnabled = True
        Me.cmbCanton.Location = New System.Drawing.Point(311, 16)
        Me.cmbCanton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbCanton.Name = "cmbCanton"
        Me.cmbCanton.Size = New System.Drawing.Size(234, 24)
        Me.cmbCanton.TabIndex = 25
        '
        'cmbProvincia
        '
        Me.cmbProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProvincia.Enabled = False
        Me.cmbProvincia.FormattingEnabled = True
        Me.cmbProvincia.Location = New System.Drawing.Point(42, 16)
        Me.cmbProvincia.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbProvincia.Name = "cmbProvincia"
        Me.cmbProvincia.Size = New System.Drawing.Size(234, 24)
        Me.cmbProvincia.TabIndex = 24
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.Panel2)
        Me.TabPage2.Controls.Add(Me.Panel4)
        Me.TabPage2.Controls.Add(Me.Panel3)
        Me.TabPage2.Controls.Add(Me.Panel1)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1267, 562)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "DashBoard"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.bcpC)
        Me.Panel2.Location = New System.Drawing.Point(958, 63)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(170, 188)
        Me.Panel2.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("LuzSans-Book", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gray
        Me.Label5.Location = New System.Drawing.Point(13, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 22)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Estado: C"
        '
        'bcpC
        '
        Me.bcpC.animated = False
        Me.bcpC.animationIterval = 5
        Me.bcpC.animationSpeed = 300
        Me.bcpC.BackColor = System.Drawing.Color.White
        Me.bcpC.BackgroundImage = CType(resources.GetObject("bcpC.BackgroundImage"), System.Drawing.Image)
        Me.bcpC.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!)
        Me.bcpC.ForeColor = System.Drawing.Color.Crimson
        Me.bcpC.LabelVisible = False
        Me.bcpC.LineProgressThickness = 8
        Me.bcpC.LineThickness = 5
        Me.bcpC.Location = New System.Drawing.Point(26, 35)
        Me.bcpC.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.bcpC.MaxValue = 100
        Me.bcpC.Name = "bcpC"
        Me.bcpC.ProgressBackColor = System.Drawing.Color.Gainsboro
        Me.bcpC.ProgressColor = System.Drawing.Color.Crimson
        Me.bcpC.Size = New System.Drawing.Size(119, 119)
        Me.bcpC.TabIndex = 1
        Me.bcpC.Value = 0
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.bcpA)
        Me.Panel4.Location = New System.Drawing.Point(571, 63)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(170, 188)
        Me.Panel4.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("LuzSans-Book", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gray
        Me.Label3.Location = New System.Drawing.Point(20, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 22)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Estado: A"
        '
        'bcpA
        '
        Me.bcpA.animated = False
        Me.bcpA.animationIterval = 5
        Me.bcpA.animationSpeed = 300
        Me.bcpA.BackColor = System.Drawing.Color.White
        Me.bcpA.BackgroundImage = CType(resources.GetObject("bcpA.BackgroundImage"), System.Drawing.Image)
        Me.bcpA.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!)
        Me.bcpA.ForeColor = System.Drawing.Color.SeaGreen
        Me.bcpA.LabelVisible = False
        Me.bcpA.LineProgressThickness = 8
        Me.bcpA.LineThickness = 5
        Me.bcpA.Location = New System.Drawing.Point(24, 42)
        Me.bcpA.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.bcpA.MaxValue = 100
        Me.bcpA.Name = "bcpA"
        Me.bcpA.ProgressBackColor = System.Drawing.Color.Gainsboro
        Me.bcpA.ProgressColor = System.Drawing.Color.SeaGreen
        Me.bcpA.Size = New System.Drawing.Size(119, 119)
        Me.bcpA.TabIndex = 0
        Me.bcpA.Value = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.bcpB)
        Me.Panel3.Location = New System.Drawing.Point(763, 63)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(170, 188)
        Me.Panel3.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("LuzSans-Book", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gray
        Me.Label4.Location = New System.Drawing.Point(22, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 22)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Estado: B"
        '
        'bcpB
        '
        Me.bcpB.animated = False
        Me.bcpB.animationIterval = 5
        Me.bcpB.animationSpeed = 300
        Me.bcpB.BackColor = System.Drawing.Color.White
        Me.bcpB.BackgroundImage = CType(resources.GetObject("bcpB.BackgroundImage"), System.Drawing.Image)
        Me.bcpB.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!)
        Me.bcpB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bcpB.LabelVisible = False
        Me.bcpB.LineProgressThickness = 8
        Me.bcpB.LineThickness = 5
        Me.bcpB.Location = New System.Drawing.Point(26, 35)
        Me.bcpB.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.bcpB.MaxValue = 100
        Me.bcpB.Name = "bcpB"
        Me.bcpB.ProgressBackColor = System.Drawing.Color.Gainsboro
        Me.bcpB.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bcpB.Size = New System.Drawing.Size(119, 119)
        Me.bcpB.TabIndex = 1
        Me.bcpB.Value = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.lvContactados)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(27, 63)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(513, 192)
        Me.Panel1.TabIndex = 1
        '
        'lvContactados
        '
        Me.lvContactados.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvContactados.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader9})
        Me.lvContactados.FullRowSelect = True
        Me.lvContactados.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lvContactados.HideSelection = False
        Me.lvContactados.Location = New System.Drawing.Point(20, 42)
        Me.lvContactados.Name = "lvContactados"
        Me.lvContactados.Size = New System.Drawing.Size(476, 128)
        Me.lvContactados.TabIndex = 2
        Me.lvContactados.UseCompatibleStateImageBehavior = False
        Me.lvContactados.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Width = 408
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("LuzSans-Book", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(16, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(195, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Contactados el dia de Hoy"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("LuzSans-Book", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(22, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(241, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Seguimiento de Vendedores"
        '
        'frmVendedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1275, 642)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
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
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents tssLbCierre As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tspbLoading As System.Windows.Forms.ToolStripProgressBar
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
    Friend WithEvents tsslCancel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents lvVendedores As ListView
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ckDistrito As CheckBox
    Friend WithEvents ckCanton As CheckBox
    Friend WithEvents cmdBuscar As Button
    Friend WithEvents cmbDistrito As ComboBox
    Friend WithEvents cmbCanton As ComboBox
    Friend WithEvents cmbProvincia As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents bcpA As Bunifu.Framework.UI.BunifuCircleProgressbar
    Friend WithEvents bcpC As Bunifu.Framework.UI.BunifuCircleProgressbar
    Friend WithEvents bcpB As Bunifu.Framework.UI.BunifuCircleProgressbar
    Friend WithEvents lvContactados As ListView
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents EnviarWhatsAppToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents KryptonDropButton1 As ComponentFactory.Krypton.Toolkit.KryptonDropButton
    Friend WithEvents KryptonContextMenu1 As ComponentFactory.Krypton.Toolkit.KryptonContextMenu
    Friend WithEvents KryptonContextMenuHeading1 As ComponentFactory.Krypton.Toolkit.KryptonContextMenuHeading
    Friend WithEvents KryptonContextMenuItems1 As ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems
    Friend WithEvents KryptonContextMenuItems2 As ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems
    Friend WithEvents KryptonContextMenuItem1 As ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem
    Friend WithEvents KryptonContextMenuItem2 As ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem
End Class
