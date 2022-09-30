Imports System.IO
Imports UserManagementLib
Imports AutoUpdaterDotNET
Public Class frmLogin
    Public Class KeyValuePair
        Public Key As String
        Public Description As String
        Public Sub New(ByVal NewValue As String, ByVal NewDescription As String)
            Key = NewValue
            Description = NewDescription
        End Sub
        Public Overrides Function ToString() As String
            Return Description
        End Function
        Public Function Value() As String
            Return Key
        End Function
    End Class
    Structure datos
        Dim Adress As String
        Dim Name As String
        Dim DataBase As String
    End Structure
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        GrbxInicio.Visible = False
        Me.GrbxConectando.Visible = True
        ConnectToMSSQL()
    End Sub
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub
    Private Sub ConnectToMSSQL()
        Dim ServerAdress As String = ""
        Dim sett As List(Of LoginSettings.ServerSettings)
        Dim i As Integer

        Me.Label2.Text = "Conectando..."
        My.Application.DoEvents()

        ServerAdress = Me.cmbServidor.SelectedItem.value
        Try

            Variables.ConnectionString = DataWarehouseLib2.ConnectionStringBroker.SetDataSourceLocation("SakifConn", ServerAdress)
            db = New SqlClient.SqlConnection()
            db.ConnectionString = Variables.ConnectionString
            Try
                db.Open()
            Catch ex As Exception
                MessageBox.Show("No se pudo establecer la conexion con el servidor [" + ex.Message + "]", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.GrbxConectando.Visible = False
                Me.GrbxInicio.Visible = True
                Exit Sub
            End Try

            'Autentificacion del usuario
            Dim au As New Authentication
            Dim currentuser As User = au.TestCredentials(Me.txtUsuario.Text, Me.txtpassword.Text)
            If au Is Nothing Then
                MessageBox.Show("Este usuario no tiene permiso para accesar el modulo de servicio al cliente", "SaC", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End
            End If

            Dim secure As AppSecurity = New AppSecurity
            currentaccesos = secure.getAccesos(currentuser.PerfilSC)

            Me.Label2.Text = "Cargando Interfaz..."
            My.Application.DoEvents()
            Reg.SaveSetting("ServicioalCliente", "Login", "User", Me.txtUsuario.Text)
            Reg.SaveSetting("ServicioalCliente", "Login", "Server", Me.cmbServidor.Text)

            Variables.Usuario = Me.txtUsuario.Text
            Variables.Password = Me.txtpassword.Text
            Variables.Ubicacion = Me.cmbServidor.Text
            Variables.IpPhoneAdress = currentuser.PhoneIpAdress

            sett = LoginSettings.GetSettings
            For i = 0 To sett.Count - 1
                If sett(i).Name.Trim = Me.cmbServidor.Text.Trim Then
                    Variables.Servidor = sett(i).Adress.Trim
                    Variables.DataBase = sett(i).DataBase.Trim
                End If
            Next
            Bootstrapper.Init()

            frmMain.frmMain_Load(Nothing, Nothing)
            Me.Hide()
            frmMain.WindowState = FormWindowState.Maximized
            frmMain.Show()
        Catch ex As Exception
            MessageBox.Show("No se pudo establecer la conexion al Servidor" + Environment.NewLine + ex.Message, "Servicioalcliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.GrbxConectando.Visible = False
            Me.GrbxInicio.Visible = True
        End Try
    End Sub
    Private Sub CloseApplication()
        Application.Exit()
    End Sub
    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer

        Dim sett As List(Of LoginSettings.ServerSettings)



        Me.lbVersion.Text = "V." + Application.ProductVersion

        Try
            AddHandler AutoUpdater.ApplicationExitEvent, AddressOf CloseApplication
            AutoUpdater.ShowSkipButton = False
            AutoUpdater.ShowRemindLaterButton = False
            AutoUpdater.ReportErrors = False
            AutoUpdater.RunUpdateAsAdmin = False
            AutoUpdater.DownloadPath = Path.Combine(Application.StartupPath, "update")
            AutoUpdater.Start("http://192.168.100.2/updates/servicioalcliente.xml")
        Catch ex As Exception

        End Try

        Try
            sett = LoginSettings.GetSettings
            For i = 0 To sett.Count - 1
                cmbServidor.Items.Add(New KeyValuePair(sett(i).Adress.Trim, sett(i).Name))
            Next
            Me.txtUsuario.Text = Reg.GetSetting("ServicioalCliente", "Login", "User")
            Me.cmbServidor.Text = Reg.GetSetting("ServicioalCliente", "Login", "Server")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        
        
    End Sub
    Private Sub cmdAgregarServidor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregarServidor.Click
        frmAgregarServidor.Show()
    End Sub

End Class
