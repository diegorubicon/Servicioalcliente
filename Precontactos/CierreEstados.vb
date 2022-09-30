Imports TrackingContacts.Data
Public Class CierreEstados

    Private db As dbDataContext = Nothing

    Public Sub New(ByRef DataManager As Data.Manager)
        db = DataManager.Source
    End Sub

    Public Function ToList() As IEnumerable(Of CierreEstado)
        Try
            Dim query = From estado In db.CierreEstados
                        Select estado
            Return query
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

End Class
