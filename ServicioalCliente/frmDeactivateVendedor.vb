Imports System.Data.Sqlclient
Public Class frmDeactivateVendedor
    Public vendedor As String
    Private Sub cmdCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCerrar.Click
        Me.Close()
    End Sub
    Private Sub cmdInactivar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdInactivar.Click
        Dim cmd As SqlCommand
        Dim opara As SqlParameter
        Dim rst As Long
        cmd = New SqlCommand("sp_InactiveVendedor", db)
        cmd.CommandType = CommandType.StoredProcedure
        opara = New SqlParameter("@vendedor", vendedor)
        cmd.Parameters.Add(opara)
        opara = New SqlParameter("@comentario", Me.txtComentarios.Text)
        cmd.Parameters.Add(opara)
        opara = New SqlParameter("@usuario", Usuario)
        cmd.Parameters.Add(opara)
        Try
            rst = cmd.ExecuteNonQuery
        Catch ex As Exception
            MessageBox.Show("No se pudo inactivar el vendedor " + ex.Message, "ServicioalCliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        MessageBox.Show("Se inactivo el vendedor", "ServicioalCliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
        frmVendedores.lvVendedores.Items.RemoveAt(frmVendedores.lvVendedores.SelectedItems(0).Index)
        Me.Close()


    End Sub
End Class