Public Class Init
    Public Sub New(ConnectionString As String, usuario As String)
        Variables.db = New Data.Manager(ConnectionString)
        Variables.ConnectionString = ConnectionString
    End Sub
    Public Sub Start()
        Dim frm As frmPrecontactos = New frmPrecontactos

        frm.Show()
    End Sub
End Class
