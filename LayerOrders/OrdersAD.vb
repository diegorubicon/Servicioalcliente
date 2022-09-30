Option Strict Off
Option Explicit On
Friend Class OrdersAD
    Inherits DataProvider.DataManagement
    Public Enum Orden
        Ascendig = 1
        Descending = 2
    End Enum
    Public Enum TableColumns
        Factura = 1
        CodigoCliente = 2
        TipoFactura = 3
        Estado = 4
        Fecha = 5
        FechaVencimiento = 6
        Cobrador = 7
        Vendedor = 8
        Referencia = 9
        MontoTotal = 10
        SaldoFactura = 11
        FechaUltimoPago = 12
        Cierre = 13
        DespachadoPor = 14
        MercanciaSalida = 15
        MesesPlazo = 16
        FechaSalida = 17
        FormaDespacho = 18
        PostVenta = 19
        TipoDescuento = 20
        MontoIntereses = 21
        MontoTransporte = 22
        Observacion = 23
        EstadoEntrega = 24
        Bodega = 25
        ImpuestoVentas = 26
        Descuento = 27
        MontoBruto = 28
        Promocion = 29
        FechaAño = 30
        Linea1 = 31
    End Enum
#Region "Propiedades"
    Public Property Column(ByVal ColumnName As TableColumns) As TableColumn
        Get
            Return MyBase.Fields(Map(ColumnName))
        End Get
        Set(ByVal value As TableColumn)

        End Set
    End Property
#End Region
    Public Sub New()
        MyBase.TableName = "facturas_encabezado"
    End Sub
    Public Sub AddOrder(ByVal ColumnName As TableColumns, ByVal Condition As Orden)
        If Condition = Orden.Ascendig Then
            MyBase.Order.Add(New TableColumn(Map(ColumnName)), TableOrder.TypeOrder.Asc)
        Else
            MyBase.Order.Add(New TableColumn(Map(ColumnName)), TableOrder.TypeOrder.Desc)
        End If
    End Sub
    Public Sub AddFilter(ByVal ColumnName As TableColumns, ByVal Condition As String, ByVal Value As Object)
        MyBase.Filter.Add(New TableColumn(Map(ColumnName)), Condition, Value)
    End Sub
    Private Function Map(ByVal Columnname As TableColumns) As String
        Select Case Columnname
            Case TableColumns.Factura : Return "factura"
            Case TableColumns.CodigoCliente : Return "Cliente"
            Case TableColumns.TipoFactura : Return "tipo"
            Case TableColumns.Estado : Return "estado"
            Case TableColumns.Fecha : Return "Fecha"
            Case TableColumns.FechaVencimiento : Return "fecha_vencimiento"
            Case TableColumns.Cobrador : Return "cobrador"
            Case TableColumns.Vendedor : Return "vendedor"
            Case TableColumns.Referencia : Return "referencia"
            Case TableColumns.MontoTotal : Return "monto_total"
            Case TableColumns.SaldoFactura : Return "saldo_factura"
            Case TableColumns.FechaUltimoPago : Return "fecha_ultimo_pago"
            Case TableColumns.Cierre : Return "cierre"
            Case TableColumns.DespachadoPor : Return "despachado_por"
            Case TableColumns.MercanciaSalida : Return "mercancia_salida"
            Case TableColumns.MesesPlazo : Return "meses_plazo"
            Case TableColumns.FechaSalida : Return "fecha_salida_mercancia"
            Case TableColumns.FormaDespacho : Return "forma_despacho"
            Case TableColumns.PostVenta : Return "postventa"
            Case TableColumns.TipoDescuento : Return "tipo_orden"
            Case TableColumns.MontoIntereses : Return "monto_intereses_por_mora"
            Case TableColumns.MontoTransporte : Return "monto_transporte"
            Case TableColumns.Observacion : Return "observacion"
            Case TableColumns.EstadoEntrega : Return "estado_entrega"
            Case TableColumns.Bodega : Return "bodega"
            Case TableColumns.ImpuestoVentas : Return "total_impuesto_ventas"
            Case TableColumns.Descuento : Return "monto_descuento_factura"
            Case TableColumns.MontoBruto : Return "linea1"
            Case TableColumns.Promocion : Return "promocion"
            Case TableColumns.FechaAño : Return "year(fecha)"
            Case TableColumns.Linea1 : Return "monto_bruto"
            Case Else : Return ""
        End Select
    End Function
End Class