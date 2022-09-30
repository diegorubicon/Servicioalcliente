Imports TrackingContacts.Data
Public Class frmCambiarLista
    Private _precontacto As Contacto = Nothing
    Public Event DeleteFromList(RemovePrecontacto As Contacto, List As lista)

    Private Sub KryptonButton1_Click(sender As System.Object, e As System.EventArgs) Handles KryptonButton1.Click
        Dim newlist As lista = Me.cmbLista.SelectedItem

        If newlist Is Nothing Then
            Exit Sub
        End If

        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = ""

        For Each lst As ListaItem In _precontacto.ListaItems
            If lst.list.GetHashCode = newlist.GetHashCode Then
                MessageBox.Show("Este precontacto ya se agrego a esta lista")
            End If
        Next

        Dim repolst As PrecontactosListasRepository = New PrecontactosListasRepository(db)
        repolst.Add(_precontacto, newlist, Nothing, Nothing, "")

        Dim item As ListViewItem = New ListViewItem(Me.cmbLista.Text)
        item.Tag = newlist

        Me.lvListas.Items.Add(item)

        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = "Lista agregada correctamente"
    End Sub

    Private Sub KryptonButton2_Click(sender As System.Object, e As System.EventArgs) Handles KryptonButton2.Click
        If Me.lvListas.SelectedItems.Count = 0 Then
            Exit Sub
        End If

        Dim repo As PrecontactosListasRepository = New PrecontactosListasRepository(db)
        For Each it As ListViewItem In Me.lvListas.SelectedItems
            Dim removelist As lista = it.Tag

            Try
                repo.Remove(_precontacto, removelist)

                Me.lvListas.Items.Remove(it)
                Me.KryptonHeaderGroup1.ValuesSecondary.Heading = "Lista eliminada correctamente"
                RaiseEvent DeleteFromList(_precontacto, removelist)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Eventos Publicitarios", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        Next
    End Sub

    Private Sub KryptonButton3_Click(sender As System.Object, e As System.EventArgs) Handles KryptonButton3.Click
        Me.Close()
    End Sub
End Class
