Imports System.Data.SqlClient
Public Class frmPassword
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Dim cmd As SqlCommand
        Dim result As Integer

        cmd = New SqlCommand("select count(*) as rec from parametros_default where password = @password", db)
        cmd.Parameters.Add(New SqlParameter("@password", Me.txtpasw.Text))
        Try
            result = cmd.ExecuteScalar
            If result = 1 Then
                ContraseñaValida = True
                Me.Close()
            Else
                ContraseñaValida = False
                MessageBox.Show("La contraseña ingresada no es Valida", "ServicioalCliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            ContraseñaValida = False
        End Try
    End Sub
    Private Sub frmPassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtpasw.Text = ""
        ContraseñaValida = False
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ContraseñaValida = False
        Me.Close()
    End Sub
    
End Class