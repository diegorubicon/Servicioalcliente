Imports TrackingContacts.Data
Public Class Cantones

    Private db As dbDataContext = Nothing

    Public Sub New(ConnectionString As String)
        db = New dbDataContext(ConnectionString)
    End Sub

    Public Function ToList() As IEnumerable(Of provincia)
        Dim query = From pro In db.provincias
                    Select pro
        Return query
    End Function

End Class