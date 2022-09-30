
Public Class Contacto1
    Private _id As Integer
    Dim _nombre As String, _apellido01 As String, _apellido02 As String
    Dim _telefono01 As String, _telefono02 As String, _telefono03 As String
    Dim _email As String
    Public Property ID As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property
    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property
    Public Property Apellido01 As String
        Get
            Return _apellido01
        End Get
        Set(value As String)
            _apellido01 = value
        End Set
    End Property
    Public Property Apellido02 As String
        Get
            Return _apellido02
        End Get
        Set(value As String)
            _apellido02 = value
        End Set
    End Property
    Public ReadOnly Property NombreCompleto As String
        Get
            Return Nombre + " " + Apellido01 + " " + Apellido02
        End Get
    End Property
    Public Property Telefono01 As String
        Get
            Return _telefono01
        End Get
        Set(value As String)
            _telefono01 = value
        End Set
    End Property
    Public Property Telefono02 As String
        Get
            Return _telefono02
        End Get
        Set(value As String)
            _telefono02 = value
        End Set
    End Property
    Public Property Telefono03 As String
        Get
            Return _telefono03
        End Get
        Set(value As String)
            _telefono03 = value
        End Set
    End Property
    Public Property Email As String
        Get
            Return _email
        End Get
        Set(value As String)
            _email = value
        End Set
    End Property
End Class
