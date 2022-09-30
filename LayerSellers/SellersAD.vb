Option Strict Off
Option Explicit On
Friend Class SellersAD
    Inherits dataprovider.AccessData
    Private filtro As String = ""
    Public Enum TableSellersFields
        Vendedor = 1
        Nombre = 2
        apellido1 = 3
        apellido2 = 4
        Direccion = 5
        Telefono1 = 6
        Telefono2 = 7
        Identificacion = 8
        provincia = 9
        canton = 10
        distrito = 11
        Estado = 12
        nivel = 13
        Lider = 14
        Subnivel = 15
        TipoIdentificacion = 16
        Descuento = 17
        zona = 18
        NumeroContrato = 19
        CodigoCliente = 20
        FechaIngreso = 21
        FechaNacimiento = 11
        Email = 23
        Fax = 24
        MostrarObservacion = 25
        Observacion = 26
        NombreCompleto = 27
        CierreIngreso = 28
        CierreActivacion = 29
        CierreEjecutivoVentas = 30
        UltimaVenta = 31
        EstadoSeguimiento = 32
        'AccountNumber = data.field("cuenta")
        'NoAccount = data.field("fp_sin_cuenta")
        'PayByTransfer = data.field("fp_transferencia")
        'PayByCheque = data.field("fp_cheque")
        'AccountType = data.field("tipo_cuenta")
    End Enum
    Public Enum SellerSymbol
        EqualChr = 1
        StartsWith = 2
        EndWith = 3
        PartOf = 4
    End Enum
    Public Sub ReadByVendedor(Optional ByVal Vendedor As String = "")
        If Vendedor = "" Then
            If filtro = "" Then
                GetData("vendedores", "vendedores")
            Else
                GetData("vendedores", "vendedores", filtro)
            End If
        Else
            If filtro = "" Then
                GetData("vendedores", "vendedores", "vendedor = '" & Vendedor & "'")
            Else
                GetData("vendedores", "vendedores", "vendedor = '" & Vendedor & "' and " & filtro)
            End If
        End If
    End Sub
    Public Sub ReadByCierreIngreso(ByVal cierre As Integer, Optional ByVal provincia As Integer = 0, Optional ByVal canton As Integer = 0, Optional ByVal distrito As Integer = 0, Optional ByVal NombreVendedor As String = "")
        Dim filtro As String
        filtro = "creado_el >= dateadd(month,-3,getdate()) "

        If provincia <> 0 Then
            filtro += " AND provincia = " & CStr(provincia)
        End If
        If canton <> 0 Then
            filtro += " AND canton = " & CStr(canton)
        End If
        If distrito <> 0 Then
            filtro += " AND distrito = " & CStr(distrito)
        End If
        If NombreVendedor <> "" Then
            filtro += " AND nombre+apellido_01+apellido_02 like '%" + Replace(NombreVendedor, " ", "%") + "%'"
        End If
        GetData("vendedores", "vendedores", filtro, "", " cierre_ingreso desc")

    End Sub
    Public Sub ReadByUltimaVenta(ByVal cierre As Integer, Optional ByVal provincia As Integer = 0, Optional ByVal canton As Integer = 0, Optional ByVal distrito As Integer = 0, Optional ByVal NombreVendedor As String = "")
        Dim filtro As String
        filtro = "not vendedor in (Select vendedor from vendedores where cierre_ingreso = " & cierre & ")"
        If provincia <> 0 Then
            filtro += " AND provincia = " & CStr(provincia)
        End If
        If canton <> 0 Then
            filtro += " AND canton = " & CStr(canton)
        End If
        If distrito <> 0 Then
            filtro += " AND distrito = " & CStr(distrito)
        End If
        If NombreVendedor <> "" Then
            filtro += " AND nombre+apellido_01+apellido_02 like '%" + Replace(NombreVendedor, " ", "%") + "%'"
        End If
        filtro += " AND estado <> 2 "
        GetData("vendedores", "vendedores", filtro, , " fecha_ult_venta desc")
    End Sub
    Public Function Count()
        Return MyBase.RowCount("vendedores")
    End Function
    Private Function Map(ByRef f As TableSellersFields) As String
        Select Case f
            Case 1 : Map = "vendedor"
            Case 2 : Map = "nombre"
            Case 3 : Map = "apellido_01"
            Case 4 : Map = "apellido_02"
            Case 5 : Map = "direccion"
            Case 6 : Map = "telefono"
            Case 7 : Map = "telefono_02"
            Case 8 : Map = "identificacion"
            Case 9 : Map = "provincia"
            Case 10 : Map = "canton"
            Case 11 : Map = "distrito"
            Case 12 : Map = "estado"
            Case 13 : Map = "nivel02"
            Case 14 : Map = "promotor_asignado"
            Case 15 : Map = "subnivel"
            Case 16 : Map = "tipo_de_identificacion"
            Case 17 : Map = "descuento"
            Case 18 : Map = "zona"
            Case 19 : Map = "num_contrato"
            Case 20 : Map = "cod_cliente"
            Case 21 : Map = "fecha_ingreso"
            Case 22 : Map = "fecha_nacimiento"
            Case 23 : Map = "correo"
            Case 24 : Map = "fax"
            Case 25 : Map = "Mostrar_obs_fact"
            Case 28 : Map = "cierre_ingreso"
            Case 29 : Map = "activo"
            Case 30 : Map = "cierre_ejecutivo_ventas"
            Case 31 : Map = "fecha_ult_venta"
            Case 32 : Return "estado_seguimiento"
            Case TableSellersFields.NombreCompleto : Return "nombre+' '+apellido_01+' '+apellido_02"
            Case Else : Map = ""
        End Select
    End Function
    Public Sub AddFilter(ByRef f As TableSellersFields, ByRef s As SellerSymbol, ByRef Value As String)
        If filtro = "" Then
            filtro = Map(f) + MapSymbol(s, Value)
        Else
            filtro = filtro & " and " & Map(f) + MapSymbol(s, Value)
        End If
    End Sub
    Public Sub ClearFilter()
        filtro = ""
    End Sub
    Private Function MapSymbol(ByRef s As SellerSymbol, ByRef Value As String) As Object
        Select Case s
            Case 1 : Return " = '" & Value & "'"
            Case 2 : Return " like '" & Value & "%'"
            Case 3 : Return " like %" & Value
            Case 4 : Return " like '%" & Value & "%'"
            Case Else : Return ""
        End Select
    End Function
    Public Property ValueAT(ByVal Column As TableSellersFields, Optional ByVal index As Integer = 0) As Object
        Get
            Return GetValueFromRow("vendedores", Map(Column), index)
        End Get
        Set(ByVal Value As Object)
            SetValueToRow("vendedores", Map(Column), Value)
        End Set
    End Property

End Class