Public Class Señoria
    Private data As LayerSellers.SeñoriaAD
    Private CodeSeller As String
    Private cact01 As LayerCierres.CierreBonos = Nothing
    Private cact02 As LayerCierres.CierreBonos = Nothing
    Private cact03 As LayerCierres.CierreBonos = Nothing
    Private cdect01 As LayerCierres.CierreBonos = Nothing
    Private cdect02 As LayerCierres.CierreBonos = Nothing
    Private cdect03 As LayerCierres.CierreBonos = Nothing
    Private cdect04 As LayerCierres.CierreBonos = Nothing
    Private index As Integer
    Public Sub New()
        MyBase.New()
        data = New SeñoriaAD
        index = 0
    End Sub
    Public Sub New(ByRef cnn As SqlClient.SqlConnection, Optional ByVal Seller As String = "")
        MyBase.New()
        data = New SeñoriaAD
        SetConnection(cnn)
        CodeSeller = Seller
    End Sub
    Public Sub SetConnection(ByRef cnn As SqlClient.SqlConnection)
        data.Connection(cnn)
    End Sub
    Public Sub SetCodeSeller(ByVal Seller As String)
        Me.CodeSeller = Seller
    End Sub
    Public Sub GetInformation()
        data.Read(CodeSeller)
        If Count() > 0 Then
            index = 1
        End If
    End Sub
    Public Sub ClearObjects(ByVal i As Integer)
        If i <> index Then
            index = i
            cact01 = Nothing
            cact02 = Nothing
            cact03 = Nothing
            cdect01 = Nothing
            cdect02 = Nothing
            cdect03 = Nothing
            cdect04 = Nothing
        End If
    End Sub
    Public Function Count() As Short
        Return data.Count
    End Function
    Public ReadOnly Property CierrePromocion01(Optional ByVal i As Integer = 1) As LayerCierres.CierreBonos
        Get
            ClearObjects(i)
            If cact01 Is Nothing Then
                cact01 = New LayerCierres.CierreBonos(data.ValueAT(SeñoriaAD.TableSeñoria.CierrePromocion01, i), data.ContextConnection)
                cact01.GetInformation()
            End If
            Return cact01
        End Get
    End Property
    Public ReadOnly Property CierrePromocion02(Optional ByVal i As Integer = 1) As LayerCierres.CierreBonos
        Get
            ClearObjects(i)
            If cact02 Is Nothing Then
                cact02 = New LayerCierres.CierreBonos(data.ValueAT(SeñoriaAD.TableSeñoria.CierrePromocion02, i), data.ContextConnection)
                cact02.GetInformation()
            End If
            Return cact02
        End Get
    End Property
    Public ReadOnly Property CierrePromocion03(Optional ByVal i As Integer = 1) As LayerCierres.CierreBonos
        Get
            ClearObjects(i)
            If cact03 Is Nothing Then
                cact03 = New LayerCierres.CierreBonos(data.ValueAT(SeñoriaAD.TableSeñoria.CierrePromocion03, i), data.ContextConnection)
                cact03.GetInformation()
            End If
            Return cact03
        End Get
    End Property
    Public ReadOnly Property CierreDesactivacion01(Optional ByVal i As Integer = 1) As LayerCierres.CierreBonos
        Get
            ClearObjects(i)
            If cdect01 Is Nothing Then
                cdect01 = New LayerCierres.CierreBonos(data.ValueAT(SeñoriaAD.TableSeñoria.CierreDesactivacion01, i), data.ContextConnection)
                cdect01.GetInformation()
            End If
            Return cdect01
        End Get
    End Property
    Public ReadOnly Property CierreDesactivacion02(Optional ByVal i As Integer = 1) As LayerCierres.CierreBonos
        Get
            ClearObjects(i)
            If cdect02 Is Nothing Then
                cdect02 = New LayerCierres.CierreBonos(data.ValueAT(SeñoriaAD.TableSeñoria.CierreDesactivacion02, i), data.ContextConnection)
                cdect02.GetInformation()
            End If
            Return cdect02
        End Get
    End Property
    Public ReadOnly Property CierreDesactivacion03(Optional ByVal i As Integer = 1) As LayerCierres.CierreBonos
        Get
            ClearObjects(i)
            If cdect03 Is Nothing Then
                cdect03 = New LayerCierres.CierreBonos(data.ValueAT(SeñoriaAD.TableSeñoria.CierreDesactivacion03, i), data.ContextConnection)
                cdect03.GetInformation()
            End If
            Return cdect03
        End Get
    End Property
    Public ReadOnly Property CierreDesactivacion04(Optional ByVal i As Integer = 1) As LayerCierres.CierreBonos
        Get
            ClearObjects(i)
            If cdect04 Is Nothing Then
                cdect04 = New LayerCierres.CierreBonos(data.ValueAT(SeñoriaAD.TableSeñoria.CierreDesactivacion04, i), data.ContextConnection)
                cdect04.GetInformation()
            End If
            Return cdect04
        End Get
    End Property
End Class
