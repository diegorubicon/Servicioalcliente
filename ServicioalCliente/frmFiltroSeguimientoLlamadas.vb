Imports System.Data.SqlClient
Public Class frmFiltroSeguimientoLlamadas
    Public tipo As Integer = 1
    Private Sub cmdCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCerrar.Click
        Me.Close()
    End Sub
    Private Sub DistribuidoresNoContactados()
        With frmVistaPrevia
            .TypeReport = frmVistaPrevia.Reports.DistribuidoresNoContactados

            If Not Me.ckFecha.Checked Then
                .AddFormula("fecha", "Desde " + CType(Me.DateTimePicker1.Value.ToShortDateString, String) + " hasta " + CType(Me.DateTimePicker2.Value.ToShortDateString, String))
                .AddFormula("fecha1", Me.DateTimePicker1.Value.ToShortDateString)
                .AddFormula("fecha2", Me.DateTimePicker2.Value.ToShortDateString)
              
            Else
                .AddFormula("fecha", "Todas las fechas")
                .AddFormula("fecha1", "01/01/1900")
                .AddFormula("fecha2", DateTime.Now.ToShortDateString)
            End If
            .AddFormula("compania", "Master Cocina")
            .AddFormula("v_usuario", Usuario)
            .Show()
        End With
    End Sub
    Private Sub cmdVistaPrevia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdVistaPrevia.Click
        Dim sql As String = ""
        If Me.ComboBox1.Text = "No Contactados" Then
            DistribuidoresNoContactados()
            Exit Sub
        End If

        With frmVistaPrevia
            If tipo = 1 Then
                .TypeReport = frmVistaPrevia.Reports.SeguimientoLlamadas
            Else
                .TypeReport = frmVistaPrevia.Reports.SeguimientoVendedores
            End If

            'Filtro de acuerdo a la fecha
            If Not Me.ckFecha.Checked Then
                .AddFormula("fecha", "Desde " + CType(Me.DateTimePicker1.Value.ToShortDateString, String) + " hasta " + CType(Me.DateTimePicker2.Value.ToShortDateString, String))

                sql = "{notas_cobro.creado_el} in Date (" & Me.DateTimePicker1.Value.Year & "," & _
                                                           Me.DateTimePicker1.Value.Month & "," & _
                                                           Me.DateTimePicker1.Value.Day & ") " & _
                                               "to Date (" & Me.DateTimePicker2.Value.Year & "," & _
                                                        Me.DateTimePicker2.Value.Month & "," & _
                                                        Me.DateTimePicker2.Value.Day & ")"
            Else
                .AddFormula("fecha", "Todas las fechas")
            End If

            'Filtro deacuero al tipo de llamada
            If Not Me.ckTipoLlamada.Checked Then
                If sql <> "" Then
                    sql = sql + " and "
                End If
                Select Case Me.ComboBox1.Text
                    Case "Tipo A" : sql = sql + "{notas_cobro.estado} = 1"
                    Case "Tipo B" : sql = sql + "{notas_cobro.estado} = 2"
                    Case "Tipo C" : sql = sql + "{notas_cobro.estado} = 3"
                End Select
            End If
            If tipo = 1 Then

            Else
                'Filtro para el reporte seguimiento de vendedores                
                If Not Me.cb_Provincias.Checked Then
                    If sql <> "" Then
                        sql += " AND "
                    End If
                    sql += " {vendedores.provincia} = " & Me.cmbProvincia.SelectedValue
                End If
                If Not Me.cb_canton.Checked Then
                    If sql <> "" Then
                        sql += " AND "
                    End If
                    sql += " {vendedores.canton} = " & Me.cmbCanton.SelectedValue
                End If
                If Not Me.cb_distrito.Checked Then
                    If sql <> "" Then
                        sql += " AND "
                    End If
                    sql += " {vendedores.distrito} = " & Me.cmbDistrito.SelectedValue
                End If
            End If
            .selectionformula = sql
            .AddFormula("compania", "Master Cocina")
            .AddFormula("v_usuario", Usuario)
            .Show()
        End With
    End Sub

    Private Sub frmFiltroSeguimientoLlamadas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim cmd As SqlCommand
        Dim da As SqlDataAdapter
        Dim ds As New DataSet

        cmd = New SqlCommand("SELECT provincia,descripcion  FROM provincias", db)
        da = New SqlDataAdapter(cmd)
        Try
            da.Fill(ds, "provincias")
            Me.cmbProvincia.DataSource = ds.Tables("provincias")
            Me.cmbProvincia.DisplayMember = "descripcion"
            Me.cmbProvincia.ValueMember = "provincia"
        Catch ex As Exception

        End Try
        If tipo = 1 Then
            Me.Text = "Seguimiento Llamadas"
        Else
            Me.Text = "Seguimiento Vendedores"
        End If
    End Sub
    Private Sub cmbProvincia_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbProvincia.SelectionChangeCommitted
        Dim cmd As SqlCommand
        Dim da As SqlDataAdapter
        Dim ds As New DataSet
        Dim opara As SqlParameter

        If Not Me.cmbProvincia.SelectedValue Is Nothing Then
            cmd = New SqlCommand("Select canton,descripcion from cantones where provincia = @provincia", db)
            opara = New SqlParameter("@provincia", Me.cmbProvincia.SelectedValue)
            cmd.Parameters.Add(opara)
            da = New SqlDataAdapter(cmd)
            Try
                da.Fill(ds, "cantones")
                Me.cmbCanton.DataSource = ds.Tables("cantones")
                Me.cmbCanton.DisplayMember = "descripcion"
                Me.cmbCanton.ValueMember = "canton"
            Catch ex As Exception
                MessageBox.Show("No se pudo obtener la informacion de los Cantones " + ex.Message, "ServicioalCliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
    Private Sub cmbCanton_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCanton.SelectionChangeCommitted
        Dim cmd As SqlCommand
        Dim opara As SqlParameter
        Dim da As SqlDataAdapter
        Dim ds As New DataSet
        If Not Me.cmbProvincia.SelectedValue Is Nothing Then
            cmd = New SqlCommand("Select distrito,descripcion from distritos where provincia = @provincia and canton = @canton", db)
            opara = New SqlParameter("@provincia", Me.cmbProvincia.SelectedValue)
            cmd.Parameters.Add(opara)
            opara = New SqlParameter("@canton", Me.cmbCanton.SelectedValue)
            cmd.Parameters.Add(opara)
            da = New SqlDataAdapter(cmd)
            Try
                da.Fill(ds, "distritos")
                Me.cmbDistrito.DataSource = ds.Tables("distritos")
                Me.cmbDistrito.DisplayMember = "descripcion"
                Me.cmbDistrito.ValueMember = "distrito"
            Catch ex As Exception
                MessageBox.Show("No se pudo obtener la informacion de los Distritos" + ex.Message, "ServicioalCliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
End Class