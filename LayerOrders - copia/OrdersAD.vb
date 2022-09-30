Option Strict Off
Option Explicit On
Friend Class OrdersAD
    Inherits DataProvider.AccessData
    Private filtro As String
    Public Enum TableOrdersFields
        odFactura = 1
        odCliente = 2
        odTipo = 3
        odEstado = 4
        odfecha = 5
        odFechaVencimiento = 6
        odCobrador = 7
        odVendedor = 8
        odReferencia = 9
        odMontoTotal = 10
        odSaldoFactura = 11
        odFechaUltPago = 12
        odAprobadoDespacho = 13
        odPlazo = 14
        odFechaDespacho = 15
        odFormaDespacho = 16
        odDespachadoPor = 17
        odMontoIntereses = 18
        odMontoTransporte = 19
        odObservaciones = 20
        odEstadoEntrega = 21
        odBodega = 22
        odTotalImpuestoVentas = 23
        odLinea1 = 24
        odDescuento = 25
        odFacturaFisica = 26
        odTipoDescuento = 27
        odPromocion = 28
        odCierre = 29
        odFechaAño = 30
        odMontoBruto = 31
    End Enum
    Public Enum OrderSymbol
        EqualCHR = 1
        StartsWith = 2
        EndWith = 3
        EqualNUM = 5
        NotEqualNUM = 6
        Less = 7
        LessDT = 201
        MayorDT = 203
        MayorThan = 202
    End Enum
    Public Sub AddFilter(ByVal Campo As TableOrdersFields, ByVal Condicion As OrderSymbol, ByVal valor As String)
        If filtro = "" Then
            filtro = "(" + Map(Campo) + " " + MapSymbol(Condicion, valor) + ")"
        Else
            filtro = filtro + " and (" + Map(Campo) + " " + MapSymbol(Condicion, valor) + ")"
        End If
    End Sub
    Public Sub ClearFilter()
        Filtro = ""
    End Sub
    'Public Function Exist(ByRef o As String) As Boolean
    '    Filter_Renamed = ""
    '    AddFilter(TableOrdersFields.odFactura, OrderSymbol.EqualCHR, o)
    '    proceso = 2
    '    cnn.OpenConnection()
    '    If cont = 0 Then
    '        Exist = False
    '    Else
    '        Exist = True
    '    End If
    'End Function
    Public Sub Read(Optional ByVal o As String = "")
        If o = "" Then
            If filtro = "" Then
                MyBase.GetData("Select * from facturas_encabezado order by fecha desc")
            Else
                MyBase.GetData("Select * from facturas_encabezado where " + filtro + " order by fecha desc")
            End If
        Else
            MyBase.GetData("Select * from facturas_encabezado where factura = '" & o & "' order by fecha desc")
        End If
    End Sub
    '-------------------------------------------------------------------------------------
    'Efecto: Agrega un filtro para la extracion de datos
    'Requiere f: campo sobre el que se va a filtrar, s simbolo, value valor de comparacion
    'Modifica Agrega el filtro a la variable filter encargada de establecer los filtros
    '---------------------------------------------------------------------------------------
    'Public Sub AddFilter(ByRef f As TableOrdersFields, ByRef s As OrderSymbol, ByRef value As String)
    '    If Filter_Renamed = "" Then
    '        'UPGRADE_WARNING: Couldn't resolve default property of object MapSymbol(s, value). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '        Filter_Renamed = Map(f) + MapSymbol(s, value)
    '    Else
    '        'UPGRADE_WARNING: Couldn't resolve default property of object MapSymbol(s, value). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '        Filter_Renamed = Filter_Renamed & " and " & Map(f) + MapSymbol(s, value)
    '    End If
    'End Sub
    'Public Sub ClearFilter()
    '    Filter_Renamed = ""
    'End Sub
    'Public Sub AddOrder(ByRef f As TableOrdersFields, Optional ByRef Descendente As Boolean = False)
    '    If CamposOrdenamiento = "" Then
    '        If Descendente Then
    '            CamposOrdenamiento = Map(f) & " DESC"
    '        Else
    '            CamposOrdenamiento = Map(f) & " ASC"
    '        End If
    '    Else
    '        CamposOrdenamiento = Replace(CamposOrdenamiento, " DESC", "")
    '        CamposOrdenamiento = Replace(CamposOrdenamiento, " ASC", "")
    '        CamposOrdenamiento = CamposOrdenamiento & ", " & Map(f)
    '        If Descendente Then
    '            CamposOrdenamiento = CamposOrdenamiento & " DESC"
    '        Else
    '            CamposOrdenamiento = CamposOrdenamiento & " ASC"
    '        End If
    '    End If
    'End Sub    
    Public Property ValueAt(ByVal Column As TableOrdersFields, Optional ByVal index As Integer = 1) As Object
        Get
            Return MyBase.GetValueFromRow(Map(Column), index)
        End Get
        Set(ByVal Value As Object)
            MyBase.SetValueToRow(Map(Column), Value)
        End Set
    End Property
    Private Function Map(ByRef f As TableOrdersFields) As String
        Select Case f
            Case 1 : Map = "factura"
            Case 2 : Map = "cliente"
            Case 3 : Map = "tipo"
            Case 4 : Map = "estado"
            Case 5 : Map = "fecha"
            Case 6 : Map = "fecha_vencimiento"
            Case 7 : Map = "cobrador"
            Case 8 : Map = "vendedor"
            Case 9 : Map = "referencia"
            Case 10 : Map = "monto_total"
            Case 11 : Map = "saldo_Factura"
            Case 12 : Map = "fecha_ultimo_pago"
            Case 13 : Map = "mercancia_salida"
            Case 14 : Map = "meses_plazo"
            Case 15 : Map = "fecha_salida_mercancia"
            Case 16 : Map = "forma_despacho"
            Case 17 : Map = "despachado_por"
            Case 18 : Map = "monto_intereses_por_mora"
            Case 19 : Map = "monto_transporte"
            Case 20 : Map = "observacion"
            Case 21 : Map = "estado_entrega"
            Case 22 : Map = "bodega"
            Case 23 : Map = "total_impuesto_ventas"
            Case 24 : Map = "linea1"
            Case 25 : Map = "monto_descuento_factura"
            Case 27 : Return "tipo_orden"
            Case 28 : Return "promocion"
            Case 29 : Return "cierre"
            Case TableOrdersFields.odFechaAño : Return ("year(fecha)")
            Case 31 : Return "monto_bruto"
            Case Else : Map = ""
        End Select
    End Function
    Private Function MapSymbol(ByRef s As OrderSymbol, ByRef value As String) As Object
        Select Case s
            Case 1 : Return " = '" & value & "'"
            Case 2 : Return " like '" & value & "%'"
            Case 3 : Return " like %" & value
            Case 5 : Return " = " & value
            Case 6 : Return " <> " & value
            Case 7 : Return " < " & value
            Case 201 : Return " < '" & value & "'"
            Case 203 : Return " > '" & value & "'"
            Case 202 : Return " > " & value
            Case Else : Return " = '" & value & "'"
        End Select
    End Function
End Class