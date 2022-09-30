Option Strict Off
Option Explicit On
Public Class ZipCode
    Private data As ZipCodeAD
    Private index As Short
    Private proceso As Short
    Public Sub New()
        MyBase.New()
        data = New ZipCodeAD
        index = 1
        proceso = 0
    End Sub
    Public Sub ZipCode(Optional ByRef z As Short = 0)
        data.Read((z))
    End Sub
    Public ReadOnly Property Codigo(Optional ByVal I As Short = 0) As String
        Get
            Return ReturnStringOf(ZipCodeAD.TableZipCodeField.zcZona, I)
        End Get
    End Property
    Public ReadOnly Property Descripcion(Optional ByVal I As Short = 0) As String
        Get
            Return ReturnStringOf(ZipCodeAD.TableZipCodeField.zcDescripcion, I)
        End Get
    End Property
    Public ReadOnly Property Impuesto(Optional ByVal I As Short = 0) As Double
        Get
            Return ReturnStringOf((ZipCodeAD.TableZipCodeField.zcImpuesto), I)
        End Get
    End Property
    Private Function ReturnStringOf(ByRef f As ZipCodeAD.TableZipCodeField, Optional ByRef I As Short = 0) As Object
        Dim j As Short
        If data.Count > 0 Then
            If I = 1 Then
                data.GetFirstRow()
                index = 1
            End If
            If (I = index) Or (I = 0) Then
                Return data.ValueAt(f)
            Else
                For j = index To I - 1
                    data.GetNextRow()
                Next j
                index = I
                Return data.ValueAt(f)
            End If
        Else
            Return ""
        End If
    End Function
    Public Sub FillDataCombo(ByRef cmb As ComboBox)
        data.Read()
        cmb.DataSource = data.Source
        cmb.DisplayMember = "descripcion"
    End Sub
    Public Function Count() As Short
        Count = data.Count
    End Function
    Public Sub SetDataBaseLogon(ByRef User As String, ByRef Password As String, Optional ByRef server As String = "Sakif")
        data.Usuario = User
        data.Password = Password
        data.Servidor = server
    End Sub
    Protected Overrides Sub Finalize()
        data = Nothing
        MyBase.Finalize()
    End Sub
End Class