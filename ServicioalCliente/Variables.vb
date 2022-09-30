Imports System.Text
Imports System.Security.Cryptography
Module Variables
    Public Servidor As String
    Public Usuario As String
    Public Password As String
    Public DataBase As String
    Public Ubicacion As String
    Public Compania As String
    Public IpPhoneAdress As String
    Public ContraseñaValida As Boolean
    Public ConnectionString As String
    Public ConnectionStringCRM As String = "Data Source=192.168.0.2;Initial Catalog=CRM;Persist Security Info=True;User ID=UserCRM;Password=Asd1234."
    Public db As SqlClient.SqlConnection = Nothing

    Public Pais As String


    Public currentaccesos As Accesos
    Function getMD5Hash(ByVal strToHash As String) As String
        Dim md5Obj As New Security.Cryptography.MD5CryptoServiceProvider
        Dim bytesToHash() As Byte = System.Text.Encoding.ASCII.GetBytes(strToHash)
        bytesToHash = md5Obj.ComputeHash(bytesToHash)
        Dim strResult As String = ""
        For Each b As Byte In bytesToHash
            strResult += b.ToString("x2")
        Next
        Return strResult
    End Function
    Public Function FormatMonthFirst(ByVal fecha As DateTime)
        Dim dia As String = fecha.Day.ToString
        Dim month As String = fecha.Month.ToString

        If dia.Length = 1 Then
            dia = "0" + dia
        End If
        If month.Length = 1 Then
            month = "0" + month
        End If

        Return month + "/" + dia + "/" + fecha.Year.ToString
    End Function
End Module
