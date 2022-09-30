Imports System.Data.SqlClient
Public Class frmBitacoraVendedores
    Public vendedor As String
    Public Gestion As Double
    Public cierre As Integer
    Private Sub frmBitacoraVendedores_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim sql As System.Text.StringBuilder
        Dim cmd As SqlCommand
        Dim result As Integer
        sql = New System.Text.StringBuilder
        sql.Append("SELECT count(*)  FROM gestiones_vendedores WHERE consecutivo = @gestion and estado = 1")
        cmd = New SqlCommand(sql.ToString, db)
        cmd.Parameters.Add(New SqlParameter("@gestion", Gestion))
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
    End Sub
    Private Sub frmBitacoraVendedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim v As LayerSellers.Sellers
        Dim cmd As SqlCommand
        Dim da As SqlDataAdapter
        Dim ds As DataSet
        Dim i As Integer
        Dim item As ListViewItem
        Dim reader As SqlDataReader = Nothing
        Dim sql As System.Text.StringBuilder

        v = New LayerSellers.Sellers(db)
        v.SetCodeSeller(vendedor)
        v.GetInformation()
        If v.Count > 0 Then
            Me.lbNombreVendedor.Text = v.NombreCompleto
            Me.lbTelefono01.Text = v.Telefono1
            Me.lbTelefono02.Text = v.Telefono2
            If v.FechaUltimaVenta <> "" Then
                Me.lbUltimaVenta.Text = Convert.ToDateTime(v.FechaUltimaVenta).ToShortDateString
            Else
                Me.lbUltimaVenta.Text = ""
            End If
            Me.lbCorreoElectronico.Text = v.Email
            Try
                cmd = New SqlCommand("SELECT venta,venta_unidad " & _
                                     "FROM VENTAS " & _
                                     "WHERE vendedor = @vendedor and cierre = @cierre", db)
                cmd.CommandType = CommandType.Text
                da = New SqlDataAdapter
                da.SelectCommand = cmd
                cmd.Parameters.Add(New SqlParameter("@vendedor", vendedor))
                cmd.Parameters.Add(New SqlParameter("@cierre", cierre))
                'Carga los reclutas del vendedor
                ds = New DataSet
                da.Fill(ds)
                If ds.Tables(0).Rows.Count > 0 Then
                    With ds.Tables(0).Rows(0)
                        Me.txtVentaPersonal.Text = .Item("venta").ToString
                        Me.txtVentaUnidad.Text = .Item("venta_unidad").ToString
                    End With
                Else
                    Me.txtVentaPersonal.Text = "0,00"
                    Me.txtVentaUnidad.Text = "0,00"
                End If
            Catch ex As Exception

            End Try
            Try
                cmd = New SqlCommand("sp_VentasEquipo", db)
                cmd.CommandType = CommandType.StoredProcedure
                da = New SqlDataAdapter
                da.SelectCommand = cmd
                cmd.Parameters.Add(New SqlParameter("@vendedor", vendedor))
                cmd.Parameters.Add(New SqlParameter("@cierre", cierre))
                cmd.Parameters.Add(New SqlParameter("@generacion", 2))
                'Carga los reclutas del vendedor
                ds = New DataSet
                da.Fill(ds)
                If ds.Tables(0).Rows.Count > 0 Then
                    With ds.Tables(0)
                        For i = 0 To .Rows.Count - 1
                            item = New ListViewItem(.Rows(i).Item(0).ToString)
                            item.SubItems.Add(.Rows(i).Item(1).ToString)
                            item.SubItems.Add(.Rows(i).Item(2).ToString)
                            item.SubItems.Add(.Rows(i).Item(3).ToString)
                            Me.lvReclutas.Items.Add(item)
                        Next i
                    End With
                End If
                'Carga la observaciones
                sql = New System.Text.StringBuilder
                sql.Append("SELECT * FROM notas_vendedores WHERE vendedor = @vendedor order by fecha desc")
                cmd = New SqlCommand(sql.ToString, db)
                cmd.Parameters.Add(New SqlParameter("@vendedor", vendedor))
                Try
                    reader = cmd.ExecuteReader
                    While reader.Read
                        item = New ListViewItem(Convert.ToDateTime(reader("fecha").ToString).ToShortDateString)
                        item.SubItems.Add(reader("observacion").ToString)
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
                        Try
                            item.SubItems.Add(Convert.ToDateTime(reader("fecha_proxima_llamada").ToString).ToShortDateString)
                        Catch ex As Exception
                            item.SubItems.Add("")
                        End Try
                        item.SubItems.Add(reader("creado_por").ToString)
                        Me.lvObservaciones.Items.Add(item)
                    End While
                Catch ex As Exception

                Finally
                    If Not reader Is Nothing Then
                        reader.Close()
                    End If
                    cmd.Dispose()
                End Try

            Catch ex As Exception
                MessageBox.Show("No se pudo obtener las ventas del equipo", "ServicioalCliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
    Private Sub cmdAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregar.Click
        Dim cmd As SqlCommand
        Dim item As ListViewItem
        Dim sel As New System.Text.StringBuilder
        Dim result As Integer

        If Me.dtProximaLlamada.Value = DateTime.Now Then
            MessageBox.Show("Debe Ingresar una fecha de proxima llamada", _
                            "ServicioalCliente", _
                            MessageBoxButtons.OK, _
                            MessageBoxIcon.Error)
            Exit Sub
        End If

        'llamadas de tipo A
        If Me.rbA.Checked Then
            If Me.txtObservacion.Text.Length = 0 Then
                MessageBox.Show("Debe Ingresar un Comentario", _
                                "ServicioalCliente", _
                                MessageBoxButtons.OK, _
                                MessageBoxIcon.Error)
                Exit Sub
            End If
            If (Me.dtProximaLlamada.Value - DateTime.Now).TotalDays > 15 Then
                MessageBox.Show("No se puede programar una proxima llamada superior a 15 Dias", _
                                "ServicioalCliente", _
                                MessageBoxButtons.OK, _
                                MessageBoxIcon.Error)
                Exit Sub
            End If
        End If

        'llamadas de tipo B
        If Me.rbB.Checked Then
            If Me.txtObservacion.Text.Length = 0 Then
                MessageBox.Show("Debe Ingresar un Comentario", _
                                "ServicioalCliente", _
                                MessageBoxButtons.OK, _
                                MessageBoxIcon.Error)
                Exit Sub
            End If
            If (Me.dtProximaLlamada.Value - DateTime.Now).TotalDays > 8 Then
                MessageBox.Show("No se puede programar una proxima llamada superior a 8 Dias", _
                                "ServicioalCliente", _
                                MessageBoxButtons.OK, _
                                MessageBoxIcon.Error)
                Exit Sub
            End If
        End If

        'llamadas de tipo B
        If Me.rbC.Checked Then
            Me.dtProximaLlamada.Value = DateTime.Now.AddDays(1)
        End If
        If Me.rbA.Checked = False And Me.rbB.Checked = False And Me.rbC.Checked = False Then
            MessageBox.Show("Debe seleccionar el estado de la llamada", _
                            "ServicioalCliente", _
                            MessageBoxButtons.OK, _
                            MessageBoxIcon.Error)
            Exit Sub
        End If


        'Insertar la nota de cobro
        sel.Append("INSERT INTO notas_vendedores (vendedor,fecha,observacion,estado,gestion,fecha_proxima_llamada,creado_el,creado_por) ")
        sel.Append("VALUES (@vendedor,getdate (),@observacion,@estado,@gestion,@proxima_llamada,getdate (),@creado_por); ")
        sel.Append("UPDATE gestiones_vendedores SET fecha_fin = @fecha_fin , estado = 2 WHERE consecutivo = @gestion")
        cmd = New SqlCommand(sel.ToString, db)
        cmd.Parameters.AddWithValue("@vendedor", vendedor)
        cmd.Parameters.AddWithValue("@observacion", Me.txtObservacion.Text)
        If Me.rbA.Checked Then
            cmd.Parameters.AddWithValue("@estado", 1)
        End If
        If Me.rbB.Checked Then
            cmd.Parameters.AddWithValue("@estado", 2)
        End If
        If Me.rbC.Checked Then
            cmd.Parameters.AddWithValue("@estado", 3)
        End If
        cmd.Parameters.AddWithValue("@gestion", Gestion)
        cmd.Parameters.AddWithValue("@proxima_llamada", Me.dtProximaLlamada.Value)
        cmd.Parameters.AddWithValue("@creado_por", Usuario)
        cmd.Parameters.AddWithValue("@fecha_fin", DateTime.Now)
        Try
            result = cmd.ExecuteScalar
            item = New ListViewItem(DateTime.Now.ToShortDateString)
            item.SubItems.Add(Me.txtObservacion.Text)
            If Me.rbA.Checked Then
                frmVendedores.lvVendedores.SelectedItems(0).SubItems(5).Text = FormatMonthFirst(Me.dtProximaLlamada.Value)
                item.SubItems.Add("X")
                item.SubItems.Add("")
                item.SubItems.Add("")
            End If
            If Me.rbB.Checked Then
                frmVendedores.lvVendedores.SelectedItems(0).SubItems(5).Text = FormatMonthFirst(Me.dtProximaLlamada.Value)
                item.SubItems.Add("")
                item.SubItems.Add("X")
                item.SubItems.Add("")
            End If
            If Me.rbC.Checked Then
                item.SubItems.Add("")
                item.SubItems.Add("")
                item.SubItems.Add("X")
            End If
            item.SubItems.Add(Me.dtProximaLlamada.Value.ToShortDateString)
            Me.lvObservaciones.Items.Add(item)
            Me.txtObservacion.Text = ""
            Me.rbA.Checked = False
            Me.rbB.Checked = False
            Me.rbC.Checked = False
            Me.txtObservacion.Focus()
        Catch ex As SqlException
            MessageBox.Show("No se pudo insertar el comentario", "ServicioalCliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, _
                            "ServicioalCliente", _
                            MessageBoxButtons.OK, _
                            MessageBoxIcon.Error)
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
            cmd = New SqlCommand("UPDATE gestiones_vendedores SET fecha_fin = @fecha_fin , estado = 2 WHERE consecutivo = @gestion", db)
            cmd.Parameters.Add(New SqlParameter("@fecha_fin", DateTime.Now))
            cmd.Parameters.Add(New SqlParameter("@gestion", Gestion))
            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show("No se pudo desbloquear la bitacora")
            End Try
        End If
    End Sub
    Private Sub cmdCorreoElectronico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCorreoElectronico.Click
        frmEditEmail.vendedor = vendedor
        frmEditEmail.lbVendedor.Text = Me.lbNombreVendedor.Text
        frmEditEmail.TextBox1.Text = Me.lbCorreoElectronico.Text
        frmEditEmail.Show()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        FrmJoinMeeting.vendedor = vendedor
        FrmJoinMeeting.Show()
    End Sub
End Class