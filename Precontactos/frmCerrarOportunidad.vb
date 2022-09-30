Imports TrackingContacts.Data
Public Class frmCerrarOportunidad
    Private PrecontactoEnLista As ListaItem = Nothing
    Private GlobalListas As ListasRepository = Nothing
    Private Sub txtOportunidad_GotFocus(sender As Object, e As System.EventArgs) Handles txtObservacion.GotFocus
        txtObservacion.BackColor = Color.FromArgb(222, 237, 250)
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = "Ingrese la observacion de cierre"
        Me.ErrorProvider1.Clear()
    End Sub

    Private Sub txtOportunidad_LostFocus(sender As Object, e As System.EventArgs) Handles txtObservacion.LostFocus
        txtObservacion.BackColor = Color.White
    End Sub

    Private Sub txtReferencia_GotFocus(sender As Object, e As System.EventArgs) Handles txtReferencia.GotFocus
        Me.txtReferencia.BackColor = Color.FromArgb(222, 237, 250)
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = "Ingrese la referencia de cierre(#deposito, orden de pedido)"
        Me.ErrorProvider1.Clear()
    End Sub

    Private Sub txtReferencia_LostFocus(sender As Object, e As System.EventArgs) Handles txtReferencia.LostFocus
        Me.txtReferencia.BackColor = Color.White
    End Sub

    Private Sub cmdGuardar_Click(sender As System.Object, e As System.EventArgs) Handles cmdGuardar.Click
        Dim haserror As Boolean
        If Me.txtObservacion.Text = "" Then
            Me.ErrorProvider1.SetError(Me.txtObservacion, "Ingrese la observacion de cierre")
            haserror = True
        End If
        If Me.cmbEstado.SelectedValue Is Nothing Then
            Me.ErrorProvider1.SetError(Me.cmbEstado, "Seleccione el estado")
            haserror = True
        End If

        Dim oporepo As OportunidadesRepository = New OportunidadesRepository(db)

        oporepo.Close(PrecontactoEnLista, Me.txtObservacion.Text, Me.cmbEstado.SelectedItem, Me.txtReferencia.Text)

        RaiseEvent AddCierreFinished(PrecontactoEnLista)

        Me.Close()
    End Sub

    Public Event AddCierreFinished(ByRef precontactoenlista As ListaItem)


End Class
