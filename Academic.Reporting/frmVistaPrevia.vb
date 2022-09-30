Public Class frmVistaPrevia

    Public Sub New(ReportSource As Object)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.crViewer.ReportSource = ReportSource

    End Sub
End Class