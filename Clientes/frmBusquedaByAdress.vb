Imports Clientes.BusinessLayer
Imports System.Windows.Forms
Imports TerritorialDivisionLib

Public Class frmBusquedaByAdress
    Private _cnnstr As String
    Public Event ClientSelected(ByRef cliente As Entities.Cliente)

    Public Sub New(ConnectionString As String)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _cnnstr = ConnectionString
    End Sub

    Private Sub cmdIniciarBusqueda_Click(sender As System.Object, e As System.EventArgs) Handles cmdIniciarBusqueda.Click
        Me.lvClientes.Items.Clear()

        If Me.cmbProvincia.SelectedItem Is Nothing And Me.cmbCanton.SelectedItem Is Nothing And Me.cmbDistrito Is Nothing Then
            Exit Sub
        End If
        If Not Me.cmbCanton.SelectedItem Is Nothing Then
            If CType(Me.cmbCanton.SelectedItem, Canton).ID = -1 Then
                Me.cmbCanton.SelectedItem = Nothing
            End If
        End If

        If Not Me.cmbDistrito.SelectedItem Is Nothing Then
            If CType(Me.cmbDistrito.SelectedItem, District).ID = -1 Then
                Me.cmbDistrito.SelectedItem = Nothing
            End If
        End If


        Dim clientes As Cliente = New Cliente(_cnnstr)

        For Each c As Entities.Cliente In clientes.FilterByAdress(Me.cmbProvincia.SelectedItem, Me.cmbCanton.SelectedItem, Me.cmbDistrito.SelectedItem)
            Dim item As ListViewItem = New ListViewItem(c.Codigo)
            item.SubItems.Add(c.NombreCompleto)
            item.Tag = c
            Me.lvClientes.Items.Add(item)
        Next
    End Sub

    Private Sub txtTextoBusqueda_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Return Then
            cmdIniciarBusqueda_Click(sender, e)
        End If
        If e.KeyCode = Keys.Down Then
            Me.lvClientes.Focus()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub lvClientes_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles lvClientes.KeyDown
        If e.KeyCode = Keys.Return Then
            cmdSeleccionar_Click(sender, e)
        End If
        If e.KeyCode = Keys.Up Then
            If Me.lvClientes.SelectedItems(0).Index = 0 Then

            End If
        End If
    End Sub
    Private Sub cmdCancelar_Click(sender As System.Object, e As System.EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub cmdSeleccionar_Click(sender As System.Object, e As System.EventArgs) Handles cmdSeleccionar.Click
        If Me.lvClientes.SelectedItems.Count = 0 Then
            Exit Sub
        End If

        RaiseEvent ClientSelected(Me.lvClientes.SelectedItems(0).Tag)

        Me.Close()
    End Sub

    Private Sub frmBusquedaByAdress_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim Provincias As New Provinces

        Me.cmbProvincia.Items.Clear()

        For Each prov As Province In Provincias
            Me.cmbProvincia.Items.Add(prov)
        Next

    End Sub

    Private Sub cmbProvincia_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbProvincia.SelectedIndexChanged
        Me.cmbCanton.Items.Clear()

        Dim sel As Province = CType(Me.cmbProvincia.SelectedItem, Province)

        Me.cmbCanton.Items.Add(New Canton With {.ID = -1, .Name = "TODOS"})

        For Each cant As Canton In sel.Cantons
            Me.cmbCanton.Items.Add(cant)
        Next

       

    End Sub

    Private Sub cmbCanton_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbCanton.SelectedIndexChanged
        Me.cmbDistrito.Items.Clear()

        Dim sel As Canton = CType(Me.cmbCanton.SelectedItem, Canton)

        Me.cmbDistrito.Items.Add(New District With {.ID = -1, .Name = "TODOS"})
        For Each dist As District In sel.Districts
            Me.cmbDistrito.Items.Add(dist)
        Next

      

    End Sub
End Class
