Namespace Data
    Public Class Listas
        Private db As dbDataContext
        Public Sub New(ConnectionString As String)
            db = New dbDataContext(ConnectionString)
        End Sub

        Default Public Property Item(key As Integer) As lista
            Get
                Dim query = From lista In db.listas
                            Where (lista.id_lista = key)
                If query.Count = 0 Then
                    Return Nothing
                Else
                    Return query.First
                End If
            End Get
            Set(value As lista)

            End Set
        End Property
    End Class
End Namespace

