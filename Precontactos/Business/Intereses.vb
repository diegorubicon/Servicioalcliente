Public Class Intereses

    Private db As dbDataContext = Nothing

    Public Sub New(ByRef datamanager As Data.Manager)
        db = datamanager.Source
    End Sub

    Public Function ToList()
        Dim query = From int In db.InteresTypes
                    Select int
        Return query
    End Function

    Public Function ToList(ByVal ID_lista) As IEnumerable(Of InteresType)
        Dim query = From int In db.InteresTypes
                    Where int.lista = ID_lista
                    Select int
        Return query
    End Function


End Class
