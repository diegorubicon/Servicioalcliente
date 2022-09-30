Imports System.Data.SqlClient
Public Class frmFiltroActividades

    Private Sub cmdCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCerrar.Click
        Me.Close()
    End Sub

    Private Sub frmFiltroActividades_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cmd As SqlCommand
        Dim opara As SqlParameter
        Dim da As SqlDataAdapter
        Dim ds As New DataSet

        cmd = New SqlCommand("sp_GetActivities", db)
        cmd.CommandType = CommandType.StoredProcedure
        opara = New SqlParameter("@actividad", -1)
        cmd.Parameters.Add(opara)
        da = New SqlDataAdapter
        da.SelectCommand = cmd
        ds = New DataSet
        Try
            da.Fill(ds)
            Me.SuspendLayout()
            Me.cmbActividades.DataSource = ds.Tables(0)
            Me.cmbActividades.DisplayMember = "titulo"
            Me.cmbActividades.ValueMember = "actividad"
            Me.ResumeLayout()
        Catch ex As Exception
            MessageBox.Show("No se pudo obtener las actividades " + ex.Message, "Servicioalcliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmdVistaPrevia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdVistaPrevia.Click
        If Me.cmbActividades.SelectedValue Is Nothing Then
            MessageBox.Show("Debe Seleccionar una actividad", "Servicioalcliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        With frmVistaPrevia
            .TypeReport = frmVistaPrevia.Reports.InformeActividades
            .selectionformula = "{actividades_vendedores.actividad} = " & Me.cmbActividades.SelectedValue
            .AddFormula("compania", "Master Cocina")
            .AddFormula("fecha", Me.cmbActividades.Text)
            .AddFormula("v_usuario", Usuario)
            .Show()
        End With
    End Sub
End Class