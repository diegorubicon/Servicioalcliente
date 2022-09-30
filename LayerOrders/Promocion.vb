Public Class Promocion
    Private data As PromocionAD
    Private index As Integer
    Public Sub SetDataBaseLogon(ByRef User As String, ByRef Password As String, Optional ByRef server As String = "Sakif")
        data.Usuario = User
        data.Password = Password
        data.Servidor = server
    End Sub
    Public Sub SetConnection(ByRef cnn As SqlClient.SqlConnection)
        data.Connection(cnn)
    End Sub
    Public Sub Promocion(ByRef promocion As Integer, Optional ByRef showNull As Boolean = False)
        data.Read(promocion)
    End Sub
    Public ReadOnly Property Codigo(Optional ByVal i As Short = 1) As Integer
        Get
            Return data.ValueAt(PromocionAD.TablePromocion.prPromocion, i)
        End Get
    End Property
    Public ReadOnly Property Descripcion(Optional ByVal i As Short = 1) As String
        Get
            Return data.ValueAt(PromocionAD.TablePromocion.prDescripcion, i)
        End Get
    End Property
    Public Sub New()
        data = New PromocionAD
    End Sub
End Class
