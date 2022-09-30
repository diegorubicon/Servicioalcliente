Imports System.Data.SqlClient
Imports System.Text
Public Class AppSecurity
    Public Function getAccesos(cod_perfil As Integer) As Accesos
        Dim cmd As SqlCommand


        Dim query As StringBuilder = New StringBuilder()
        query.Append("SELECT top 1  * ")
        query.Append("FROM accesos_perfil ")
        query.Append("WHERE cod_perfil = @perfil ")

        cmd = New SqlCommand(query.ToString(), db)
        cmd.Parameters.AddWithValue("perfil", cod_perfil)


        Dim reader As SqlDataReader = cmd.ExecuteReader()
        Dim acc As Accesos = New Accesos
        While (reader.Read())
            With acc
                .Clientes = New InfoClientes
                .Clientes.BuscarCliente = reader("buscar_cliente")
                .Clientes.InformacionGeneral = reader("informacion_general_cliente")
                .Clientes.ActualizarDatos = reader("actualizar_datos_cliente")
                .Clientes.Facturacion = reader("facturacion")
                .Clientes.Garantias = reader("garantias")

                .Vendedores.HistoricoCierres = reader("historico_cierres")
                .Vendedores.NiveldelVendedor = reader("nivel_vendedor")
                .Vendedores.InformacionPersonal = reader("informacion_general_vendedor")
                .Vendedores.ActualizarDatos = reader("actualizar_datos_vendedor")
                .Vendedores.Referencia = reader("referencias")
                .Vendedores.Organizacion = reader("organizacion")
                .Vendedores.Ventas.Resumen = reader("resumen")
                .Vendedores.Ventas.VentasPersonales = reader("ventas_personales")
                .Vendedores.Ventas.VentasUnidad = reader("ventas_unidad")
                .Vendedores.Ventas.DetalleVentasUnidad = reader("ventas_unidad_detalle")
                .Vendedores.Ventas.EstadoReclutamiento = reader("estado_Reclutamiento")
                .Vendedores.Ventas.GraficoProvincias = reader("graficos_provincias")
                If Not .Vendedores.Ventas.VentasPersonales And Not .Vendedores.Ventas.VentasUnidad And Not .Vendedores.Ventas.EstadoReclutamiento And Not .Vendedores.Ventas.GraficoProvincias Then
                    .Vendedores.Ventas = Nothing
                End If
            End With
        End While
        reader.Close()
        Return acc
    End Function
End Class
