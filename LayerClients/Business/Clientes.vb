'--------------------------------------------------------------------------------
'Clase negocio Clientes:
'Funcion interactua con la capa de acceso a datos (linq) y brinda a la capa de presentacion objeto simples
'---------------------------------------------------------------------------------------------------------
Public Class Clientes

    Private Data As ClientesRepository
   
    Public Sub New(ConnectionString As String)
        Data = New ClientesRepository(ConnectionString)

    End Sub

    Default Overloads Property Item(id As String) As Cliente
        Get
            'Hace el paso del objeto linq a un objeto normal
            'para eliminar nulo y posibles errores de DB
            Dim rw As ClienteRow = Data.Item(id)
            Dim c As Cliente = Nothing
            If Not (rw Is Nothing) Then
                c = New Cliente(rw)
            Else
                c = New Cliente
            End If
            Return c
        End Get
        Set(value As Cliente)

        End Set
    End Property
End Class
