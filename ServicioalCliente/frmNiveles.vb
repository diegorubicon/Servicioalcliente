Imports System.Data.SqlClient
Imports CompensationPlan

Public Class frmNiveles
    Public vendedor As String
    Public Sub CargarDatos()
        Dim sf As New SalesForceLib.SalesForce
        Dim objSellers As SalesForceLib.SalesMan = sf(vendedor)
        Dim item As ListViewItem



        Me.lbVendedor.Text = "Vendedor: " + objSellers.FullName
        Me.lbNivel.Text = "Nivel Actual: " + objSellers.CompensationPlan.Description

        item = New ListViewItem(objSellers.EntryPeriod)
        item.SubItems.Add("Distribuidor")
        item.SubItems.Add("Cierre Ingreso")
        Me.lvPosiciones.Items.Add(item)

        'item = New ListViewItem(objSellers.CierreActivacion.Descripcion)
        'item.SubItems.Add("Activo")
        'item.SubItems.Add("Cierre Activacion ")
        'Me.lvPosiciones.Items.Add(item)

        Using cmd As SqlCommand = New SqlCommand("ObtenerHistoricoNiveles", db)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@vendedor", vendedor)
            Using reader As SqlDataReader = cmd.ExecuteReader
                While reader.Read
                    item = New ListViewItem(reader.Item(0).ToString)
                    item.SubItems.Add(reader.Item(1).ToString)
                    item.SubItems.Add(reader.Item(2).ToString)

                    Me.lvPosiciones.Items.Add(item)
                End While
            End Using

        End Using



    End Sub

    Private Sub frmNiveles_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmdCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCerrar.Click
        Me.Close()
    End Sub
End Class