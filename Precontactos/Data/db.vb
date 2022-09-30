



Partial Public Class lista

    Public Function Item(ID_precontacto As Integer) As ListaItem

        Try
            Dim _precontacto As ListaItem
            _precontacto = ListaItems.Single(Function(_pre) _pre.id_precontacto = ID_precontacto)

            Return _precontacto
        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Public Function Filter(provincia As Integer) As IEnumerable(Of ListaItem)
        Return ListaItems.Where(Function(param) param.Contacto.id_provincia = provincia)
    End Function
    Public Function Filter(provincia As Integer, ubicacion As String) As IEnumerable(Of ListaItem)

        Return ListaItems.Where(Function(param) param.Contacto.id_provincia = provincia And param.Contacto.lugar.Contains(ubicacion))
    End Function

End Class


Partial Public Class Contacto
    Private Sub OnValidate(action As System.Data.Linq.ChangeAction)

        If nombre.Trim = "" Then
            Throw New Exception("Debe ingresar el nombre del pre-contacto")
        End If
    End Sub
    Public ReadOnly Property NombreCompleto As String
        Get
            Return nombre + " " + apellido_01 + " " + apellido_02
        End Get
    End Property
End Class







