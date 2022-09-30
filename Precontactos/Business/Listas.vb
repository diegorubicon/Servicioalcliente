Namespace Business
    Public Class Listas
        Private ListasAD As Data.Listas = Nothing    'Objeto referencia a la capa de acceso a datos

        Public Sub New(ConnectionString)
            ListasAD = New Data.Listas(ConnectionString)
        End Sub

        Default Public Property Item(ID As Integer) As Lista
            Get
                Return New Lista(ListasAD(ID))
            End Get
            Set(value As Lista)

            End Set
        End Property
    End Class
End Namespace