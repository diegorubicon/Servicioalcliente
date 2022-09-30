Imports Clientes.BusinessLayer
Imports System.Windows.Forms

Public Class frmBusquedaClientes
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

        If Me.txtTextoBusqueda.Text = String.Empty Then
            Exit Sub
        End If

        Dim clientes As Cliente = New Cliente(_cnnstr)

        For Each c As Entities.Cliente In clientes.Filter(Me.txtTextoBusqueda.Text)

            Dim item As ListViewItem = New ListViewItem(c.Codigo)
            item.SubItems.Add(c.NombreCompleto)
            item.Tag = c
            Me.lvClientes.Items.Add(item)

        Next
    End Sub

    Private Sub txtTextoBusqueda_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtTextoBusqueda.KeyDown
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
                Me.txtTextoBusqueda.Focus()
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

    Private Sub lvClientes_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lvClientes.SelectedIndexChanged

    End Sub
End Class
