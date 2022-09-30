Friend Class PromocionAD
    Inherits DataProvider.AccessData
    Public Enum TablePromocion
        prPromocion = 1
        prDescripcion = 2
    End Enum
    Public Sub Read(Optional ByVal Promocion As Integer = 0)
        If Promocion <> 0 Then
            MyBase.GetData("promociones", "promociones", "promocion = '" & Promocion & "'")
        Else
            MyBase.GetData("promociones", "promociones")
        End If
    End Sub
    Public Property ValueAt(ByVal Column As TablePromocion, Optional ByVal index As Integer = 1) As Object
        Get
            Return MyBase.GetValueFromRow("promociones", Map(Column), index)
        End Get
        Set(ByVal Value As Object)
            MyBase.SetValueToRow("promociones", Map(Column), Value)
        End Set
    End Property
    Private Function Map(ByRef f As TablePromocion) As String
        Select Case f
            Case TablePromocion.prPromocion : Return "promocion"
            Case TablePromocion.prDescripcion : Return "descripcion"
            Case Else : Return ""
        End Select
    End Function
End Class
