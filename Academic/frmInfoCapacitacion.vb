Imports Academic.Business
Public Class frmInfoCapacitacion
    Private _cnnstr As String
    Private id As Decimal = 0
    Private action As Integer = 0
    Public Event CapacitacionAgregada(ByVal NuevaCapacitacion As Academic.Entities.Capacitacion)
    Public Event CapacitacionActualizada(ByVal UpCapacitacion As Academic.Entities.Capacitacion)

    Private Sub cmdAgregarModulo_Click(sender As System.Object, e As System.EventArgs) Handles cmdAgregarModulo.Click
        If (Me.txtNombreModulo.Text = String.Empty) Then
            Exit Sub
        End If

        Dim item As ListViewItem = New ListViewItem(Me.txtNombreModulo.Text)
        item.SubItems.Add(Me.txtDescripcionModulo.Text)

        Me.lvModulos.Items.Add(item)

        Me.txtNombreModulo.Text = ""
        Me.txtDescripcionModulo.Text = ""

        Me.txtNombreModulo.Focus()

    End Sub

    Private Sub cmdEliminarModulo_Click(sender As System.Object, e As System.EventArgs) Handles cmdEliminarModulo.Click
        If Me.lvModulos.SelectedItems.Count = 0 Then
            Exit Sub
        End If

        For Each it As ListViewItem In Me.lvModulos.SelectedItems
            Me.lvModulos.Items.Remove(it)
        Next
    End Sub

    Private Sub cmdSubirNivel_Click(sender As System.Object, e As System.EventArgs) Handles cmdSubirNivel.Click
        If Me.lvModulos.SelectedItems.Count = 0 Then
            Exit Sub
        End If

        If Me.lvModulos.SelectedItems(0).Index = 0 Then
            Exit Sub
        End If

        Dim index As Integer = Me.lvModulos.SelectedItems(0).Index - 1
        Dim movenombre As String = Me.lvModulos.Items(index).Text
        Dim movedescripcion As String = Me.lvModulos.Items(index).SubItems(1).Text

        Me.lvModulos.Items(index).Text = Me.lvModulos.SelectedItems(0).Text
        Me.lvModulos.Items(index).SubItems(1).Text = Me.lvModulos.SelectedItems(0).SubItems(1).Text

        Me.lvModulos.SelectedItems(0).Text = movenombre
        Me.lvModulos.SelectedItems(0).SubItems(1).Text = movedescripcion
        Me.lvModulos.SelectedItems(0).Selected = False
        Me.lvModulos.Items(index).Selected = True
        Me.lvModulos.Select()
    End Sub
    Private Sub cmdBajarNivel_Click(sender As System.Object, e As System.EventArgs) Handles cmdBajarNivel.Click
        If Me.lvModulos.SelectedItems.Count = 0 Then
            Exit Sub
        End If

        If Me.lvModulos.SelectedItems(0).Index = Me.lvModulos.Items.Count Then
            Exit Sub
        End If

        Dim index As Integer = Me.lvModulos.SelectedItems(0).Index + 1
        Dim movenombre As String = Me.lvModulos.Items(index).Text
        Dim movedescripcion As String = Me.lvModulos.Items(index).SubItems(1).Text

        Me.lvModulos.Items(index).Text = Me.lvModulos.SelectedItems(0).Text
        Me.lvModulos.Items(index).SubItems(1).Text = Me.lvModulos.SelectedItems(0).SubItems(1).Text

        Me.lvModulos.SelectedItems(0).Text = movenombre
        Me.lvModulos.SelectedItems(0).SubItems(1).Text = movedescripcion

        Me.lvModulos.SelectedItems(0).Selected = False
        Me.lvModulos.Items(index).Selected = True
        Me.lvModulos.Select()
    End Sub

    Private Sub cmdGuardarInfo_Click(sender As System.Object, e As System.EventArgs) Handles cmdGuardarInfo.Click
        Me.ErrorProvider1.Clear()

        If Me.txtNombre.Text = String.Empty Then
            Me.ErrorProvider1.SetError(Me.txtNombre, "Debe ingresar el nombre de la capacitacion")
            Exit Sub
        End If

        Dim c As Capacitacion2 = New Capacitacion2(_cnnstr)
        c.id = id
        c.Descripcion = Me.txtNombre.Text

        For Each it As ListViewItem In Me.lvModulos.Items
            Dim m As Academic.Entities.cm = New Academic.Entities.cm


            m.Nombre = it.Text
            m.Descripcion = it.SubItems(1).Text

            c.Modulos.Add(m)
        Next

        Try
            c.Update()
        Catch ex As Exception
            Me.KryptonHeaderGroup1.ValuesSecondary.Heading = "No se pudo guardar la capacitacion " + ex.Message
            Exit Sub
        End Try
        If action = 1 Then
            Me.KryptonHeaderGroup1.ValuesSecondary.Heading = "Capacitacion Agregada Correctamente"
            'RaiseEvent CapacitacionAgregada(c)
            RestartControls()
            Me.txtNombre.Focus()
        Else
            'RaiseEvent CapacitacionActualizada(c)
            Me.Close()
        End If
    End Sub
    Private Sub RestartControls()
        Me.txtNombre.Text = ""
        Me.txtNombreModulo.Text = ""
        Me.txtDescripcionModulo.Text = ""
        Me.lvModulos.Items.Clear()
    End Sub


    Public Sub New(CadenaConexion As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _cnnstr = CadenaConexion
        action = 1
    End Sub
    Public Sub New(CadenaConexion As String, Entidad As Academic.Entities.Capacitacion)
        ' This call is required by the designer.
        InitializeComponent()

        _cnnstr = CadenaConexion
        action = 2

        id = Entidad.Id
        Me.txtNombre.Text = Entidad.Descripcion

        For Each m As Academic.Entities.Modulo In Entidad.Modulos
            Dim item As ListViewItem = New ListViewItem(m.Nombre)
            item.SubItems.Add(m.Descripcion)

            Me.lvModulos.Items.Add(item)
        Next
    End Sub

    Private Sub txtNombre_GotFocus(sender As Object, e As System.EventArgs) Handles txtNombre.GotFocus
        Me.txtNombre.BackColor = System.Drawing.Color.FromArgb(201, 224, 250)
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = "Ingrese el nombre de la capacitacion"
    End Sub

    Private Sub txtNombre_LostFocus(sender As Object, e As System.EventArgs) Handles txtNombre.LostFocus
        Me.txtNombre.BackColor = Color.White
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = ""
    End Sub


    Private Sub txtNombre_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtNombre.TextChanged

    End Sub

    Private Sub KryptonButton6_Click(sender As System.Object, e As System.EventArgs) Handles KryptonButton6.Click
        Me.txtNombre.Text = ""
        Me.lvModulos.Items.Clear()
        Me.Hide()
    End Sub

    Private Sub txtNombreModulo_GotFocus(sender As Object, e As System.EventArgs) Handles txtNombreModulo.GotFocus
        Me.txtNombreModulo.BackColor = System.Drawing.Color.FromArgb(201, 224, 250)
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = "Ingrese el nombre del modulo"
    End Sub

    Private Sub txtNombreModulo_LostFocus(sender As Object, e As System.EventArgs) Handles txtNombreModulo.LostFocus
        Me.txtNombreModulo.BackColor = Color.White
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = ""
    End Sub

    Private Sub txtNombreModulo_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtNombreModulo.TextChanged

    End Sub

    Private Sub txtDescripcionModulo_GotFocus(sender As Object, e As System.EventArgs) Handles txtDescripcionModulo.GotFocus
        Me.txtDescripcionModulo.BackColor = System.Drawing.Color.FromArgb(201, 224, 250)
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = "Ingrese la descripcion del modulo"
    End Sub

    Private Sub txtDescripcionModulo_LostFocus(sender As Object, e As System.EventArgs) Handles txtDescripcionModulo.LostFocus
        Me.txtDescripcionModulo.BackColor = Color.White
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = ""
    End Sub


    Private Sub txtDescripcionModulo_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtDescripcionModulo.TextChanged

    End Sub
End Class