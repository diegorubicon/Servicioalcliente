Namespace Business
    Public Class Lista
        Private _source As Lista ' Referencia al objeto de capa de acceso de datos (Linq)
        Public Sub New(source As Lista)
            If Not source Is Nothing Then
                _source = source
            Else
                _source = New Lista
            End If
        End Sub
        Public Property Precontactos As List(Of Precontacto)
            Get
                Dim temp As List(Of Precontacto) = New List(Of Precontacto)
                For Each pre As ListaItem In _source.Precontactos
                    Dim precontacto As Precontacto = New Precontacto(pre.PreContacto)

                    temp.Add(precontacto)
                Next
                Return temp
            End Get
            Set(value As List(Of Precontacto))

            End Set
        End Property
        Public Function Filter(provincia As Integer, ubicacion As String) As List(Of Precontacto)
            Dim precontactos As IEnumerable(Of PrecontactoLista) = Nothing
            Dim lst As List(Of Precontacto) = Nothing
            Try
                If ubicacion = "" Then
                    precontactos = _source.Filter(provincia)
                Else
                    precontactos = _source.Filter(provincia, ubicacion)
                End If
            Catch ex As Exception

            End Try
            If precontactos.Count > 0 Then
                lst = New List(Of Precontacto)
                For Each pre As PrecontactoLista In precontactos
                    Dim ooo As Precontacto

                    ooo = New Precontacto(Precontacto)

                    lst.Add(ooo)
                Next
            End If
            Return lst
        End Function



    End Class
End Namespace
