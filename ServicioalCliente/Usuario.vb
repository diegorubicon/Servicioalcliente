Imports System.Data.SqlClient
Imports System.Text
Public Class clsUsuario
    Public _id As Integer = 0
    Public _usuario As String
    Public _nombre As String
    Public _apellido1 As String
    Public _apellido2 As String
    Public _perfil As String

    Public AppIn As Boolean = False
    Public Sub New(usuario As String)
        _usuario = usuario
        RetrieveInfo()
    End Sub
    Private Sub RetrieveInfo()
        Dim query As StringBuilder = New StringBuilder
        query.Append("SELECT top 1 codigo, usuario,nombre,apellido_1,apellido_2,cod_perfil_sc ")
        query.Append("FROM tsys_0002 ")
        query.Append("WHERE usuario = @usuario")

        Dim cmd As SqlCommand = New SqlCommand(query.ToString, db)
        cmd.Parameters.AddWithValue("usuario", _usuario)

        Dim reader As SqlDataReader = cmd.ExecuteReader()
        If reader.HasRows Then
            reader.Read()
            _id = reader("codigo")
            _nombre = reader("nombre")
            _apellido1 = reader("apellido_1")
            _apellido2 = reader("apellido_2")
            _perfil = reader("cod_perfil_sc")
            If _perfil > 0 Then
                AppIn = True
            End If
        Else
            AppIn = False
        End If
        reader.Close()
    End Sub
    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property
    Public ReadOnly Property NombreCompleto As String
        Get
            Return _nombre + " " + _apellido1 + " " + _apellido2
        End Get
    End Property
    Public Property Perfil As Integer
        Get
            Return _perfil
        End Get
        Set(value As Integer)
            _perfil = value
        End Set
    End Property
End Class
