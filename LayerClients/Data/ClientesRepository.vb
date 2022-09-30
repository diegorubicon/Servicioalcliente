'----------------------------------------------------------------------------------------------------------
'funcion: clase de datos, gestiona las operaciones linq sobre los objetos linq to sql
'--------------------------------------------------------------------------------------------------------------
Public Class ClientesRepository

    Private db As SourceDataContext = Nothing
    Private query As IQueryable(Of ClienteRow)

    Public Sub New(ConnectionString As String)
        db = New SourceDataContext(ConnectionString)

        query = From cliente In db.ClienteRows
                Select cliente

    End Sub
    Public Property Item(Id As String) As ClienteRow
        Get
            Try
                Dim rst As ClienteRow = query.Where(Function(param) param.cliente = Id).First
                Return rst
            Catch ex As InvalidOperationException
                Return Nothing
            Catch ex As Exception
                Return Nothing
            End Try
        End Get
        Set(value As ClienteRow)
            Dim rs = query.Where(Function(param) param.cliente = Id).First
            rs = value
        End Set
    End Property

End Class
