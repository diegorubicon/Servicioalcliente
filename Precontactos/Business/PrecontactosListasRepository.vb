Imports TrackingContacts.Data
Public Class PrecontactosListasRepository
    Private WithEvents db As dbDataContext
    Public Sub New(ByRef datamanager As Data.Manager)
        db = datamanager.Source
    End Sub

    Public Function ToList(ByVal IndexList As Integer) As IEnumerable(Of ListaItem)
        Dim query = From pre In db.ListaItems
                    Select pre
        Return query
    End Function

    Public Function GetPrecontactOFLista(IndexList As Integer, IDPrecontact As Integer) As ListaItem

        Dim query = From pre In db.ListaItems
                    Where pre.id_lista = IndexList And pre.Contacto.ID = IDPrecontact
                    Select pre
        If query.Count > 0 Then
            Return query.First
        Else
            Return Nothing
        End If

    End Function
    Public Sub Add(precontacto As Contacto, lista As lista, interestype As InteresType, interesstatus As InteresStatus, interesespecifico As String)
        Dim pl As ListaItem = New ListaItem

        pl.list = lista
        pl.InteresType = Nothing
        pl.InteresStatus = Nothing
        pl.interes_especifico = ""

        precontacto.ListaItems.Add(pl)
    End Sub
    Public Sub Add(pre As ListaItem)
        db.ListaItems.InsertOnSubmit(pre)
    End Sub
    Public Sub Remove(pre As ListaItem)
        db.ListaItems.DeleteOnSubmit(pre)
    End Sub
    Public Sub Remove(ByRef precontacto As Contacto, ByRef RemoveList As lista)

        For Each pre In precontacto.ListaItems
            If pre.list.GetHashCode = RemoveList.GetHashCode Then
                If Not pre.Oportunidad Is Nothing Then
                    Throw New Exception("No se puede eliminar esta lista, tiene una oportunidad asociada")
                    Exit Sub
                End If
                precontacto.ListaItems.Remove(pre)

                RemoveList.ListaItems.Remove(pre)
                Exit Sub
            End If
        Next

    End Sub


End Class
