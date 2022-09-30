Public Class DistribuidoresRepository
    Private db As dbDataContext = Nothing

    Public Sub New(ByRef DataManager As Data.Manager)
        db = DataManager.Source
    End Sub
    Public Function ToList() As IEnumerable
        Dim query As IEnumerable

        query = From distribuidores In db.Distribuidors
                Select distribuidores

        Return query
    End Function
    Public Function SearchByName(Criteria As String) As IEnumerable
        Dim query = From distribuidores In db.Distribuidors
                Where distribuidores.nombre + distribuidores.apellido_01 + distribuidores.apellido_02 Like "*" + Criteria + "*"
                Select distribuidores
        Return query
    End Function
    Public ReadOnly Property Item(id_distribuidor As String) As Distribuidor
        Get
            Dim query = From dist In db.Distribuidors
                        Where dist.id_distribuidor = id_distribuidor
                        Select dist
            If query.Count > 0 Then
                Return query.First
            Else
                Return Nothing
            End If
        End Get

    End Property

End Class
