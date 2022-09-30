

Imports System.Threading
Public Class frmEnvioMensajes
    Dim trd As Thread = Nothing
    Private Sub KryptonButton1_Click(sender As System.Object, e As System.EventArgs) Handles KryptonButton1.Click
        If Not trd Is Nothing Then
            If trd.ThreadState = ThreadState.Running Then Exit Sub
        End If

        trd = New Thread(AddressOf StartSearch)
        trd.Start()

    End Sub
    Private Sub StartSearch()
        Try
            Me.lvPrecontactos.Items.Clear()
        Catch ex As Exception

        End Try

        Dim lista As lista = Me.cmbLista.SelectedValue

        If Not lista Is Nothing Then
            Dim p As List(Of ListaItem)

            If Me.ckProvincia.Checked = True And Me.txtUbicacion.Text = "" Then
                p = lista.ListaItems.ToList()
            Else
                p = lista.Filter(Me.cmbProvincia.SelectedValue, Me.txtUbicacion.Text)
            End If
            If Not p Is Nothing Then
                For Each pre As ListaItem In p

                    Dim item As ListViewItem = New ListViewItem(pre.Contacto.ID)
                    item.SubItems.Add(pre.Contacto.NombreCompleto)
                    item.SubItems.Add(pre.Contacto.telefono_01)
                    item.SubItems.Add(pre.Contacto.telefono_02)
                    item.SubItems.Add(pre.Contacto.Email)

                    Me.lvPrecontactos.Items.Add(item)

                Next
            End If
        End If
    End Sub

    Private Sub frmEnvioMensajes_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Dim listas As ListasRepository = New ListasRepository(db)

        cmbLista.DataSource = listas.ToList
        cmbLista.DisplayMember = "descripcion"
        cmbLista.ValueMember = "id_lista"


        Dim _provincia As ProvinciasRepository = New ProvinciasRepository(db)
        
        Me.cmbProvincia.DataSource = _provincia.ToList
        Me.cmbProvincia.DisplayMember = "descripcion"
        Me.cmbProvincia.ValueMember = "id_provincia"

    End Sub

    Private Sub cmdEnviarSMS_Click(sender As System.Object, e As System.EventArgs) Handles cmdEnviarSMS.Click
        Dim frm As frmMensajeSMS = New frmMensajeSMS

        frm.ShowDialog()

        If frm.withinfo Then
            Dim sms As EnvioSMS.Business.SMS = New EnvioSMS.Business.SMS(frm.mensaje, frm.horaenvio, frm.fechaenvio)
            For Each item As ListViewItem In Me.lvPrecontactos.Items
                If item.Checked Then
                    sms.AgregarDestinatario(item.SubItems(1).Text, item.SubItems(2).Text)
                End If
            Next

            Dim phone As EnvioSMS.Business.PhoneVirtual = New EnvioSMS.Business.PhoneVirtual(Variables.ConnectionString)
            phone.SendSMSandSave(sms)

        End If
        frm.Dispose()
    End Sub

    Private Sub KryptonButton2_Click(sender As System.Object, e As System.EventArgs) Handles KryptonButton2.Click
        Me.Close()
    End Sub

    Private Sub KryptonButton3_Click(sender As System.Object, e As System.EventArgs) Handles KryptonButton3.Click
        Dim maillist As String = ""
        For Each item As ListViewItem In Me.lvPrecontactos.Items
            If item.Checked Then
                maillist += item.SubItems(4).Text + ";"
            End If
        Next

        Clipboard.SetText(maillist)

        MessageBox.Show("Correos Electronicos copiados correctamente al Portapapeles", "Eventos", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub KryptonButton4_Click(sender As System.Object, e As System.EventArgs) Handles KryptonButton4.Click
        For Each it As ListViewItem In Me.lvPrecontactos.Items
            it.Checked = Not it.Checked
        Next
    End Sub
End Class