Public Class Warranty
    Private data As WarrantyAD
    Private items As WarrantyItem
    Private LoadItem As Boolean = False
    Private KeyConsecutivo As Integer
    Private dbtemp As SqlClient.SqlConnection
    Public Sub New(Optional ByRef cnn As SqlClient.SqlConnection = Nothing)
        data = New WarrantyAD                    'Crea el onjeto de la capa de acceso a datos
        If Not cnn Is Nothing Then
            dbtemp = cnn
            data.Connection(cnn)
        End If
    End Sub
    Public Sub SetDataBaseLogon(ByRef User As String, ByRef Password As String, ByRef server As String)
        data.Usuario = User
        data.Password = Password
        data.Servidor = server
    End Sub
    Public Sub SetConnection(ByRef cnn As SqlClient.SqlConnection)
        dbtemp = cnn
        data.Connection(cnn)
    End Sub
    Public Sub LoadByWarranty(ByVal Boleta As String)
        data.ReadByWarranty(Boleta)
        KeyConsecutivo = data.ValueAt(WarrantyAD.TableWarranty.waConsecutivo)
    End Sub
    Public Sub LoadByClient(ByVal Cliente As String)
        data.ReadByClient(Cliente)
        KeyConsecutivo = data.ValueAt(WarrantyAD.TableWarranty.waConsecutivo)
    End Sub
    Public Function Count() As Short
        Count = data.Count
    End Function
    Public Property Consecutivo(Optional ByVal i As Short = 1) As Integer
        Get
            If KeyConsecutivo <> data.ValueAt(WarrantyAD.TableWarranty.waConsecutivo, i) Then
                LoadItem = False
                KeyConsecutivo = data.ValueAt(WarrantyAD.TableWarranty.waConsecutivo, i)
            End If
            Return KeyConsecutivo
        End Get
        Set(ByVal value As Integer)
        End Set
    End Property
    Public Property Boleta(Optional ByVal i As Short = 1) As String
        Get
            Return data.ValueAt(WarrantyAD.TableWarranty.waBoleta, i)
        End Get
        Set(ByVal value As String)
        End Set
    End Property
    Public Property Cliente(Optional ByVal i As Short = 1) As String
        Get
            Return data.ValueAt(WarrantyAD.TableWarranty.waCliente, i)
        End Get
        Set(ByVal value As String)
        End Set
    End Property
    Public Property NombreCliente(Optional ByVal i As Short = 1) As String
        Get
            Return data.ValueAt(WarrantyAD.TableWarranty.waNombreCliente, i)
        End Get
        Set(ByVal value As String)
        End Set
    End Property
    Public Property CedulaCliente(Optional ByVal i As Short = 1) As String
        Get
            Return data.ValueAt(WarrantyAD.TableWarranty.waCedula, i)
        End Get
        Set(ByVal value As String)
        End Set
    End Property
    Public Property TelefonoCliente(Optional ByVal i As Short = 1) As String
        Get
            Return data.ValueAt(WarrantyAD.TableWarranty.waTelefono, i)
        End Get
        Set(ByVal value As String)
        End Set
    End Property
    Public Property DireccionCliente(Optional ByVal i As Short = 1) As String
        Get
            Return data.ValueAt(WarrantyAD.TableWarranty.waDireccion, i)
        End Get
        Set(ByVal value As String)
        End Set
    End Property
    Public Property Documento(Optional ByVal i As Short = 1) As String
        Get
            Return data.ValueAt(WarrantyAD.TableWarranty.waDocumento, i)
        End Get
        Set(ByVal value As String)
        End Set
    End Property
    Public Property Estado(Optional ByVal i As Short = 1) As Integer
        Get
            Return data.ValueAt(WarrantyAD.TableWarranty.waEstado, i)
        End Get
        Set(ByVal value As Integer)
        End Set
    End Property
    Public ReadOnly Property Articulos(Optional ByVal i As Short = 1) As WarrantyItem
        Get
            If Not LoadItem Then
                items = New WarrantyItem(dbtemp)
                items.Load(KeyConsecutivo)
                LoadItem = True
            End If
            Return items
        End Get
    End Property
    Public Property Fecha(Optional ByVal i As Short = 1) As Date
        Get
            Return data.ValueAt(WarrantyAD.TableWarranty.waFecha, i)
        End Get
        Set(ByVal value As Date)
        End Set
    End Property
    Public Property FechaEstudio(Optional ByVal i As Short = 1) As Date
        Get
            Return data.ValueAt(WarrantyAD.TableWarranty.waFechaEstudio, i)
        End Get
        Set(ByVal value As Date)
        End Set
    End Property
    Public Property Inspector(Optional ByVal i As Short = 1) As String
        Get
            Return data.ValueAt(WarrantyAD.TableWarranty.waInspector, i)
        End Get
        Set(ByVal value As String)
        End Set
    End Property



End Class
