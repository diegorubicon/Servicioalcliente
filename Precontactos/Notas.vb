Imports TrackingContacts.Data
Public Class Notas
    Private db As dbDataContext = Nothing

    Public Sub New(ConnectionString As String)
        db = New dbDataContext(ConnectionString)
    End Sub

    Public Function ToList(id_lista As Integer, id_precontacto As Integer)
        Dim query = From nota In db.notas
                    Where nota.id_lista = id_lista And nota.id_precontacto = id_precontacto
                    Select nota
        Return query

    End Function


End Class
