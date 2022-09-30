Imports System.Data.SqlClient
Imports System.Threading
Imports System.Linq
Imports SalesForceLib
Imports SalesForceTracking
Public Class frmVendedores
    Private trd As Thread
    Dim cierre As Integer
    Dim Mes As String
    Dim provincia As TerritorialDivisionLib.Province
    Dim canton As TerritorialDivisionLib.Canton
    Dim distrito As TerritorialDivisionLib.District
    Dim BitacoraExtendida As Integer
    Dim FirstView As Boolean = True
    Dim GroupMode As Integer
    Private lvwColumnSorter As ListViewColumnSorter
    Private Class ProximaLlamda
        Public vendedor As String
        Public index As Integer
        Public Sub New(ByVal mvendedor As String, ByVal mindex As Integer)
            vendedor = mvendedor
            index = mindex
        End Sub
    End Class
    Private Sub frmVendedores_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If Not trd Is Nothing Then
            If trd.ThreadState = 4 Then
                trd.Abort()
            End If
        End If
    End Sub
    Private Sub frmVendedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'obtiene el cierre actual kitchen fair
        CheckForIllegalCrossThreadCalls = False
        GroupMode = My.Settings.VendedoresGroupMode
        Try
            Dim provs As New TerritorialDivisionLib.Provinces
            For Each p As TerritorialDivisionLib.Province In provs
                Me.cmbProvincia.Items.Add(p)
            Next
            Me.cmbProvincia.DisplayMember = "Name"

            'Obtiene el cierre actual
            Using cmd = New SqlCommand("GetCierre", db)
                cmd.CommandType = CommandType.StoredProcedure
                Using da = New SqlDataAdapter
                    da.SelectCommand = cmd

                    Using ds = New DataSet
                        da.Fill(ds)
                        If ds.Tables(0).Rows.Count > 0 Then
                            cierre = Convert.ToInt32(ds.Tables(0).Rows(0).Item("cod_cierre").ToString)
                            Mes = ds.Tables(0).Rows(0).Item("mes").ToString
                            Me.tssLbCierre.Text = Mes

                            trd = New Thread(AddressOf LoadVendedores)
                            trd.Start()
                        End If
                    End Using
                End Using
            End Using

            'Obtiene los parametros del programa
            Using da As SqlDataAdapter = New SqlDataAdapter("SELECT * FROM parametros_servicio_cliente", db)
                Using ds As DataSet = New DataSet()
                    da.Fill(ds)
                    With ds.Tables(0)
                        If .Rows.Count > 0 Then
                            BitacoraExtendida = CType(.Rows(0).Item("bitacora_extendida"), Integer)
                        Else
                            BitacoraExtendida = 0
                        End If
                    End With
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ServicioalCliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub LoadVendedores()
        Dim item As ListViewItem
        Dim group As ListViewGroup
        Dim dias As Integer = 0


        Me.tspbLoading.Visible = True
        Me.tsslCancel.Visible = True
        Me.lvVendedores.Visible = False
        Me.lvVendedores.Items.Clear()
        Me.lvVendedores.Groups.Clear()

        group = New ListViewGroup("01. Nuevos Vendedores (Ultimos 3 Meses)")
        Dim group30 = New ListViewGroup("02. Ventas <= 30 Dias")
        Dim group60 = New ListViewGroup("03. Ventas <= 60 Dias")
        Dim group90 = New ListViewGroup("04. Ventas <= 90 dias")
        Dim groupmas90 = New ListViewGroup("05. Ventas > 90 dias")
        Dim groupsv = New ListViewGroup("06. Sin Ventas")

        Dim group1 = New ListViewGroup("01. Ventas <= 1 Año")
        Dim group2 = New ListViewGroup("02. Ventas <= 2 Años")
        Dim group3 = New ListViewGroup("03. Ventas <= 3 Años")
        Dim group4 = New ListViewGroup("04. Ventas > 3 Años")

        If GroupMode = 1 Then
            Me.lvVendedores.Groups.Add(group)
            Me.lvVendedores.Groups.Add(group30)
            Me.lvVendedores.Groups.Add(group60)
            Me.lvVendedores.Groups.Add(group90)
            Me.lvVendedores.Groups.Add(groupmas90)
            Me.lvVendedores.Groups.Add(groupsv)
        Else
            Me.lvVendedores.Groups.Add(group1)
            Me.lvVendedores.Groups.Add(group2)
            Me.lvVendedores.Groups.Add(group3)
            Me.lvVendedores.Groups.Add(group4)
            Me.lvVendedores.Groups.Add(groupsv)
        End If

        Dim force As SalesForce
        Dim specs As New SalesForceLib.SalesManSearchSpecs
        specs.Status.NotEqual(2)
        If Me.CheckBox2.Checked Then
            specs.TrackingStatus.NotEqual(2)
        End If

        If FirstView Then
            'Muestra los valores al inicio
            If GroupMode = 1 Then
                Dim datespecs As New SalesManSearchSpecs
                datespecs.DateOfAdmission.GreatherorEqualThan(DateTime.Now.AddMonths(-3))

                Dim sales As New SalesManSearchSpecs
                sales.LastSaleDate.GreatherorEqualThan(Date.Now.AddDays(-30))

                force = New SalesForce(specs + (datespecs * sales))
            Else
                Dim sales As New SalesManSearchSpecs
                sales.LastSaleDate.GreatherorEqualThan(Date.Now.AddDays(-365))

                force = New SalesForce(specs + sales)

            End If
        Else
            If Me.txtBuscar.Text.Length > 0 Then
                specs.FullName.Containts(Me.txtBuscar.Text)
            End If
            If Me.CheckBox1.Checked = True Then
                specs.Province = Me.cmbProvincia.SelectedItem
            End If
            If Me.ckCanton.Checked Then
                specs.Canton = Me.cmbCanton.SelectedItem
            End If
            If Me.ckDistrito.Checked Then
                specs.District = Me.cmbDistrito.SelectedItem
            End If

            force = New SalesForce(specs)
        End If

        Dim i As Integer = 0
        Me.tspbLoading.Maximum = force.Count
        Me.tspbLoading.Value = 0

        'Obtener todos los vendedores
        Try


            For Each s As SalesMan In force.OrderByDescending(Function(sa As SalesMan) sa.LastSaleDate)
                SetValue(i)
                item = New ListViewItem(s.TrackingStatus.ToString(), s.TrackingStatus)
                item.SubItems.Add(s.Id)
                item.SubItems.Add(s.ContractNumber)
                item.SubItems.Add(s.FullName)
                If s.LastSaleDate.HasValue Then
                    item.SubItems.Add(s.LastSaleDate.Value.ToString("yyyy-MM-dd"))
                Else
                    item.SubItems.Add("")
                End If
                If s.SummaryCall.PreviousCall.HasValue Then
                    item.SubItems.Add(s.SummaryCall.PreviousCall.Value.ToString("yyyy-MM-dd"))

                    If s.SummaryCall.PreviousCall.Value.Day = DateTime.Now.Day And
                            s.SummaryCall.PreviousCall.Value.Month = DateTime.Now.Month And
                            s.SummaryCall.PreviousCall.Value.Year = DateTime.Now.Year Then

                        SetLineHighLigh(item, s.SummaryCall.Status)
                    End If
                Else
                    item.SubItems.Add("")
                End If
                If s.SummaryCall.NextCall.HasValue Then
                    item.SubItems.Add(s.SummaryCall.NextCall.Value.ToString("yyyy-MM-dd"))
                Else
                    item.SubItems.Add("")
                End If
                item.SubItems.Add(s.Email)
                Select Case s.SummaryCall.Status
                    Case 1 : item.SubItems.Add("A")
                    Case 2 : item.SubItems.Add("B")
                    Case 3 : item.SubItems.Add("C")
                    Case Else : item.SubItems.Add("")
                End Select
                If s.SummaryCall.LastContact.HasValue Then
                    Dim lc As DateTime = Convert.ToDateTime(s.SummaryCall.LastContact.Value.ToShortDateString)
                    Dim diff As TimeSpan = DateTime.Today.Subtract(lc)
                    item.SubItems.Add(diff.Days)
                End If

                If GroupMode = 1 Then
                    If s.DateOfAdmission >= DateTime.Now.AddMonths(-3) Then
                        item.Group = group
                    Else
                        If (s.LastSaleDate.HasValue()) Then
                            Dim tsTimeSpan As TimeSpan
                            tsTimeSpan = DateTime.Now.Subtract(s.LastSaleDate)
                            dias = (tsTimeSpan.Days)
                        Else
                            dias = -1
                        End If
                        Select Case dias
                            Case -1 : item.Group = groupsv
                            Case 0 To 30 : item.Group = group30
                            Case 31 To 60 : item.Group = group60
                            Case 61 To 90 : item.Group = group90
                            Case Is > 90 : item.Group = groupmas90
                        End Select
                    End If
                Else
                    If (s.LastSaleDate.HasValue) Then
                        Dim tsTimeSpan As TimeSpan
                        tsTimeSpan = DateTime.Now.Subtract(s.LastSaleDate)
                        dias = (tsTimeSpan.Days)
                    Else
                        dias = -1
                    End If
                    Select Case dias
                        Case -1 : item.Group = groupsv
                        Case 0 To 365 : item.Group = group1
                        Case 366 To 730 : item.Group = group2
                        Case 367 To 1095 : item.Group = group3
                        Case Is > 1095 : item.Group = group4
                    End Select
                End If

                If s.DateOfBirth.Day = DateTime.Now.Day And s.DateOfBirth.Month = DateTime.Now.Month Then
                    item.Font = New Font(lvVendedores.Font, FontStyle.Bold)
                End If
                item.Tag = s

                Me.lvVendedores.Items.Add(item)
                i += 1

            Next
            Me.lvVendedores.Visible = True
            Me.tspbLoading.Visible = False
            Me.tsslCancel.Visible = False
            SetValue(0)
        Catch ex As Exception
            MessageBox.Show("No se pudo cargar la informacion de los vendedores " + ex.Message, "Servicioalcliente", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Dim cmd As SqlCommand
        Dim sel As System.Text.StringBuilder
        Dim consec As Double

        If Me.lvVendedores.SelectedItems.Count = 0 Then
            MessageBox.Show("Debe Seleccionar un vendedor", "ServicioalCliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Using db As SqlConnection = New SqlConnection(Variables.ConnectionString)
            'Crea la gestion postventa
            sel = New System.Text.StringBuilder
            sel.Append("INSERT INTO  gestiones_vendedores (fecha_inicio,ejecutivo,vendedor,estado,creado_por,creado_el) ")
            sel.Append("VALUES (@fecha_inicio,@ejecutivo,@vendedor,1,@usuario,getdate ()); ")
            sel.Append("SELECT max(consecutivo) from gestiones_vendedores")
            cmd = New SqlCommand(sel.ToString, db)
            cmd.Parameters.Add(New SqlParameter("@fecha_inicio", DateTime.Now))
            cmd.Parameters.Add(New SqlParameter("@ejecutivo", Usuario))
            cmd.Parameters.Add(New SqlParameter("@vendedor", Me.lvVendedores.SelectedItems(0).SubItems(1).Text))
            cmd.Parameters.Add(New SqlParameter("@usuario", Usuario))
            Try
                db.Open()
                consec = cmd.ExecuteScalar
                db.Close()
            Catch ex As Exception
                consec = -1
                MessageBox.Show("No se pudo ingresar la gestion Seguimiento Vendedores " + ex.Message, _
                                "ServicioalCliente", _
                                MessageBoxButtons.OK, _
                                MessageBoxIcon.Error)
                Exit Sub
            Finally
                cmd.Dispose()
            End Try
        End Using
        If BitacoraExtendida = 1 Then
            Dim frmbitacora As New FrmBitacoraVendedoresExtend
            frmbitacora.FormPadre = Me
            frmbitacora.line = Me.lvVendedores.SelectedItems(0)
            frmbitacora.CodigoVendedor = Me.lvVendedores.SelectedItems(0).SubItems(1).Text
            frmbitacora.Gestion = consec
            frmbitacora.Cierre = cierre
            frmbitacora.Show()
        End If
    End Sub
    Private Sub cmbProvincia_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbProvincia.SelectedValueChanged
        Me.cmbCanton.Items.Clear()
        If Me.cmbProvincia.SelectedItem Is Nothing Then Exit Sub

        For Each c As TerritorialDivisionLib.Canton In CType(Me.cmbProvincia.SelectedItem, TerritorialDivisionLib.Province).Cantons
            Me.cmbCanton.Items.Add(c)
        Next
    End Sub
    Private Sub cmbCanton_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCanton.SelectedValueChanged
        Me.cmbDistrito.Items.Clear()
        If Me.cmbCanton.SelectedItem Is Nothing Then Exit Sub

        Dim c As TerritorialDivisionLib.Canton = Me.cmbCanton.SelectedItem

        For Each d As TerritorialDivisionLib.District In c.Districts
            Me.cmbDistrito.Items.Add(d)
        Next
        Me.cmbDistrito.DisplayMember = "Name"
    End Sub
    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        If trd Is Nothing Or trd.ThreadState = 4 Then
            trd.Abort()
        End If
        If Not trd Is Nothing Then
            If trd.ThreadState = ThreadState.Running Then
                Try
                    trd.Abort()
                Catch ex As Exception

                End Try
            End If
        End If
        trd = New Thread(AddressOf LoadVendedores)
        trd.Start()
    End Sub
    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        If trd Is Nothing Or trd.ThreadState = 4 Then
            trd.Abort()
        End If
        If Not trd Is Nothing Then
            If trd.ThreadState = ThreadState.Running Then
                Try
                    trd.Abort()
                Catch ex As Exception

                End Try
            End If
        End If
        Me.Close()
    End Sub
    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        frmPassword.ShowDialog()
        If ContraseñaValida Then
            frmDesbloquearBitacoraVendedor.Show()
        End If
    End Sub
    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
        FirstView = False
        If trd Is Nothing Or trd.ThreadState = 4 Then
            trd.Abort()
        End If
        If Not trd Is Nothing Then
            If trd.ThreadState = ThreadState.Running Then
                Try
                    trd.Abort()
                Catch ex As Exception

                End Try
            End If
        End If

        provincia = Me.cmbProvincia.SelectedItem
        If Me.ckCanton.Checked Then
            canton = Me.cmbCanton.SelectedItem
        End If
        If Me.ckDistrito.Checked Then
            distrito = Me.cmbDistrito.SelectedItem
        End If

        trd = New Thread(AddressOf LoadVendedores)
        trd.Start()

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        FirstView = False
        If trd Is Nothing Or trd.ThreadState = 4 Then
            trd.Abort()
        End If
        If Not trd Is Nothing Then
            If trd.ThreadState = ThreadState.Running Then
                Try
                    trd.Abort()
                Catch ex As Exception

                End Try
            End If
        End If
        provincia = Nothing
        canton = Nothing
        distrito = Nothing
        Me.ckDistrito.Checked = False
        Me.ckCanton.Checked = False
        Me.CheckBox1.Checked = False

        trd = New Thread(AddressOf LoadVendedores)
        trd.Start()
        'LoadVendedores()
    End Sub
    Private Sub ckCanton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckCanton.CheckedChanged
        Me.cmbCanton.Enabled = Me.ckCanton.Checked
        If Me.ckCanton.Checked = False Then
            canton = Nothing
        End If
    End Sub
    Private Sub ckDistrito_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckDistrito.CheckedChanged
        Me.cmbDistrito.Enabled = Me.ckDistrito.Checked
        If Me.ckDistrito.Checked = False Then
            distrito = Nothing
        End If
    End Sub
    Private Sub InformeDeSeguimientoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InformeDeSeguimientoToolStripMenuItem.Click
        frmFiltroSeguimientoLlamadas.tipo = 2
        frmFiltroSeguimientoLlamadas.Show()
    End Sub
    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton6.Click

        frmMakeMeeting.Show()
    End Sub
    Private Sub ToolStripButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton7.Click
        If Me.lvVendedores.SelectedItems.Count = 0 Then
            MessageBox.Show("Debe seleccionar un vendedor", "ServicioalCliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        FrmJoinMeeting.vendedor = Me.lvVendedores.SelectedItems(0).SubItems(1).Text
        FrmJoinMeeting.Show()
    End Sub
    Private Sub ToolStripButton4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        If trd Is Nothing Or trd.ThreadState = 4 Then
            Exit Sub
        End If
        If Not trd Is Nothing Then
            If trd.ThreadState = ThreadState.Running Then
                Try
                    trd.Abort()
                Catch ex As Exception

                End Try
            End If
        End If
        trd = New Thread(AddressOf LoadVendedores)
        trd.Start()
    End Sub
    Private Sub lvVendedores_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles lvVendedores.ColumnClick
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
        Me.lvVendedores.Sort()
    End Sub
    Private Sub lvVendedores_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lvVendedores.MouseClick
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            Me.lvVendedores.ContextMenuStrip.Show()
        End If
    End Sub
    Private Sub ModificarCorreoElectronicoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarCorreoElectronicoToolStripMenuItem.Click
        If Me.lvVendedores.SelectedItems.Count = 0 Then
            MessageBox.Show("Debe seleccionar un vendedor", "ServicioalCliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        frmEditEmail.vendedor = Me.lvVendedores.SelectedItems(0).SubItems(1).Text
        frmEditEmail.lbVendedor.Text = Me.lvVendedores.SelectedItems(0).SubItems(3).Text
        frmEditEmail.TextBox1.Text = Me.lvVendedores.SelectedItems(0).SubItems(7).Text
        frmEditEmail.Show()
    End Sub
    Private Sub DesactivarVendedorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DesactivarVendedorToolStripMenuItem.Click
        If Me.lvVendedores.SelectedItems.Count = 0 Then
            MessageBox.Show("Debe seleccionar un vendedor", "ServicioalCliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        frmDeactivateVendedor.vendedor = Me.lvVendedores.SelectedItems(0).SubItems(1).Text
        frmDeactivateVendedor.txtVendedor.Text = Me.lvVendedores.SelectedItems(0).SubItems(3).Text
        frmDeactivateVendedor.Show()
    End Sub
    Private Sub AsistenciaActividadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AsistenciaActividadToolStripMenuItem.Click
        frmFiltroActividades.Show()
    End Sub
    Private Sub VendedoresInactivosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VendedoresInactivosToolStripMenuItem.Click
        With frmVistaPrevia
            .TypeReport = frmVistaPrevia.Reports.VendedoresInactivos
            .selectionformula = ""
            .AddFormula("compania", "Master Cocina")
            .AddFormula("fecha", DateTime.Now.ToShortDateString)
            .AddFormula("v_usuario", Usuario)
            .Show()
        End With
    End Sub
    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        lvwColumnSorter = New ListViewColumnSorter()
        Me.lvVendedores.ListViewItemSorter = lvwColumnSorter
    End Sub
    Private Sub EstadoVerdeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EstadoVerdeToolStripMenuItem.Click
        Dim cmd As SqlCommand
        Dim opara As SqlParameter
        Dim rst As Long

        If Me.lvVendedores.SelectedItems.Count = 0 Then
            MessageBox.Show("Debe seleccionar un vendedor", "ServicioalCliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        cmd = New SqlCommand("sp_ChangeStateVendedor", db)
        cmd.CommandType = CommandType.StoredProcedure
        opara = New SqlParameter("@vendedor", Me.lvVendedores.SelectedItems(0).SubItems(1).Text)
        cmd.Parameters.Add(opara)
        opara = New SqlParameter("@estado", 0)
        cmd.Parameters.Add(opara)
        Try
            If Not db.State = ConnectionState.Open Then
                db.Open()
            End If

            rst = cmd.ExecuteNonQuery
            Me.lvVendedores.SelectedItems(0).ImageIndex = 0
            Me.lvVendedores.SelectedItems(0).Text = 0
        Catch ex As Exception
            MessageBox.Show("No se puede cambiar el estado del  vendedor " + ex.Message, "ServicioalCliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub
    Private Sub EstadoAmarilloToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EstadoAmarilloToolStripMenuItem.Click
        Dim cmd As SqlCommand
        Dim opara As SqlParameter
        Dim rst As Long

        If Me.lvVendedores.SelectedItems.Count = 0 Then
            MessageBox.Show("Debe seleccionar un vendedor", "ServicioalCliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        cmd = New SqlCommand("sp_ChangeStateVendedor", db)
        cmd.CommandType = CommandType.StoredProcedure
        opara = New SqlParameter("@vendedor", Me.lvVendedores.SelectedItems(0).SubItems(1).Text)
        cmd.Parameters.Add(opara)
        opara = New SqlParameter("@estado", 1)
        cmd.Parameters.Add(opara)
        Try
            If Not db.State = ConnectionState.Open Then
                db.Open()
            End If

            rst = cmd.ExecuteNonQuery
            Me.lvVendedores.SelectedItems(0).ImageIndex = 1
            Me.lvVendedores.SelectedItems(0).Text = 1
        Catch ex As Exception
            MessageBox.Show("No se puede cambiar el estado del  vendedor " + ex.Message, "ServicioalCliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub
    Private Sub EstadoRojoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EstadoRojoToolStripMenuItem.Click
        Dim cmd As SqlCommand
        Dim opara As SqlParameter
        Dim rst As Long

        If Me.lvVendedores.SelectedItems.Count = 0 Then
            MessageBox.Show("Debe seleccionar un vendedor", "ServicioalCliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        cmd = New SqlCommand("sp_ChangeStateVendedor", db)
        cmd.CommandType = CommandType.StoredProcedure
        opara = New SqlParameter("@vendedor", Me.lvVendedores.SelectedItems(0).SubItems(1).Text)
        cmd.Parameters.Add(opara)
        opara = New SqlParameter("@estado", 2)
        cmd.Parameters.Add(opara)
        Try
            If Not db.State = ConnectionState.Open Then
                db.Open()
            End If

            rst = cmd.ExecuteNonQuery
            Me.lvVendedores.SelectedItems(0).ImageIndex = 2
            Me.lvVendedores.SelectedItems(0).Text = 2
        Catch ex As Exception
            MessageBox.Show("No se puede cambiar el estado del  vendedor " + ex.Message, "ServicioalCliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub
    'Si InvokeRequired es verdadero, si es así, quiere decir que el hilo en el que está actualmente esa llamada 
    'es diferente al hilo en el que se creó el control, por tanto, creamos un nuevo objeto del tipo del delegado, 
    'le indicamos que método debe usar y a continuación llamamos al método Invoke de nuestro formulario, 
    'cuando se entre nuevamente en ese método (porque el formulario lo "invoca") el valor que devolverá la propiedad InvokeRequired será False, 
    'ya que el hilo en el que está es el mismo en el que se creó el control, ya que es el mismo hilo usado por el formulario... vamos, como si entráramos por la puerta falsa... De esta forma se podrá asignar el valor a la propiedad Text, ya que estamos usando el mismo hilo.

    'Lo primero que se debe hacer para definir un delegado es indicar cuál será la firma de las funciones a la que ese delegado 
    'podrá apuntar (por firma se entiende el tipo de datos de los parámetros que se reciben, y el tipo de datos que se retorna):
    Delegate Sub SetTextCallback(ByVal value As Integer)
    Private Sub SetValue(ByVal value As Integer)
        ' InvokeRequired required compares the thread ID of the
        ' calling thread to the thread ID of the creating thread.
        ' If these threads are different, it returns true.
        If Me.tspbLoading.ProgressBar.InvokeRequired Then
            'El segundo paso consiste en definir las variables que almacenarán los punteros de las funciones que se invocarán a través del delegado. 
            'Para mayor claridad llamaremos a esta variable apuntador. 
            'Estas variables deben ser del tipo de datos del delegado (definido en el paso anterior):
            'Dim d As New SetTextCallback(AddressOf SetValue)  Sintaxis mas corta
            Dim d As SetTextCallback = Nothing
            'Una vez definida la firma del delegado y declarado el apuntador (variable del tipo de delegado) para invocar las funciones, 
            'el tercer paso consiste en indicar cuáles serán esas funciones. 
            d = [Delegate].Combine(d, New SetTextCallback(AddressOf SetValue))

            Me.Invoke(d, New Object() {value})
        Else
            Me.tspbLoading.ProgressBar.Value = value
        End If
    End Sub

    Private Function formatFecha(ByVal f As Date) As String
        Dim dia As String, month As String, year As String

        dia = f.Day.ToString
        month = f.Month.ToString
        year = f.Year.ToString

        If dia.Length = 1 Then
            dia = "0" + dia
        End If
        If month.Length = 1 Then
            month = "0" + month
        End If
        Return year + "-" + month + "-" + dia

    End Function
    Private Sub ToolStripButton8_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton8.Click
        frmActividades.Show()
    End Sub

    Public Sub SetLineHighLigh(ByRef line As ListViewItem, estado As Integer)
        If line Is Nothing Then Exit Sub

        Select Case estado
            Case 1 : line.BackColor = Color.Aquamarine
            Case 2 : line.BackColor = Color.Yellow
            Case 3 : line.BackColor = Color.Red
        End Select

    End Sub


    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Me.cmbProvincia.Enabled = Me.CheckBox1.Checked
        If Me.CheckBox1.Checked = False Then
            provincia = Nothing
        End If
    End Sub

    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs) Handles tsslCancel.Click
        If trd Is Nothing Or trd.ThreadState = 4 Then
            Exit Sub
        End If
        If Not trd Is Nothing Then
            If trd.ThreadState = ThreadState.Running Then
                Try
                    trd.Abort()
                Catch ex As Exception

                End Try
            End If
        End If
        Me.lvVendedores.Visible = True
        Me.tspbLoading.Visible = False
        Me.tsslCancel.Visible = False
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = 1 Then

            LoadDashboard()
        End If
    End Sub
    Private Sub LoadDashboard()
        Dim specs As New SalesForceLib.PostItSearchSpecs

        specs.Gestor.IsEqual(Usuario)
        specs.Month.IsEqual(DateTime.Now.Month)
        specs.Day.IsEqual(DateTime.Now.Day)

        Dim total As Integer, a As Integer, b As Integer, c As Integer, d As Integer

        Me.lvContactados.Items.Clear()
        total = 0
        a = 0
        b = 0
        c = 0
        d = 0
        For Each p As PostIt In New Notepad(specs).OrderByDescending(Function(pi As PostIt) pi.Id)
            If p.CallStatus = 1 Then
                a += 1
                Me.lvContactados.Items.Add(p.SalesMan.FullName())
            End If
            If p.CallStatus = 2 Then
                b += 1
            End If
            If p.CallStatus = 3 Then
                c += 1
            End If
            total += 1
        Next
        If total > 0 Then
                                                                             Me.bcpA.Value = CInt((a * 100) / total)
                                                                             Me.bcpB.Value = (b * 100) / total
                                                                             Me.bcpC.Value = (c * 100) / total
                                                                         Else
                                                                             Me.bcpA.Value = 0
                                                                             Me.bcpB.Value = 0
                                                                             Me.bcpC.Value = 0
                                                                         End If

                                                                         Me.bcpA.LabelVisible = True

    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub EnviarWhatsAppToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnviarWhatsAppToolStripMenuItem.Click
        Dim s As SalesMan = Me.lvVendedores.SelectedItems(0).Tag

        Dim apppath As String = CheckIfRunning("WhatsApp")

        If apppath.Length > 0 Then
            System.Diagnostics.Process.Start(apppath, "whatsapp://send?phone=507" + s.PhoneNumber02 + "&text=")
        Else
            System.Diagnostics.Process.Start("whatsapp://send?phone=507" + s.PhoneNumber02 + "&text=")
        End If

    End Sub
    Private Function CheckIfRunning(sProcessName As String) As String

        Try
            Dim listProc() As System.Diagnostics.Process


            listProc = System.Diagnostics.Process.GetProcessesByName(sProcessName)
            If listProc.Length > 0 Then
                ' Process is running
                Return listProc(0).MainModule.FileName
            Else
                Return ""
            End If
        Catch ex As Exception
            Return Nothing

        End Try

    End Function

    Private Sub KryptonContextMenuItem1_Click(sender As Object, e As EventArgs) Handles KryptonContextMenuItem1.Click
        GroupMode = 1
        My.Settings.VendedoresGroupMode = 1
        My.Settings.Save()

        If trd Is Nothing Or trd.ThreadState = 4 Then
            trd.Abort()
        End If
        If Not trd Is Nothing Then
            If trd.ThreadState = ThreadState.Running Then
                Try
                    trd.Abort()
                Catch ex As Exception

                End Try
            End If
        End If

        provincia = Me.cmbProvincia.SelectedItem
        If Me.ckCanton.Checked Then
            canton = Me.cmbCanton.SelectedItem
        End If
        If Me.ckDistrito.Checked Then
            distrito = Me.cmbDistrito.SelectedItem
        End If

        trd = New Thread(AddressOf LoadVendedores)
        trd.Start()
    End Sub

    Private Sub KryptonContextMenuItem2_Click(sender As Object, e As EventArgs) Handles KryptonContextMenuItem2.Click
        GroupMode = 2
        My.Settings.VendedoresGroupMode = 2
        My.Settings.Save()

        If trd Is Nothing Or trd.ThreadState = 4 Then
            trd.Abort()
        End If
        If Not trd Is Nothing Then
            If trd.ThreadState = ThreadState.Running Then
                Try
                    trd.Abort()
                Catch ex As Exception

                End Try
            End If
        End If

        provincia = Me.cmbProvincia.SelectedItem
        If Me.ckCanton.Checked Then
            canton = Me.cmbCanton.SelectedItem
        End If
        If Me.ckDistrito.Checked Then
            distrito = Me.cmbDistrito.SelectedItem
        End If

        trd = New Thread(AddressOf LoadVendedores)
        trd.Start()
    End Sub

    Private Sub CheckBox2_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged

    End Sub
End Class