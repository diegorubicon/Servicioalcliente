Option Strict Off
Option Explicit On
Imports System.Data.SqlClient
Friend Class ZipCodeAD
    Inherits DataProvider.AccessData
    Public Enum TableZipCodeField
        zcZona = 1
        zcDescripcion = 2
        zcImpuesto = 3
        zcCreador = 4
        zcCreado = 5
        zcModificador = 6
        zcModificado = 7
    End Enum
    Private Function Map(ByRef f As TableZipCodeField) As String
        Select Case f
            Case 1 : Map = "zona"
            Case 2 : Map = "descripcion"
            Case 3 : Map = "impuesto"
            Case 4 : Map = "creado_por"
            Case 5 : Map = "creado_el"
            Case 6 : Map = "modificado_por"
            Case 7 : Map = "modificado_el"
            Case Else : Return ""
        End Select
    End Function
    Public Sub Read(Optional ByRef z As Short = 0)
        GetData("zonas", "zonas", "", "", "descripcion")
    End Sub
    Public Function Count() As Integer
        Return MyBase.RowCount("zonas")
    End Function
    Public Property ValueAt(ByVal field As TableZipCodeField, Optional ByVal index As Integer = 1) As Object
        Get
            Return GetValueFromRow("zonas", Map(field), index)
        End Get
        Set(ByVal Value As Object)
            SetValueToRow("zonas", Map(field), Value)
        End Set
    End Property
End Class