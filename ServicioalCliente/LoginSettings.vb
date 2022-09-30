Imports System.IO
Public Class LoginSettings
    Public Structure ServerSettings
        Dim Adress As String
        Dim DataBase As String
        Dim Name As String
    End Structure
    Private Settings As List(Of ServerSettings)
    Private FileName As String
    Public Sub AddSettings(ByVal Direccion As String, ByVal BaseDatos As String, ByVal Descripcion As String)
        Dim flujosave As New FileStream("config.sac", FileMode.OpenOrCreate, FileAccess.Write)
        Dim escribirfile As New BinaryWriter(flujosave)

        escribirfile.BaseStream.Seek(flujosave.Length, SeekOrigin.Begin) 'Posicion el cursor al final del archivo.
        escribirfile.Write(Direccion.PadRight(150))
        escribirfile.Write(BaseDatos.PadRight(150))
        escribirfile.Write(Descripcion.PadRight(150))

        escribirfile.Close()
        flujosave.Close()
    End Sub
    Shared Function GetSettings() As List(Of ServerSettings)
        Dim registro As Integer
        Dim flujoopen As New FileStream("config.sac", FileMode.OpenOrCreate, FileAccess.ReadWrite)
        Dim leerfile As New BinaryReader(flujoopen)
        Dim reg As ServerSettings

        GetSettings = New List(Of ServerSettings)
        If leerfile.PeekChar <> -1 Then 'si si existe texto
            'obtenemos total de registros
            registro = CType(Math.Ceiling(flujoopen.Length / 456), Integer)

            Dim a As Integer
            For a = 0 To registro - 1
                leerfile.BaseStream.Seek(456 * a, SeekOrigin.Begin)   '70 bytes de largo por cada registro
                reg.Adress = leerfile.ReadString.ToString.Trim
                reg.DataBase = leerfile.ReadString.ToString.Trim
                reg.Name = leerfile.ReadString.ToString.Trim
                GetSettings.Add(reg)
            Next a
        End If
        flujoopen.Close()
        flujoopen.Dispose()

    End Function

End Class
