Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Imports System.Threading
Imports System.ComponentModel
Imports System.Windows.Forms.ListViewItem

Public Class frmOrdenesCanceladas
    Private lvwColumnSorter As ListViewColumnSorter
    Private LastIndexSearch As Integer
    Private _lastprovince As Integer, _lastcity As Integer, _lastdistrict As Integer, _startdays As Integer, _enddays As Integer
    Private _opportunity = 0
    Public RowsSelect As ListViewItem
    Private WithEvents frmBuscaVendedor As frmBuscaVendedor = Nothing
    Private Sub frmOrdenesCanceladas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Dim pclear As New TerritorialDivisionLib.Province

        CheckForIllegalCrossThreadCalls = False




        Dim provs As New TerritorialDivisionLib.Provinces

        pclear.Id = 0
        pclear.Name = "TODOS"
        Me.cmbProvincia.Items.Add(pclear)

        For Each p As TerritorialDivisionLib.Province In provs
            Me.cmbProvincia.Items.Add(p)
        Next

        Me.cmbProvincia.SelectedItem = pclear

        Me.cmbCartera.SelectedItem = Me.cmbCartera.Items(0)

        _lastprovince = 0
        _lastcity = 0
        _lastdistrict = 0
        Me.txtVendedor.Tag = ""
        'BackgroundWorker1.WorkerReportsProgress = True
        'BackgroundWorker1.WorkerSupportsCancellation = True
        'BackgroundWorker1.RunWorkerAsync()

    End Sub
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Dim cmd As SqlCommand
        Dim sel As System.Text.StringBuilder
        Dim consec As Double

        If Me.lvOrdenes.SelectedItems.Count = 0 Then
            MessageBox.Show("Debe Seleccionar una orden de pedido", "ServicioalCliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Me.lvOrdenes.SelectedItems(0).BackColor = Color.Aquamarine
        'Crea la gestion postventa
        sel = New System.Text.StringBuilder
        sel.Append("INSERT INTO  gestiones_postventa (fecha_inicio,ejecutivo,factura,dias,estado,creado_por,creado_el) ")
        sel.Append("VALUES (@fecha_inicio,@ejecutivo,@factura,@dias,1,@usuario,getdate ()); ")
        sel.Append("SELECT max(consecutivo) from gestiones_postventa")
        cmd = New SqlCommand(sel.ToString, db)
        cmd.Parameters.Add(New SqlParameter("@fecha_inicio", DateTime.Now))
        cmd.Parameters.Add(New SqlParameter("@ejecutivo", Usuario))
        cmd.Parameters.Add(New SqlParameter("@factura", Me.lvOrdenes.SelectedItems(0).Text))
        cmd.Parameters.Add(New SqlParameter("@dias", Me.lvOrdenes.SelectedItems(0).Tag))
        cmd.Parameters.Add(New SqlParameter("@usuario", Usuario))
        Try
            Me.lvOrdenes.Enabled = False
            consec = cmd.ExecuteScalar

            RowsSelect = Me.lvOrdenes.SelectedItems(0)
            frmSeguimiento.Tipo = 1
            frmSeguimiento.gestion = consec
            frmSeguimiento.factura = Me.lvOrdenes.SelectedItems(0).Text
            frmSeguimiento.Show()
        Catch ex As Exception
            MessageBox.Show("No se pudo ingresar la gestion Post-Venta", "ServicioalCliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cmd.Dispose()
        End Try
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        If (BackgroundWorker1.IsBusy <> True) Then
            BackgroundWorker1.RunWorkerAsync()
        End If
    End Sub
    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        Me.Close()
    End Sub
    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        frmFiltroSeguimientoLlamadas.Show()
    End Sub
    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        frmPassword.ShowDialog()
        If ContraseñaValida Then
            frmDesbloquearBitacoras.Show()
        End If
    End Sub
    Private Sub lvOrdenes_ColumnClick(sender As Object, e As System.Windows.Forms.ColumnClickEventArgs) Handles lvOrdenes.ColumnClick
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
        Me.lvOrdenes.Sort()
    End Sub
    Private Sub lvOrdenes_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lvOrdenes.SelectedIndexChanged

    End Sub
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        lvwColumnSorter = New ListViewColumnSorter()
        Me.lvOrdenes.ListViewItemSorter = lvwColumnSorter
    End Sub
    Private Sub ToolStripButton6_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton6.Click
        frmPostVentaDeshabilitadas.Show()
    End Sub
    Private Sub ToolStripButton7_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton7.Click
        Me.GroupBox1.Visible = Not Me.GroupBox1.Visible
    End Sub
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim item As ListViewItem
        Dim i As Integer

        If Me.txtBuscar.Text.Trim = "" Then
            MessageBox.Show("Debe ingresar el criterio de busqueda", "Servicioalcliente", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If


        For i = LastIndexSearch To Me.lvOrdenes.Items.Count - 1
            If Me.lvOrdenes.Items(i).SubItems(2).Text.Contains(Me.txtBuscar.Text) Or Me.lvOrdenes.Items(i).SubItems(2).Text.Contains(Me.txtBuscar.Text.ToUpper) Then
                item = Me.lvOrdenes.Items(i)
                Exit For
            End If
        Next


        ' item = Me.lvOrdenes.FindItemWithText(Me.txtBuscar.Text, True, LastIndexSearch)
        If item Is Nothing Then

            MessageBox.Show("Finalizo las Busqueda",
                            "Servicio al cliente",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
        Else
            LastIndexSearch = item.Index + 1
            Me.lvOrdenes.SelectedItems.Clear()
            Me.lvOrdenes.Items.Item(item.Index).Selected = True
            Me.lvOrdenes.Select()
            Me.lvOrdenes.Items.Item(item.Index).EnsureVisible()
        End If
    End Sub
    Private Sub txtBuscar_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtBuscar.TextChanged
        Me.LastIndexSearch = 0
    End Sub
    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.GroupBox1.Visible = False
        Me.LastIndexSearch = 0
    End Sub
    Private Sub cmbProvincia_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles cmbProvincia.SelectedValueChanged
        If Not (Me.cmbProvincia.SelectedItem Is Nothing) Then
            Me.cmbCanton.Items.Clear()

            Dim ca As TerritorialDivisionLib.Canton = New TerritorialDivisionLib.Canton
            ca.Id = 0
            ca.Name = "TODOS"
            Me.cmbCanton.Items.Add(ca)
            Me.cmbCanton.SelectedItem = ca

            Dim prov As TerritorialDivisionLib.Province = Me.cmbProvincia.SelectedItem
            If prov.Id > 0 Then
                For Each c As TerritorialDivisionLib.Canton In prov.Cantons
                    Me.cmbCanton.Items.Add(c)
                Next
            End If

        End If
    End Sub
    Private Sub cmbCanton_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles cmbCanton.SelectedValueChanged
        If Not (Me.cmbCanton.SelectedItem Is Nothing) And Not (Me.cmbProvincia.SelectedItem Is Nothing) Then
            Me.cmbDistrito.Items.Clear()

            'agregar el distrito "TODOS"
            Dim pr As TerritorialDivisionLib.District = New TerritorialDivisionLib.District
            pr.Id = 0
            pr.Name = "TODOS"
            Me.cmbDistrito.Items.Add(pr)
            Me.cmbDistrito.SelectedItem = pr

            Dim prov As TerritorialDivisionLib.Province = Me.cmbProvincia.SelectedItem
            Dim cant As TerritorialDivisionLib.Canton = Me.cmbCanton.SelectedItem

            If cant.Id > 0 Then
                'Cargar los distritos del canton
                For Each d As TerritorialDivisionLib.District In cant.Districts
                    Me.cmbDistrito.Items.Add(d)
                Next
            End If
        End If

    End Sub

    Private Sub cmdBuscar_Click(sender As System.Object, e As System.EventArgs) Handles cmdBuscar.Click

        Dim prov As TerritorialDivisionLib.Province = Me.cmbProvincia.SelectedItem
        Dim cant As TerritorialDivisionLib.Canton = Me.cmbCanton.SelectedItem
        Dim dist As TerritorialDivisionLib.District = Me.cmbDistrito.SelectedItem

        If prov Is Nothing Or cant Is Nothing Or dist Is Nothing Then
            Exit Sub
        End If
        If (BackgroundWorker1.IsBusy <> True) Then
            _lastprovince = prov.Id
            _lastcity = cant.Id
            _lastdistrict = dist.Id
            _opportunity = 0

            Select Case Me.cmbCartera.SelectedIndex
                Case 0 : _startdays = 0
                    _enddays = Integer.MaxValue
                Case 1 : _startdays = 0
                    _enddays = 30
                Case 2 : _startdays = 31
                    _enddays = 60
                Case 3 : _startdays = 61
                    _enddays = 90
                Case 4 : _startdays = 91
                    _enddays = 120
                Case 5 : _startdays = 121
                    _enddays = Integer.MaxValue
                Case 6 : _startdays = 0
                    _enddays = Integer.MaxValue
                    _opportunity = 1
            End Select
            BackgroundWorker1.RunWorkerAsync()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.frmBuscaVendedor = New frmBuscaVendedor
        Me.frmBuscaVendedor.Show()
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim item As ListViewItem
        Dim group As ListViewGroup
        Dim grupo As Integer
        Dim MakeGroup As Boolean
        Dim j As Integer
        Me.lvOrdenes.Visible = False
        Me.ProgressBar1.Visible = True
        Me.lvOrdenes.Items.Clear()
        Dim msg As String = ""

        Dim group30 As ListViewGroup, group60 As ListViewGroup, group90 As ListViewGroup, group120 As ListViewGroup, group120plus As ListViewGroup

        group30 = New ListViewGroup("Ordenes Canceladas <= 30")
        group60 = New ListViewGroup("Ordenes Canceladas <= 60")
        group90 = New ListViewGroup("Ordenes Canceladas <= 90")
        group120 = New ListViewGroup("Ordenes Canceladas <= 120")
        group120plus = New ListViewGroup("Ordenes Canceladas > 120")

        Me.lvOrdenes.Groups.Add(group30)
        Me.lvOrdenes.Groups.Add(group60)
        Me.lvOrdenes.Groups.Add(group90)
        Me.lvOrdenes.Groups.Add(group120)
        Me.lvOrdenes.Groups.Add(group120plus)


        Try
            msg = "creando accounts"
            Dim accs As AfterSales.Accounts = New AfterSales.Accounts(Variables.Usuario)
            msg = "recorriendo accounts"
            For Each account As AfterSales.Model.AfterSalesAccount In accs.ToList(_lastprovince, _lastcity, _lastdistrict, _startdays, _enddays, Me.txtVendedor.Tag, _opportunity)
                item = New ListViewItem(account.PurchaseOrder.Number)
                item.SubItems.Add(account.PurchaseOrder.DateOfAdmission)
                item.SubItems.Add(account.Customer.ToString)
                item.SubItems.Add(account.SalesMan.ToString)
                If (account.PurchaseOrder.LastPaymentDate.HasValue) Then
                    item.SubItems.Add(account.PurchaseOrder.LastPaymentDate.Value.ToString("yyyy.MM.dd"))
                Else
                    item.SubItems.Add("")
                End If
                If account.NextCallDate = "12:00:00 AM" Then
                    item.SubItems.Add("")
                Else
                    item.SubItems.Add(account.NextCallDate.ToString("yyyy.MM.dd"))
                End If
                If Not account.LastManager Is Nothing Then
                    item.SubItems.Add(account.LastManager + "(" + account.LastCallStatus + ")")
                Else
                    item.SubItems.Add("")
                End If
                item.SubItems.Add(account.Customer.Interes.Name)
                item.SubItems.Add(account.Customer.Province + " - " + account.Customer.City)
                item.SubItems.Add(account.Customer.HomePhoneNumber)
                item.SubItems.Add(account.Customer.CellPhoneNumber)

                If account.Customer.CreditLevel = "A" Then
                    item.ImageIndex = 0
                End If
                If account.Customer.CreditLevel = "B" Then
                    item.ImageIndex = 1
                End If

                item.Tag = account.DaysOfCancellation
                Select Case account.DaysOfCancellation
                    Case 0 To 30 : item.Group = group30
                    Case 31 To 60 : item.Group = group60
                    Case 61 To 90 : item.Group = group90
                    Case 91 To 120 : item.Group = group120
                    Case Is > 120 : item.Group = group120plus
                End Select

                If account.OpportunityDate.HasValue Then
                    Dim days = (DateTime.Now - account.OpportunityDate.Value).Days
                    Dim c = Color.Black

                    Select Case days
                        Case 0 To 5 : c = Color.Green
                        Case 6 To 10 : c = Color.YellowGreen
                        Case 11 To 15 : c = Color.Orange
                    End Select

                    item.ForeColor = c
                    Dim su As ListViewSubItem
                    For Each su In item.SubItems
                        su.ForeColor = c
                    Next
                End If



                Me.lvOrdenes.Items.Add(item)
                'informar el avance
                'Dim worker As BackgroundWorker = sender
                'worker.ReportProgress(i * 10)

            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message + " " + msg)
        End Try
        Me.lvOrdenes.Sort()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.txtVendedor.Text = ""
        Me.txtVendedor.Tag = ""
    End Sub

    Private Sub AbrirConversacionEnWhatsAppToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirConversacionEnWhatsAppToolStripMenuItem.Click
        If (Me.lvOrdenes.SelectedItems.Count = 0) Then
            Exit Sub
        End If

        Dim phone = Me.lvOrdenes.SelectedItems(0).SubItems(10).Text
        Try
            If Pais = "CR" Then
                System.Diagnostics.Process.Start("whatsapp://send?phone=506" + phone.Replace("-", ""))
            Else
                System.Diagnostics.Process.Start("whatsapp://send?phone=507" + phone.Replace("-", ""))
            End If
        Catch ex As Exception
            MsgBox("No se pudo efectuar la operacion " + ex.Message)
        End Try

    End Sub

    Private Sub ToolStripComboBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged

    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Me.ProgressBar1.Visible = False
        Me.lvOrdenes.Visible = True
    End Sub

    Private Sub frmBuscaVendedor_VendedorSelected(IDVendedor As String, nombre As String) Handles frmBuscaVendedor.VendedorSelected
        Me.txtVendedor.Text = nombre
        Me.txtVendedor.Tag = IDVendedor
    End Sub
End Class