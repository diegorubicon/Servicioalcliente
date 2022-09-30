Public Class frmReporteCumpleaños
    Public fecha1 As Date
    Public fecha2 As Date
    Private Sub frmReporteCumpleaños_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim reporte As rptContratosNuevos
        Dim login As CrystalDecisions.Shared.TableLogOnInfo
        Dim i As Integer
        Try
            reporte = New rptContratosNuevos
            login = New CrystalDecisions.Shared.TableLogOnInfo
            login.ConnectionInfo.ServerName = Variables.Servidor
            login.ConnectionInfo.UserID = Variables.Usuario
            login.ConnectionInfo.DatabaseName = Variables.DataBase
            login.ConnectionInfo.Password = getMD5Hash(Variables.Password).ToUpper
            For i = 0 To reporte.Database.Tables.Count - 1
                reporte.Database.Tables(i).ApplyLogOnInfo(login)
            Next
            reporte.RecordSelectionFormula = "{vendedores.creado_el} in date(" & fecha1.Year.ToString + "," + fecha1.Month.ToString + "," + fecha1.Day.ToString & ") to date(" & fecha2.Year.ToString + "," + fecha2.Month.ToString + "," + fecha2.Day.ToString & ")"
            reporte.DataDefinition.FormulaFields("compania").Text = "'Master Cocina Inc'"
            reporte.DataDefinition.FormulaFields("v_usuario").Text = "'" + Variables.Usuario + "'"
            reporte.DataDefinition.FormulaFields("fecha").Text = "'Desde: " + fecha1.ToShortDateString + " Hasta: " + fecha2.ToShortDateString & "'"
            reporte.Refresh()
            Me.CrystalReportViewer1.ReportSource = reporte
            Me.CrystalReportViewer1.Refresh()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ServicioalCliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load

    End Sub
End Class



