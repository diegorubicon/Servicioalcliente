Imports TrackingContacts.Data
Public Class frmObservaciones
    Private _miembro As ListaItem

    Public Event InsertNote(miembro As ListaItem)

    Private Sub frmObservaciones_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        Me.txtObservacion.Focus()
    End Sub

    Private Sub frmObservaciones_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
        If e.KeyCode = Keys.F5 Then
            cmdGuardar_Click(Me, Nothing)
        End If
    End Sub

    Private Sub frmObservaciones_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = "Presione F5 para guardar la observacion"
    End Sub

    Private Sub cmdGuardar_Click(sender As System.Object, e As System.EventArgs) Handles cmdGuardar.Click
        Dim _nota As nota
        Dim haserror As Boolean = False

        If txtObservacion.Text = "" Then
            Me.ErrorProvider1.SetError(Me.txtObservacion, "Ingrese la observacion")
            haserror = True
            Me.txtObservacion.Focus()
        End If

        If Me.cmbIntereses.SelectedItem Is Nothing Then
            Me.ErrorProvider1.SetError(Me.cmbIntereses, "Seleccione el interes")
            haserror = True
            Me.cmbIntereses.Focus()
        End If

        If Me.cmbEstado.SelectedItem Is Nothing Then
            Me.ErrorProvider1.SetError(Me.cmbEstado, "Seleccione el estado")
            haserror = True
            Me.cmbEstado.Focus()
        End If

        If haserror Then Exit Sub

        If Not _miembro Is Nothing Then
            _miembro.InteresType = Me.cmbIntereses.SelectedItem
            _miembro.InteresStatus = Me.cmbEstado.SelectedItem
            _miembro.interes_especifico = Me.txtInteresEspecifico.Text

            _nota = New nota
            _nota.fecha = Now.Date
            _nota.observacion = txtObservacion.Text
            _nota.id_InteresActual = CType(Me.cmbIntereses.SelectedValue, Integer)
            _nota.id_EstadoActual = CType(Me.cmbEstado.SelectedValue, Integer)
            _nota.creado_por = Variables.usuario

            _miembro.notas.Add(_nota)

            Me.txtObservaciones.Text += CType(_nota.fecha, DateTime).ToShortDateString + "-" + _nota.observacion + ". "
            Me.txtObservaciones.Refresh()
            Me.KryptonHeaderGroup1.ValuesSecondary.Heading = "Observacion Guardada Correctamente"
            Me.txtObservacion.Text = ""
            Me.txtObservacion.Focus()

            RaiseEvent InsertNote(_miembro)
        End If

    End Sub

    Private Sub txtObservacion_GotFocus(sender As Object, e As System.EventArgs) Handles txtObservacion.GotFocus
        Me.txtObservacion.BackColor = Color.FromArgb(222, 237, 250)
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = "Ingrese la observacion"
    End Sub

    Private Sub KryptonButton3_Click(sender As System.Object, e As System.EventArgs) Handles KryptonButton3.Click
        Me.Close()
    End Sub

    Private Sub txtObservacion_LostFocus(sender As Object, e As System.EventArgs) Handles txtObservacion.LostFocus
        Me.txtObservacion.BackColor = Color.White
    End Sub

    Private Sub txtObservacion_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtObservacion.TextChanged

    End Sub

    Private Sub txtInteresEspecifico_GotFocus(sender As Object, e As System.EventArgs) Handles txtInteresEspecifico.GotFocus
        Me.txtInteresEspecifico.BackColor = Color.FromArgb(222, 237, 250)
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = "Ingrese el interes especifico del pre-contacto"
    End Sub

    Private Sub txtInteresEspecifico_LostFocus(sender As Object, e As System.EventArgs) Handles txtInteresEspecifico.LostFocus
        Me.txtInteresEspecifico.BackColor = Color.White
    End Sub

    Private Sub txtInteresEspecifico_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtInteresEspecifico.TextChanged

    End Sub
End Class
