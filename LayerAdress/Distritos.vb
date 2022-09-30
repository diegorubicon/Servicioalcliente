Option Strict Off
Option Explicit On
Public Class Distritos
    Private data As DistritosAD
    Public Sub Read(ByRef provincia As String, ByRef Canton As String, ByRef distrito As String)
        Call data.Read(provincia, Canton, distrito)
    End Sub
    Public ReadOnly Property Nombre() As Object
        Get
            Return data.ValueAt(DistritosAD.adTableDistritos.Descripcion)
        End Get
    End Property
    Public ReadOnly Property distrito() As Object
        Get
            Return data.ValueAt(DistritosAD.adTableDistritos.Distrito)
        End Get
    End Property
    Public Sub SetDataBaseLogon(ByRef User As String, ByRef Password As String, Optional ByRef server As String = "Sakif")
        data.Usuario = User
        data.Password = Password
        data.Servidor = server
    End Sub
    Public Sub SetConnection(ByRef cnn As SqlClient.SqlConnection)
        data.Connection(cnn)
    End Sub
    Public Sub New()
        MyBase.New()
        data = New DistritosAD
    End Sub
    Public Sub FillDataCombo(ByRef cmb As ComboBox, ByVal provincia As String, ByVal canton As String)
        data.Read(provincia, canton)
        cmb.DataSource = data.Source
        cmb.DisplayMember = "descripcion"
        cmb.ValueMember = "distrito"
    End Sub
End Class