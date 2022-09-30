Public Class Promocion
    Private data As PromocionAD
    Private index As Integer
    Public Sub SetDataBaseLogon(ByRef User As String, ByRef Password As String, Optional ByRef server As String = "Sakif")
        data = New PromocionAD
        data.Usuario = User
        data.Password = Password
        data.Servidor = server
    End Sub
    Public Sub Promocion(ByRef promocion As Integer, Optional ByRef showNull As Boolean = False)
        data.Read(promocion)
        index = 1
    End Sub
    Private Function ReturnStringOf(ByRef f As PromocionAD.TablePromocion, Optional ByRef i As Short = 0) As Object
        Dim j As Short
        If data.RowCount > 0 Then
            If i = 1 Then
                data.GetFirstRow()
                index = 1
            End If
            If (i = index) Or (i = 0) Then
                Return data.ValueAt(f)
            Else
                For j = index To i - 1
                    data.GetNextRow()
                Next j
                index = i
                Return data.ValueAt(f)
            End If
        Else
            Return ""
        End If
    End Function
    Public ReadOnly Property Codigo(Optional ByVal i As Short = 0) As Integer
        Get
            Return ReturnStringOf(PromocionAD.TablePromocion.prPromocion, i)
        End Get
    End Property
    Public ReadOnly Property Descripcion(Optional ByVal i As Short = 0) As String
        Get
            Return ReturnStringOf(PromocionAD.TablePromocion.prDescripcion, i)
        End Get
    End Property
End Class
