Friend Class TypeOrderAD
    Inherits DataProvider.AccessData
    Public Enum TableTypeOrder
        tpTipo = 1
        tpDescripcion = 2
    End Enum
    Public Sub Read(Optional ByVal Tipo As Integer = 0)
        If Tipo <> 0 Then
            MyBase.GetData("tipos", "tipos_de_facturas", "tipo = " & Tipo)
        Else
            MyBase.GetData("tipos", "tipos_de_facturas")
        End If
    End Sub
    Public Property ValueAt(ByVal Column As TableTypeOrder, Optional ByVal index As Integer = 1) As Object
        Get
            Return MyBase.GetValueFromRow("tipos", Map(Column), index)
        End Get
        Set(ByVal Value As Object)
            MyBase.SetValueToRow("tipos", Map(Column), Value)
        End Set
    End Property
    Private Function Map(ByRef f As TableTypeOrder) As String
        Select Case f
            Case TableTypeOrder.tpTipo : Return "tipo"
            Case TableTypeOrder.tpDescripcion : Return "descripcion"
            Case Else : Return ""
        End Select
    End Function
End Class
