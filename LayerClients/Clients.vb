Option Strict Off
Option Explicit On
Public Class Clients
    '--------------------------------------------------------------------------------------
    'Atributos de la clase
    '--------------------------------------------------------------------------------------
    Private clCliente As String             'Almacena el codigo de cliente temporalmente
    Private data As ClientsAD               'Objeto de la capa de acceso a datos
    Private pro As LayerAdress.Provincias   'Objeto de Negocios Provincias
    Private cant As LayerAdress.Cantones    'Objeto de Negocios Cantones
    Private Zip As LayerAdress.ZipCode      'Objeto de Negocios Zonas
    Private dist As LayerAdress.Distritos   'Objeto de Negocios Distritos
    Private ReadPro As Boolean              'Bandera de inicializion del objeto de negocios provincias
    Private ReadCant As Boolean             'Bandera de inicializion del objeto de negocios cantones
    Private ReadDist As Boolean             'Bandera de inicializion del objeto de negocios Distritos
    Private ReadZip As Boolean              'Bandera de inicializion del objeto de negocios Zonas
    Private index As Short                  'Indice de la fila que se estan obteniendo datos
    Private user As String
    Private proceso As Short
    Private dbtemp As SqlClient.SqlConnection
    Private p, u, s As String               'Variables del inicio de sesion.
    '-------------------------------------------------------------------------
    'Constructor de la clase
    'Efecto: Inicializa las variables del objeto
    'Requiere: n/a
    'Modifica
    '-------------------------------------------------------------------------    
    Public Sub New()
        MyBase.New()
        ReadPro = False
        ReadCant = False
        ReadDist = False
        data = New ClientsAD 'Crea el objeto de la capa de acceso a datos
        index = 0
        proceso = 0
    End Sub
    Public Sub SetConnection(ByRef cnn As SqlClient.SqlConnection)
        dbtemp = cnn
        data.Connection = cnn
    End Sub
    '----------------------------------------------------------------------
    'Efecto: Solicita la carga de los datos de un cliente desde la bd
    'Requiere: c = codigo del cliente que se va a solicitar
    '---------------------------------------------------------------------
    Public Sub Clients(Optional ByRef c As String = "")
        clCliente = c 'Establece el codigo del cliente e identificador del objeto
        If c <> "" Then
            data.AddFilter(ClientsAD.TableColumns.Codigo, "=", c)
        End If
        data.FillReader()
    End Sub
#Region "Metodos Buscadores"
    Public Sub FindClientsWithCode(Optional ByRef c As String = "")
        If c <> "" Then
            'data.ClearFilter()
            'Call data.AddFilter((ClientsAD.TableClientFields.Codigo), (ClientsAD.ClientSymbol.StartsWith), c)
            'data.Read()
        End If
    End Sub
    Public Sub FindClientsWithName(ByVal Nombre As String)
        Try
            If Nombre <> "" Then
                data.AddFilter(ClientsAD.TableColumns.GroupNombre, " LIKE ", "%" + Nombre + "%")
            End If
            data.FillReader()
        Catch ex As Exception

        End Try
    End Sub
#End Region
    Public Function Count() As Short
        Return data.Count
    End Function
#Region "Metodos GET and SET"
    Public Property Codigo(Optional ByVal i As Short = 0) As String
        Get
            If clCliente <> "" Then
                Codigo = clCliente
            Else
                Return data.Column(ClientsAD.TableColumns.Codigo).Value(i)
            End If
        End Get
        Set(ByVal Value As String)
            data.Column(ClientsAD.TableColumns.Codigo).Value(i) = Value
        End Set
    End Property
    Public Property TipoCliente(Optional ByVal I As Short = 0) As Short
        Get
            Return data.Column(ClientsAD.TableColumns.TipoCliente).Value(I)
        End Get
        Set(ByVal Value As Short)
            data.Column(ClientsAD.TableColumns.TipoCliente).Value(I) = Value
        End Set
    End Property
    Public Property Nombre(Optional ByVal I As Short = 0) As String
        Get
            Nombre = data.Column(ClientsAD.TableColumns.Nombre).Value(I)
        End Get
        Set(ByVal Value As String)
            data.Column(ClientsAD.TableColumns.Nombre).Value(I) = Value
        End Set
    End Property
    Public Property PrimerApellido(Optional ByVal I As Short = 0) As String
        Get
            'UPGRADE_WARNING: Couldn't resolve default property of object data.valueat(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50420D-05FE-4896-8A0B-2EC20E9037B2"'
            PrimerApellido = data.Column(ClientsAD.TableColumns.PrimerApellido).Value(I)
        End Get
        Set(ByVal Value As String)
            'UPGRADE_WARNING: Couldn't resolve default property of object data.ValueAt(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50420D-05FE-4896-8A0B-2EC20E9037B2"'
            data.Column(ClientsAD.TableColumns.PrimerApellido).Value(I) = Value
        End Set
    End Property
    Public Property SegundoApellido(Optional ByVal I As Short = 0) As String
        Get
            'UPGRADE_WARNING: Couldn't resolve default property of object data.valueat(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50420D-05FE-4896-8A0B-2EC20E9037B2"'
            SegundoApellido = data.Column(ClientsAD.TableColumns.SegundoApellido).Value(I)
        End Get
        Set(ByVal Value As String)
            'UPGRADE_WARNING: Couldn't resolve default property of object data.ValueAt(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50420D-05FE-4896-8A0B-2EC20E9037B2"'
            data.Column(ClientsAD.TableColumns.SegundoApellido).Value(I) = Value
        End Set
    End Property
    Public ReadOnly Property NombreCompleto(Optional ByVal I As Short = 0) As String
        Get
            'UPGRADE_WARNING: Couldn't resolve default property of object data.valueat(TableClientFields.SegundoApellido.value(i). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50420D-05FE-4896-8A0B-2EC20E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object data.valueat(TableClientFields.PrimerApellido.value(i). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50420D-05FE-4896-8A0B-2EC20E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object data.valueat(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50420D-05FE-4896-8A0B-2EC20E9037B2"'
            NombreCompleto = data.Column(ClientsAD.TableColumns.Nombre).Value(I) + " " + data.Column(ClientsAD.TableColumns.PrimerApellido).Value(I) + " " + data.Column(ClientsAD.TableColumns.SegundoApellido).Value(I)
        End Get
    End Property
    Public Property Direccion(Optional ByVal I As Short = 0) As String
        Get
            'UPGRADE_WARNING: Couldn't resolve default property of object data.valueat(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50420D-05FE-4896-8A0B-2EC20E9037B2"'
            Direccion = data.Column(ClientsAD.TableColumns.Direccion).Value(I)
        End Get
        Set(ByVal Value As String)
            'UPGRADE_WARNING: Couldn't resolve default property of object data.ValueAt(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50420D-05FE-4896-8A0B-2EC20E9037B2"'
            data.Column(ClientsAD.TableColumns.Direccion).Value(I) = Value
        End Set
    End Property
    Public Property Identificacion(Optional ByVal I As Short = 0) As String
        Get
            'UPGRADE_WARNING: Couldn't resolve default property of object data.valueat(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50420D-05FE-4896-8A0B-2EC20E9037B2"'
            Identificacion = data.Column(ClientsAD.TableColumns.Identificacion).Value(I)
        End Get
        Set(ByVal Value As String)
            'UPGRADE_WARNING: Couldn't resolve default property of object data.ValueAt(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50420D-05FE-4896-8A0B-2EC20E9037B2"'
            data.Column(ClientsAD.TableColumns.Identificacion).Value(I) = Value
        End Set
    End Property
    '-------------------------------------------------------------------------------------
    Public Property TelefonoHabitacion(Optional ByVal I As Short = 0) As String
        Get
            'UPGRADE_WARNING: Couldn't resolve default property of object data.valueat(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50420D-05FE-4896-8A0B-2EC20E9037B2"'
            TelefonoHabitacion = data.Column(ClientsAD.TableColumns.Telefono01).Value(I)
        End Get
        Set(ByVal Value As String)
            'UPGRADE_WARNING: Couldn't resolve default property of object data.ValueAt(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50420D-05FE-4896-8A0B-2EC20E9037B2"'
            data.Column(ClientsAD.TableColumns.Telefono01).Value(I) = Value
        End Set
    End Property
    '--------------------------------------------------------------------------------------
    Public Property TelefonoCelular(Optional ByVal I As Short = 0) As String
        Get
            'UPGRADE_WARNING: Couldn't resolve default property of object data.valueat(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50420D-05FE-4896-8A0B-2EC20E9037B2"'
            TelefonoCelular = data.Column(ClientsAD.TableColumns.Telefono02).Value(I)
        End Get
        Set(ByVal Value As String)
            'UPGRADE_WARNING: Couldn't resolve default property of object data.ValueAt(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50420D-05FE-4896-8A0B-2EC20E9037B2"'
            data.Column(ClientsAD.TableColumns.Telefono02).Value(I) = Value
        End Set
    End Property
    '-------------------------------------------------------------------------------------
    Public Property Fax(Optional ByVal I As Short = 0) As String
        Get
            'UPGRADE_WARNING: Couldn't resolve default property of object data.valueat(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50420D-05FE-4896-8A0B-2EC20E9037B2"'
            Fax = data.Column(ClientsAD.TableColumns.Fax).Value(I)
        End Get
        Set(ByVal Value As String)
            'UPGRADE_WARNING: Couldn't resolve default property of object data.ValueAt(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50420D-05FE-4896-8A0B-2EC20E9037B2"'
            data.Column(ClientsAD.TableColumns.Fax).Value(I) = Value
        End Set
    End Property
    '-------------------------------------------------------------------------------------
    Public Property CorreoElectronico(Optional ByVal I As Short = 0) As String
        Get
            'UPGRADE_WARNING: Couldn't resolve default property of object data.valueat(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50420D-05FE-4896-8A0B-2EC20E9037B2"'
            CorreoElectronico = data.Column(ClientsAD.TableColumns.Correo).Value(I)
        End Get
        Set(ByVal Value As String)
            'UPGRADE_WARNING: Couldn't resolve default property of object data.ValueAt(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50420D-05FE-4896-8A0B-2EC20E9037B2"'
            data.Column(ClientsAD.TableColumns.Correo).Value(I) = Value
        End Set
    End Property
    '-------------------------------------------------------------------------------------
    Public Property DescuentoGeneral(Optional ByVal I As Short = 0) As Double
        Get
            'UPGRADE_WARNING: Couldn't resolve default property of object data.valueat(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50420D-05FE-4896-8A0B-2EC20E9037B2"'
            DescuentoGeneral = CDbl(data.Column(ClientsAD.TableColumns.Descuento).Value(I))
        End Get
        Set(ByVal Value As Double)
            'UPGRADE_WARNING: Couldn't resolve default property of object data.ValueAt(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50420D-05FE-4896-8A0B-2EC20E9037B2"'
            data.Column(ClientsAD.TableColumns.Descuento).Value(I) = Value
        End Set
    End Property
    Public Property VentaMesAnterior(Optional ByVal I As Short = 0) As Decimal
        Get
            'UPGRADE_WARNING: Couldn't resolve default property of object data.valueat(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50420D-05FE-4896-8A0B-2EC20E9037B2"'
            VentaMesAnterior = data.Column(ClientsAD.TableColumns.VentaMesAnterior).Value(I)
        End Get
        Set(ByVal Value As Decimal)
            'UPGRADE_WARNING: Couldn't resolve default property of object data.ValueAt(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50420D-05FE-4896-8A0B-2EC20E9037B2"'
            data.Column(ClientsAD.TableColumns.VentaMesAnterior).Value(I) = Value
        End Set
    End Property
    Public Property SaldoVendido(Optional ByVal I As Short = 0) As Decimal
        Get
            'UPGRADE_WARNING: Couldn't resolve default property of object data.valueat(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50420D-05FE-4896-8A0B-2EC20E9037B2"'
            SaldoVendido = data.Column(ClientsAD.TableColumns.SaldoVendido).Value(I)
        End Get
        Set(ByVal Value As Decimal)
            'UPGRADE_WARNING: Couldn't resolve default property of object data.ValueAt(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50420D-05FE-4896-8A0B-2EC20E9037B2"'
            data.Column(ClientsAD.TableColumns.SaldoVendido).Value(I) = Value
        End Set
    End Property
    Public Property DiasPlazo(Optional ByVal I As Short = 0) As Short
        Get
            'UPGRADE_WARNING: Couldn't resolve default property of object data.valueat(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50420D-05FE-4896-8A0B-2EC20E9037B2"'
            DiasPlazo = CShort(data.Column(ClientsAD.TableColumns.DiasPlazo).Value(I))
        End Get
        Set(ByVal Value As Short)
            'UPGRADE_WARNING: Couldn't resolve default property of object data.ValueAt(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50420D-05FE-4896-8A0B-2EC20E9037B2"'
            data.Column(ClientsAD.TableColumns.DiasPlazo).Value(I) = Value
        End Set
    End Property
    Public Property TipoClienteCobro(Optional ByVal I As Short = 0) As Short
        Get
            If data.Count > 0 Then
                'UPGRADE_WARNING: Couldn't resolve default property of object data.ValueAt(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50420D-05FE-4896-8A0B-2EC20E9037B2"'
                TipoClienteCobro = data.Column(ClientsAD.TableColumns.animo).Value(I)
            Else
                TipoClienteCobro = CShort("")
            End If
        End Get
        Set(ByVal Value As Short)
            'UPGRADE_WARNING: Couldn't resolve default property of object data.ValueAt(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50420D-05FE-4896-8A0B-2EC20E9037B2"'
            data.Column(ClientsAD.TableColumns.animo).Value(I) = Value
        End Set
    End Property
    Public Property Estado(Optional ByVal I As Short = 0) As String
        Get
            'UPGRADE_WARNING: Couldn't resolve default property of object data.valueat(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50420D-05FE-4896-8A0B-2EC20E9037B2"'
            Estado = data.Column(ClientsAD.TableColumns.Estado).Value(I)
        End Get
        Set(ByVal Value As String)
            'UPGRADE_WARNING: Couldn't resolve default property of object data.ValueAt(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50420D-05FE-4896-8A0B-2EC20E9037B2"'
            data.Column(ClientsAD.TableColumns.Estado).Value(I) = Value
        End Set
    End Property
    Public Property AceptaImpuesto(Optional ByVal I As Short = 0) As Short
        Get
            Dim v As String
            'UPGRADE_WARNING: Couldn't resolve default property of object data.valueat(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50420D-05FE-4896-8A0B-2EC20E9037B2"'
            v = data.Column(ClientsAD.TableColumns.AceptaImpuesto).Value(I)
            If v = "0" Then
                AceptaImpuesto = True
            Else
                AceptaImpuesto = False
            End If
        End Get
        Set(ByVal Value As Short)
            'UPGRADE_WARNING: Couldn't resolve default property of object data.ValueAt(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50420D-05FE-4896-8A0B-2EC20E9037B2"'
            data.Column(ClientsAD.TableColumns.AceptaImpuesto).Value(I) = Value
        End Set
    End Property
    Public ReadOnly Property MostrarObservacion(Optional ByVal I As Short = 0) As Boolean
        Get
            Dim v As String
            'UPGRADE_WARNING: Couldn't resolve default property of object data.valueat(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50420D-05FE-4896-8A0B-2EC20E9037B2"'
            v = data.Column(ClientsAD.TableColumns.MostrarObservacion).Value(I)
            If v = "0" Then
                MostrarObservacion = True
            Else
                MostrarObservacion = False
            End If
        End Get
    End Property
    Public Property Observacion(Optional ByVal I As Short = 0) As String
        Get
            'UPGRADE_WARNING: Couldn't resolve default property of object data.valueat(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50420D-05FE-4896-8A0B-2EC20E9037B2"'
            Observacion = data.Column(ClientsAD.TableColumns.Observaciones).Value(I)
        End Get
        Set(ByVal Value As String)
            'UPGRADE_WARNING: Couldn't resolve default property of object data.ValueAt(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50420D-05FE-4896-8A0B-2EC20E9037B2"'
            data.Column(ClientsAD.TableColumns.Observaciones).Value(I) = Value
        End Set
    End Property
    Public Property ZipCode(Optional ByVal I As Short = 0) As LayerAdress.ZipCode
        Get
            If Not ReadZip Then
                Zip = New LayerAdress.ZipCode
                Zip.SetDataBaseLogon(u, p, s)
                Zip.ZipCode((data.Column(ClientsAD.TableColumns.zona).Value(I)))
                ReadZip = True
            End If
            ZipCode = Zip
        End Get
        Set(ByVal Value As LayerAdress.ZipCode)
            'UPGRADE_WARNING: Couldn't resolve default property of object data.ValueAt(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50420D-05FE-4896-8A0B-2EC20E9037B2"'
            data.Column(ClientsAD.TableColumns.zona).Value(I) = Value.Codigo(I)
        End Set
    End Property
    '---------------------------------------------------------------------------------
    Public ReadOnly Property Provincia(Optional ByVal I As Short = 0) As LayerAdress.Provincias
        Get
            If Not ReadPro Then
                pro = New LayerAdress.Provincias
                pro.SetConnection(dbtemp)
                pro.Read((data.Column(ClientsAD.TableColumns.Provincia).Value(I)))
                ReadPro = True
            End If
            Provincia = pro
        End Get
    End Property
    Public WriteOnly Property SetProvincia(Optional ByVal I As Short = 0) As Short
        Set(ByVal Value As Short)
            'UPGRADE_WARNING: Couldn't resolve default property of object data.ValueAt(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50420D-05FE-4896-8A0B-2EC20E9037B2"'
            data.Column(ClientsAD.TableColumns.Provincia).Value(I) = Value
        End Set
    End Property
    '---------------------------------------------------------------------------------
    Public ReadOnly Property Canton(Optional ByVal I As Short = 0) As LayerAdress.Cantones
        Get
            If Not ReadCant Then
                cant = New LayerAdress.Cantones
                cant.SetConnection(dbtemp)
                Call cant.Read(data.Column(ClientsAD.TableColumns.Provincia).Value(I), data.Column(ClientsAD.TableColumns.Canton).Value(I))
            End If
            Canton = cant
        End Get
    End Property
    Public WriteOnly Property SetCanton(Optional ByVal I As Short = 0) As Short
        Set(ByVal Value As Short)
            'UPGRADE_WARNING: Couldn't resolve default property of object data.ValueAt(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50420D-05FE-4896-8A0B-2EC20E9037B2"'
            data.Column(ClientsAD.TableColumns.Canton).Value(I) = Value
        End Set
    End Property
    '------------------------------------------------------------------------------
    Public ReadOnly Property distrito(Optional ByVal I As Short = 0) As LayerAdress.Distritos
        Get
            If Not ReadDist Then
                dist = New LayerAdress.Distritos
                dist.SetConnection(dbtemp)
                Call dist.Read(data.Column(ClientsAD.TableColumns.Provincia).Value(I), data.Column(ClientsAD.TableColumns.Canton).Value(I), data.Column(ClientsAD.TableColumns.distrito).Value(I))
            End If
            distrito = dist
        End Get
    End Property
    Public WriteOnly Property SetDistrito(Optional ByVal I As Short = 0) As Short
        Set(ByVal Value As Short)
            'UPGRADE_WARNING: Couldn't resolve default property of object data.ValueAt(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50420D-05FE-4896-8A0B-2EC20E9037B2"'
            data.Column(ClientsAD.TableColumns.distrito).Value(I) = Value
        End Set
    End Property
    Public WriteOnly Property SetZona(Optional ByVal I As Short = 0) As Short
        Set(ByVal Value As Short)
            'UPGRADE_WARNING: Couldn't resolve default property of object data.ValueAt(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50420D-05FE-4896-8A0B-2EC20E9037B2"'
            data.Column(ClientsAD.TableColumns.zona).Value(I) = Value
        End Set
    End Property
    Public Property Descripcion(Optional ByVal I As Short = 0) As String
        Get
            'UPGRADE_WARNING: Couldn't resolve default property of object data.valueat(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50420D-05FE-4896-8A0B-2EC20E9037B2"'
            Descripcion = data.Column(ClientsAD.TableColumns.Direccion).Value(I)
        End Get
        Set(ByVal Value As String)
            'UPGRADE_WARNING: Couldn't resolve default property of object data.ValueAt(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50420D-05FE-4896-8A0B-2EC20E9037B2"'
            data.Column(ClientsAD.TableColumns.Descripcion).Value(I) = Value
        End Set
    End Property
    Public Property LimiteCredito(Optional ByVal I As Short = 0) As Double
        Get
            'UPGRADE_WARNING: Couldn't resolve default property of object data.valueat(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50420D-05FE-4896-8A0B-2EC20E9037B2"'
            LimiteCredito = data.Column(ClientsAD.TableColumns.LimiteCredito).Value(I)
        End Get
        Set(ByVal Value As Double)
            'UPGRADE_WARNING: Couldn't resolve default property of object data.ValueAt(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50420D-05FE-4896-8A0B-2EC20E9037B2"'
            data.Column(ClientsAD.TableColumns.LimiteCredito).Value(I) = Value
        End Set
    End Property
    Public Property FechaNacimiento(Optional ByVal I As Short = 0) As Date
        Get
            Return CDate(data.Column(ClientsAD.TableColumns.FechaNacimiento).Value(I))
        End Get
        Set(ByVal Value As Date)
            data.Column(ClientsAD.TableColumns.FechaNacimiento).Value(I) = Value
        End Set
    End Property
    Public Property TipoIdentificacion(Optional ByVal I As Short = 0) As Short
        Get
            'UPGRADE_WARNING: Couldn't resolve default property of object data.valueat(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50420D-05FE-4896-8A0B-2EC20E9037B2"'
            TipoIdentificacion = data.Column(ClientsAD.TableColumns.TipoIdentificacion).Value(I)
        End Get
        Set(ByVal Value As Short)
            'UPGRADE_WARNING: Couldn't resolve default property of object data.ValueAt(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50420D-05FE-4896-8A0B-2EC20E9037B2"'
            data.Column(ClientsAD.TableColumns.TipoIdentificacion).Value(I) = Value
        End Set
    End Property
    Public Property Vendedor(Optional ByVal I As Short = 0) As String
        Get
            'UPGRADE_WARNING: Couldn't resolve default property of object data.valueat(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50420D-05FE-4896-8A0B-2EC20E9037B2"'
            Vendedor = data.Column(ClientsAD.TableColumns.Vendedor).Value(I)
        End Get
        Set(ByVal Value As String)
            'UPGRADE_WARNING: Couldn't resolve default property of object data.ValueAt(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50420D-05FE-4896-8A0B-2EC20E9037B2"'
            data.Column(ClientsAD.TableColumns.Vendedor).Value(I) = Value
        End Set
    End Property
    Public Property FechaIngreso(Optional ByVal I As Short = 0) As Date
        Get
            'UPGRADE_WARNING: Couldn't resolve default property of object data.valueat(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50420D-05FE-4896-8A0B-2EC20E9037B2"'
            FechaIngreso = CDate(data.Column(ClientsAD.TableColumns.FechaIngreso).Value(I))
        End Get
        Set(ByVal Value As Date)
            'UPGRADE_WARNING: Couldn't resolve default property of object data.ValueAt(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50420D-05FE-4896-8A0B-2EC20E9037B2"'
            data.Column(ClientsAD.TableColumns.FechaIngreso).Value(I) = Value
        End Set
    End Property
    Public WriteOnly Property usuario() As String
        Set(ByVal Value As String)
            user = Value
        End Set
    End Property
#End Region
End Class