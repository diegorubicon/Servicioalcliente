Friend Class PromocionAD
    Inherits DataProvider.AccessData
    Public Enum TablePromocion
        prPromocion = 1
        prDescripcion = 2
    End Enum
    Public Sub Read(Optional ByVal Promocion As Integer = 0)
        If Promocion <> 0 Then
            MyBase.GetData("Select * from promociones where promocion = '" & Promocion & "'")
        Else
            MyBase.GetData("Select * from promociones")
        End If
    End Sub
    Public Property ValueAt(ByVal Column As TablePromocion, Optional ByVal index As Integer = 0) As Object
        Get
            Return MyBase.GetValueFromRow(Map(Column), index)
        End Get
        Set(ByVal Value As Object)
            MyBase.SetValueToRow(Map(Column), Value)
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
