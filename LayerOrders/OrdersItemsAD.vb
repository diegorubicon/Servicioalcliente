Friend Class OrdersItemsAD
    Inherits DataProvider.AccessData
    Public Enum TableOrdersItems
        oiArticulo = 1
        oiTipoPrecio = 2
        oiCosto = 3
        oiPrecioBruto = 4
        oiImpuestoVentas = 5
        oiDescuento = 6
        oiPrecioNeto = 7
        oiCantidad = 8
        oiPorcentajeDescuento = 9
        oiGarantia = 10
        oiDescripcion = 11
    End Enum
    Public Sub Read(ByVal factura As String)
        If factura <> "" Then
            MyBase.GetData("facturaarticulos", "factura_Detalle fd, articulos a", "fd.articulo = a.articulo and fd.factura = '" & factura & "'", "fd.*,a.descripcion")
        End If
    End Sub
    Public Function Count()
        Return MyBase.RowCount("facturaarticulos")
    End Function
    Public Property ValueAt(ByVal Column As TableOrdersItems, Optional ByVal index As Integer = 0) As Object
        Get
            Return MyBase.GetValueFromRow("facturaarticulos", Map(Column), index)
        End Get
        Set(ByVal Value As Object)
            MyBase.SetValueToRow("facturaarticulos", Map(Column), Value)
        End Set
    End Property
    Private Function Map(ByRef f As TableOrdersItems) As String
        Select Case f
            Case TableOrdersItems.oiArticulo : Return "articulo"
            Case TableOrdersItems.oiTipoPrecio : Return "tipo_de_precio"
            Case TableOrdersItems.oiCosto : Return "costo_unitario"
            Case TableOrdersItems.oiPrecioBruto : Return "precio_de_venta"
            Case TableOrdersItems.oiImpuestoVentas : Return "impuesto_de_venta"
            Case TableOrdersItems.oiDescuento : Return "descuento_Articulo"
            Case TableOrdersItems.oiPrecioNeto : Return "monto_total"
            Case TableOrdersItems.oiCantidad : Return "cantidad"
            Case TableOrdersItems.oiPorcentajeDescuento : Return "porcentaje_Descuento"
            Case TableOrdersItems.oiGarantia : Return "referencia_cambio"
            Case TableOrdersItems.oiDescripcion : Return "descripcion"
            Case Else : Return ""
        End Select
    End Function
End Class
