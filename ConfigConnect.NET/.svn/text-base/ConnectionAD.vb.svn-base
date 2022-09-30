Option Strict Off
Option Explicit On
Imports System.Data.SqlClient
Public Class ConnectionAD
    Private User As String
    Private Pass As String
    Private server As String
    Private t As Short
    Private WithEvents db As SqlConnection
    Public Event OnConnectionLost()
    Public Event OnConnectionFail(ByRef Ex As Exception)
    Public Event OnConnectionEstablished(ByRef db As SqlConnection)
    Public WriteOnly Property Usuario() As String
        Set(ByVal Value As String)
            User = Value
        End Set
    End Property
    Public WriteOnly Property Servidor() As String
        Set(ByVal Value As String)
            server = Value
        End Set
    End Property
    Public WriteOnly Property Password() As String
        Set(ByVal Value As String)
            Pass = Value
        End Set
    End Property
    Public ReadOnly Property Source() As ADODB.Connection
        Get
            Source = db
        End Get
    End Property
    Public Sub OpenConnection()
        Try
            Select Case t
                Case 1
                    db = New SqlConnection("Data Source=" & server & ";" & "Initial Catalog=Sakif;" & "User Id=" & User & ";" & "Password= " & Pass & " ;")
                Case 2
                    db = New SqlConnection("Provider=sqloledb;Data Source=" & server & ",1433;Network Library=DBMSSOCN;Initial Catalog=Sakif;User ID=" & User & ";Password=" & Pass & ";")
            End Select
            RaiseEvent OnConnectionEstablished(db)
        Catch ex As Exception
            RaiseEvent OnConnectionFail(ex)
        End Try
    End Sub
    Public Sub CloseConnection()
        On Error Resume Next
        db.Close()
        db.Dispose()
    End Sub
    Public Sub New()
        server = ""
        t = 1
        User = ""
        Pass = ""
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
        db.Dispose()
    End Sub
End Class