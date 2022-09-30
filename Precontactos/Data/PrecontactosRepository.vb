Imports TrackingContacts.Data
Public Class PrecontactosRepository
    Private db As dbDataContext = Nothing

    Public Sub New(ByRef DataManager As Data.Manager)
        db = DataManager.Source
    End Sub
    Public Function ToList() As IEnumerable(Of Contacto)
        Dim query = From p In db.Contactos
                    Select p
        Return query
    End Function
    Public Function ToView() As IEnumerable
        Dim query = From p In db.Contactos
                    Select New With {
                                    .ID = p.ID,
                                    .Nombre = p.Nombre + " " + p.apellido_01 + " " + p.apellido_02,
                                    .Telefono01 = p.telefono_01,
                                    .Telefono02 = p.telefono_02,
                                    .Email = p.Email,
                                    .Origen = p.Origen1.descripcion,
                                    .Provincia = p.provincia1.descripcion,
                                    .Lugar = p.lugar
                                    }
        Return query
    End Function
    Public Sub Add(_NewPrecontact As Contacto)
        db.Contactos.InsertOnSubmit(_NewPrecontact)
    End Sub
    Public Function Item(ID As Integer) As Contacto
        Try
            Dim query = From p In db.Contactos
                    Where p.ID = ID
                    Select p
            If query.Count > 0 Then
                Return query.First
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Function item(Nombre As String, Apellido As String, telefono As String)
        Try
            Dim query = From p In db.Contactos
                        Where p.Nombre = Nombre And p.apellido_01 = Apellido And (p.telefono_01 = telefono Or p.telefono_02 = telefono)
                        Select p
            If query.Count > 0 Then
                Return query.First
            Else
                Return Nothing
            End If
        Catch ex As Exception

            Return Nothing

        End Try


    End Function

End Class
