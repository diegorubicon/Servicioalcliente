Imports TrackingContacts.Data
Public Class frmAgregarPrecontacto
    Private _precontacto As Contacto

    Public Event AddPrecontact(precontact As Contacto)
    Public Event AddPrecontacToList(PrecontactList As ListaItem)
    Public Event UpdatePrecontact(precontact As Contacto)

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
        If Me.ckNoDioTelefono.Checked = False Then
            If Me.txtTelefono1.Text.Trim = "" And Me.txtTelefono2.Text.Trim = "" Then
                Me.ErrorProvider1.SetError(Me.txtTelefono1, "Ingrese un numero telefonico")
                HasError = True
            End If
        End If
        If Me.cmbOrigenes.SelectedItem Is Nothing Then
            Me.ErrorProvider1.SetError(Me.cmbOrigenes, "Seleccione el origen del precontacto")
            HasError = True
        End If
        If Me.cmbEstados.SelectedItem Is Nothing And Not (Me.cmbIntereses.SelectedItem Is Nothing) Then
            Me.ErrorProvider1.SetError(Me.cmbIntereses, "Seleccione la lista")
            HasError = True
        End If
        If Me.cmbIntereses.SelectedItem Is Nothing And Not (Me.cmbEstados.SelectedItem Is Nothing) Then
            Me.ErrorProvider1.SetError(Me.cmbIntereses, "Seleccione el interes")
            HasError = True
        End If
        If Me.txtProvincia.SelectedItem Is Nothing Then
            Me.ErrorProvider1.SetError(Me.txtProvincia, "Seleccione la provincia")
            HasError = True
        End If

        If HasError Then
            Me.KryptonHeaderGroup1.ValuesSecondary.Heading = "No se pudo guardar, verifique los datos ingresados"
            Me.cmdGuardar.Enabled = True
            Me.ProgressBar1.Visible = False
            Exit Sub
        End If

        Dim action As Integer = 0
        Me.cmdGuardar.Enabled = False
        Me.ProgressBar1.Visible = True
        Application.DoEvents()

        Dim _Precontactos As PrecontactosRepository = New PrecontactosRepository(db)

        If _precontacto Is Nothing Then
            'Verifica si el nombre y telefono ya se ingresaron
            _precontacto = _Precontactos.Item(Me.txtNombre.Text, Me.txtApellido01.Text, Me.txtTelefono1.Text)

            If Not _precontacto Is Nothing Then
                'El precontacto ya se habia creado anteriormente
                'se aunmenta el numero de llamadas para indicar que el cliente se contacto por segunda o mas veces
                _precontacto.NumLlamada = _precontacto.NumLlamada + 1

                db.DoneChanges()
                RaiseEvent UpdatePrecontact(_precontacto)
            Else
                'Crea el objeto del nuevo precontacto
                _precontacto = New Contacto
                With _precontacto
                    .nombre = Me.txtNombre.Text
                    .apellido_01 = Me.txtApellido01.Text
                    .apellido_02 = Me.txtApellido02.Text
                    .telefono_01 = Me.txtTelefono1.Text
                    .telefono_02 = Me.txtTelefono2.Text
                    .sintelefono = IIf(Me.ckNoDioTelefono.Checked, 1, 0)
                    .email = Me.txtEmail.Text
                    .provincia1 = Me.txtProvincia.SelectedItem
                    .lugar = Me.txtLugar.Text
                    .Origen1 = Me.cmbOrigenes.SelectedItem
                    .referido_por = Me.txtReferidoPor.Text
                    .NumLlamada = 1
                    .fecha = Me.dtFechaIngreso.Value
                    .creado_el = Now
                    .creado_por = Variables.usuario
                End With
                'Añade el objeto a la coleccion de precontactos
                _Precontactos.Add(_precontacto)

                If Not (Me.cmbIntereses.SelectedItem Is Nothing) And Not (Me.cmbEstados.SelectedItem Is Nothing) Then
                    'Agregar el precontacto al interes seleccionado
                    Dim PrecontactoEnLista As ListaItem = New ListaItem

                    Dim statusrepo As StatusRepository = New StatusRepository(db)

                    Dim st As InteresStatus = statusrepo.Item(0)
                    With PrecontactoEnLista
                        .list = Me.cmbEstados.SelectedItem
                        .InteresType = Me.cmbIntereses.SelectedItem
                        .InteresStatus = st
                        .interes_especifico = Me.txtInteresEspecifico.Text
                        .creado_el = Now
                        .creado_por = Variables.usuario
                    End With

                    _precontacto.ListaItems.Add(PrecontactoEnLista)
                End If

                db.DoneChanges()
                RaiseEvent AddPrecontact(_precontacto)
            End If
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
            Me.txtInteresEspecifico.Text = ""
            Me.ProgressBar1.Visible = False
            Me.txtProvincia.SelectedItem = Nothing
            Me.cmbOrigenes.SelectedItem = Nothing
            _precontacto = Nothing
            Me.txtNombre.Focus()

        Else
            action = 2
            With _precontacto

                .nombre = Me.txtNombre.Text
                .apellido_01 = Me.txtApellido01.Text
                .apellido_02 = Me.txtApellido02.Text
                .telefono_01 = Me.txtTelefono1.Text
                .telefono_02 = Me.txtTelefono2.Text
                .email = Me.txtEmail.Text
                .provincia1 = Me.txtProvincia.SelectedItem
                .lugar = Me.txtLugar.Text
            End With

            RaiseEvent UpdatePrecontact(_precontacto)
            Me.Close()
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

    Private Sub txtApellido02_GotFocus(sender As Object, e As System.EventArgs) Handles txtApellido02.GotFocus
        txtApellido02.BackColor = Color.FromArgb(222, 237, 250)
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = "Ingrese el segundo apellido del precontacto"
        Me.ErrorProvider1.Clear()
    End Sub

    Private Sub txtApellido02_LostFocus(sender As Object, e As System.EventArgs) Handles txtApellido02.LostFocus
        txtApellido02.BackColor = Color.White
    End Sub

    Private Sub txtTelefono1_GotFocus(sender As Object, e As System.EventArgs) Handles txtTelefono1.GotFocus
        txtTelefono1.BackColor = Color.FromArgb(222, 237, 250)
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = "Ingrese el telefono del precontacto"
        Me.ErrorProvider1.Clear()
    End Sub

    Private Sub txtTelefono1_LostFocus(sender As Object, e As System.EventArgs) Handles txtTelefono1.LostFocus
        txtTelefono1.BackColor = Color.White
    End Sub

    Private Sub txtTelefono1_TextChanged(sender As System.Object, e As System.EventArgs)

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

    Private Sub frm_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Me.cmbOrigenes.SelectedValue = Nothing
        Me.cmbEstados.SelectedValue = Nothing
        Me.cmbIntereses.SelectedValue = Nothing
    End Sub

    Private Sub txtInteresEspecifico_GotFocus(sender As Object, e As System.EventArgs) Handles txtInteresEspecifico.GotFocus
        Me.txtInteresEspecifico.BackColor = Color.FromArgb(222, 237, 250)
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = "Ingrese el interes especifico del pre-contacto"
        Me.ErrorProvider1.Clear()
    End Sub

    Private Sub txtInteresEspecifico_LostFocus(sender As Object, e As System.EventArgs) Handles txtInteresEspecifico.LostFocus
        Me.txtInteresEspecifico.BackColor = Color.White
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
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = "Seleccione la lista donde se asignara el pre-contacto para su seguimiento"
    End Sub

    Public Sub New(ByVal _precontact As Contacto, ByVal _SelectedList As lista)

        ' This call is required by the designer.
        InitializeComponent()

        Me.dtFechaIngreso.Value = Now.Date
        ' Add any initialization after the InitializeComponent() call.
        Dim _provincia As ProvinciasRepository = New ProvinciasRepository(db)
        For Each pro In _provincia.ToList
            Me.txtProvincia.Items.Add(pro)
        Next
        Me.txtProvincia.DisplayMember = "descripcion"
        Me.txtProvincia.ValueMember = "provincia"

        Dim _origenes As OrigenesRepository = New OrigenesRepository(db)
        For Each ori In _origenes.ToList
            Me.cmbOrigenes.Items.Add(ori)
        Next
        Me.cmbOrigenes.DisplayMember = "descripcion"
        Me.cmbOrigenes.ValueMember = "origen"

        Dim _listas As ListasRepository = New ListasRepository(db)

        For Each lst As lista In _listas.ToList
            Me.cmbEstados.Items.Add(lst)
        Next
        Me.cmbEstados.DisplayMember = "descripcion"

        If Not _precontact Is Nothing Then

            _precontacto = _precontact
            Me.txtNombre.Text = _precontact.nombre
            Me.txtApellido01.Text = _precontact.apellido_01
            Me.txtApellido02.Text = _precontact.apellido_02
            Me.txtTelefono1.Text = _precontact.telefono_01
            Me.txtTelefono2.Text = _precontact.telefono_02
            Me.txtEmail.Text = _precontact.email
            Me.txtLugar.Text = _precontact.lugar
            Me.txtProvincia.SelectedItem = _precontact.provincia1
            Me.cmbOrigenes.SelectedItem = _precontact.Origen1

            Me.cmbIntereses.SelectedItem = Nothing
            Me.cmbEstados.SelectedItem = Nothing

            Me.cmbIntereses.Enabled = False
            Me.cmbEstados.Enabled = False
            Me.dtFechaIngreso.Value = _precontact.creado_el
            Me.dtFechaIngreso.Enabled = False
        End If

        If Not _SelectedList Is Nothing Then
            Me.cmbEstados.SelectedItem = _SelectedList
        End If

    End Sub


    Private Sub cmbEstados_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbEstados.SelectedIndexChanged
        If Not cmbEstados.SelectedItem Is Nothing Then
            Me.cmbIntereses.Items.Clear()

            Dim lst As lista = Me.cmbEstados.SelectedItem
            For Each inte As InteresType In lst.InteresTypes
                Me.cmbIntereses.Items.Add(inte)
            Next
            Me.cmbIntereses.DisplayMember = "descripcion"
            Me.cmbIntereses.ValueMember = "interes"


        End If
    End Sub


    Private Sub KryptonHeaderGroup1_Panel_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles KryptonHeaderGroup1.Panel.Paint

    End Sub
End Class