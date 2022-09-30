Imports InvoicingLib
Public Class frmBuscarOrden
    Public cliente As String = ""
    Public tipo As Integer = 1
    Public LastSearch As Integer
    Public Sub CargarOrdenes()



    End Sub
    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Hide()
    End Sub
    Private Sub cmdSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSeleccionar.Click
        If Me.lvArticulos.SelectedItems.Count = 0 Then
            MessageBox.Show("Debe seleccionar una orden de pedido", "ServicioalCliente", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        If tipo = 1 Then
            frmMain.txtFactura.Text = Me.lvArticulos.SelectedItems(0).Text
            frmMain.Button1_Click(sender, Nothing)
            Me.Close()
        Else
            frmMain.txtBoletaGarantia.Text = Me.lvArticulos.SelectedItems(0).Text
            frmMain.cmdMostrarDatos_Click(sender, Nothing)
            Me.Close()
        End If
    End Sub
    Private Sub txtBuscarOrden_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscarOrden.TextChanged
        Me.lvArticulos.Items.Clear()
        If Me.txtBuscarOrden.Text = "" Then
            Exit Sub
        End If


        LastSearch = 1
        Dim item As ListViewItem
        Dim sp As New InvoiceSearchSpecs
        sp.NumberContains = Me.txtBuscarOrden.Text
        sp.CustomerID = cliente
        If Me.ckOrdenesSaldo.Checked Then
            sp.BalanceHigher = 0
        End If

        For Each f As Invoice In New InvoiceBook(sp)
            For Each l As LineDetails In f.Details
                item = New ListViewItem(f.Number)
                item.SubItems.Add(f.Date)
                item.SubItems.Add(l.Item)
                item.SubItems.Add(f.TotalAmount)
                Me.lvArticulos.Items.Add(item)
            Next
        Next

    End Sub

    Private Sub txtBuscarDescripcion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscarDescripcion.TextChanged

    End Sub

    Private Sub ckOrdenesSaldo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckOrdenesSaldo.CheckedChanged
        Select Case LastSearch
            Case 1 : Me.txtBuscarOrden_TextChanged(sender, e)
            Case 2 : Me.txtBuscarDescripcion_TextChanged(sender, e)
        End Select
    End Sub

    Private Sub frmBuscarOrden_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class