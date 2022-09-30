Public Class ListasRepository
    Private db As dbDataContext = Nothing
    Public Sub New(ByRef DataManager As Data.Manager)
        db = DataManager.Source
    End Sub
    Public Function Add(descripction As String, Intereses As List(Of String)) As lista
        Dim lst As lista = New lista With {.descripcion = descripction}

        For Each Str As String In Intereses
            If Str <> "" Then
                lst.InteresTypes.Add(New InteresType With {.descripcion = Str.Trim})
            End If
        Next
        db.listas.InsertOnSubmit(lst)
        Try
            Submmit()
            Return lst
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Sub Refresh()
        db.Refresh(System.Data.Linq.RefreshMode.KeepCurrentValues)
    End Sub
    Public Function ToList() As IEnumerable(Of lista)
        Try
            Dim query = From list In db.listas
                    Select list
                    Order By list.id_lista
            Return query
        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Public Function Item(id As Integer) As lista
        Try
            Dim query = From lis In db.listas
                    Where lis.id_lista = id
                    Select lis
            If query.Count = 0 Then
                Return Nothing
            Else
                Return query.First
            End If
        Catch ex As Exception
            Throw New Exception("No se pudo obtener la lista " + ex.Message)
            Return Nothing
        End Try



    End Function

    Public Sub Submmit()
        Try
            db.SubmitChanges()
        Catch ex As Exception
            Throw New Exception("Error actualizando listas de seguimiento " + ex.Message)
        End Try
    End Sub

End Class
