Imports System.Data.SqlClient
Public Class InformeCapacitaciones

    Private _cnnstr As String
    Private _Id As Integer
    Private _compania As String
    Public Sub New(ConnectionString As String, id As Integer)
        _cnnstr = ConnectionString
        _Id = id
    End Sub
    Public Property Compania As String
        Get
            Return _compania
        End Get
        Set(value As String)
            _compania = value
        End Set
    End Property
    Public Sub Show()
        '
        'Carga los datos en el dataset
        '
        Dim sqlCapacitacion As String = "SELECT * FROM capacitaciones WHERE id = @id"
        Dim sqlcapacitacionModulos As String = "SELECT * FROM capacitacion_modulos WHERE id_capacitacion = @id"
        Dim sqlcapacitacionVendedores As String = "SELECT * FROM capacitacion_modulos_vendedores where id_capacitacion = @id"
        Dim sqlvendedores As String = "SELECT v.* FROM vendedores v, capacitacion_modulos_vendedores cmv where cmv.vendedor = v.vendedor and cmv.id_capacitacion = @id"

        Dim ds As dsCapacitaciones = New dsCapacitaciones
        Try
            Dim conn As SqlConnection = New SqlConnection(_cnnstr)

            Dim adapter1 As SqlDataAdapter = New SqlDataAdapter(sqlCapacitacion, conn)
            adapter1.SelectCommand.Parameters.AddWithValue("@id", _Id)
            Dim adapter2 As SqlDataAdapter = New SqlDataAdapter(sqlcapacitacionModulos, conn)
            adapter2.SelectCommand.Parameters.AddWithValue("@id", _Id)
            Dim adapter3 As SqlDataAdapter = New SqlDataAdapter(sqlcapacitacionVendedores, conn)
            adapter3.SelectCommand.Parameters.AddWithValue("@id", _Id)
            Dim adapter4 As SqlDataAdapter = New SqlDataAdapter(sqlvendedores, conn)
            adapter4.SelectCommand.Parameters.AddWithValue("@id", _Id)

            adapter1.Fill(ds, "capacitaciones")
            adapter2.Fill(ds, "capacitacion_modulos")
            adapter3.Fill(ds, "capacitacion_modulos_vendedores")
            adapter4.Fill(ds, "vendedores")

            'Dim informe As rptCapacitaciones = New rptCapacitaciones

            ' informe.DataDefinition.FormulaFields("compania").Text = "'" & _compania & "'"
            'informe.SetDataSource(ds)

            ' Dim frm As frmVistaPrevia = New frmVistaPrevia(informe)
            'frm.Show()

        Catch ex As Exception

        End Try


    End Sub

End Class
