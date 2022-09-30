Imports System.Data.SqlClient
Public Class frmDesbloquearBitacoraVendedor

    Private Sub LoadDatos()
        Dim cmd As SqlCommand
        Dim reader As SqlDataReader
        Dim item As ListViewItem
        Me.lvGestiones.Items.Clear()
        cmd = New SqlCommand("Select gpv.fecha_inicio, gpv.ejecutivo, gpv.vendedor,gpv.consecutivo, v.nombre+' '+v.apellido_01+' '+v.apellido_02 as nom_cliente from gestiones_vendedores gpv, vendedores v where gpv.vendedor = v.vendedor and gpv.estado = 1", db)
        Try
            reader = cmd.ExecuteReader
            While reader.Read
                item = New ListViewItem(reader.Item("vendedor").ToString)
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
        cmd = New SqlCommand("UPDATE gestiones_vendedores SET fecha_fin = @fecha_fin , estado = 3 WHERE consecutivo = @gestion", db)
        cmd.Parameters.Add(New SqlParameter("@fecha_fin", DateTime.Now))
        cmd.Parameters.Add(New SqlParameter("@gestion", gestion))
        Try
            cmd.ExecuteNonQuery()
            LoadDatos()
        Catch ex As Exception
            MessageBox.Show("No se pudo desbloquear la bitacora " + ex.Message)
        End Try
    End Sub
    Private Sub lvGestiones_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvGestiones.SelectedIndexChanged

    End Sub
    Private Sub cmdCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCerrar.Click
        Me.Close()
    End Sub
End Class
