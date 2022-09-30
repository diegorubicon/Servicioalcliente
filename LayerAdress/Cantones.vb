Option Strict Off
Option Explicit On
Public Class Cantones
    Private data As CantonesAD
    Public Sub New()
        MyBase.New()
        data = New CantonesAD
    End Sub
    Public Sub SetDataBaseLogon(ByRef User As String, ByRef Password As String, Optional ByRef server As String = "")
        data.Usuario = User
        data.Password = Password
        data.Servidor = server
    End Sub
    Public Sub SetConnection(ByRef cnn As SqlClient.SqlConnection)
        data.Connection(cnn)
    End Sub
    Public Sub Read(ByRef provincia As String, ByRef Canton As String)
        Call data.Read(provincia, Canton)
    End Sub
    Public ReadOnly Property Nombre() As Object
        Get
            Return data.ValueAt(CantonesAD.adTableCantones.Descripcion)
        End Get
    End Property
    Public ReadOnly Property Canton() As Short
        Get
            Return data.ValueAt(CantonesAD.adTableCantones.Canton)
        End Get
    End Property
    Public Sub FillDataCombo(ByRef cmb As ComboBox, ByVal provincia As String)
        data.Read(provincia)
        cmb.DataSource = data.Source
        cmb.DisplayMember = "descripcion"
        cmb.ValueMember = "canton"
    End Sub
End Class