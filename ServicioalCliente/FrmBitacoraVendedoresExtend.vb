Imports System.Data.SqlClient
Imports System.Linq
Imports System.Windows.Forms.DataVisualization.Charting
Imports CompensationPlan
Imports CTILib
Imports InvoicingLib
Imports SalesForceLib
Imports SalesSummary
Imports Microsoft.VisualBasic
Public Class FrmBitacoraVendedoresExtend
    Public CodigoVendedor As String
    Public Cierre As Integer
    Private s As SalesMan
    Private PlanMercadeoActual As Integer
    Public Gestion As Integer
    Private AgregoObservacion As Boolean = False
    Private _HasMetas As Boolean = False
    Private TypeCall As Integer

    Public FormPadre As frmVendedores
    Public line As ListViewItem
    Private Sub FrmBitacoraVendedoresExtend_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not _HasMetas And Me.TypeCall = 1 Then
            MessageBox.Show("Debe ingresar las metas del vendedor para el periodo actual", "Servicioalcliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
            e.Cancel = True
        End If
    End Sub
    Private Sub CargarBitacora()
        Me.lvBitacora.Items.Clear()

        Dim notepad As New Notepad(s)

        For Each n As PostIt In notepad.OrderByDescending(Function(p As PostIt) p.Date)
            'Fecha de la proxima llamada
            If lbproxima.Text.Length = 0 Then
                Me.lbproxima.Text = "Proxima Llamada: " + n.DateNextCall.ToShortDateString
            End If

            Dim text As String = n.Date.ToString("dd.MM.yyyy") + " (" + n.Gestor + ") " + n.Observation
            Dim index As Integer = 80

            While index < text.Length
                text = text.Insert(index, "|")
                index += 80
            End While

            For Each str As String In text.Split("|")
                Dim item As ListViewItem = New ListViewItem(str)
                If n.CallStatus = 1 Then
                    item.BackColor = Color.FromArgb(92, 220, 156)
                End If
                If n.CallStatus = 2 Then
                    item.BackColor = Color.FromArgb(249, 211, 83)
                End If
                If n.CallStatus = 3 Then
                    item.BackColor = Color.FromArgb(249, 102, 66)
                End If
                Me.lvBitacora.Items.Add(item)
            Next
        Next

    End Sub
    Private Sub CargarInfo()
        Me.TabControl1.Visible = False
        Me.TabControl2.Visible = False
        Me.chartViewer.Visible = False
        Me.lvVentas.Visible = False


        Panel4.Visible = False

        'panel central
        Me.Panel8.Visible = False
        Me.Label36.Visible = False
        Me.lvFacturas.Visible = False
        Me.lvVentasEquipo.Visible = False

        'Panel Derecho
        Me.Label45.Visible = False
        Me.lbMaxGeneracion.Visible = False
        Me.Label44.Visible = False
        Me.TableLayoutPanel1.Visible = False
        Me.lbEncabezadoBonoExcelencia.Visible = False


        Dim terri As TerritorialDivisionLib.Location


        'Muestra la informacion personal del venddor
        Dim Force As SalesForce = New SalesForce

        s = Force(CodigoVendedor)
        If Not (s Is Nothing) Then
            Me.lbNombreVendedor.Text = s.FullName
            Me.lbNombreVendedor.Text = s.FullName + " (" + s.CompensationPlan.Description + ")"
            Me.lbCedula.Text = s.IdentificationCard
            Me.lbEmail.Text = s.Email
            If Not s.LastSaleDate Is Nothing Then
                Me.lbFechaUltimaVenta.Text = s.LastSaleDate.Value.ToShortDateString
            Else
                Me.lbFechaUltimaVenta.Text = ""
            End If
            Me.lbDireccion.Text = s.Location.FullAdress

            If Not (s.Sponsor Is Nothing) Then
                Me.lbPatrocinador.Text = "Patrocinador: " + s.Sponsor.FullName
            End If

            Me.lbPeriodo.Text = "Periodo Actual: P-" + CType(Cierre, String)
            Me.lbFechaNacimiento.Text = "Fecha Nacimiento: " + s.DateOfBirth.ToShortDateString
            Me.lbFechaIngreso.Text = "Fecha Ingreso: " + s.DateOfAdmission.ToShortDateString
            Me.txtTelefono01.Text = s.PhoneNumber01
            Me.txtTelefono2.Text = s.PhoneNumber02

            MakeDataChar(s)
            CargarBitacora()

            'CargarCapacitacion()

            'Me.CargarMetasBonoExcelencia(s.MarketingPlanID, s.LevelID)
            'Dim o As Sales.Opportunities.SalesOpportunities
            'o = New Sales.Opportunities.SalesOpportunities(Variables.ConnectionStringCRM, CodigoVendedor)
            'If o.Count > 0 Then
            ' Me.llOportunidades.Visible = True
            ' Else
            '    Me.llOportunidades.Visible = False
            'End If
        End If

        Me.chartViewer.Visible = True
        Me.lvVentas.Visible = True
        Panel4.Visible = True
        'Mostrar el panel central
        Me.Panel8.Visible = True
        Me.Label36.Visible = True
        Me.lvFacturas.Visible = True
        Me.lvVentasEquipo.Visible = True
        'Panek derecho
        Me.Label45.Visible = True
        Me.lbMaxGeneracion.Visible = True
        Me.Label44.Visible = True
        Me.TableLayoutPanel1.Visible = True
        Me.lbEncabezadoBonoExcelencia.Visible = True
        Me.TabControl1.Visible = True
        Me.TabControl2.Visible = True
    End Sub
    Private Sub FrmBitacoraVendedoresExtend_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim thd As New Threading.Thread(AddressOf CargarInfo)
        thd.Start()
    End Sub


    Private Sub cmdGuardar_Click(sender As System.Object, e As System.EventArgs)


    End Sub

    Private Sub Label14_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Label15_Click(sender As System.Object, e As System.EventArgs)
        Me.lvReclutas.Visible = True
        Me.lvBitacora.Visible = False
        Me.lvCapacitacion.Visible = False
        Me.lvActividades.Visible = False

        Me.Label32.Text = "Reclutas nuevos del periodo"
        Me.Label33.Visible = False
        Me.Label34.Visible = False
        Me.Label35.Visible = False
        Me.cmdAgregarObservacion.Visible = False
        Me.lbproxima.Visible = False
    End Sub

    Private Sub Label13_Click(sender As System.Object, e As System.EventArgs)
        Me.lvReclutas.Visible = False
        Me.lvCapacitacion.Visible = False
        Me.lvBitacora.Visible = True
        Me.lvActividades.Visible = False

        Me.Label32.Text = "Bitacora de conversaciones con el vendedor"
        Me.Label33.Visible = True
        Me.Label34.Visible = True
        Me.Label35.Visible = True
        Me.cmdAgregarObservacion.Visible = True
        Me.lbproxima.Visible = True
    End Sub
    Private Sub Label16_Click(sender As System.Object, e As System.EventArgs)
        Me.lvFacturas.Visible = True
        Me.lvVentasEquipo.Visible = False
        Me.Label36.Text = "Ordenes ingresadas en el periodo actual "
        Me.Panel8.Visible = False
    End Sub

    Private Sub Label18_Click(sender As System.Object, e As System.EventArgs)
        Me.lvFacturas.Visible = False
        Me.lvVentasEquipo.Visible = True
        Me.Label36.Text = "Montos en linea1 ingresados por los miembros del equipo"
        Me.Panel8.Visible = False
    End Sub
    Private Sub Label37_Click(sender As System.Object, e As System.EventArgs) Handles Label37.Click
        Panel1.Visible = False
        Panel6.Visible = False
        Panel7.Visible = True
    End Sub

    Private Sub Label19_Click(sender As System.Object, e As System.EventArgs) Handles Label19.Click
        Panel1.Visible = True
        Panel6.Visible = False
        Panel7.Visible = False
    End Sub

    Private Sub lvDocumentos_DoubleClick(sender As Object, e As System.EventArgs) Handles lvDocumentos.DoubleClick
        If Me.lvDocumentos.SelectedItems.Count > 0 Then
            Dim Proceso As New Process()
            Proceso.StartInfo.FileName = Me.lvDocumentos.SelectedItems(0).Tag
            Proceso.StartInfo.Arguments = ""
            Proceso.Start()
        End If
    End Sub
    Private Sub Label47_Click(sender As System.Object, e As System.EventArgs) Handles Label47.Click
        Panel6.Visible = True
        Panel1.Visible = False
        Panel7.Visible = False
    End Sub

    Private Sub cmdSalir_Click(sender As System.Object, e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub lbNombreVendedor_Click(sender As System.Object, e As System.EventArgs) Handles lbNombreVendedor.Click

    End Sub


    Private Sub cmdImprimir_Click(sender As System.Object, e As System.EventArgs) Handles cmdImprimir.Click
        Dim temp As RegistrosDeVenta.Temp


        temp = New RegistrosDeVenta.Temp(Variables.ConnectionString, CodigoVendedor)

        If (temp.Count() > 0) Then
            temp(0).venta = CType(txtEstadoVentaPersonal.Text, Decimal)
            temp(0).cierre = CType(Cierre, Decimal)
            temp(0).venta_generacion = CType(txtEstadoVentaGeneracion.Text, Decimal)
            temp(0).nuevos_reclutas = CType(txtEstadoNuevosReclutas.Text, Decimal)
            temp(0).activos_directos = CType(txtEstadoActivosDirectos.Text, Decimal)
            temp(0).activos_indirectos = CType(txtEstadoActivosIndirectos.Text, Decimal)
            temp(0).conventa_directos = CType(txtEstadoDirectoVenta.Text, Decimal)
            temp(0).conventa_indirectos = CType(txtEstadoIndirectoVenta.Text, Decimal)
            temp.Update()
        Else
            Dim rec As New RegistrosDeVenta.RegistroTemp

            With rec
                .vendedor = CodigoVendedor
                .venta = CType(txtEstadoVentaPersonal.Text, Decimal)
                .venta_generacion = CType(txtEstadoVentaGeneracion.Text, Decimal)
            End With

            temp.Add(rec)
        End If

        Dim frm As frmVistaPrevia = New frmVistaPrevia
        frm.TypeReport = frmVistaPrevia.Reports.VentasVendedor
        frm.selectionformula = "{Ventas.vendedor} = '" + CodigoVendedor + "' and {Ventas.cierre} in " + CType(Cierre - 4, String) + " to " + CType(Cierre - 1, String)
        frm.Show()


    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.TypeCall = 0
    End Sub

    Private Sub Label49_Click(sender As System.Object, e As System.EventArgs)
        Me.lvReclutas.Visible = False
        Me.lvBitacora.Visible = False
        Me.lvCapacitacion.Visible = True
        Me.lvActividades.Visible = False

        Me.Label32.Text = "Asistencia a Capacitaciones"
        Me.Label33.Visible = False
        Me.Label34.Visible = False
        Me.Label35.Visible = False
        Me.cmdAgregarObservacion.Visible = False
        Me.lbproxima.Visible = False
    End Sub
    Private Sub CargarCapacitacion()
        Me.lvCapacitacion.Items.Clear()
        Using dbcap As SqlConnection = New SqlConnection(Variables.ConnectionString)
            Using cmd As SqlCommand = New SqlCommand("SELECT cm.nombre,cmv.fecha, c.descripcion, cmv.id_Capacitacion " &
                                                    "FROM capacitacion_modulos cm ,capacitacion_modulos_vendedores cmv, capacitaciones c " &
                                                    "WHERE cm.id_capacitacion = cmv.id_capacitacion AND cm.id_modulo = cmv.id_modulo and c.id = cmv.id_capacitacion " &
                                                    "AND vendedor = @vendedor " &
                                                    "ORDER BY cm.prioridad desc", dbcap)
                cmd.CommandType = CommandType.Text
                cmd.Parameters.AddWithValue("@vendedor", CodigoVendedor)
                Try
                    dbcap.Open()
                    Dim Reader As SqlDataReader = cmd.ExecuteReader
                    While Reader.Read
                        Dim group As ListViewGroup = Nothing

                        For Each g As ListViewGroup In lvCapacitacion.Groups
                            If g.Tag = Reader("id_capacitacion").ToString Then
                                group = g
                            End If
                        Next
                        If group Is Nothing Then
                            group = New ListViewGroup(Reader("descripcion").ToString)
                            Me.lvCapacitacion.Groups.Add(group)
                        End If

                        Dim item As ListViewItem = New ListViewItem(Reader("nombre").ToString)
                        item.SubItems.Add(CType(Reader("fecha"), DateTime).ToShortDateString)
                        group.Items.Add(item)
                        Me.lvCapacitacion.Items.Add(item)

                    End While
                    Reader.Close()
                    dbcap.Close()
                Catch ex As Exception

                End Try

            End Using
        End Using
    End Sub

    Private Sub llOportunidades_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llOportunidades.LinkClicked
        Dim frmOpor As frmOportunidades = New frmOportunidades(CodigoVendedor)

        frmOpor.Show()
    End Sub

    Private Sub Label51_Click(sender As Object, e As EventArgs)
        Me.lvFacturas.Visible = False
        Me.lvVentasEquipo.Visible = False
        Me.Label36.Text = "Metas del Periodo"
        Me.Panel8.Visible = True
    End Sub


    Private Sub Label55_Click(sender As Object, e As EventArgs)
        Me.Label32.Text = "Asistencia a actividades"
        Me.lvReclutas.Visible = False
        Me.lvBitacora.Visible = False
        Me.lvCapacitacion.Visible = False
        Me.Label33.Visible = False
        Me.Label34.Visible = False
        Me.Label35.Visible = False
        Me.cmdAgregarObservacion.Visible = False
        Me.lbproxima.Visible = False
        My.Application.DoEvents()



    End Sub

    Private Sub cmdAgregarObservacion_Click(sender As Object, e As EventArgs) Handles cmdAgregarObservacion.Click
        frmAgregarObservacion.vendedor = Me.CodigoVendedor
        frmAgregarObservacion.Gestion = Gestion
        frmAgregarObservacion.ShowDialog(Me)

        Me.AgregoObservacion = frmAgregarObservacion.AgregoObservacion

        FormPadre.SetLineHighLigh(line, frmAgregarObservacion.TypeCall)
        If Me.AgregoObservacion Then
            line.SubItems(6).Text = frmAgregarObservacion.dtProximaLlamada.Value.ToString("yyyy-MM-dd")
            line.SubItems(5).Text = DateTime.Now.ToString("yyyy-MM-dd")

            CargarBitacora()
        End If
    End Sub

    Private Sub MakeDataChar(s As SalesMan)
        Dim i As Integer
        Dim chartArea1 As New ChartArea("ChartArea1")
        Dim _SerieVentaPersonal As New Series("Venta Personal")
        Dim _SerieVentaGeneracion As New Series("Venta Generacion")
        Dim _SerieNuevosReclutas As New Series("Reclutas Nuevos")
        Dim _serieReclutasActivosDirectos As New Series("Reclutas Activos Directos")
        Dim _SeriesReclutasActivosIndirectos As New Series("Reclutas Activos Indirectos")
        Dim _SeriesReclutasConVentaDirectos As New Series("Reclutas Directos con Venta")
        Dim _SeriesReclutasConVentaInDirectos As New Series("Reclutas Indirectos con Venta")

        chartViewer.ChartAreas.Add(chartArea1)

        Dim c As Integer = 1

        Dim st As New Stats(s)         'Registros Mensuales 
        Dim g As Goals = New Goals(s)  'Metas

        For i = (Cierre - 4) To (Cierre - 1) Step 1
            Me.lvVentas.Columns(c).Text = "Periodo P-" + CType(i, String)
            c = c + 1
            If Not st(i) Is Nothing Then
                With st(i)
                    'registros del periodo
                    Me.lvVentas.Items(0).SubItems.Add(.PersonalSale.ToString("'¢'#,0.00;('¢'#,0.00)"))
                    Me.lvVentas.Items(2).SubItems.Add(.UnitSales - .PersonalSale)
                    Me.lvVentas.Items(4).SubItems.Add(.NewRecruits)
                    Me.lvVentas.Items(6).SubItems.Add(.DirectActiveRecruits)
                    Me.lvVentas.Items(7).SubItems.Add(.IndirectActiveRecruits)
                    Me.lvVentas.Items(8).SubItems.Add(.DirectWithSaleRecruits)
                    Me.lvVentas.Items(9).SubItems.Add(.IndirectWithSaleRecruits)
                    'Metas del periodo
                    If Not g(i) Is Nothing Then
                        With g(i)
                            Me.lvVentas.Items(1).SubItems.Add(.PersonalSale.ToString("'¢'#,0.00;('¢'#,0.00)"))
                            Me.lvVentas.Items(3).SubItems.Add(.TeamSale)
                            Me.lvVentas.Items(5).SubItems.Add(.NewRecruits)
                        End With
                    Else
                        Me.lvVentas.Items(1).SubItems.Add("0,00")
                        Me.lvVentas.Items(3).SubItems.Add("0,00")
                        Me.lvVentas.Items(5).SubItems.Add("0")
                    End If
                    'Agrega los puntos al cuadro
                    _SerieVentaPersonal.Points.Add(.PersonalSale)
                    _SerieVentaGeneracion.Points.Add(.UnitSales - .PersonalSale)
                    _SerieNuevosReclutas.Points.Add(.NewRecruits * 1000)
                    _serieReclutasActivosDirectos.Points.Add(.DirectActiveRecruits * 1000)
                    _SeriesReclutasActivosIndirectos.Points.Add(.IndirectActiveRecruits * 1000)
                    _SeriesReclutasConVentaDirectos.Points.Add(.DirectWithSaleRecruits * 1000)
                    _SeriesReclutasConVentaInDirectos.Points.Add(.IndirectWithSaleRecruits * 1000)
                End With
            Else
                'Vendedor no tuvo registro de ventas en el periodo seleccionado
                'Dim rst As New RecordMensual
                'With rst
                ' .cierre = i
                ' .venta1 = 0
                ' .venta_equipo = 0
                ' .venta_unidad = 0
                ''.NQRD = 0
                ' .NQRI = 0
                ' .NVRD = 0
                ''.NVRI = 0
                ' .RAD = 0
                ' .RAI = 0
                ' .RVD = 0
                '.RVI = 0
                'End With

                's(0).AddRegistro(rst)
                's.ApplyChanges()

                Me.lvVentas.Items(0).SubItems.Add(0)
                Me.lvVentas.Items(1).SubItems.Add(0)
                Me.lvVentas.Items(2).SubItems.Add("0")
                Me.lvVentas.Items(3).SubItems.Add(0)
                Me.lvVentas.Items(4).SubItems.Add(0)
                Me.lvVentas.Items(5).SubItems.Add(0)
                Me.lvVentas.Items(6).SubItems.Add(0)

                _SerieVentaPersonal.Points.Add(0)
                _SerieVentaGeneracion.Points.Add(0)
                _SerieNuevosReclutas.Points.Add(0)
                _serieReclutasActivosDirectos.Points.Add(0)
                _SeriesReclutasActivosIndirectos.Points.Add(0)
                _SeriesReclutasConVentaDirectos.Points.Add(0)
                _SeriesReclutasConVentaInDirectos.Points.Add(0)
            End If
        Next i

        _SerieVentaPersonal.ChartType = SeriesChartType.Line
        _SerieVentaGeneracion.ChartType = SeriesChartType.Line
        _SerieNuevosReclutas.ChartType = SeriesChartType.Line
        _serieReclutasActivosDirectos.ChartType = SeriesChartType.Line
        _SeriesReclutasActivosIndirectos.ChartType = SeriesChartType.Line
        _SeriesReclutasConVentaDirectos.ChartType = SeriesChartType.Line
        _SeriesReclutasConVentaInDirectos.ChartType = SeriesChartType.Line

        chartViewer.Series.Add(_SerieVentaPersonal)
        chartViewer.Series.Add(_SerieVentaGeneracion)
        chartViewer.Series.Add(_SerieNuevosReclutas)
        chartViewer.Series.Add(_serieReclutasActivosDirectos)
        chartViewer.Series.Add(_SeriesReclutasActivosIndirectos)
        chartViewer.Series.Add(_SeriesReclutasConVentaDirectos)
        chartViewer.Series.Add(_SeriesReclutasConVentaInDirectos)

        chartViewer.Series(0).ChartArea = "ChartArea1"



        'Ordenes de compra con cuota completa
        Dim GrupoCuota As ListViewGroup = New ListViewGroup("Ordenes Cuota Completa")
        Me.lvFacturas.Groups.Add(GrupoCuota)
        Dim montomensual As Double = 0

        Dim filter As InvoiceSearchSpecs = New InvoiceSearchSpecs With {
            .SalesMan = s.Id,
            .Period = Cierre,
            .StatusNotIs = InvoicingLib.Common.InvoiceStatus.Canceled
        }

        For Each f As Invoice In New InvoiceBook(filter)
            Dim item As ListViewItem = New ListViewItem(f.Number)
            item.SubItems.Add(f.Date.ToShortDateString())
            item.SubItems.Add(f.Customer.FullName)
            item.SubItems.Add(f.Line1.ToString("C2"))
            item.Group = GrupoCuota
            montomensual += f.Line1
            Me.lvFacturas.Items.Add(item)
        Next
        Me.txtEstadoVentaPersonal.Text = montomensual.ToString("C2")

        'Ordenes ingresadas en este periodo pero no han completado la primera cuota
        Dim GrupoEnganche As ListViewGroup = New ListViewGroup("Ordenes con Enganche")
        Me.lvFacturas.Groups.Add(GrupoEnganche)

        filter.Clear()
        filter.SalesMan = s.Id
        filter.Period = 0
        filter.CreationPeriod = Cierre
        filter.StatusNotIs = InvoicingLib.Common.InvoiceStatus.Canceled
        filter.TypeInvoices = {TypeInvoice.Credit, TypeInvoice.Cash}

        For Each f As Invoice In New InvoiceBook(filter)
            Dim item As ListViewItem = New ListViewItem(f.Number)
            item.SubItems.Add(f.Date.ToShortDateString())
            item.SubItems.Add(f.Customer.FullName)
            item.SubItems.Add(f.Line1.ToString("C2"))
            item.Group = GrupoEnganche
            Me.lvFacturas.Items.Add(item)
        Next

        'Obtiene las ventas de los miembros del equipo
        Dim team As SalesStaff = New SalesStaff(s)
        Dim MontoEquipos As Double = 0
        Dim rda As Integer = 0, ria As Integer = 0
        Dim rdv As Integer = 0, riv As Integer = 0
        Dim nqr As Integer = 0

        For Each r As Recruits In team.OrderBy(Function(re As Recruits) re.Level)
            If r.Level > 0 Then
                Dim item As ListViewItem = New ListViewItem(r.Recruit.Id)
                item.SubItems.Add(r.Recruit.FullName)

                'Obtiene las ventas del recluta
                Dim rt As Stats = New Stats(r.Recruit)
                item.SubItems.Add(rt(Cierre).PersonalSale.ToString("C2"))
                item.SubItems.Add(r.Level)
                Me.lvVentasEquipo.Items.Add(item)

                MontoEquipos += rt(Cierre).PersonalSale
                If r.Level = 1 Then
                    If rt(Cierre).PersonalSale >= 499 Then
                        rda += 1
                        rdv += 1
                    Else
                        If rt(Cierre).PersonalSale > 0 Then
                            rdv += 1
                        End If
                    End If
                Else
                    If r.Level > 0 Then
                        If rt(Cierre).PersonalSale >= 499 Then
                            ria += 1
                            riv += 1
                        Else
                            If rt(Cierre).PersonalSale > 0 Then
                                riv += 1
                            End If
                        End If
                    End If
                End If

                'Si el vendedor es nuevo lo agrega al cuadro de nuevos vendedores
                If r.Recruit.EntryPeriod = Cierre Then
                    With r.Recruit
                        Dim nitem As ListViewItem = New ListViewItem(.ContractNumber)
                        nitem.Tag = r.Recruit
                        nitem.SubItems.Add(.FullName)
                        nitem.SubItems.Add(r.Level)
                        item.SubItems.Add(0)
                        nqr += 1

                        Dim PadreEnLista As Boolean = False
                        Dim j As Integer
                        For j = 0 To Me.lvReclutas.Groups.Count - 1
                            If .Sponsor.Equals(Me.lvReclutas.Groups(j).Tag) Then
                                PadreEnLista = True
                                item.Group = Me.lvReclutas.Groups(j)
                            End If
                        Next
                        If Not PadreEnLista Then
                            Dim _group As New ListViewGroup(.Sponsor.FullName)
                            _group.Tag = .Sponsor
                            nitem.Group = _group
                            Me.lvReclutas.Groups.Add(_group)
                        End If
                        Me.lvReclutas.Items.Add(nitem)
                    End With
                End If
            End If
        Next

        Me.txtEstadoVentaGeneracion.Text = MontoEquipos.ToString("C2")
        Me.txtEstadoActivosDirectos.Text = rda
        Me.txtEstadoActivosIndirectos.Text = ria
        Me.txtEstadoDirectoVenta.Text = rdv
        Me.txtEstadoIndirectoVenta.Text = riv
        Me.txtEstadoNuevosReclutas.Text = nqr

        'Metas del vendedor
        Dim goals As New Goals(s)
        If goals(Cierre) Is Nothing Then
            _HasMetas = False
            Me.cmdAgregarMetas.Visible = True
            Me.lbMetas.Text = "No se han agregado metas para este periodo"
        Else
            Dim Nometas As Boolean
            Me.cmdAgregarMetas.Visible = False
            Me.lbMetas.Text = ""
            With goals(Cierre)
                Me.txtMetaVentaPersonal.Text = .PersonalSale.ToString("C2")
                Me.txtMetaVentaGeneracion.Text = .TeamSale.ToString("C2")
                Me.txtMetaNuevosReclutas.Text = .NewRecruits
                Me.txtMetaDirectosActivos.Text = .DirectActiveRecruits
                Me.txtMetaIndirectosActivos.Text = .IndirectActiveRecruits
                Me.txtMetaDirectosVenta.Text = .DirectWithSaleRecruits
                Me.txtMetaIndirectosVenta.Text = .IndirectWithSaleRecruits

                'Evaluacion del Cuadro de metas
                If CType(Me.txtEstadoVentaPersonal.Text, Decimal) < .PersonalSale Then
                    Me.txtMetaVentaPersonal.ForeColor = Color.Red
                    Nometas = True
                End If
                If CType(Me.txtEstadoVentaGeneracion.Text, Decimal) < .TeamSale Then
                    Me.txtMetaVentaGeneracion.ForeColor = Color.Red
                    Nometas = True
                End If
                If CType(Me.txtMetaNuevosReclutas.Text, Decimal) < .NewRecruits Then
                    Me.txtEstadoNuevosReclutas.ForeColor = Color.Red
                    Nometas = True
                End If
                If CType(Me.txtMetaDirectosActivos.Text, Decimal) < .DirectActiveRecruits Then
                    Me.txtMetaDirectosActivos.ForeColor = Color.Red
                    Nometas = True
                End If

                If CType(Me.txtMetaIndirectosActivos.Text, Decimal) < .IndirectActiveRecruits Then
                    Me.txtMetaIndirectosActivos.ForeColor = Color.Red
                    Nometas = True
                End If

                If CType(Me.txtMetaDirectosVenta.Text, Decimal) < .DirectWithSaleRecruits Then
                    Me.txtMetaDirectosVenta.ForeColor = Color.Red
                    Nometas = True
                End If


                If CType(Me.txtMetaIndirectosVenta.Text, Decimal) = .IndirectWithSaleRecruits Then
                    Me.txtMetaIndirectosVenta.ForeColor = Color.Red
                    Nometas = True
                End If
            End With
            If Nometas Then
                Me.lbMetas.Text = "Vendedor no ha alcanzado las metas del periodo"
                Me.lbMetas.ForeColor = Color.Red
            Else
                Me.lbMetas.Text = "Vendedor alcanzo las metas del periodo"
                Me.lbMetas.ForeColor = Color.Green
            End If
        End If

        'Mantenimiento
        Dim SuccessXoption As Integer = 0
        Dim SuccessXOptionAnt As Integer = 0
        Dim OptionToshow As Integer = 0

        With s.CompensationPlanLevel.Maintenance
            Me.Label36.Text = "Metas del Periodo (" + s.CompensationPlanLevel.Description + ")"

            txtMantenimientoVentaPersonal.Text = .PersonalSale.ToString("C2")
            txtMantenimientoVentaGeneracion.Text = .TeamSale.ToString("C2")
            txtMantenimientoNuevosReclutas.Text = .NewRecruits
            txtMantenimientoActivosDirectos.Text = .NewRecruitsQualifiedDirect
            Me.txtMantenimientoActivosIndirectos.Text = .NewRecruitsQualifiedIndirect
            Me.txtMantenimientoConVentaDirectos.Text = .NewRecruitsWithSaleDirect
            Me.txtMantenimientoConVentaIndirectos.Text = .NewRecruitsWithSaleIndirect

            SuccessXoption = 0
            If .PersonalSale <= CType(Me.txtEstadoVentaPersonal.Text, Decimal) Then
                SuccessXoption += 1
            End If
            If .TeamSale <= (CType(Me.txtEstadoVentaPersonal.Text, Decimal) + CType(Me.txtEstadoVentaGeneracion.Text, Decimal)) Then
                SuccessXoption += 1
            End If

            If .NewRecruitsQualifiedDirect <= CType(Me.txtEstadoNuevosReclutas.Text, Decimal) Then
                SuccessXoption += 1
            End If

            If .DirectActiveRecruits <= CType(Me.txtEstadoActivosDirectos.Text, Decimal) Then
                SuccessXoption += 1
            End If

            If .IndirectActiveRecruits <= CType(Me.txtEstadoActivosIndirectos.Text, Decimal) Then
                SuccessXoption += 1
            End If
            If .DirectWithSaleRecruits <= CType(Me.txtEstadoDirectoVenta.Text, Decimal) Then
                SuccessXoption += 1
            End If
            If .IndirectWithSaleRecruits <= CType(Me.txtEstadoIndirectoVenta.Text, Decimal) Then
                SuccessXoption += 1
            End If
            If SuccessXoption > SuccessXOptionAnt Then
                SuccessXOptionAnt = SuccessXoption
                OptionToshow = .Option
            End If
            'Next
            If SuccessXOptionAnt = 0 Then
                OptionToshow = 1
            End If
            'Imagenes de mantenimiendo
            If SuccessXoption >= 7 Then
                pbSucess.Visible = True
                pbNosuccess.Visible = False
            Else
                pbNosuccess.Visible = True
                pbSucess.Visible = False
            End If

        End With




        'Premiate

        'Me.txtPuntosPremiateAcumulados.Text = s(0).PuntosPremiateAcumulados
        'Me.txtPuntosPremiateCamjeados.Text = s(0).PuntosPremiateCanjeados
        'Me.txtPuntosPremiateDisponibles.Text = s(0).PuntosPremiateAcumulados - s(0).PuntosPremiateCanjeados

        'Dim puntos As PuntosPremiate.Business.Premiate

        'puntos = New PuntosPremiate.Business.Premiate(Variables.ConnectionString, 1, montomensual)

        'If puntos.Count > 0 Then
        'Me.txtPuntosCierreActual.Text = puntos(0).puntos
        'End If

        'Circulo de la excelencia

        'Dim circ As CirculosExcelencia.Business.Circulo

        'circ = New CirculosExcelencia.Business.Circulo(Variables.ConnectionString, s(0).Codigo, Cierre - 1)

        'If (circ.Count > 0) Then
        ' Me.txtCirculoNivel.Text = circ(0).NivelCirculo.descripcion
        ' Me.txtCirculosPeriodo.Text = (circ(0).cierre_final - circ(0).cierre_inicio) + 1
        ' End If

        'Obtiene los concursos activos

        'Dim conc As Concursos.Concursos

        'conc = New Concursos.Concursos(Variables.ConnectionString)
        'For i = 0 To conc.Count - 1
        ' Dim item As ListViewItem = New ListViewItem(conc(i).descripcion)
        ' item.SubItems.Add(conc(i).Puntos)
        ' item.SubItems.Add(conc(i).VentaEquipo)

        'Me.lvConcursos.Items.Add(item)

        'Dim item2 As ListViewItem = New ListViewItem("")
        'Dim j As Integer
        ' Dim montototal As Decimal
        ' item2.SubItems.Add(s(0).PuntosPremiatexCierre(conc(i).PeriodoInicio, conc(i).PeriodoCierre))

        'For j = conc(i).PeriodoInicio To conc(i).PeriodoInicio

        'team = New Business.TeamSales(Variables.ConnectionString, s(0).Codigo, j, True)
        'For Each vend As vendedor In team
        'montototal += vend.VentaMensual
        'Next


        'Next
        'item2.SubItems.Add(montototal)
        'Me.lvConcursos.Items.Add(item2)
        'Next

        'documentos

        'Dim doc As DashBoard.DashBoard

        'doc = New DashBoard.DashBoard(Variables.ConnectionString)

        'For Each app As DashBoard.Appointment In doc
        ' Dim item As ListViewItem = New ListViewItem(app.titulo)
        ' item.Tag = app.link
        ''item.ImageKey = app.tipo
        'Me.lvDocumentos.Items.Add(item)
        'Next
    End Sub

    Private Sub cmdAgregarMetas_Click_1(sender As Object, e As EventArgs) Handles cmdAgregarMetas.Click
        Me.txtMetaVentaPersonal.BorderStyle = BorderStyle.Fixed3D
        Me.txtMetaVentaPersonal.Enabled = True
        Me.txtMetaVentaGeneracion.BorderStyle = BorderStyle.Fixed3D
        Me.txtMetaVentaGeneracion.Enabled = True
        Me.txtMetaNuevosReclutas.BorderStyle = BorderStyle.Fixed3D
        Me.txtMetaNuevosReclutas.Enabled = True
        Me.txtMetaDirectosActivos.BorderStyle = BorderStyle.Fixed3D
        Me.txtMetaDirectosActivos.Enabled = True
        Me.txtMetaIndirectosActivos.BorderStyle = BorderStyle.Fixed3D
        Me.txtMetaIndirectosActivos.Enabled = True
        Me.txtMetaDirectosVenta.BorderStyle = BorderStyle.Fixed3D
        Me.txtMetaDirectosVenta.Enabled = True

        Me.txtMetaIndirectosVenta.BorderStyle = BorderStyle.Fixed3D
        Me.txtMetaIndirectosVenta.Enabled = True

        Me.txtMetaVentaPersonal.Focus()

        Me.cmdGuardar.Visible = True
        Me.cmdAgregarMetas.Visible = False
    End Sub

    Private Sub cmdGuardar_Click_1(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        Dim meta As New SalesSummary.PeriodGoals

        If txtMetaVentaPersonal.Text = "" Then Me.txtMetaVentaPersonal.Text = 0
        If Me.txtMetaVentaGeneracion.Text = "" Then Me.txtMetaVentaGeneracion.Text = 0
        If Me.txtMetaNuevosReclutas.Text = "" Then Me.txtMetaNuevosReclutas.Text = 0
        If Me.txtMetaDirectosActivos.Text = "" Then Me.txtMetaDirectosActivos.Text = 0
        If Me.txtMetaIndirectosActivos.Text = "" Then Me.txtMetaIndirectosActivos.Text = 0
        If Me.txtMetaDirectosVenta.Text = "" Then Me.txtMetaDirectosVenta.Text = 0
        If Me.txtMetaIndirectosVenta.Text = "" Then Me.txtMetaIndirectosVenta.Text = 0

        With meta
            .SalesManId = CodigoVendedor
            .PersonalSale = Convert.ToDecimal(Me.txtMetaVentaPersonal.Text)
            .TeamSale = Convert.ToDecimal(Me.txtMetaVentaGeneracion.Text)
            .NewRecruits = Convert.ToInt32(Me.txtMetaNuevosReclutas.Text)
            .DirectActiveRecruits = Convert.ToInt32(Me.txtMetaDirectosActivos.Text)
            .IndirectActiveRecruits = Convert.ToInt32(Me.txtMetaIndirectosActivos.Text)
            .DirectWithSaleRecruits = Convert.ToInt32(Me.txtMetaDirectosVenta.Text)
            .IndirectWithSaleRecruits = Convert.ToInt32(Me.txtMetaIndirectosVenta.Text)
            .PeriodNumber = Cierre
        End With

        Dim metas As New SalesSummary.Goals(s)
        metas.Add(meta)


        MessageBox.Show("Se agregaron correctamente las metas para este periodo", "Servicioalcliente", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me._HasMetas = True
        Me.cmdGuardar.Visible = False

        Me.txtMetaVentaPersonal.BorderStyle = BorderStyle.None
        Me.txtMetaVentaPersonal.Enabled = False
        Me.txtMetaVentaGeneracion.BorderStyle = BorderStyle.None
        Me.txtMetaVentaGeneracion.Enabled = False
        Me.txtMetaNuevosReclutas.BorderStyle = BorderStyle.None
        Me.txtMetaNuevosReclutas.Enabled = False
        Me.txtMetaDirectosActivos.BorderStyle = BorderStyle.None
        Me.txtMetaDirectosActivos.Enabled = False
        Me.txtMetaIndirectosActivos.BorderStyle = BorderStyle.None
        Me.txtMetaIndirectosActivos.Enabled = False
        Me.txtMetaDirectosVenta.BorderStyle = BorderStyle.None
        Me.txtMetaDirectosVenta.Enabled = False

        Me.txtMetaIndirectosVenta.BorderStyle = BorderStyle.None
        Me.txtMetaIndirectosVenta.Enabled = False
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = 1 Then
            Me.lvActividades.Items.Clear()
            'cargas las actividades a las que a asistido el vendedor
            Dim acts As MonthlyMeetingLib.Meetings = New MonthlyMeetingLib.Meetings
            For Each m As MonthlyMeetingLib.MonthlyMeeting In acts.getAttendMeetings(s)
                Dim item As ListViewItem = New ListViewItem(m.Date)
                item.SubItems.Add(m.Description + " (" + m.Location + ") ")

                Me.lvActividades.Items.Add(item)
            Next
            Me.lvActividades.Visible = True
        End If
    End Sub

    Private Sub KryptonButton1_Click(sender As Object, e As EventArgs) Handles KryptonButton1.Click
        If Me.txtTelefono01.Text.Length > 0 Then
            Dim phone As PhoneManager = New PhoneManager(Variables.IpPhoneAdress, "admin")

            Try
                phone.MakeaCall("9" + txtTelefono01.Text)
            Catch ex As CTIException
                MessageBox.Show("No se pudo inicair la llamada " + ex.Message)
            End Try
        End If
    End Sub

    Private Sub KryptonButton2_Click(sender As Object, e As EventArgs) Handles KryptonButton2.Click
        If Me.txtTelefono2.Text.Length > 0 Then
            Dim phone As PhoneManager = New PhoneManager(Variables.IpPhoneAdress, "admin")

            Try
                phone.MakeaCall("9" + Me.txtTelefono2.Text)
            Catch ex As CTIException
                MessageBox.Show("No se pudo inicair la llamada " + ex.Message)
            End Try
        End If
    End Sub

    Private Function CheckIfRunning(sProcessName As String) As Process

        Try
            Dim listProc() As System.Diagnostics.Process
            listProc = System.Diagnostics.Process.GetProcessesByName(sProcessName)
            If listProc.Length > 0 Then
                ' Process is running
                Return listProc(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing

        End Try

    End Function

    Private Sub KryptonButton3_Click(sender As Object, e As EventArgs) Handles KryptonButton3.Click
        Dim pr As Process = CheckIfRunning("WhatsApp")
        If pr Is Nothing Then
            MessageBox.Show("La aplicacion de WhatsApp no se encuentra en ejecucion")
            Exit Sub
        End If
        Dim telefono As String = ""

        If Not Me.txtTelefono2.Text.StartsWith("2") And Me.txtTelefono2.Text.Length > 0 Then
            telefono = Me.txtTelefono2.Text
        End If

        If telefono.Length = 0 Then Exit Sub



        Try
            If Pais = "CR" Then
                System.Diagnostics.Process.Start("whatsapp://send?phone=506" + telefono.Replace("-", ""))
            Else
                System.Diagnostics.Process.Start("whatsapp://send?phone=507" + telefono.Replace("-", ""))
            End If
        Catch ex As Exception
            MsgBox("No se pudo efectuar la operacion " + ex.Message)
        End Try

    End Sub

    Private Sub KryptonButton4_Click(sender As Object, e As EventArgs) Handles KryptonButton4.Click
        Dim pr As Process = CheckIfRunning("WhatsApp")
        If pr Is Nothing Then
            MessageBox.Show("La aplicacion de WhatsApp no se encuentra en ejecucion")
            Exit Sub
        End If
        Dim telefono As String = ""


        telefono = Me.txtTelefono01.Text


        If telefono.Length = 0 Then Exit Sub



        Try
            If Pais = "CR" Then
                System.Diagnostics.Process.Start("whatsapp://send?phone=506" + telefono.Replace("-", ""))
            Else
                System.Diagnostics.Process.Start("whatsapp://send?phone=507" + telefono.Replace("-", ""))
            End If
        Catch ex As Exception
            MsgBox("No se pudo efectuar la operacion " + ex.Message)
        End Try
    End Sub
End Class
