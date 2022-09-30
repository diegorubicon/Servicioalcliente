Public Class TypeDiscount
    Private data As TypeDiscountAD
    Private index As Integer
    Public Sub SetDataBaseLogon(ByRef User As String, ByRef Password As String, Optional ByRef server As String = "Sakif")
        data.Usuario = User
        data.Password = Password
        data.Servidor = server
    End Sub
    Public Sub SetConnection(ByRef cnn As SqlClient.SqlConnection)
        data.Connection(cnn)
    End Sub
    Public Sub TypeDiscount(ByRef tipo As Integer, Optional ByRef showNull As Boolean = False)
        data.Read(tipo)
        index = 1
    End Sub
    
    Public ReadOnly Property Descuento(Optional ByVal i As Short = 1) As Integer
        Get
            Return data.ValueAt(TypeDiscountAD.TableTypeDiscount.tpDescuento, i)
        End Get
    End Property
    Public ReadOnly Property Descripcion(Optional ByVal i As Short = 1) As String
        Get
            Return data.ValueAt(TypeDiscountAD.TableTypeDiscount.tpDescripcion, i)
        End Get
    End Property

    Public Sub New()
        data = New TypeDiscountAD
    End Sub
End Class
