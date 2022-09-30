Public Class OportunidadEstadoRepository
    Private db As dbDataContext = Nothing

    Public Sub New(ByRef datamanager As Data.Manager)
        db = datamanager.Source
    End Sub
    Public Sub New(ByVal datamanager As dbDataContext)
        db = datamanager
    End Sub

    Public Property Item(id_estado As Integer) As OportunidadEstado
        Get
            Dim query = From st In db.OportunidadEstados
                        Where st.estado = id_estado
                        Select st
            If query.Count > 0 Then
                Return query.First
            Else
                Return Nothing
            End If
        End Get
        Set(value As OportunidadEstado)

        End Set
    End Property

End Class
