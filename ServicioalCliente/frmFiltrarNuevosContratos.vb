Public Class frmFiltrarNuevosContratos

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim sql As String
        Me.Cursor = Cursors.WaitCursor
        With frmVistaPrevia
            .TypeReport = frmVistaPrevia.Reports.NuevosVendedores
            Sql = "{vendedores.creado_el} in Date (" & Me.DateTimePicker1.Value.Year & "," & _
                                                           Me.DateTimePicker1.Value.Month & "," & _
                                                           Me.DateTimePicker1.Value.Day & ") " & _
                                               "to Date (" & Me.DateTimePicker2.Value.Year & "," & _
                                                        Me.DateTimePicker2.Value.Month & "," & _
                                                        Me.DateTimePicker2.Value.Day & ")"



            .selectionformula = sql
            .AddFormula("compania", "Master Cocina")
            .AddFormula("fecha", "Desde " + Me.DateTimePicker1.Value.ToShortDateString + " Hasta " + Me.DateTimePicker2.Value.ToShortDateString)
            .AddFormula("v_usuario", Usuario)
            .Show()
        End With
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class