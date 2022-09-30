Public Class frmEditEmail
    Public vendedor As String
    Private Sub cmdCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCerrar.Click
        Me.Close()
    End Sub

    Private Sub cmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click
        Dim cmd As SqlClient.SqlCommand
        Dim prm As SqlClient.SqlParameter
        Dim rst As Integer

        If MessageBox.Show("Desea Actualizar el correo electronico del vendedor", _
                           "ServicioalCliente", _
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            cmd = New SqlClient.SqlCommand("UPDATE  vendedores set correo = @correo WHERE vendedor = @vendedor", db)
            prm = New SqlClient.SqlParameter("@correo", Me.TextBox1.Text)
            cmd.Parameters.Add(prm)
            prm = New SqlClient.SqlParameter("@vendedor", vendedor)
            cmd.Parameters.Add(prm)
            Try
                rst = cmd.ExecuteNonQuery
            Catch ex As Exception
                MessageBox.Show("No se pudo actualizar el correo electronico del vendedor", "ServicioalCliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            If rst = 1 Then

                frmVendedores.lvVendedores.SelectedItems(0).SubItems(6).Text = Me.TextBox1.Text
                frmVendedores.Refresh()
                MessageBox.Show("Informacion Actualizada Correctamente", "ServicioalCliente", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End If
        End If
    End Sub
End Class