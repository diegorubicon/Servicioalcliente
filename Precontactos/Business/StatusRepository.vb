Imports TrackingContacts.Data
Public Class StatusRepository
    Private db As dbDataContext

    Public Sub New(ByRef DataManager As Data.Manager)
        db = DataManager.Source
    End Sub
    Public Sub New(ByRef DataSource As dbDataContext)
        db = DataSource
    End Sub

    Public Function ToList()
        Dim query = From st In db.InteresStatus
                    Select st
                    Order By st.estado Ascending
        Return query

    End Function

    Public Property Item(id As Integer) As InteresStatus
        Get
            Dim query = From st In db.InteresStatus
                Where st.estado = id
                Select st
            If query.Count = 0 Then
                Return Nothing
            Else
                Return query.First
            End If
        End Get
        Set(value As InteresStatus)

        End Set
    End Property
End Class
