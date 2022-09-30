<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim ListViewGroup1 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Registrados", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup2 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("En transicion", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup3 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Primera Cuota Completa", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup4 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Pendientes de Primer Pago", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup5 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Primera Cuota Completa", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup6 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Pendientes de Primer Pago", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup7 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Sin Ventas", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup8 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Ingreso <= 30", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup9 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Ingreso <= 60", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup10 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Ingreso <= 90", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup11 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Ingreso <= 120", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup12 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Ingreso > 120", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim DataPoint1 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(0R, 50.0R)
        Dim DataPoint2 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(0R, 25.0R)
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim DataPoint3 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(0R, 50.0R)
        Dim DataPoint4 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(0R, 25.0R)
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabpage56 = New System.Windows.Forms.TabPage()
        Me.cmdMostrarCliente = New System.Windows.Forms.Button()
        Me.lbNombre = New System.Windows.Forms.Label()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.TabControl5 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Label77 = New System.Windows.Forms.Label()
        Me.dtFechaNacCliente = New System.Windows.Forms.DateTimePicker()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.cmbDistrito = New System.Windows.Forms.ComboBox()
        Me.cmbCanton = New System.Windows.Forms.ComboBox()
        Me.cmbProvincia = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.txtFax = New System.Windows.Forms.TextBox()
        Me.txtCelular = New System.Windows.Forms.TextBox()
        Me.txtApellido02 = New System.Windows.Forms.TextBox()
        Me.txtHabitacion = New System.Windows.Forms.TextBox()
        Me.txtapellido01 = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TabControl4 = New System.Windows.Forms.TabControl()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.lvArticulos = New System.Windows.Forms.ListView()
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader17 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader18 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label33 = New System.Windows.Forms.Label()
        Me.txtTipo = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtMontoTotal = New System.Windows.Forms.TextBox()
        Me.txtFechaVencimiento = New System.Windows.Forms.TextBox()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.txtPlazo = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TabPage11 = New System.Windows.Forms.TabPage()
        Me.txtMontoCancelado = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.txtSaldoActual = New System.Windows.Forms.TextBox()
        Me.lvPagos = New System.Windows.Forms.ListView()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtCuotasCanceladas = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TabPage12 = New System.Windows.Forms.TabPage()
        Me.lvEstadoDespacho = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtSaldoDespacho = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtFactura = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.txtInspector = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtFechaEstudio = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cmdMostrarDatos = New System.Windows.Forms.Button()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.txtComentarioGarantia = New System.Windows.Forms.TextBox()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.txtGarantiaAplicada = New System.Windows.Forms.TextBox()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.ListView9 = New System.Windows.Forms.ListView()
        Me.ColumnHeader34 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label57 = New System.Windows.Forms.Label()
        Me.lvArticulosGarantia = New System.Windows.Forms.ListView()
        Me.ColumnHeader32 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader33 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader35 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader36 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader37 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label56 = New System.Windows.Forms.Label()
        Me.txtEstadoGarantia = New System.Windows.Forms.TextBox()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.txtFechaIngresoGarantia = New System.Windows.Forms.TextBox()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.txtBoletaGarantia = New System.Windows.Forms.TextBox()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cmdBuscaCliente = New System.Windows.Forms.Button()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tabpage57 = New System.Windows.Forms.TabPage()
        Me.PictureBox14 = New System.Windows.Forms.PictureBox()
        Me.PictureBox13 = New System.Windows.Forms.PictureBox()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lbNivel = New System.Windows.Forms.Label()
        Me.cmbCierre = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cmdConsultarVendedor = New System.Windows.Forms.Button()
        Me.lbVendedor = New System.Windows.Forms.Label()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.TabControl3 = New System.Windows.Forms.TabControl()
        Me.tabpage14 = New System.Windows.Forms.TabPage()
        Me.Label78 = New System.Windows.Forms.Label()
        Me.dtFechaNacVendedor = New System.Windows.Forms.DateTimePicker()
        Me.txtdireccionvendedor = New System.Windows.Forms.TextBox()
        Me.cmbdistritovendedor = New System.Windows.Forms.ComboBox()
        Me.cmbcantonvendedor = New System.Windows.Forms.ComboBox()
        Me.cmbprovinciavendedor = New System.Windows.Forms.ComboBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.txtcorreovendedor = New System.Windows.Forms.TextBox()
        Me.txtfaxvendedor = New System.Windows.Forms.TextBox()
        Me.txtcelularvendedor = New System.Windows.Forms.TextBox()
        Me.txtapellido02vendedor = New System.Windows.Forms.TextBox()
        Me.txthabitacionvendedor = New System.Windows.Forms.TextBox()
        Me.txtapellido01vendedor = New System.Windows.Forms.TextBox()
        Me.txtNombreVendedor = New System.Windows.Forms.TextBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lvReferencias = New System.Windows.Forms.ListView()
        Me.ColumnHeader41 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader42 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader43 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader44 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label70 = New System.Windows.Forms.Label()
        Me.txtTelefonoReferencia02 = New System.Windows.Forms.TextBox()
        Me.txtSector02 = New System.Windows.Forms.TextBox()
        Me.txtNombreReferencia02 = New System.Windows.Forms.TextBox()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.txtTelefonoReferencia01 = New System.Windows.Forms.TextBox()
        Me.txtSector01 = New System.Windows.Forms.TextBox()
        Me.txtNombreReferencia01 = New System.Windows.Forms.TextBox()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.txtTelefonoConyuge = New System.Windows.Forms.TextBox()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.txtNombreConyuge = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtEstadoCivil = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.txtContratoOrganizacion = New System.Windows.Forms.TextBox()
        Me.Label76 = New System.Windows.Forms.Label()
        Me.txtCorreoOrganizacion = New System.Windows.Forms.TextBox()
        Me.txtTelefono03Organizacion = New System.Windows.Forms.TextBox()
        Me.txtTelefono02Organizacion = New System.Windows.Forms.TextBox()
        Me.txtTelefono01Organizacion = New System.Windows.Forms.TextBox()
        Me.Label75 = New System.Windows.Forms.Label()
        Me.Label74 = New System.Windows.Forms.Label()
        Me.Label73 = New System.Windows.Forms.Label()
        Me.Label72 = New System.Windows.Forms.Label()
        Me.txtDistribuidorOrganizacion = New System.Windows.Forms.TextBox()
        Me.Label71 = New System.Windows.Forms.Label()
        Me.lvTreeReclutas = New System.Windows.Forms.TreeView()
        Me.tapag45 = New System.Windows.Forms.TabPage()
        Me.txtDiasIngreso = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txtNuevosDirectos = New System.Windows.Forms.TextBox()
        Me.Label82 = New System.Windows.Forms.Label()
        Me.txtNuevosReclutas = New System.Windows.Forms.TextBox()
        Me.Label81 = New System.Windows.Forms.Label()
        Me.Label80 = New System.Windows.Forms.Label()
        Me.txtIndirectosVenta = New System.Windows.Forms.TextBox()
        Me.Label79 = New System.Windows.Forms.Label()
        Me.txtDirectosConVenta = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lvFacturasVendedor = New System.Windows.Forms.ListView()
        Me.ColumnHeader26 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader27 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader28 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader38 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader29 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader30 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader31 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPage10 = New System.Windows.Forms.TabPage()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.lvVentasRecluta = New System.Windows.Forms.ListView()
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader20 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader21 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader22 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvVendedoresUnidad = New System.Windows.Forms.ListView()
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader39 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader40 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPage13 = New System.Windows.Forms.TabPage()
        Me.lvEstadoReclutamiento = New System.Windows.Forms.ListView()
        Me.ColumnHeader19 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader23 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader50 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader51 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader24 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader25 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader45 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader46 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader47 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader48 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader49 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPage8 = New System.Windows.Forms.TabPage()
        Me.lbEstadoReclutamiento = New System.Windows.Forms.Label()
        Me.ChartReclutamiento = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.lbVentasProvincia = New System.Windows.Forms.Label()
        Me.ChartVentaEquipo = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.txtVentasPersonalesProceso = New System.Windows.Forms.TextBox()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.txtReclutasActivosIndirectos = New System.Windows.Forms.TextBox()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.txtReclutasActivosDirectos = New System.Windows.Forms.TextBox()
        Me.txtVentasUnidad = New System.Windows.Forms.TextBox()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.txtVendedorVentasPersonales = New System.Windows.Forms.TextBox()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.TabPage9 = New System.Windows.Forms.TabPage()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txtvendedor = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.ComboBox6 = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.TextBox18 = New System.Windows.Forms.TextBox()
        Me.TextBox26 = New System.Windows.Forms.TextBox()
        Me.TextBox27 = New System.Windows.Forms.TextBox()
        Me.TextBox28 = New System.Windows.Forms.TextBox()
        Me.TextBox29 = New System.Windows.Forms.TextBox()
        Me.TextBox30 = New System.Windows.Forms.TextBox()
        Me.TextBox31 = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SistemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PerfilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HerramientasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SeguimientoPostVentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SeguimientoVendedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EventosPublicitariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CapacitacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EncuestasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConcursosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VendedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VendedoresActivosInactivosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoriasDeEstudiosDeCreditoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevosEjecutivosDeVentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tssLbCompania = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslbUbicacion = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tssLbUsuario = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslbDatabase = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TabControl1.SuspendLayout()
        Me.tabpage56.SuspendLayout()
        Me.TabControl5.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabControl4.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.TabPage11.SuspendLayout()
        Me.TabPage12.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabpage57.SuspendLayout()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl3.SuspendLayout()
        Me.tabpage14.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage7.SuspendLayout()
        Me.tapag45.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage10.SuspendLayout()
        Me.TabPage13.SuspendLayout()
        Me.TabPage8.SuspendLayout()
        CType(Me.ChartReclutamiento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartVentaEquipo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.tabpage56)
        Me.TabControl1.Controls.Add(Me.tabpage57)
        Me.TabControl1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(12, 27)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1228, 673)
        Me.TabControl1.TabIndex = 0
        '
        'tabpage56
        '
        Me.tabpage56.Controls.Add(Me.cmdMostrarCliente)
        Me.tabpage56.Controls.Add(Me.lbNombre)
        Me.tabpage56.Controls.Add(Me.Label61)
        Me.tabpage56.Controls.Add(Me.TabControl5)
        Me.tabpage56.Controls.Add(Me.PictureBox1)
        Me.tabpage56.Controls.Add(Me.cmdBuscaCliente)
        Me.tabpage56.Controls.Add(Me.txtCliente)
        Me.tabpage56.Controls.Add(Me.Label1)
        Me.tabpage56.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabpage56.Location = New System.Drawing.Point(4, 26)
        Me.tabpage56.Name = "tabpage56"
        Me.tabpage56.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpage56.Size = New System.Drawing.Size(1220, 643)
        Me.tabpage56.TabIndex = 0
        Me.tabpage56.Text = "Informacion del Cliente"
        Me.tabpage56.UseVisualStyleBackColor = True
        '
        'cmdMostrarCliente
        '
        Me.cmdMostrarCliente.Location = New System.Drawing.Point(314, 11)
        Me.cmdMostrarCliente.Name = "cmdMostrarCliente"
        Me.cmdMostrarCliente.Size = New System.Drawing.Size(71, 27)
        Me.cmdMostrarCliente.TabIndex = 7
        Me.cmdMostrarCliente.Text = "Mostrar"
        Me.cmdMostrarCliente.UseVisualStyleBackColor = True
        '
        'lbNombre
        '
        Me.lbNombre.AutoSize = True
        Me.lbNombre.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNombre.Location = New System.Drawing.Point(141, 47)
        Me.lbNombre.Name = "lbNombre"
        Me.lbNombre.Size = New System.Drawing.Size(0, 23)
        Me.lbNombre.TabIndex = 6
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label61.Location = New System.Drawing.Point(17, 51)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(60, 18)
        Me.Label61.TabIndex = 5
        Me.Label61.Text = "Cliente: "
        '
        'TabControl5
        '
        Me.TabControl5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl5.Controls.Add(Me.TabPage3)
        Me.TabControl5.Controls.Add(Me.TabPage4)
        Me.TabControl5.Controls.Add(Me.TabPage5)
        Me.TabControl5.Location = New System.Drawing.Point(20, 94)
        Me.TabControl5.Multiline = True
        Me.TabControl5.Name = "TabControl5"
        Me.TabControl5.SelectedIndex = 0
        Me.TabControl5.Size = New System.Drawing.Size(956, 543)
        Me.TabControl5.TabIndex = 4
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Button9)
        Me.TabPage3.Controls.Add(Me.Button8)
        Me.TabPage3.Controls.Add(Me.Label77)
        Me.TabPage3.Controls.Add(Me.dtFechaNacCliente)
        Me.TabPage3.Controls.Add(Me.txtDireccion)
        Me.TabPage3.Controls.Add(Me.cmbDistrito)
        Me.TabPage3.Controls.Add(Me.cmbCanton)
        Me.TabPage3.Controls.Add(Me.cmbProvincia)
        Me.TabPage3.Controls.Add(Me.Label9)
        Me.TabPage3.Controls.Add(Me.Button4)
        Me.TabPage3.Controls.Add(Me.txtCorreo)
        Me.TabPage3.Controls.Add(Me.txtFax)
        Me.TabPage3.Controls.Add(Me.txtCelular)
        Me.TabPage3.Controls.Add(Me.txtApellido02)
        Me.TabPage3.Controls.Add(Me.txtHabitacion)
        Me.TabPage3.Controls.Add(Me.txtapellido01)
        Me.TabPage3.Controls.Add(Me.txtNombre)
        Me.TabPage3.Controls.Add(Me.Label8)
        Me.TabPage3.Controls.Add(Me.Label7)
        Me.TabPage3.Controls.Add(Me.Label6)
        Me.TabPage3.Controls.Add(Me.Label5)
        Me.TabPage3.Controls.Add(Me.Label4)
        Me.TabPage3.Controls.Add(Me.Label3)
        Me.TabPage3.Controls.Add(Me.Label2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 27)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(948, 512)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "Informacion General"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(722, 57)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(120, 24)
        Me.Button9.TabIndex = 26
        Me.Button9.Text = "Button9"
        Me.Button9.UseVisualStyleBackColor = True
        Me.Button9.Visible = False
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(71, 423)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(123, 25)
        Me.Button8.TabIndex = 25
        Me.Button8.Text = "Button8"
        Me.Button8.UseVisualStyleBackColor = True
        Me.Button8.Visible = False
        '
        'Label77
        '
        Me.Label77.AutoSize = True
        Me.Label77.Location = New System.Drawing.Point(118, 300)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(119, 18)
        Me.Label77.TabIndex = 24
        Me.Label77.Text = "Fecha Nacimiento"
        '
        'dtFechaNacCliente
        '
        Me.dtFechaNacCliente.Location = New System.Drawing.Point(258, 292)
        Me.dtFechaNacCliente.Name = "dtFechaNacCliente"
        Me.dtFechaNacCliente.Size = New System.Drawing.Size(266, 26)
        Me.dtFechaNacCliente.TabIndex = 23
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(258, 381)
        Me.txtDireccion.Multiline = True
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(549, 50)
        Me.txtDireccion.TabIndex = 22
        '
        'cmbDistrito
        '
        Me.cmbDistrito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDistrito.FormattingEnabled = True
        Me.cmbDistrito.Location = New System.Drawing.Point(633, 339)
        Me.cmbDistrito.Name = "cmbDistrito"
        Me.cmbDistrito.Size = New System.Drawing.Size(174, 26)
        Me.cmbDistrito.TabIndex = 21
        '
        'cmbCanton
        '
        Me.cmbCanton.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCanton.FormattingEnabled = True
        Me.cmbCanton.Location = New System.Drawing.Point(444, 339)
        Me.cmbCanton.Name = "cmbCanton"
        Me.cmbCanton.Size = New System.Drawing.Size(174, 26)
        Me.cmbCanton.TabIndex = 20
        '
        'cmbProvincia
        '
        Me.cmbProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProvincia.FormattingEnabled = True
        Me.cmbProvincia.Location = New System.Drawing.Point(259, 339)
        Me.cmbProvincia.Name = "cmbProvincia"
        Me.cmbProvincia.Size = New System.Drawing.Size(174, 26)
        Me.cmbProvincia.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(118, 343)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 18)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Provincia"
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button4.Location = New System.Drawing.Point(428, 466)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(176, 29)
        Me.Button4.TabIndex = 16
        Me.Button4.Text = "Actualizar Datos"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'txtCorreo
        '
        Me.txtCorreo.Location = New System.Drawing.Point(258, 247)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(360, 26)
        Me.txtCorreo.TabIndex = 13
        '
        'txtFax
        '
        Me.txtFax.Location = New System.Drawing.Point(258, 197)
        Me.txtFax.Name = "txtFax"
        Me.txtFax.Size = New System.Drawing.Size(175, 26)
        Me.txtFax.TabIndex = 12
        '
        'txtCelular
        '
        Me.txtCelular.Location = New System.Drawing.Point(258, 156)
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(175, 26)
        Me.txtCelular.TabIndex = 11
        '
        'txtApellido02
        '
        Me.txtApellido02.Location = New System.Drawing.Point(439, 73)
        Me.txtApellido02.Name = "txtApellido02"
        Me.txtApellido02.Size = New System.Drawing.Size(179, 26)
        Me.txtApellido02.TabIndex = 10
        '
        'txtHabitacion
        '
        Me.txtHabitacion.Location = New System.Drawing.Point(258, 114)
        Me.txtHabitacion.Name = "txtHabitacion"
        Me.txtHabitacion.Size = New System.Drawing.Size(175, 26)
        Me.txtHabitacion.TabIndex = 9
        '
        'txtapellido01
        '
        Me.txtapellido01.Location = New System.Drawing.Point(258, 73)
        Me.txtapellido01.Name = "txtapellido01"
        Me.txtapellido01.Size = New System.Drawing.Size(175, 26)
        Me.txtapellido01.TabIndex = 8
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(258, 30)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(360, 26)
        Me.txtNombre.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(118, 255)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 18)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Electronico"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(118, 237)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 18)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Correo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(118, 205)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 18)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Fax"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(118, 164)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 18)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Telefono Celular"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(118, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 18)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Telefono Habitacion"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(118, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 18)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Apellidos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(118, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nombre"
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.White
        Me.TabPage4.Controls.Add(Me.TabControl4)
        Me.TabPage4.Controls.Add(Me.Button1)
        Me.TabPage4.Controls.Add(Me.Button2)
        Me.TabPage4.Controls.Add(Me.txtFactura)
        Me.TabPage4.Controls.Add(Me.Label10)
        Me.TabPage4.Location = New System.Drawing.Point(4, 27)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(948, 512)
        Me.TabPage4.TabIndex = 1
        Me.TabPage4.Text = "Facturacion"
        '
        'TabControl4
        '
        Me.TabControl4.Controls.Add(Me.TabPage6)
        Me.TabControl4.Controls.Add(Me.TabPage11)
        Me.TabControl4.Controls.Add(Me.TabPage12)
        Me.TabControl4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl4.Location = New System.Drawing.Point(19, 56)
        Me.TabControl4.Multiline = True
        Me.TabControl4.Name = "TabControl4"
        Me.TabControl4.SelectedIndex = 0
        Me.TabControl4.Size = New System.Drawing.Size(923, 450)
        Me.TabControl4.TabIndex = 63
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.lvArticulos)
        Me.TabPage6.Controls.Add(Me.Label33)
        Me.TabPage6.Controls.Add(Me.txtTipo)
        Me.TabPage6.Controls.Add(Me.Label30)
        Me.TabPage6.Controls.Add(Me.Label29)
        Me.TabPage6.Controls.Add(Me.txtMontoTotal)
        Me.TabPage6.Controls.Add(Me.txtFechaVencimiento)
        Me.TabPage6.Controls.Add(Me.txtFecha)
        Me.TabPage6.Controls.Add(Me.txtPlazo)
        Me.TabPage6.Controls.Add(Me.Label20)
        Me.TabPage6.Controls.Add(Me.Label12)
        Me.TabPage6.Controls.Add(Me.Label11)
        Me.TabPage6.Controls.Add(Me.Label13)
        Me.TabPage6.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage6.Location = New System.Drawing.Point(4, 25)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(915, 421)
        Me.TabPage6.TabIndex = 0
        Me.TabPage6.Text = "Datos Generales"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'lvArticulos
        '
        Me.lvArticulos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader15, Me.ColumnHeader16, Me.ColumnHeader17, Me.ColumnHeader18})
        Me.lvArticulos.GridLines = True
        Me.lvArticulos.Location = New System.Drawing.Point(377, 50)
        Me.lvArticulos.Name = "lvArticulos"
        Me.lvArticulos.Size = New System.Drawing.Size(481, 318)
        Me.lvArticulos.TabIndex = 49
        Me.lvArticulos.UseCompatibleStateImageBehavior = False
        Me.lvArticulos.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "Articulo"
        Me.ColumnHeader15.Width = 0
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "Descripcion"
        Me.ColumnHeader16.Width = 341
        '
        'ColumnHeader17
        '
        Me.ColumnHeader17.Text = "Cantidad"
        Me.ColumnHeader17.Width = 67
        '
        'ColumnHeader18
        '
        Me.ColumnHeader18.Text = "Precio de Venta"
        Me.ColumnHeader18.Width = 67
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Calibri", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(374, 13)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(77, 18)
        Me.Label33.TabIndex = 65
        Me.Label33.Text = "2. Articulos"
        '
        'txtTipo
        '
        Me.txtTipo.Location = New System.Drawing.Point(180, 50)
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.Size = New System.Drawing.Size(133, 26)
        Me.txtTipo.TabIndex = 58
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(42, 50)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(35, 18)
        Me.Label30.TabIndex = 57
        Me.Label30.Text = "Tipo"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Calibri", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(41, 13)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(124, 18)
        Me.Label29.TabIndex = 56
        Me.Label29.Text = "1. Datos Generales"
        '
        'txtMontoTotal
        '
        Me.txtMontoTotal.Location = New System.Drawing.Point(180, 250)
        Me.txtMontoTotal.Name = "txtMontoTotal"
        Me.txtMontoTotal.Size = New System.Drawing.Size(133, 26)
        Me.txtMontoTotal.TabIndex = 55
        Me.txtMontoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtFechaVencimiento
        '
        Me.txtFechaVencimiento.Location = New System.Drawing.Point(180, 150)
        Me.txtFechaVencimiento.Name = "txtFechaVencimiento"
        Me.txtFechaVencimiento.Size = New System.Drawing.Size(133, 26)
        Me.txtFechaVencimiento.TabIndex = 54
        '
        'txtFecha
        '
        Me.txtFecha.Location = New System.Drawing.Point(180, 100)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(133, 26)
        Me.txtFecha.TabIndex = 53
        '
        'txtPlazo
        '
        Me.txtPlazo.Location = New System.Drawing.Point(180, 200)
        Me.txtPlazo.Name = "txtPlazo"
        Me.txtPlazo.Size = New System.Drawing.Size(43, 26)
        Me.txtPlazo.TabIndex = 64
        Me.txtPlazo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(44, 253)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(82, 18)
        Me.Label20.TabIndex = 52
        Me.Label20.Text = "Monto Total"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(41, 153)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(126, 18)
        Me.Label12.TabIndex = 51
        Me.Label12.Text = "Fecha Vencimiento"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(42, 103)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 18)
        Me.Label11.TabIndex = 50
        Me.Label11.Text = "Fecha"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(44, 203)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(50, 18)
        Me.Label13.TabIndex = 63
        Me.Label13.Text = "Cuotas"
        '
        'TabPage11
        '
        Me.TabPage11.Controls.Add(Me.txtMontoCancelado)
        Me.TabPage11.Controls.Add(Me.Label34)
        Me.TabPage11.Controls.Add(Me.txtSaldoActual)
        Me.TabPage11.Controls.Add(Me.lvPagos)
        Me.TabPage11.Controls.Add(Me.Label25)
        Me.TabPage11.Controls.Add(Me.Label21)
        Me.TabPage11.Controls.Add(Me.txtCuotasCanceladas)
        Me.TabPage11.Controls.Add(Me.Label16)
        Me.TabPage11.Location = New System.Drawing.Point(4, 25)
        Me.TabPage11.Name = "TabPage11"
        Me.TabPage11.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage11.Size = New System.Drawing.Size(915, 421)
        Me.TabPage11.TabIndex = 1
        Me.TabPage11.Text = "Pagos"
        Me.TabPage11.UseVisualStyleBackColor = True
        '
        'txtMontoCancelado
        '
        Me.txtMontoCancelado.Location = New System.Drawing.Point(193, 53)
        Me.txtMontoCancelado.Name = "txtMontoCancelado"
        Me.txtMontoCancelado.Size = New System.Drawing.Size(99, 23)
        Me.txtMontoCancelado.TabIndex = 70
        Me.txtMontoCancelado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Calibri", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(28, 16)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(129, 18)
        Me.Label34.TabIndex = 64
        Me.Label34.Text = "3. Estado de Cuenta"
        '
        'txtSaldoActual
        '
        Me.txtSaldoActual.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldoActual.Location = New System.Drawing.Point(193, 97)
        Me.txtSaldoActual.Name = "txtSaldoActual"
        Me.txtSaldoActual.Size = New System.Drawing.Size(99, 26)
        Me.txtSaldoActual.TabIndex = 69
        Me.txtSaldoActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lvPagos
        '
        Me.lvPagos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9})
        Me.lvPagos.GridLines = True
        ListViewGroup1.Header = "Registrados"
        ListViewGroup1.Name = "ListViewGroup1"
        ListViewGroup2.Header = "En transicion"
        ListViewGroup2.Name = "ListViewGroup2"
        Me.lvPagos.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup1, ListViewGroup2})
        Me.lvPagos.Location = New System.Drawing.Point(31, 185)
        Me.lvPagos.Name = "lvPagos"
        Me.lvPagos.Size = New System.Drawing.Size(837, 240)
        Me.lvPagos.TabIndex = 60
        Me.lvPagos.UseCompatibleStateImageBehavior = False
        Me.lvPagos.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Fecha"
        Me.ColumnHeader5.Width = 136
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Tipo"
        Me.ColumnHeader6.Width = 152
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Banco"
        Me.ColumnHeader7.Width = 225
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Documento"
        Me.ColumnHeader8.Width = 140
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Monto"
        Me.ColumnHeader9.Width = 114
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(28, 61)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(106, 16)
        Me.Label25.TabIndex = 67
        Me.Label25.Text = "Monto Cancelado"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(28, 100)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(79, 16)
        Me.Label21.TabIndex = 65
        Me.Label21.Text = "Saldo Actual"
        '
        'txtCuotasCanceladas
        '
        Me.txtCuotasCanceladas.Location = New System.Drawing.Point(193, 142)
        Me.txtCuotasCanceladas.Name = "txtCuotasCanceladas"
        Me.txtCuotasCanceladas.Size = New System.Drawing.Size(99, 23)
        Me.txtCuotasCanceladas.TabIndex = 63
        Me.txtCuotasCanceladas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(28, 142)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(116, 16)
        Me.Label16.TabIndex = 61
        Me.Label16.Text = "Cuotas Canceladas"
        '
        'TabPage12
        '
        Me.TabPage12.Controls.Add(Me.lvEstadoDespacho)
        Me.TabPage12.Controls.Add(Me.Label27)
        Me.TabPage12.Controls.Add(Me.txtSaldoDespacho)
        Me.TabPage12.Controls.Add(Me.Label23)
        Me.TabPage12.Location = New System.Drawing.Point(4, 25)
        Me.TabPage12.Name = "TabPage12"
        Me.TabPage12.Size = New System.Drawing.Size(915, 421)
        Me.TabPage12.TabIndex = 2
        Me.TabPage12.Text = "Envio y Entrega"
        Me.TabPage12.UseVisualStyleBackColor = True
        '
        'lvEstadoDespacho
        '
        Me.lvEstadoDespacho.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lvEstadoDespacho.LabelWrap = False
        Me.lvEstadoDespacho.Location = New System.Drawing.Point(30, 121)
        Me.lvEstadoDespacho.Name = "lvEstadoDespacho"
        Me.lvEstadoDespacho.Size = New System.Drawing.Size(838, 110)
        Me.lvEstadoDespacho.TabIndex = 65
        Me.lvEstadoDespacho.UseCompatibleStateImageBehavior = False
        Me.lvEstadoDespacho.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Evento"
        Me.ColumnHeader1.Width = 105
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Fecha"
        Me.ColumnHeader2.Width = 92
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Estado"
        Me.ColumnHeader3.Width = 247
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Calibri", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(27, 16)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(116, 18)
        Me.Label27.TabIndex = 64
        Me.Label27.Text = "4. Envio y Entrega"
        '
        'txtSaldoDespacho
        '
        Me.txtSaldoDespacho.Location = New System.Drawing.Point(162, 58)
        Me.txtSaldoDespacho.Name = "txtSaldoDespacho"
        Me.txtSaldoDespacho.Size = New System.Drawing.Size(74, 23)
        Me.txtSaldoDespacho.TabIndex = 63
        Me.txtSaldoDespacho.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(38, 66)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(99, 16)
        Me.Label23.TabIndex = 62
        Me.Label23.Text = "Saldo Despacho"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(290, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(71, 26)
        Me.Button1.TabIndex = 62
        Me.Button1.Text = "Mostrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(367, 10)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(62, 26)
        Me.Button2.TabIndex = 49
        Me.Button2.Text = "Buscar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtFactura
        '
        Me.txtFactura.Location = New System.Drawing.Point(155, 11)
        Me.txtFactura.Name = "txtFactura"
        Me.txtFactura.Size = New System.Drawing.Size(129, 26)
        Me.txtFactura.TabIndex = 27
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(16, 19)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(113, 18)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Orden de Pedido"
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.txtInspector)
        Me.TabPage5.Controls.Add(Me.Label22)
        Me.TabPage5.Controls.Add(Me.txtFechaEstudio)
        Me.TabPage5.Controls.Add(Me.Label17)
        Me.TabPage5.Controls.Add(Me.cmdMostrarDatos)
        Me.TabPage5.Controls.Add(Me.Label60)
        Me.TabPage5.Controls.Add(Me.txtComentarioGarantia)
        Me.TabPage5.Controls.Add(Me.Label59)
        Me.TabPage5.Controls.Add(Me.txtGarantiaAplicada)
        Me.TabPage5.Controls.Add(Me.Label58)
        Me.TabPage5.Controls.Add(Me.ListView9)
        Me.TabPage5.Controls.Add(Me.Label57)
        Me.TabPage5.Controls.Add(Me.lvArticulosGarantia)
        Me.TabPage5.Controls.Add(Me.Label56)
        Me.TabPage5.Controls.Add(Me.txtEstadoGarantia)
        Me.TabPage5.Controls.Add(Me.Label55)
        Me.TabPage5.Controls.Add(Me.txtFechaIngresoGarantia)
        Me.TabPage5.Controls.Add(Me.Label54)
        Me.TabPage5.Controls.Add(Me.Button7)
        Me.TabPage5.Controls.Add(Me.txtBoletaGarantia)
        Me.TabPage5.Controls.Add(Me.Label53)
        Me.TabPage5.Controls.Add(Me.PictureBox4)
        Me.TabPage5.Location = New System.Drawing.Point(4, 27)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(948, 512)
        Me.TabPage5.TabIndex = 2
        Me.TabPage5.Text = "Cambios y Garantias"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'txtInspector
        '
        Me.txtInspector.Location = New System.Drawing.Point(177, 156)
        Me.txtInspector.Name = "txtInspector"
        Me.txtInspector.Size = New System.Drawing.Size(128, 26)
        Me.txtInspector.TabIndex = 26
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(20, 164)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(66, 18)
        Me.Label22.TabIndex = 25
        Me.Label22.Text = "Inspector"
        '
        'txtFechaEstudio
        '
        Me.txtFechaEstudio.Location = New System.Drawing.Point(177, 124)
        Me.txtFechaEstudio.Name = "txtFechaEstudio"
        Me.txtFechaEstudio.Size = New System.Drawing.Size(128, 26)
        Me.txtFechaEstudio.TabIndex = 24
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(20, 132)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(93, 18)
        Me.Label17.TabIndex = 23
        Me.Label17.Text = "Fecha Estudio"
        '
        'cmdMostrarDatos
        '
        Me.cmdMostrarDatos.Location = New System.Drawing.Point(311, 9)
        Me.cmdMostrarDatos.Name = "cmdMostrarDatos"
        Me.cmdMostrarDatos.Size = New System.Drawing.Size(65, 27)
        Me.cmdMostrarDatos.TabIndex = 22
        Me.cmdMostrarDatos.Text = "Mostrar"
        Me.cmdMostrarDatos.UseVisualStyleBackColor = True
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Location = New System.Drawing.Point(497, 319)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(91, 18)
        Me.Label60.TabIndex = 21
        Me.Label60.Text = "Comentarios:"
        '
        'txtComentarioGarantia
        '
        Me.txtComentarioGarantia.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtComentarioGarantia.Location = New System.Drawing.Point(500, 340)
        Me.txtComentarioGarantia.Multiline = True
        Me.txtComentarioGarantia.Name = "txtComentarioGarantia"
        Me.txtComentarioGarantia.Size = New System.Drawing.Size(432, 116)
        Me.txtComentarioGarantia.TabIndex = 20
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Location = New System.Drawing.Point(498, 78)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(128, 18)
        Me.Label59.TabIndex = 19
        Me.Label59.Text = "Criterios Aplicados:"
        '
        'txtGarantiaAplicada
        '
        Me.txtGarantiaAplicada.Location = New System.Drawing.Point(649, 37)
        Me.txtGarantiaAplicada.Name = "txtGarantiaAplicada"
        Me.txtGarantiaAplicada.Size = New System.Drawing.Size(121, 26)
        Me.txtGarantiaAplicada.TabIndex = 18
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Location = New System.Drawing.Point(498, 45)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(115, 18)
        Me.Label58.TabIndex = 17
        Me.Label58.Text = "Garantia Aplicada"
        '
        'ListView9
        '
        Me.ListView9.CheckBoxes = True
        Me.ListView9.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader34})
        Me.ListView9.Location = New System.Drawing.Point(497, 104)
        Me.ListView9.Name = "ListView9"
        Me.ListView9.Size = New System.Drawing.Size(436, 201)
        Me.ListView9.TabIndex = 16
        Me.ListView9.UseCompatibleStateImageBehavior = False
        Me.ListView9.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader34
        '
        Me.ColumnHeader34.Text = "Criterio"
        Me.ColumnHeader34.Width = 421
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Font = New System.Drawing.Font("Calibri", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label57.Location = New System.Drawing.Point(498, 14)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(119, 18)
        Me.Label57.TabIndex = 15
        Me.Label57.Text = "Resultado Estudio"
        '
        'lvArticulosGarantia
        '
        Me.lvArticulosGarantia.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lvArticulosGarantia.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader32, Me.ColumnHeader33, Me.ColumnHeader35, Me.ColumnHeader36, Me.ColumnHeader37})
        Me.lvArticulosGarantia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lvArticulosGarantia.FullRowSelect = True
        Me.lvArticulosGarantia.Location = New System.Drawing.Point(23, 221)
        Me.lvArticulosGarantia.Name = "lvArticulosGarantia"
        Me.lvArticulosGarantia.Size = New System.Drawing.Size(422, 214)
        Me.lvArticulosGarantia.TabIndex = 14
        Me.lvArticulosGarantia.UseCompatibleStateImageBehavior = False
        Me.lvArticulosGarantia.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader32
        '
        Me.ColumnHeader32.Text = "Codigo"
        Me.ColumnHeader32.Width = 86
        '
        'ColumnHeader33
        '
        Me.ColumnHeader33.Text = "Articulo"
        Me.ColumnHeader33.Width = 322
        '
        'ColumnHeader35
        '
        Me.ColumnHeader35.Text = "linea"
        Me.ColumnHeader35.Width = 0
        '
        'ColumnHeader36
        '
        Me.ColumnHeader36.Text = "garantia"
        Me.ColumnHeader36.Width = 0
        '
        'ColumnHeader37
        '
        Me.ColumnHeader37.Text = "comentarios"
        Me.ColumnHeader37.Width = 0
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Font = New System.Drawing.Font("Calibri", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label56.Location = New System.Drawing.Point(20, 200)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(63, 18)
        Me.Label56.TabIndex = 13
        Me.Label56.Text = "Articulos"
        '
        'txtEstadoGarantia
        '
        Me.txtEstadoGarantia.Location = New System.Drawing.Point(177, 92)
        Me.txtEstadoGarantia.Name = "txtEstadoGarantia"
        Me.txtEstadoGarantia.Size = New System.Drawing.Size(128, 26)
        Me.txtEstadoGarantia.TabIndex = 6
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Location = New System.Drawing.Point(19, 100)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(49, 18)
        Me.Label55.TabIndex = 5
        Me.Label55.Text = "Estado"
        '
        'txtFechaIngresoGarantia
        '
        Me.txtFechaIngresoGarantia.Location = New System.Drawing.Point(177, 54)
        Me.txtFechaIngresoGarantia.Name = "txtFechaIngresoGarantia"
        Me.txtFechaIngresoGarantia.Size = New System.Drawing.Size(128, 26)
        Me.txtFechaIngresoGarantia.TabIndex = 4
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Location = New System.Drawing.Point(20, 62)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(93, 18)
        Me.Label54.TabIndex = 3
        Me.Label54.Text = "Fecha Ingreso"
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(376, 10)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(68, 26)
        Me.Button7.TabIndex = 2
        Me.Button7.Text = "Buscar"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'txtBoletaGarantia
        '
        Me.txtBoletaGarantia.Location = New System.Drawing.Point(177, 10)
        Me.txtBoletaGarantia.Name = "txtBoletaGarantia"
        Me.txtBoletaGarantia.Size = New System.Drawing.Size(128, 26)
        Me.txtBoletaGarantia.TabIndex = 1
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Font = New System.Drawing.Font("Calibri", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.Location = New System.Drawing.Point(19, 18)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(123, 18)
        Me.Label53.TabIndex = 0
        Me.Label53.Text = "Boleta de Garantia"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.ServicioalCliente.My.Resources.Resources.lineavertical
        Me.PictureBox4.Location = New System.Drawing.Point(467, 6)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(15, 510)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 12
        Me.PictureBox4.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ServicioalCliente.My.Resources.Resources.linea
        Me.PictureBox1.Location = New System.Drawing.Point(20, 72)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(601, 16)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'cmdBuscaCliente
        '
        Me.cmdBuscaCliente.Location = New System.Drawing.Point(391, 10)
        Me.cmdBuscaCliente.Name = "cmdBuscaCliente"
        Me.cmdBuscaCliente.Size = New System.Drawing.Size(66, 28)
        Me.cmdBuscaCliente.TabIndex = 2
        Me.cmdBuscaCliente.Text = "Buscar"
        Me.cmdBuscaCliente.UseVisualStyleBackColor = True
        '
        'txtCliente
        '
        Me.txtCliente.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCliente.Location = New System.Drawing.Point(145, 11)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(163, 27)
        Me.txtCliente.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo Cliente"
        '
        'tabpage57
        '
        Me.tabpage57.Controls.Add(Me.PictureBox14)
        Me.tabpage57.Controls.Add(Me.PictureBox13)
        Me.tabpage57.Controls.Add(Me.PictureBox12)
        Me.tabpage57.Controls.Add(Me.PictureBox11)
        Me.tabpage57.Controls.Add(Me.PictureBox10)
        Me.tabpage57.Controls.Add(Me.PictureBox9)
        Me.tabpage57.Controls.Add(Me.PictureBox8)
        Me.tabpage57.Controls.Add(Me.PictureBox7)
        Me.tabpage57.Controls.Add(Me.PictureBox6)
        Me.tabpage57.Controls.Add(Me.PictureBox5)
        Me.tabpage57.Controls.Add(Me.Label31)
        Me.tabpage57.Controls.Add(Me.PictureBox2)
        Me.tabpage57.Controls.Add(Me.lbNivel)
        Me.tabpage57.Controls.Add(Me.cmbCierre)
        Me.tabpage57.Controls.Add(Me.Label15)
        Me.tabpage57.Controls.Add(Me.cmdConsultarVendedor)
        Me.tabpage57.Controls.Add(Me.lbVendedor)
        Me.tabpage57.Controls.Add(Me.Label64)
        Me.tabpage57.Controls.Add(Me.TabControl3)
        Me.tabpage57.Controls.Add(Me.Button3)
        Me.tabpage57.Controls.Add(Me.txtvendedor)
        Me.tabpage57.Controls.Add(Me.Label18)
        Me.tabpage57.Controls.Add(Me.PictureBox3)
        Me.tabpage57.Location = New System.Drawing.Point(4, 26)
        Me.tabpage57.Name = "tabpage57"
        Me.tabpage57.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpage57.Size = New System.Drawing.Size(1220, 643)
        Me.tabpage57.TabIndex = 1
        Me.tabpage57.Text = "Informacion Vendedor"
        Me.tabpage57.UseVisualStyleBackColor = True
        '
        'PictureBox14
        '
        Me.PictureBox14.Image = Global.ServicioalCliente.My.Resources.Resources.StartMenuFavoritesicon
        Me.PictureBox14.Location = New System.Drawing.Point(962, 53)
        Me.PictureBox14.Name = "PictureBox14"
        Me.PictureBox14.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox14.TabIndex = 50
        Me.PictureBox14.TabStop = False
        '
        'PictureBox13
        '
        Me.PictureBox13.Image = Global.ServicioalCliente.My.Resources.Resources.StartMenuFavoritesicon
        Me.PictureBox13.Location = New System.Drawing.Point(924, 53)
        Me.PictureBox13.Name = "PictureBox13"
        Me.PictureBox13.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox13.TabIndex = 49
        Me.PictureBox13.TabStop = False
        '
        'PictureBox12
        '
        Me.PictureBox12.Image = Global.ServicioalCliente.My.Resources.Resources.StartMenuFavoritesicon
        Me.PictureBox12.Location = New System.Drawing.Point(886, 53)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox12.TabIndex = 48
        Me.PictureBox12.TabStop = False
        '
        'PictureBox11
        '
        Me.PictureBox11.Image = Global.ServicioalCliente.My.Resources.Resources.StartMenuFavoritesicon
        Me.PictureBox11.Location = New System.Drawing.Point(848, 53)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox11.TabIndex = 47
        Me.PictureBox11.TabStop = False
        '
        'PictureBox10
        '
        Me.PictureBox10.Image = Global.ServicioalCliente.My.Resources.Resources.StartMenuFavoritesicon
        Me.PictureBox10.Location = New System.Drawing.Point(810, 53)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox10.TabIndex = 46
        Me.PictureBox10.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.Image = Global.ServicioalCliente.My.Resources.Resources.Flagredicon
        Me.PictureBox9.Location = New System.Drawing.Point(962, 53)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox9.TabIndex = 45
        Me.PictureBox9.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = Global.ServicioalCliente.My.Resources.Resources.Flagredicon
        Me.PictureBox8.Location = New System.Drawing.Point(924, 53)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox8.TabIndex = 20
        Me.PictureBox8.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = Global.ServicioalCliente.My.Resources.Resources.Flagredicon
        Me.PictureBox7.Location = New System.Drawing.Point(886, 53)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox7.TabIndex = 19
        Me.PictureBox7.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.ServicioalCliente.My.Resources.Resources.Flagredicon
        Me.PictureBox6.Location = New System.Drawing.Point(848, 53)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox6.TabIndex = 18
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.ServicioalCliente.My.Resources.Resources.Flagredicon
        Me.PictureBox5.Location = New System.Drawing.Point(810, 53)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox5.TabIndex = 17
        Me.PictureBox5.TabStop = False
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(511, 57)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(45, 18)
        Me.Label31.TabIndex = 16
        Me.Label31.Text = "Nivel:"
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Image = Global.ServicioalCliente.My.Resources.Resources.loading
        Me.PictureBox2.Location = New System.Drawing.Point(924, 6)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 15
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'lbNivel
        '
        Me.lbNivel.AutoSize = True
        Me.lbNivel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbNivel.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNivel.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lbNivel.Location = New System.Drawing.Point(590, 58)
        Me.lbNivel.Name = "lbNivel"
        Me.lbNivel.Size = New System.Drawing.Size(0, 18)
        Me.lbNivel.TabIndex = 14
        '
        'cmbCierre
        '
        Me.cmbCierre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCierre.FormattingEnabled = True
        Me.cmbCierre.Location = New System.Drawing.Point(593, 20)
        Me.cmbCierre.Name = "cmbCierre"
        Me.cmbCierre.Size = New System.Drawing.Size(207, 25)
        Me.cmbCierre.TabIndex = 13
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(510, 24)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(48, 19)
        Me.Label15.TabIndex = 12
        Me.Label15.Text = "Cierre"
        '
        'cmdConsultarVendedor
        '
        Me.cmdConsultarVendedor.Location = New System.Drawing.Point(317, 20)
        Me.cmdConsultarVendedor.Name = "cmdConsultarVendedor"
        Me.cmdConsultarVendedor.Size = New System.Drawing.Size(77, 27)
        Me.cmdConsultarVendedor.TabIndex = 11
        Me.cmdConsultarVendedor.Text = "Mostrar"
        Me.cmdConsultarVendedor.UseVisualStyleBackColor = True
        '
        'lbVendedor
        '
        Me.lbVendedor.AutoSize = True
        Me.lbVendedor.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbVendedor.Location = New System.Drawing.Point(141, 53)
        Me.lbVendedor.Name = "lbVendedor"
        Me.lbVendedor.Size = New System.Drawing.Size(0, 23)
        Me.lbVendedor.TabIndex = 10
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label64.Location = New System.Drawing.Point(17, 57)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(73, 18)
        Me.Label64.TabIndex = 9
        Me.Label64.Text = "Vendedor:"
        '
        'TabControl3
        '
        Me.TabControl3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl3.Controls.Add(Me.tabpage14)
        Me.TabControl3.Controls.Add(Me.TabPage1)
        Me.TabControl3.Controls.Add(Me.TabPage7)
        Me.TabControl3.Controls.Add(Me.tapag45)
        Me.TabControl3.Controls.Add(Me.TabPage9)
        Me.TabControl3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl3.Location = New System.Drawing.Point(20, 104)
        Me.TabControl3.Name = "TabControl3"
        Me.TabControl3.SelectedIndex = 0
        Me.TabControl3.Size = New System.Drawing.Size(1194, 550)
        Me.TabControl3.TabIndex = 8
        '
        'tabpage14
        '
        Me.tabpage14.Controls.Add(Me.Label78)
        Me.tabpage14.Controls.Add(Me.dtFechaNacVendedor)
        Me.tabpage14.Controls.Add(Me.txtdireccionvendedor)
        Me.tabpage14.Controls.Add(Me.cmbdistritovendedor)
        Me.tabpage14.Controls.Add(Me.cmbcantonvendedor)
        Me.tabpage14.Controls.Add(Me.cmbprovinciavendedor)
        Me.tabpage14.Controls.Add(Me.Label41)
        Me.tabpage14.Controls.Add(Me.Button6)
        Me.tabpage14.Controls.Add(Me.txtcorreovendedor)
        Me.tabpage14.Controls.Add(Me.txtfaxvendedor)
        Me.tabpage14.Controls.Add(Me.txtcelularvendedor)
        Me.tabpage14.Controls.Add(Me.txtapellido02vendedor)
        Me.tabpage14.Controls.Add(Me.txthabitacionvendedor)
        Me.tabpage14.Controls.Add(Me.txtapellido01vendedor)
        Me.tabpage14.Controls.Add(Me.txtNombreVendedor)
        Me.tabpage14.Controls.Add(Me.Label42)
        Me.tabpage14.Controls.Add(Me.Label43)
        Me.tabpage14.Controls.Add(Me.Label44)
        Me.tabpage14.Controls.Add(Me.Label45)
        Me.tabpage14.Controls.Add(Me.Label46)
        Me.tabpage14.Controls.Add(Me.Label47)
        Me.tabpage14.Controls.Add(Me.Label48)
        Me.tabpage14.Location = New System.Drawing.Point(4, 27)
        Me.tabpage14.Name = "tabpage14"
        Me.tabpage14.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpage14.Size = New System.Drawing.Size(1186, 519)
        Me.tabpage14.TabIndex = 0
        Me.tabpage14.Text = "Informacion Personal"
        Me.tabpage14.UseVisualStyleBackColor = True
        '
        'Label78
        '
        Me.Label78.AutoSize = True
        Me.Label78.Location = New System.Drawing.Point(130, 277)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(119, 18)
        Me.Label78.TabIndex = 44
        Me.Label78.Text = "Fecha Nacimiento"
        '
        'dtFechaNacVendedor
        '
        Me.dtFechaNacVendedor.Location = New System.Drawing.Point(270, 269)
        Me.dtFechaNacVendedor.Name = "dtFechaNacVendedor"
        Me.dtFechaNacVendedor.Size = New System.Drawing.Size(266, 26)
        Me.dtFechaNacVendedor.TabIndex = 43
        '
        'txtdireccionvendedor
        '
        Me.txtdireccionvendedor.Location = New System.Drawing.Point(269, 354)
        Me.txtdireccionvendedor.Multiline = True
        Me.txtdireccionvendedor.Name = "txtdireccionvendedor"
        Me.txtdireccionvendedor.Size = New System.Drawing.Size(549, 50)
        Me.txtdireccionvendedor.TabIndex = 42
        '
        'cmbdistritovendedor
        '
        Me.cmbdistritovendedor.FormattingEnabled = True
        Me.cmbdistritovendedor.Location = New System.Drawing.Point(644, 312)
        Me.cmbdistritovendedor.Name = "cmbdistritovendedor"
        Me.cmbdistritovendedor.Size = New System.Drawing.Size(174, 26)
        Me.cmbdistritovendedor.TabIndex = 41
        '
        'cmbcantonvendedor
        '
        Me.cmbcantonvendedor.FormattingEnabled = True
        Me.cmbcantonvendedor.Location = New System.Drawing.Point(455, 312)
        Me.cmbcantonvendedor.Name = "cmbcantonvendedor"
        Me.cmbcantonvendedor.Size = New System.Drawing.Size(174, 26)
        Me.cmbcantonvendedor.TabIndex = 40
        '
        'cmbprovinciavendedor
        '
        Me.cmbprovinciavendedor.FormattingEnabled = True
        Me.cmbprovinciavendedor.Location = New System.Drawing.Point(270, 312)
        Me.cmbprovinciavendedor.Name = "cmbprovinciavendedor"
        Me.cmbprovinciavendedor.Size = New System.Drawing.Size(174, 26)
        Me.cmbprovinciavendedor.TabIndex = 39
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(129, 316)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(65, 18)
        Me.Label41.TabIndex = 38
        Me.Label41.Text = "Provincia"
        '
        'Button6
        '
        Me.Button6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button6.Location = New System.Drawing.Point(412, 450)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(176, 26)
        Me.Button6.TabIndex = 37
        Me.Button6.Text = "Actualizar Datos"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'txtcorreovendedor
        '
        Me.txtcorreovendedor.Location = New System.Drawing.Point(270, 226)
        Me.txtcorreovendedor.Name = "txtcorreovendedor"
        Me.txtcorreovendedor.Size = New System.Drawing.Size(360, 26)
        Me.txtcorreovendedor.TabIndex = 36
        '
        'txtfaxvendedor
        '
        Me.txtfaxvendedor.Location = New System.Drawing.Point(270, 176)
        Me.txtfaxvendedor.Name = "txtfaxvendedor"
        Me.txtfaxvendedor.Size = New System.Drawing.Size(175, 26)
        Me.txtfaxvendedor.TabIndex = 35
        '
        'txtcelularvendedor
        '
        Me.txtcelularvendedor.Location = New System.Drawing.Point(270, 135)
        Me.txtcelularvendedor.Name = "txtcelularvendedor"
        Me.txtcelularvendedor.Size = New System.Drawing.Size(175, 26)
        Me.txtcelularvendedor.TabIndex = 34
        '
        'txtapellido02vendedor
        '
        Me.txtapellido02vendedor.Location = New System.Drawing.Point(451, 52)
        Me.txtapellido02vendedor.Name = "txtapellido02vendedor"
        Me.txtapellido02vendedor.Size = New System.Drawing.Size(179, 26)
        Me.txtapellido02vendedor.TabIndex = 33
        '
        'txthabitacionvendedor
        '
        Me.txthabitacionvendedor.Location = New System.Drawing.Point(270, 93)
        Me.txthabitacionvendedor.Name = "txthabitacionvendedor"
        Me.txthabitacionvendedor.Size = New System.Drawing.Size(175, 26)
        Me.txthabitacionvendedor.TabIndex = 32
        '
        'txtapellido01vendedor
        '
        Me.txtapellido01vendedor.Location = New System.Drawing.Point(270, 52)
        Me.txtapellido01vendedor.Name = "txtapellido01vendedor"
        Me.txtapellido01vendedor.Size = New System.Drawing.Size(175, 26)
        Me.txtapellido01vendedor.TabIndex = 31
        '
        'txtNombreVendedor
        '
        Me.txtNombreVendedor.Location = New System.Drawing.Point(270, 9)
        Me.txtNombreVendedor.Name = "txtNombreVendedor"
        Me.txtNombreVendedor.Size = New System.Drawing.Size(360, 26)
        Me.txtNombreVendedor.TabIndex = 30
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(130, 234)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(77, 18)
        Me.Label42.TabIndex = 29
        Me.Label42.Text = "Electronico"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(130, 216)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(50, 18)
        Me.Label43.TabIndex = 28
        Me.Label43.Text = "Correo"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(130, 184)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(29, 18)
        Me.Label44.TabIndex = 27
        Me.Label44.Text = "Fax"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(130, 143)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(110, 18)
        Me.Label45.TabIndex = 26
        Me.Label45.Text = "Telefono Celular"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(130, 101)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(132, 18)
        Me.Label46.TabIndex = 25
        Me.Label46.Text = "Telefono Habitacion"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Location = New System.Drawing.Point(130, 60)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(67, 18)
        Me.Label47.TabIndex = 24
        Me.Label47.Text = "Apellidos"
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Location = New System.Drawing.Point(130, 17)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(59, 18)
        Me.Label48.TabIndex = 23
        Me.Label48.Text = "Nombre"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lvReferencias)
        Me.TabPage1.Controls.Add(Me.Label70)
        Me.TabPage1.Controls.Add(Me.txtTelefonoReferencia02)
        Me.TabPage1.Controls.Add(Me.txtSector02)
        Me.TabPage1.Controls.Add(Me.txtNombreReferencia02)
        Me.TabPage1.Controls.Add(Me.Label69)
        Me.TabPage1.Controls.Add(Me.Label68)
        Me.TabPage1.Controls.Add(Me.Label67)
        Me.TabPage1.Controls.Add(Me.txtTelefonoReferencia01)
        Me.TabPage1.Controls.Add(Me.txtSector01)
        Me.TabPage1.Controls.Add(Me.txtNombreReferencia01)
        Me.TabPage1.Controls.Add(Me.Label66)
        Me.TabPage1.Controls.Add(Me.txtTelefonoConyuge)
        Me.TabPage1.Controls.Add(Me.Label50)
        Me.TabPage1.Controls.Add(Me.txtNombreConyuge)
        Me.TabPage1.Controls.Add(Me.Label26)
        Me.TabPage1.Controls.Add(Me.txtEstadoCivil)
        Me.TabPage1.Controls.Add(Me.Label24)
        Me.TabPage1.Location = New System.Drawing.Point(4, 27)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(1186, 519)
        Me.TabPage1.TabIndex = 4
        Me.TabPage1.Text = "Referencias"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'lvReferencias
        '
        Me.lvReferencias.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lvReferencias.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader41, Me.ColumnHeader42, Me.ColumnHeader43, Me.ColumnHeader44})
        Me.lvReferencias.Location = New System.Drawing.Point(36, 265)
        Me.lvReferencias.Name = "lvReferencias"
        Me.lvReferencias.Size = New System.Drawing.Size(812, 217)
        Me.lvReferencias.TabIndex = 17
        Me.lvReferencias.UseCompatibleStateImageBehavior = False
        Me.lvReferencias.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader41
        '
        Me.ColumnHeader41.Text = "Nombre"
        Me.ColumnHeader41.Width = 296
        '
        'ColumnHeader42
        '
        Me.ColumnHeader42.Text = "Telefono #1"
        Me.ColumnHeader42.Width = 97
        '
        'ColumnHeader43
        '
        Me.ColumnHeader43.Text = "Telefono #2"
        Me.ColumnHeader43.Width = 102
        '
        'ColumnHeader44
        '
        Me.ColumnHeader44.Text = "Observaciones"
        Me.ColumnHeader44.Width = 308
        '
        'Label70
        '
        Me.Label70.AutoSize = True
        Me.Label70.Font = New System.Drawing.Font("Calibri", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label70.Location = New System.Drawing.Point(33, 244)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(117, 18)
        Me.Label70.TabIndex = 16
        Me.Label70.Text = "Otras Referencias"
        '
        'txtTelefonoReferencia02
        '
        Me.txtTelefonoReferencia02.Location = New System.Drawing.Point(630, 206)
        Me.txtTelefonoReferencia02.Name = "txtTelefonoReferencia02"
        Me.txtTelefonoReferencia02.Size = New System.Drawing.Size(218, 26)
        Me.txtTelefonoReferencia02.TabIndex = 15
        '
        'txtSector02
        '
        Me.txtSector02.Location = New System.Drawing.Point(389, 206)
        Me.txtSector02.Name = "txtSector02"
        Me.txtSector02.Size = New System.Drawing.Size(235, 26)
        Me.txtSector02.TabIndex = 14
        '
        'txtNombreReferencia02
        '
        Me.txtNombreReferencia02.Location = New System.Drawing.Point(36, 206)
        Me.txtNombreReferencia02.Name = "txtNombreReferencia02"
        Me.txtNombreReferencia02.Size = New System.Drawing.Size(347, 26)
        Me.txtNombreReferencia02.TabIndex = 13
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.Location = New System.Drawing.Point(627, 153)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(63, 18)
        Me.Label69.TabIndex = 12
        Me.Label69.Text = "Telefono"
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.Location = New System.Drawing.Point(386, 153)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(47, 18)
        Me.Label68.TabIndex = 11
        Me.Label68.Text = "Sector"
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.Location = New System.Drawing.Point(33, 153)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(59, 18)
        Me.Label67.TabIndex = 10
        Me.Label67.Text = "Nombre"
        '
        'txtTelefonoReferencia01
        '
        Me.txtTelefonoReferencia01.Location = New System.Drawing.Point(630, 174)
        Me.txtTelefonoReferencia01.Name = "txtTelefonoReferencia01"
        Me.txtTelefonoReferencia01.Size = New System.Drawing.Size(218, 26)
        Me.txtTelefonoReferencia01.TabIndex = 9
        '
        'txtSector01
        '
        Me.txtSector01.Location = New System.Drawing.Point(389, 174)
        Me.txtSector01.Name = "txtSector01"
        Me.txtSector01.Size = New System.Drawing.Size(235, 26)
        Me.txtSector01.TabIndex = 8
        '
        'txtNombreReferencia01
        '
        Me.txtNombreReferencia01.Location = New System.Drawing.Point(36, 174)
        Me.txtNombreReferencia01.Name = "txtNombreReferencia01"
        Me.txtNombreReferencia01.Size = New System.Drawing.Size(347, 26)
        Me.txtNombreReferencia01.TabIndex = 7
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.Font = New System.Drawing.Font("Calibri", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label66.Location = New System.Drawing.Point(33, 120)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(152, 18)
        Me.Label66.TabIndex = 6
        Me.Label66.Text = "Referencias Personales"
        '
        'txtTelefonoConyuge
        '
        Me.txtTelefonoConyuge.Location = New System.Drawing.Point(185, 77)
        Me.txtTelefonoConyuge.Name = "txtTelefonoConyuge"
        Me.txtTelefonoConyuge.Size = New System.Drawing.Size(198, 26)
        Me.txtTelefonoConyuge.TabIndex = 5
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Location = New System.Drawing.Point(33, 80)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(120, 18)
        Me.Label50.TabIndex = 4
        Me.Label50.Text = "Telefono Conyuge"
        '
        'txtNombreConyuge
        '
        Me.txtNombreConyuge.Location = New System.Drawing.Point(185, 45)
        Me.txtNombreConyuge.Name = "txtNombreConyuge"
        Me.txtNombreConyuge.Size = New System.Drawing.Size(616, 26)
        Me.txtNombreConyuge.TabIndex = 3
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(33, 48)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(116, 18)
        Me.Label26.TabIndex = 2
        Me.Label26.Text = "Nombre Conyuge"
        '
        'txtEstadoCivil
        '
        Me.txtEstadoCivil.Location = New System.Drawing.Point(185, 13)
        Me.txtEstadoCivil.Name = "txtEstadoCivil"
        Me.txtEstadoCivil.Size = New System.Drawing.Size(163, 26)
        Me.txtEstadoCivil.TabIndex = 1
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(33, 21)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(79, 18)
        Me.Label24.TabIndex = 0
        Me.Label24.Text = "Estado Civil"
        '
        'TabPage7
        '
        Me.TabPage7.Controls.Add(Me.txtContratoOrganizacion)
        Me.TabPage7.Controls.Add(Me.Label76)
        Me.TabPage7.Controls.Add(Me.txtCorreoOrganizacion)
        Me.TabPage7.Controls.Add(Me.txtTelefono03Organizacion)
        Me.TabPage7.Controls.Add(Me.txtTelefono02Organizacion)
        Me.TabPage7.Controls.Add(Me.txtTelefono01Organizacion)
        Me.TabPage7.Controls.Add(Me.Label75)
        Me.TabPage7.Controls.Add(Me.Label74)
        Me.TabPage7.Controls.Add(Me.Label73)
        Me.TabPage7.Controls.Add(Me.Label72)
        Me.TabPage7.Controls.Add(Me.txtDistribuidorOrganizacion)
        Me.TabPage7.Controls.Add(Me.Label71)
        Me.TabPage7.Controls.Add(Me.lvTreeReclutas)
        Me.TabPage7.Location = New System.Drawing.Point(4, 27)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage7.Size = New System.Drawing.Size(1186, 519)
        Me.TabPage7.TabIndex = 1
        Me.TabPage7.Text = "Organizacion"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'txtContratoOrganizacion
        '
        Me.txtContratoOrganizacion.Location = New System.Drawing.Point(445, 101)
        Me.txtContratoOrganizacion.Name = "txtContratoOrganizacion"
        Me.txtContratoOrganizacion.ReadOnly = True
        Me.txtContratoOrganizacion.Size = New System.Drawing.Size(73, 26)
        Me.txtContratoOrganizacion.TabIndex = 12
        '
        'Label76
        '
        Me.Label76.AutoSize = True
        Me.Label76.Location = New System.Drawing.Point(442, 80)
        Me.Label76.Name = "Label76"
        Me.Label76.Size = New System.Drawing.Size(62, 18)
        Me.Label76.TabIndex = 11
        Me.Label76.Text = "Contrato"
        '
        'txtCorreoOrganizacion
        '
        Me.txtCorreoOrganizacion.Location = New System.Drawing.Point(445, 366)
        Me.txtCorreoOrganizacion.Name = "txtCorreoOrganizacion"
        Me.txtCorreoOrganizacion.ReadOnly = True
        Me.txtCorreoOrganizacion.Size = New System.Drawing.Size(467, 26)
        Me.txtCorreoOrganizacion.TabIndex = 10
        '
        'txtTelefono03Organizacion
        '
        Me.txtTelefono03Organizacion.Location = New System.Drawing.Point(445, 295)
        Me.txtTelefono03Organizacion.Name = "txtTelefono03Organizacion"
        Me.txtTelefono03Organizacion.ReadOnly = True
        Me.txtTelefono03Organizacion.Size = New System.Drawing.Size(214, 26)
        Me.txtTelefono03Organizacion.TabIndex = 9
        '
        'txtTelefono02Organizacion
        '
        Me.txtTelefono02Organizacion.Location = New System.Drawing.Point(445, 230)
        Me.txtTelefono02Organizacion.Name = "txtTelefono02Organizacion"
        Me.txtTelefono02Organizacion.ReadOnly = True
        Me.txtTelefono02Organizacion.Size = New System.Drawing.Size(214, 26)
        Me.txtTelefono02Organizacion.TabIndex = 8
        '
        'txtTelefono01Organizacion
        '
        Me.txtTelefono01Organizacion.Location = New System.Drawing.Point(445, 165)
        Me.txtTelefono01Organizacion.Name = "txtTelefono01Organizacion"
        Me.txtTelefono01Organizacion.ReadOnly = True
        Me.txtTelefono01Organizacion.Size = New System.Drawing.Size(214, 26)
        Me.txtTelefono01Organizacion.TabIndex = 7
        '
        'Label75
        '
        Me.Label75.AutoSize = True
        Me.Label75.Location = New System.Drawing.Point(442, 345)
        Me.Label75.Name = "Label75"
        Me.Label75.Size = New System.Drawing.Size(122, 18)
        Me.Label75.TabIndex = 6
        Me.Label75.Text = "Correo Electronico"
        '
        'Label74
        '
        Me.Label74.AutoSize = True
        Me.Label74.Location = New System.Drawing.Point(442, 274)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(111, 18)
        Me.Label74.TabIndex = 5
        Me.Label74.Text = "Telefono Trabajo"
        '
        'Label73
        '
        Me.Label73.AutoSize = True
        Me.Label73.Location = New System.Drawing.Point(442, 209)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(110, 18)
        Me.Label73.TabIndex = 4
        Me.Label73.Text = "Telefono Celular"
        '
        'Label72
        '
        Me.Label72.AutoSize = True
        Me.Label72.Location = New System.Drawing.Point(442, 144)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(132, 18)
        Me.Label72.TabIndex = 3
        Me.Label72.Text = "Telefono Habitacion"
        '
        'txtDistribuidorOrganizacion
        '
        Me.txtDistribuidorOrganizacion.Location = New System.Drawing.Point(445, 39)
        Me.txtDistribuidorOrganizacion.Name = "txtDistribuidorOrganizacion"
        Me.txtDistribuidorOrganizacion.ReadOnly = True
        Me.txtDistribuidorOrganizacion.Size = New System.Drawing.Size(477, 26)
        Me.txtDistribuidorOrganizacion.TabIndex = 2
        '
        'Label71
        '
        Me.Label71.AutoSize = True
        Me.Label71.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label71.Location = New System.Drawing.Point(442, 18)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(100, 18)
        Me.Label71.TabIndex = 1
        Me.Label71.Text = "Representante"
        '
        'lvTreeReclutas
        '
        Me.lvTreeReclutas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lvTreeReclutas.FullRowSelect = True
        Me.lvTreeReclutas.Location = New System.Drawing.Point(15, 18)
        Me.lvTreeReclutas.Name = "lvTreeReclutas"
        Me.lvTreeReclutas.Size = New System.Drawing.Size(406, 490)
        Me.lvTreeReclutas.TabIndex = 0
        '
        'tapag45
        '
        Me.tapag45.Controls.Add(Me.txtDiasIngreso)
        Me.tapag45.Controls.Add(Me.Label32)
        Me.tapag45.Controls.Add(Me.txtNuevosDirectos)
        Me.tapag45.Controls.Add(Me.Label82)
        Me.tapag45.Controls.Add(Me.txtNuevosReclutas)
        Me.tapag45.Controls.Add(Me.Label81)
        Me.tapag45.Controls.Add(Me.Label80)
        Me.tapag45.Controls.Add(Me.txtIndirectosVenta)
        Me.tapag45.Controls.Add(Me.Label79)
        Me.tapag45.Controls.Add(Me.txtDirectosConVenta)
        Me.tapag45.Controls.Add(Me.Label14)
        Me.tapag45.Controls.Add(Me.TabControl2)
        Me.tapag45.Controls.Add(Me.txtVentasPersonalesProceso)
        Me.tapag45.Controls.Add(Me.Label62)
        Me.tapag45.Controls.Add(Me.txtReclutasActivosIndirectos)
        Me.tapag45.Controls.Add(Me.Label52)
        Me.tapag45.Controls.Add(Me.txtReclutasActivosDirectos)
        Me.tapag45.Controls.Add(Me.txtVentasUnidad)
        Me.tapag45.Controls.Add(Me.Label51)
        Me.tapag45.Controls.Add(Me.txtVendedorVentasPersonales)
        Me.tapag45.Controls.Add(Me.Label49)
        Me.tapag45.Location = New System.Drawing.Point(4, 27)
        Me.tapag45.Name = "tapag45"
        Me.tapag45.Size = New System.Drawing.Size(1186, 519)
        Me.tapag45.TabIndex = 2
        Me.tapag45.Text = "Ventas"
        Me.tapag45.UseVisualStyleBackColor = True
        '
        'txtDiasIngreso
        '
        Me.txtDiasIngreso.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiasIngreso.Location = New System.Drawing.Point(709, 43)
        Me.txtDiasIngreso.Name = "txtDiasIngreso"
        Me.txtDiasIngreso.Size = New System.Drawing.Size(103, 22)
        Me.txtDiasIngreso.TabIndex = 31
        Me.txtDiasIngreso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(568, 46)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(98, 17)
        Me.Label32.TabIndex = 30
        Me.Label32.Text = "Dias de Ingreso"
        '
        'txtNuevosDirectos
        '
        Me.txtNuevosDirectos.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNuevosDirectos.Location = New System.Drawing.Point(141, 94)
        Me.txtNuevosDirectos.Name = "txtNuevosDirectos"
        Me.txtNuevosDirectos.Size = New System.Drawing.Size(103, 22)
        Me.txtNuevosDirectos.TabIndex = 29
        Me.txtNuevosDirectos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label82
        '
        Me.Label82.AutoSize = True
        Me.Label82.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label82.Location = New System.Drawing.Point(15, 97)
        Me.Label82.Name = "Label82"
        Me.Label82.Size = New System.Drawing.Size(106, 17)
        Me.Label82.TabIndex = 28
        Me.Label82.Text = "Nuevos Directos"
        '
        'txtNuevosReclutas
        '
        Me.txtNuevosReclutas.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNuevosReclutas.Location = New System.Drawing.Point(141, 68)
        Me.txtNuevosReclutas.Name = "txtNuevosReclutas"
        Me.txtNuevosReclutas.Size = New System.Drawing.Size(103, 22)
        Me.txtNuevosReclutas.TabIndex = 27
        Me.txtNuevosReclutas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label81
        '
        Me.Label81.AutoSize = True
        Me.Label81.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label81.Location = New System.Drawing.Point(15, 71)
        Me.Label81.Name = "Label81"
        Me.Label81.Size = New System.Drawing.Size(107, 17)
        Me.Label81.TabIndex = 26
        Me.Label81.Text = "Nuevos Reclutas"
        '
        'Label80
        '
        Me.Label80.AutoSize = True
        Me.Label80.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label80.Location = New System.Drawing.Point(303, 99)
        Me.Label80.Name = "Label80"
        Me.Label80.Size = New System.Drawing.Size(133, 17)
        Me.Label80.TabIndex = 25
        Me.Label80.Text = "Con venta Indirectos"
        '
        'txtIndirectosVenta
        '
        Me.txtIndirectosVenta.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIndirectosVenta.Location = New System.Drawing.Point(442, 96)
        Me.txtIndirectosVenta.Name = "txtIndirectosVenta"
        Me.txtIndirectosVenta.Size = New System.Drawing.Size(103, 22)
        Me.txtIndirectosVenta.TabIndex = 24
        Me.txtIndirectosVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label79
        '
        Me.Label79.AutoSize = True
        Me.Label79.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label79.Location = New System.Drawing.Point(303, 71)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(123, 17)
        Me.Label79.TabIndex = 23
        Me.Label79.Text = "Con venta directos"
        '
        'txtDirectosConVenta
        '
        Me.txtDirectosConVenta.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDirectosConVenta.Location = New System.Drawing.Point(442, 68)
        Me.txtDirectosConVenta.Name = "txtDirectosConVenta"
        Me.txtDirectosConVenta.Size = New System.Drawing.Size(103, 22)
        Me.txtDirectosConVenta.TabIndex = 22
        Me.txtDirectosConVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(303, 43)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(116, 17)
        Me.Label14.TabIndex = 21
        Me.Label14.Text = "Activos Indirectos"
        '
        'TabControl2
        '
        Me.TabControl2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl2.Controls.Add(Me.TabPage2)
        Me.TabControl2.Controls.Add(Me.TabPage10)
        Me.TabControl2.Controls.Add(Me.TabPage13)
        Me.TabControl2.Controls.Add(Me.TabPage8)
        Me.TabControl2.Location = New System.Drawing.Point(14, 122)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(1169, 394)
        Me.TabControl2.TabIndex = 20
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.lvFacturasVendedor)
        Me.TabPage2.Location = New System.Drawing.Point(4, 27)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1161, 363)
        Me.TabPage2.TabIndex = 0
        Me.TabPage2.Text = "Informacion Personal"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'lvFacturasVendedor
        '
        Me.lvFacturasVendedor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvFacturasVendedor.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader26, Me.ColumnHeader27, Me.ColumnHeader28, Me.ColumnHeader38, Me.ColumnHeader29, Me.ColumnHeader30, Me.ColumnHeader31})
        Me.lvFacturasVendedor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lvFacturasVendedor.FullRowSelect = True
        ListViewGroup3.Header = "Primera Cuota Completa"
        ListViewGroup3.Name = "ListViewGroup1"
        ListViewGroup4.Header = "Pendientes de Primer Pago"
        ListViewGroup4.Name = "ListViewGroup2"
        Me.lvFacturasVendedor.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup3, ListViewGroup4})
        Me.lvFacturasVendedor.Location = New System.Drawing.Point(7, 17)
        Me.lvFacturasVendedor.Name = "lvFacturasVendedor"
        Me.lvFacturasVendedor.Size = New System.Drawing.Size(1142, 330)
        Me.lvFacturasVendedor.TabIndex = 13
        Me.lvFacturasVendedor.UseCompatibleStateImageBehavior = False
        Me.lvFacturasVendedor.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader26
        '
        Me.ColumnHeader26.Text = "Factura"
        Me.ColumnHeader26.Width = 68
        '
        'ColumnHeader27
        '
        Me.ColumnHeader27.Text = "Fecha"
        Me.ColumnHeader27.Width = 103
        '
        'ColumnHeader28
        '
        Me.ColumnHeader28.Text = "Plazo"
        Me.ColumnHeader28.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader28.Width = 65
        '
        'ColumnHeader38
        '
        Me.ColumnHeader38.Text = "Cliente"
        Me.ColumnHeader38.Width = 273
        '
        'ColumnHeader29
        '
        Me.ColumnHeader29.Text = "Monto Total"
        Me.ColumnHeader29.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader29.Width = 99
        '
        'ColumnHeader30
        '
        Me.ColumnHeader30.Text = "Cuota Mensual"
        Me.ColumnHeader30.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader30.Width = 80
        '
        'ColumnHeader31
        '
        Me.ColumnHeader31.Text = "Monto Abonado"
        Me.ColumnHeader31.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader31.Width = 95
        '
        'TabPage10
        '
        Me.TabPage10.Controls.Add(Me.Label65)
        Me.TabPage10.Controls.Add(Me.Label63)
        Me.TabPage10.Controls.Add(Me.lvVentasRecluta)
        Me.TabPage10.Controls.Add(Me.lvVendedoresUnidad)
        Me.TabPage10.Location = New System.Drawing.Point(4, 27)
        Me.TabPage10.Name = "TabPage10"
        Me.TabPage10.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage10.Size = New System.Drawing.Size(1161, 363)
        Me.TabPage10.TabIndex = 1
        Me.TabPage10.Text = "Informacion Unidad"
        Me.TabPage10.UseVisualStyleBackColor = True
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label65.Location = New System.Drawing.Point(607, 13)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(151, 13)
        Me.Label65.TabIndex = 22
        Me.Label65.Text = "Detalle de Ventas Registradas"
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label63.Location = New System.Drawing.Point(6, 13)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(230, 13)
        Me.Label63.TabIndex = 21
        Me.Label63.Text = "Registro de Ventas  - Vendedores de la Unidad"
        '
        'lvVentasRecluta
        '
        Me.lvVentasRecluta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvVentasRecluta.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader14, Me.ColumnHeader20, Me.ColumnHeader21, Me.ColumnHeader22})
        ListViewGroup5.Header = "Primera Cuota Completa"
        ListViewGroup5.Name = "ListViewGroup1"
        ListViewGroup6.Header = "Pendientes de Primer Pago"
        ListViewGroup6.Name = "ListViewGroup2"
        Me.lvVentasRecluta.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup5, ListViewGroup6})
        Me.lvVentasRecluta.Location = New System.Drawing.Point(610, 34)
        Me.lvVentasRecluta.Name = "lvVentasRecluta"
        Me.lvVentasRecluta.Size = New System.Drawing.Size(524, 422)
        Me.lvVentasRecluta.TabIndex = 20
        Me.lvVentasRecluta.UseCompatibleStateImageBehavior = False
        Me.lvVentasRecluta.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Factura"
        Me.ColumnHeader12.Width = 68
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Fecha"
        Me.ColumnHeader13.Width = 103
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "Plazo"
        Me.ColumnHeader14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader14.Width = 65
        '
        'ColumnHeader20
        '
        Me.ColumnHeader20.Text = "Linea 1"
        Me.ColumnHeader20.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader20.Width = 99
        '
        'ColumnHeader21
        '
        Me.ColumnHeader21.Text = "Cuota Mensual"
        Me.ColumnHeader21.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader21.Width = 80
        '
        'ColumnHeader22
        '
        Me.ColumnHeader22.Text = "Monto Abonado"
        Me.ColumnHeader22.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader22.Width = 95
        '
        'lvVendedoresUnidad
        '
        Me.lvVendedoresUnidad.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lvVendedoresUnidad.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader39, Me.ColumnHeader40})
        Me.lvVendedoresUnidad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lvVendedoresUnidad.FullRowSelect = True
        ListViewGroup7.Header = "Sin Ventas"
        ListViewGroup7.Name = "ListViewGroup4"
        Me.lvVendedoresUnidad.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup7})
        Me.lvVendedoresUnidad.Location = New System.Drawing.Point(9, 34)
        Me.lvVendedoresUnidad.Name = "lvVendedoresUnidad"
        Me.lvVendedoresUnidad.Size = New System.Drawing.Size(584, 422)
        Me.lvVendedoresUnidad.TabIndex = 19
        Me.lvVendedoresUnidad.UseCompatibleStateImageBehavior = False
        Me.lvVendedoresUnidad.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Vendedor"
        Me.ColumnHeader4.Width = 318
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Ventas Actuales"
        Me.ColumnHeader10.Width = 121
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "En transicion"
        Me.ColumnHeader11.Width = 123
        '
        'ColumnHeader39
        '
        Me.ColumnHeader39.Text = "Codigo"
        Me.ColumnHeader39.Width = 0
        '
        'ColumnHeader40
        '
        Me.ColumnHeader40.Text = "Generacion"
        Me.ColumnHeader40.Width = 0
        '
        'TabPage13
        '
        Me.TabPage13.Controls.Add(Me.lvEstadoReclutamiento)
        Me.TabPage13.Location = New System.Drawing.Point(4, 27)
        Me.TabPage13.Name = "TabPage13"
        Me.TabPage13.Size = New System.Drawing.Size(1161, 363)
        Me.TabPage13.TabIndex = 2
        Me.TabPage13.Text = "Estado de Reclutamiento"
        Me.TabPage13.UseVisualStyleBackColor = True
        '
        'lvEstadoReclutamiento
        '
        Me.lvEstadoReclutamiento.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvEstadoReclutamiento.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader19, Me.ColumnHeader23, Me.ColumnHeader50, Me.ColumnHeader51, Me.ColumnHeader24, Me.ColumnHeader25, Me.ColumnHeader45, Me.ColumnHeader46, Me.ColumnHeader47, Me.ColumnHeader48, Me.ColumnHeader49})
        Me.lvEstadoReclutamiento.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ListViewGroup8.Header = "Ingreso <= 30"
        ListViewGroup8.Name = "ListViewGroup1"
        ListViewGroup9.Header = "Ingreso <= 60"
        ListViewGroup9.Name = "ListViewGroup2"
        ListViewGroup10.Header = "Ingreso <= 90"
        ListViewGroup10.Name = "ListViewGroup3"
        ListViewGroup11.Header = "Ingreso <= 120"
        ListViewGroup11.Name = "ListViewGroup4"
        ListViewGroup12.Header = "Ingreso > 120"
        ListViewGroup12.Name = "ListViewGroup5"
        Me.lvEstadoReclutamiento.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup8, ListViewGroup9, ListViewGroup10, ListViewGroup11, ListViewGroup12})
        Me.lvEstadoReclutamiento.Location = New System.Drawing.Point(13, 14)
        Me.lvEstadoReclutamiento.Name = "lvEstadoReclutamiento"
        Me.lvEstadoReclutamiento.Size = New System.Drawing.Size(1134, 494)
        Me.lvEstadoReclutamiento.TabIndex = 0
        Me.lvEstadoReclutamiento.UseCompatibleStateImageBehavior = False
        Me.lvEstadoReclutamiento.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader19
        '
        Me.ColumnHeader19.Text = "Vendedor"
        Me.ColumnHeader19.Width = 81
        '
        'ColumnHeader23
        '
        Me.ColumnHeader23.Text = "Nombre"
        Me.ColumnHeader23.Width = 257
        '
        'ColumnHeader50
        '
        Me.ColumnHeader50.Text = "Gen"
        '
        'ColumnHeader51
        '
        Me.ColumnHeader51.Text = "P. Ingreso"
        '
        'ColumnHeader24
        '
        Me.ColumnHeader24.Text = "F. Ingreso"
        Me.ColumnHeader24.Width = 66
        '
        'ColumnHeader25
        '
        Me.ColumnHeader25.Text = "F. Primer Venta"
        Me.ColumnHeader25.Width = 74
        '
        'ColumnHeader45
        '
        Me.ColumnHeader45.Text = "F. Ult Venta"
        Me.ColumnHeader45.Width = 83
        '
        'ColumnHeader46
        '
        Me.ColumnHeader46.Text = "M. Activos"
        '
        'ColumnHeader47
        '
        Me.ColumnHeader47.Text = "P. Activacion"
        Me.ColumnHeader47.Width = 87
        '
        'ColumnHeader48
        '
        Me.ColumnHeader48.Text = "P. Cambio Nivel"
        Me.ColumnHeader48.Width = 99
        '
        'ColumnHeader49
        '
        Me.ColumnHeader49.Text = "Reclutas Directos"
        Me.ColumnHeader49.Width = 78
        '
        'TabPage8
        '
        Me.TabPage8.Controls.Add(Me.lbEstadoReclutamiento)
        Me.TabPage8.Controls.Add(Me.ChartReclutamiento)
        Me.TabPage8.Controls.Add(Me.lbVentasProvincia)
        Me.TabPage8.Controls.Add(Me.ChartVentaEquipo)
        Me.TabPage8.Location = New System.Drawing.Point(4, 27)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage8.Size = New System.Drawing.Size(1161, 363)
        Me.TabPage8.TabIndex = 3
        Me.TabPage8.Text = "Graficos por Provincias"
        Me.TabPage8.UseVisualStyleBackColor = True
        '
        'lbEstadoReclutamiento
        '
        Me.lbEstadoReclutamiento.AutoSize = True
        Me.lbEstadoReclutamiento.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEstadoReclutamiento.Location = New System.Drawing.Point(479, 16)
        Me.lbEstadoReclutamiento.Name = "lbEstadoReclutamiento"
        Me.lbEstadoReclutamiento.Size = New System.Drawing.Size(178, 17)
        Me.lbEstadoReclutamiento.TabIndex = 31
        Me.lbEstadoReclutamiento.Text = "Reclutamiento por Provincia"
        '
        'ChartReclutamiento
        '
        ChartArea1.Area3DStyle.Enable3D = True
        ChartArea1.Area3DStyle.Inclination = 60
        ChartArea1.Area3DStyle.IsRightAngleAxes = False
        ChartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic
        ChartArea1.Name = "ChartArea1"
        Me.ChartReclutamiento.ChartAreas.Add(ChartArea1)
        Legend1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend1.IsTextAutoFit = False
        Legend1.Name = "Legend1"
        Me.ChartReclutamiento.Legends.Add(Legend1)
        Me.ChartReclutamiento.Location = New System.Drawing.Point(469, 16)
        Me.ChartReclutamiento.Name = "ChartReclutamiento"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series1.IsValueShownAsLabel = True
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        DataPoint1.IsValueShownAsLabel = False
        DataPoint1.Label = ""
        DataPoint1.LegendText = "Alajuela"
        DataPoint2.Label = ""
        Series1.Points.Add(DataPoint1)
        Series1.Points.Add(DataPoint2)
        Me.ChartReclutamiento.Series.Add(Series1)
        Me.ChartReclutamiento.Size = New System.Drawing.Size(461, 341)
        Me.ChartReclutamiento.TabIndex = 30
        Me.ChartReclutamiento.Text = "Chart1"
        '
        'lbVentasProvincia
        '
        Me.lbVentasProvincia.AutoSize = True
        Me.lbVentasProvincia.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbVentasProvincia.Location = New System.Drawing.Point(15, 16)
        Me.lbVentasProvincia.Name = "lbVentasProvincia"
        Me.lbVentasProvincia.Size = New System.Drawing.Size(132, 17)
        Me.lbVentasProvincia.TabIndex = 29
        Me.lbVentasProvincia.Text = "Ventas por Provincia"
        '
        'ChartVentaEquipo
        '
        ChartArea2.Area3DStyle.Enable3D = True
        ChartArea2.Area3DStyle.Inclination = 60
        ChartArea2.Area3DStyle.IsRightAngleAxes = False
        ChartArea2.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic
        ChartArea2.Name = "ChartArea1"
        Me.ChartVentaEquipo.ChartAreas.Add(ChartArea2)
        Legend2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend2.IsTextAutoFit = False
        Legend2.Name = "Legend1"
        Me.ChartVentaEquipo.Legends.Add(Legend2)
        Me.ChartVentaEquipo.Location = New System.Drawing.Point(18, 16)
        Me.ChartVentaEquipo.Name = "ChartVentaEquipo"
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series2.IsValueShownAsLabel = True
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        DataPoint3.IsValueShownAsLabel = False
        DataPoint3.Label = ""
        DataPoint3.LegendText = "Alajuela"
        DataPoint4.Label = ""
        Series2.Points.Add(DataPoint3)
        Series2.Points.Add(DataPoint4)
        Me.ChartVentaEquipo.Series.Add(Series2)
        Me.ChartVentaEquipo.Size = New System.Drawing.Size(461, 341)
        Me.ChartVentaEquipo.TabIndex = 0
        Me.ChartVentaEquipo.Text = "Chart1"
        '
        'txtVentasPersonalesProceso
        '
        Me.txtVentasPersonalesProceso.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVentasPersonalesProceso.Location = New System.Drawing.Point(141, 43)
        Me.txtVentasPersonalesProceso.Name = "txtVentasPersonalesProceso"
        Me.txtVentasPersonalesProceso.Size = New System.Drawing.Size(103, 22)
        Me.txtVentasPersonalesProceso.TabIndex = 19
        Me.txtVentasPersonalesProceso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label62.Location = New System.Drawing.Point(15, 46)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(74, 17)
        Me.Label62.TabIndex = 13
        Me.Label62.Text = "Pendientes"
        '
        'txtReclutasActivosIndirectos
        '
        Me.txtReclutasActivosIndirectos.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReclutasActivosIndirectos.Location = New System.Drawing.Point(442, 41)
        Me.txtReclutasActivosIndirectos.Name = "txtReclutasActivosIndirectos"
        Me.txtReclutasActivosIndirectos.Size = New System.Drawing.Size(103, 22)
        Me.txtReclutasActivosIndirectos.TabIndex = 11
        Me.txtReclutasActivosIndirectos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.Location = New System.Drawing.Point(303, 14)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(107, 17)
        Me.Label52.TabIndex = 10
        Me.Label52.Text = "Activos Directos"
        '
        'txtReclutasActivosDirectos
        '
        Me.txtReclutasActivosDirectos.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReclutasActivosDirectos.Location = New System.Drawing.Point(442, 13)
        Me.txtReclutasActivosDirectos.Name = "txtReclutasActivosDirectos"
        Me.txtReclutasActivosDirectos.Size = New System.Drawing.Size(103, 22)
        Me.txtReclutasActivosDirectos.TabIndex = 9
        Me.txtReclutasActivosDirectos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtVentasUnidad
        '
        Me.txtVentasUnidad.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVentasUnidad.Location = New System.Drawing.Point(709, 13)
        Me.txtVentasUnidad.Name = "txtVentasUnidad"
        Me.txtVentasUnidad.Size = New System.Drawing.Size(103, 22)
        Me.txtVentasUnidad.TabIndex = 8
        Me.txtVentasUnidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.Location = New System.Drawing.Point(568, 16)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(124, 17)
        Me.Label51.TabIndex = 7
        Me.Label51.Text = "Ventas Generacion"
        '
        'txtVendedorVentasPersonales
        '
        Me.txtVendedorVentasPersonales.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVendedorVentasPersonales.Location = New System.Drawing.Point(141, 14)
        Me.txtVendedorVentasPersonales.Name = "txtVendedorVentasPersonales"
        Me.txtVendedorVentasPersonales.Size = New System.Drawing.Size(103, 22)
        Me.txtVendedorVentasPersonales.TabIndex = 5
        Me.txtVendedorVentasPersonales.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.Location = New System.Drawing.Point(11, 16)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(116, 17)
        Me.Label49.TabIndex = 0
        Me.Label49.Text = "Ventas Personales"
        '
        'TabPage9
        '
        Me.TabPage9.Location = New System.Drawing.Point(4, 27)
        Me.TabPage9.Name = "TabPage9"
        Me.TabPage9.Size = New System.Drawing.Size(1186, 519)
        Me.TabPage9.TabIndex = 3
        Me.TabPage9.Text = "Estadisticas"
        Me.TabPage9.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(400, 19)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(104, 28)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Buscar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'txtvendedor
        '
        Me.txtvendedor.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtvendedor.Location = New System.Drawing.Point(145, 21)
        Me.txtvendedor.Name = "txtvendedor"
        Me.txtvendedor.Size = New System.Drawing.Size(163, 27)
        Me.txtvendedor.TabIndex = 5
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(16, 24)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(119, 19)
        Me.Label18.TabIndex = 4
        Me.Label18.Text = "Codigo Vendedor"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.ServicioalCliente.My.Resources.Resources.linea
        Me.PictureBox3.Location = New System.Drawing.Point(20, 82)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(601, 16)
        Me.PictureBox3.TabIndex = 7
        Me.PictureBox3.TabStop = False
        '
        'TextBox14
        '
        Me.TextBox14.Location = New System.Drawing.Point(258, 335)
        Me.TextBox14.Multiline = True
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(549, 69)
        Me.TextBox14.TabIndex = 22
        '
        'ComboBox4
        '
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(633, 293)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(174, 21)
        Me.ComboBox4.TabIndex = 21
        Me.ComboBox4.Text = "Central"
        '
        'ComboBox5
        '
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Location = New System.Drawing.Point(444, 293)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(174, 21)
        Me.ComboBox5.TabIndex = 20
        Me.ComboBox5.Text = "San Jose "
        '
        'ComboBox6
        '
        Me.ComboBox6.FormattingEnabled = True
        Me.ComboBox6.Location = New System.Drawing.Point(259, 293)
        Me.ComboBox6.Name = "ComboBox6"
        Me.ComboBox6.Size = New System.Drawing.Size(174, 21)
        Me.ComboBox6.TabIndex = 18
        Me.ComboBox6.Text = "San Jose"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(118, 297)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(51, 13)
        Me.Label19.TabIndex = 17
        Me.Label19.Text = "Provincia"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(405, 448)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(176, 26)
        Me.Button5.TabIndex = 16
        Me.Button5.Text = "Actualizar Datos"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'TextBox18
        '
        Me.TextBox18.Location = New System.Drawing.Point(258, 247)
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New System.Drawing.Size(360, 20)
        Me.TextBox18.TabIndex = 13
        Me.TextBox18.Text = "dmartinez@mastercocina.net"
        '
        'TextBox26
        '
        Me.TextBox26.Location = New System.Drawing.Point(258, 197)
        Me.TextBox26.Name = "TextBox26"
        Me.TextBox26.Size = New System.Drawing.Size(175, 20)
        Me.TextBox26.TabIndex = 12
        Me.TextBox26.Text = "2231-1389"
        '
        'TextBox27
        '
        Me.TextBox27.Location = New System.Drawing.Point(258, 156)
        Me.TextBox27.Name = "TextBox27"
        Me.TextBox27.Size = New System.Drawing.Size(175, 20)
        Me.TextBox27.TabIndex = 11
        '
        'TextBox28
        '
        Me.TextBox28.Location = New System.Drawing.Point(439, 73)
        Me.TextBox28.Name = "TextBox28"
        Me.TextBox28.Size = New System.Drawing.Size(179, 20)
        Me.TextBox28.TabIndex = 10
        Me.TextBox28.Text = "Cedeño"
        '
        'TextBox29
        '
        Me.TextBox29.Location = New System.Drawing.Point(258, 114)
        Me.TextBox29.Name = "TextBox29"
        Me.TextBox29.Size = New System.Drawing.Size(175, 20)
        Me.TextBox29.TabIndex = 9
        Me.TextBox29.Text = "2231-1389"
        '
        'TextBox30
        '
        Me.TextBox30.Location = New System.Drawing.Point(258, 73)
        Me.TextBox30.Name = "TextBox30"
        Me.TextBox30.Size = New System.Drawing.Size(175, 20)
        Me.TextBox30.TabIndex = 8
        Me.TextBox30.Text = "Martinez"
        '
        'TextBox31
        '
        Me.TextBox31.Location = New System.Drawing.Point(258, 30)
        Me.TextBox31.Name = "TextBox31"
        Me.TextBox31.Size = New System.Drawing.Size(360, 20)
        Me.TextBox31.TabIndex = 7
        Me.TextBox31.Text = "Diego"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(118, 255)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(60, 13)
        Me.Label28.TabIndex = 6
        Me.Label28.Text = "Electronico"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(118, 237)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(38, 13)
        Me.Label35.TabIndex = 5
        Me.Label35.Text = "Correo"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(118, 205)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(24, 13)
        Me.Label36.TabIndex = 4
        Me.Label36.Text = "Fax"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(118, 122)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(103, 13)
        Me.Label37.TabIndex = 2
        Me.Label37.Text = "Telefono Habitacion"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(118, 81)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(49, 13)
        Me.Label38.TabIndex = 1
        Me.Label38.Text = "Apellidos"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(118, 164)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(84, 13)
        Me.Label39.TabIndex = 3
        Me.Label39.Text = "Telefono Celular"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(118, 38)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(44, 13)
        Me.Label40.TabIndex = 0
        Me.Label40.Text = "Nombre"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SistemaToolStripMenuItem, Me.HerramientasToolStripMenuItem, Me.InformesToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1246, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SistemaToolStripMenuItem
        '
        Me.SistemaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PerfilesToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.SistemaToolStripMenuItem.Name = "SistemaToolStripMenuItem"
        Me.SistemaToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.SistemaToolStripMenuItem.Text = "Sistema"
        '
        'PerfilesToolStripMenuItem
        '
        Me.PerfilesToolStripMenuItem.Name = "PerfilesToolStripMenuItem"
        Me.PerfilesToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.PerfilesToolStripMenuItem.Text = "Perfiles"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'HerramientasToolStripMenuItem
        '
        Me.HerramientasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SeguimientoPostVentaToolStripMenuItem, Me.SeguimientoVendedoresToolStripMenuItem, Me.EventosPublicitariosToolStripMenuItem, Me.CapacitacionesToolStripMenuItem, Me.EncuestasToolStripMenuItem, Me.ConcursosToolStripMenuItem})
        Me.HerramientasToolStripMenuItem.Name = "HerramientasToolStripMenuItem"
        Me.HerramientasToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.HerramientasToolStripMenuItem.Text = "Herramientas"
        '
        'SeguimientoPostVentaToolStripMenuItem
        '
        Me.SeguimientoPostVentaToolStripMenuItem.Name = "SeguimientoPostVentaToolStripMenuItem"
        Me.SeguimientoPostVentaToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.SeguimientoPostVentaToolStripMenuItem.Text = "Seguimiento Post Venta"
        '
        'SeguimientoVendedoresToolStripMenuItem
        '
        Me.SeguimientoVendedoresToolStripMenuItem.Name = "SeguimientoVendedoresToolStripMenuItem"
        Me.SeguimientoVendedoresToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.SeguimientoVendedoresToolStripMenuItem.Text = "Seguimiento Vendedores"
        '
        'EventosPublicitariosToolStripMenuItem
        '
        Me.EventosPublicitariosToolStripMenuItem.Name = "EventosPublicitariosToolStripMenuItem"
        Me.EventosPublicitariosToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.EventosPublicitariosToolStripMenuItem.Text = "Eventos Publicitarios"
        '
        'CapacitacionesToolStripMenuItem
        '
        Me.CapacitacionesToolStripMenuItem.Name = "CapacitacionesToolStripMenuItem"
        Me.CapacitacionesToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.CapacitacionesToolStripMenuItem.Text = "Capacitaciones"
        '
        'EncuestasToolStripMenuItem
        '
        Me.EncuestasToolStripMenuItem.Name = "EncuestasToolStripMenuItem"
        Me.EncuestasToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.EncuestasToolStripMenuItem.Text = "Encuestas"
        '
        'ConcursosToolStripMenuItem
        '
        Me.ConcursosToolStripMenuItem.Name = "ConcursosToolStripMenuItem"
        Me.ConcursosToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.ConcursosToolStripMenuItem.Text = "Concursos"
        '
        'InformesToolStripMenuItem
        '
        Me.InformesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.VendedoresToolStripMenuItem})
        Me.InformesToolStripMenuItem.Name = "InformesToolStripMenuItem"
        Me.InformesToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.InformesToolStripMenuItem.Text = "Informes"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'VendedoresToolStripMenuItem
        '
        Me.VendedoresToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VendedoresActivosInactivosToolStripMenuItem, Me.CategoriasDeEstudiosDeCreditoToolStripMenuItem, Me.CToolStripMenuItem, Me.NuevosEjecutivosDeVentasToolStripMenuItem})
        Me.VendedoresToolStripMenuItem.Name = "VendedoresToolStripMenuItem"
        Me.VendedoresToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.VendedoresToolStripMenuItem.Text = "Vendedores"
        '
        'VendedoresActivosInactivosToolStripMenuItem
        '
        Me.VendedoresActivosInactivosToolStripMenuItem.Name = "VendedoresActivosInactivosToolStripMenuItem"
        Me.VendedoresActivosInactivosToolStripMenuItem.Size = New System.Drawing.Size(251, 22)
        Me.VendedoresActivosInactivosToolStripMenuItem.Text = "Vendedores Activos Inactivos"
        '
        'CategoriasDeEstudiosDeCreditoToolStripMenuItem
        '
        Me.CategoriasDeEstudiosDeCreditoToolStripMenuItem.Name = "CategoriasDeEstudiosDeCreditoToolStripMenuItem"
        Me.CategoriasDeEstudiosDeCreditoToolStripMenuItem.Size = New System.Drawing.Size(251, 22)
        Me.CategoriasDeEstudiosDeCreditoToolStripMenuItem.Text = "Categorias de Estudios de Credito"
        '
        'CToolStripMenuItem
        '
        Me.CToolStripMenuItem.Name = "CToolStripMenuItem"
        Me.CToolStripMenuItem.Size = New System.Drawing.Size(251, 22)
        Me.CToolStripMenuItem.Text = "Nuevos Vendedores"
        '
        'NuevosEjecutivosDeVentasToolStripMenuItem
        '
        Me.NuevosEjecutivosDeVentasToolStripMenuItem.Name = "NuevosEjecutivosDeVentasToolStripMenuItem"
        Me.NuevosEjecutivosDeVentasToolStripMenuItem.Size = New System.Drawing.Size(251, 22)
        Me.NuevosEjecutivosDeVentasToolStripMenuItem.Text = "Nuevos Ejecutivos de Ventas"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tssLbCompania, Me.tsslbUbicacion, Me.tssLbUsuario, Me.tsslbDatabase})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 709)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1246, 24)
        Me.StatusStrip1.TabIndex = 44
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tssLbCompania
        '
        Me.tssLbCompania.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.tssLbCompania.Name = "tssLbCompania"
        Me.tssLbCompania.Size = New System.Drawing.Size(307, 19)
        Me.tssLbCompania.Spring = True
        Me.tssLbCompania.Text = "Master Cocina"
        Me.tssLbCompania.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tsslbUbicacion
        '
        Me.tsslbUbicacion.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.tsslbUbicacion.Name = "tsslbUbicacion"
        Me.tsslbUbicacion.Size = New System.Drawing.Size(307, 19)
        Me.tsslbUbicacion.Spring = True
        Me.tsslbUbicacion.Text = "Costa Rica"
        Me.tsslbUbicacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tssLbUsuario
        '
        Me.tssLbUsuario.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.tssLbUsuario.Name = "tssLbUsuario"
        Me.tssLbUsuario.Size = New System.Drawing.Size(307, 19)
        Me.tssLbUsuario.Spring = True
        Me.tssLbUsuario.Text = "Administrador"
        Me.tssLbUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tsslbDatabase
        '
        Me.tsslbDatabase.Name = "tsslbDatabase"
        Me.tsslbDatabase.Size = New System.Drawing.Size(307, 19)
        Me.tsslbDatabase.Spring = True
        Me.tsslbDatabase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1246, 733)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Text = "Servicio al Cliente"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TabControl1.ResumeLayout(False)
        Me.tabpage56.ResumeLayout(False)
        Me.tabpage56.PerformLayout()
        Me.TabControl5.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabControl4.ResumeLayout(False)
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        Me.TabPage11.ResumeLayout(False)
        Me.TabPage11.PerformLayout()
        Me.TabPage12.ResumeLayout(False)
        Me.TabPage12.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabpage57.ResumeLayout(False)
        Me.tabpage57.PerformLayout()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl3.ResumeLayout(False)
        Me.tabpage14.ResumeLayout(False)
        Me.tabpage14.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage7.ResumeLayout(False)
        Me.TabPage7.PerformLayout()
        Me.tapag45.ResumeLayout(False)
        Me.tapag45.PerformLayout()
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage10.ResumeLayout(False)
        Me.TabPage10.PerformLayout()
        Me.TabPage13.ResumeLayout(False)
        Me.TabPage8.ResumeLayout(False)
        Me.TabPage8.PerformLayout()
        CType(Me.ChartReclutamiento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartVentaEquipo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabpage56 As System.Windows.Forms.TabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tabpage57 As System.Windows.Forms.TabPage
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cmdBuscaCliente As System.Windows.Forms.Button
    Friend WithEvents txtCliente As System.Windows.Forms.TextBox
    Friend WithEvents TabControl5 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtHabitacion As System.Windows.Forms.TextBox
    Friend WithEvents txtapellido01 As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbCanton As System.Windows.Forms.ComboBox
    Friend WithEvents cmbProvincia As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents txtCorreo As System.Windows.Forms.TextBox
    Friend WithEvents txtFax As System.Windows.Forms.TextBox
    Friend WithEvents txtCelular As System.Windows.Forms.TextBox
    Friend WithEvents txtApellido02 As System.Windows.Forms.TextBox
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents cmbDistrito As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtFactura As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents txtvendedor As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents TabControl3 As System.Windows.Forms.TabControl
    Friend WithEvents tabpage14 As System.Windows.Forms.TabPage
    Friend WithEvents txtdireccionvendedor As System.Windows.Forms.TextBox
    Friend WithEvents cmbdistritovendedor As System.Windows.Forms.ComboBox
    Friend WithEvents cmbcantonvendedor As System.Windows.Forms.ComboBox
    Friend WithEvents cmbprovinciavendedor As System.Windows.Forms.ComboBox
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents txtcorreovendedor As System.Windows.Forms.TextBox
    Friend WithEvents txtfaxvendedor As System.Windows.Forms.TextBox
    Friend WithEvents txtcelularvendedor As System.Windows.Forms.TextBox
    Friend WithEvents txtapellido02vendedor As System.Windows.Forms.TextBox
    Friend WithEvents txthabitacionvendedor As System.Windows.Forms.TextBox
    Friend WithEvents txtapellido01vendedor As System.Windows.Forms.TextBox
    Friend WithEvents txtNombreVendedor As System.Windows.Forms.TextBox
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents TabPage7 As System.Windows.Forms.TabPage
    Friend WithEvents tapag45 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage9 As System.Windows.Forms.TabPage
    Friend WithEvents TextBox14 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox5 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox6 As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents TextBox18 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox26 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox27 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox28 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox29 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox30 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox31 As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents lvTreeReclutas As System.Windows.Forms.TreeView
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents txtVendedorVentasPersonales As System.Windows.Forms.TextBox
    Friend WithEvents txtReclutasActivosIndirectos As System.Windows.Forms.TextBox
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents txtReclutasActivosDirectos As System.Windows.Forms.TextBox
    Friend WithEvents txtVentasUnidad As System.Windows.Forms.TextBox
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents txtBoletaGarantia As System.Windows.Forms.TextBox
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents txtEstadoGarantia As System.Windows.Forms.TextBox
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents txtFechaIngresoGarantia As System.Windows.Forms.TextBox
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents lvArticulosGarantia As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader32 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader33 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents txtGarantiaAplicada As System.Windows.Forms.TextBox
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents ListView9 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader34 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents txtComentarioGarantia As System.Windows.Forms.TextBox
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents lbNombre As System.Windows.Forms.Label
    Friend WithEvents lbVendedor As System.Windows.Forms.Label
    Friend WithEvents Label64 As System.Windows.Forms.Label
    Friend WithEvents cmdMostrarDatos As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader35 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader36 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader37 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmdConsultarVendedor As System.Windows.Forms.Button
    Friend WithEvents cmdMostrarCliente As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents txtVentasPersonalesProceso As System.Windows.Forms.TextBox
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents lvFacturasVendedor As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader26 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader27 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader28 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader38 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader29 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader30 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader31 As System.Windows.Forms.ColumnHeader
    Friend WithEvents TabPage10 As System.Windows.Forms.TabPage
    Friend WithEvents Label65 As System.Windows.Forms.Label
    Friend WithEvents Label63 As System.Windows.Forms.Label
    Friend WithEvents lvVentasRecluta As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader20 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader21 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader22 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvVendedoresUnidad As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cmbCierre As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TabControl4 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents txtTipo As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txtMontoTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtFechaVencimiento As System.Windows.Forms.TextBox
    Friend WithEvents txtFecha As System.Windows.Forms.TextBox
    Friend WithEvents txtPlazo As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TabPage11 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage12 As System.Windows.Forms.TabPage
    Friend WithEvents txtMontoCancelado As System.Windows.Forms.TextBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents txtSaldoActual As System.Windows.Forms.TextBox
    Friend WithEvents lvPagos As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtCuotasCanceladas As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lvEstadoDespacho As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtSaldoDespacho As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtInspector As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtFechaEstudio As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader39 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader40 As System.Windows.Forms.ColumnHeader
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents SistemaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InformesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VendedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VendedoresActivosInactivosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CategoriasDeEstudiosDeCreditoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lbNivel As System.Windows.Forms.Label
    Friend WithEvents CToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevosEjecutivosDeVentasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HerramientasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SeguimientoPostVentaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SeguimientoVendedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents txtTelefonoConyuge As System.Windows.Forms.TextBox
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents txtNombreConyuge As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txtEstadoCivil As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtTelefonoReferencia02 As System.Windows.Forms.TextBox
    Friend WithEvents txtSector02 As System.Windows.Forms.TextBox
    Friend WithEvents txtNombreReferencia02 As System.Windows.Forms.TextBox
    Friend WithEvents Label69 As System.Windows.Forms.Label
    Friend WithEvents Label68 As System.Windows.Forms.Label
    Friend WithEvents Label67 As System.Windows.Forms.Label
    Friend WithEvents txtTelefonoReferencia01 As System.Windows.Forms.TextBox
    Friend WithEvents txtSector01 As System.Windows.Forms.TextBox
    Friend WithEvents txtNombreReferencia01 As System.Windows.Forms.TextBox
    Friend WithEvents Label66 As System.Windows.Forms.Label
    Friend WithEvents lvReferencias As System.Windows.Forms.ListView
    Friend WithEvents Label70 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader41 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader42 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader43 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader44 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtCorreoOrganizacion As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefono03Organizacion As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefono02Organizacion As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefono01Organizacion As System.Windows.Forms.TextBox
    Friend WithEvents Label75 As System.Windows.Forms.Label
    Friend WithEvents Label74 As System.Windows.Forms.Label
    Friend WithEvents Label73 As System.Windows.Forms.Label
    Friend WithEvents Label72 As System.Windows.Forms.Label
    Friend WithEvents txtDistribuidorOrganizacion As System.Windows.Forms.TextBox
    Friend WithEvents Label71 As System.Windows.Forms.Label
    Friend WithEvents txtContratoOrganizacion As System.Windows.Forms.TextBox
    Friend WithEvents Label76 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents tssLbCompania As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tsslbUbicacion As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tssLbUsuario As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tsslbDatabase As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Label77 As System.Windows.Forms.Label
    Friend WithEvents dtFechaNacCliente As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label78 As System.Windows.Forms.Label
    Friend WithEvents dtFechaNacVendedor As System.Windows.Forms.DateTimePicker
    Friend WithEvents TabPage13 As System.Windows.Forms.TabPage
    Friend WithEvents lvEstadoReclutamiento As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader19 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader23 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader24 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader25 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader45 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader46 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader47 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader48 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader49 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader50 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader51 As System.Windows.Forms.ColumnHeader
    Friend WithEvents TabPage8 As System.Windows.Forms.TabPage
    Friend WithEvents ChartVentaEquipo As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Label80 As System.Windows.Forms.Label
    Friend WithEvents txtIndirectosVenta As System.Windows.Forms.TextBox
    Friend WithEvents Label79 As System.Windows.Forms.Label
    Friend WithEvents txtDirectosConVenta As System.Windows.Forms.TextBox
    Friend WithEvents txtNuevosDirectos As System.Windows.Forms.TextBox
    Friend WithEvents Label82 As System.Windows.Forms.Label
    Friend WithEvents txtNuevosReclutas As System.Windows.Forms.TextBox
    Friend WithEvents Label81 As System.Windows.Forms.Label
    Friend WithEvents lbVentasProvincia As System.Windows.Forms.Label
    Friend WithEvents lbEstadoReclutamiento As System.Windows.Forms.Label
    Friend WithEvents ChartReclutamiento As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents EventosPublicitariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lvArticulos As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader16 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader17 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader18 As System.Windows.Forms.ColumnHeader
    Friend WithEvents CapacitacionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox9 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox10 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox14 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox13 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox12 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox11 As System.Windows.Forms.PictureBox
    Friend WithEvents EncuestasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PerfilesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtDiasIngreso As System.Windows.Forms.TextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents ConcursosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button

End Class
