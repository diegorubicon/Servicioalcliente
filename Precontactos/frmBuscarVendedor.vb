Imports TrackingContacts.Data
Public Class frmBuscarVendedor
    Public Event SelectedDistribuidor(_distribudor As Distribuidor)
    Private Sub KryptonButton1_Click(sender As System.Object, e As System.EventArgs) Handles KryptonButton1.Click
        Dim disrepo As DistribuidoresRepository = New DistribuidoresRepository(db)

        Me.lvDistribuidores.Items.Clear()

        For Each dis As Distribuidor In disrepo.SearchByName(Me.txtNombre.Text.Replace(" ", "*"))
            Dim item As ListViewItem = New ListViewItem(dis.id_distribuidor)
            item.Tag = dis
            item.SubItems.Add(dis.nombre + " " + dis.apellido_01 + " " + dis.apellido_02)

            Me.lvDistribuidores.Items.Add(item)

        Next
    End Sub

    Private Sub cmdSeleccionar_Click(sender As System.Object, e As System.EventArgs) Handles cmdSeleccionar.Click
        If Me.lvDistribuidores.SelectedItems.Count > 0 Then
            RaiseEvent SelectedDistribuidor(Me.lvDistribuidores.SelectedItems(0).Tag)
            Me.Close()
        End If
    End Sub

    Private Sub cmdSalir_Click(sender As System.Object, e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub
End Class