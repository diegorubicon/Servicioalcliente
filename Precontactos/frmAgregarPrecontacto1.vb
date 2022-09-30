Public Class frmAgregarPrecontacto1

    Private Sub frm_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        Me.txtNombre.Focus()
    End Sub

    Private Sub frm_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
        If e.KeyCode = Keys.F5 Then
            cmdGuardar_Click(Me, Nothing)
        End If
        If e.KeyCode = Keys.F3 Then
            KryptonButton2_Click(Me, Nothing)
        End If
    End Sub

    Private Sub cmdGuardar_Click(sender As System.Object, e As System.EventArgs) Handles cmdGuardar.Click
        Dim HasError As Boolean = False

        If Me.txtNombre.Text.Trim = "" Then
            Me.ErrorProvider1.SetError(Me.txtNombre, "Ingrese el nombre")
            HasError = True
        End If
        If Me.txtTelefono1.Text.Trim = "" And Me.txtTelefono2.Text.Trim = "" Then
            Me.ErrorProvider1.SetError(Me.txtTelefono1, "Ingrese un numero telefonico")
            HasError = True
        End If
        If Me.cmbOrigenes.SelectedValue Is Nothing Then
            Me.ErrorProvider1.SetError(Me.cmbOrigenes, "Seleccione el origen del precontacto")
            HasError = True
        End If
        If Me.cmbEstados.SelectedValue Is Nothing And Not (Me.cmbIntereses.SelectedValue Is Nothing) Then
            Me.ErrorProvider1.SetError(Me.cmbIntereses, "Seleccione el estado")
            HasError = True
        End If
        If Me.cmbIntereses.SelectedValue Is Nothing And Not (Me.cmbEstados.SelectedValue Is Nothing) Then
            Me.ErrorProvider1.SetError(Me.cmbIntereses, "Seleccione el interes")
            HasError = True
        End If

        If Not HasError Then
            Dim _origenes As Origenes
            Dim _origen As Origen

            Me.cmdGuardar.Enabled = False
            Me.ProgressBar1.Visible = True
            Application.DoEvents()


            _origenes = New Origenes(Variables.ConnectionString)

            _origen = _origenes.GetByID(CType(Me.cmbOrigenes.SelectedValue, Integer))

            If Not (_origen Is Nothing) Then
                Dim pre As PreContact = New PreContact
                With pre
                    .nombre = Me.txtNombre.Text
                    .apellido_01 = Me.txtApellido01.Text
                    .apellido_02 = Me.txtApellido02.Text
                    .telefono_01 = Me.txtTelefono1.Text
                    .telefono_02 = Me.txtTelefono2.Text
                    .email = Me.txtEmail.Text
                    .lugar = Me.txtLugar.Text
                End With

                If Not (Me.cmbIntereses.SelectedValue Is Nothing) And Not (Me.cmbEstados.SelectedValue Is Nothing) Then
                    Dim _interes As PrecontactoLista = New PrecontactoLista

                    With _interes
                        .lista = Me.cmbEstados.SelectedValue
                        .interes = Me.cmbIntereses.SelectedValue
                        .estado = 0
                        .interes_especifico = ""
                    End With

                    pre.PrecontactoListas.Add(_interes)

                End If

                _origen.PreContacts.Add(pre)

                Try
                    _origenes.Submmit()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Pre-Contactos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.cmdGuardar.Enabled = True
                    Me.ProgressBar1.Visible = False
                    Exit Sub
                End Try
                Me.KryptonHeaderGroup1.ValuesSecondary.Heading = "Pre-contacto guardado correctamente"
                Threading.Thread.Sleep(1000)
                Me.txtNombre.Text = ""
                Me.txtApellido01.Text = ""
                Me.txtApellido02.Text = ""
                Me.txtTelefono1.Text = ""
                Me.txtTelefono2.Text = ""
                Me.txtEmail.Text = ""
                Me.txtLugar.Text = ""
                Me.cmdGuardar.Enabled = True
                Me.ProgressBar1.Visible = False
                Me.txtNombre.Focus()
            Else
                Me.KryptonHeaderGroup1.ValuesSecondary.Heading = "No se pudo guardar, verifique los datos ingresados"
                Me.cmdGuardar.Enabled = True
                Me.ProgressBar1.Visible = False
            End If
        Else
            Me.KryptonHeaderGroup1.ValuesSecondary.Heading = "No se pudo guardar, verifique los datos ingresados"
            Me.cmdGuardar.Enabled = True
            Me.ProgressBar1.Visible = False
        End If
    End Sub

    Private Sub txtNombre_GotFocus(sender As Object, e As System.EventArgs) Handles txtNombre.GotFocus
        txtNombre.BackColor = Color.FromArgb(222, 237, 250)
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = "Ingrese el nombre del precontacto"
        Me.ErrorProvider1.Clear()
    End Sub


    Private Sub txtNombre_LostFocus(sender As Object, e As System.EventArgs) Handles txtNombre.LostFocus
        txtNombre.BackColor = Color.White
    End Sub

    Private Sub txtApellido01_GotFocus(sender As Object, e As System.EventArgs) Handles txtApellido01.GotFocus
        txtApellido01.BackColor = Color.FromArgb(222, 237, 250)
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = "Ingrese el Primer Apellido del precontacto"
        Me.ErrorProvider1.Clear()
    End Sub

    Private Sub txtApellido01_LostFocus(sender As Object, e As System.EventArgs) Handles txtApellido01.LostFocus
        txtApellido01.BackColor = Color.White
    End Sub

    Private Sub txtApellido01_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtApellido01.TextChanged

    End Sub

    Private Sub txtApellido02_GotFocus(sender As Object, e As System.EventArgs) Handles txtApellido02.GotFocus
        txtApellido02.BackColor = Color.FromArgb(222, 237, 250)
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = "Ingrese el segundo apellido del precontacto"
        Me.ErrorProvider1.Clear()
    End Sub

    Private Sub txtApellido02_LostFocus(sender As Object, e As System.EventArgs) Handles txtApellido02.LostFocus
        txtApellido02.BackColor = Color.White
    End Sub

    Private Sub txtApellido02_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtApellido02.TextChanged

    End Sub

    Private Sub txtTelefono1_GotFocus(sender As Object, e As System.EventArgs) Handles txtTelefono1.GotFocus
        txtTelefono1.BackColor = Color.FromArgb(222, 237, 250)
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = "Ingrese el telefono del precontacto"
        Me.ErrorProvider1.Clear()
    End Sub

    Private Sub txtTelefono1_LostFocus(sender As Object, e As System.EventArgs) Handles txtTelefono1.LostFocus
        txtTelefono1.BackColor = Color.White
    End Sub

    Private Sub txtTelefono1_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtTelefono1.TextChanged

    End Sub

    Private Sub txtTelefono2_GotFocus(sender As Object, e As System.EventArgs) Handles txtTelefono2.GotFocus
        txtTelefono2.BackColor = Color.FromArgb(222, 237, 250)
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = "Ingrese el telefono del precontacto"
        Me.ErrorProvider1.Clear()
    End Sub

    Private Sub txtTelefono2_LostFocus(sender As Object, e As System.EventArgs) Handles txtTelefono2.LostFocus
        txtTelefono2.BackColor = Color.White
    End Sub

    Private Sub txtEmail_GotFocus(sender As Object, e As System.EventArgs) Handles txtEmail.GotFocus
        txtEmail.BackColor = Color.FromArgb(222, 237, 250)
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = "Ingrese el correo electronico"
        Me.ErrorProvider1.Clear()
    End Sub

    Private Sub txtEmail_LostFocus(sender As Object, e As System.EventArgs) Handles txtEmail.LostFocus
        txtEmail.BackColor = Color.White
    End Sub
    Private Sub txtProvincia_GotFocus(sender As Object, e As System.EventArgs) Handles txtProvincia.GotFocus
        txtProvincia.BackColor = Color.FromArgb(222, 237, 250)
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = "Ingrese el telefono del precontacto"
        Me.ErrorProvider1.Clear()
    End Sub

    Private Sub txtProvincia_LostFocus(sender As Object, e As System.EventArgs) Handles txtProvincia.LostFocus
        txtProvincia.BackColor = Color.White
    End Sub

    Private Sub txtProvincia_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles txtProvincia.SelectedIndexChanged

    End Sub

    Private Sub frm_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Me.cmbOrigenes.SelectedValue = Nothing
        Me.cmbEstados.SelectedValue = Nothing
        Me.cmbIntereses.SelectedValue = Nothing
    End Sub

    Private Sub txtNombre_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtNombre.TextChanged

    End Sub

    Private Sub txtInteresEspecifico_GotFocus(sender As Object, e As System.EventArgs) Handles txtInteresEspecifico.GotFocus
        Me.txtInteresEspecifico.BackColor = Color.FromArgb(222, 237, 250)
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = "Ingrese el interes especifico del pre-contacto"
        Me.ErrorProvider1.Clear()
    End Sub

    Private Sub txtInteresEspecifico_LostFocus(sender As Object, e As System.EventArgs) Handles txtInteresEspecifico.LostFocus
        Me.txtInteresEspecifico.BackColor = Color.White
    End Sub

    Private Sub txtInteresEspecifico_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtInteresEspecifico.TextChanged

    End Sub

    Private Sub KryptonButton2_Click(sender As System.Object, e As System.EventArgs) Handles KryptonButton2.Click
        Me.txtNombre.Text = ""
        Me.txtApellido01.Text = ""
        Me.txtApellido02.Text = ""
        Me.txtTelefono1.Text = ""
        Me.txtTelefono2.Text = ""
        Me.txtEmail.Text = ""
        Me.txtLugar.Text = ""
        Me.txtNombre.Focus()
    End Sub

    Private Sub KryptonButton3_Click(sender As System.Object, e As System.EventArgs) Handles KryptonButton3.Click
        Me.Close()
    End Sub

    Private Sub cmbEstados_GotFocus(sender As Object, e As System.EventArgs) Handles cmbEstados.GotFocus

    End Sub

    Private Sub cmbEstados_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbEstados.SelectedIndexChanged
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = "Seleccione la lista donde se asignara el pre-contacto para su seguimiento"
    End Sub
End Class
