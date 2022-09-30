Public Class Payments
    Private data As PaymentsAD
    Private index As Integer
    Private factura As String
    Public Sub New(ByVal f As String)
        data = New PaymentsAD                    'Crea el onjeto de la capa de acceso a datos
        factura = f                              'establece la llave de la clase   
    End Sub
    Public Sub SetDataBaseLogon(ByRef User As String, ByRef Password As String, ByRef server As String)
        data.Usuario = User
        data.Password = Password
        data.Servidor = server
    End Sub
    Public Sub SetConnection(ByRef cnn As SqlClient.SqlConnection)
        data.Connection(cnn)
    End Sub
    Public Sub Load()
        data.Read(factura)
        index = 1
    End Sub
    Public ReadOnly Property MontoTotal(Optional ByVal i As Short = 1) As Double
        Get
            Return data.ValueAt(PaymentsAD.TablePayments.paMonto, i)
        End Get
    End Property
    Public ReadOnly Property Consecutivo(Optional ByVal i As Short = 1) As Integer
        Get
            Dim obj As Object = data.ValueAt(PaymentsAD.TablePayments.paConsecutivo, i)
            If Not (obj Is Nothing) Then
                Return Convert.ToInt32(obj)
            Else
                Return 0
            End If
        End Get
    End Property
    Public ReadOnly Property FechaPago(Optional ByVal i As Short = 1) As Date
        Get
            Dim obj As Object = data.ValueAt(PaymentsAD.TablePayments.paFechaPago, i)
            If Not (obj Is Nothing) Then
                Return Convert.ToDateTime(obj)
            Else
                Return Today()
            End If
        End Get
    End Property
    Public ReadOnly Property Documento(Optional ByVal i As Short = 1) As String
        Get
            Dim obj As Object = data.ValueAt(PaymentsAD.TablePayments.paDocumento, i)
            If Not (obj Is Nothing) Then
                Return Convert.ToString(obj)
            Else
                Return ""
            End If
        End Get
    End Property
    Public ReadOnly Property Banco(Optional ByVal i As Short = 1) As String
        Get
            Dim obj As Object = data.ValueAt(PaymentsAD.TablePayments.paBanco, i)
            If Not (obj Is Nothing) Then
                Return Convert.ToString(obj)
            Else
                Return ""
            End If
        End Get
    End Property
    Public ReadOnly Property FormaPago(Optional ByVal i As Short = 1) As String
        Get
            Dim obj As Object = data.ValueAt(PaymentsAD.TablePayments.paFormaPago, i)
            If Not (obj Is Nothing) Then
                Return Convert.ToString(obj)
            Else
                Return ""
            End If
        End Get
    End Property
    Public ReadOnly Property Aprobado(Optional ByVal i As Short = 1) As Date
        Get
            Dim obj As Object = data.ValueAt(PaymentsAD.TablePayments.paFechaPago, i)
            If Not (obj Is Nothing) Then
                Return Convert.ToDateTime(obj)
            Else
                Return Today()
            End If
        End Get
    End Property
    Public Function Count() As Double
        Return data.Count
    End Function
End Class
