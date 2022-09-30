Option Strict Off
Option Explicit On
Imports System.Data.SqlClient
Public MustInherit Class AccessData
    Private Class TableField
        Public Name As String
        Public Value As String
    End Class
    Private Structure Table
        Dim RowActual As Integer    'Indice de la fila actual q se esta consultando
        Dim Row As Collection       'Almacenamiento de los pares nombre/valor 
        Dim Rows As Integer         'Cantidad maxima de filas
        Dim Fields As String        'Campos a recuperar
        Dim TableName As String     'Tabla de donde provienen los datos
        Dim Filter As String        'Filtro de seleccion de datos
    End Structure
    Private ds As DataSet
    Private db As SqlConnection
    Private User As String             'Usuario de la base de datos   
    Private Pass As String             'Contraseña de la base de datos
    Private srv As String              'Servidor de base de datos    
    Private Tables As Hashtable
    Public Sub Connection(ByRef cnn As SqlClient.SqlConnection)
        db = cnn
    End Sub
    Public Function ContextConnection() As SqlConnection
        Return db
    End Function
    Protected Sub GetData(ByVal AliasTable As String, ByVal TableName As String, Optional ByVal Filter As String = "", Optional ByVal fields As String = "", Optional ByVal order As String = "")
        Dim cmd As SqlCommand
        Dim da As SqlDataAdapter
        Dim NewTable As Table = Nothing
        Dim query As String

        If fields = "" Then
            fields = "*"
        End If
        query = "SELECT " + fields + " FROM " + TableName
        If Filter <> "" Then
            query = query + " WHERE " + Filter
        End If
        If order <> "" Then
            query = query + " ORDER BY " + order
        End If
        NewTable.Fields = fields
        NewTable.TableName = AliasTable
        NewTable.Filter = Filter
        'Realiza la consulta a la base de datos
        Try
            cmd = New SqlCommand(query, db)
            da = New SqlDataAdapter(cmd)
            ds = New DataSet
            da.Fill(ds, AliasTable)
            NewTable.RowActual = 1
            NewTable.Rows = ds.Tables(0).Rows.Count
            If NewTable.Rows > 0 Then
                NewTable.Row = CargarColeccion(AliasTable, NewTable.RowActual)
            End If
            Tables.Add(AliasTable, NewTable) 'Agrega la tabla a la estructura tabla hash
        Catch ex As Exception

        End Try
    End Sub
    Protected Function CargarColeccion(ByVal table As String, ByVal RowActual As Integer) As Collection
        Dim I As Short
        Dim f As TableField
        Dim row As Collection
        row = New Collection
        For I = 0 To ds.Tables(table).Columns.Count - 1
            f = New TableField
            f.Name = ds.Tables(table).Columns(I).ColumnName
            f.Value = ValueFromTable(table, I, RowActual)
            Call row.Add(f, f.Name)
        Next I
        Return row
    End Function
    '--------------------------------------------------------------------------------------------
    'Efecto: 
    'Requiere
    'Devuelve: 
    '---------------------------------------------------------------------------------------------
    Protected Function GetValueFromRow(ByVal table As String, ByVal field As String, ByVal i As Integer) As Object
        Dim f As TableField
        Dim Tab As Object = Nothing

        Tab = Tables.Item(table)    'Obtiene la fila actual
        If Not (Tab Is Nothing) Then
            'Ubica la tabla
            If Tab.Rows > 0 Then
                If (i <> Tab.RowActual) Then
                    Tab.RowActual = i
                    Tab.Row = CargarColeccion(Tab.TableName, Tab.RowActual)
                    Tables.Item(table) = Tab
                End If
                f = Tab.Row.Item(field)
                Return f.Value
            Else
                Return ""
            End If
        Else
            Return ""
        End If
    End Function
    Protected Sub SetValueToRow(ByVal table As String, ByVal field As String, ByVal value As Object)
        Dim f As TableField
        On Error GoTo CatchError
        Dim tab As Object

        tab = Tables.Item(table)
        If tab.Row Is Nothing Then
            tab.Row = New Collection
            f = New TableField
            f.Name = field
            f.Value = value
            tab.Row.Add(f, f.Name)
        Else
            f = New TableField
            f.Name = field
            f.Value = value
            tab.Row.Remove(f.Name)
            tab.Row.Add(f, f.Name)
        End If
        Tables.Item(table) = tab
        Exit Sub
CatchError:
        If Err.Number = 457 Or Err.Number = 5 Then
            Resume Next
        End If
    End Sub
    Private ReadOnly Property ValueFromTable(ByVal table As String, ByVal ColumnIndex As Short, ByVal RowActual As Short) As Object
        Get
            If IsDBNull(ds.Tables(table).Rows(RowActual - 1).Item(ColumnIndex)) Then
                Select Case ds.Tables(0).Columns(ColumnIndex).DataType.Name
                    Case "Decimal" : Return 0
                    Case "DateTime" : Return ""
                    Case Else
                        Return ""
                End Select
            Else
                ValueFromTable = ds.Tables(table).Rows(RowActual - 1).Item(ColumnIndex)
            End If
        End Get
    End Property
    Protected Function RowCount(Optional ByVal table As String = "") As Short
        Dim tab As Object
        tab = Tables.Item(table)
        If Not tab Is Nothing Then
            Return tab.Rows
        Else
            Return 0
        End If
    End Function
    Public Function GetNextRow(Optional ByVal table As String = "") As Boolean
        Dim tab As Object
        tab = Tables(table)
        If tab.RowActual = tab.Rows Then
            tab.RowActual = 1
        Else
            tab.RowActual = tab.RowActual + 1
        End If
        tab.Row = CargarColeccion(table, tab.RowActual)
        Tables(table) = tab
    End Function
    Public Sub GetFirstRow(Optional ByVal table As String = "")
        Dim tab As Table
        tab = Tables(table)
        tab.RowActual = 1
        Tables(table) = tab
        ' ChangeRow = True
    End Sub
    
    Public WriteOnly Property Usuario() As String
        Set(ByVal Value As String)
            User = Value
        End Set
    End Property
    Public WriteOnly Property Password() As String
        Set(ByVal Value As String)
            Pass = Value
        End Set
    End Property
    Public WriteOnly Property Servidor() As String
        Set(ByVal Value As String)
            srv = Value
        End Set
    End Property
    Public Function Source(Optional ByVal table As String = "") As DataTable
        Try
            If table = "" Then
                If ds Is Nothing Then
                    Return Nothing
                Else
                    If ds.Tables.Count > 0 Then
                        Return ds.Tables(0)
                    Else
                        Return Nothing
                    End If
                End If
            Else
                Return ds.Tables(table)
            End If
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    ' Public Function RowChange() As Boolean
    '     Return ChangeRow
    ' End Function
    'EFECTO: Manipula los errores ocurridos en la clase
    'MODIFICA: Nada.
    'REQUIERE: Los parámetros
    'EXCEPCIÓN: Nada.
    Private Sub ErrorControl(Optional ByRef msg As String = "")
        'Para almacenar el número de archivo de la bitácora de errores.
        Dim vln_FileNumber As Integer

        'Si el número de error no es -1, es un error grave, por lo que hay que
        'almacenarlo en el archivo de bitácora.
        If Err.Number <> -1 Then
            'Obtener un número de archivo libre y abrir el archivo de bitácora.
            vln_FileNumber = FreeFile()
            FileOpen(vln_FileNumber, My.Application.Info.DirectoryPath & "\Logs\ADErr.Log", OpenMode.Append)

            'Agregar el error al archivo de bitácora
            PrintLine(vln_FileNumber, vbCrLf & vbCrLf)
            PrintLine(vln_FileNumber, "FECHA Y HORA: " & Now)
            PrintLine(vln_FileNumber, "NÚMERO: " & Err.Number)
            PrintLine(vln_FileNumber, "FUENTE: " & Err.Source)
            PrintLine(vln_FileNumber, "DESCRIPCIÓN: " & Err.Description)
            PrintLine(vln_FileNumber, "DETALLES ADICIONALES: " & msg)
            'Cerrar el archivo
            FileClose(vln_FileNumber)
        End If
    End Sub

    Public Sub New()
        Tables = New Hashtable()
    End Sub
End Class
