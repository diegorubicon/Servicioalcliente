<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.OK = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.cmbServidor = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GrbxInicio = New System.Windows.Forms.GroupBox()
        Me.cmdAgregarServidor = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GrbxConectando = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbVersion = New System.Windows.Forms.Label()
        Me.GrbxInicio.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrbxConectando.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Location = New System.Drawing.Point(174, 28)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(82, 31)
        Me.UsernameLabel.TabIndex = 0
        Me.UsernameLabel.Text = "Nombre de Usuario"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Location = New System.Drawing.Point(174, 69)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(67, 23)
        Me.PasswordLabel.TabIndex = 2
        Me.PasswordLabel.Text = "Contraseña"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(262, 34)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(286, 20)
        Me.txtUsuario.TabIndex = 1
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(262, 71)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassword.Size = New System.Drawing.Size(286, 20)
        Me.txtpassword.TabIndex = 3
        '
        'OK
        '
        Me.OK.Location = New System.Drawing.Point(205, 181)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(94, 23)
        Me.OK.TabIndex = 4
        Me.OK.Text = "&OK"
        '
        'Cancel
        '
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Location = New System.Drawing.Point(305, 181)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(94, 23)
        Me.Cancel.TabIndex = 5
        Me.Cancel.Text = "&Cancel"
        '
        'cmbServidor
        '
        Me.cmbServidor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbServidor.FormattingEnabled = True
        Me.cmbServidor.Location = New System.Drawing.Point(262, 110)
        Me.cmbServidor.Name = "cmbServidor"
        Me.cmbServidor.Size = New System.Drawing.Size(258, 21)
        Me.cmbServidor.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(174, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Servidor"
        '
        'GrbxInicio
        '
        Me.GrbxInicio.BackColor = System.Drawing.Color.White
        Me.GrbxInicio.Controls.Add(Me.cmdAgregarServidor)
        Me.GrbxInicio.Controls.Add(Me.PictureBox1)
        Me.GrbxInicio.Controls.Add(Me.Label1)
        Me.GrbxInicio.Controls.Add(Me.cmbServidor)
        Me.GrbxInicio.Controls.Add(Me.txtpassword)
        Me.GrbxInicio.Controls.Add(Me.txtUsuario)
        Me.GrbxInicio.Controls.Add(Me.PasswordLabel)
        Me.GrbxInicio.Controls.Add(Me.UsernameLabel)
        Me.GrbxInicio.Location = New System.Drawing.Point(12, 12)
        Me.GrbxInicio.Name = "GrbxInicio"
        Me.GrbxInicio.Size = New System.Drawing.Size(581, 154)
        Me.GrbxInicio.TabIndex = 9
        Me.GrbxInicio.TabStop = False
        Me.GrbxInicio.Text = "Iniciar Sesion"
        '
        'cmdAgregarServidor
        '
        Me.cmdAgregarServidor.Location = New System.Drawing.Point(526, 110)
        Me.cmdAgregarServidor.Name = "cmdAgregarServidor"
        Me.cmdAgregarServidor.Size = New System.Drawing.Size(30, 21)
        Me.cmdAgregarServidor.TabIndex = 9
        Me.cmdAgregarServidor.Text = "..."
        Me.cmdAgregarServidor.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ServicioalCliente.My.Resources.Resources.sesion
        Me.PictureBox1.Location = New System.Drawing.Point(33, 34)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(108, 97)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'GrbxConectando
        '
        Me.GrbxConectando.BackColor = System.Drawing.Color.White
        Me.GrbxConectando.Controls.Add(Me.PictureBox2)
        Me.GrbxConectando.Controls.Add(Me.Label2)
        Me.GrbxConectando.Location = New System.Drawing.Point(12, 12)
        Me.GrbxConectando.Name = "GrbxConectando"
        Me.GrbxConectando.Size = New System.Drawing.Size(575, 154)
        Me.GrbxConectando.TabIndex = 10
        Me.GrbxConectando.TabStop = False
        Me.GrbxConectando.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.ServicioalCliente.My.Resources.Resources.loading
        Me.PictureBox2.Location = New System.Drawing.Point(263, 56)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Conectando...."
        '
        'lbVersion
        '
        Me.lbVersion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbVersion.AutoSize = True
        Me.lbVersion.Location = New System.Drawing.Point(553, 191)
        Me.lbVersion.Name = "lbVersion"
        Me.lbVersion.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lbVersion.Size = New System.Drawing.Size(40, 13)
        Me.lbVersion.TabIndex = 11
        Me.lbVersion.Text = "1.0.1.0"
        Me.lbVersion.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'frmLogin
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(605, 221)
        Me.Controls.Add(Me.lbVersion)
        Me.Controls.Add(Me.GrbxConectando)
        Me.Controls.Add(Me.GrbxInicio)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogin"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio de Sesion"
        Me.GrbxInicio.ResumeLayout(False)
        Me.GrbxInicio.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrbxConectando.ResumeLayout(False)
        Me.GrbxConectando.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbServidor As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GrbxInicio As System.Windows.Forms.GroupBox
    Friend WithEvents GrbxConectando As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmdAgregarServidor As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents lbVersion As Label
End Class
