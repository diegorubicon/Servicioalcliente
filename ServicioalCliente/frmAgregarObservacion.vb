Imports System.Data.SqlClient
Public Class frmAgregarObservacion
    Public vendedor As String
    Public Gestion As Integer
    Public AgregoObservacion As Boolean = False
    Public TypeCall As Integer
    Private Sub cmdAgregar_Click(sender As System.Object, e As System.EventArgs) Handles cmdAgregar.Click
        Dim cmd As SqlCommand
        Dim sel As New System.Text.StringBuilder
        Dim result As Integer

        If Me.dtProximaLlamada.Value = DateTime.Now Then
            MessageBox.Show("Debe Ingresar una fecha de proxima llamada", _
                            "ServicioalCliente", _
                            MessageBoxButtons.OK, _
                            MessageBoxIcon.Error)
            Exit Sub
        End If
        'llamadas de tipo A
        If Me.rbA.Checked Then
            If Me.txtObservacion.Text.Length = 0 Then
                MessageBox.Show("Debe Ingresar un Comentario", _
                                "ServicioalCliente", _
                                MessageBoxButtons.OK, _
                                MessageBoxIcon.Error)
                Exit Sub
            End If
            If (Me.dtProximaLlamada.Value - DateTime.Now).TotalDays > 15 Then
                MessageBox.Show("No se puede programar una proxima llamada superior a 15 Dias", _
                                "ServicioalCliente", _
                                MessageBoxButtons.OK, _
                                MessageBoxIcon.Error)
                Exit Sub
            End If
        End If
        'llamadas de tipo B
        If Me.rbB.Checked Then
            If Me.txtObservacion.Text.Length = 0 Then
                MessageBox.Show("Debe Ingresar un Comentario", _
                                "ServicioalCliente", _
                                MessageBoxButtons.OK, _
                                MessageBoxIcon.Error)
                Exit Sub
            End If
            If (Me.dtProximaLlamada.Value - DateTime.Now).TotalDays > 8 Then
                MessageBox.Show("No se puede programar una proxima llamada superior a 8 Dias", _
                                "ServicioalCliente", _
                                MessageBoxButtons.OK, _
                                MessageBoxIcon.Error)
                Exit Sub
            End If
        End If
        'llamadas de tipo c
        If Me.rbC.Checked Then
            Me.dtProximaLlamada.Value = DateTime.Now.AddDays(1)
        End If
        If Me.rbA.Checked = False And Me.rbB.Checked = False And Me.rbC.Checked = False Then
            MessageBox.Show("Debe seleccionar el estado de la llamada", _
                            "ServicioalCliente", _
                            MessageBoxButtons.OK, _
                            MessageBoxIcon.Error)
            Exit Sub
        End If
        Using db As SqlConnection = New SqlConnection(Variables.ConnectionString)
            'Insertar la nota de cobro
            sel.Append("INSERT INTO notas_vendedores (vendedor,fecha,observacion,estado,gestion,fecha_proxima_llamada,creado_el,creado_por) ")
            sel.Append("VALUES (@vendedor,getdate (),@observacion,@estado,@gestion,@proxima_llamada,getdate (),@creado_por); ")
            sel.Append("UPDATE gestiones_vendedores SET fecha_fin = @fecha_fin , estado = 2 WHERE consecutivo = @gestion")
            cmd = New SqlCommand(sel.ToString, db)
            cmd.Parameters.AddWithValue("@vendedor", vendedor)
            cmd.Parameters.AddWithValue("@observacion", Me.txtObservacion.Text)
            If Me.rbA.Checked Then
                cmd.Parameters.AddWithValue("@estado", 1)
                TypeCall = 1
            End If
            If Me.rbB.Checked Then
                cmd.Parameters.AddWithValue("@estado", 2)
                TypeCall = 2
            End If
            If Me.rbC.Checked Then
                cmd.Parameters.AddWithValue("@estado", 3)
                TypeCall = 3
            End If
            cmd.Parameters.AddWithValue("@gestion", Gestion)
            cmd.Parameters.AddWithValue("@proxima_llamada", Me.dtProximaLlamada.Value)
            cmd.Parameters.AddWithValue("@creado_por", Usuario)
            cmd.Parameters.AddWithValue("@fecha_fin", DateTime.Now)
            Try
                db.Open()
                result = cmd.ExecuteScalar
                db.Close()
                AgregoObservacion = True
                Me.Close()
            Catch ex As SqlException
                MessageBox.Show("No se pudo insertar el comentario", "ServicioalCliente", MessageBoxButtons.OK, MessageBoxIcon.Error)

                Me.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, _
                                "ServicioalCliente", _
                                MessageBoxButtons.OK, _
                                MessageBoxIcon.Error)
                Me.Close()
            Finally
                cmd.Dispose()
            End Try
            Me.txtObservacion.Text = ""
            Me.rbA.Checked = False
            Me.rbB.Checked = False
            Me.rbC.Checked = False

        End Using
    End Sub

    Private Sub frmAgregarObservacion_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmdCerrar_Click(sender As System.Object, e As System.EventArgs) Handles cmdCerrar.Click
        Me.Close()
    End Sub
End Class