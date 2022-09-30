Option Strict Off
Option Explicit On
Imports System.Data.SqlClient
Friend MustInherit Class AccessData
    Private Class TableField
        Public Name As String
        Public Value As String
    End Class
    Private ds As DataSet
    Private WithEvents cnn As ConfigConnect.ConnectionAD
    Private RowActual As Integer       'Fila Actual que se estan recuperando los datos
    Private Row As Collection          'Coleccion que contiene el valor de fila actual y los datos leidos del recordset
    Private Rows As Integer            'Cantidad de filas que leyo del recordset    
    Private User As String             'Usuario de la base de datos   
    Private Pass As String             'Contraseña de la base de datos
    Private srv As String              'Servidor de base de datos 
    Private query As String
    Public Sub New()
        Row = Nothing
        RowActual = 0
        Rows = 0
    End Sub
    Protected Sub GetData(ByVal sql As String)
        query = sql
        cnn = New ConfigConnect.ConnectionAD
        cnn.Usuario = User
        cnn.Password = Pass
        cnn.Servidor = srv
        cnn.OpenConnection()
    End Sub
    Private Sub cnn_OnConnectionEstablished(ByRef db As SqlConnection) Handles cnn.OnConnectionEstablished
        Dim cmd As SqlCommand
        Dim da As SqlDataAdapter
        Try
            cmd = New SqlCommand(query, db)
            da = New SqlDataAdapter(cmd)
            ds = New DataSet
            da.Fill(ds)
            RowActual = 0
            Rows = ds.Tables(0).Rows.Count
            CargarColeccion()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub cnn_OnConnectionFail(ByRef Ex As System.Exception) Handles cnn.OnConnectionFail
        RowActual = 0
        Rows = 0
    End Sub
    Protected Sub CargarColeccion()
        Dim I As Short
        Dim f As TableField

        Row = New Collection
        For I = 0 To ds.Tables(0).Columns.Count - 1
            f = New TableField
            f.Name = ds.Tables(0).Columns(I).ColumnName
            f.Value = ValueFromTable(I)
            Call Row.Add(f, f.Name)
        Next I
    End Sub
    Protected Function GetValueFromRow(ByVal field As String) As Object
        Dim f As TableField
        f = Row.Item(field)
        Return f.Value
    End Function
    Protected Sub SetValueToRow(ByVal field As String, ByVal value As Object)
        Dim f As TableField
        On Error GoTo CatchError
        If Row Is Nothing Then
            Row = New Collection
            f = New TableField
            f.Name = field
            f.Value = value
            Row.Add(f, f.Name)
        Else
            f = New TableField
            f.Name = field
            f.Value = value
            Row.Remove(f.Name)
            Row.Add(f, f.Name)
        End If
        Exit Sub
CatchError:
        If Err.Number = 457 Or Err.Number = 5 Then
            Resume Next
        End If
    End Sub
    Private ReadOnly Property ValueFromTable(ByVal ColumnIndex As Short) As Object
        Get
            If IsDBNull(ds.Tables(0).Rows(RowActual).Item(ColumnIndex)) Then
                Select Case ds.Tables(0).Columns(ColumnIndex).DataType.Name
                    Case "Decimal" : Return 0
                    Case "DateTime" : Return Now


                    Case Else
                        Return ""
                End Select
            Else
                ValueFromTable = ds.Tables(0).Rows(RowActual).Item(ColumnIndex)
            End If
        End Get
    End Property
    Public Function RowCount() As Short
        Return Rows
    End Function
    Public Function GetNextRow() As Boolean
        If RowActual = Rows Then
            RowActual = 0
        Else
            RowActual = RowActual + 1
        End If
    End Function
    Public Sub GetFirstRow()
        RowActual = 0
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
    Public Function Source() As DataTable
        Return ds.Tables(0)
    End Function
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
            FileOpen(vln_FileNumber, My.Application.Info.DirectoryPath & "\Logs\ZipCodeADErr.Log", OpenMode.Append)

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
