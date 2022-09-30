Option Strict Off
Option Explicit On
Friend Class ClientsAD
    Inherits DataProvider.DataManagement
    Public Enum TableColumns
        Codigo = 1
        Nombre = 2
        PrimerApellido = 3
        SegundoApellido = 4
        Direccion = 5
        Telefono01 = 6
        Telefono02 = 7
        Identificacion = 8
        Provincia = 9
        Canton = 10
        distrito = 11
        Estado = 12
        zona = 13
        MostrarObservacion = 14
        AceptaImpuesto = 15
        Descripcion = 16
        LimiteCredito = 17
        FechaNacimiento = 18
        Fax = 19
        Correo = 20
        Descuento = 21
        VentaMesAnterior = 22
        SaldoVendido = 23
        DiasPlazo = 24
        TipoIdentificacion = 25
        TipoCliente = 26
        Vendedor = 27
        FechaIngreso = 28
        CreadoEl = 29
        CreadoPor = 30
        Observaciones = 31
        'Campos Extra
        animo = 1001
        'Campos Agrupados
        GroupNombre = 2001
    End Enum
#Region "Propiedades"
    Public Property Column(ByVal ColumnName As TableColumns) As TableColumn
        Get
            Return MyBase.Fields(Map(ColumnName))
        End Get
        Set(ByVal value As TableColumn)

        End Set
    End Property
#End Region
    Public Sub New()
        MyBase.TableName = "Clientes"
    End Sub
    Public Sub AddFilter(ByVal ColumnName As TableColumns, ByVal Condition As String, ByVal Value As Object)
        MyBase.Filter.Add(New TableColumn(Map(ColumnName)), Condition, Value)
    End Sub
    Private Function Map(ByRef f As TableColumns) As String
        Select Case f
            Case 1 : Map = "Cliente"
            Case 2 : Map = "nombre"
            Case 3 : Map = "apellido_01"
            Case 4 : Map = "apellido_02"
            Case 5 : Map = "direccion"
            Case 6 : Map = "telefono_01"
            Case 7 : Map = "telefono_02"
            Case 8 : Map = "identificacion"
            Case 9 : Map = "provincia"
            Case 10 : Map = "canton"
            Case 11 : Map = "distrito"
            Case 12 : Map = "estado"
            Case 13 : Map = "zona"
            Case 14 : Map = "mostrar_obs_fact"
            Case 15 : Map = "acepta_impuesto"
            Case 16 : Map = "descripcion"
            Case 17 : Map = "limite_de_credito"
            Case 18 : Map = "Fecha_nacimiento"
            Case 19 : Map = "fax"
            Case 20 : Map = "email"
            Case 21 : Map = "descuento_general"
            Case 22 : Map = "venta_mes_anterior"
            Case 23 : Map = "Saldo_vendido"
            Case 24 : Map = "dias_plazo"
            Case 25 : Map = "tipo_de_identificacion"
            Case 26 : Map = "tipo"
            Case 27 : Map = "vendedor"
            Case 28 : Map = "fecha"
            Case 29 : Map = "creado_el"
            Case 30 : Map = "creado_por"
            Case 31 : Map = "observaciones"
            Case 1001 : Map = "animo"
            Case 2001 : Map = "nombre+' '+apellido_01+' '+apellido_02"
            Case Else : Return ""
        End Select
    End Function
End Class
