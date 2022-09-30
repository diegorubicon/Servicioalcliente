Public Class frmPostVentaDeshabilitadas
    Private lvwColumnSorter As ListViewColumnSorter
    Private LastIndexSearch As Integer = 0
    Private Sub frmPostVentaDeshabilitadas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        BackgroundWorker1.WorkerReportsProgress = True
        Me.ToolStripProgressBar1.Maximum = 100
        Me.ToolStripProgressBar1.Minimum = 0
        BackgroundWorker1.RunWorkerAsync()
    End Sub
    Public Sub LoadOrdenes()
        Dim os As AfterSales.PurchaseOrdersTracking
        Dim i As Decimal
        i = 0
        Me.lvOrdenesPostVenta.Items.Clear()
        os = New AfterSales.PurchaseOrdersTracking

        Dim s As List(Of AfterSales.Model.DisableTrackings) = os.GetDisableTrackings

        For Each o As AfterSales.Model.DisableTrackings In s
            AddItemToListView(o)
            i = i + 1
            BackgroundWorker1.ReportProgress((i * 100) / s.Count)
        Next
    End Sub
    Public Sub AddItemToListView(order As AfterSales.Model.DisableTrackings)
        Dim item As ListViewItem = New ListViewItem(order.Sequent)
        item.Tag = order
        item.SubItems.Add(order.PurchaseOrderNumber)
        item.SubItems.Add(order.Customer.Nombre)
        item.SubItems.Add(order.DisableTime.ToShortDateString)
        item.SubItems.Add(order.DisableBy)
        item.SubItems.Add(order.LastNote)
        Me.lvOrdenesPostVenta.Items.Add(item)
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        LoadOrdenes()
    End Sub
    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        Me.ToolStripProgressBar1.Value = e.ProgressPercentage
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Me.lvOrdenesPostVenta.Visible = True
        Me.ToolStripProgressBar1.Visible = False
    End Sub

    Private Sub ToolStripButton2_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton2.Click
        If Me.lvOrdenesPostVenta.SelectedItems.Count = 0 Then
            MessageBox.Show("Debe Seleccionar una orden de pedido deshabilitada",
                            "Sertvicioalcliente",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
            Exit Sub
        End If

        If MessageBox.Show("Confirma habilitar nuevamente el seguimiento de esta orden de pedido",
                           "Servicio al Cliente",
                            MessageBoxButtons.YesNo,
                             MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.No Then
            Exit Sub
        End If


        Dim aSales As AfterSales.PurchaseOrdersTracking = New AfterSales.PurchaseOrdersTracking()

        If aSales.ReactivateTracking(TryCast(Me.lvOrdenesPostVenta.SelectedItems(0).Tag, 
                                     AfterSales.Model.DisableTrackings)) > 0 Then
            Me.lvOrdenesPostVenta.Items.Remove(Me.lvOrdenesPostVenta.SelectedItems(0))
        End If

    End Sub

    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
        frmSeguimiento.Tipo = 2
        frmSeguimiento.factura = Me.lvOrdenesPostVenta.SelectedItems(0).SubItems(1).Text
        frmSeguimiento.Show()
    End Sub

    Private Sub ToolStripButton4_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton4.Click
        Me.Close()
    End Sub

    Private Sub lvOrdenesPostVenta_ColumnClick(sender As Object, e As System.Windows.Forms.ColumnClickEventArgs) Handles lvOrdenesPostVenta.ColumnClick
        ' Determinar si la columna en la que se hizo clic ya es la que se está ordenando. 
        If (e.Column = lvwColumnSorter.SortColumn) Then ' Revertir la dirección de ordenación actual de esta columna. 
            If (lvwColumnSorter.Order = System.Windows.Forms.SortOrder.Ascending) Then
                lvwColumnSorter.Order = System.Windows.Forms.SortOrder.Descending
            Else
                lvwColumnSorter.Order = System.Windows.Forms.SortOrder.Ascending
            End If
        Else ' Establecer el número de columna que se va a ordenar; de forma predeterminada, en orden ascendente. 
            lvwColumnSorter.SortColumn = e.Column
            lvwColumnSorter.Order = System.Windows.Forms.SortOrder.Ascending
        End If

        ' Realizar la ordenación con estas nuevas opciones de ordenación. 
        Me.lvOrdenesPostVenta.Sort()
    End Sub

    Private Sub lvOrdenesPostVenta_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lvOrdenesPostVenta.SelectedIndexChanged

    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        lvwColumnSorter = New ListViewColumnSorter()
        Me.lvOrdenesPostVenta.ListViewItemSorter = lvwColumnSorter
    End Sub

    Private Sub ToolStripButton3_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton3.Click
        LastIndexSearch = 0
        Me.GroupBox1.Visible = Not Me.GroupBox1.Visible
    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim item As ListViewItem = Nothing
        Dim i As Integer
        For i = LastIndexSearch To Me.lvOrdenesPostVenta.Items.Count - 1
            With Me.lvOrdenesPostVenta.Items(i)
                If .SubItems(2).Text.Contains(Me.txtBuscar.Text) Or .SubItems(2).Text.Contains(Me.txtBuscar.Text.ToUpper) Then
                    item = Me.lvOrdenesPostVenta.Items(i)
                    Exit For
                End If

            End With
        Next
        If item Is Nothing Then
            MessageBox.Show("Finalizo las Busqueda",
                            "Servicio al cliente",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
        Else
            LastIndexSearch = item.Index + 1
            Me.lvOrdenesPostVenta.SelectedItems.Clear()
            Me.lvOrdenesPostVenta.Items.Item(item.Index).Selected = True
            Me.lvOrdenesPostVenta.Select()
            Me.lvOrdenesPostVenta.Items.Item(item.Index).EnsureVisible()

        End If
    End Sub

    Private Sub txtBuscar_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtBuscar.TextChanged
        Me.LastIndexSearch = 0
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.GroupBox1.Visible = False
        Me.LastIndexSearch = 0
    End Sub
End Class