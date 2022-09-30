Imports TrackingContacts.Data
Public Class ProvinciasRepository

    Private db As dbDataContext = Nothing

    Public Sub New(ByRef DataManager As Data.Manager)
        db = DataManager.Source
    End Sub

    Public Function ToList() As IEnumerable(Of provincia)
        Dim query = From pro In db.provincias
                    Select pro
        Return query
    End Function

    Public Function Item(Id As Integer) As provincia
        Dim query = From pros In db.provincias
                    Where pros.id_provincia = Id
                    Select pros
        Return query
    End Function

End Class
