Imports System.Data.SqlClient
Imports System.Threading
Imports System.Windows.Forms.DataVisualization.Charting

Imports CompensationPlan
Imports InvoicingLib
Imports InvoicingLib.Common
Imports System.Linq
Imports CustomerPortfolioLib
Imports CustomerPortfolioLib.WindowsView
Imports ServicioalCliente.Services
Imports ServicioalCliente.Config
Public Class frmMain
    Private trd As Thread
    Private LoadCliente As Boolean = False
    Private LoadVendedor As Boolean = False
    Private LoadRef As Boolean = False
    Private LoadOrganizacion As Boolean = False
    Private loadventas As Boolean = False
    Private PlanMercadeo As Integer
    Private NivelVendedor As Integer
    Public CierreActual As Integer
    Private WithEvents frmBuscaVendedor As frmBuscaVendedor = Nothing
    Private WithEvents frmBuscaCliente As frmCustomersSearch = Nothing
    Private ImgDescenso As List(Of PictureBox) = New List(Of PictureBox)
    Private ImgAscenso As List(Of PictureBox) = New List(Of PictureBox)
    Private CurrentSalesMan As SalesForceLib.SalesMan = Nothing
    Private CurrentCustomer As CustomerPortfolioLib.Customer
#Region "Eventos"

    Private Sub txtCliente_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCliente.KeyDown
        If e.KeyCode = Keys.F2 Then
            frmBuscaCliente.Show()
        End If
    End Sub
    Private Sub txtCliente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCliente.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            Me.cmdMostrarCliente_Click(sender, Nothing)
        End If
    End Sub
#End Region
    Private Sub txtCliente_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCliente.TextChanged
        On Error Resume Next
        Me.txtNombre.Text = ""
        Me.lbNombre.Text = ""
        Me.txtapellido01.Text = ""
        Me.txtApellido02.Text = ""
        Me.txtHabitacion.Text = ""
        Me.txtCelular.Text = ""
        Me.txtFax.Text = ""
        Me.cmbProvincia.SelectedIndex = 0
        Me.lvReferencias.Items.Clear()
        'Me.cmbCanton.SelectedValue = Nothing
        'Me.cmbDistrito.SelectedValue = Nothing
        Me.txtCorreo.Text = ""
        Me.txtDireccion.Text = ""
        LoadCliente = False
    End Sub
    Private Sub frmMain_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        End
    End Sub
    Public Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim cmd As SqlCommand
        Dim ds As DataSet
        Dim da As SqlDataAdapter
        Dim reader As SqlDataReader

        CheckForIllegalCrossThreadCalls = False

        Dim service = DependencyInjector.Retrieve(Of CompanyParametersService)
        Try
            Dim parameter = service.getParameters()

            Pais = parameter.Country
        Catch ex As Exception
            MessageBox.Show("No se pudo obtener los parametros de la compañia")
        End Try




        'Accesos de la pestañña clientes
        cmdBuscaCliente.Visible = currentaccesos.Clientes.BuscarCliente
        Button4.Visible = currentaccesos.Clientes.ActualizarDatos

        If Not currentaccesos.Clientes.InformacionGeneral Then TabPage3.Parent = Nothing
        If Not currentaccesos.Clientes.Facturacion Then TabPage4.Parent = Nothing
        If Not currentaccesos.Clientes.Garantias Then TabPage5.Parent = Nothing

        'Accesso de la pestañña vendedores
        Me.Label15.Visible = currentaccesos.Vendedores.HistoricoCierres
        Me.cmbCierre.Visible = currentaccesos.Vendedores.HistoricoCierres

        Me.Label31.Visible = currentaccesos.Vendedores.NiveldelVendedor

        Button6.Visible = currentaccesos.Vendedores.ActualizarDatos

        If Not currentaccesos.Vendedores.InformacionPersonal Then tabpage14.Parent = Nothing
        If Not currentaccesos.Vendedores.Referencia Then TabPage1.Parent = Nothing
        If Not currentaccesos.Vendedores.Organizacion Then TabPage7.Parent = Nothing

        If currentaccesos.Vendedores.Ventas Is Nothing Then tapag45.Parent = Nothing

        If Not currentaccesos.Vendedores.Ventas Is Nothing Then
            If Not currentaccesos.Vendedores.Ventas.Resumen Then
                Me.Label49.Visible = False
                Me.Label62.Visible = False
                Me.Label81.Visible = False
                Me.Label82.Visible = False
                Me.txtVendedorVentasPersonales.Visible = False
                Me.txtVentasPersonalesProceso.Visible = False
                Me.txtNuevosReclutas.Visible = False
                Me.txtNuevosDirectos.Visible = False
                Me.Label52.Visible = False
                Me.Label14.Visible = False
                Me.Label79.Visible = False
                Me.Label80.Visible = False
                Me.txtReclutasActivosDirectos.Visible = False
                Me.txtReclutasActivosIndirectos.Visible = False
                Me.txtDirectosConVenta.Visible = False
                Me.txtIndirectosVenta.Visible = False
                Me.Label51.Visible = False
                Me.txtVentasUnidad.Visible = False
            End If

            If Not currentaccesos.Vendedores.Ventas.GraficoProvincias Then TabPage9.Parent = Nothing
            If Not currentaccesos.Vendedores.Ventas.EstadoReclutamiento Then TabPage13.Parent = Nothing
            If Not currentaccesos.Vendedores.Ventas.VentasPersonales Then TabPage2.Parent = Nothing
            If Not currentaccesos.Vendedores.Ventas.VentasUnidad Then TabPage10.Parent = Nothing
            If Not currentaccesos.Vendedores.Ventas.DetalleVentasUnidad Then
                Me.Label65.Visible = False
                Me.lvVentasRecluta.Visible = False
            End If
        End If




        ImgDescenso.Add(PictureBox5)
        ImgDescenso.Add(PictureBox6)
        ImgDescenso.Add(PictureBox7)
        ImgDescenso.Add(PictureBox8)
        ImgDescenso.Add(PictureBox9)

        ImgAscenso.Add(PictureBox10)
        ImgAscenso.Add(PictureBox11)
        ImgAscenso.Add(PictureBox12)
        ImgAscenso.Add(PictureBox13)
        ImgAscenso.Add(PictureBox14)

        For Each pct As PictureBox In ImgDescenso
            pct.Visible = False
        Next
        For Each pct As PictureBox In ImgAscenso
            pct.Visible = False
        Next

        For Each p As TerritorialDivisionLib.Province In New TerritorialDivisionLib.Provinces
            Me.cmbProvincia.Items.Add(p)
            Me.cmbprovinciavendedor.Items.Add(p)
        Next
        Try
            cmd = New SqlCommand("GetCierre", db)
            cmd.CommandType = CommandType.StoredProcedure
            da = New SqlDataAdapter
            da.SelectCommand = cmd
            ds = New DataSet
            da.Fill(ds)
            Me.cmbCierre.DataSource = ds.Tables(0)
            Me.cmbCierre.DisplayMember = ds.Tables(0).Columns(1).Caption
            Me.cmbCierre.ValueMember = ds.Tables(0).Columns(0).Caption
        Catch ex As SqlException
            MessageBox.Show(ex.Message, "Servicioalcliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Try
            cmd = New SqlCommand("Select moneda,moneda_local,nombre_compania_propiedad " &
                                 "from parametros_Default", db)
            cmd.CommandType = CommandType.Text
            reader = cmd.ExecuteReader
            If reader.Read Then
                Me.tssLbCompania.Text = reader.Item("nombre_compania_propiedad").ToString
            End If
            reader.Close()
        Catch ex As Exception
            reader = Nothing
        End Try

        Me.tsslbUbicacion.Text = Variables.Ubicacion
        Me.tssLbUsuario.Text = Variables.Usuario
        Me.tsslbDatabase.Text = Variables.DataBase


    End Sub
    Private Sub cmbProvincia_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbProvincia.SelectedValueChanged
        Me.cmbCanton.Items.Clear()
        If Me.cmbProvincia.SelectedItem Is Nothing Then Exit Sub

        For Each c As TerritorialDivisionLib.Canton In CType(Me.cmbProvincia.SelectedItem, TerritorialDivisionLib.Province).Cantons
            Me.cmbCanton.Items.Add(c)
        Next
    End Sub
    Private Sub cmbCanton_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCanton.SelectedValueChanged
        Me.cmbDistrito.Items.Clear()
        If Me.cmbCanton.SelectedItem Is Nothing Then Exit Sub

        Dim c As TerritorialDivisionLib.Canton = Me.cmbCanton.SelectedItem

        For Each d As TerritorialDivisionLib.District In c.Districts
            Me.cmbDistrito.Items.Add(d)
        Next

    End Sub

    Private Sub txtFactura_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFactura.KeyDown
        If e.KeyCode = Keys.F2 Then
            If Me.txtCliente.Text = "" Then
                MessageBox.Show("Debe Seleccionar un Cliente", "Servicioalcliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            frmBuscarOrden.cliente = Me.txtCliente.Text
            frmBuscarOrden.Show()
        End If
    End Sub
    Public Sub txtFactura_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFactura.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            Me.Button1_Click(sender, Nothing)
        End If
    End Sub
    Private Sub txtFactura_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFactura.TextChanged
        Me.txtTipo.Text = ""
        Me.txtFecha.Text = ""
        Me.txtFechaVencimiento.Text = ""
        Me.txtPlazo.Text = ""
        Me.txtMontoTotal.Text = ""
        Me.txtCuotasCanceladas.Text = ""
        Me.txtSaldoActual.Text = ""
        Me.txtMontoCancelado.Text = ""
        Me.txtSaldoDespacho.Text = ""
        Me.lvArticulos.Items.Clear()
        Me.lvPagos.Items.Clear()
        Me.lvEstadoDespacho.Items.Clear()
    End Sub
    Public Sub cmdMostrarDatos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMostrarDatos.Click
        Dim wa As LayerWarranty.Warranty
        Dim item As System.Windows.Forms.ListViewItem
        Dim i As Integer

        If Me.txtBoletaGarantia.Text = "" Then
            MessageBox.Show("Debe Ingresar el numero de  Boleta de Garantia", "Servicioalcliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        wa = New LayerWarranty.Warranty(db)
        wa.LoadByWarranty(Me.txtBoletaGarantia.Text)
        If wa.Count > 0 Then
            If Me.txtCliente.Text = wa.Cliente Then
                Me.txtBoletaGarantia.Text = wa.Boleta
                Me.txtFechaIngresoGarantia.Text = wa.Fecha.Date
                Me.txtFechaEstudio.Text = wa.FechaEstudio.Date
                Me.txtInspector.Text = wa.Inspector
                Select Case wa.Estado
                    Case 0 : Me.txtEstadoGarantia.Text = "Estudio no Realizado"
                    Case 1 : Me.txtEstadoGarantia.Text = "Estudio Aplicado"
                End Select
                If wa.Articulos.Count > 0 Then
                    For i = 1 To wa.Articulos.Count
                        item = New System.Windows.Forms.ListViewItem(wa.Articulos.Articulo(i))
                        item.SubItems.Add(wa.Articulos.Descripcion(i))
                        item.SubItems.Add(wa.Articulos.Linea(i))
                        item.SubItems.Add(wa.Articulos.TipoGarantia(i))
                        item.SubItems.Add(wa.Articulos.Comentarios(i))
                        Me.lvArticulosGarantia.Items.Add(item)
                    Next i
                End If
            Else
                MessageBox.Show("Esta boleta de garantia no fue ingresada a este cliente", "ServicioalCliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("No se encuentra este numero de boleta de Garantia", "Servicioalcliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub
    Private Sub txtBoletaGarantia_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBoletaGarantia.KeyDown
        If e.KeyCode = Keys.F2 Then
            Button7_Click(Nothing, Nothing)
        End If
    End Sub
    Private Sub txtBoletaGarantia_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBoletaGarantia.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            cmdMostrarDatos_Click(sender, Nothing)
        End If
    End Sub
    Private Sub txtBoletaGarantia_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBoletaGarantia.TextChanged
        Me.txtFechaIngresoGarantia.Text = ""
        Me.txtEstadoGarantia.Text = ""
        Me.lvArticulosGarantia.Items.Clear()
        Me.txtGarantiaAplicada.Text = ""
        Me.txtComentarioGarantia.Text = ""
    End Sub
    Private Sub lvArticulosGarantia_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvArticulosGarantia.Click
        If Me.lvArticulosGarantia.SelectedItems.Count > 0 Then
            Select Case Me.lvArticulosGarantia.SelectedItems(0).SubItems(3).Text
                Case 0 : Me.txtGarantiaAplicada.Text = "No cambio"
                Case 1 : Me.txtGarantiaAplicada.Text = "100%"
                Case 2 : Me.txtGarantiaAplicada.Text = "40%"
                Case 3 : Me.txtGarantiaAplicada.Text = "50%"
            End Select
            Me.txtComentarioGarantia.Text = Me.lvArticulosGarantia.SelectedItems(0).SubItems(4).Text
        End If
    End Sub
    Public Sub cmdConsultarVendedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConsultarVendedor.Click
        Dim FechaCierre As String = ""

        Try
            Me.Cursor = Cursors.WaitCursor   'Curso de espera
            Dim force As New SalesForceLib.SalesForce


            CurrentSalesMan = force(Me.txtvendedor.Text)
            If Not CurrentSalesMan Is Nothing Then
                With CurrentSalesMan
                    Me.txtNombreVendedor.Text = .FirstName
                    Me.txtapellido01vendedor.Text = .LastName01
                    Me.txtapellido02vendedor.Text = .LastName02
                    Me.lbVendedor.Text = .FullName
                    Me.txthabitacionvendedor.Text = .PhoneNumber01
                    Me.txtcelularvendedor.Text = .PhoneNumber02
                    Me.txtfaxvendedor.Text = .FaxNumber
                    Me.txtcorreovendedor.Text = .Email
                    Dim difference As TimeSpan = DateTime.Now.Subtract(.DateOfAdmission)
                    Me.txtDiasIngreso.Text = Math.Truncate(difference.TotalDays).ToString()

                    Me.cmbprovinciavendedor.SelectedItem = .Location.Province
                    Me.cmbcantonvendedor.SelectedItem = .Location.Canton
                    Me.cmbdistritovendedor.SelectedItem = .Location.District
                    Me.txtdireccionvendedor.Text = .Location.SpecificAdress
                    Me.dtFechaNacVendedor.Text = .DateOfBirth
                    PlanMercadeo = .CompensationPlanID
                    NivelVendedor = .LevelID
                    Me.lbNivel.Text = .CompensationPlanLevel.Description
                    LoadVendedor = True
                End With


                If TabControl3.SelectedIndex = 1 Then
                    If LoadVendedor Then
                        LoadReferencias()
                    End If
                End If
                If TabControl3.SelectedIndex = 2 Then
                    CrearArbolOrganizacion()
                End If
                If TabControl3.SelectedIndex = 3 Then
                    CargarInformacionVentas(Convert.ToInt32(Me.cmbCierre.SelectedValue))
                End If

            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MessageBox.Show(ex.Message, "ServicioalCliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub CrearTree(ByRef n As TreeNode, ByVal s As SalesForceLib.SalesMan)
        Dim specs As New SalesForceLib.SalesStaffSearchSpecs() With {.Generation = 1}
        Dim staff As New SalesForceLib.SalesStaff(s, specs)

        For Each r As SalesForceLib.Recruits In staff
            Dim nodo As New TreeNode(r.Recruit.FullName)
            nodo.Tag = r.Recruit
            n.Nodes.Add(nodo)
            CrearTree(nodo, r.Recruit)
        Next
    End Sub
    Private Sub cmbprovinciavendedor_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbprovinciavendedor.SelectedValueChanged

        Me.cmbcantonvendedor.Items.Clear()
        If Me.cmbprovinciavendedor.SelectedItem Is Nothing Then Exit Sub

        For Each c As TerritorialDivisionLib.Canton In CType(Me.cmbprovinciavendedor.SelectedItem, TerritorialDivisionLib.Province).Cantons
            Me.cmbcantonvendedor.Items.Add(c)
        Next
    End Sub
    Private Sub cmbcantonvendedor_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbcantonvendedor.SelectedValueChanged
        Me.cmbdistritovendedor.Items.Clear()
        If Me.cmbcantonvendedor.SelectedItem Is Nothing Then Exit Sub

        Dim c As TerritorialDivisionLib.Canton = Me.cmbcantonvendedor.SelectedItem

        For Each d As TerritorialDivisionLib.District In c.Districts
            Me.cmbdistritovendedor.Items.Add(d)
        Next
    End Sub

    Private Sub txtvendedor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtvendedor.KeyDown
        If e.KeyCode = Keys.F2 Then
            Button3_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub txtvendedor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtvendedor.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            cmdConsultarVendedor_Click(sender, Nothing)
        End If
    End Sub
    Private Sub txtvendedor_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtvendedor.TextChanged
        LoadVendedor = False
        LoadRef = False
        LoadOrganizacion = False
        loadventas = False
        CurrentSalesMan = Nothing
        PlanMercadeo = 0
        NivelVendedor = 0
        Me.txtNombreVendedor.Text = ""
        Me.txtapellido01vendedor.Text = ""
        Me.txtapellido02vendedor.Text = ""
        Me.txthabitacionvendedor.Text = ""
        Me.txtcelularvendedor.Text = ""
        Me.txtfaxvendedor.Text = ""
        Me.txtcorreovendedor.Text = ""
        Me.txtdireccionvendedor.Text = ""
        Me.lvTreeReclutas.Nodes.Clear()
        Me.lbVendedor.Text = ""
        Me.txtVendedorVentasPersonales.Text = ""
        Me.txtVentasPersonalesProceso.Text = ""
        Me.txtVentasUnidad.Text = ""
        Me.txtReclutasActivosDirectos.Text = ""
        Me.lvFacturasVendedor.Items.Clear()
        Me.lvVendedoresUnidad.Items.Clear()
        Me.lvVentasRecluta.Items.Clear()
        Me.lbNivel.Text = ""

        For Each pct As PictureBox In ImgDescenso
            pct.Visible = False
        Next
        For Each pct As PictureBox In ImgAscenso
            pct.Visible = False
        Next
    End Sub
    Private Sub lvTreeReclutas_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles lvTreeReclutas.AfterSelect
        Me.txtDistribuidorOrganizacion.Text = ""
        Me.txtTelefono01Organizacion.Text = ""
        Me.txtTelefono02Organizacion.Text = ""
        Me.txtTelefono03Organizacion.Text = ""
        Me.txtCorreoOrganizacion.Text = ""
        Me.txtContratoOrganizacion.Text = ""

        If Me.lvTreeReclutas.SelectedNode Is Nothing Then Exit Sub

        Dim s As SalesForceLib.SalesMan = Me.lvTreeReclutas.SelectedNode.Tag

        With s
            Me.txtDistribuidorOrganizacion.Text = .FullName
            Me.txtTelefono01Organizacion.Text = .PhoneNumber01
            Me.txtTelefono02Organizacion.Text = .PhoneNumber02
            Me.txtTelefono03Organizacion.Text = .FaxNumber
            Me.txtContratoOrganizacion.Text = .ContractNumber
            Me.txtCorreoOrganizacion.Text = .Email
        End With
    End Sub
    Private Sub LoadInfoCliente(c1 As Customer)

        Me.txtCliente.Text = c1.Id
        Me.txtNombre.Text = c1.FirstName
        Me.lbNombre.Text = c1.FullName
        Me.txtapellido01.Text = c1.LastName01
        Me.txtApellido02.Text = c1.LastName02
        Me.txtHabitacion.Text = c1.HomePhoneNumber
        Me.txtCelular.Text = c1.CellPhoneNumber
        Me.txtFax.Text = c1.FaxNumber
        Me.txtCorreo.Text = c1.Email
        Me.cmbProvincia.SelectedItem = c1.Location.Province
        Me.cmbCanton.SelectedItem = c1.Location.Canton
        Me.cmbDistrito.SelectedItem = c1.Location.District
        Me.txtDireccion.Text = c1.Location.SpecificAdress
        If (c1.DateOFBirth.HasValue()) Then
            Me.dtFechaNacCliente.Text = c1.DateOFBirth.Value().ToShortDateString
        Else
            Me.dtFechaNacCliente.Text = ""
        End If

        LoadCliente = True
    End Sub
    Public Sub cmdMostrarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMostrarCliente.Click
        If Me.txtCliente.Text = "" Then
            MessageBox.Show("Debe Ingresar el codigo del cliente", "Servicioalcliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Try
            CurrentCustomer = CustomerPortfolioLib.CustomerPortfolio.Item(Me.txtCliente.Text)

            If Not CurrentCustomer Is Nothing Then
                LoadInfoCliente(CurrentCustomer)
            Else
                MessageBox.Show("Este cliente no se encuentra", "Servicio al cliente", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show("No se pudo completar la operacion " + ex.Message, "ServicioalCliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Not LoadCliente Then
            MessageBox.Show("Debe Seleccionar un Cliente", "ServicioalCliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Me.Cursor = Cursors.WaitCursor
        frmBuscarOrden.cliente = Me.txtCliente.Text
        frmBuscarOrden.tipo = 1
        frmBuscarOrden.CargarOrdenes()
        frmBuscarOrden.Show()
        Me.Cursor = Cursors.Default
    End Sub
    Public Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim env As LayerShipping.Shipping = Nothing
        Dim i As Integer
        Dim lvItem As System.Windows.Forms.ListViewItem

        If Not LoadCliente Then
            MessageBox.Show("Debe Ingresar un cliente valido", "ServicioalCliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Me.txtFactura.Text = "" Then
            MessageBox.Show("Debe Ingresar el numero de orden de pedido", "ServicioalCliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If


        Dim book As New InvoicingLib.InvoiceBook
        Dim fact As InvoicingLib.Invoice = book(Me.txtFactura.Text)

        If Not fact Is Nothing Then
            If fact.Customer.Id <> Me.txtCliente.Text Then
                MessageBox.Show("Esta orden de Pedido no pertene al cliente indicado", "ServicioalCliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Me.txtFecha.Text = fact.Date
            Me.txtFechaVencimiento.Text = fact.ExpirationDate
            Me.txtPlazo.Text = fact.TimeLimit
            Me.txtMontoTotal.Text = fact.TotalAmount + fact.TransportationAmount
            'Me.txtCuotasCanceladas.Text = ord.CuotasCanceladas
            Me.txtSaldoActual.Text = fact.Balance
            Me.txtMontoCancelado.Text = fact.Payments.TotalCanceled()

            'Me.txtSaldoDespacho.Text = ord.MontoDespacho
            Me.txtTipo.Text = fact.Type.Description

            Me.lvArticulos.Items.Clear()
            For Each de As LineDetails In fact.Details
                lvItem = New System.Windows.Forms.ListViewItem()
                lvItem.SubItems.Add(de.Item)
                lvItem.SubItems.Add(de.Quantity)
                lvItem.SubItems.Add(de.TotalAmount)
                Me.lvArticulos.Items.Add(lvItem)
            Next

            Me.lvPagos.Items.Clear()
            For Each p As InvoicePayment In fact.Payments
                lvItem = New System.Windows.Forms.ListViewItem(p.PaymentDate.ToShortDateString)
                lvItem.SubItems.Add("")
                lvItem.SubItems.Add("")
                lvItem.SubItems.Add("")
                lvItem.SubItems.Add(p.Amortization)
                lvItem.Group = Me.lvPagos.Groups(0)
                Me.lvPagos.Items.Add(lvItem)
            Next
        End If

        'If ord.EstadoDespacho = 0 Then
        ' lvItem = New System.Windows.Forms.ListViewItem("No Despachado")
        ' Me.lvEstadoDespacho.Items.Add(lvItem)
        ' Else
        '     lvItem = New System.Windows.Forms.ListViewItem("Despachado")
        '     lvItem.SubItems.Add(ord.FechaDespacho)
        '     lvItem.SubItems.Add(ord.DescripcionDespacho)
        '     Me.lvEstadoDespacho.Items.Add(lvItem)
        ' End If
        '
        '            If ord.EstadoEntrega = 0 Then
        '            lvItem = New System.Windows.Forms.ListViewItem("No Enviado")
        '            Me.lvEstadoDespacho.Items.Add(lvItem)
        '        Else
        '            lvItem = New System.Windows.Forms.ListViewItem("Enviado")
        '            env = New LayerShipping.Shipping(Me.txtFactura.Text)
        '            env.SetConnection(db)
        '            env.Load()
        '            If env.Count > 0 Then
        '           lvItem.SubItems.Add(env.Fecha)
        '           lvItem.SubItems.Add(env.Transporte + "-" + env.Sucursal)
        '       End If
        '           Me.lvEstadoDespacho.Items.Add(lvItem)
        '       End If
        '       End If

        'Catch ex As Exception
        'MessageBox.Show("error")
        'End Try
    End Sub
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If Not LoadCliente Then
            MessageBox.Show("Debe Seleccionar un Cliente", "ServicioalCliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Me.Cursor = Cursors.WaitCursor
        frmBuscaGarantia.CargarGarantias(Me.txtCliente.Text)
        frmBuscaGarantia.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub lvVendedoresUnidad_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvVendedoresUnidad.Click

        Dim item As ListViewItem


        Me.lvVentasRecluta.Items.Clear()
        If Me.lvVendedoresUnidad.SelectedItems.Count > 0 Then
            Dim specs As New InvoicingLib.InvoiceSearchSpecs
            specs.SalesMan = Me.lvVendedoresUnidad.SelectedItems(0).Tag
            specs.Period = CierreActual
            specs.StatusNotIs = InvoicingLib.Common.InvoiceStatus.Canceled

            For Each fact As InvoicingLib.Invoice In New InvoiceBook(specs)
                item = New ListViewItem(fact.Number)
                item.SubItems.Add(fact.Date)
                item.SubItems.Add(fact.TimeLimit)
                item.SubItems.Add(fact.Line1)
                item.SubItems.Add(fact.MonthlyFee)
                item.SubItems.Add(fact.Payments.TotalCanceled)
                item.Group = Me.lvVentasRecluta.Groups(0)
                Me.lvVentasRecluta.Items.Add(item)
            Next

            specs.Clear()
            specs.SalesMan = Me.lvVendedoresUnidad.SelectedItems(0).Tag
            specs.Period = 0
            specs.StatusNotIs = InvoicingLib.Common.InvoiceStatus.Canceled
            For Each fact As InvoicingLib.Invoice In New InvoiceBook(specs)
                item = New ListViewItem(fact.Number)
                item.SubItems.Add(fact.Date)
                item.SubItems.Add(fact.TimeLimit)
                item.SubItems.Add(fact.Line1)
                item.SubItems.Add(fact.MonthlyFee)
                item.SubItems.Add(fact.Payments.TotalCanceled)
                item.Group = Me.lvVentasRecluta.Groups(0)
                Me.lvVentasRecluta.Items.Add(item)
            Next
        End If
    End Sub
    Private Sub lvVendedoresUnidad_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvVendedoresUnidad.SelectedIndexChanged
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.frmBuscaVendedor = New frmBuscaVendedor
        Me.frmBuscaVendedor.Show()
    End Sub
    Private Sub frmBuscaVendedor_VendedorSelected(IDVendedor As String, Nombre As String) Handles frmBuscaVendedor.VendedorSelected
        If IDVendedor <> "" Then
            Me.txtvendedor.Text = IDVendedor
            cmdConsultarVendedor_Click(Nothing, Nothing)
        End If
    End Sub
    Private Sub CargarInformacionVentas(ByVal cierre As Integer)
        Dim venta As Double, VentaVendedor As Double, VentaProceso As Double
        Dim ActivosDirectos As Integer, activosindirectos As Integer

        Dim FechaCierre As Date

        If Not LoadVendedor Then Exit Sub
        Me.PictureBox2.Visible = True
        My.Application.DoEvents()

        Dim cls As ClosuresSalesLib.Closures = New ClosuresSalesLib.Closures(db)
        If Not cls.Last Is Nothing Then
            FechaCierre = cls.Last.FechaInicio
        Else
            Exit Sub
        End If
        'obtiene la informacion del plan de mercadeo
        'Dim plan As MarketingPlan = New MarketingPlan(PlanMercadeo)

        'For Each uko As UpkeepOption In plan.Levels(NivelVendedor).UpkeepOptions
        'CierreActual = cierre

        '
        Dim group0 As ListViewGroup = New ListViewGroup("0", "Sin Ventas")
        Dim item As ListViewItem

        Me.lvFacturasVendedor.Items.Clear()
        Dim VentasPersonales As Decimal
        Dim VentasPeriodo As Decimal

        'Filtro de Ventas Personales
        Dim filter As InvoiceSearchSpecs = New InvoiceSearchSpecs
        filter.SalesMan = Me.txtvendedor.Text
        filter.Period = cierre
        filter.StatusNotIn = {InvoiceStatus.Canceled, InvoiceStatus.PassiveInTransit, InvoiceStatus.Passive, InvoiceStatus.Lost}
        filter.TypeInvoices = {TypeInvoice.Credit, TypeInvoice.Cash}
        For Each f As Invoice In New InvoiceBook(filter)
            item = New ListViewItem(f.Number)
            item.SubItems.Add(f.Date)
            item.SubItems.Add(f.TimeLimit)
            item.SubItems.Add(f.Customer.FullName)
            item.SubItems.Add(f.Line1.ToString("C2"))
            item.SubItems.Add(f.MonthlyFee.ToString("C2"))
            item.SubItems.Add(f.Payments.TotalCanceled.ToString("C2"))
            item.Group = Me.lvFacturasVendedor.Groups(0)
            Me.lvFacturasVendedor.Items.Add(item)
            VentasPersonales += f.Line1
        Next
        Me.txtVendedorVentasPersonales.Text = VentasPersonales.ToString("C2")

        'Ordenes pendientes de primera cuota
        VentasPeriodo = 0
        filter.Clear()
        filter.SalesMan = Me.txtvendedor.Text
        filter.Period = 0
        filter.StatusNotIn = {InvoiceStatus.Canceled, InvoiceStatus.PassiveInTransit, InvoiceStatus.Passive, InvoiceStatus.Lost}
        filter.TypeInvoices = {TypeInvoice.Credit, TypeInvoice.Cash}
        filter.MinimunDate = DateTime.Now.Date.AddMonths(-2)
        For Each f As Invoice In New InvoiceBook(filter)
            item = New ListViewItem(f.Number)
            item.SubItems.Add(f.Date)
            item.SubItems.Add(f.TimeLimit)
            item.SubItems.Add(f.Customer.FullName)
            item.SubItems.Add(f.Line1.ToString("C2"))
            item.SubItems.Add(f.MonthlyFee.ToString("C2"))
            item.SubItems.Add(f.Payments.TotalCanceled.ToString("C2"))
            item.Group = Me.lvFacturasVendedor.Groups(1)
            Me.lvFacturasVendedor.Items.Add(item)
            VentasPeriodo += f.Line1
        Next
        Me.txtVentasPersonalesProceso.Text = VentasPeriodo.ToString("C2")

        Me.lvVendedoresUnidad.Items.Clear()
        Me.lvVendedoresUnidad.Groups.Clear()

        Dim NuevosReclutas As Integer = 0
        Dim nuevosdirectos As Integer = 0
        Dim DirectosVenta As Integer
        Dim IndirectosVenta As Integer

        venta = 0
        ActivosDirectos = 0
        activosindirectos = 0
        DirectosVenta = 0
        IndirectosVenta = 0
        Dim specs As New SalesForceLib.SalesStaffSearchSpecs
        specs.MinGeneration = 1
        Dim staff As New SalesForceLib.SalesStaff(CurrentSalesMan, specs)

        For Each r As SalesForceLib.Recruits In staff
            If r.Recruit.EntryPeriod = cierre Then
                NuevosReclutas += 1
                If r.Level = 1 Then
                    nuevosdirectos += 1
                End If
            End If
            'Ventas Personales del Recluta
            filter.Clear()
            filter.SalesMan = r.Recruit.Id
            filter.Period = cierre
            filter.StatusNotIn = {InvoiceStatus.Canceled, InvoiceStatus.PassiveInTransit, InvoiceStatus.Passive, InvoiceStatus.Lost}
            filter.TypeInvoices = {TypeInvoice.Credit, TypeInvoice.Cash}

            VentaVendedor = New InvoiceBook(filter).Sum(Function(invoice) invoice.Line1)

            'Ventas Pendientes del recluta
            filter.Clear()
            filter.SalesMan = r.Recruit.Id
            filter.Period = 0
            filter.StatusNotIn = {InvoiceStatus.Canceled, InvoiceStatus.PassiveInTransit, InvoiceStatus.Passive, InvoiceStatus.Lost}
            filter.TypeInvoices = {TypeInvoice.Credit, TypeInvoice.Cash}
            filter.MinimunDate = DateTime.Now.Date.AddMonths(-2)

            VentaProceso = New InvoiceBook(filter).Sum(Function(invoice) invoice.Line1)

            item = New ListViewItem(r.Recruit.FullName)
            item.SubItems.Add(VentaVendedor)
            item.SubItems.Add(VentaProceso)
            item.SubItems.Add(r.Recruit.Id)
            item.SubItems.Add(r.Level)

            If VentaVendedor > 0 Then
                If r.Level = 1 Then
                    DirectosVenta += 1
                    If VentaVendedor >= 299999 Then
                        ActivosDirectos = ActivosDirectos + 1
                    End If
                Else
                    IndirectosVenta = IndirectosVenta + 1
                    If VentaVendedor >= 299999 Then
                        activosindirectos = activosindirectos + 1
                    End If
                End If
            End If
            If VentaVendedor + VentaProceso = 0 Then
                item.Group = group0
            Else
                Dim group As ListViewGroup = lvVendedoresUnidad.Groups.Item(r.Level.ToString)
                If group Is Nothing Then
                    group = New ListViewGroup(r.Level.ToString, "Generacion #: " + r.Level.ToString())

                    Me.lvVendedoresUnidad.Groups.Add(group)
                End If
                item.Group = group
            End If

            Me.lvVendedoresUnidad.Items.Add(item)
            venta += VentaVendedor
        Next
        Me.txtNuevosReclutas.Text = NuevosReclutas
        Me.txtNuevosDirectos.Text = nuevosdirectos

        Me.lvVendedoresUnidad.Groups.Add(group0)
        Me.txtVentasUnidad.Text = venta + VentasPersonales
        Me.txtReclutasActivosDirectos.Text = ActivosDirectos
        Me.txtReclutasActivosIndirectos.Text = activosindirectos
        Me.txtDirectosConVenta.Text = CType(DirectosVenta, String)
        Me.txtIndirectosVenta.Text = CType(IndirectosVenta, String)
        loadventas = True

        TabControl2_SelectedIndexChanged(Nothing, Nothing)

        Me.PictureBox2.Visible = False
        My.Application.DoEvents()
    End Sub
    Private Sub cmbCierre_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCierre.SelectedValueChanged
        If cmbCierre.SelectedValue.ToString <> "System.Data.DataRowView" Then
            Me.Cursor = Cursors.WaitCursor
            CargarInformacionVentas(Convert.ToInt32(Me.cmbCierre.SelectedValue))
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub VendedoresActivosInactivosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VendedoresActivosInactivosToolStripMenuItem.Click
        Dim cmd As SqlCommand
        Dim i As Integer
        If Not LoadVendedor Then
            MessageBox.Show("Debe Ingresar un codigo de Vendedor", "ServicioalCliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Try
            Me.Cursor = Cursors.WaitCursor

            CargarInformacionVentas(Convert.ToInt32(Me.cmbCierre.SelectedValue))

            cmd = New SqlCommand("delete from reporte_encabezado_activos", db)
            cmd.ExecuteNonQuery()
            cmd = New SqlCommand("delete from reporte_activos_inactivos", db)
            cmd.ExecuteNonQuery()

            cmd = New SqlCommand("INSERT INTO reporte_encabezado_activos " &
                                "(lider,nombre,ventas_actuales,ventas_transicion,ventas_unidad,ventas_unidad_transicion) " &
                                "VALUES (@lider,@nombre,@ventasactuales,@ventastransicion,@ventasunidad,@ventasunidadtransicion)", db)
            cmd.Parameters.Add(New SqlParameter("@lider", SqlDbType.VarChar))
            cmd.Parameters("@lider").Value = Me.txtvendedor.Text
            cmd.Parameters.Add(New SqlParameter("@nombre", SqlDbType.VarChar))
            cmd.Parameters("@nombre").Value = Me.lbVendedor.Text
            cmd.Parameters.Add(New SqlParameter("@ventasactuales", SqlDbType.Money))
            cmd.Parameters("@ventasactuales").Value = txtVendedorVentasPersonales.Text
            cmd.Parameters.Add(New SqlParameter("@ventastransicion", SqlDbType.Money))
            cmd.Parameters("@ventastransicion").Value = Me.txtVentasPersonalesProceso.Text
            cmd.Parameters.Add(New SqlParameter("@ventasunidad", SqlDbType.Money))
            cmd.Parameters("@ventasunidad").Value = Me.txtVentasUnidad.Text
            cmd.Parameters.Add(New SqlParameter("@ventasunidadtransicion", SqlDbType.Money))
            cmd.Parameters("@ventasunidadtransicion").Value = 0
            cmd.ExecuteNonQuery()
            For i = 0 To Me.lvVendedoresUnidad.Items.Count - 1
                cmd = New SqlCommand("INSERT INTO reporte_activos_inactivos (lider,vendedor,venta_actual,venta_transicion,generacion,estado) VALUES (@lider,@vendedor,@ventasactuales,@ventastransicion,@generacion,@estado)", db)
                cmd.Parameters.Add(New SqlParameter("@lider", SqlDbType.VarChar))
                cmd.Parameters("@lider").Value = Me.txtvendedor.Text
                cmd.Parameters.Add(New SqlParameter("@vendedor", SqlDbType.VarChar))
                cmd.Parameters("@vendedor").Value = Me.lvVendedoresUnidad.Items(i).SubItems(3).Text
                cmd.Parameters.Add(New SqlParameter("@ventasactuales", SqlDbType.Money))
                cmd.Parameters("@ventasactuales").Value = Me.lvVendedoresUnidad.Items(i).SubItems(1).Text
                cmd.Parameters.Add(New SqlParameter("@ventastransicion", SqlDbType.Money))
                cmd.Parameters("@ventastransicion").Value = Me.lvVendedoresUnidad.Items(i).SubItems(2).Text
                cmd.Parameters.Add(New SqlParameter("@generacion", SqlDbType.Int))
                cmd.Parameters("@generacion").Value = Me.lvVendedoresUnidad.Items(i).SubItems(4).Text
                cmd.Parameters.Add(New SqlParameter("@estado", SqlDbType.Int))
                If Convert.ToDouble(Me.lvVendedoresUnidad.Items(i).SubItems(1).Text) >= 500 Then
                    cmd.Parameters("@estado").Value = 1
                Else
                    cmd.Parameters("@estado").Value = 0
                End If
                cmd.ExecuteNonQuery()
            Next
            frmVistaPrevia.TypeReport = frmVistaPrevia.Reports.ReclutasActivosInactivos
            frmVistaPrevia.selectionformula = ""
            frmVistaPrevia.AddFormula("compania", "Master Cocina")
            frmVistaPrevia.AddFormula("fecha", DateTime.Now.ToShortDateString)
            frmVistaPrevia.AddFormula("v_usuario", Usuario)
            frmVistaPrevia.Show()
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MessageBox.Show("No se pudo visualizar el reporte", "ServicioalCliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub
    Private Sub CategoriasDeEstudiosDeCreditoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CategoriasDeEstudiosDeCreditoToolStripMenuItem.Click
        If Not LoadVendedor Then
            MessageBox.Show("Debe Ingresar un codigo de Vendedor", "ServicioalCliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        frmFiltrarCategorias.Show()
    End Sub
    Private Sub lbNivel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbNivel.Click
        If Me.txtvendedor.Text <> "" Then
            frmNiveles.vendedor = Me.txtvendedor.Text
            frmNiveles.CargarDatos()
            frmNiveles.Show()
        End If
    End Sub
    Private Sub cmbProvincia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbProvincia.SelectedIndexChanged
    End Sub
    Private Sub CToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CToolStripMenuItem.Click
        frmFiltrarNuevosContratos.Show()
    End Sub
    Private Sub NuevosEjecutivosDeVentasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevosEjecutivosDeVentasToolStripMenuItem.Click
        frmFiltrarEjecutivosVentas.Show()
    End Sub
    Private Sub tabpage57_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tabpage57.Click
    End Sub
    Private Sub SeguimientoPostVentaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SeguimientoPostVentaToolStripMenuItem.Click
        frmOrdenesCanceladas.Show()
    End Sub
    Private Sub SeguimientoVendedoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SeguimientoVendedoresToolStripMenuItem.Click
        frmVendedores.Show()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

        If Not LoadVendedor Then
            MessageBox.Show("Debe Ingresar un nombre de vendedor", "ServicioalCliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If MessageBox.Show("Confirma desea actualizar los datos del vendedor", "Servcioacliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            With CurrentSalesMan
                .FirstName = Me.txtNombreVendedor.Text
                .LastName01 = Me.txtapellido01vendedor.Text
                .LastName02 = Me.txtapellido02vendedor.Text

                .PhoneNumber01 = Me.txthabitacionvendedor.Text
                .PhoneNumber02 = Me.txtcelularvendedor.Text
                .FaxNumber = Me.txtfaxvendedor.Text
                .Email = Me.txtcorreovendedor.Text

                .Province = Me.cmbprovinciavendedor.SelectedItem
                .Canton = Me.cmbcantonvendedor.SelectedItem
                .District = Me.cmbdistritovendedor.SelectedItem
                .SpecificAddress = Me.txtdireccionvendedor.Text
                .DateOfBirth = Me.dtFechaNacVendedor.Text
            End With

            Try
                Dim force As New SalesForceLib.SalesForce
                force.Update(CurrentSalesMan)

                MessageBox.Show("Datos actualizados correctamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show("No se pudo actualizar la informacion " + ex.Message, "Servicioalcliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
    Private Sub LoadReferencias()
        Dim query As String
        Dim cmd As SqlCommand
        Dim reader As SqlDataReader

        If Not LoadVendedor Then Exit Sub

        Me.PictureBox2.Visible = True
        My.Application.DoEvents()

        query = "SELECT cd.estado_civil,cd.nombre_conyuge+' '+cd.apellido_01_conyuge+' '+cd.apellido_02_conyuge as nom,cd.telefono_conyuge as tel " &
                "FROM clientes_adicional cd, vendedores v " &
                "WHERE v.cod_cliente = cd.cliente and v.vendedor = @vendedor"
        cmd = New SqlCommand(query, db)
        cmd.Parameters.AddWithValue("@vendedor", Me.txtvendedor.Text)

        Try
            reader = cmd.ExecuteReader
            If reader.Read Then
                Me.txtEstadoCivil.Text = reader.Item("estado_civil").ToString
                Me.txtNombreConyuge.Text = reader.Item("nom").ToString
                Me.txtTelefonoConyuge.Text = reader.Item("tel").ToString
            End If
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("No se pudo obtener la informacion del conyuge del vendedor", "Servicioalcliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        query = "SELECT rpc.* " &
                "FROM referencias_personales_cliente rpc, vendedores v " &
                "WHERE rpc.cliente = v.cod_cliente and v.vendedor = @vendedor"
        cmd = New SqlCommand(query, db)
        cmd.Parameters.AddWithValue("@vendedor", Me.txtvendedor.Text)

        Try
            reader = cmd.ExecuteReader
            If reader.Read Then
                Me.txtNombreReferencia01.Text = reader.Item("nombre_referencia_01").ToString
                Me.txtNombreReferencia02.Text = reader.Item("nombre_referencia_02").ToString

                Me.txtSector01.Text = reader.Item("sector_01").ToString
                Me.txtSector02.Text = reader.Item("sector_02").ToString

                Me.txtTelefonoReferencia01.Text = reader.Item("telefonos_01").ToString
                Me.txtTelefonoReferencia02.Text = reader.Item("telefonos_02").ToString

            End If
            reader.Close()

        Catch ex As Exception

        End Try
        Me.lvReferencias.Items.Clear()
        query = "SELECT rc.nombre+' '+rc.apellido_01+' '+rc.apellido_02 as nom, rc.telefono_01,rc.telefono_02,rc.observaciones " &
                "FROM referencias_cliente rc , vendedores v " &
                "WHERE rc.cliente = v.cod_cliente and v.vendedor = @vendedor"
        cmd = New SqlCommand(query, db)
        cmd.Parameters.AddWithValue("@vendedor", Me.txtvendedor.Text)

        Try
            reader = cmd.ExecuteReader
            If reader.Read Then
                Dim item As ListViewItem = New ListViewItem(reader.Item("nom").ToString)
                item.SubItems.Add(reader.Item("telefono_01").ToString)
                item.SubItems.Add(reader.Item("telefono_02").ToString)
                item.SubItems.Add(reader.Item("observaciones").ToString)
                Me.lvReferencias.Items.Add(item)
            End If
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("No se pudo obtener la informacion de otras referencias", "ServicioalCliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        LoadRef = True
        Me.PictureBox2.Visible = False
        My.Application.DoEvents()

    End Sub
    Private Sub CrearArbolOrganizacion()
        Dim nodo As TreeNode = Nothing
        Dim nodopadre As TreeNode = Nothing

        If Not LoadVendedor Then Exit Sub
        Me.PictureBox2.Visible = True
        My.Application.DoEvents()

        Me.lvTreeReclutas.Nodes.Clear()

        'Obtiene los lideres del vendedor
        Dim specs As New SalesForceLib.SalesStaffSearchSpecs() With {.Recruit = CurrentSalesMan}
        Dim staff As New SalesForceLib.SalesStaff(specs)


        For Each r As SalesForceLib.Recruits In staff.OrderBy(Function(re As SalesForceLib.Recruits) re.Level)
            nodo = New TreeNode(r.Lider.FullName)
            nodo.Name = r.Lider.Id
            nodo.Tag = r.Lider
            If nodopadre Is Nothing Then
                Me.lvTreeReclutas.Nodes.Add(nodo)
            Else
                nodopadre.Nodes.Add(nodo)
            End If
            nodopadre = nodo
            nodopadre.Expand()
        Next
        CrearTree(nodopadre, CurrentSalesMan)
        LoadOrganizacion = True
        Me.PictureBox2.Visible = False
        My.Application.DoEvents()
    End Sub

    Private Sub TabControl3_Selected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TabControlEventArgs) Handles TabControl3.Selected
        If TabControl3.SelectedIndex = 1 Then
            If LoadRef Then Exit Sub
            If LoadVendedor Then
                LoadReferencias()
            End If
        End If
        If TabControl3.SelectedIndex = 2 Then
            If LoadOrganizacion Then Exit Sub
            CrearArbolOrganizacion()
        End If
        If TabControl3.SelectedIndex = 3 Then
            If loadventas Then Exit Sub

            CargarInformacionVentas(Convert.ToInt32(Me.cmbCierre.SelectedValue))

        End If
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click


        If Not LoadCliente Then
            MessageBox.Show("Debe Ingresar un Cliente", "ServicioalCliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If MessageBox.Show("Confirma desea actualizar los datos del cliente", "Servcioacliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            With CurrentCustomer
                .FirstName = Me.txtNombre.Text
                .LastName01 = Me.txtapellido01.Text
                .LastName02 = Me.txtApellido02.Text
                .HomePhoneNumber = Me.txtHabitacion.Text
                .CellPhoneNumber = Me.txtCelular.Text
                .FaxNumber = Me.txtFax.Text
                .Email = Me.txtCorreo.Text
                .Province = Me.cmbProvincia.SelectedItem
                .Canton = Me.cmbCanton.SelectedItem
                .District = Me.cmbDistrito.SelectedItem
                .SpecificAddress = Me.txtDireccion.Text
                .DateOFBirth = Me.dtFechaNacCliente.Value
            End With
            Try
                Dim port As New CustomerPortfolio

                port.Update(CurrentCustomer)

                MessageBox.Show("Datos Actualizados Correctamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show("No se pudo actualizar la informacion " + ex.Message, "Servicioalcliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs)
        FrmBitacoraVendedoresExtend.Show()
    End Sub

    Private Sub TabControl2_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles TabControl2.SelectedIndexChanged
        If TabControl2.SelectedIndex = 2 Then
            Dim cmd As SqlCommand
            Dim da As SqlDataAdapter
            Dim ds As DataSet
            Dim item As ListViewItem
            Dim i As Integer
            Dim DiasDiff As Integer
            Dim fecha As DateTime
            'Obtiene todos los miembros del equipo
            cmd = New SqlCommand("select  r.recluta,r.generacion,v.cierre_ingreso, v.nombre+' '+v.apellido_01+' '+v.apellido_02 as nom_ven, v.fecha_ult_venta,v.fecha_ingreso, activo " &
                                "from reclutas r, vendedores v " &
                                "where (r.recluta = v.vendedor) and (r.lider = @lider) and (r.generacion > 0) order by v.cierre_ingreso desc, r.generacion asc ", db)
            cmd.Parameters.AddWithValue("@lider", Me.txtvendedor.Text)
            da = New SqlDataAdapter(cmd)
            ds = New DataSet
            da.Fill(ds)
            If ds.Tables(0).Rows.Count > 0 Then
                For i = 0 To ds.Tables(0).Rows.Count - 1
                    Dim FechaUltVenta As DateTime = Nothing
                    Dim FechaPrimerVenta As DateTime = Nothing

                    With ds.Tables(0).Rows(i)
                        item = New ListViewItem(.Item("recluta").ToString)

                        fecha = CType(.Item("fecha_ingreso").ToString, DateTime)
                        DiasDiff = Microsoft.VisualBasic.DateDiff(Microsoft.VisualBasic.DateInterval.Day, fecha, DateTime.Now)

                        Select Case DiasDiff
                            Case 1 To 30 : item.Group = Me.lvEstadoReclutamiento.Groups(0)
                            Case 31 To 60 : item.Group = Me.lvEstadoReclutamiento.Groups(1)
                            Case 61 To 90 : item.Group = Me.lvEstadoReclutamiento.Groups(2)
                            Case 91 To 120 : item.Group = Me.lvEstadoReclutamiento.Groups(3)
                            Case Is > 120 : item.Group = Me.lvEstadoReclutamiento.Groups(4)
                        End Select

                        item.SubItems.Add(.Item("nom_ven").ToString)
                        item.SubItems.Add(.Item("generacion").ToString)
                        item.SubItems.Add("P-" + .Item("cierre_ingreso").ToString)
                        item.SubItems.Add(fecha.ToShortDateString)

                        'Fecha de la primer venta
                        Dim cmdMinFact As New SqlCommand("SELECT min(fecha) as fecha " &
                                                        "FROM facturas_encabezado " &
                                                        "WHERE vendedor = @vendedor and estado <> 4 and tipo < 3", db)
                        cmdMinFact.Parameters.AddWithValue("@vendedor", .Item("recluta").ToString)
                        Dim da2 As New SqlDataAdapter(cmdMinFact)
                        Dim ds2 As New DataSet
                        da2.Fill(ds2)
                        If ds2.Tables(0).Rows.Count > 0 Then
                            If Convert.IsDBNull(ds2.Tables(0).Rows(0).Item("fecha")) Then
                                item.SubItems.Add("")
                            Else
                                FechaPrimerVenta = CType(ds2.Tables(0).Rows(0).Item("fecha"), DateTime)
                                item.SubItems.Add(FechaPrimerVenta)
                            End If
                        Else
                            item.SubItems.Add("")
                        End If
                        '
                        'Fecha de la ultima venta
                        If Convert.IsDBNull(.Item("fecha_ult_venta")) Then
                            item.SubItems.Add("")
                            item.SubItems.Add("0")
                        Else
                            FechaUltVenta = .Item("fecha_ult_venta").ToString
                            item.SubItems.Add(FechaUltVenta.ToShortDateString)

                            If Not (FechaPrimerVenta = Nothing) And Not (FechaUltVenta = Nothing) Then
                                item.SubItems.Add(Microsoft.VisualBasic.DateDiff(Microsoft.VisualBasic.DateInterval.Month,
                                                                                 FechaPrimerVenta,
                                                                                 FechaUltVenta))
                            Else
                                item.SubItems.Add("0")
                            End If
                        End If

                        If CType(.Item("activo").ToString, Integer) > 0 Then
                            item.SubItems.Add("P-" + .Item("activo").ToString)
                        Else
                            item.SubItems.Add("N/A")
                        End If

                        item.SubItems.Add(0)

                        '
                        'Reclutas directos del vendedor
                        Dim cmd3 As New SqlCommand("SELECT isnull(Count(vendedor),0) as reclutas " &
                                                   "FROM vendedores " &
                                                   "where patrocinador = '" & .Item("recluta").ToString & "'", db)
                        Dim da3 As New SqlDataAdapter(cmd3)
                        Dim ds3 As New DataSet
                        da3.Fill(ds3)
                        If ds3.Tables(0).Rows.Count > 0 Then
                            item.SubItems.Add(ds3.Tables(0).Rows(0).Item("reclutas").ToString)
                        Else
                            item.SubItems.Add("0")
                        End If

                        Me.lvEstadoReclutamiento.Items.Add(item)

                    End With
                Next
            End If
        End If
        If TabControl2.SelectedIndex = 3 Then
            ChartVentaEquipo.Series.Clear()
            ChartReclutamiento.Series.Clear()
            Me.lbVentasProvincia.Text = "Ventas por Provincia (P-" + CType(Me.cmbCierre.SelectedValue, String) + ")"
            Me.lbEstadoReclutamiento.Text = "Reclutamiento por Provincia (P-" + CType(Me.cmbCierre.SelectedValue, String) + ")"

            'Obtiene las provincias
            Using db As SqlConnection = New SqlConnection(Variables.ConnectionString)
                Using cmd As SqlCommand = New SqlCommand("SELECT provincia, descripcion FROM provincias WHERE descripcion <> 'DESCONOCIDA' ", db)
                    cmd.CommandType = CommandType.Text
                    Dim reader As SqlDataReader
                    Try
                        db.Open()
                        reader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                    Catch ex As Exception
                        MessageBox.Show("No se pudo obtener las provincias", "Servicioalcliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        If db.State = ConnectionState.Open Then
                            db.Close()
                        End If
                        Exit Sub
                    End Try
                    Dim serie As New Series("Provincias")
                    Dim serier As New Series("Provincias")

                    serie.ChartType = SeriesChartType.Pie
                    serie.IsValueShownAsLabel = True

                    serier.ChartType = SeriesChartType.Pie
                    serier.IsValueShownAsLabel = True
                    Using db2 As SqlConnection = New SqlConnection(Variables.ConnectionString)
                        db2.Open()
                        While reader.Read
                            Dim provincia As Integer = CType(reader.Item("provincia").ToString, Integer)

                            Using cmdventas As SqlCommand = New SqlCommand("SELECT isnull(sum(fe.monto_bruto),0) " &
                                                                           "FROM facturas_encabezado fe, clientes c " &
                                                                           "WHERE fe.cliente = c.cliente and fe.tipo < 3 and fe.estado <> 4 and fe.cierre = @cierre " &
                                                                           "AND c.provincia = @provincia and fe.vendedor in (select recluta from reclutas where lider = @lider) ", db2)
                                cmdventas.Parameters.AddWithValue("lider", Me.txtvendedor.Text)
                                cmdventas.Parameters.AddWithValue("provincia", provincia)
                                cmdventas.Parameters.AddWithValue("cierre", Convert.ToInt32(Me.cmbCierre.SelectedValue))

                                Try

                                    Dim Ventas As Double = cmdventas.ExecuteScalar

                                    Dim pt As New DataPoint

                                    pt.LegendText = reader.Item("descripcion").ToString + " ($" + CType(Ventas, String) + ")"
                                    pt.IsValueShownAsLabel = False
                                    pt.YValues(0) = Ventas

                                    serie.Points.Add(pt)
                                Catch ex As Exception

                                End Try
                            End Using


                            Using cmdventas As SqlCommand = New SqlCommand("SELECT isnull(count(vendedor),0) " &
                                                       "FROM vendedores " &
                                                       "where cierre_ingreso = @cierre and provincia = @provincia " &
                                                       "AND vendedor in (SELECT recluta from reclutas where lider = @lider) ", db2)
                                cmdventas.Parameters.AddWithValue("lider", Me.txtvendedor.Text)
                                cmdventas.Parameters.AddWithValue("provincia", provincia)
                                cmdventas.Parameters.AddWithValue("cierre", Convert.ToInt32(Me.cmbCierre.SelectedValue))
                                Try

                                    Dim reclutas As Integer = cmdventas.ExecuteScalar
                                    Dim pt As New DataPoint

                                    pt.LegendText = reader.Item("descripcion").ToString + " (" + CType(reclutas, String) + ")"
                                    pt.IsValueShownAsLabel = False
                                    pt.YValues(0) = reclutas


                                    serier.Points.Add(pt)

                                Catch ex As Exception

                                End Try
                            End Using
                        End While
                        reader.Close()
                        db2.Close()
                    End Using

                    ChartVentaEquipo.Series.Add(serie)
                    ChartReclutamiento.Series.Add(serier)
                End Using
            End Using
        End If


    End Sub

    Private Sub cmbCierre_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbCierre.SelectedIndexChanged

    End Sub

    Private Sub Button8_Click_1(sender As System.Object, e As System.EventArgs)


    End Sub

    Private Sub EventosPublicitariosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EventosPublicitariosToolStripMenuItem.Click
        Dim CrmCnn As String = "Data Source=192.168.100.4;Initial Catalog=CRM;Persist Security Info=True;User ID=UserCRM;Password=Asd1234."

        Dim pr As TrackingContactsLib.WindowsView.Init = New TrackingContactsLib.WindowsView.Init(CrmCnn, Variables.Usuario)

        pr.Start()
    End Sub


    Private Sub CapacitacionesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CapacitacionesToolStripMenuItem.Click
        Dim frm As Academic.frmControlCapacitacion

        frm = New Academic.frmControlCapacitacion(Variables.ConnectionString)
        frm.Show()

    End Sub

    Private Sub EncuestasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EncuestasToolStripMenuItem.Click
        Dim frm As Survey.frmSurvey

        frm = New Survey.frmSurvey(Variables.ConnectionString)
        frm.Show()

    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ClientesToolStripMenuItem.Click

    End Sub

    Private Sub Button8_Click_2(sender As System.Object, e As System.EventArgs)



    End Sub

    Private Sub PerfilesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PerfilesToolStripMenuItem.Click
        Dim perf As UserAccessManager.main

        perf = New UserAccessManager.main

        perf.ShowPerfilesWindow(Variables.ConnectionString)

    End Sub

    Private Sub ConcursosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ConcursosToolStripMenuItem.Click
        'Dim frm As SFC.ContestsLib.WinForms.frmConcursos = New SFC.ContestsLib.WinForms.frmConcursos

        'frm.Show()
    End Sub

    Private Sub Button8_Click_3(sender As System.Object, e As System.EventArgs) Handles Button8.Click


    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        ' Dim vs As SFC.SalesForceLib.VendedoresWithSales = New SFC.SalesForceLib.VendedoresWithSales(6)
        'vs.Fill()
        'vs.MakeFileVcf("c:\contact.vcf")
    End Sub

    Private Sub TabPage7_Click(sender As Object, e As EventArgs) Handles TabPage7.Click

    End Sub

    Private Sub cmdBuscaCliente_Click(sender As Object, e As EventArgs) Handles cmdBuscaCliente.Click
        If Me.frmBuscaCliente Is Nothing Then
            Me.frmBuscaCliente = New CustomerPortfolioLib.WindowsView.frmCustomersSearch
        ElseIf Not Me.frmBuscaCliente.IsHandleCreated Then
            Me.frmBuscaCliente = New CustomerPortfolioLib.WindowsView.frmCustomersSearch
        End If

        Me.frmBuscaCliente.Show()
        Me.frmBuscaCliente.BringToFront()
        Me.frmBuscaCliente.WindowState = FormWindowState.Normal
    End Sub

    Private Sub frmBuscaCliente_CustomerSelected(customer As Customer) Handles frmBuscaCliente.CustomerSelected
        CurrentCustomer = customer

        LoadInfoCliente(CurrentCustomer)
    End Sub

    Private Sub frmMain_Closed(sender As Object, e As EventArgs) Handles Me.Closed

    End Sub
End Class
