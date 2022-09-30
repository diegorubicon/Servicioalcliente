Friend Class ItemsAD
    Inherits AccessData
    Public Enum TableItems
        itArticulo = 1
        itCodigoBarras = 2
        itDescripcion = 3
    End Enum
    Public Sub Read(Optional ByVal Articulo As String = "")
        If Articulo <> 0 Then
            MyBase.GetData("Select * from articulos where articulo = '" & Articulo & "'")
        Else
            MyBase.GetData("Select * from articulos")
        End If
    End Sub
    Public Property ValueAt(ByVal Column As TableItems) As Object
        Get
            Return MyBase.GetValueFromRow(Map(Column))
        End Get
        Set(ByVal Value As Object)
            MyBase.SetValueToRow(Map(Column), Value)
        End Set
    End Property
    Private Function Map(ByRef f As TableItems) As String
        Select Case f
            Case TableItems.itArticulo : Return "articulos"
            Case TableItems.itCodigoBarras : Return "codigo_De_barras"
            Case TableItems.itDescripcion : Return "descripcion"
            Case Else : Return ""
        End Select
    End Function

End Class
