Friend Class ShippingAD
    Inherits DataProvider.AccessData
    Public Enum TableShipping
        Guia = 0
        FormaEnvio = 1
        Transporte = 2
        Sucursal = 3
        Observacion = 4
        Fecha = 5
    End Enum
    Public Sub Read(ByVal factura As String)
        MyBase.GetData("Shipping", "entregas e, formas_entrega fe,transportes t,sucursales s", "e.forma_entrega = fe.forma_entrega and e.transporte = t.transporte and e.transporte = s.transporte and e.sucursal = s.sucursal and e.factura = '" & factura & "'", "e.guia,e.fecha,e.observacion,fe.descripcion as FormaEntrega,t.descripcion as transporte,s.nombre as sucursal")
    End Sub
    Public Function count() As Integer
        Return MyBase.RowCount("Shipping")
    End Function
    Public Property ValueAt(ByVal Column As TableShipping, Optional ByVal index As Integer = 0) As Object
        Get
            Return MyBase.GetValueFromRow("Shipping", Map(Column), index)
        End Get
        Set(ByVal Value As Object)
            MyBase.SetValueToRow("Shipping", Map(Column), Value)
        End Set
    End Property
    Private Function Map(ByRef f As TableShipping) As String
        Select Case f
            Case TableShipping.Guia : Return "Guia"
            Case TableShipping.FormaEnvio : Return "FormaEntrega"
            Case TableShipping.Transporte : Return "Transporte"
            Case TableShipping.Sucursal : Return "sucursal"
            Case TableShipping.Observacion : Return "observacion"
            Case TableShipping.Fecha : Return "fecha"
            Case Else : Return ""
        End Select
    End Function
End Class
