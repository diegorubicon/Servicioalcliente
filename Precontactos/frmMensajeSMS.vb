Public Class frmMensajeSMS
    Public mensaje As String
    Public horaenvio As DateTime
    Public fechaenvio As DateTime
    Public withinfo As Boolean = False
    Private Sub cmdTerminar_Click(sender As System.Object, e As System.EventArgs) Handles cmdTerminar.Click
        withinfo = True
        mensaje = Me.txtmensaje.text
        horaenvio = Me.dtHoraEnvio.Value
        fechaenvio = Me.dtFechaEnvio.Value

        Me.Close()
    End Sub

    Private Sub cmdCancelar_Click(sender As System.Object, e As System.EventArgs) Handles cmdCancelar.Click
        withinfo = False
        Me.Close()
    End Sub
End Class