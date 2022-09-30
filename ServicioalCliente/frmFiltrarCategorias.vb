Public Class frmFiltrarCategorias
    Private Sub frmFiltrarCategorias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtdate1.Value = DateTime.Now
        Me.txtdate2.Value = DateTime.Now
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        With frmVistaPrevia
            .TypeReport = frmVistaPrevia.Reports.CategoriasEstudioCredito
            .AddFormula("compania", Variables.Compania)
            .AddFormula("fecha", "Del " + CStr(Me.txtdate1.Value) + " al " + CStr(Me.txtdate2.Value))
            .selectionformula = "{facturas_encabezado.vendedor} = '" & frmMain.txtvendedor.Text & "' and {facturas_encabezado.estado} <> 4 and {facturas_encabezado.tipo} < 3 "
            .Show()
        End With
        
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class