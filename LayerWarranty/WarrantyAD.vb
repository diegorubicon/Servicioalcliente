Friend Class WarrantyAD
    Inherits DataProvider.AccessData
    Public Enum TableWarranty
        waConsecutivo = 0
        waBoleta = 1
        waCliente = 2
        waNombreCliente = 3
        waCedula = 4
        waTelefono = 5
        waDireccion = 6
        waDocumento = 7
        waEstado = 8
        waObservaciones = 9
        waMontoTransporte = 10
        waInspector = 11
        waFechaEstudio = 12
        waFecha = 13
    End Enum
    Public Sub ReadByWarranty(ByVal boleta As String)
        MyBase.GetData("cambios", "cambios", "boleta = '" & boleta & "'")
    End Sub
    Public Sub ReadByClient(ByVal Cliente As String)
        MyBase.GetData("cambios", "cambios", "cliente = '" & Cliente & "'")
    End Sub
    Public Function Count()
        Return MyBase.RowCount("cambios")
    End Function
    Public Property ValueAt(ByVal Column As TableWarranty, Optional ByVal index As Integer = 1) As Object
        Get
            Return MyBase.GetValueFromRow("cambios", Map(Column), index)
        End Get
        Set(ByVal Value As Object)
            MyBase.SetValueToRow("cambios", Map(Column), Value)
        End Set
    End Property
    Private Function Map(ByRef f As TableWarranty) As String
        Select Case f
            Case TableWarranty.waConsecutivo : Return "consecutivo"
            Case TableWarranty.waBoleta : Return "boleta"
            Case TableWarranty.waCliente : Return "cliente"
            Case TableWarranty.waNombreCliente : Return "persona"
            Case TableWarranty.waCedula : Return "cedula"
            Case TableWarranty.waTelefono : Return "telefono"
            Case TableWarranty.waDireccion : Return "direccion"
            Case TableWarranty.waDocumento : Return "documento"
            Case TableWarranty.waEstado : Return "estado"
            Case TableWarranty.waObservaciones : Return "observaciones"
            Case TableWarranty.waMontoTransporte : Return "transporte"
            Case TableWarranty.waInspector : Return "usuario_cambio"
            Case TableWarranty.waFechaEstudio : Return "fecha_estudio"
            Case TableWarranty.waFecha : Return "creado_el"
            Case Else : Return ""
        End Select
    End Function
End Class
