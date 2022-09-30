Public Class Cliente
    Private _source As ClienteRow = Nothing
    Private _linked As Boolean = False
    Private _provincia As ProvinciaObj
    Private _canton As CantonObj
    Private _distrito As DistritoObj
    Public Sub New()
        _linked = False
        _source = New ClienteRow
        _provincia = New ProvinciaObj
        _canton = New CantonObj
        _distrito = New DistritoObj
    End Sub
    Public Sub New(Source As ClienteRow)
        _source = Source
        _linked = True
        _provincia = New ProvinciaObj(Source.ProvinciaRow)
        _canton = New CantonObj(Source.CantonRow)
        _distrito = New DistritoObj(Source.DistritoRow)
    End Sub
#Region "Metodos"
    Public ReadOnly Property IsLinked
        Get
            Return _linked
        End Get
    End Property
    Public Property ID As String
        Get
            Return _source.cliente
        End Get
        Set(value As String)
            _source.cliente = ID
        End Set
    End Property
    Public ReadOnly Property NombreCompleto As String
        Get
            Return (_source.nombre + " " + _source.apellido_01 + " " + _source.apellido_02).ToUpper
        End Get
    End Property

    Public Property Nombre As String
        Get
            Return _source.nombre.ToUpper
        End Get
        Set(value As String)
            _source.nombre = value.ToUpper
        End Set
    End Property

    Public Property Apellido01 As String
        Get
            Return _source.apellido_01.ToUpper
        End Get
        Set(value As String)
            _source.apellido_01 = value.ToUpper
        End Set
    End Property
    Public Property Apellido02 As String
        Get
            Return _source.apellido_02.ToUpper
        End Get
        Set(value As String)
            _source.apellido_02 = value.ToUpper
        End Set
    End Property
    Public Property TelefonoHabitacion As String
        Get
            Return _source.telefono_01
        End Get
        Set(value As String)
            _source.telefono_01 = value
        End Set
    End Property
    Public Property TelefonoCelular As String
        Get
            Return _source.telefono_02
        End Get
        Set(value As String)
            _source.telefono_02 = value
        End Set
    End Property
    Public Property TelefonoTrabajo As String
        Get
            Return _source.telefono_03
        End Get
        Set(value As String)
            _source.telefono_03 = value
        End Set
    End Property
    Public Property Fax As String
        Get
            Return _source.fax
        End Get
        Set(value As String)
            _source.fax = value
        End Set
    End Property
    Public Property CorreoElectronico As String
        Get
            Return _source.email
        End Get
        Set(value As String)
            _source.email = value
        End Set
    End Property
    Public Property Provincia As ProvinciaObj
        Get
            Return _provincia
        End Get
        Set(value As ProvinciaObj)
            _provincia = Provincia
        End Set
    End Property
    Public Property Canton As CantonObj
        Get
            Return _canton
        End Get
        Set(value As CantonObj)
            _canton = value
        End Set
    End Property
    Public Property Distrito As DistritoObj
        Get
            Return _distrito
        End Get
        Set(value As DistritoObj)
            _distrito = value
        End Set
    End Property
    Public Property Direccion As String
        Get
            Return _source.direccion
        End Get
        Set(value As String)
            _source.direccion = value
        End Set
    End Property
    Public Property FechaNacimiento As Date
        Get
            Dim fecha As Date?

            fecha = _source.fecha_nacimiento
            If fecha Is Nothing Then
                Return Now.Date
            Else
                Return fecha
            End If
        End Get
        Set(value As Date)

        End Set
    End Property
#End Region
    Public Class ProvinciaObj
        Private _source As ProvinciaRow
        Public Sub New()
            _source = New ProvinciaRow
        End Sub
        Public Sub New(source As ProvinciaRow)
            _source = source
        End Sub
        Public Property Codigo As Integer
            Get
                Return _source.provincia
            End Get
            Set(value As Integer)
                _source.provincia = Codigo
            End Set
        End Property
        Public Property Descripcion As String
            Get
                Return _source.descripcion
            End Get
            Set(value As String)
                _source.descripcion = value
            End Set
        End Property
    End Class
    Public Class CantonObj
        Private _source As CantonRow
        Public Sub New()
            _source = New CantonRow
        End Sub
        Public Sub New(source As CantonRow)
            _source = source
        End Sub
        Public Property Codigo As Integer
            Get
                Return _source.canton
            End Get
            Set(value As Integer)
                _source.provincia = Codigo
            End Set
        End Property
        Public Property Descripcion As String
            Get
                Return _source.descripcion
            End Get
            Set(value As String)
                _source.descripcion = value
            End Set
        End Property
    End Class
    Public Class DistritoObj
        Private _source As DistritoRow
        Public Sub New()
            _source = New DistritoRow
        End Sub
        Public Sub New(source As DistritoRow)
            _source = source
        End Sub
        Public Property Codigo As Integer
            Get
                Return _source.distrito
            End Get
            Set(value As Integer)
                _source.provincia = Codigo
            End Set
        End Property
        Public Property Descripcion As String
            Get
                Return _source.descripcion
            End Get
            Set(value As String)
                _source.descripcion = value
            End Set
        End Property
    End Class


End Class
