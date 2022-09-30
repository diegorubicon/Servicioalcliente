Namespace Business
    Public Class Precontacto
        Private _source As Data.PreContacto  'Referencia al objeto de la capa de acceso de datos
        Public Sub New()
            _source = New Data.PreContacto
        End Sub
        Public Sub New(source As Data.PreContacto)
            If Not source Is Nothing Then
                _source = source
            Else
                _source = New Data.PreContacto
            End If
        End Sub
        Public Property ID As Integer
            Get
                Return _source.id
            End Get
            Set(value As Integer)
                _source.id = value
            End Set
        End Property
        Public Property Nombre As String
            Get
                Return _source.nombre
            End Get
            Set(value As String)
                _source.nombre = value
            End Set
        End Property
        Public Property Apellido01 As String
            Get
                Return _source.apellido_01
            End Get
            Set(value As String)
                _source.apellido_01 = value
            End Set
        End Property
        Public Property Apellido02 As String
            Get
                Return _source.apellido_02
            End Get
            Set(value As String)
                _source.apellido_02 = value
            End Set
        End Property
        Public ReadOnly Property NombreCompleto As String
            Get
                Return Nombre + " " + Apellido01 + " " + Apellido02
            End Get
        End Property
        Public Property Telefono01 As String
            Get
                Return _source.telefono_01
            End Get
            Set(value As String)
                _source.telefono_01 = value
            End Set
        End Property
        Public Property Telefono02 As String
            Get
                Return _source.telefono_02
            End Get
            Set(value As String)
                _source.telefono_02 = value
            End Set
        End Property
        Public Property Email As String
            Get
                Return _source.email
            End Get
            Set(value As String)
                _source.email = value
            End Set
        End Property
    End Class
End Namespace
