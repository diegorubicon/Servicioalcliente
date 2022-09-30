Public Class frmReporteCategorias
    Public Fecha1 As Date
    Public fecha2 As Date
    Public vendedor As String
    Private Sub frmReporteCategorias_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.rptCategoriasEstudios1.RecordSelectionFormula += " and {facturas_encabezado.fecha} in date(" & Fecha1.Year.ToString + "," + Fecha1.Month.ToString + "," + Fecha1.Day.ToString & ") to date(" & fecha2.Year.ToString + "," + fecha2.Month.ToString + "," + fecha2.Day.ToString & ")"
        Me.rptCategoriasEstudios1.RecordSelectionFormula += " and {facturas_encabezado.vendedor}  = '" & vendedor & "'"
        Me.rptCategoriasEstudios1.DataDefinition.FormulaFields("compania").Text = "'Nugajed S.A.'"
        Me.rptCategoriasEstudios1.DataDefinition.FormulaFields("usuario").Text = "'" + Variables.Usuario + "'"
        Me.rptCategoriasEstudios1.DataDefinition.FormulaFields("fecha").Text = "'Desde: " + Fecha1.ToShortDateString + " Hasta: " + fecha2.ToShortDateString & "'"
        Me.rptCategoriasEstudios1.DataDefinition.FormulaFields("vendedor").Text = "'Vendedor: " + frmMain.lbVendedor.Text + "'"

    End Sub
End Class