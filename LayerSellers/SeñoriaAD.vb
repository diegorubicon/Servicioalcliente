Option Strict Off
Option Explicit On
Public Class Se�oriaAD
    Inherits DataProvider.AccessData
    Public Enum TableSe�oria
        vendedor = 1
        CierrePromocion01 = 2
        CierrePromocion02 = 3
        CierrePromocion03 = 4
        CierreDesactivacion01 = 5
        CierreDesactivacion02 = 6
        CierreDesactivacion03 = 7
        CierreDesactivacion04 = 8
    End Enum
    Public Sub Read(ByVal vendedor As String)
        MyBase.GetData("se�oria", "ejecutivos_se�oria_activacion", " vendedor = '" & vendedor & "'", "", "consecutivo asc")
    End Sub
    Public Property ValueAT(ByVal Column As TableSe�oria, Optional ByVal index As Integer = 0) As Object
        Get
            Return GetValueFromRow("se�oria", Map(Column), index)
        End Get
        Set(ByVal Value As Object)
            SetValueToRow("se�oria", Map(Column), Value)
        End Set
    End Property
    Public Function Count()
        Return MyBase.RowCount("se�oria")
    End Function
    Private Function Map(ByRef f As TableSe�oria) As String
        Select Case f
            Case TableSe�oria.vendedor : Return "vendedor"
            Case TableSe�oria.CierrePromocion01 : Return "cierre_promocion_01"
            Case TableSe�oria.CierrePromocion02 : Return "cierre_promocion_02"
            Case TableSe�oria.CierrePromocion03 : Return "cierre_promocion_03"
            Case TableSe�oria.CierreDesactivacion01 : Return "cierre_desactivacion_01"
            Case TableSe�oria.CierreDesactivacion02 : Return "cierre_desactivacion_02"
            Case TableSe�oria.CierreDesactivacion03 : Return "cierre_desactivacion_03"
            Case TableSe�oria.CierreDesactivacion04 : Return "cierre_desactivacion_04"
            Case Else : Return ""
        End Select
    End Function

End Class
