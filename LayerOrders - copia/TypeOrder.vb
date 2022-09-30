Public Class TypeOrder
    Private data As TypeOrderAD
    Public Sub SetDataBaseLogon(ByRef User As String, ByRef Password As String, Optional ByRef server As String = "")
        data.Usuario = User
        data.Password = Password
        data.Servidor = server
    End Sub
    Public Sub SetConnection(ByRef cnn As SqlClient.SqlConnection)
        data.Connection(cnn)
    End Sub
    Public Sub TypeOrder(ByRef tipo As Integer, Optional ByRef showNull As Boolean = False)
        data.Read(tipo)
    End Sub
    Public ReadOnly Property Codigo(Optional ByVal i As Short = 1) As Integer
        Get
            Return data.ValueAt(TypeOrderAD.TableTypeOrder.tpTipo, i)
        End Get
    End Property
    Public ReadOnly Property Descripcion(Optional ByVal i As Short = 1) As String
        Get
            Return data.ValueAt(TypeOrderAD.TableTypeOrder.tpDescripcion, i)
        End Get
    End Property
    Public Sub New()
        data = New TypeOrderAD
    End Sub
End Class
