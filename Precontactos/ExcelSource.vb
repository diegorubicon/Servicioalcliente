Imports System.Data
Imports System.Data.OleDb

Public Class ExcelSource


    Private _cnnstr As String
    Public Sub New(FileName As String)
        _cnnstr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + FileName + ";Extended Properties='Excel 8.0;HDR=YES;'"
    End Sub

    Public Function Sheets() As List(Of String)
        Dim lista As List(Of String) = New List(Of String)

        Using excelConnection As OleDbConnection = New OleDbConnection(_cnnstr)
            Try
                excelConnection.Open()
            Catch ex As Exception
                Return lista
            End Try

            Dim dtTables As DataTable = New DataTable()
            'to get the schema of the workbook.
            dtTables = excelConnection.GetSchema()

            'get the tables in the workbook
            dtTables = excelConnection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, Nothing)

            If Not dtTables Is Nothing Then
                For Each row As DataRow In dtTables.Rows
                    If Not row("TABLE_NAME").ToString().StartsWith("_xln") Then
                        lista.Add(row("TABLE_NAME").ToString().Replace("$", ""))
                    End If
                Next
            End If
            Return lista

        End Using
    End Function
    Public Function ReadSheet(SheetName As String) As DataTable

        Using excelConnection As OleDbConnection = New OleDbConnection(_cnnstr)
            Try
                excelConnection.Open()
            Catch ex As Exception
                Return Nothing
            End Try



            Using cmd As OleDbCommand = New OleDbCommand()
                cmd.Connection = excelConnection
                cmd.CommandText = "Select * from [" + SheetName + "$]"

                Dim adapter = New OleDbDataAdapter(cmd)
                Dim ds As DataTable = New DataTable

                Try
                    adapter.Fill(ds)

                    Return ds
                Catch ex As Exception
                    Return Nothing
                End Try

            End Using
        End Using

    End Function

    

End Class
