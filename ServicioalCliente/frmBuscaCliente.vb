Imports CustomerPortfolioLib
Public Class frmBuscaCliente
    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
        If Me.txtBuscar.Text.Length = 0 Then
            MessageBox.Show("Ingrese el criterio de busqueda", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Me.lvClientes.Items.Clear()

        Dim specs As New CustomerSearchSpecs
        specs.FullName.Containts(Me.txtBuscar.Text)
        For Each c As Customer In New CustomerPortfolio(specs)
            Dim item As ListViewItem = New ListViewItem(c.Id)
            item.SubItems.Add(c.FullName)
            item.SubItems.Add(c.CellPhoneNumber)
            Me.lvClientes.Items.Add(item)
        Next
    End Sub
    Private Sub cmdSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSeleccionar.Click
        If Me.lvClientes.SelectedItems.Count > 0 Then
            frmMain.txtCliente.Text = Me.lvClientes.SelectedItems(0).Text
            frmMain.cmdMostrarCliente_Click(sender, e)
            Me.Close()
        End If
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

    Private Sub frmBuscaCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub
End Class