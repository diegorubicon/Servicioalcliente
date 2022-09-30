Public Class frmOportunidades

    Private Sub frmOportunidades_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(assigneddealer As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim s As Sales.Opportunities.SalesOpportunities

        s = New Sales.Opportunities.SalesOpportunities(Variables.ConnectionStringCRM, assigneddealer)

        For Each o As Sales.Opportunities.SalesOpportunity In s
            Dim item As ListViewItem = New ListViewItem(o.Id)
            item.SubItems.Add(o.Contact.Id)
            item.SubItems.Add(o.Contact.Nombre + " " + o.Contact.Apellido01 + " " + o.Contact.Apellido02)
            item.SubItems.Add(o.Contact.Telefono01)
            item.SubItems.Add(o.Contact.Telefono02)
            item.SubItems.Add(o.Provincia.Name)
            item.SubItems.Add(o.Canton.Name)
            item.SubItems.Add(o.Distrito.Name)

            Me.lvOportunidades.Items.Add(item)
        Next
    End Sub

    Private Sub cmdCerrar_Click(sender As System.Object, e As System.EventArgs) Handles cmdCerrar.Click
        Me.Close()
    End Sub
End Class