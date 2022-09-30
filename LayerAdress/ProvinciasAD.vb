Option Strict Off
Option Explicit On
Imports System.Data.SqlClient
Friend Class ProvinciasAD
    Inherits DataProvider.AccessData
    Public Enum adTableProvincia
        Provincia = 1
        Descripcion = 2
        Creador = 3
        Creado = 4
        Modificador = 6
        Modificado = 7
    End Enum
    Private Function Map(ByRef f As adTableProvincia) As String
        Select Case f
            Case 1 : Map = "provincia"
            Case 2 : Map = "descripcion"
            Case 3 : Map = "creado_por"
            Case 4 : Map = "creado_el"
            Case 5 : Map = "modificado_por"
            Case 6 : Map = "modificado_el"
            Case Else : Return ""
        End Select
    End Function
    Public Sub Read(Optional ByRef provincia As String = "")
        If provincia = "" Then
            GetData("provincias", "provincias", "", "", "provincia asc")
        Else
            GetData("provincias", "provincias", "provincia =  " & provincia & "", "", "")
        End If
    End Sub
    Public Property ValueAt(ByVal field As adTableProvincia, Optional ByVal index As Integer = 1) As Object
        Get
            Return GetValueFromRow("provincias", Map(field), index)
        End Get
        Set(ByVal Value As Object)
            SetValueToRow("provincias", Map(field), Value)
        End Set
    End Property
End Class