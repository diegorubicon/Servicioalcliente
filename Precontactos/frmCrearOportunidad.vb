Imports TrackingContacts.Data
Public Class frmCrearOportunidad
    Private _pre As ListaItem
    Private action As Integer
    Public Event UpdateStatus(ByRef _precontacto As ListaItem)
    Public Event AddOportunity(ByRef _precontacto As ListaItem)
    Private WithEvents _frmBuscaVendedor As frmBuscarVendedor
    Private Sub cmbProvincia_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles cmbProvincia.SelectedValueChanged
        If Not cmbProvincia.SelectedItem Is Nothing Then
            Me.cmbCanton.Items.Clear()
            Dim provincia As provincia = Me.cmbProvincia.SelectedItem
            For Each cant In provincia.cantones
                Me.cmbCanton.Items.Add(cant)
            Next
            Me.cmbCanton.DisplayMember = "descripcion"

        Else
            Me.cmbCanton.Items.Clear()
            Me.cmbCanton.SelectedItem = Nothing
        End If
    End Sub

    Private Sub cmbCanton_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles cmbCanton.SelectedValueChanged
        If Not cmbCanton.SelectedItem Is Nothing Then
            Dim cant As cantone = CType(Me.cmbCanton.SelectedItem, cantone)

            Me.cmbDistrito.Items.Clear()
            For Each c As distrito In cant.distritos
                Me.cmbDistrito.Items.Add(c)
            Next

            Me.cmbDistrito.DisplayMember = "descripcion"
        Else
            Me.cmbDistrito.Items.Clear()
            Me.cmbDistrito.SelectedItem = Nothing
        End If
    End Sub

    Private Sub cmdGuardar_Click(sender As System.Object, e As System.EventArgs) Handles cmdGuardar.Click
        If Me.txtIdentificacion.Text = "" Then
            Me.ErrorProvider1.SetError(Me.txtIdentificacion, "Debe ingresar la identificacion")
            Exit Sub
        End If
        If Me.txtDistribuidor.Text = "" Then
            Me.ErrorProvider1.SetError(Me.txtNombreDistribuidor, "Debe ingresar el distribuidor")
            Exit Sub
        End If
        If Me.cmbProvincia.SelectedItem Is Nothing Or Me.cmbCanton.SelectedItem Is Nothing Or Me.cmbDistrito.SelectedItem Is Nothing Then
            Me.ErrorProvider1.SetError(Me.cmbDistrito, "Debe seleccionar la provincia, canton, distrito")
            Exit Sub
        End If

        If Me.txtDireccion.Text = "" Then
            Me.ErrorProvider1.SetError(Me.txtDireccion, "Debe ingresar la direccion")
            Exit Sub
        End If

        Dim repo As OportunidadesRepository = New OportunidadesRepository(db)

        If action = 1 Then
            repo.Add(_pre, Me.txtIdentificacion.Text, Me.cmbProvincia.SelectedItem, Me.cmbCanton.SelectedItem, Me.cmbDistrito.SelectedItem, Me.txtDireccion.Text, Me.txtDistribuidor.Tag)
            RaiseEvent UpdateStatus(_pre)
        Else
            repo.Update(_pre, Me.txtIdentificacion.Text, Me.cmbProvincia.SelectedItem, Me.cmbCanton.SelectedItem, Me.cmbDistrito.SelectedItem, Me.txtDireccion.Text, Me.txtDistribuidor.Tag)
            RaiseEvent AddOportunity(_pre)
        End If

        MessageBox.Show("Se creo la oportunidad de venta correctamente", "Seguimiento Publicidad", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub

    Private Sub txtDistribuidor_LostFocus(sender As Object, e As System.EventArgs) Handles txtDistribuidor.LostFocus
        If Me.txtDistribuidor.Text = "" Then Exit Sub
        Dim distrepo As DistribuidoresRepository

        distrepo = New DistribuidoresRepository(db)
        Dim d As Distribuidor = distrepo.Item(Me.txtDistribuidor.Text)
        If Not d Is Nothing Then
            Me.txtNombreDistribuidor.Text = d.nombre + " " + d.apellido_01 + " " + d.apellido_02
            Me.txtDistribuidor.Tag = d
        End If
    End Sub
    Private Sub txtDistribuidor_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtDistribuidor.TextChanged
        Me.txtNombreDistribuidor.Text = ""
    End Sub

    Private Sub KryptonButton1_Click(sender As System.Object, e As System.EventArgs) Handles KryptonButton1.Click
        _frmBuscaVendedor = New frmBuscarVendedor
        _frmBuscaVendedor.ShowDialog()
    End Sub
    Private Sub _frmBuscaVendedor_SelectedDistribuidor(Selected As Distribuidor) Handles _frmBuscaVendedor.SelectedDistribuidor
        Me.txtDistribuidor.Text = Selected.id_distribuidor
        Me.txtDistribuidor.Tag = Selected
        Me.txtNombreDistribuidor.Text = Selected.nombre + " " + Selected.apellido_01 + " " + Selected.apellido_02
    End Sub

    Private Sub KryptonButton3_Click(sender As System.Object, e As System.EventArgs) Handles KryptonButton3.Click
        Me.Close()
    End Sub
End Class
