Imports SalesForce.Business
Public Class frmBuscaVendedor
    Private _cnnstr As String

    Public Event VendedorSeleccionado(Vendedor As SalesForce.Entities.Vendedor)

    Private Sub cmdBuscaVendedor_Click(sender As System.Object, e As System.EventArgs) Handles cmdBuscaVendedor.Click
        Me.lvVendedores.Items.Clear()
        If Me.txtFiltro.Text = String.Empty Then
            Exit Sub
        End If

        Dim vend As Vendedor = New Vendedor(_cnnstr)

        For Each v As Entities.Vendedor In vend.FilterByName(Me.txtFiltro.Text)
            Dim item As ListViewItem = New ListViewItem(v.Id)
            item.SubItems.Add(v.NombreCompleto)
            item.Tag = v
            Me.lvVendedores.Items.Add(item)
        Next

    End Sub

    Public Sub New(CadenadeConexion As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _cnnstr = CadenadeConexion
    End Sub
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

  
    End Sub

    Private Sub cmdSeleccionar_Click(sender As System.Object, e As System.EventArgs) Handles cmdSeleccionar.Click
        If Me.lvVendedores.SelectedItems.Count = 0 Then
            Exit Sub
        End If

        RaiseEvent VendedorSeleccionado(Me.lvVendedores.SelectedItems(0).Tag)

        Me.Close()
    End Sub

    Private Sub cmdCerrar_Click(sender As System.Object, e As System.EventArgs) Handles cmdCerrar.Click
        Me.Close()
    End Sub
End Class
