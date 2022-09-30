Public Class WarrantyItem
    Private data As WarrantyItemAD
    Private index As Integer
    Private KeyBoleta As String
    Public Sub New(Optional ByRef cnn As SqlClient.SqlConnection = Nothing)
        data = New WarrantyItemAD                    'Crea el onjeto de la capa de acceso a datos
        If Not cnn Is Nothing Then
            data.Connection(cnn)
        End If
    End Sub
    Public Sub SetDataBaseLogon(ByRef User As String, ByRef Password As String, ByRef server As String)
        data.Usuario = User
        data.Password = Password
        data.Servidor = server
    End Sub
    Public Sub SetConnection(ByRef cnn As SqlClient.SqlConnection)
        data.Connection(cnn)
    End Sub
    Public Sub Load(ByVal Consecutivo As Integer)
        data.Read(Consecutivo)
    End Sub
    Public Function Count() As Short
        Count = data.Count
    End Function
    Public Property Articulo(Optional ByVal i As Short = 1) As String
        Get
            Return data.ValueAt(WarrantyItemAD.TableWarrantyItem.waiArticulo, i)
        End Get
        Set(ByVal value As String)
        End Set
    End Property
    Public Property Descripcion(Optional ByVal i As Short = 1) As String
        Get
            Return data.ValueAt(WarrantyItemAD.TableWarrantyItem.waiDescripcion, i)
        End Get
        Set(ByVal value As String)
        End Set
    End Property
    Public Property Linea(Optional ByVal i As Short = 1) As Integer
        Get
            Return data.ValueAt(WarrantyItemAD.TableWarrantyItem.waiLinea, i)
        End Get
        Set(ByVal value As Integer)
        End Set
    End Property
    Public Property TipoGarantia(Optional ByVal i As Short = 1) As Integer
        Get
            Return data.ValueAt(WarrantyItemAD.TableWarrantyItem.waiTipoGarantia, i)
        End Get
        Set(ByVal value As Integer)
        End Set
    End Property
    Public Property Comentarios(Optional ByVal i As Short = 1) As String
        Get
            Return data.ValueAt(WarrantyItemAD.TableWarrantyItem.waiComentarios, i)
        End Get
        Set(ByVal value As String)
        End Set
    End Property
End Class
