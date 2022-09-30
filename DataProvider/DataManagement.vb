Option Strict Off
Option Explicit On
Imports System.Data.SqlClient
Public MustInherit Class DataManagement
    Private db As SqlConnection = Nothing
    Private mTableName As String
    Private mFilter As TableFilter = Nothing
    Private mFields As Hashtable = Nothing
    Private mTable As DataTable
    Private mOrder As TableOrder = Nothing
    Private Shared mTypeStorage As Integer = 1
    Public Class TableFilter
        Private mFilter As String = ""
        Public Sub Add(ByVal ColumnName As TableColumn, ByVal Condition As String, ByVal Value As Object)
            Dim filtro = Value.ToString
            If TypeOf Value Is String Then
                filtro = "'" + filtro + "'"
            End If
            If mFilter = "" Then
                mFilter = "(" + ColumnName.Name + " " + Condition + filtro + ")"
            Else
                mFilter = mFilter + " and (" + ColumnName.Name + " " + Condition + filtro + ")"
            End If
        End Sub
        Public Overrides Function ToString() As String
            Return mFilter
        End Function
    End Class
    Public Class TableOrder
        Private mOrder As String = ""
        Public Enum TypeOrder
            Asc = 1
            Desc = 2
        End Enum
        Public Sub Add(ByVal ColumnName As TableColumn, ByVal tipo As TypeOrder)
            If mOrder = "" Then
                If tipo = TypeOrder.Asc Then
                    mOrder = ColumnName.Name + " ASC "
                Else
                    mOrder = ColumnName.Name + " DESC "
                End If
            Else
                If tipo = TypeOrder.Asc Then
                    mOrder = mOrder + "," + ColumnName.Name + " ASC "
                Else
                    mOrder = mOrder + "," + ColumnName.Name + " DESC "
                End If
            End If
        End Sub
        Public Overrides Function ToString() As String
            Return mOrder
        End Function
    End Class
    Public Class TableColumn
        Private mColumnName As String
        Private mtable As DataTable = Nothing
        Public Sub New(ByVal ColumnName As String)
            mColumnName = ColumnName
        End Sub
        Public Sub New(ByVal ColumnName As String, ByRef dtTable As DataTable)
            mColumnName = ColumnName
            mtable = dtTable
        End Sub
        Public ReadOnly Property Type() As String
            Get
                Return mTable.Columns(mColumnName).DataType.Name
            End Get
        End Property
        Public Property Value(Optional ByVal RowNum As Integer = 0) As Object
            Get
                Try
                    Return (RemoveNull(mTable.Rows(RowNum).Item(mColumnName)))
                Catch ex As Exception
                    Return Nothing
                End Try
            End Get
            Set(ByVal value As Object)
            End Set
        End Property
        Public Property Name() As String
            Get
                Return mColumnName
            End Get
            Set(ByVal value As String)
                mColumnName = value
            End Set
        End Property
        Private Function RemoveNull(ByVal Value As Object) As Object
            If IsDBNull(Value) Then
                Select Case Type
                    Case "Decimal" : Return 0
                    Case "DateTime" : Return ""
                    Case Else
                        Return ""
                End Select
            Else
                Return Value
            End If
        End Function
    End Class
#Region "Constructores"
    Public Sub New(Optional ByRef Connection As SqlClient.SqlConnection = Nothing)
        db = Connection
        mFilter = New TableFilter
        mFields = New Hashtable
        mOrder = New TableOrder
    End Sub
    Public Sub New(ByVal Srv As String, ByVal Uid As String, ByVal Pwd As String)
        db = New SqlConnection()
        mFilter = New TableFilter
    End Sub
#End Region
#Region "Propiedades"
    Public Property Connection() As SqlClient.SqlConnection
        Get
            Return db
        End Get
        Set(ByVal value As SqlConnection)
            db = value
        End Set
    End Property
    Protected ReadOnly Property Filter() As TableFilter
        Get
            Return mFilter
        End Get
    End Property
    Protected ReadOnly Property Order() As TableOrder
        Get
            Return mOrder
        End Get
    End Property
    Protected Property Fields(ByVal Columna As String) As TableColumn
        Get
            If Not mFields.ContainsKey(Columna) Then
                Dim tc = New TableColumn(Columna, mTable)
                mFields.Add(Columna, tc)
            End If
            Return mFields.Item(Columna)
        End Get
        Set(ByVal value As TableColumn)
            If Not mFields.ContainsKey(Columna) Then
                mFields.Add(Columna, value)
            End If
        End Set
    End Property
    Protected Property TableName() As String
        Get
            Return mTableName
        End Get
        Set(ByVal value As String)
            mTableName = value
        End Set
    End Property
#End Region
#Region "Metodos"
    Public Sub GetThisField(ByVal Columna As String)
        If Not mFields.ContainsKey(Columna) Then
            Dim tc = New TableColumn(Columna)
            mFields.Add(Columna, tc)
        End If
    End Sub
    Public Sub FillTable()
        Dim cmd As SqlCommand
        Dim da As SqlDataAdapter
        Dim query As String
        mTypeStorage = 1
        query = MakeSQLInstruction()
        'Realiza la consulta a la base de datos
        cmd = New SqlCommand(query, db)
        cmd.CommandTimeout = Integer.MaxValue
        cmd.CommandType = CommandType.Text
        da = New SqlDataAdapter(cmd)
        Try
            mTable = New DataTable(mTableName)
            da.Fill(mTable)
        Catch ex As SqlException
            mTable = Nothing
        End Try
    End Sub
    Public Function FillReader() As Integer
        Dim cmd As SqlCommand
        Dim query As String
        Dim inicio As Integer, final As Integer
        Dim reader As SqlDataReader
        mTypeStorage = 2
        query = MakeSQLInstruction()
        cmd = New SqlCommand(query, db)
        cmd.CommandTimeout = Integer.MaxValue
        cmd.CommandType = CommandType.Text
        Try
            inicio = Math.Abs(Environment.TickCount)
            reader = cmd.ExecuteReader
            mTable = New DataTable(mTableName)
            mTable.Load(reader)
            'db.Close()
            final = Math.Abs(Environment.TickCount)
            Return inicio - final
        Catch ex As Exception
        End Try
    End Function
    Private Function MakeSQLInstruction()
        Dim f As String = ""
        Dim q
        'Creacion de la sentecia sql
        If mFields.Count = 0 Then
            f = "*"
        Else
            For Each elemento As DictionaryEntry In mFields
                If f = "" Then
                    f = mFields(elemento.Key).ToString
                Else
                    f = f + "," + mFields(elemento.Key).ToString
                End If
            Next
        End If
        q = "SELECT " + f + " FROM " + mTableName
        If mFilter.ToString <> "" Then
            q = q + " WHERE " + mFilter.ToString
        End If
        If mOrder.ToString <> "" Then
            q += " ORDER BY " + mOrder.ToString
        End If
        Return q
    End Function
    Public Function Count()
        If mTable Is Nothing Then
            Return 0
        Else
            Return mTable.Rows.Count
        End If
    End Function
#End Region
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
End Class
