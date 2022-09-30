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
    Private c As LayerClients.Clients = Nothing
    Private v As LayerSellers.Sellers = Nothing
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
    Private index As Short
    Private p, u, s As String
    Private dbtemp As SqlClient.SqlConnection
    Private Key As String = ""
    Public Sub New()
        MyBase.New()
        data = New OrdersAD

    End Sub
    Public Sub SetDataBaseLogon(ByRef User As String, ByRef Password As String, Optional ByRef server As String = "Sakif")
        u = User
        p = Password
        s = server
        data.Usuario = u
        data.Password = p
        data.Servidor = s
    End Sub
    Public Sub SetConnection(ByRef cnn As SqlClient.SqlConnection)
        data.Connection(cnn)
    End Sub
    '--------------------------------------------------------------------------------------
    'Efecto: Carga los datos desde la base de datos
    'Requiere: o numero de orden que se va a cargar
    'Modifica: varible local order
    '---------------------------------------------------------------------------------------
    Public Sub Order(ByRef factura As String, Optional ByRef showNull As Boolean = False)
        Key = factura
        data.Read(factura)
        ReadyClients = False
        ReadySellers = False
    End Sub
    Public Sub OrderByClient(ByRef Cliente As String, Optional ByVal WithSaldo As Boolean = False)
        If Cliente <> "" Then
            Call data.AddFilter((OrdersAD.TableOrdersFields.odCliente), (OrdersAD.OrderSymbol.EqualCHR), Cliente)
        End If
        If WithSaldo Then
            data.AddFilter(OrdersAD.TableOrdersFields.odSaldoFactura, OrdersAD.OrderSymbol.MayorThan, 0)
        End If
        data.AddFilter(OrdersAD.TableOrdersFields.odEstado, OrdersAD.OrderSymbol.NotEqualNUM, CStr(4))
        data.AddFilter(OrdersAD.TableOrdersFields.odTipo, OrdersAD.OrderSymbol.Less, 3)
        data.Read()
        ReadyClients = False
        ReadySellers = False
        index = 1
    End Sub
    Public Sub OrderBySalesMan(ByRef SalesMan As String, Optional ByVal cierre As Integer = 0)
        data.ClearFilter()
        If SalesMan <> "" Then
            Call data.AddFilter(OrdersAD.TableOrdersFields.odVendedor, OrdersAD.OrderSymbol.EqualCHR, SalesMan)
        End If
        If cierre <> 0 Then
            Call data.AddFilter(OrdersAD.TableOrdersFields.odCierre, OrdersAD.OrderSymbol.EqualNUM, cierre)
        End If
        data.AddFilter(OrdersAD.TableOrdersFields.odEstado, OrdersAD.OrderSymbol.NotEqualNUM, CStr(4))
        data.AddFilter(OrdersAD.TableOrdersFields.odTipo, OrdersAD.OrderSymbol.Less, 3)
        data.Read()
        ReadyClients = False
        ReadySellers = False
        index = 1
    End Sub
    Public Sub OrderBySalesManTrans(ByRef SalesMan As String, Optional ByVal cierre As Integer = 0)
        data.ClearFilter()
        If SalesMan <> "" Then
            Call data.AddFilter(OrdersAD.TableOrdersFields.odVendedor, OrdersAD.OrderSymbol.EqualCHR, SalesMan)
        End If
        data.AddFilter(OrdersAD.TableOrdersFields.odEstado, OrdersAD.OrderSymbol.NotEqualNUM, CStr(4))
        data.AddFilter(OrdersAD.TableOrdersFields.odTipo, OrdersAD.OrderSymbol.Less, 3)
        data.AddFilter(OrdersAD.TableOrdersFields.odFechaAño, OrdersAD.OrderSymbol.EqualNUM, Now.Year)
        data.AddFilter(OrdersAD.TableOrdersFields.odFechaVencimiento, OrdersAD.OrderSymbol.MayorDT, Now.ToShortDateString)
        data.AddFilter(OrdersAD.TableOrdersFields.odCierre, OrdersAD.OrderSymbol.EqualNUM, 0)
        data.Read()
        ReadyClients = False
        ReadySellers = False
        index = 1
    End Sub
    Public Sub GarantiaByClient(ByRef c As String)
        If c <> "" Then
            Call data.AddFilter((OrdersAD.TableOrdersFields.odCliente), (OrdersAD.OrderSymbol.EqualCHR), c)
        End If
        data.AddFilter(OrdersAD.TableOrdersFields.odEstado, OrdersAD.OrderSymbol.NotEqualNUM, CStr(4))
        data.AddFilter(OrdersAD.TableOrdersFields.odTipo, OrdersAD.OrderSymbol.EqualNUM, 4)
        data.Read()
        ReadyClients = False
        ReadySellers = False
        index = 1
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
        OrdersCount = data.RowCount
    End Function
    Public ReadOnly Property Factura(Optional ByVal i As Short = 1) As String
        Get
            Factura = data.ValueAt((OrdersAD.TableOrdersFields.odFactura), i)
            If Factura <> Key Then
                ReadyClients = False
                ReadySellers = False
                ReadyTypeOrder = False
                Key = Factura
            End If
        End Get
    End Property
    Public ReadOnly Property Cliente(Optional ByVal i As Short = 1) As LayerClients.Clients
        Get
            If Not ReadyClients Then
                c = New LayerClients.Clients
                c.SetConnection(dbtemp)
                c.Clients((data.ValueAt((OrdersAD.TableOrdersFields.odCliente), i)))
                ReadyClients = True
            End If
            Cliente = c
        End Get
    End Property
    Public ReadOnly Property Vendedor(Optional ByVal i As Short = 1) As LayerSellers.Sellers
        Get
            If Not ReadySellers Then
                v = New LayerSellers.Sellers
                v.SetConnection(dbtemp)
                v.Seller((data.ValueAt((OrdersAD.TableOrdersFields.odVendedor), i)))
                ReadySellers = True
            End If
            Vendedor = v
        End Get
    End Property
    Public ReadOnly Property Tipo(Optional ByVal i As Short = 1) As LayerOrders.TypeOrder
        Get
            If Not ReadyTypeOrder Then
                tp = New LayerOrders.TypeOrder
                tp.SetConnection(dbtemp)
                tp.TypeOrder(data.ValueAt((OrdersAD.TableOrdersFields.odTipo), i))
                ReadyTypeOrder = True
            End If
            Tipo = tp
        End Get
    End Property
    Public ReadOnly Property TipoDescuento(Optional ByVal i As Short = 1) As LayerOrders.TypeDiscount
        Get
            Dim descuento As Integer
            descuento = data.ValueAt(LayerOrders.OrdersAD.TableOrdersFields.odTipoDescuento, i)
            If Not ReadyTypeDiscount Then
                td = New LayerOrders.TypeDiscount
                td.SetConnection(dbtemp)
                td.TypeDiscount(descuento)
                ReadyTypeDiscount = True
            End If
            Return td
        End Get
    End Property
    Public ReadOnly Property Articulos(Optional ByVal i As Short = 1) As LayerOrders.OrdersItems
        Get
            Dim factura As String

            factura = data.ValueAt(LayerOrders.OrdersAD.TableOrdersFields.odFactura, i)
            art = New LayerOrders.OrdersItems(factura, dbtemp)

            Return art
        End Get
    End Property
    Public ReadOnly Property Pagos(Optional ByVal i As Short = 1) As LayerPayments.Payments
        Get
            Dim factura As String
            If Not ReadyPag Then
                factura = data.ValueAt(LayerOrders.OrdersAD.TableOrdersFields.odFactura, i)
                pag = New LayerPayments.Payments(factura)
                pag.SetDataBaseLogon(u, p, s)
                pag.Load()
                ReadyPag = True
            End If
            Return pag
        End Get
    End Property
    Public ReadOnly Property Promocion(Optional ByVal i As Short = 1) As LayerOrders.Promocion
        Get
            Dim pro As String = data.ValueAt(LayerOrders.OrdersAD.TableOrdersFields.odPromocion, i)
            If Not ReadyPromocion Then
                pr = New LayerOrders.Promocion
                pr.SetDataBaseLogon(u, p, s)
                If pro <> "" Then
                    pr.Promocion(pro)
                End If
                ReadyPromocion = True
            End If
            Return pr
        End Get
    End Property
    Public ReadOnly Property Fecha(Optional ByVal i As Short = 1) As Object
        Get
            Fecha = data.ValueAt((OrdersAD.TableOrdersFields.odfecha), i)
        End Get
    End Property
    Public ReadOnly Property Fecha_Vencimiento(Optional ByVal i As Short = 1) As Object
        Get
            Fecha_Vencimiento = data.ValueAt((OrdersAD.TableOrdersFields.odFechaVencimiento), i)
        End Get
    End Property
    Public ReadOnly Property Fecha_ult_pago(Optional ByVal i As Short = 1) As Object
        Get
            Fecha_ult_pago = data.ValueAt((OrdersAD.TableOrdersFields.odFechaUltPago), i)
        End Get
    End Property
    Public ReadOnly Property Cobrador(Optional ByVal i As Short = 1) As Object
        Get
            Cobrador = data.ValueAt((OrdersAD.TableOrdersFields.odCobrador), i)
        End Get
    End Property
    Public ReadOnly Property MontoTotal(Optional ByVal i As Short = 1) As Decimal
        Get
            MontoTotal = data.ValueAt((OrdersAD.TableOrdersFields.odMontoTotal), i)
        End Get
    End Property
    Public ReadOnly Property SaldoFactura(Optional ByVal i As Short = 1) As Decimal
        Get
            SaldoFactura = data.ValueAt((OrdersAD.TableOrdersFields.odSaldoFactura), i)
        End Get
    End Property
    Public ReadOnly Property MontoAbonado(Optional ByVal i As Short = 1) As Decimal
        Get
            MontoAbonado = MontoTotal - SaldoFactura
        End Get
    End Property
    Public ReadOnly Property CuotaMensual(Optional ByVal i As Short = 1) As Decimal
        Get
            CuotaMensual = System.Math.Round(MontoTotal / CDbl(Plazo), 2)
        End Get
    End Property
    Public ReadOnly Property CuotasCanceladas(Optional ByVal i As Short = 1) As Double
        Get
            CuotasCanceladas = System.Math.Round(MontoAbonado / CuotaMensual, 4)
        End Get
    End Property
    Public ReadOnly Property Referencia(Optional ByVal i As Short = 1) As String
        Get
            Referencia = data.ValueAt((OrdersAD.TableOrdersFields.odReferencia), i)
        End Get
    End Property
    Public ReadOnly Property Plazo(Optional ByVal i As Short = 1) As String
        Get
            Plazo = data.ValueAt(OrdersAD.TableOrdersFields.odPlazo)
        End Get
    End Property
    Public ReadOnly Property Bodega(Optional ByVal i As Short = 1) As String
        Get
            Bodega = data.ValueAt((OrdersAD.TableOrdersFields.odBodega), i)
        End Get
    End Property
    Public ReadOnly Property EstadoDespacho(Optional ByVal i As Short = 1) As Short
        Get
            EstadoDespacho = CShort(data.ValueAt((OrdersAD.TableOrdersFields.odAprobadoDespacho), i))
        End Get
    End Property
    Public ReadOnly Property DescripcionDespacho(Optional ByVal i As Short = 1) As String
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
    Public ReadOnly Property FechaDespacho(Optional ByVal i As Short = 1) As Date
        Get
            FechaDespacho = CDate(data.ValueAt((OrdersAD.TableOrdersFields.odFechaDespacho), i))
        End Get
    End Property
    Public ReadOnly Property FormaDespacho(Optional ByVal i As Short = 1) As Short
        Get
            FormaDespacho = data.ValueAt((OrdersAD.TableOrdersFields.odFormaDespacho), i)
        End Get
    End Property
    Public ReadOnly Property DespachadoPor(Optional ByVal i As Short = 1) As String
        Get
            DespachadoPor = CStr(data.ValueAt((OrdersAD.TableOrdersFields.odDespachadoPor), i))
        End Get
    End Property
    Public ReadOnly Property MontoDespacho(Optional ByVal i As Short = 1) As Decimal
        Get
            MontoDespacho = System.Math.Round(MontoTotal(i) / 2, 1)
            If MontoDespacho > MontoAbonado(i) Then
                MontoDespacho = MontoDespacho - MontoAbonado(i)
            End If
        End Get
    End Property
    Public ReadOnly Property SaldoDespacho(Optional ByVal i As Short = 1) As Decimal
        Get
            If MontoDespacho(i) > MontoAbonado(i) Then
                SaldoDespacho = MontoDespacho(i) - MontoAbonado(i)
            Else
                SaldoDespacho = 0
            End If
        End Get
    End Property
    Public ReadOnly Property SaldoSinIntereses(Optional ByVal i As Short = 1) As Decimal
        Get
            SaldoSinIntereses = SaldoFactura(i) - MontoIntereses(i)
        End Get
    End Property
    Public ReadOnly Property MontoIntereses(Optional ByVal i As Short = 0) As Decimal
        Get
            MontoIntereses = CDec(data.ValueAt((OrdersAD.TableOrdersFields.odMontoIntereses), i))
        End Get
    End Property
    Public ReadOnly Property MontoTransporte(Optional ByVal i As Short = 1) As Decimal
        Get
            MontoTransporte = CDec(data.ValueAt((OrdersAD.TableOrdersFields.odMontoTransporte), i))
        End Get
    End Property
    Public ReadOnly Property MontoBruto(Optional ByVal i As Short = 1) As Decimal
        Get
            MontoBruto = CDec(data.ValueAt((OrdersAD.TableOrdersFields.odLinea1), i)) - CDec(data.ValueAt((OrdersAD.TableOrdersFields.odDescuento), i))
        End Get
    End Property
    Public ReadOnly Property Linea1(Optional ByVal i As Short = 1) As Decimal
        Get
            Return (data.ValueAt((OrdersAD.TableOrdersFields.odMontoBruto), i))
        End Get
    End Property
    Public ReadOnly Property TotalImpuesto(Optional ByVal i As Short = 1) As Decimal
        Get
            TotalImpuesto = CDec(data.ValueAt((OrdersAD.TableOrdersFields.odTotalImpuestoVentas), i))
        End Get
    End Property
    Public ReadOnly Property TotalDescuento(Optional ByVal i As Short = 1) As Decimal
        Get
            TotalDescuento = CDec(data.ValueAt((OrdersAD.TableOrdersFields.odDescuento), i))
        End Get
    End Property
    Public ReadOnly Property Observaciones(Optional ByVal i As Short = 1) As String
        Get
            Observaciones = data.ValueAt((OrdersAD.TableOrdersFields.odObservaciones), i)
        End Get
    End Property
    Public ReadOnly Property EstadoEntrega(Optional ByVal i As Short = 1) As Short
        Get
            EstadoEntrega = CShort(data.ValueAt((OrdersAD.TableOrdersFields.odEstadoEntrega), i))
        End Get
    End Property
    Public ReadOnly Property MonthsExpired(Optional ByVal i As Short = 1) As Short
        Get
            Dim fecha As Date
            fecha = CDate(data.ValueAt(OrdersAD.TableOrdersFields.odFechaVencimiento, i))
            MonthsExpired = DateDiff(Microsoft.VisualBasic.DateInterval.Month, fecha, Today)
        End Get
    End Property
End Class