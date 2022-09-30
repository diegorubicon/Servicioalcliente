Public Class OrdersItems
    Private data As OrdersItemsAD
    Public Sub SetDataBaseLogon(ByRef User As String, ByRef Password As String, Optional ByRef server As String = "")
        data = New OrdersItemsAD
        data.Usuario = User
        data.Password = Password
        data.Servidor = server
    End Sub
    Public Sub New(ByRef factura As String, ByRef User As String, ByRef Password As String, ByRef server As String)
        data = New OrdersItemsAD
        data.Usuario = User
        data.Password = Password
        data.Servidor = server
        data.Read(factura)
    End Sub
    Public Sub New(ByRef factura As String, ByRef db As SqlClient.SqlConnection)
        data = New OrdersItemsAD
        data.Connection(db)
        data.Read(factura)
    End Sub
    Public Function Count() As Double
        Return data.RowCount
    End Function
    Public ReadOnly Property Articulo(Optional ByVal i As Short = 1) As String
        Get
            Return data.ValueAt(OrdersItemsAD.TableOrdersItems.oiArticulo, i)
        End Get
    End Property
    Public ReadOnly Property PrecioNeto(Optional ByVal i As Short = 1) As Double
        Get
            Return data.ValueAt(OrdersItemsAD.TableOrdersItems.oiPrecioNeto, i)
        End Get
    End Property
    Public ReadOnly Property Cantidad(Optional ByVal i As Short = 1) As Integer
        Get
            Return data.ValueAt(OrdersItemsAD.TableOrdersItems.oiCantidad, i)
        End Get
    End Property
    Public ReadOnly Property Descripcion(Optional ByVal i As Short = 1) As String
        Get
            Return data.ValueAt(OrdersItemsAD.TableOrdersItems.oiDescripcion, i)
        End Get
    End Property

End Class
