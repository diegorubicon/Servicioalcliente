Option Strict Off
Option Explicit On
Public Class Sellers
    Private data As SellersAD     'Referencia a la tercera capa de acceso a datos
    Private attCierreIngreso As LayerCierres.CierreBonos = Nothing
    Private m_CierreActivacion As LayerCierres.CierreBonos = Nothing
    Private m_CierreEjecutivoVentas As LayerCierres.CierreBonos = Nothing
    Private CodeSeller As String
    Private mSeñoria As LayerSellers.Señoria
    '--------------------------------------------------------------------------------------------------------------------------
    'Constructores de la clase
    '--------------------------------------------------------------------------------------------------------------------------
    Public Sub New()
        MyBase.New()
        data = New SellersAD
    End Sub
    Public Sub New(ByRef cnn As SqlClient.SqlConnection, Optional ByVal Seller As String = "")
        MyBase.New()
        data = New SellersAD
        SetConnection(cnn)
        CodeSeller = Seller
    End Sub
    '-----------------------------------------------------------------------------------------------------------------
    'Efecto: Establece las variables para el inicio de sesion con la base de datos
    'Requiere:
    '------------------------------------------------------------------------------------------------------------------
    Public Sub SetDataBaseLogon(ByVal user As String, ByRef pass As String, ByRef server As String)
        data.Password = pass
        data.Usuario = user
        data.Servidor = server
    End Sub
    Public Sub SetConnection(ByRef cnn As SqlClient.SqlConnection)
        data.Connection(cnn)
    End Sub
    Public Sub SetCodeSeller(ByVal Seller As String)
        Me.CodeSeller = Seller
    End Sub
    Public Sub GetInformation()
        data.ReadByVendedor(CodeSeller)
    End Sub
    Public Sub GetVendedoresCierre(ByVal cierre As Integer, Optional ByVal pro As Integer = 0, Optional ByVal can As Integer = 0, Optional ByVal dis As Integer = 0, Optional ByVal nombre As String = "")
        data.ReadByCierreIngreso(cierre, pro, can, dis, nombre)
    End Sub
    Public Sub GetVendedoresFechaVentas(ByVal cierre As Integer, Optional ByVal pro As Integer = 0, Optional ByVal can As Integer = 0, Optional ByVal dis As Integer = 0, Optional ByVal nombre As String = "")
        data.ReadByUltimaVenta(cierre, pro, can, dis, nombre)
    End Sub
    Public Sub GetInformationIngreso(Optional ByVal i As Short = 1)
        attCierreIngreso = New LayerCierres.CierreBonos
        attCierreIngreso.SetCierre(data.ValueAT(SellersAD.TableSellersFields.CierreIngreso, i))
        attCierreIngreso.SetConnection(data.ContextConnection)
        attCierreIngreso.GetInformation()
    End Sub
    Public Sub GetInformationActivate(Optional ByVal i As Short = 1)
        m_CierreActivacion = New LayerCierres.CierreBonos
        m_CierreActivacion.SetCierre(data.ValueAT(SellersAD.TableSellersFields.CierreActivacion, i))
        m_CierreActivacion.SetConnection(data.ContextConnection)
        m_CierreActivacion.GetInformation()
    End Sub
    Public Sub GetInformationEjecutivoVentas(Optional ByVal i As Short = 1)
        m_CierreEjecutivoVentas = New LayerCierres.CierreBonos
        m_CierreEjecutivoVentas.SetCierre(data.ValueAT(SellersAD.TableSellersFields.CierreEjecutivoVentas, i))
        m_CierreEjecutivoVentas.SetConnection(data.ContextConnection)
        m_CierreEjecutivoVentas.GetInformation()
    End Sub
    Public Sub GetInformationSeñoria(Optional ByVal i As Short = 1)
        mSeñoria = New LayerSellers.Señoria
        mSeñoria.SetCodeSeller(data.ValueAT(SellersAD.TableSellersFields.Vendedor, i))
        mSeñoria.SetConnection(data.ContextConnection)
        mSeñoria.GetInformation()
    End Sub
#Region "Metodos Buscadores"
    Public Sub FindSalesManWithName(ByVal Nombre As String)
        Try
            data.ClearFilter()       'Limpia el filtro de los datos
            If Nombre <> "" Then
                data.AddFilter(SellersAD.TableSellersFields.NombreCompleto, SellersAD.SellerSymbol.PartOf, Nombre)
            End If
            data.ReadByVendedor()
        Catch ex As Exception

        End Try
    End Sub
#End Region
    Public Function Count() As Short
        Return data.Count
    End Function
#Region "Metodos GET and SET"
    Public ReadOnly Property Vendedor(Optional ByVal i As Short = 1) As String
        Get
            Return data.ValueAT((SellersAD.TableSellersFields.Vendedor), i)
        End Get
    End Property
    Public ReadOnly Property Nombre(Optional ByVal i As Short = 1) As String
        Get
            Return data.ValueAT((SellersAD.TableSellersFields.Nombre), i)
        End Get
    End Property
    Public ReadOnly Property PrimerApellido(Optional ByVal i As Short = 1) As String
        Get
            Return CStr(data.ValueAT((SellersAD.TableSellersFields.apellido1), i))
        End Get
    End Property
    Public ReadOnly Property SegundoApellido(Optional ByVal i As Short = 1) As Object
        Get
            Return CStr(data.ValueAT((SellersAD.TableSellersFields.apellido1), i))
        End Get
    End Property
    Public ReadOnly Property NombreCompleto(Optional ByVal i As Short = 1) As String
        Get
            Return data.ValueAT((SellersAD.TableSellersFields.Nombre), i) + " " + data.ValueAT((SellersAD.TableSellersFields.apellido1), i) + " " + data.ValueAT((SellersAD.TableSellersFields.apellido2), i)
        End Get
    End Property
    Public ReadOnly Property Estado(Optional ByVal i As Short = 1) As Short
        Get
            Return CShort(data.ValueAT((SellersAD.TableSellersFields.Estado), i))
        End Get
    End Property
    Public ReadOnly Property Telefono1(Optional ByVal i As Short = 1) As String
        Get
            Return data.ValueAT((SellersAD.TableSellersFields.Telefono1), i)
        End Get
    End Property
    Public ReadOnly Property Telefono2(Optional ByVal i As Short = 1) As String
        Get
            Return data.ValueAT((SellersAD.TableSellersFields.Telefono2), i)
        End Get
    End Property
    Public ReadOnly Property Nivel(Optional ByVal i As Short = 1) As Integer
        Get
            Return data.ValueAT(SellersAD.TableSellersFields.nivel, i)
        End Get
    End Property
    Public ReadOnly Property Contrato(Optional ByVal i As Short = 1) As Integer
        Get
            Return data.ValueAT(SellersAD.TableSellersFields.NumeroContrato, i)
        End Get
    End Property
    Public ReadOnly Property FechaUltimaVenta(Optional ByVal i As Short = 1) As String
        Get
            Return data.ValueAT(SellersAD.TableSellersFields.UltimaVenta, i)
        End Get
    End Property
    Public ReadOnly Property Rango(Optional ByVal i As Short = 1) As String
        Get
            Dim n As Integer
            n = data.ValueAT((SellersAD.TableSellersFields.nivel), i)
            Select Case n
                Case 1 : Return "Distribuidor"
                Case 2 : Return "Distribuidor Premiun"
                Case 3 : Return "Ejecutivo"
                Case 4 : Return "Ejecutivo de Ventas con Señoria"
                Case Else : Return ""
            End Select
        End Get
    End Property
    Public ReadOnly Property Email(Optional ByVal i As Short = 1) As String
        Get
            Return data.ValueAT(SellersAD.TableSellersFields.Email, i)
        End Get
    End Property

    Public ReadOnly Property CierreIngreso(Optional ByVal i As Short = 1) As LayerCierres.CierreBonos
        Get
            Return attCierreIngreso
        End Get
    End Property
    Public ReadOnly Property CierreActivacion(Optional ByVal i As Short = 1) As LayerCierres.CierreBonos
        Get
            Return m_CierreActivacion
        End Get
    End Property
    Public ReadOnly Property CierreEjecutivoVentas(Optional ByVal i As Short = 1) As LayerCierres.CierreBonos
        Get
            Return m_CierreEjecutivoVentas
        End Get
    End Property
    Public ReadOnly Property InfoSeñoria(Optional ByVal i As Short = 1) As LayerSellers.Señoria
        Get
            Return mSeñoria
        End Get
    End Property
    Public ReadOnly Property EstadoSeguimiento(Optional ByVal i As Short = 1) As Integer
        Get
            Return data.ValueAT(SellersAD.TableSellersFields.EstadoSeguimiento, i)
        End Get
    End Property


#End Region
End Class