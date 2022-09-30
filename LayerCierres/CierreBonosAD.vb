Friend Class CierreBonosAD
    Inherits DataProvider.AccessData
    Const AliasTable As String = "cierrebonos"
    Public Enum TableCierreBonos
        Codigo = 1
        FechaInicio = 2
        FechaFinal = 3
    End Enum
    Public Sub Read(ByVal cierre As Integer)
        MyBase.GetData(AliasTable, "cierres_bonos", "cod_cierre = " & cierre)
    End Sub
    Public Function Count()
        Return MyBase.RowCount(AliasTable)
    End Function
    Public Property ValueAt(ByVal Column As TableCierreBonos, Optional ByVal index As Integer = 1) As Object
        Get
            Return MyBase.GetValueFromRow(AliasTable, Map(Column), index)
        End Get
        Set(ByVal Value As Object)
            MyBase.SetValueToRow(AliasTable, Map(Column), Value)
        End Set
    End Property
    Private Function Map(ByRef f As TableCierreBonos) As String
        Select Case f
            Case TableCierreBonos.Codigo : Return "cod_cierre"
            Case TableCierreBonos.FechaInicio : Return "fecha_inicio"
            Case TableCierreBonos.FechaFinal : Return "fecha_cierre"
            Case Else : Return ""
        End Select
    End Function
End Class
