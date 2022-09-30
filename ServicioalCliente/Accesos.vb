Public Class InfoClientes
    Public BuscarCliente As Boolean = False
    Public InformacionGeneral As Boolean = False
    Public ActualizarDatos As Boolean = False
    Public Facturacion As Boolean
    Public Garantias As Boolean
End Class
Public Class clsVentas
    Public Resumen As Boolean = False
    Public VentasPersonales As Boolean = False
    Public VentasUnidad As Boolean = False
    Public DetalleVentasUnidad As Boolean = False
    Public EstadoReclutamiento As Boolean = False
    Public GraficoProvincias As Boolean = False
End Class
Public Class InfoVendedores
    Public HistoricoCierres As Boolean = False
    Public NiveldelVendedor As Boolean = False
    Public InformacionPersonal As Boolean = False
    Public ActualizarDatos As Boolean = False
    Public Referencia As Boolean = False
    Public Organizacion As Boolean = False
    Public Ventas As clsVentas
    Public Sub New()
        ventas = New clsVentas
    End Sub
End Class
Public Class Accesos
    Public Clientes As InfoClientes
    Public Vendedores As InfoVendedores

    Public Sub New()
        Clientes = New InfoClientes
        Vendedores = New InfoVendedores
    End Sub
End Class
