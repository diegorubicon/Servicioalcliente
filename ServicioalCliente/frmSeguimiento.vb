Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Imports System.Linq
Imports CTILib

Public Class frmSeguimiento
    Private _tipo As Integer
    Public factura As String
    Public cliente As String
    Public gestion As String
    Private Class TipoInteresPostVenta
        Public tipo As Integer
        Public Descripcion As String
    End Class
    Public Property Tipo As Integer
        Get
            Return _tipo
        End Get
        Set(value As Integer)
            _tipo = value
        End Set
    End Property

    Private Sub frmSeguimiento_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If _tipo <> 2 Then
            Dim sql As System.Text.StringBuilder
            Dim cmd As SqlCommand
            Dim result As Integer
            sql = New System.Text.StringBuilder
            sql.Append("SELECT count(*)  FROM gestiones_postventa WHERE consecutivo = @gestion and estado = 1")
            cmd = New SqlCommand(sql.ToString, db)
            cmd.Parameters.Add(New SqlParameter("@gestion", gestion))
            Try
                result = cmd.ExecuteScalar
                If result = 1 Then
                    e.Cancel = True
                    MessageBox.Show("No ha ingresado la observacion de esta orden de pedido", "ServicioalCliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                frmOrdenesCanceladas.lvOrdenes.Enabled = True
            Catch ex As Exception
                e.Cancel = True
            Finally
                cmd.Dispose()
            End Try
        Else
            frmOrdenesCanceladas.lvOrdenes.Enabled = True
        End If
    End Sub
    Private Sub frmSeguimiento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadInfo()
        If _tipo = 2 Then
            Me.Label11.Visible = False
            Me.txtObservacion.Visible = False
            Me.Label12.Visible = False
            Me.rbA.Visible = False
            Me.rbB.Visible = False
            Me.rbC.Visible = False
            Me.rbD.Visible = False
            Me.Label13.Visible = False
            Me.dtProximaLlamada.Visible = False
            Me.cmdAgregar.Visible = False
            Me.lvObservaciones.Location = New System.Drawing.Point(9, 10)
            Me.lvObservaciones.Size = New System.Drawing.Size(605, 200)
            Me.cmdDesbloquear.Visible = False
        End If
    End Sub
    Private Sub LoadInfo()
        Dim item As ListViewItem
        Dim i As Integer, j As Integer
        Dim fecha As DateTime, FechaUltVenta As DateTime
        Dim monto As Double
        Dim adelantadas As Integer
        Dim cmd As SqlCommand
        Dim reader As SqlDataReader = Nothing
        Dim sql As System.Text.StringBuilder
        Dim book As New InvoicingLib.InvoiceBook
        Me.dtProximaLlamada.Value = DateTime.Now

        If factura <> "" Then

            Me.cmbTipo.DataSource = DataAccess.GetDataTable("SELECT * FROM tipos_interes_postventa", db)
            Me.cmbTipo.DisplayMember = "descripcion"
            Me.cmbTipo.ValueMember = "tipo"

            Dim fact As InvoicingLib.Invoice = book(factura)
            If Not fact Is Nothing Then
                Me.lbFactura.Text = factura
                cliente = fact.Customer.Id
                Me.lbCliente.Text = fact.Customer.FullName
                Me.lbTelefono01.Text = fact.Customer.CellPhoneNumber
                Me.lbTelefono02.Text = fact.Customer.HomePhoneNumber
                Me.lbtelefono03.Text = fact.Customer.WorkPhoneNumber
                Me.txtEmail.Text = fact.Customer.Email

                Me.lbVendedor.Text = fact.SalesMan.FullName
                Me.lbTelefonoVendedor.Text = fact.SalesMan.PhoneNumber01 + "-" + fact.SalesMan.PhoneNumber02
                'Obtiene el tipo de interes post-venta
                Me.cmbTipo.SelectedValue = DataAccess.GetValue("SELECT tipo FROM cliente_interes_postventa WHERE cliente= '" + cliente + "'", db)
                '
                'fecha de la ult. venta del vendedor
                FechaUltVenta = fact.SalesMan.LastSaleDate
                Dim dif As Integer = DateDiff(DateInterval.Month, FechaUltVenta, Now.Date)
                If dif = 0 Then
                    Me.lbVendedor.Text += " (Activo) "
                Else
                    Me.lbVendedor.Text += " (" + CType(dif, String) + " meses ultima venta)"
                End If
                Me.lbFecha.Text = fact.Date
                Me.lbPlazo.Text = fact.TimeLimit
                Me.lbFechaVencimiento.Text = fact.ExpirationDate
                If fact.LastPaymentDate.HasValue Then
                    Me.lbFechaCancelacion.Text = fact.LastPaymentDate.Value.ToShortDateString()
                Else
                    Me.lbFechaCancelacion.Text = ""
                End If
                Me.lbMontoTotal.Text = fact.TotalAmount + fact.TransportationAmount
                    For Each line As InvoicingLib.LineDetails In fact.Details
                        item = New ListViewItem(line.Item)
                        item.SubItems.Add(line.ItemDescription)
                        item.SubItems.Add(line.Quantity)
                        item.SubItems.Add(line.TotalAmount)
                        Me.lvArticulos.Items.Add(item)
                    Next
                    adelantadas = 0
                    fecha = fact.Date.AddDays(5)
                    For i = 1 To fact.TimeLimit
                        monto = 0
                        For Each p As InvoicingLib.InvoicePayment In fact.Payments
                            If p.PaymentDate <= fecha Then
                                monto = monto + p.Amortization
                            End If
                        Next
                        If monto >= fact.MonthlyFee * i Then
                            adelantadas = adelantadas + 1
                        End If
                        fecha = fact.Date.AddMonths(i).AddDays(5)
                    Next
                    Me.txtCorrectas.Text = adelantadas
                    Me.txtFails.Text = fact.TimeLimit - adelantadas

                    'Carga los comentarios anteriores
                    sql = New System.Text.StringBuilder
                sql.Append("SELECT npv.* FROM notas_postventa npv, facturas_encabezado fe WHERE npv.factura = fe.factura and fe.cliente = @cliente order by fecha desc")
                cmd = New SqlCommand(sql.ToString, db)
                cmd.Parameters.Add(New SqlParameter("@cliente", cliente))
                Try
                    reader = cmd.ExecuteReader
                    While reader.Read
                            Dim observacion As String = reader("observacion").ToString
                            Dim insertAT As Integer = 50
                            While (insertAT < observacion.Length)
                                observacion = observacion.Insert(insertAT, "¬")
                                insertAT += 50
                            End While
                            Dim lines() As String = observacion.Split("¬")
                            item = New ListViewItem(reader("fecha").ToString)
                            item.SubItems.Add(lines(0))
                            If reader("estado").ToString = "1" Then
                                item.SubItems.Add("X")
                                item.SubItems.Add("")
                                item.SubItems.Add("")
                            End If
                            If reader("estado").ToString = "2" Then
                                item.SubItems.Add("")
                                item.SubItems.Add("X")
                                item.SubItems.Add("")
                            End If
                            If reader("estado").ToString = "3" Then
                                item.SubItems.Add("")
                                item.SubItems.Add("")
                                item.SubItems.Add("X")
                            End If
                            If reader("estado").ToString = "4" Then
                                item.SubItems.Add("")
                                item.SubItems.Add("")
                                item.SubItems.Add("")
                                Me._tipo = 2
                                Me.Label11.Visible = False
                                Me.txtObservacion.Visible = False
                                Me.Label12.Visible = False
                                Me.rbA.Visible = False
                                Me.rbB.Visible = False
                                Me.rbC.Visible = False
                                Me.rbD.Visible = False
                                Me.Label13.Visible = False
                                Me.dtProximaLlamada.Visible = False
                                Me.cmdAgregar.Visible = False
                                Me.lvObservaciones.Location = New System.Drawing.Point(9, 10)
                                Me.lvObservaciones.Size = New System.Drawing.Size(605, 200)
                            Me.cmdDesbloquear.Visible = False
                        End If
                        Try
                            item.SubItems.Add(Convert.ToDateTime(reader("fecha_proxima_llamada").ToString).ToShortDateString)
                        Catch ex As Exception
                            item.SubItems.Add("")
                        End Try
                        item.SubItems.Add(reader("creado_por").ToString)
                        item.SubItems.Add(reader("factura").ToString)

                        Me.lvObservaciones.Items.Add(item)
                            If lines.Length > 1 Then
                                For i = 1 To lines.Length - 1
                                    item = New ListViewItem()
                                    item.SubItems.Add(lines(i))
                                    Me.lvObservaciones.Items.Add(item)
                                Next
                            End If
                        End While
                    Catch ex As Exception

                    Finally
                        If Not reader Is Nothing Then
                            reader.Close()
                        End If
                        cmd.Dispose()
                    End Try
                End If
            End If
    End Sub
    Private Sub cmdAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregar.Click
        Dim cmd As SqlCommand
        Dim item As ListViewItem
        Dim sel As New System.Text.StringBuilder
        Dim result As Integer
        Dim Nuevoestado As Integer

        If Me.txtObservacion.Text.Length = 0 Then
            MessageBox.Show("Debe Ingresar un Comentario", "ServicioalCliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Me.rbA.Checked = False And Me.rbB.Checked = False And Me.rbC.Checked = False And Me.rbD.Checked = False Then
            MessageBox.Show("Debe seleccionar el estado de la llamada", "ServicioalCliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Me.rbD.Checked Then
            If MessageBox.Show("Si selecciona este estado de llamada la orden se descartara de Post-Venta, desea continuar?", "Sac", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.No Then
                Exit Sub
            End If
        End If

        'Actualiza el tipo actual de interes postventa
        If Not Me.cmbTipo.SelectedValue Is Nothing Then
            Nuevoestado = CType(Me.cmbTipo.SelectedValue, Integer)

            Dim estadoacual As Integer = DataAccess.GetValue("SELECT tipo FROM cliente_interes_postventa WHERE cliente= '" + cliente + "'", db)
            If estadoacual = 0 Then
                'no se habia definido el interes del cliente
                If Nuevoestado = 1 Then
                    'posible nueva compra
                    cmd = New SqlCommand("CreateorUpdateSaleOpportunity", db)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("factura", factura)
                    Try
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MessageBox.Show("No se pudo insertar el tipo " + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                Else
                    If Nuevoestado = 2 Or Nuevoestado = 3 Then
                        MessageBox.Show("Dele seleccionar el estado POSIBLE COMPRA 1, para iniciar el seguimiento de la posible compra")
                        Exit Sub
                    End If
                End If

                sel = New System.Text.StringBuilder
                sel.Append("INSERT INTO cliente_interes_postventa ")
                sel.Append("(cliente,tipo,creado_el,creado_por) ")
                sel.Append("VALUES (@cliente,@tipo,getdate(),@usuario)")

                cmd = New SqlCommand(sel.ToString, db)
                cmd.Parameters.AddWithValue("cliente", cliente)
                cmd.Parameters.AddWithValue("tipo", Nuevoestado)
                cmd.Parameters.AddWithValue("usuario", Usuario)
                Try
                    cmd.ExecuteNonQuery()
                Catch ex As Exception
                    MessageBox.Show("No se pudo insertar el tipo " + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Else
                'el cliente ya tiene definido un interes
                If Nuevoestado <> estadoacual Then
                    If Nuevoestado = 1 Then
                        'posible nueva compra
                        cmd = New SqlCommand("CreateorUpdateSaleOpportunity", db)
                        cmd.CommandType = CommandType.StoredProcedure
                        cmd.Parameters.AddWithValue("factura", factura)
                        Try
                            cmd.ExecuteNonQuery()
                        Catch ex As Exception
                            MessageBox.Show("No se pudo insertar el tipo " + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End Try
                    End If

                    sel = New System.Text.StringBuilder
                    sel.Append("UPDATE cliente_interes_postventa ")
                    sel.Append("SET tipo = @tipo ")
                    sel.Append("WHERE cliente = @cliente")

                    cmd = New SqlCommand(sel.ToString, db)
                    cmd.CommandType = CommandType.Text
                    cmd.Parameters.AddWithValue("tipo", Nuevoestado)
                    cmd.Parameters.AddWithValue("cliente", cliente)
                    Try
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MessageBox.Show("No se pudo actualizar el tipo " + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If
            End If
        End If

        sel = New System.Text.StringBuilder
        sel.Append("INSERT INTO notas_postventa (factura,fecha,observacion,estado,gestion,fecha_proxima_llamada,creado_el,creado_por) ")
        sel.Append("VALUES (@factura,getdate (),@observacion,@estado,@gestion,@proxima_llamada,getdate (),@creado_por); ")
        sel.Append("UPDATE gestiones_postventa SET fecha_fin = @fecha_fin , estado = 2 WHERE consecutivo = @gestion")
        cmd = New SqlCommand(sel.ToString, db)
        cmd.Parameters.Add(New SqlParameter("@factura", factura))
        cmd.Parameters.Add(New SqlParameter("@observacion", Me.txtObservacion.Text))
        If Me.rbA.Checked Then
            cmd.Parameters.Add(New SqlParameter("@estado", 1))
        End If
        If Me.rbB.Checked Then
            cmd.Parameters.Add(New SqlParameter("@estado", 2))
        End If
        If Me.rbC.Checked Then
            cmd.Parameters.Add(New SqlParameter("@estado", 3))
        End If
        If Me.rbD.Checked Then
            cmd.Parameters.Add(New SqlParameter("@estado", 4))
        End If
        cmd.Parameters.Add(New SqlParameter("@gestion", gestion))
        cmd.Parameters.Add(New SqlParameter("@proxima_llamada", Me.dtProximaLlamada.Value))
        cmd.Parameters.Add(New SqlParameter("@creado_por", Usuario))
        cmd.Parameters.Add(New SqlParameter("@fecha_fin", DateTime.Now))
        Try
            result = cmd.ExecuteScalar
            item = New ListViewItem(DateTime.Now.ToShortDateString)
            item.SubItems.Add(Me.txtObservacion.Text)
            If Me.rbA.Checked Then
                item.SubItems.Add("X")
                item.SubItems.Add("")
                item.SubItems.Add("")
            End If
            If Me.rbB.Checked Then
                frmOrdenesCanceladas.lvOrdenes.SelectedItems(0).SubItems(5).Text = Me.dtProximaLlamada.Value.ToShortDateString
                item.SubItems.Add("")
                item.SubItems.Add("X")
                item.SubItems.Add("")
            End If
            If Me.rbC.Checked Then
                frmOrdenesCanceladas.lvOrdenes.SelectedItems(0).SubItems(5).Text = Me.dtProximaLlamada.Value.ToShortDateString
                item.SubItems.Add("")
                item.SubItems.Add("")
                item.SubItems.Add("X")
            End If

            item.SubItems.Add(Me.dtProximaLlamada.Value)
            Me.lvObservaciones.Items.Add(item)

            item.EnsureVisible()

            frmOrdenesCanceladas.RowsSelect.SubItems(5).Text = Me.dtProximaLlamada.Value.ToShortDateString
            frmOrdenesCanceladas.RowsSelect.SubItems(7).Text = Me.cmbTipo.Text
            If rbA.Checked Then
                If MessageBox.Show("Desea Finalizar el Seguimiento de esta orden de pedido",
                                   "ServicioalCliente",
                                   MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Error) = System.Windows.Forms.DialogResult.Yes Then

                    Dim trackings As AfterSales.PurchaseOrdersTracking = New AfterSales.PurchaseOrdersTracking()
                    trackings.DisableTracking(factura, gestion, Usuario)
                End If
            End If
            If rbD.Checked Then
                Dim trackings As AfterSales.PurchaseOrdersTracking = New AfterSales.PurchaseOrdersTracking()
                trackings.DisableTracking(factura, gestion, Usuario)

            End If



            Me.txtObservacion.Text = ""
            Me.rbA.Checked = False
            Me.rbB.Checked = False
            Me.rbC.Checked = False
            Me.rbD.Checked = False

            Me.txtObservacion.Focus()
        Catch ex As SqlException
            MessageBox.Show("No se pudo insertar el comentario", "ServicioalCliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ServicioalCliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cmd.Dispose()
        End Try
    End Sub
    Private Sub cmdCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCerrar.Click
        Me.Close()
    End Sub
    Private Sub cmdDesbloquear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDesbloquear.Click
        Dim cmd As SqlCommand
        frmPassword.ShowDialog()
        If ContraseñaValida Then
            cmd = New SqlCommand("UPDATE gestiones_postventa SET fecha_fin = @fecha_fin , estado = 2 WHERE consecutivo = @gestion", db)
            cmd.Parameters.Add(New SqlParameter("@fecha_fin", DateTime.Now))
            cmd.Parameters.Add(New SqlParameter("@gestion", gestion))
            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show("No se pudo desbloquear la bitacora")
            End Try
        End If

    End Sub

    Private Sub LoadOrdenes()

        Me.lvOrdenesPendientes.Items.Clear()

        Using conn As SqlConnection = New SqlConnection(Variables.ConnectionString)
            Using cmd As SqlCommand = New SqlCommand()
                cmd.Connection = conn
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "SELECT fe.factura,fe.fecha,fe.fecha_ultimo_pago,fe.monto_total, fe.saldo_factura,fe.fecha_vencimiento, fd.articulo,a.descripcion " & _
                                   "FROM facturas_encabezado fe, factura_detalle fd, articulos a " & _
                                   "WHERE fe.factura = fd.factura and fd.articulo = a.articulo " & _
                                   "AND fe.tipo < 3 and fe.estado <> 4 and fe.saldo_factura > 1 " & _
                                   "AND fe.cliente = @cliente "
                cmd.Parameters.AddWithValue("@cliente", cliente)
                Try
                    Dim adapter As SqlDataAdapter = New SqlDataAdapter(cmd)
                    Dim table As DataTable = New DataTable

                    adapter.Fill(table)
                    For Each row As DataRow In table.Rows
                        Dim item As ListViewItem = New ListViewItem(row("factura").ToString())
                        item.SubItems.Add(CType(row("fecha"), DateTime).ToShortDateString)
                        item.SubItems.Add(CType(row("fecha_vencimiento"), DateTime).ToShortDateString)
                        item.SubItems.Add(row("descripcion").ToString)
                        item.SubItems.Add(CType(row("fecha_ultimo_pago"), DateTime).ToShortDateString)
                        item.SubItems.Add(row("monto_total").ToString)
                        item.SubItems.Add(row("saldo_Factura").ToString)

                        Me.lvOrdenesPendientes.Items.Add(item)
                    Next
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End Using
        End Using
    End Sub
    Private Sub LoadOrdenesCanceladas()

        Me.lvOrdenesCanceladas.Items.Clear()

        Using conn As SqlConnection = New SqlConnection(Variables.ConnectionString)
            Using cmd As SqlCommand = New SqlCommand()
                cmd.Connection = conn
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "SELECT fe.factura,fe.fecha,fe.fecha_ultimo_pago,fe.monto_total, fe.saldo_factura,fe.fecha_vencimiento, fd.articulo,a.descripcion " & _
                                   "FROM facturas_encabezado fe, factura_detalle fd, articulos a " & _
                                   "WHERE fe.factura = fd.factura and fd.articulo = a.articulo " & _
                                   "AND fe.tipo < 3 and fe.estado <> 4 and fe.saldo_factura < 1 " & _
                                   "AND fe.cliente = @cliente " & _
                                    "AND fe.factura <> @factura"
                cmd.Parameters.AddWithValue("@cliente", cliente)
                cmd.Parameters.AddWithValue("@factura", factura)
                Try
                    Dim adapter As SqlDataAdapter = New SqlDataAdapter(cmd)
                    Dim table As DataTable = New DataTable

                    adapter.Fill(table)
                    For Each row As DataRow In table.Rows
                        Dim item As ListViewItem = New ListViewItem(row("factura").ToString())
                        item.SubItems.Add(CType(row("fecha"), DateTime).ToShortDateString)
                        item.SubItems.Add(CType(row("fecha_vencimiento"), DateTime).ToShortDateString)
                        item.SubItems.Add(row("descripcion").ToString)
                        item.SubItems.Add(CType(row("fecha_ultimo_pago"), DateTime).ToShortDateString)
                        item.SubItems.Add(row("monto_total").ToString)
                        item.SubItems.Add(row("saldo_Factura").ToString)

                        Me.lvOrdenesCanceladas.Items.Add(item)
                    Next
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End Using
        End Using
    End Sub


    Private Sub TabControl1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = 1 Then
            LoadOrdenes()
        End If
        If TabControl1.SelectedIndex = 2 Then
            LoadOrdenesCanceladas()
        End If
    End Sub

    Private Sub KryptonButton3_Click(sender As Object, e As EventArgs) Handles KryptonButton3.Click
        sendWhatsApp(Me.lbTelefono01.Text)
    End Sub
    Private Sub sendWhatsApp(telefono As String)
        If telefono.Length = 0 Then Exit Sub

        telefono = telefono.Replace("-", "")
        telefono = telefono.Replace(" ", "")
        Dim c As String
        If Pais = "CR" Then
            c = "506"
        Else
            c = "507"
        End If

        Dim tele = telefono.Split(";")
        Try
            System.Diagnostics.Process.Start("whatsapp://send?phone=" + c + tele(0))
        Catch ex As Exception
            MsgBox("No se pudo efectuar la operacion " + ex.Message)
        End Try

    End Sub
    Private Sub startcall(telefono As String)
        telefono = telefono.Replace("-", "")
        telefono = telefono.Replace(" ", "")

        If telefono.Length > 0 Then
            Dim phone As PhoneManager = New PhoneManager(Variables.IpPhoneAdress, "admin")

            Try
                phone.MakeaCall("9" + telefono)
            Catch ex As CTIException
                MessageBox.Show("No se pudo inicair la llamada " + ex.Message)
            End Try
        End If
    End Sub
    Private Sub KryptonButton1_Click(sender As Object, e As EventArgs) Handles KryptonButton1.Click
        sendWhatsApp(Me.lbTelefono02.Text)
    End Sub

    Private Sub KryptonButton2_Click(sender As Object, e As EventArgs) Handles KryptonButton2.Click
        sendWhatsApp(Me.lbtelefono03.Text)
    End Sub

    Private Sub KryptonButton4_Click(sender As Object, e As EventArgs) Handles KryptonButton4.Click
        startcall(Me.lbTelefono01.Text)
    End Sub

    Private Sub KryptonButton5_Click(sender As Object, e As EventArgs) Handles KryptonButton5.Click
        startcall(Me.lbTelefono02.Text)
    End Sub

    Private Sub KryptonButton6_Click(sender As Object, e As EventArgs) Handles KryptonButton6.Click
        startcall(Me.lbtelefono03.Text)
    End Sub

    Private Sub cmbTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTipo.SelectedIndexChanged

    End Sub
End Class