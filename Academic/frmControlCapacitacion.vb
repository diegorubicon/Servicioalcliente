Imports System.Threading
Imports Academic.Business
Public Class frmControlCapacitacion

    Private _cnnstr As String = ""
    Private WithEvents frmInfoCapacitacion As frmInfoCapacitacion = Nothing

    Private Sub frmControlCapacitacion_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        CheckForIllegalCrossThreadCalls = False
        Dim thread As Thread = New Thread(AddressOf LoadTable)
        thread.Start()
    End Sub
    Private Sub LoadTable()
        Dim caps As Capacitacion = New Capacitacion(_cnnstr)
        Dim cuenta As Integer = 0

        Me.lvCapacitaciones.Items.Clear()

        Try
            For Each c As Academic.Entities.Capacitacion In caps.ToList()
                cuenta = cuenta + 1
                Dim item As ListViewItem = New ListViewItem(CType(c.Id, String))
                item.SubItems.Add(c.Descripcion)
                item.SubItems.Add(CType(c.Modulos.Count(), String))
                item.Tag = c

                Me.lvCapacitaciones.Items.Add(item)
            Next
            Me.txtNumCapacitaciones.Text = CType(cuenta, String)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Servicioalcliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public Sub New(CadenaConexion As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _cnnstr = CadenaConexion
    End Sub

    Private Sub KryptonButton1_Click(sender As System.Object, e As System.EventArgs) Handles KryptonButton1.Click
        If frmInfoCapacitacion Is Nothing Then
            frmInfoCapacitacion = New frmInfoCapacitacion(_cnnstr)
        End If
        frmInfoCapacitacion.Show()
    End Sub

    Private Sub frmInfoCapacitacion_CapacitacionActualizada(UpCapacitacion As Entities.Capacitacion) Handles frmInfoCapacitacion.CapacitacionActualizada
        For Each i As ListViewItem In Me.lvCapacitaciones.Items
            If (i.Text = UpCapacitacion.Id.ToString) Then
                i.SubItems(1).Text = UpCapacitacion.Descripcion
                i.SubItems(2).Text = UpCapacitacion.Modulos.Count.ToString
                i.Tag = UpCapacitacion
                Me.lvCapacitaciones.Refresh()
                Exit For
            End If
        Next
    End Sub

    Private Sub frmInfoCapacitacion_CapacitacionAgregada(c As Entities.Capacitacion) Handles frmInfoCapacitacion.CapacitacionAgregada
        Dim item As ListViewItem = New ListViewItem(CType(c.Id, String))
        item.SubItems.Add(c.Descripcion)
        item.SubItems.Add(CType(c.Modulos.Count, String))
        item.Tag = c

        Me.lvCapacitaciones.Items.Add(item)
        Me.txtNumCapacitaciones.Text = CType(CType(Me.txtNumCapacitaciones.Text, Integer) + 1, String)

    End Sub


    Private Sub cmdEditar_Click(sender As System.Object, e As System.EventArgs) Handles cmdEditar.Click
        If Me.lvCapacitaciones.SelectedItems.Count = 0 Then
            MessageBox.Show("Debe seleccionar una Capacitacion", "Servicioalcliente", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        frmInfoCapacitacion = New frmInfoCapacitacion(_cnnstr, Me.lvCapacitaciones.SelectedItems(0).Tag)
        frmInfoCapacitacion.Show()

    End Sub


    Private Sub cmdEliminar_Click(sender As System.Object, e As System.EventArgs) Handles cmdEliminar.Click
        If Me.lvCapacitaciones.SelectedItems.Count = 0 Then
            MessageBox.Show("Debe seleccionar una Capacitacion", "Servicioalcliente", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If MessageBox.Show("Confirma desea eliminar la capacitacion", "Servicioalcliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        Dim c As Capacitacion = New Capacitacion(_cnnstr, Me.lvCapacitaciones.SelectedItems(0).Tag)
        Try
            c.Remove()
            Me.txtNumCapacitaciones.Text = CType(CType(Me.txtNumCapacitaciones.Text, Integer) - 1, String)
        Catch ex As Exception
            MessageBox.Show("No se pudo eliminar ", "Servicioalcliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        Me.lvCapacitaciones.Items.Remove(Me.lvCapacitaciones.SelectedItems(0))


    End Sub



    Private Sub KryptonButton2_Click(sender As System.Object, e As System.EventArgs) Handles KryptonButton2.Click
        If Me.lvCapacitaciones.SelectedItems.Count = 0 Then
            MessageBox.Show("Debe seleccionar una Capacitacion", "Servicioalcliente", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim frm As frmModulos = New frmModulos(_cnnstr, Me.lvCapacitaciones.SelectedItems(0).Tag)
        frm.Show()

    End Sub

    Private Sub KryptonButton4_Click(sender As System.Object, e As System.EventArgs) Handles KryptonButton4.Click
        Me.Close()
    End Sub

    Private Sub KryptonButton3_Click(sender As System.Object, e As System.EventArgs) Handles KryptonButton3.Click
        Dim thread As Thread = New Thread(AddressOf LoadTable)
        thread.Start()
    End Sub

    Private Sub cmdInforme_Click(sender As System.Object, e As System.EventArgs) Handles cmdInforme.Click

        Dim rpt As Academic.Reporting.InformeCapacitaciones = New Academic.Reporting.InformeCapacitaciones(_cnnstr, CType(Me.lvCapacitaciones.SelectedItems(0).Text, Integer))

        rpt.Compania = "Nugajed S.A"
        rpt.Show()



    End Sub
End Class
