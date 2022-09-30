Option Strict Off
Option Explicit On
Public Class Orders
    '----------------------------------------------------------------------------------------
    'Descripcion:
    'Objeto de la capa de negocios, encargado de realizar las operaciones consernientes a
    'las ordenes de pedido.
    'Autor: Diego Martinez Cedeño
    '-----------------------------------------------------------------------------------
    'Efecto: Conexion con el objeto de la capa de acceso a datos para leer la informacion
    '       de una orden de pedido.
    Private data As OrdersAD = Nothing
    Private c As LayerClients.Clients = Nothing             'Referencia al objeto cliente
    Private v As LayerSellers.Sellers = Nothing             'Referencia al objeto vendedor
    Private tp As LayerOrders.TypeOrder
    Private td As LayerOrders.TypeDiscount = Nothing
    Private pr As LayerOrders.Promocion = Nothing
    Private art As LayerOrders.OrdersItems = Nothing
    Private pag As LayerPayments.Payments = Nothing
    Private ReadyClients As Boolean = False
    Private ReadySellers As Boolean = False
    Private ReadyTypeOrder As Boolean = False
    Private ReadyTypeDiscount As Boolean = False
    Private ReadyPromocion As Boolean = False
    Private ReadyItems As Boolean = False
    Private ReadyPag As Boolean = False
    Private p, u, s As String
    Private Key As String = ""
    Public Sub New()
        data = New OrdersAD
    End Sub
    Public Sub New(ByRef Connection As SqlClient.SqlConnection)
        data = New OrdersAD
        data.Connection = Connection
    End Sub
    Public WriteOnly Property Connection() As SqlClient.SqlConnection
        Set(ByVal value As SqlClient.SqlConnection)
            data.Connection = value
        End Set
    End Property
    '--------------------------------------------------------------------------------------
    'Efecto: Carga los datos desde la base de datos
    'Requiere: o numero de orden que se va a cargar
    'Modifica: varible local order
    '---------------------------------------------------------------------------------------
    Public Sub Order(ByRef factura As String, Optional ByRef showNull As Boolean = False)
        Key = factura
        data.AddFilter(OrdersAD.TableColumns.Factura, "=", factura)
        data.FillTable()
        ReadyClients = False
        ReadySellers = False
    End Sub
    Public Sub OrderByClient(ByRef Cliente As String, Optional ByVal WithSaldo As Boolean = False)
        If Cliente <> "" Then
            data.AddFilter(OrdersAD.TableColumns.CodigoCliente, "=", Cliente)
        End If
        If WithSaldo Then
            data.AddFilter(OrdersAD.TableColumns.SaldoFactura, ">", 0)
        End If
        data.AddFilter(OrdersAD.TableColumns.Estado, "<>", 4)
        data.AddFilter(OrdersAD.TableColumns.TipoFactura, "<", 3)
        data.FillReader()
        ReadyClients = False
        ReadySellers = False
        ReadyItems = False
    End Sub
    Public Sub OrderBySalesMan(ByRef SalesMan As String, Optional ByVal cierre As Integer = 0)
        If SalesMan <> "" Then
            data.AddFilter(OrdersAD.TableColumns.Vendedor, "=", SalesMan)
        End If
        If cierre <> 0 Then
            data.AddFilter(OrdersAD.TableColumns.Cierre, "=", cierre)

        End If
        data.AddFilter(OrdersAD.TableColumns.Estado, "<>", 4)
        data.AddFilter(OrdersAD.TableColumns.TipoFactura, "<", 3)
        data.FillTable()
        ReadyClients = False
        ReadySellers = False
    End Sub
    Public Sub OrderBySalesManTrans(ByRef SalesMan As String, Optional ByVal cierre As Integer = 0)
        If SalesMan <> "" Then
            data.AddFilter(OrdersAD.TableColumns.Vendedor, "=", SalesMan)
        End If
        data.AddFilter(OrdersAD.TableColumns.Estado, "<>", 4)
        data.AddFilter(OrdersAD.TableColumns.TipoFactura, "<", 3)
        data.AddFilter(OrdersAD.TableColumns.FechaAño, "=", Now.Year)
        data.AddFilter(OrdersAD.TableColumns.FechaVencimiento, ">", Now.AddMonths(-1).ToShortDateString)
        data.AddFilter(OrdersAD.TableColumns.Cierre, "=", 0)
        data.FillTable()
        ReadyClients = False
        ReadySellers = False
    End Sub
    Public Sub OrdersCandeladas()

        data.AddFilter(OrdersAD.TableColumns.Estado, "<>", 4)
        data.AddFilter(OrdersAD.TableColumns.TipoFactura, "<", 3)
        data.AddFilter(OrdersAD.TableColumns.SaldoFactura, "=", 0)
        data.AddFilter(OrdersAD.TableColumns.PostVenta, "=", 0)
        data.AddOrder(OrdersAD.TableColumns.FechaUltimoPago, OrdersAD.Orden.Descending)
        data.FillReader()
        ReadyClients = False
        ReadySellers = False
    End Sub

    Public Sub GarantiaByClient(ByRef c As String)
        If c <> "" Then
            data.AddFilter(OrdersAD.TableColumns.CodigoCliente, "=", c)
        End If
        data.AddFilter(OrdersAD.TableColumns.Estado, "<>", 4)
        data.AddFilter(OrdersAD.TableColumns.TipoFactura, "=", 4)
        data.FillTable()
        ReadyClients = False
        ReadySellers = False
    End Sub
    'Public Sub OrderExpired()
    '    data.AddFilter(OrdersAD.TableOrdersFields.odEstado, OrdersAD.OrderSymbol.NotEqualNUM, CStr(4))
    '    data.AddFilter(OrdersAD.TableOrdersFields.odSaldoFactura, OrdersAD.OrderSymbol.MayorThan, CStr(1))
    '    data.AddFilter(OrdersAD.TableOrdersFields.odFechaVencimiento, OrdersAD.OrderSymbol.LessDT, CStr(Today))
    '    data.AddFilter(OrdersAD.TableOrdersFields.odTipo, OrdersAD.OrderSymbol.Less, CStr(4))
    '    data.AddOrder(OrdersAD.TableOrdersFields.odFechaVencimiento)
    '    data.AddOrder(OrdersAD.TableOrdersFields.odCliente)
    '    data.AddOrder(OrdersAD.TableOrdersFields.odVendedor)
    '    data.Read()
    '    ReadyClients = False
    '    ReadySellers = False
    '    index = 1
    'End Sub
    'Public Function ExistOrder(ByRef o As String) As Boolean
    '    ExistOrder = data.Exist(o)
    '    'UPGRADE_NOTE: Object data may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
    '    data = Nothing
    'End Function

    'Public Sub OrdersOfClient(ByRef c As String)
    '    'UPGRADE_NOTE: Object data may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
    '    data = Nothing
    '    data = New OrdersAD
    '    Call data.AddFilter((OrdersAD.TableOrdersFields.odCliente), (OrdersAD.OrderSymbol.EqualCHR), c)
    '    Call data.AddFilter((OrdersAD.TableOrdersFields.odTipo), (OrdersAD.OrderSymbol.Less), CStr(3))
    '    data.Read()
    '    ReadyClients = False
    '    index = 1
    'End Sub
    'Public Sub OrdersOfReferenceStudy(ByRef c As String)
    '    data.ClearFilter()
    '    Call data.AddFilter((OrdersAD.TableOrdersFields.odCliente), (OrdersAD.OrderSymbol.EqualCHR), c)
    '    Call data.AddFilter((OrdersAD.TableOrdersFields.odEstado), (OrdersAD.OrderSymbol.NotEqualNUM), CStr(4))
    '    Call data.AddFilter((OrdersAD.TableOrdersFields.odTipo), (OrdersAD.OrderSymbol.Less), CStr(3))
    '    Call data.AddFilter((OrdersAD.TableOrdersFields.odFechaVencimiento), (OrdersAD.OrderSymbol.LessDT), CStr(Today))
    '    data.Read()
    '    ReadyClients = False
    '    index = 1
    'End Sub
    'Public Sub OrdersWithoutOut(ByRef c As String)
    '    data.ClearFilter()
    '    Call data.AddFilter((OrdersAD.TableOrdersFields.odCliente), (OrdersAD.OrderSymbol.EqualCHR), c)
    '    Call data.AddFilter((OrdersAD.TableOrdersFields.odEstado), (OrdersAD.OrderSymbol.NotEqualNUM), CStr(4))
    '    Call data.AddFilter((OrdersAD.TableOrdersFields.odTipo), (OrdersAD.OrderSymbol.Less), CStr(3))
    '    Call data.AddFilter(OrdersAD.TableOrdersFields.odAprobadoDespacho, OrdersAD.OrderSymbol.EqualNUM, CStr(0))
    '    data.Read()
    '    ReadyClients = False
    '    index = 1
    'End Sub
    Public Function OrdersCount() As Short
        OrdersCount = data.Count
    End Function
    Public ReadOnly Property Factura(Optional ByVal i As Short = 0) As String
        Get
            Factura = data.Column(OrdersAD.TableColumns.Factura).Value(i)
            If Factura <> Key Then
                ReadyClients = False
                ReadySellers = False
                ReadyTypeOrder = False
                ReadyItems = False
                ReadyTypeDiscount = False
                ReadyPromocion = False
                Key = Factura
            End If
        End Get
    End Property
    Public ReadOnly Property Cliente(Optional ByVal i As Short = 0) As LayerClients.Clients
        Get
            If Not ReadyClients Then
                c = New LayerClients.Clients
                c.SetConnection(data.Connection)
                c.Clients(data.Column(OrdersAD.TableColumns.CodigoCliente).Value(i))
                ReadyClients = True
            End If
            Cliente = c
        End Get
    End Property
    Public ReadOnly Property Vendedor(Optional ByVal i As Short = 0) As LayerSellers.Sellers
        Get
            If Not ReadySellers Then
                v = New LayerSellers.Sellers
                v.SetConnection(data.Connection)
                v.SetCodeSeller(data.Column(OrdersAD.TableColumns.Vendedor).Value(i))
                v.GetInformation()
                ReadySellers = True
            End If
            Vendedor = v
        End Get
    End Property
    Public ReadOnly Property Tipo(Optional ByVal i As Short = 0) As LayerOrders.TypeOrder
        Get
            If Not ReadyTypeOrder Then
                tp = New LayerOrders.TypeOrder
                tp.SetConnection(data.Connection)
                tp.TypeOrder(data.Column(OrdersAD.TableColumns.TipoFactura).Value(i))
                ReadyTypeOrder = True
            End If
            Tipo = tp
        End Get
    End Property
    Public ReadOnly Property TipoDescuento(Optional ByVal i As Short = 0) As LayerOrders.TypeDiscount
        Get
            Dim descuento As Integer
            descuento = data.Column(OrdersAD.TableColumns.TipoDescuento).Value(i)
            If Not ReadyTypeDiscount Then
                td = New LayerOrders.TypeDiscount
                td.SetConnection(data.Connection)
                td.TypeDiscount(descuento)
                ReadyTypeDiscount = True
            End If
            Return td
        End Get
    End Property
    Public ReadOnly Property Articulos(Optional ByVal i As Short = 0) As LayerOrders.OrdersItems
        Get
            Dim factura As String
            If Not ReadyItems Then
                factura = data.Column(OrdersAD.TableColumns.Factura).Value(i)
                art = New LayerOrders.OrdersItems(factura, data.Connection)
                ReadyItems = True
            End If
            Return art
        End Get
    End Property
    Public ReadOnly Property Pagos(Optional ByVal i As Short = 0) As LayerPayments.Payments
        Get
            Dim factura As String
            If Not ReadyPag Then
                factura = data.Column(OrdersAD.TableColumns.Factura).Value(i)
                pag = New LayerPayments.Payments(factura)
                pag.SetConnection(data.Connection)
                pag.Load()
                ReadyPag = True
            End If
            Return pag
        End Get
    End Property
    Public ReadOnly Property Promocion(Optional ByVal i As Short = 0) As LayerOrders.Promocion
        Get
            Dim pro As String = data.Column(OrdersAD.TableColumns.Promocion).Value(i)
            If Not ReadyPromocion Then
                pr = New LayerOrders.Promocion
                pr.SetConnection(data.Connection)
                If pro <> "" Then
                    pr.Promocion(pro)
                End If
                ReadyPromocion = True
            End If
            Return pr
        End Get
    End Property
    Public ReadOnly Property Fecha(Optional ByVal i As Short = 0) As Object
        Get
            Fecha = data.Column(OrdersAD.TableColumns.Fecha).Value(i)
        End Get
    End Property
    Public ReadOnly Property Fecha_Vencimiento(Optional ByVal i As Short = 0) As Object
        Get
            Fecha_Vencimiento = data.Column(OrdersAD.TableColumns.FechaVencimiento).Value(i)
        End Get
    End Property
    Public ReadOnly Property Fecha_ult_pago(Optional ByVal i As Short = 0) As Object
        Get
            Fecha_ult_pago = data.Column(OrdersAD.TableColumns.FechaUltimoPago).Value(i)
        End Get
    End Property
    Public ReadOnly Property Cobrador(Optional ByVal i As Short = 0) As Object
        Get
            Cobrador = data.Column(OrdersAD.TableColumns.Cobrador).Value(i)
        End Get
    End Property
    Public ReadOnly Property MontoTotal(Optional ByVal i As Short = 0) As Decimal
        Get
            MontoTotal = data.Column(OrdersAD.TableColumns.MontoTotal).Value(i)
        End Get
    End Property
    Public ReadOnly Property SaldoFactura(Optional ByVal i As Short = 0) As Decimal
        Get
            SaldoFactura = data.Column(OrdersAD.TableColumns.SaldoFactura).Value(i)
        End Get
    End Property
    Public ReadOnly Property MontoAbonado(Optional ByVal i As Short = 0) As Decimal
        Get
            MontoAbonado = MontoTotal(i) - SaldoFactura(i)
        End Get
    End Property
    Public ReadOnly Property CuotaMensual(Optional ByVal i As Short = 0) As Decimal
        Get
            CuotaMensual = System.Math.Round(MontoTotal(i) / CDbl(Plazo(i)), 2)
        End Get
    End Property
    Public ReadOnly Property CuotasCanceladas(Optional ByVal i As Short = 0) As Double
        Get
            CuotasCanceladas = System.Math.Round(MontoAbonado(i) / CuotaMensual(i), 4)
        End Get
    End Property
    Public ReadOnly Property Referencia(Optional ByVal i As Short = 0) As String
        Get
            Referencia = data.Column(OrdersAD.TableColumns.Referencia).Value(i)
        End Get
    End Property
    Public ReadOnly Property Plazo(Optional ByVal i As Short = 0) As String
        Get
            Plazo = data.Column(OrdersAD.TableColumns.MesesPlazo).Value(i)
        End Get
    End Property
    Public ReadOnly Property Bodega(Optional ByVal i As Short = 0) As String
        Get
            Bodega = data.Column(OrdersAD.TableColumns.Bodega).Value(i)
        End Get
    End Property
    Public ReadOnly Property EstadoDespacho(Optional ByVal i As Short = 0) As Short
        Get
            EstadoDespacho = data.Column(OrdersAD.TableColumns.EstadoEntrega).Value(i)
        End Get
    End Property
    Public ReadOnly Property DescripcionDespacho(Optional ByVal i As Short = 0) As String
        Get
            Dim fecha_Salida As String
            If EstadoDespacho(i) = 0 Then
                DescripcionDespacho = "Salida Pendiente"
            Else
                If IsDBNull(FechaDespacho(i)) Then
                    fecha_Salida = "No determinada"
                Else
                    fecha_Salida = CStr(FechaDespacho(i))
                End If
                Select Case FormaDespacho
                    Case 1 : DescripcionDespacho = "(50%) Completado"
                    Case 2 : DescripcionDespacho = "Salida Especial"
                    Case 3 : DescripcionDespacho = "Credito Aprobado"
                    Case Else : DescripcionDespacho = "No determinado"
                End Select
            End If
        End Get
    End Property
    Public ReadOnly Property FechaDespacho(Optional ByVal i As Short = 0) As Date
        Get
            FechaDespacho = data.Column(OrdersAD.TableColumns.FechaSalida).Value(i)
        End Get
    End Property
    Public ReadOnly Property FormaDespacho(Optional ByVal i As Short = 0) As Short
        Get
            FormaDespacho = data.Column(OrdersAD.TableColumns.FormaDespacho).Value(i)
        End Get
    End Property
    Public ReadOnly Property DespachadoPor(Optional ByVal i As Short = 0) As String
        Get
            DespachadoPor = data.Column(OrdersAD.TableColumns.DespachadoPor).Value(i)
        End Get
    End Property
    Public ReadOnly Property MontoDespacho(Optional ByVal i As Short = 0) As Decimal
        Get
            MontoDespacho = System.Math.Round(MontoTotal(i) / 2, 1)
            If MontoDespacho > MontoAbonado(i) Then
                MontoDespacho = MontoDespacho - MontoAbonado(i)
            End If
        End Get
    End Property
    Public ReadOnly Property SaldoDespacho(Optional ByVal i As Short = 0) As Decimal
        Get
            If MontoDespacho(i) > MontoAbonado(i) Then
                SaldoDespacho = MontoDespacho(i) - MontoAbonado(i)
            Else
                SaldoDespacho = 0
            End If
        End Get
    End Property
    Public ReadOnly Property SaldoSinIntereses(Optional ByVal i As Short = 0) As Decimal
        Get
            SaldoSinIntereses = SaldoFactura(i) - MontoIntereses(i)
        End Get
    End Property
    Public ReadOnly Property MontoIntereses(Optional ByVal i As Short = 0) As Decimal
        Get
            MontoIntereses = data.Column(OrdersAD.TableColumns.MontoIntereses).Value(i)
        End Get
    End Property
    Public ReadOnly Property MontoTransporte(Optional ByVal i As Short = 0) As Decimal
        Get
            MontoTransporte = data.Column(OrdersAD.TableColumns.MontoTransporte).Value(i)
        End Get
    End Property
    Public ReadOnly Property MontoBruto(Optional ByVal i As Short = 0) As Decimal
        Get
            MontoBruto = data.Column(OrdersAD.TableColumns.MontoBruto).Value(i)
        End Get
    End Property
    Public ReadOnly Property Linea1(Optional ByVal i As Short = 0) As Decimal
        Get
            Return data.Column(OrdersAD.TableColumns.Linea1).Value(i)
        End Get
    End Property
    Public ReadOnly Property TotalImpuesto(Optional ByVal i As Short = 0) As Decimal
        Get
            TotalImpuesto = data.Column(OrdersAD.TableColumns.ImpuestoVentas).Value(i)
        End Get
    End Property
    Public ReadOnly Property TotalDescuento(Optional ByVal i As Short = 0) As Decimal
        Get
            TotalDescuento = data.Column(OrdersAD.TableColumns.Descuento).Value(i)
        End Get
    End Property
    Public ReadOnly Property Observaciones(Optional ByVal i As Short = 0) As String
        Get
            Observaciones = data.Column(OrdersAD.TableColumns.Observacion).Value(i)
        End Get
    End Property
    Public ReadOnly Property EstadoEntrega(Optional ByVal i As Short = 0) As Short
        Get
            EstadoEntrega = data.Column(OrdersAD.TableColumns.EstadoEntrega).Value(i)
        End Get
    End Property
    Public ReadOnly Property MonthsExpired(Optional ByVal i As Short = 0) As Short
        Get
            Dim fecha As Date
            fecha = data.Column(OrdersAD.TableColumns.FechaVencimiento).Value(i)
            MonthsExpired = DateDiff(Microsoft.VisualBasic.DateInterval.Month, fecha, Today)
        End Get
    End Property
End Class