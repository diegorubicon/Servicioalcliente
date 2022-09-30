Option Strict Off
Option Explicit On
Public Class SeñoriaAD
    Inherits DataProvider.AccessData
    Public Enum TableSeñoria
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
        MyBase.GetData("señoria", "ejecutivos_señoria_activacion", " vendedor = '" & vendedor & "'", "", "consecutivo asc")
    End Sub
    Public Property ValueAT(ByVal Column As TableSeñoria, Optional ByVal index As Integer = 0) As Object
        Get
            Return GetValueFromRow("señoria", Map(Column), index)
        End Get
        Set(ByVal Value As Object)
            SetValueToRow("señoria", Map(Column), Value)
        End Set
    End Property
    Public Function Count()
        Return MyBase.RowCount("señoria")
    End Function
    Private Function Map(ByRef f As TableSeñoria) As String
        Select Case f
            Case TableSeñoria.vendedor : Return "vendedor"
            Case TableSeñoria.CierrePromocion01 : Return "cierre_promocion_01"
            Case TableSeñoria.CierrePromocion02 : Return "cierre_promocion_02"
            Case TableSeñoria.CierrePromocion03 : Return "cierre_promocion_03"
            Case TableSeñoria.CierreDesactivacion01 : Return "cierre_desactivacion_01"
            Case TableSeñoria.CierreDesactivacion02 : Return "cierre_desactivacion_02"
            Case TableSeñoria.CierreDesactivacion03 : Return "cierre_desactivacion_03"
            Case TableSeñoria.CierreDesactivacion04 : Return "cierre_desactivacion_04"
            Case Else : Return ""
        End Select
    End Function

End Class
