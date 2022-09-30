Imports TrackingContacts.Data
Public Class OportunidadesRepository
    Private db As dbDataContext = Nothing
    Public Sub New(ByRef datamanager As Data.Manager)
        db = datamanager.Source
    End Sub

    Public Function Item(idlista As Integer, idprecontacto As Integer) As Oportunida
        Dim query = From op In db.Oportunidas
                    Where op.id_lista = idlista And op.id_precontacto = idprecontacto
                    Select op
        Return query
    End Function

    Public Sub Add(NewOportunidad)
        db.Oportunidas.InsertOnSubmit(NewOportunidad)
    End Sub
    Public Sub Add(ByRef prelist As ListaItem, ByVal identificacion As String, _Provincia As provincia, canton As cantone, _distrito As distrito, direccion As String, distribuidor As Distribuidor)

        Dim estadoscierre As OportunidadEstadoRepository = New OportunidadEstadoRepository(db)
        Dim estado As OportunidadEstado = estadoscierre.Item(1)

        'Dim op As Oportunida = New Oportunida

        prelist.Oportunidad = New Oportunida
        With prelist.Oportunidad
            .identificacion = identificacion
            .ParentProvincia = _Provincia
            .ParentCanton = canton
            .ParentDistrito = _distrito
            .direccion = direccion
            .Distribuidor1 = distribuidor
            .estado = estado
            .referencia = ""
            .creado_el = Date.Today
        End With

        'db.Oportunidas.InsertOnSubmit(op)

        '
        'Actualiza el estado
        '     
        Dim statusrepo As StatusRepository = New StatusRepository(db)
        Dim st As InteresStatus = statusrepo.Item(10)

        prelist.InteresStatus = st
        prelist.notas.Add(New nota With {.fecha = Date.Today, .observacion = Date.Today.ToShortDateString + " - Oportunidad creada", _
                                         .id_EstadoActual = prelist.estado, _
                                         .id_InteresActual = prelist.interes})


    End Sub

    Public Sub Update(ByVal prelist As ListaItem, ByVal identificacion As String, _Provincia As provincia, canton As cantone, _distrito As distrito, direccion As String, distribuidor As Distribuidor)

        If prelist.Oportunidad Is Nothing Then
            prelist.Oportunidad = New Oportunida
        End If
        With prelist.Oportunidad
            If .Distribuidor1.id_distribuidor <> distribuidor.id_distribuidor Then
                '
                'Actualiza el historico de vendedores
                '
                .DistribuidorHistoricos.Add(New DistribuidorHistorico With {.distribuidor = distribuidor.id_distribuidor, .creado_el = Date.Today})
            End If
            .identificacion = identificacion
            .ParentProvincia = _Provincia
            .ParentCanton = canton
            .ParentDistrito = _distrito
            .direccion = direccion
            .Distribuidor1 = distribuidor
            .id_estado = 1
            .referencia = ""
        End With
    End Sub
    Public Sub Close(ByVal prelist As ListaItem, observacion As String, Estado As CierreEstado, referencia As String)
        With prelist.Oportunidad

            .id_estado = -1

            .cierre = New OportunidadCierre
            .cierre.observacion = observacion
            .cierre.estado = Estado
            .cierre.referencia = referencia
            .cierre.creado_el = Now.Date
        End With

    End Sub
    Public Sub Remove(ByRef op As Oportunida)
        db.Oportunidas.DeleteOnSubmit(op)
    End Sub
    Public Sub Remove(ByRef prelist As ListaItem)
        Remove(prelist.Oportunidad)

        prelist.Oportunidad = Nothing
    End Sub

    Public Sub Update()
        db.SubmitChanges()
    End Sub

End Class
