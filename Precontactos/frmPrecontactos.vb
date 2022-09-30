Imports System.Threading
Imports TrackingContacts.Data

Public Class frmPrecontactos
    Private indicebusqueda As Integer
    Private _thread As Thread = Nothing
    Private vista As TypeOfVista
    Private Enum TypeOfVista
        Precontacts = 1
        oportunitys = 2
    End Enum

    Private PrecontactRef As Contacto
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        Dim listas As ListasRepository = New ListasRepository(db)

        For Each lst As lista In listas.ToList()
            cmbListas.Items.Add(lst)
        Next
        cmbListas.DisplayMember = "descripcion"
        cmbListas.ValueMember = "id_lista"

        vista = TypeOfVista.Precontacts
    End Sub

    Private Sub CargarLista(lst As lista)
        Dim ListaActual As Integer = CType(Me.cmbListas.SelectedValue, Integer)
        Try
            Me.lvPrecontactos.Items.Clear()
        Catch ex As Exception
            Exit Sub
        End Try

        For Each item As ListaItem In lst.ListaItems
            AddItemtoListView(item)
        Next

    End Sub

    Private Sub CargarOportunidades(lst As lista)
        Dim listaactual As Integer = CType(Me.cmbListas.SelectedValue, Integer)
        Try
            Me.lvOportunidades.Items.Clear()
        Catch ex As Exception
            Exit Sub
        End Try

        For Each item As ListaItem In lst.ListaItems.ToList
            If Not item.Oportunidad Is Nothing Then
                Dim lvitem As ListViewItem = New ListViewItem(item.id_precontacto)
                lvitem.Tag = item
                lvitem.SubItems.Add(item.Contacto.creado_el)
                lvitem.SubItems.Add(item.Contacto.Nombre + " " + item.Contacto.apellido_01 + " " + item.Contacto.apellido_02)
                lvitem.SubItems.Add(item.Contacto.telefono_01)
                lvitem.SubItems.Add(item.Contacto.telefono_02)
                lvitem.SubItems.Add(item.Contacto.provincia1.descripcion)
                lvitem.SubItems.Add(item.Oportunidad.Distribuidor1.nombre + " " + item.Oportunidad.Distribuidor1.apellido_01)
                lvitem.SubItems.Add(item.Oportunidad.estado.descripcion)

                If Not item.Oportunidad.cierre Is Nothing Then
                    If Not item.Oportunidad.cierre.estado Is Nothing Then
                        lvitem.SubItems.Add(item.Oportunidad.cierre.estado.descripcion)
                    Else
                        lvitem.SubItems.Add("")
                    End If
                Else
                    lvitem.SubItems.Add("")
                End If
                Me.lvOportunidades.Items.Add(lvitem)
            End If
        Next
    End Sub

    Private Sub KryptonRibbonGroupButton1_Click(sender As System.Object, e As System.EventArgs) Handles KryptonRibbonGroupButton1.Click


        _frmAgregarPreContacto = New frmAgregarPrecontacto(Nothing, Me.cmbListas.SelectedItem)
        _frmAgregarPreContacto.Show()
        
    End Sub
#Region "frmAgregarPrecontacto_Events"
    ''' <summary>
    ''' Controla el evento que se produce al ingresar los datos de un nuevo precontactco. 
    ''' Inicia un nuevo hilo, para guardar la informacion en la base de datos.
    ''' </summary>
    ''' <param name="precontact">Datos del nuevo precontacto ingresado </param>
    ''' <remarks></remarks>

    Private Sub _frmAgregarPreContacto_AddPrecontact(precontact As Contacto) Handles _frmAgregarPreContacto.AddPrecontact
        Dim tr As Thread = New Thread(AddressOf AddPrecontactToList)
        Try
            PrecontactRef = precontact
            tr.Start()
        Catch ex As Exception
            MessageBox.Show("Error iniciando el proceso de almacenamiento en BD " + ex.Message)
        End Try
    End Sub

    Private Sub frmAgregarPrecontacto_UpdatePrecontact(Updated As Contacto) Handles _frmAgregarPreContacto.UpdatePrecontact
        Dim tr As Thread = New Thread(AddressOf UpdatePrecontactInList)
        Try
            PrecontactRef = Updated
            tr.Start()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub AddPrecontactToList()
        GuardarCambios()
        If Not PrecontactRef Is Nothing Then
            If Not Me.cmbListas.SelectedItem Is Nothing Then
                Dim lst As lista = Me.cmbListas.SelectedItem

                For Each pl As ListaItem In PrecontactRef.ListaItems
                    If pl.id_lista = lst.id_lista Then
                        AddItemtoListView(pl)
                    End If
                Next
            End If
        End If
    End Sub
    Private Sub UpdatePrecontactInList()
        'Actualiza los cambios en la base de datos
        GuardarCambios()

        Dim lst As lista = Me.cmbListas.SelectedItem
        'Verifica que el precontacto se encuentra en la lista seleccionada
        For Each pl As ListaItem In PrecontactRef.ListaItems
            If pl.id_lista = lst.id_lista Then
                For Each it As ListViewItem In lvPrecontactos.Items
                    Dim pre As ListaItem = it.Tag
                    If pl.GetHashCode = pre.GetHashCode Then
                        it.SubItems(1).Text = PrecontactRef.creado_el
                        it.SubItems(2).Text = PrecontactRef.Nombre + " " + PrecontactRef.apellido_01 + " " + PrecontactRef.apellido_02
                        it.SubItems(3).Text = PrecontactRef.telefono_01
                        it.SubItems(4).Text = PrecontactRef.telefono_02
                        it.SubItems(5).Text = PrecontactRef.Email
                        it.SubItems(6).Text = PrecontactRef.provincia1.descripcion
                        it.SubItems(7).Text = PrecontactRef.lugar
                        it.SubItems(8).Text = PrecontactRef.Origen1.descripcion

                        If PrecontactRef.NumLlamada > 1 Then
                            it.ImageIndex = 0
                        End If
                    End If
                Next
            End If
        Next
    End Sub
#End Region
    Private Sub AddItemtoListView(ByRef lstItem As ListaItem)
        Dim item As ListViewItem = Nothing
        Try
            item = New ListViewItem(lstItem.Contacto.ID)
            item.Tag = lstItem
        Catch ex As Exception

        End Try

        item.Tag = lstItem
        item.SubItems.Add(lstItem.Contacto.creado_el.Value.ToShortDateString)
        item.SubItems.Add(lstItem.Contacto.Nombre + " " + lstItem.Contacto.apellido_01 + " " + lstItem.Contacto.apellido_02)
        item.SubItems.Add(lstItem.Contacto.telefono_01)
        item.SubItems.Add(lstItem.Contacto.telefono_02)
        item.SubItems.Add(lstItem.Contacto.Email)
        If Not lstItem.Contacto.provincia1 Is Nothing Then
            item.SubItems.Add(lstItem.Contacto.provincia1.descripcion)
        Else
            item.SubItems.Add("")
        End If
        item.SubItems.Add(lstItem.Contacto.lugar)
        If Not lstItem.Contacto.Origen1 Is Nothing Then
            item.SubItems.Add(lstItem.Contacto.Origen1.descripcion)
        End If
        If Not lstItem.InteresType Is Nothing Then
            item.SubItems.Add(lstItem.InteresType.descripcion)
        End If
        If Not lstItem.InteresStatus Is Nothing Then
            item.SubItems.Add(lstItem.InteresStatus.descripcion)
        End If

        If lstItem.Contacto.NumLlamada > 1 Then
            item.ImageIndex = 0
        End If
        Dim FindGroup As Boolean = False
        For Each gr As ListViewGroup In Me.lvPrecontactos.Groups
            If gr.Header = lstItem.Contacto.referido_por Then
                FindGroup = True
                gr.Items.Add(item)
            End If
        Next
        If Not FindGroup Then
            Dim gr As ListViewGroup = New ListViewGroup(lstItem.Contacto.referido_por)

            gr.Items.Add(item)
            Me.lvPrecontactos.Groups.Add(gr)
        End If
        Me.lvPrecontactos.Items.Add(item)

    End Sub

    Private Sub KryptonRibbonGroupButton2_Click(sender As System.Object, e As System.EventArgs) Handles KryptonRibbonGroupButton2.Click
        'Editar un precontacto
        If vista = TypeOfVista.Precontacts Then
            If Me.lvPrecontactos.SelectedItems.Count = 0 Then
                MessageBox.Show("Debe seleccionar un pre-contacto", "Seguimientos Publicitarios", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Dim pre As ListaItem = Me.lvPrecontactos.SelectedItems(0).Tag

            _frmAgregarPreContacto = New frmAgregarPrecontacto(pre.Contacto, Nothing)
            _frmAgregarPreContacto.Show()
        Else
            If Me.lvOportunidades.SelectedItems.Count = 0 Then
                MessageBox.Show("Debe seleccionar un pre-contacto", "Seguimientos Publicitarios", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Dim pre As ListaItem = Me.lvOportunidades.SelectedItems(0).Tag
            _frmAgregarPreContacto = New frmAgregarPrecontacto(pre.Contacto, Nothing)
            _frmAgregarPreContacto.Show()
        End If
    End Sub

    Private Sub KryptonRibbonGroupButton6_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        If Me.lvPrecontactos.SelectedItems.Count = 0 Then
            tsslInformacion.Text = "Seleccione un pre-contacto"
            Exit Sub
        End If

        Dim pre As ListaItem = Me.lvPrecontactos.SelectedItems(0).Tag

        If Not pre.Oportunidad Is Nothing Then
            MessageBox.Show("Ya se creo una oportunidad de venta para este precontacto", "Eventos Publicitarios", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        _frmCrearOportunidad = New frmCrearOportunidad(pre, frmCrearOportunidad.Actions.MakeNew)
        _frmCrearOportunidad.Show()
    End Sub

    'Evento que se dispara cuando la ventana de crear oportunidades, crea una nueva oportunidad, y actuliza el estado
    'del objeto precontactolista
    Private Sub UpdateStatusOportunity(ByRef p As ListaItem) Handles _frmCrearOportunidad.UpdateStatus

    End Sub
    Private Sub KryptonRibbonGroupButton11_Click(sender As System.Object, e As System.EventArgs) Handles KryptonRibbonGroupButton11.Click
        ChangeView(TypeOfVista.Precontacts)
        Application.DoEvents()
    End Sub

    Private Sub KryptonRibbonGroupButton12_Click(sender As System.Object, e As System.EventArgs) Handles KryptonRibbonGroupButton12.Click
        ChangeView(TypeOfVista.oportunitys)
        Application.DoEvents()
    End Sub
    Private WithEvents _frmAgregarPreContacto As frmAgregarPrecontacto = Nothing
    Private WithEvents _frmObservacines As frmObservaciones = Nothing
    Private WithEvents _frmCrearOportunidad As frmCrearOportunidad = Nothing
    Private WithEvents _FrmCambiarLista As frmCambiarLista = Nothing
    Private WithEvents _FrmAgregarCierre As frmCerrarOportunidad = Nothing
    Private WithEvents _frmCrearLista As frmCrearLista = Nothing

    Private Sub KryptonRibbonGroupButton13_Click(sender As System.Object, e As System.EventArgs) Handles KryptonRibbonGroupButton13.Click
        If vista <> TypeOfVista.oportunitys Then
            Exit Sub
        End If

        If Me.lvOportunidades.SelectedItems.Count = 0 Then
            Exit Sub
        End If

        If Me.cmbListas.SelectedItem Is Nothing Then
            Exit Sub
        End If

        Dim _pre As ListaItem = Me.lvOportunidades.SelectedItems(0).Tag

        _FrmAgregarCierre = New frmCerrarOportunidad(_pre)
        _FrmAgregarCierre.Show()

    End Sub

    Private Sub AddCierreFinished(ByRef pre As ListaItem) Handles _FrmAgregarCierre.AddCierreFinished
        If CType(Me.cmbListas.SelectedValue, Integer) <> pre.id_lista Then
            Exit Sub
        End If
        For Each it As ListViewItem In lvOportunidades.Items
            If CType(it.Text, Integer) = pre.id_precontacto Then
                it.SubItems(6).Text = "CERRADO"
                it.SubItems(7).Text = pre.Oportunidad.cierre.estado.descripcion
            End If
        Next
    End Sub

    Private Sub KryptonRibbonGroupButton8_Click(sender As System.Object, e As System.EventArgs) Handles KryptonRibbonGroupButton8.Click
        If vista = TypeOfVista.oportunitys Then
            If Me.cmbListas.SelectedItem Is Nothing Then
                Exit Sub
            End If
            If Me.lvOportunidades.SelectedItems.Count = 0 Then
                Exit Sub
            End If

            Dim preinlist As ListaItem = Me.lvOportunidades.SelectedItems(0).Tag
            Dim repo As OportunidadesRepository = New OportunidadesRepository(db)

            repo.Remove(preinlist.Oportunidad)

            Me.lvOportunidades.Items.Remove(Me.lvOportunidades.SelectedItems(0))


        End If
    End Sub

    Private Sub KryptonRibbonGroupButton7_Click(sender As System.Object, e As System.EventArgs) Handles KryptonRibbonGroupButton7.Click

        If vista = TypeOfVista.oportunitys Then
            If Me.lvOportunidades.SelectedItems.Count = 0 Then
                tsslInformacion.Text = "Seleccione una oportunidad"
                Exit Sub
            End If
            Dim pre As ListaItem = Me.lvOportunidades.SelectedItems(0).Tag

            _frmCrearOportunidad = New frmCrearOportunidad(pre, frmCrearOportunidad.Actions.Update)
            _frmCrearOportunidad.Show()
        Else
            If Me.lvPrecontactos.SelectedItems.Count = 0 Then
                Me.tsslInformacion.Text = "Debe seleccionar un contacto que tenga creada una oportunidad de venta"
                Application.DoEvents()
                Exit Sub
            End If

            Dim pre As ListaItem = Me.lvPrecontactos.SelectedItems(0).Tag

            If pre.Oportunidad Is Nothing Then
                Me.tsslInformacion.Text = "Este precontacto no se ha convertido en oportunidad"
                Application.DoEvents()
            End If

            _frmCrearOportunidad = New frmCrearOportunidad(pre, frmCrearOportunidad.Actions.Update)
            _frmCrearOportunidad.Show()
        End If
    End Sub

    Private Sub _frmCrearLista_AddList(newlst As lista) Handles _frmCrearLista.InsertedList
        Me.cmbListas.Items.Add(newlst)
        Me.cmbListas.Refresh()
    End Sub

    Private Sub KryptonButton1_Click(sender As System.Object, e As System.EventArgs) Handles KryptonButton1.Click
        If Not cmbListas.SelectedItem Is Nothing Then
            If vista = TypeOfVista.Precontacts Then
                CargarLista(cmbListas.SelectedItem)
            Else
                CargarOportunidades(cmbListas.SelectedItem)
            End If
        End If
    End Sub
    Private Sub KryptonRibbonGroupButton9_Click(sender As System.Object, e As System.EventArgs) Handles KryptonRibbonGroupButton9.Click
        If Not _thread Is Nothing Then
            If _thread.ThreadState = ThreadState.Running Then
                Exit Sub
            End If
        End If
        _thread = New Thread(AddressOf GuardarCambios)
        _thread.Start()
    End Sub
    Private Sub GuardarCambios()
        Try
            db.DoneChanges()
            Me.tsslInformacion.Text = "Informacion almacenada en BD correctamente"
        Catch ex As Exception
            Me.tsslInformacion.Text = "No se pudo guardar la informacion " + ex.Message
        End Try

    End Sub



    Private Sub KryptonRibbonGroupButton4_Click_1(sender As System.Object, e As System.EventArgs) Handles KryptonRibbonGroupButton4.Click
        If vista = TypeOfVista.Precontacts Then
            If Me.cmbListas.SelectedItem Is Nothing Then
                Exit Sub
            End If

            If Me.lvPrecontactos.SelectedItems.Count > 0 Then

                Dim PrecontactoSeleccionado As ListaItem = Me.lvPrecontactos.SelectedItems(0).Tag

                _frmObservacines = New frmObservaciones(PrecontactoSeleccionado)
                _frmObservacines.ShowDialog()
            End If
        Else
            If Me.cmbListas.SelectedItem Is Nothing Then
                Exit Sub
            End If
            If Me.lvOportunidades.SelectedItems.Count > 0 Then
                Dim PrecontactoSeleccionado As ListaItem = Me.lvOportunidades.SelectedItems(0).Tag

                _frmObservacines = New frmObservaciones(PrecontactoSeleccionado)
                _frmObservacines.ShowDialog()
            End If
        End If
    End Sub
    Private Sub _frmObservaciones_InsertNote(mi As ListaItem) Handles _frmObservacines.InsertNote
        If vista = TypeOfVista.Precontacts Then
            For Each item As ListViewItem In lvPrecontactos.Items
                Dim pre As ListaItem = item.Tag

                If pre.GetHashCode = mi.GetHashCode Then
                    item.SubItems(8).Text = mi.InteresType.descripcion
                    item.SubItems(9).Text = mi.InteresStatus.descripcion
                End If
            Next
        Else
        End If
    End Sub

    Private Sub KryptonRibbonGroupButton5_Click_1(sender As System.Object, e As System.EventArgs) Handles KryptonRibbonGroupButton5.Click
        If vista = TypeOfVista.Precontacts Then
            If Me.lvPrecontactos.SelectedItems.Count = 0 Then Exit Sub
            Dim id_precontacto As ListaItem = Me.lvPrecontactos.SelectedItems(0).Tag
            If id_precontacto Is Nothing Then Exit Sub
            _FrmCambiarLista = New frmCambiarLista(id_precontacto.Contacto)
            _FrmCambiarLista.Show()
        Else
            If Me.lvOportunidades.SelectedItems.Count = 0 Then Exit Sub

            Dim id_precontacto As ListaItem = Me.lvOportunidades.SelectedItems(0).Tag

            If id_precontacto Is Nothing Then Exit Sub

            _FrmCambiarLista = New frmCambiarLista(id_precontacto.Contacto)
            _FrmCambiarLista.Show()
        End If
    End Sub
    Private Sub _frmCambiarLista_DeleteFromList(precontacto As Contacto, list As lista) Handles _FrmCambiarLista.DeleteFromList

        Dim lista As lista = Me.cmbListas.SelectedItem

        If lista Is Nothing Then
            Exit Sub
        End If

        If lista.GetHashCode = list.GetHashCode Then
            For Each it As ListViewItem In lvOportunidades.Items

                Dim preinlst As ListaItem = it.Tag

                If preinlst.Contacto.GetHashCode = precontacto.GetHashCode Then
                    Me.lvOportunidades.Items.Remove(it)
                End If
            Next
        End If

        Dim lista2 As lista = Me.cmbListas.SelectedItem

        If Not lista2 Is Nothing Then
            If lista2.GetHashCode = list.GetHashCode Then

                For Each it As ListViewItem In Me.lvPrecontactos.Items

                    Dim preinlst As ListaItem = it.Tag

                    If preinlst.Contacto Is Nothing Then
                        Me.lvPrecontactos.Items.Remove(it)
                    End If
                Next
            End If
        End If
    End Sub


    Private Sub frmPrecontactos_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If db.HasChanges Then
            Select Case MessageBox.Show("Tiene Cambios pendientes de actualizar en la base de datos, desea aplicarlos antes de salir?", "Eventos", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information)
                Case Windows.Forms.DialogResult.Yes
                    Try
                        db.DoneChanges()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                        e.Cancel = True
                    End Try

                Case Windows.Forms.DialogResult.Cancel
                    e.Cancel = True
            End Select
        End If
    End Sub

    Private Function BuscarEnPrecontactos(nombre As String, indice As Integer)
        Dim findindex As Integer = 0
        If indice > 0 Then
            indice = indice + 1
        End If
        For i = indice To Me.lvPrecontactos.Items.Count - 1

            Dim item As ListaItem = Me.lvPrecontactos.Items(i).Tag

            If Not item Is Nothing Then
                Dim NombrePre As String
                nombre = nombre.Replace(" ", "")

                NombrePre = item.Contacto.Nombre + item.Contacto.apellido_01 + item.Contacto.apellido_02

                NombrePre = NombrePre.Replace(" ", "")

                If NombrePre.ToUpper.Contains(nombre.ToUpper) Then
                    findindex = i
                    Exit For
                End If
            End If
        Next
        Return findindex
    End Function

    Private Sub cmdCerrarBusqueda_Click(sender As System.Object, e As System.EventArgs)


    End Sub


    Private Sub KryptonRibbonGroupButton6_Click_1(sender As System.Object, e As System.EventArgs) Handles KryptonRibbonGroupButton6.Click
        If vista = TypeOfVista.oportunitys Then

        Else
            frmBusquedaenPrecontacto.Visible = True
            Me.txtBusquedaPrecontacto.Focus()
        End If
    End Sub

    Private Sub KryptonRibbonGroupButton10_Click(sender As System.Object, e As System.EventArgs) Handles KryptonRibbonGroupButton10.Click
        If vista = TypeOfVista.oportunitys Then
            MessageBox.Show("Debe seleccionar la vista de precontactos", "Eventos Publicitarios", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim PrecontactoOfLista As ListaItem = Me.lvPrecontactos.SelectedItems(0).Tag

        PrecontactoOfLista.Contacto.NumLlamada = PrecontactoOfLista.Contacto.NumLlamada + 1

        Dim tr As Thread = New Thread(AddressOf UpdatePrecontactInList)
        Try
            PrecontactRef = PrecontactoOfLista.Contacto
            tr.Start()
        Catch ex As Exception
            MessageBox.Show("No se pudo iniciar el proceso de almancenamiento", "Eventos Publicitarios", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
    End Sub

    Private Sub KryptonRibbonGroupButton14_Click(sender As System.Object, e As System.EventArgs) Handles KryptonRibbonGroupButton14.Click
        Dim f As frmEnvioMensajes = New frmEnvioMensajes

        f.Show()


    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs)
        Me.lvPrecontactos.ShowGroups = Not Me.lvPrecontactos.ShowGroups
    End Sub

    Private Sub KryptonRibbonGroupButton15_Click(sender As System.Object, e As System.EventArgs) Handles KryptonRibbonGroupButton15.Click
        Dim f As frmImportarExcel = New frmImportarExcel

        f.Show()
    End Sub
    Private Sub ChangeView(view As TypeOfVista)
        vista = view
        If view = TypeOfVista.Precontacts Then
            Me.lbTitulo.Text = "Lista de Pre-Contactos"
            Me.lvPrecontactos.Visible = True
            Me.lvOportunidades.Visible = False

            If Not Me.cmbListas.SelectedItem Is Nothing Then
                CargarLista(Me.cmbListas.SelectedItem)
            End If
        Else
            Me.lbTitulo.Text = "Lista de Seguimiento"
            Me.lvPrecontactos.Visible = False
            Me.lvOportunidades.Visible = True
            If Not Me.cmbListas.SelectedItem Is Nothing Then
                CargarOportunidades(Me.cmbListas.SelectedItem)
            End If
        End If
    End Sub

    Private Sub cmdBuscar_Click_1(sender As System.Object, e As System.EventArgs) Handles cmdBuscar.Click
        If Me.txtBusquedaPrecontacto.Text = "" Then
            MessageBox.Show("Debe de ingresar un criterio de busqueda", "Eventos Publicitarios", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Dim i As Integer

        For i = 0 To Me.lvPrecontactos.Items.Count - 1
            Me.lvPrecontactos.Items(i).Selected = False
        Next

        indicebusqueda = BuscarEnPrecontactos(Me.txtBusquedaPrecontacto.Text, indicebusqueda)
        If indicebusqueda = 0 Then
            MessageBox.Show("Finalizo la busqueda", "Eventos Publicitarios", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Me.lvPrecontactos.Items(indicebusqueda).Selected = True
            Me.lvPrecontactos.Items(indicebusqueda).EnsureVisible()
            Me.lvPrecontactos.Focus()
        End If

    End Sub

    Private Sub cmdCerrarBusqueda_Click_1(sender As System.Object, e As System.EventArgs) Handles cmdCerrarBusqueda.Click
        indicebusqueda = 0
        Me.frmBusquedaenPrecontacto.Visible = False
    End Sub

    Private Sub txtBusquedaPrecontacto_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtBusquedaPrecontacto.TextChanged
        indicebusqueda = 0
    End Sub

    Private Sub KryptonPanel1_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles KryptonPanel1.Paint

    End Sub

    Private Sub frmPrecontactos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
