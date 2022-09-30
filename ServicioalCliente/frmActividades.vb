Imports System.Data.SqlClient
Imports System.Threading
Public Class frmActividades
    Private ActividadSeleccionada As Integer = 0
    Private WithEvents _frmBuscaVendedor As frmBuscaVendedor = Nothing
    Private Sub frmActividades_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Using db As SqlConnection = New SqlConnection(Variables.ConnectionString)
            Using cmd As SqlCommand = New SqlCommand("sp_GetActivities", db)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@actividad", -1)
                Using adapter As SqlDataAdapter = New SqlDataAdapter(cmd)
                    Try
                        Dim dt As DataTable = New DataTable

                        adapter.Fill(dt)

                        Me.cmbActividades.DataSource = dt
                        Me.cmbActividades.DisplayMember = "titulo"
                        Me.cmbActividades.ValueMember = "actividad"

                    Catch ex As Exception
                        MessageBox.Show("No se pudo obtener las actividades " + ex.Message, "Servicioalcliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        If db.State = ConnectionState.Open Then
                            db.Close()
                        End If
                        Exit Sub
                    End Try
                End Using
            End Using
        End Using

    End Sub
    Private Sub CargarActividad(actividad As Integer)
        Try
            Me.lvVendedores.Items.Clear()
        Catch ex As Exception
            Exit Sub
        End Try

        ActividadSeleccionada = actividad

        Using db As SqlConnection = New SqlConnection(Variables.ConnectionString)
            Using cmd As SqlCommand = New SqlCommand("getVendedoresEnActividad", db)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@actividad", actividad)

                Try
                    db.Open()
                    Dim i As Integer = 0
                    Dim reader As SqlDataReader = cmd.ExecuteReader
                    While reader.Read()
                        i += 1
                        Dim icon As Integer = 0
                        If CType(reader.Item("estado").ToString, Integer) = 2 Then
                            icon = 1
                        End If
                        Dim item As ListViewItem = New ListViewItem(reader.Item("vendedor").ToString, icon)
                        item.SubItems.Add(reader.Item("num_contrato").ToString)
                        item.SubItems.Add(reader.Item("nom").ToString)
                        item.SubItems.Add(reader.Item("telefono").ToString)
                        item.SubItems.Add(reader.Item("telefono_02").ToString)

                        item.Checked = Convert.ToInt16(reader.Item("asistencia").ToString)
                        Me.lvVendedores.Items.Add(item)
                    End While

                    Me.lbContador.Text = CType(i, String) + " vendedores en la actividad "
                Catch ex As Exception
                    MessageBox.Show("No se pudo cargar los vendedores de la actividad", "Servicioalcliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    If db.State = ConnectionState.Open Then
                        db.Close()
                    End If

                    Exit Sub
                End Try
            End Using

        End Using

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If Me.cmbActividades.SelectedValue Is Nothing Then Exit Sub

        Dim actividad As Integer = CType(Me.cmbActividades.SelectedValue, Integer)

        CheckForIllegalCrossThreadCalls = False

        Dim _thread As Thread = New Thread(AddressOf CargarActividad)

        _thread.Start(actividad)

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles cmdEliminar.Click
        If Me.lvVendedores.SelectedItems.Count = 0 Then
            MessageBox.Show("Debe seleccionar un vendedor", "Servicio al Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If MessageBox.Show("Confirma Inactivar los vendedores seleccionados de la actividad", _
                           "Servicio al Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            Using db As SqlConnection = New SqlConnection(Variables.ConnectionString)
                Dim i As Integer
                For i = 0 To Me.lvVendedores.SelectedItems.Count - 1
                    Using cmd As SqlCommand = New SqlCommand("UPDATE actividades_vendedores " & _
                                                             "SET estado = 2 " & _
                                                             "WHERE actividad = @actividad and vendedor = @vendedor", db)
                        cmd.Parameters.AddWithValue("@actividad", ActividadSeleccionada)
                        cmd.Parameters.AddWithValue("@vendedor", Me.lvVendedores.SelectedItems(i).Text)
                        Try
                            db.Open()
                            Dim rst = cmd.ExecuteNonQuery
                            db.Close()
                        Catch ex As Exception
                            If db.State = ConnectionState.Open Then
                                db.Close()
                            End If
                            MessageBox.Show("No se pudo inactivar " + Me.lvVendedores.SelectedItems(i).SubItems(2).Text, "Servicio al CLiente", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Exit Sub
                        End Try
                    End Using
                Next i
            End Using
            Dim _thread As Thread = New Thread(AddressOf CargarActividad)

            _thread.Start(ActividadSeleccionada)
        End If
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        With frmVistaPrevia
            .TypeReport = frmVistaPrevia.Reports.InformeActividades
            .selectionformula = "{actividades_vendedores.actividad} = " & ActividadSeleccionada
            .AddFormula("fecha", Me.cmbActividades.Text)
            .AddFormula("v_usuario", Usuario)
            .Show()
        End With
    End Sub
    Private Sub cmdCerrar_Click(sender As System.Object, e As System.EventArgs) Handles cmdCerrar.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click_1(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If MessageBox.Show("Desea guardar la confirmacion de asistencia a la actividad", My.Application.Info.Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.No Then
            Exit Sub
        End If
        Using db As SqlConnection = New SqlConnection(Variables.ConnectionString)
            Try
                db.Open()
            Catch ex As Exception
                MessageBox.Show("No se pudo conectar a la base de datos", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End Try
            For Each item As ListViewItem In Me.lvVendedores.Items
                Using cmd As SqlCommand = New SqlCommand("ConfirmacionAsistenciaActividad", db)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@actividad", ActividadSeleccionada)
                    cmd.Parameters.AddWithValue("@vendedor", item.Text)
                    If item.Checked Then
                        cmd.Parameters.AddWithValue("@asistencia", 1)
                    Else
                        cmd.Parameters.AddWithValue("@asistencia", 0)
                    End If
                    Try

                        Dim rst = cmd.ExecuteNonQuery

                    Catch ex As Exception
                        If db.State = ConnectionState.Open Then
                            db.Close()
                        End If
                        MessageBox.Show("No se pudo confirmar la asistencia " + item.SubItems(2).Text, "Servicio al CLiente", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End Try
                End Using
            Next
            db.Close()
        End Using
        MessageBox.Show("Confirmaciones guardadas correctamente", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        _frmBuscaVendedor = New frmBuscaVendedor
        _frmBuscaVendedor.Show()
    End Sub

    Private Sub _frmBuscaVendedor_VendedorSelected(IDVendedor As String, ByVal Nombre As String) Handles _frmBuscaVendedor.VendedorSelected
        If IDVendedor <> "" Then
            If MessageBox.Show("Desea ingresar el vendedor: " + IDVendedor + " - " + Nombre + " a la actividad?", _
                               My.Application.Info.Title, MessageBoxButtons.YesNo, MessageBoxIcon.Information) = System.Windows.Forms.DialogResult.Yes Then

                Using db As SqlConnection = New SqlConnection(Variables.ConnectionString)
                    Using cmd As SqlCommand = New SqlCommand("sp_JoinActivity", db)
                        Dim rst As Int16
                        cmd.CommandType = CommandType.StoredProcedure
                        cmd.Parameters.AddWithValue("@actividad", ActividadSeleccionada)
                        cmd.Parameters.AddWithValue("@vendedor", IDVendedor)
                        Try
                            db.Open()
                            rst = cmd.ExecuteScalar
                            db.Close()
                        Catch ex As Exception
                            MessageBox.Show("No se pudo ingresar " + ex.Message)
                        End Try
                        If rst = 0 Then
                            MessageBox.Show("Este vendedor ya se unio a esta actividad, Se activo nuevamente", "ServicioalCliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            Dim item As ListViewItem = New ListViewItem(IDVendedor, 0)
                            item.SubItems.Add("")
                            item.SubItems.Add(Nombre)

                            Me.lvVendedores.Items.Add(item)
                            MessageBox.Show("Vendedor se unio a esta actividad", "ServicioalCliente", MessageBoxButtons.OK, MessageBoxIcon.Error)

                        End If
                    End Using
                End Using
            End If
        End If
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        With frmVistaPrevia
            .TypeReport = frmVistaPrevia.Reports.InformeActividades
            .selectionformula = "{actividades_vendedores.actividad} = " & ActividadSeleccionada
            .AddFormula("fecha", Me.cmbActividades.Text)
            .AddFormula("v_usuario", Usuario)
            .Show()
        End With
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Me.ProgressBar1.Visible = False
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Dim smsw As TextMessageLib.Windows.SendSMS = New TextMessageLib.Windows.SendSMS(Usuario)

        For Each i As ListViewItem In Me.lvVendedores.Items

            smsw.AddContact(i.SubItems(2).Text, i.SubItems(4).Text)
        Next
        smsw.Show()
    End Sub
End Class