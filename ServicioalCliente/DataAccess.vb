Imports System.Data.SqlClient
Module DataAccess
    Public Function GetReader(query As String, ByRef db As SqlConnection) As SqlDataReader
        Dim cmd As SqlCommand = New SqlCommand(query, db)
        cmd.CommandType = CommandType.Text
        Try
            Return cmd.ExecuteReader
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Function GetDataTable(query As String, ByRef db As SqlConnection) As DataTable
        Using cmd As SqlCommand = New SqlCommand(query, db)
            cmd.CommandType = CommandType.Text
            Using adapter As SqlDataAdapter = New SqlDataAdapter(cmd)
                Try
                    Dim dt As DataTable = New DataTable

                    adapter.Fill(dt)

                    Return dt

                Catch ex As Exception
                    MessageBox.Show("No se pudo obtener los datos" + ex.Message, "Servicioalcliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return Nothing
                End Try
            End Using
        End Using
    End Function
    Public Function GetValue(query As String, ByRef db As SqlConnection) As Integer
        Using cmd As SqlCommand = New SqlCommand(query, db)
            cmd.CommandType = CommandType.Text
            Try
                Dim rst = CType(cmd.ExecuteScalar, Integer)

                Return rst

            Catch ex As Exception
                MessageBox.Show("No se pudo obtener los datos" + ex.Message, "Servicioalcliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return Nothing
            End Try
        End Using
    End Function

End Module
