Option Strict Off
Option Explicit On
Public Class Provincias
    Private data As ProvinciasAD
    Public Sub Read(ByRef provincia As String)
        data.Read((provincia))
    End Sub
    Public Property Nombre() As String
        Get
            'UPGRADE_WARNING: Couldn't resolve default property of object data.ValueAt(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Nombre = data.ValueAt(ProvinciasAD.adTableProvincia.Descripcion)
        End Get
        Set(ByVal Value As String)
        End Set
    End Property
    Public Property provincia() As Short
        Get
            'UPGRADE_WARNING: Couldn't resolve default property of object data.ValueAt(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            provincia = data.ValueAt(ProvinciasAD.adTableProvincia.Provincia)
        End Get
        Set(ByVal Value As Short)
        End Set
    End Property
    Public Sub SetDataBaseLogon(ByRef User As String, ByRef Password As String, Optional ByRef server As String = "Sakif")
        data.Usuario = User
        data.Password = Password
        data.Servidor = server
    End Sub
    Public Sub FillDataCombo(ByRef cmb As ComboBox)
        If data.Source Is Nothing Then
            data.Read()
        End If
        cmb.DataSource = data.Source
        cmb.DisplayMember = "descripcion"
        cmb.ValueMember = "provincia"
    End Sub
   
    Public Sub SetConnection(ByRef cnn As SqlClient.SqlConnection)
        data.Connection(cnn)
    End Sub
    Private Sub Class_Initialize_Renamed()
        data = New ProvinciasAD
    End Sub
    Public Sub New()
        MyBase.New()
        Class_Initialize_Renamed()
    End Sub
End Class