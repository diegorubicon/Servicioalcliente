Namespace Data
    Partial Public Class Manager
        Private db As dbDataContext

        Public Sub New(CnnStr As String)
            db = New dbDataContext(CnnStr)
        End Sub

        Public ReadOnly Property Source()
            Get
                Return db
            End Get
        End Property

        Public Sub DoneChanges()
            Try
                db.SubmitChanges()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub

        Public ReadOnly Property HasChanges As Boolean
            Get
                If db.GetChangeSet.Deletes.Count > 0 _
                    Or db.GetChangeSet.Inserts.Count > 0 _
                    Or db.GetChangeSet.Updates.Count > 0 Then
                    Return True
                Else


                    Return False
                End If
            End Get
        End Property

    End Class
End Namespace



