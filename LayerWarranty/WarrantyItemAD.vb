Public Class WarrantyItemAD
    Inherits DataProvider.AccessData
    Public Enum TableWarrantyItem
        waiLinea = 0
        waiArticulo = 1
        waiDescripcion = 2
        waiBodega = 3
        waiTipoGarantia = 4
        waiCantidad = 5
        waiComentarios = 6
        waiTransporte = 7
    End Enum
    Public Sub Read(ByVal consecutivo As String)
        MyBase.GetData("cambios", "cambios_detalle cd, articulos a", "cd.articulo = a.articulo and cd.consecutivo = " & consecutivo & "", "cd.*,a.descripcion", )
    End Sub
    Public Function Count()
        Return MyBase.RowCount("cambios")
    End Function
    Public Property ValueAt(ByVal Column As TableWarrantyItem, Optional ByVal index As Integer = 0) As Object
        Get
            Return MyBase.GetValueFromRow("cambios", Map(Column), index)
        End Get
        Set(ByVal Value As Object)
            MyBase.SetValueToRow("cambios", Map(Column), Value)
        End Set
    End Property
    Private Function Map(ByRef f As TableWarrantyItem) As String
        Select Case f
            Case TableWarrantyItem.waiLinea : Return "linea"
            Case TableWarrantyItem.waiArticulo : Return "articulo"
            Case TableWarrantyItem.waiDescripcion : Return "descripcion"
            Case TableWarrantyItem.waiBodega : Return "bodega"
            Case TableWarrantyItem.waiTipoGarantia : Return "tipogarantia"
            Case TableWarrantyItem.waiCantidad : Return "cantidad"
            Case TableWarrantyItem.waiComentarios : Return "comentarios"
            Case TableWarrantyItem.waiTransporte : Return "transporte"
            Case Else : Return ""
        End Select
    End Function

End Class
