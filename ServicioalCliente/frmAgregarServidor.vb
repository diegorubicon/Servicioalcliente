Public Class frmAgregarServidor
    Private Sub cmdSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSiguiente.Click
        Dim sett As LoginSettings

        sett = New LoginSettings
        sett.AddSettings(Me.txtAdress.Text, Me.txtBaseDatos.Text, Me.txtDescripcion.Text)
        Me.Close()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class