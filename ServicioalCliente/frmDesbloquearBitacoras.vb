Imports System.Data.SqlClient
Public Class frmDesbloquearBitacoras
    Private Sub LoadDatos()
        Dim cmd As SqlCommand
        Dim reader As SqlDataReader
        Dim item As ListViewItem
        Me.lvGestiones.Items.Clear()
        cmd = New SqlCommand("Select gpv.fecha_inicio, gpv.ejecutivo, gpv.factura,gpv.consecutivo, c.nombre+' '+c.apellido_01+' '+c.apellido_02 as nom_cliente from gestiones_postventa gpv, facturas_encabezado fe, clientes c where gpv.factura = fe.factura and fe.cliente = c.cliente and gpv.estado = 1", db)
        Try
            reader = cmd.ExecuteReader
            While reader.Read
                item = New ListViewItem(reader.Item("factura").ToString)
                item.SubItems.Add(reader.Item("nom_cliente").ToString)
                item.SubItems.Add(reader.Item("ejecutivo").ToString)
                item.SubItems.Add(reader.Item("consecutivo").ToString)
                item.SubItems.Add(reader.Item("fecha_inicio").ToString)
                Me.lvGestiones.Items.Add(item)
            End While
        Catch ex As Exception

        End Try
    End Sub
    Private Sub frmDesbloquearBitacoras_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadDatos()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDesbloquear.Click
        Dim cmd As SqlCommand
        Dim gestion As String
        If Me.lvGestiones.SelectedItems.Count = 0 Then Exit Sub
        gestion = Me.lvGestiones.SelectedItems(0).SubItems(3).Text
        cmd = New SqlCommand("UPDATE gestiones_postventa SET fecha_fin = @fecha_fin , estado = 3 WHERE consecutivo = @gestion", db)
        cmd.Parameters.Add(New SqlParameter("@fecha_fin", DateTime.Now))
        cmd.Parameters.Add(New SqlParameter("@gestion", gestion))
        Try
            cmd.ExecuteNonQuery()
            LoadDatos()
        Catch ex As Exception
            MessageBox.Show("No se pudo desbloquear la bitacora", "Servicioalcliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub cmdCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCerrar.Click
        Me.Close()
    End Sub
End Class