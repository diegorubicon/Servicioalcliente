Imports System.ComponentModel
Imports System.Threading
Public Class frmImportarExcel

    Public Class Columnas
        Private _fecha As String = "A"
        Private _nombre As String = "B"
        Private _telefono1 As String = "C"
        Private _telefono2 As String = "D"
        Private _email As String = "E"
        Private _Provincia As String = "F"
        Private _lugar As String
        Private _referido As String
        Private _interes As String

        <CategoryAttribute("Mapeo de Columnas"), _
        DefaultValueAttribute("A"),
        DescriptionAttribute("Fecha de ingreso del Precontacto")> _
        Public Property Fecha As String
            Get
                Return _fecha
            End Get
            Set(value As String)
                _fecha = value
            End Set
        End Property
        <CategoryAttribute("Mapeo de Columnas"), _
        DefaultValueAttribute("B"),
        DescriptionAttribute("Nombre del Precontacto")> _
        Public Property Nombre As String
            Get
                Return _nombre
            End Get
            Set(value As String)
                _nombre = value
            End Set
        End Property
        <CategoryAttribute("Mapeo de Columnas"), _
        DefaultValueAttribute("C"),
        DescriptionAttribute("Telefono principal del precontancto")> _
        Public Property Telefono1 As String
            Get
                Return _telefono1
            End Get
            Set(value As String)
                _telefono1 = value
            End Set
        End Property
        <CategoryAttribute("Mapeo de Columnas"), _
        DefaultValueAttribute("D"),
        DescriptionAttribute("Telefono secundario del precontacto")> _
        Public Property Telefono2 As String
            Get
                Return _telefono2
            End Get
            Set(value As String)
                _telefono2 = value
            End Set
        End Property
        <CategoryAttribute("Mapeo de Columnas"), _
        DefaultValueAttribute("E"),
        DescriptionAttribute("Fecha de ingreso del Precontacto")> _
        Public Property CorreoElectronico As String
            Get
                Return _email
            End Get
            Set(value As String)
                _email = value
            End Set
        End Property
        <CategoryAttribute("Mapeo de Columnas"), _
        DefaultValueAttribute("F"),
        DescriptionAttribute("Provincia de residencia")> _
        Public Property Provincia As String
            Get
                Return _Provincia
            End Get
            Set(value As String)
                _Provincia = value
            End Set
        End Property
        <CategoryAttribute("Mapeo de Columnas"), _
        DefaultValueAttribute("G"),
        DescriptionAttribute("Zona de residencia del precontacto")> _
        Public Property Zona As String
            Get
                Return _lugar
            End Get
            Set(value As String)
                _lugar = value
            End Set
        End Property
        <CategoryAttribute("Mapeo de Columnas"), _
        DefaultValueAttribute("H"),
        DescriptionAttribute("Persona referencia del precontacto")> _
        Public Property ReferidoPor As String
            Get
                Return _referido
            End Get
            Set(value As String)
                _referido = value
            End Set
        End Property
        <CategoryAttribute("Mapeo de Columnas"), _
        DefaultValueAttribute("i"),
        DescriptionAttribute("Interes del Precontacto")> _
        Public Property Interes As String
            Get
                Return _interes
            End Get
            Set(value As String)
                _interes = value
            End Set
        End Property
       
    End Class
    Private _filename As String
    Private cols As Columnas
    Public Sub New()
        CheckForIllegalCrossThreadCalls = False
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ' Create the AppSettings class and display it in the PropertyGrid.
        cols = New Columnas
        PropertyGrid1.SelectedObject = cols

        _filename = "C:\Users\Public\Documents\Inventario Manuales.xlsx"
    End Sub

    Private Sub KryptonButton2_Click(sender As System.Object, e As System.EventArgs) Handles KryptonButton2.Click
        Me.Close()
    End Sub
    Private Sub LoadTable()
        Dim excel As ExcelSource = New ExcelSource(_filename)

        Me.PictureBox2.Visible = True

        Me.lvPrecontactos.Items.Clear()

        Dim dt As DataTable = excel.ReadSheet(Me.cmbHojas.Text)

        For Each r As DataRow In dt.Rows
            Dim fecha As DateTime
            Dim nombre As String = ""
            Dim telefono1 As String = ""
            Dim telefono2 As String = ""
            Dim email As String = ""
            Dim Provincia As String = ""
            Dim lugar As String = ""
            Dim Referido As String = ""
            Dim Interes As String = ""

            Try
                fecha = CType(r.Item(IndexColumn(cols.Fecha)).ToString, DateTime)
            Catch ex As Exception
                fecha = Today.Date
            End Try
            If cols.Nombre <> "" Then
                nombre = r.Item(IndexColumn(cols.Nombre)).ToString
            End If
            If cols.Telefono1 <> "" Then
                telefono1 = r.Item(IndexColumn(cols.Telefono1)).ToString
            End If
            If cols.Telefono2 <> "" Then
                telefono2 = r.Item(IndexColumn(cols.Telefono2)).ToString
            End If
            If cols.CorreoElectronico <> "" Then
                email = r.Item(IndexColumn(cols.CorreoElectronico)).ToString
            End If
            If cols.Provincia <> "" Then
                Provincia = r.Item(IndexColumn(cols.Provincia)).ToString
            End If
            If cols.Zona <> "" Then
                lugar = r.Item(IndexColumn(cols.Zona)).ToString
            End If
            If cols.ReferidoPor <> "" Then
                Referido = r.Item(IndexColumn(cols.ReferidoPor)).ToString
            End If
            If cols.Interes <> "" Then
                Interes = r.Item(IndexColumn(cols.Interes)).ToString
            End If

            Dim item As ListViewItem = New ListViewItem(fecha)
            item.SubItems.Add(nombre)
            item.SubItems.Add(telefono1)
            item.SubItems.Add(telefono2)
            item.SubItems.Add(email)
            item.SubItems.Add(Provincia)
            item.SubItems.Add(lugar)
            item.SubItems.Add(Referido)
            item.SubItems.Add(Interes)

            Me.lvPrecontactos.Items.Add(item)
        Next

        Me.PictureBox2.Visible = False

        Me.Label2.Visible = False
        Me.txtDocumento.Visible = False
        Me.Label3.Visible = False
        Me.cmbHojas.Visible = False
        Me.KryptonButton1.Visible = False
        Me.PictureBox1.Visible = False
        Me.KryptonSeparator1.Visible = False
        Me.Label1.Visible = False
        Me.PropertyGrid1.Visible = False

        Me.lvPrecontactos.Visible = True
    End Sub

    Private Sub KryptonButton3_Click(sender As System.Object, e As System.EventArgs) Handles KryptonButton3.Click
        Dim th As Thread = New Thread(AddressOf LoadTable)
        th.Start()

    End Sub
    Private Function IndexColumn(s As String) As Integer
        Return Asc(s) - 65
    End Function

    Private Sub KryptonButton1_Click(sender As System.Object, e As System.EventArgs) Handles KryptonButton1.Click

        

        OpenFileDialog1.Filter = "Documentos de Excel (*.xlsx)|*.xlsx"
        OpenFileDialog1.RestoreDirectory = True

        If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Try
                Me.txtDocumento.Text = _filename
                _filename = OpenFileDialog1.FileName
                If _filename <> String.Empty Then
                    Dim th As Thread = New Thread(AddressOf CargarSheetNames)
                    th.Start()
                End If
            Catch Ex As Exception
                MessageBox.Show("Cannot read file from disk. Original error: " & Ex.Message)
            End Try
        End If
    End Sub
    Private Sub CargarSheetNames()
        Dim exel As ExcelSource = New ExcelSource(_filename)
        Me.PictureBox1.Visible = True
        Application.DoEvents()
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = "Cargando nombres de hojas"
        Try
            For Each sheet As String In exel.Sheets
                cmbHojas.Items.Add(sheet)
            Next
            Me.KryptonHeaderGroup1.ValuesSecondary.Heading = "Nombres cargados correctamente"
        Catch ex As Exception
            Me.KryptonHeaderGroup1.ValuesSecondary.Heading = ex.Message
        End Try
        Me.PictureBox1.Visible = False
        Application.DoEvents()
    End Sub
End Class