Imports SalesForceLib
Public Class frmBuscaVendedor
    Public Event VendedorSelected(ByVal IDVendedor As String, ByVal nombre As String)

    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
        Dim item As ListViewItem
        Me.lvClientes.Items.Clear()

        Dim specs As New SalesManSearchSpecs
        specs.FullName.Containts(Me.txtBuscar.Text)

        For Each v As SalesMan In New SalesForce(specs)

            item = New ListViewItem(v.Id)
            item.SubItems.Add(v.FullName)
            item.SubItems.Add(v.PhoneNumber01)
            Me.lvClientes.Items.Add(item)
        Next


    End Sub
    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub
    Private Sub txtBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscar.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            Me.cmdBuscar_Click(sender, Nothing)
        End If
    End Sub
    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged
        Me.lvClientes.Items.Clear()
    End Sub

    Private Sub cmdSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSeleccionar.Click
        If Me.lvClientes.SelectedItems.Count > 0 Then

            RaiseEvent VendedorSelected(Me.lvClientes.SelectedItems(0).Text, Me.lvClientes.SelectedItems(0).SubItems(1).Text)

            Me.Close()
        End If
    End Sub
End Class