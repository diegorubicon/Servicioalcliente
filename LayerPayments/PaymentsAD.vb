Friend Class PaymentsAD
    Inherits DataProvider.AccessData
    Public Enum TablePayments
        paConsecutivo = 0
        paFactura = 1
        paCliente = 2
        paVendedor = 3
        paFormaPago = 4
        paCobrador = 5
        paDocumento = 6
        paFechaPago = 7
        paMonto = 8
        paEstado = 9
        paObservacion = 10
        paBanco = 11
        paAprobado = 12
    End Enum
    Public Sub Read(ByVal factura As String)
        MyBase.GetData("pagos", "pagos_a_facturas p, forma_de_pago fp,banco b", "p.forma_De_pago = fp.tipo and p.banco = b.codigo and p.factura = '" & factura & "' and estado <> 4", "p.amortizacion,p.consecutivo,p.factura,p.cliente,p.vendedor,fp.descripcion as forma_de_pago,b.banco as banco,p.fecha_de_pago,p.documento", )
    End Sub
    Public Function Count() As Integer
        Return MyBase.RowCount("pagos")
    End Function
    Public Property ValueAt(ByVal Column As TablePayments, Optional ByVal index As Integer = 0) As Object
        Get
            Return MyBase.GetValueFromRow("pagos", Map(Column), index)
        End Get
        Set(ByVal Value As Object)
            MyBase.SetValueToRow("pagos", Map(Column), Value)
        End Set
    End Property
    Private Function Map(ByRef f As TablePayments) As String
        Select Case f
            Case TablePayments.paConsecutivo : Return "consecutivo"
            Case TablePayments.paFactura : Return "factura"
            Case TablePayments.paCliente : Return "cliente"
            Case TablePayments.paVendedor : Return "vendedor"
            Case TablePayments.paFormaPago : Return "forma_de_pago"
            Case TablePayments.paCobrador : Return "cobrador"
            Case TablePayments.paDocumento : Return "documento"
            Case TablePayments.paFechaPago : Return "fecha_de_pago"
            Case TablePayments.paMonto : Return "amortizacion"
            Case TablePayments.paObservacion : Return "observacion"
            Case TablePayments.paBanco : Return "banco"
            Case TablePayments.paAprobado : Return "creado_el"
            Case Else : Return ""
        End Select
    End Function
End Class
