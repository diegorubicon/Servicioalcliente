Option Strict Off
Option Explicit On
Friend Class CantonesAD
    Inherits DataProvider.AccessData
    Public Enum adTableCantones
        Provincia = 0
        Canton = 1
        Descripcion = 2
        Creador = 3
        Creado = 4
        Modificador = 6
        Modificado = 7
    End Enum
    Private Function Map(ByRef f As adTableCantones) As String
        Select Case f
            Case 0 : Map = "provincia"
            Case 1 : Map = "canton"
            Case 2 : Map = "descripcion"
            Case 3 : Map = "creado_por"
            Case 4 : Map = "creado_el"
            Case 5 : Map = "modificado_por"
            Case 6 : Map = "modificado_el"
            Case Else : Return ""
        End Select
    End Function
    Public Sub Read(ByRef provincia As String, Optional ByVal canton As String = "")
        If canton = "" Then
            GetData("cantones", "cantones", "provincia =" & provincia)
        Else
            GetData("cantones", "cantones", "provincia =  " & provincia & " and canton = " & canton)
        End If
    End Sub
    Public Property ValueAt(ByVal field As adTableCantones, Optional ByVal index As Integer = 1) As Object
        Get
            Return GetValueFromRow("cantones", Map(field), index)
        End Get
        Set(ByVal Value As Object)
            SetValueToRow("cantones", Map(field), Value)
        End Set
    End Property

End Class