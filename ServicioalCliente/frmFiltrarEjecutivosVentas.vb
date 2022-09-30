Imports System.Data.SqlClient
Public Class frmFiltrarEjecutivosVentas

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub frmFiltrarEjecutivosVentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cmd As SqlCommand, cmd2 As SqlCommand
        Dim da As SqlDataAdapter, da2 As SqlDataAdapter
        Dim ds As DataSet, ds2 As DataSet
        Try
            cmd = New SqlCommand("GetCierre", db)
            cmd.CommandType = CommandType.StoredProcedure
            da = New SqlDataAdapter
            da.SelectCommand = cmd
            ds = New DataSet
            da.Fill(ds)

            cmd2 = New SqlCommand("GetCierre", db)
            cmd2.CommandType = CommandType.StoredProcedure
            da2 = New SqlDataAdapter
            da2.SelectCommand = cmd
            ds2 = New DataSet
            da2.Fill(ds2)
            Me.cmbCierre1.DataSource = ds.Tables(0)
            Me.cmbCierre1.DisplayMember = ds.Tables(0).Columns(1).Caption
            Me.cmbCierre1.ValueMember = ds.Tables(0).Columns(0).Caption

            Me.cmbcierre2.DataSource = ds2.Tables(0)
            Me.cmbcierre2.DisplayMember = ds2.Tables(0).Columns(1).Caption
            Me.cmbcierre2.ValueMember = ds2.Tables(0).Columns(0).Caption
        Catch ex As SqlException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmVistaPrevia.selectionformula = "{vendedor_promocion.cierre} >= " & Me.cmbCierre1.SelectedValue.ToString & " and {vendedor_promocion.cierre} <= " & Me.cmbcierre2.SelectedValue.ToString & " and {vendedor_promocion.nivel_actual} = 2"
        frmVistaPrevia.AddFormula("fecha", "'Desde: " + Me.cmbCierre1.Text + " Hasta: " + Me.cmbcierre2.Text & "'")
        frmVistaPrevia.AddFormula("compania", "Master Cocina")
        frmVistaPrevia.AddFormula("v_usuario", Usuario)
        frmVistaPrevia.Show()
    End Sub
End Class