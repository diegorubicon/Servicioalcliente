Imports TrackingContacts.Data
Public Class frmCrearLista
    Public Event InsertedList(inserted As lista)
    Private Sub cmdGuardar_Click(sender As System.Object, e As System.EventArgs) Handles cmdGuardar.Click
        If Me.txtNombre.Text = "" Then
            Me.ErrorProvider1.SetError(Me.txtNombre, "Ingrese el nombre de la lista")
            Exit Sub
        End If

        If Me.txtIntereses.Text = "" Then
            Me.txtIntereses.Text = "NO ESPECIFICADO;"
        End If

        Dim lists As ListasRepository = New ListasRepository(Variables.db)
        Dim newlst As lista

        newlst = lists.Add(Me.txtNombre.Text, Me.txtIntereses.Text.Split(";").ToList)

        Me.Close()

        RaiseEvent InsertedList(newlst)
    End Sub

    Private Sub KryptonButton3_Click(sender As System.Object, e As System.EventArgs) Handles KryptonButton3.Click
        Me.Close()
    End Sub
End Class