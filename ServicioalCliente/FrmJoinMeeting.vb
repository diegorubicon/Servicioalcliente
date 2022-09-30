Imports System.Data.SqlClient
Public Class FrmJoinMeeting
    Public vendedor As String
    Private Sub cmbActividades_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbActividades.SelectedValueChanged
        Dim cmd As SqlCommand
        Dim opara As SqlParameter
        Dim da As SqlDataAdapter
        Dim ds As DataSet
        If Me.cmbActividades.SelectedValue Is Nothing Then
            Exit Sub
        End If
        If Me.cmbActividades.SelectedValue.ToString <> "System.Data.DataRowView" Then
            Try
                cmd = New SqlCommand("sp_GetActivities", db)
                cmd.CommandType = CommandType.StoredProcedure
                opara = New SqlParameter("@actividad", Me.cmbActividades.SelectedValue)
                cmd.Parameters.Add(opara)
                da = New SqlDataAdapter
                da.SelectCommand = cmd
                ds = New DataSet
                da.Fill(ds)

                Me.lbFecha.Text = "Fecha: " + ds.Tables(0).Rows(0).Item("fecha").ToString
                Me.lbObservaciones.Text = "Observaciones: " + ds.Tables(0).Rows(0).Item("observaciones").ToString
            Catch ex As Exception
                MessageBox.Show("No se pudo cargar la informacion de la actividad", "ServicioalCliente", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try
        End If
    End Sub

    Public Sub New()
        Dim cmd As SqlCommand
        Dim opara As SqlParameter
        Dim da As SqlDataAdapter
        Dim ds As DataSet
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        Try
            cmd = New SqlCommand("sp_GetActivities", db)
            cmd.CommandType = CommandType.StoredProcedure
            opara = New SqlParameter("@actividad", 0)
            cmd.Parameters.Add(opara)
            da = New SqlDataAdapter
            da.SelectCommand = cmd
            ds = New DataSet
            da.Fill(ds)
            Me.SuspendLayout()
            Me.cmbActividades.DataSource = ds.Tables(0)
            Me.cmbActividades.DisplayMember = "titulo"
            Me.cmbActividades.ValueMember = "actividad"
            Me.ResumeLayout()
        Catch ex As Exception
            MessageBox.Show("No se pudo obtener las actividades " + ex.Message, "ServicioalCliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim cmd As SqlCommand
        Dim opara As SqlParameter
        Dim rst As Integer

        cmd = New SqlCommand("sp_JoinActivity", db)
        cmd.CommandType = CommandType.StoredProcedure
        opara = New SqlParameter("@actividad", Me.cmbActividades.SelectedValue)
        cmd.Parameters.Add(opara)
        opara = New SqlParameter("@vendedor", vendedor)
        cmd.Parameters.Add(opara)
        Try
            rst = cmd.ExecuteScalar
        Catch ex As Exception
            MessageBox.Show("No se pudo ingresar " + ex.Message)
        End Try
        If rst = 0 Then
            MessageBox.Show("Este vendedor ya se unio a esta actividad, Se activo nuevamente", "ServicioalCliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            MessageBox.Show("Vendedor se unio a esta actividad", "ServicioalCliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End If

    End Sub

    Private Sub FrmJoinMeeting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class