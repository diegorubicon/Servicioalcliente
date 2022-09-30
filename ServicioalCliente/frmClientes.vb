Imports System.Data.SqlClient
Imports System.Threading
Public Class frmVendedores
    Private trd As Thread
    Dim cierre As Integer
    Dim Mes As String
    Dim provincia As Integer = 0, canton As Integer = 0, distrito As Integer = 0
    Dim BitacoraExtendida As Integer
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
        Try
            'Carga las provincias
            Dim pr As LayerAdress.Provincias
            pr = New LayerAdress.Provincias
            pr.SetConnection(db)
            pr.FillDataCombo(Me.cmbProvincia)

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
        Dim v As LayerSellers.Sellers
        Dim item As ListViewItem
        Dim i As Integer
        Dim group As ListViewGroup
        Dim dias As Integer = 0
        Dim grupo As Integer
        Dim MakeGroup As Boolean
        Dim j As Integer
        Dim cmd As SqlCommand
        Dim reader As SqlDataReader


        Me.lvVendedores.Items.Clear()
        Me.lvVendedores.Groups.Clear()

        Me.lvVendedores.Visible = False

        Using db As SqlConnection = New SqlConnection(Variables.ConnectionString)
       
            'Obtener los vendedores nuevos del cierre
            v = New LayerSellers.Sellers(db)
            v.GetVendedoresCierre(cierre, provincia, canton, distrito, Me.txtBuscar.Text)
            If v.Count > 0 Then
                group = New ListViewGroup("01. Nuevos Vendedores")
                Me.lvVendedores.Groups.Add(group)

                For i = 1 To v.Count
                    item = New ListViewItem(v.Vendedor(i), v.EstadoSeguimiento(i))
                    item.SubItems.Add(v.Contrato(i))
                    item.SubItems.Add(v.NombreCompleto(i))
                    item.SubItems.Add(v.FechaUltimaVenta(i))
                    '
                    cmd = New SqlCommand("SELECT max(fecha_proxima_llamada) as fecha_proxima,max(fecha) as fecha " & _
                                         "FROM notas_vendedores " & _
                                         "WHERE vendedor = @vendedor ", db)
                    cmd.Parameters.Add(New SqlParameter("@vendedor", v.Vendedor(i)))
                    Try
                        db.Open()
                        reader = cmd.ExecuteReader
                        If reader.Read Then
                            If Not System.Convert.IsDBNull(reader.Item("fecha")) Then
                                item.SubItems.Add(formatFecha(Convert.ToDateTime(reader.Item("fecha"))))
                            Else
                                item.SubItems.Add("")
                            End If
                            If Not System.Convert.IsDBNull(reader.Item("fecha_proxima")) Then
                                item.SubItems.Add(formatFecha(Convert.ToDateTime(reader.Item("fecha_proxima"))))
                            Else
                                item.SubItems.Add("")
                            End If
                        Else
                            item.SubItems.Add("")
                            item.SubItems.Add("")
                        End If
                        'reader.Close()
                        db.Close()
                    Catch ex As Exception
                        item.SubItems.Add("")
                        item.SubItems.Add("")
                    End Try
                    item.SubItems.Add(v.Email(i))
                    item.Group = group
                    Me.lvVendedores.Items.Add(item)
                Next
            End If
            'Obtener los vendedores por fecha de ventas
            v = New LayerSellers.Sellers(db)
            v.GetVendedoresFechaVentas(cierre, provincia, canton, distrito, Me.txtBuscar.Text)
            tspbLoading.Minimum = 1
            tspbLoading.Maximum = v.Count
            For i = 1 To v.Count
                SetValue(i)
                item = New ListViewItem(v.Vendedor(i), v.EstadoSeguimiento(i))
                item.SubItems.Add(v.Contrato(i))
                item.SubItems.Add(v.NombreCompleto(i))
                If v.FechaUltimaVenta(i) <> "" Then
                    item.SubItems.Add(Convert.ToDateTime(v.FechaUltimaVenta(i)).ToShortDateString)
                Else
                    item.SubItems.Add("")
                End If
                cmd = New SqlCommand("select max(fecha_proxima_llamada) as fecha_proxima,max(fecha) as fecha " & _
                                     "from notas_vendedores " & _
                                     "where vendedor = @vendedor ", db)
                cmd.Parameters.Add(New SqlParameter("@vendedor", v.Vendedor(i)))
                Try
                    db.Open()
                    reader = cmd.ExecuteReader
                    If reader.Read Then
                        With item
                            'llamada anterior
                            If Not System.Convert.IsDBNull(reader.Item("fecha")) Then
                                .SubItems.Add(formatFecha(Convert.ToDateTime(reader.Item("fecha"))))
                            Else
                                .SubItems.Add("")
                            End If
                            'Proxima llamada
                            If Not System.Convert.IsDBNull(reader.Item("fecha_proxima")) Then
                                .SubItems.Add(formatFecha(Convert.ToDateTime(reader.Item("fecha_proxima").ToString)))
                            Else
                                .SubItems.Add("")
                            End If
                        End With
                    Else
                        item.SubItems.Add("")
                        item.SubItems.Add("")
                    End If
                    reader.Close()
                    db.Close()
                Catch ex As Exception
                    item.SubItems.Add("")
                    item.SubItems.Add("")
                End Try

                item.SubItems.Add(v.Email(i))
                If (v.FechaUltimaVenta(i) <> "") Then
                    Dim tsTimeSpan As TimeSpan
                    tsTimeSpan = DateTime.Now.Subtract(Convert.ToDateTime(v.FechaUltimaVenta(i)).ToShortDateString)
                    dias = (tsTimeSpan.Days)
                Else
                    dias = -1
                End If
                Select Case dias
                    Case -1 : grupo = 5
                    Case 0 To 30 : grupo = 1
                    Case 31 To 60 : grupo = 2
                    Case 61 To 90 : grupo = 3
                    Case Is > 90 : grupo = 4
                End Select
                MakeGroup = True
                For j = 0 To Me.lvVendedores.Groups.Count - 1

                    If Me.lvVendedores.Groups(j).Tag = grupo Then
                        item.Group = Me.lvVendedores.Groups(j)
                        MakeGroup = False
                    End If
                Next
                If MakeGroup Then
                    group = New ListViewGroup()
                    group.Tag = grupo
                    Select Case grupo
                        Case 1 : group.Header = "02. Ventas <= 30 Dias"
                        Case 2 : group.Header = "03. Ventas <= 60 Dias"
                        Case 3 : group.Header = "04. Ventas <= 90 dias"
                        Case 4 : group.Header = "05. Ventas > 90 dias"
                        Case 5 : group.Header = "06. Sin Ventas"
                    End Select
                    item.Group = group
                    Me.lvVendedores.Groups.Add(group)
                End If
                Me.lvVendedores.Items.Add(item)
            Next

        End Using

        Me.lvVendedores.Visible = True

        Me.tspbLoading.Visible = False
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
            cmd.Parameters.Add(New SqlParameter("@vendedor", Me.lvVendedores.SelectedItems(0).Text))
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
            Me.lvVendedores.SelectedItems(0).BackColor = Color.Aquamarine
            FrmBitacoraVendedoresExtend.CodigoVendedor = Me.lvVendedores.SelectedItems(0).Text
            FrmBitacoraVendedoresExtend.Gestion = consec
            FrmBitacoraVendedoresExtend.Cierre = cierre
            FrmBitacoraVendedoresExtend.Show()
        Else
            Me.lvVendedores.SelectedItems(0).BackColor = Color.Aquamarine
            frmBitacoraVendedores.vendedor = Me.lvVendedores.SelectedItems(0).Text
            frmBitacoraVendedores.Gestion = consec
            frmBitacoraVendedores.cierre = cierre
            frmBitacoraVendedores.Show()
        End If
    End Sub
    Private Sub cmbProvincia_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbProvincia.SelectedValueChanged
        Dim ca As LayerAdress.Cantones
        If cmbProvincia.SelectedValue.ToString <> "System.Data.DataRowView" Then
            ca = New LayerAdress.Cantones
            ca.SetConnection(db)
            ca.FillDataCombo(Me.cmbCanton, cmbProvincia.SelectedValue)
        End If
    End Sub
    Private Sub cmbCanton_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCanton.SelectedValueChanged
        Dim di As LayerAdress.Distritos
        If cmbCanton.SelectedValue.ToString <> "System.Data.DataRowView" And cmbProvincia.SelectedValue.ToString <> "System.Data.DataRowView" Then
            di = New LayerAdress.Distritos
            di.SetConnection(db)
            di.FillDataCombo(Me.cmbDistrito, cmbProvincia.SelectedValue, cmbCanton.SelectedValue)
        End If
    End Sub
    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        If trd Is Nothing Or trd.ThreadState = 4 Then
            Exit Sub
        End If
        LoadVendedores()
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        
        Me.Close()
    End Sub
    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        frmPassword.ShowDialog()
        If ContraseñaValida Then
            frmDesbloquearBitacoraVendedor.Show()
        End If
    End Sub
    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
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

        provincia = Me.cmbProvincia.SelectedValue
        If Me.ckCanton.Checked Then
            canton = Me.cmbCanton.SelectedValue
        End If
        If Me.ckDistrito.Checked Then
            distrito = Me.cmbDistrito.SelectedValue
        End If
        LoadVendedores()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        provincia = 0
        canton = 0
        distrito = 0
        LoadVendedores()
    End Sub
    Private Sub ckCanton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckCanton.CheckedChanged
        Me.cmbCanton.Enabled = Me.ckCanton.Checked
        If Me.ckCanton.Checked = False Then
            canton = 0
        End If
    End Sub

    Private Sub ckDistrito_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckDistrito.CheckedChanged
        Me.cmbDistrito.Enabled = Me.ckDistrito.Checked
        If Me.ckDistrito.Checked = False Then
            distrito = 0
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
        FrmJoinMeeting.vendedor = Me.lvVendedores.SelectedItems(0).Text
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
        LoadVendedores()
    End Sub

    Private Sub lvVendedores_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles lvVendedores.ColumnClick
        ' Determinar si la columna en la que se hizo clic ya es la que se está ordenando. 
        If (e.Column = lvwColumnSorter.SortColumn) Then ' Revertir la dirección de ordenación actual de esta columna. 
            If (lvwColumnSorter.Order = Windows.Forms.SortOrder.Ascending) Then
                lvwColumnSorter.Order = Windows.Forms.SortOrder.Descending
            Else
                lvwColumnSorter.Order = Windows.Forms.SortOrder.Ascending
            End If
        Else ' Establecer el número de columna que se va a ordenar; de forma predeterminada, en orden ascendente. 
            lvwColumnSorter.SortColumn = e.Column
            lvwColumnSorter.Order = Windows.Forms.SortOrder.Ascending
        End If

        ' Realizar la ordenación con estas nuevas opciones de ordenación. 
        Me.lvVendedores.Sort()
    End Sub
    Private Sub lvVendedores_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lvVendedores.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            Me.lvVendedores.ContextMenuStrip.Show()
        End If
    End Sub
    Private Sub ModificarCorreoElectronicoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarCorreoElectronicoToolStripMenuItem.Click
        If Me.lvVendedores.SelectedItems.Count = 0 Then
            MessageBox.Show("Debe seleccionar un vendedor", "ServicioalCliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        frmEditEmail.vendedor = Me.lvVendedores.SelectedItems(0).Text
        frmEditEmail.lbVendedor.Text = Me.lvVendedores.SelectedItems(0).SubItems(2).Text
        frmEditEmail.TextBox1.Text = Me.lvVendedores.SelectedItems(0).SubItems(6).Text
        frmEditEmail.Show()
    End Sub
    Private Sub DesactivarVendedorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DesactivarVendedorToolStripMenuItem.Click
        If Me.lvVendedores.SelectedItems.Count = 0 Then
            MessageBox.Show("Debe seleccionar un vendedor", "ServicioalCliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        frmDeactivateVendedor.vendedor = Me.lvVendedores.SelectedItems(0).Text
        frmDeactivateVendedor.txtVendedor.Text = Me.lvVendedores.SelectedItems(0).SubItems(2).Text
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
        opara = New SqlParameter("@vendedor", Me.lvVendedores.SelectedItems(0).Text)
        cmd.Parameters.Add(opara)
        opara = New SqlParameter("@estado", 0)
        cmd.Parameters.Add(opara)
        Try
            rst = cmd.ExecuteNonQuery
            Me.lvVendedores.SelectedItems(0).ImageIndex = 0
        Catch ex As Exception
            MessageBox.Show("No se cambiar el estado del  vendedor " + ex.Message, "ServicioalCliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        opara = New SqlParameter("@vendedor", Me.lvVendedores.SelectedItems(0).Text)
        cmd.Parameters.Add(opara)
        opara = New SqlParameter("@estado", 1)
        cmd.Parameters.Add(opara)
        Try
            rst = cmd.ExecuteNonQuery
            Me.lvVendedores.SelectedItems(0).ImageIndex = 1
        Catch ex As Exception
            MessageBox.Show("No se cambiar el estado del  vendedor " + ex.Message, "ServicioalCliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        opara = New SqlParameter("@vendedor", Me.lvVendedores.SelectedItems(0).Text)
        cmd.Parameters.Add(opara)
        opara = New SqlParameter("@estado", 2)
        cmd.Parameters.Add(opara)
        Try
            rst = cmd.ExecuteNonQuery
            Me.lvVendedores.SelectedItems(0).ImageIndex = 2
        Catch ex As Exception
            MessageBox.Show("No se cambiar el estado del  vendedor " + ex.Message, "ServicioalCliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
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


    Private Sub cmbProvincia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbProvincia.SelectedIndexChanged

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
End Class