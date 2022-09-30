Friend Class TypeDiscountAD
    Inherits DataProvider.AccessData
    Public Enum TableTypeDiscount
        tpDescuento = 1
        tpDescripcion = 2
    End Enum
    Public Sub Read(Optional ByVal Descuento As Integer = 0)
        If Descuento <> 0 Then
            MyBase.GetData("descuento", "tipos_de_descuento", "descuento = " & Descuento)
        Else
            MyBase.GetData("descuento", "tipos_de_descuento")
        End If
    End Sub
    Public Property ValueAt(ByVal Column As TableTypeDiscount, Optional ByVal index As Integer = 0) As Object
        Get
            Return MyBase.GetValueFromRow("descuento", Map(Column), index)
        End Get
        Set(ByVal Value As Object)
            MyBase.SetValueToRow("descuento", Map(Column), Value)
        End Set
    End Property
    Private Function Map(ByRef f As TableTypeDiscount) As String
        Select Case f
            Case TableTypeDiscount.tpDescuento : Return "descuento"
            Case TableTypeDiscount.tpDescripcion : Return "descripcion"
            Case Else : Return ""
        End Select
    End Function
End Class
