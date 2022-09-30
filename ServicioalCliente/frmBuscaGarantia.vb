Public Class frmBuscaGarantia
    Private CodCliente As String
    Private Sub frmBuscaGarantia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Public Sub CargarGarantias(ByVal cliente As String, Optional ByVal boleta As String = "", Optional ByVal articulo As String = "")
        Dim lw As LayerWarranty.Warranty
        Dim item As ListViewItem
        Dim i As Integer
        Dim j As Integer
        Dim f As Integer
        Dim AddBoleta As Boolean = False, AddArticulo As Boolean = False
        CodCliente = cliente
        Me.lvArticulos.Items.Clear()
        lw = New LayerWarranty.Warranty(db)
        lw.LoadByClient(cliente)
        If lw.Count > 0 Then
            For i = 1 To lw.Count
                f = lw.Consecutivo(i)
                If boleta <> "" Then
                    If lw.Boleta(i).Contains(boleta) Then
                        AddBoleta = True
                    Else
                        AddBoleta = False
                    End If
                Else
                    AddBoleta = True
                End If
                If AddBoleta Then
                    For j = 1 To lw.Articulos(i).Count
                        If articulo <> "" Then
                            If lw.Articulos(i).Descripcion(j).Contains(articulo) Then
                                AddArticulo = True
                            Else
                                AddArticulo = False
                            End If
                        Else
                            AddArticulo = True
                        End If
                        If AddArticulo Then
                            item = New ListViewItem(lw.Boleta(i))
                            item.SubItems.Add(lw.Fecha(i))
                            item.SubItems.Add(lw.Articulos(i).Descripcion(j))
                            Me.lvArticulos.Items.Add(item)
                        End If
                    Next
                End If
            Next
        End If
    End Sub
    Private Sub cmdSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSeleccionar.Click
        If Me.lvArticulos.SelectedItems.Count = 0 Then
            MessageBox.Show("Debe seleccionar una Boleta de Garantia", "ServicioalCliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        frmMain.txtBoletaGarantia.Text = Me.lvArticulos.SelectedItems(0).Text
        frmMain.cmdMostrarDatos_Click(sender, Nothing)
        Me.Close()

    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub txtBuscarOrden_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscarOrden.TextChanged
        CargarGarantias(CodCliente, Me.txtBuscarOrden.Text, Me.txtBuscarDescripcion.Text)
    End Sub

    Private Sub txtBuscarDescripcion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscarDescripcion.TextChanged
        CargarGarantias(CodCliente, Me.txtBuscarOrden.Text, Me.txtBuscarDescripcion.Text)
    End Sub
End Class