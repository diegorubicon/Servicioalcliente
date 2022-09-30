Imports System.Data.SqlClient
Public Class frmMakeMeeting
    Private Sub cmdCrearActividad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCrearActividad.Click

        If Me.txtDescripcion.Text.Trim = "" Then
            MessageBox.Show("Debe Ingresar la descripcion de la Actividad", "ServicioalCliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Me.txtUbicacion.Text.Trim = "" Then
            MessageBox.Show("Debe ingresar la ubicacion", "ServicioalCliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Me.txtfecha.Value.Date < DateTime.Now.Date Then
            MessageBox.Show("La fecha de la actividad no puede ser inferior a la actual", "ServicioalCliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Me.optActividadMensual.Checked = False _
            And Me.optActividadReclutamiento.Checked = False _
            And Me.optActividadVenta.Checked = False And Me.optActividadDesarrollo.Checked = False Then

            MessageBox.Show("Debe seleccionar el tipo de actividad", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub

        End If

        Dim esventa As Integer = If(Me.optActividadVenta.Checked, 1, 0)
        Dim esreclutamiento As Integer = If(Me.optActividadReclutamiento.Checked, 1, 0)
        Dim esmensual As Integer = If(Me.optActividadMensual.Checked, 1, 0)
        Dim esdesarrollo As Integer = If(Me.optActividadDesarrollo.Checked, 1, 0)

        Using cmd As SqlCommand = New SqlCommand("[sac].sp_InsertActivity", db)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("descripcion", Me.txtDescripcion.Text)
            cmd.Parameters.AddWithValue("ubicacion", Me.txtUbicacion.Text)
            cmd.Parameters.AddWithValue("fecha", Me.txtfecha.Value)
            cmd.Parameters.AddWithValue("observaciones", Me.txtObservaciones.Text)
            cmd.Parameters.AddWithValue("esventa", esventa)
            cmd.Parameters.AddWithValue("esreclutamiento", esreclutamiento)
            cmd.Parameters.AddWithValue("esmensual", esmensual)
            cmd.Parameters.AddWithValue("esdesarrollo", esdesarrollo)
            cmd.Parameters.AddWithValue("usuario", Usuario)
            Try
                Dim rst As String = cmd.ExecuteScalar

                If rst.Trim <> "SUCCESS" Then
                    MessageBox.Show("No se pudo crear la actividad " + rst, "ServicioalCliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                Me.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "ServicioalCliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub
    Private Sub frmMakeMeeting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtfecha.Value = DateTime.Now.Date
    End Sub

    Private Sub cmdCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCerrar.Click
        Me.Close()
    End Sub
End Class