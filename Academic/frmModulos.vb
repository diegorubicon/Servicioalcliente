Public Class frmModulos
    Private _cnnstr As String
    Private id As Decimal
    Private WithEvents frmBuscaVendedor As SalesForce.frmBuscaVendedor = Nothing
    Public Sub New(CadenaConexion As String, Capacitacion As Entities.Capacitacion)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _cnnstr = CadenaConexion

        id = Capacitacion.Id
       
        LoadInfo()
    End Sub
    Private Sub LoadInfo()
        Me.lvModulos.Items.Clear()
        Dim Capacitacion As Academic.Business.Capacitacion = New Academic.Business.Capacitacion(_cnnstr)

        If Capacitacion.Load(id) Then

            Me.txtNombreCapacitacion.Text = Capacitacion.Descripcion
            Me.cmbModulos.DataSource = Capacitacion.Modulos
            Me.cmbModulos.ValueMember = "id"
            Me.cmbModulos.DisplayMember = "nombre"

            For Each m As Academic.Entities.Modulo In Capacitacion.Modulos
                Dim group As ListViewGroup = New ListViewGroup(m.Nombre + " (" + m.Descripcion + ")")
                group.Tag = m
                For Each a As Academic.Entities.Asistente In m.Asistentes

                    Dim item As ListViewItem = New ListViewItem(a.Vendedor)
                    item.SubItems.Add(a.Nombre)
                    item.SubItems.Add(a.Fecha.ToShortDateString)
                    item.Tag = a
                    group.Items.Add(item)

                    Me.lvModulos.Items.Add(item)
                Next
                Me.lvModulos.Groups.Add(group)
            Next
        End If
    End Sub
    Private Sub cmdAgregarVendedor_Click(sender As System.Object, e As System.EventArgs) Handles cmdAgregarVendedor.Click

        If Me.txtVendedor.Text = "" Then
            MessageBox.Show("Debe ingresar el codigo del vendedor", "Servicioalcliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If (Me.cmbModulos.SelectedValue Is Nothing) Then
            MessageBox.Show("Debe seleccionar el modulo", "Servicioalcliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim cap As Academic.Business.Capacitacion = New Academic.Business.Capacitacion(_cnnstr)
        Try
            If cap.Load(id) Then
                cap.AddAsistente(Me.cmbModulos.SelectedItem, New Academic.Entities.Asistente With {.Vendedor = Me.txtVendedor.Text, .Fecha = Me.dtFecha.Value})
            End If
            'cap.Update()
        Catch sqlex As SqlClient.SqlException
            If sqlex.Number = 2627 Then
                MessageBox.Show("Este vendedor ya se ingreso a este modulo", "Servicioalcliente", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                MessageBox.Show(sqlex.Message, "Servicioalcliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Servicioalcliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        LoadInfo()

        Me.txtVendedor.Text = ""
        Me.txtNombreVendedor.Text = ""

        Me.txtVendedor.Focus()
    End Sub

    Private Sub txtVendedor_GotFocus(sender As Object, e As System.EventArgs) Handles txtVendedor.GotFocus
        Me.txtVendedor.BackColor = System.Drawing.Color.FromArgb(201, 224, 250)
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = "Ingrese el codigo del vendedor (F2 = Buscar Vendedor)"
    End Sub

    Private Sub txtVendedor_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtVendedor.KeyDown
        If e.KeyCode = Keys.F2 Then
            frmBuscaVendedor = New SalesForce.frmBuscaVendedor(_cnnstr)
            frmBuscaVendedor.Show()
        End If
    End Sub

    Private Sub txtVendedor_LostFocus(sender As Object, e As System.EventArgs) Handles txtVendedor.LostFocus
        Me.txtVendedor.BackColor = Color.White
        If Me.txtVendedor.Text = "" Then
            Exit Sub
        End If

        Dim vend As SalesForce.Business.Vendedor = New SalesForce.Business.Vendedor(_cnnstr)

        If vend.Load(Me.txtVendedor.Text) Then
            Me.txtNombreVendedor.Text = vend.NombreCompleto
        Else
            MessageBox.Show("Este codigo de vendedor no existe", My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.txtVendedor.Focus()
        End If


    End Sub
    Private Sub cmdBuscaVendedor_Click(sender As System.Object, e As System.EventArgs) Handles cmdBuscaVendedor.Click

        frmBuscaVendedor = New SalesForce.frmBuscaVendedor(_cnnstr)
        frmBuscaVendedor.Show()

    End Sub
    Private Sub frmBuscaVendedor_VendedorSeleccionado(Vendedor As SalesForce.Entities.Vendedor) Handles frmBuscaVendedor.VendedorSeleccionado
        If Vendedor Is Nothing Then
            Exit Sub
        End If

        Me.txtVendedor.Text = Vendedor.Id
        Me.txtNombreVendedor.Text = Vendedor.NombreCompleto
        Me.cmbModulos.Focus()

    End Sub

    Private Sub cmdEliminarAsistente_Click(sender As System.Object, e As System.EventArgs) Handles cmdEliminarAsistente.Click
        If Me.lvModulos.SelectedItems.Count = 0 Then
            MessageBox.Show("Debe seleccionar un vendedor de un modulo", "Servicioalcliente", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Dim cap As Academic.Business.Capacitacion = New Academic.Business.Capacitacion(_cnnstr)
        Try
            If cap.Load(id) Then
                cap.DeleteAsistente(Me.lvModulos.SelectedItems(0).Group.Tag, Me.lvModulos.SelectedItems(0).Tag)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Servicioalcliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
        LoadInfo()
    End Sub

    Private Sub txtVendedor_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtVendedor.TextChanged

    End Sub

    Private Sub cmbModulos_GotFocus(sender As Object, e As System.EventArgs) Handles cmbModulos.GotFocus
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = "Seleccione el modulo en que el vendedor participo"
    End Sub

    Private Sub cmbModulos_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbModulos.SelectedIndexChanged

    End Sub

    Private Sub dtFecha_ValueChanged(sender As System.Object, e As System.EventArgs) Handles dtFecha.ValueChanged
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = "Seleccione la fecha cuando el vendedor tomo el modulo"
    End Sub
End Class