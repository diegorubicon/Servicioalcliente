Imports TrackingContacts.Data
Public Class OrigenesRepository
    Private db As dbDataContext = Nothing

    Public Sub New(ByRef datamanager As Data.Manager)
        db = datamanager.Source
    End Sub
    Public Function GetByID(_IdOrigen As Integer) As Origen
        Dim query = From ori In db.Origens
                    Where ori.origen = _IdOrigen
                    Select ori
        If query.Count > 0 Then
            Return query.First
        Else
            Return Nothing
        End If
    End Function

    Public Function ToList() As IEnumerable(Of Origen)
        Try
            Dim query = From ori In db.Origens
                        Select ori
                        Order By ori.descripcion Ascending
            Return query
        Catch ex As Exception
            Throw New Exception("Error cargando los origenes" + ex.Message)
            Return Nothing
        End Try
    End Function
    Public Sub Submmit()
        Try
            db.SubmitChanges()
        Catch ex As Exception
            Throw New Exception("No se pudo aplicar los cambios" + ex.Message)
        End Try
    End Sub
End Class
