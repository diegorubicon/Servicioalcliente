Public Class frmVistaPrevia
    Public Enum Reports
        EjecutivoVentas = 1
        SeguimientoLlamadas = 2
        SeguimientoVendedores = 3
        InformeActividades = 4
        VendedoresInactivos = 5
        ReclutasActivosInactivos = 6
        CategoriasEstudioCredito = 7
        VentasVendedor = 8
        NuevosVendedores = 9
        DistribuidoresNoContactados = 10
    End Enum
    Private LoadReport As Boolean = False
    Public Structure TypeFormulas
        Dim name As String
        Dim value As String
    End Structure
    Public selectionformula As String
    Public fecha As String
    Public TypeReport As Reports
    Public Formulas() As TypeFormulas
    Public Sub AddFormula(ByVal name As String, ByVal value As String)
        Dim index As Integer
        If Formulas Is Nothing Then
            index = 0
        Else
            index = Formulas.Length
        End If
        ReDim Preserve Formulas(index)
        Formulas(index).name = name
        Formulas(index).value = value
    End Sub
    Private Sub frmVistaPrevia_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
      

    End Sub

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ReDim Formulas(-1)

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

  
    Private Sub CrystalReportViewer1_Load(sender As System.Object, e As System.EventArgs) Handles CrystalReportViewer1.Load
        'MessageBox.Show("CArgo")
        Dim reporte As Object
        Dim login As CrystalDecisions.Shared.TableLogOnInfo
        Dim i As Integer

        If LoadReport Then
            Exit Sub
        End If

        Try

            Select Case TypeReport
                Case 1 : reporte = New rptEjecutivoVentas
                Case 2 : reporte = New rptSeguimientoLlamadas
                Case 3 : reporte = New rptSeguimientoVendedores
                Case 4 : reporte = New rptInformeActividades
                Case 5 : reporte = New rptVendedoresInactivos
                Case 6 : reporte = New rptActivosInactivos
                Case 7 : reporte = New rptCategoriasEstudios
                Case 8 : reporte = New rptRegistroMentasPorPeriodo
                Case 9 : reporte = New rptContratosNuevos
                Case 10 : reporte = New rptDistribuidoresNoContactados
                Case Else : reporte = New rptEjecutivoVentas
            End Select
            login = New CrystalDecisions.Shared.TableLogOnInfo
            login.ConnectionInfo.ServerName = Variables.Servidor
            login.ConnectionInfo.UserID = Variables.Usuario
            login.ConnectionInfo.DatabaseName = Variables.DataBase
            login.ConnectionInfo.Password = getMD5Hash(Variables.Password).ToUpper

            Dim rpt As New rptContratosNuevos

            For i = 0 To reporte.Database.Tables.Count - 1
                reporte.Database.Tables(i).ApplyLogOnInfo(login)
            Next
            'reporte.RecordSelectionFormula = selectionformula
            For i = 0 To Formulas.Length - 1
                reporte.DataDefinition.FormulaFields(Formulas(i).name).Text = "'" & Formulas(i).value & "'"
            Next
            reporte.Refresh()
            Me.CrystalReportViewer1.SelectionFormula = selectionformula
            Me.CrystalReportViewer1.ReportSource = reporte
            Me.CrystalReportViewer1.Refresh()
            LoadReport = True
        Catch ex As Exception
            LoadReport = False
            MessageBox.Show("No se pudo visualizar el reporte " + ex.InnerException.Message, "Servicioalcliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class