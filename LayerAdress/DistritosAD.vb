Option Strict Off
Option Explicit On
Friend Class DistritosAD
    Inherits DataProvider.AccessData
    Public Enum adTableDistritos
        Provincia = 0
        Canton = 1
        Distrito = 2
        Descripcion = 3
        Creador = 4
        Creado = 5
        Modificador = 6
        Modificado = 7
    End Enum
    Private Function Map(ByRef f As adTableDistritos) As String
        Select Case f
            Case 0 : Map = "provincia"
            Case 1 : Map = "canton"
            Case 2 : Map = "distrito"
            Case 3 : Map = "descripcion"
            Case 4 : Map = "creado_por"
            Case 5 : Map = "creado_el"
            Case 6 : Map = "modificado_por"
            Case 7 : Map = "modificado_el"
            Case Else : Return ""
        End Select
    End Function
    Public Sub Read(ByVal provincia As String, ByVal canton As String, Optional ByVal distrito As String = "")
        If distrito = "" Then
            GetData("distritos", "distritos", "provincia =" & provincia & " and canton = " & canton)
        Else
            GetData("distritos", "distritos", "provincia =  " & provincia & " and canton = " & canton & " and distrito = " & distrito)
        End If
    End Sub
    Public Property ValueAt(ByVal field As adTableDistritos, Optional ByVal index As Integer = 1) As Object
        Get
            Return GetValueFromRow("distritos", Map(field), index)
        End Get
        Set(ByVal Value As Object)
            SetValueToRow("distritos", Map(field), Value)
        End Set
    End Property
End Class