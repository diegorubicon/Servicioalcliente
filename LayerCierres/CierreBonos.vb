Public Class CierreBonos
    Private data As CierreBonosAD
    Private cod_cierre As Integer
    Public Sub New()
        data = New CierreBonosAD
    End Sub
    Public Sub New(ByVal Cierre As Integer, ByRef cnn As SqlClient.SqlConnection)
        data = New CierreBonosAD
        cod_cierre = Cierre
        data.Connection(cnn)
    End Sub
    Public Sub SetCierre(ByVal cierre As Integer)
        cod_cierre = cierre
    End Sub
    Public Sub SetConnection(ByRef cnn As SqlClient.SqlConnection)
        data.Connection(cnn)
    End Sub
    Public Sub GetInformation()
        data.Read(cod_cierre)
    End Sub
    Public Property Codigo(Optional ByVal i As Short = 1) As Integer
        Get
            Return cod_cierre
        End Get
        Set(ByVal value As Integer)
        End Set
    End Property
    Public Property Descripcion(Optional ByVal i As Short = 1) As String
        Get
            Dim f1 As DateTime
            If data.Count > 0 Then
                f1 = data.ValueAt(CierreBonosAD.TableCierreBonos.FechaInicio, i)
                Select Case f1.Month
                    Case 1 : Return "Enero " + f1.Year.ToString
                    Case 2 : Return "Febrero " + f1.Year.ToString
                    Case 3 : Return "Marzo " + f1.Year.ToString
                    Case 4 : Return "Abril " + f1.Year.ToString
                    Case 5 : Return "Mayo " + f1.Year.ToString
                    Case 6 : Return "Junio " + f1.Year.ToString
                    Case 7 : Return "Julio " + f1.Year.ToString
                    Case 8 : Return "Agosto " + f1.Year.ToString
                    Case 9 : Return "Setiembre " + f1.Year.ToString
                    Case 10 : Return "Octubre " + f1.Year.ToString
                    Case 11 : Return "Noviembre " + f1.Year.ToString
                    Case 12 : Return "Diciembre " + f1.Year.ToString
                    Case Else : Return ""
                End Select
            Else
                If cod_cierre = 0 Then
                    Return ("")
                Else
                    Return ("Actual")
                End If
            End If

        End Get
        Set(ByVal value As String)
        End Set
    End Property

End Class
