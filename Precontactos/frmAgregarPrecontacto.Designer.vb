<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgregarPrecontacto
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.KryptonHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup()
        Me.txtReferidoPor = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ckNoDioTelefono = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.txtInteresEspecifico = New System.Windows.Forms.TextBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.KryptonButton3 = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.KryptonButton2 = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.cmdGuardar = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.cmbEstados = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmbIntereses = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmbOrigenes = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtLugar = New System.Windows.Forms.TextBox()
        Me.txtProvincia = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtTelefono2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTelefono1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtApellido02 = New System.Windows.Forms.TextBox()
        Me.txtApellido01 = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label15 = New System.Windows.Forms.Label()
        Me.dtFechaIngreso = New System.Windows.Forms.DateTimePicker()
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup1.Panel.SuspendLayout()
        Me.KryptonHeaderGroup1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.KryptonHeaderGroup1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(577, 635)
        Me.KryptonPanel.TabIndex = 2
        '
        'KryptonHeaderGroup1
        '
        Me.KryptonHeaderGroup1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KryptonHeaderGroup1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonHeaderGroup1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.KryptonHeaderGroup1.Name = "KryptonHeaderGroup1"
        Me.KryptonHeaderGroup1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Silver
        '
        'KryptonHeaderGroup1.Panel
        '
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.dtFechaIngreso)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.Label15)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtReferidoPor)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.Label13)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.ckNoDioTelefono)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtInteresEspecifico)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.ProgressBar1)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonButton3)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonButton2)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.cmdGuardar)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.cmbEstados)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.Label12)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.cmbIntereses)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.Label11)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.cmbOrigenes)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.Label10)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.Label9)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtLugar)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtProvincia)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.Label8)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.Label7)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.Label6)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtEmail)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtTelefono2)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.Label5)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtTelefono1)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.Label4)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtApellido02)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtApellido01)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtNombre)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.Label3)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.Label2)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.Label1)
        Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(576, 632)
        Me.KryptonHeaderGroup1.TabIndex = 1
        Me.KryptonHeaderGroup1.ValuesPrimary.Heading = "Crear nuevo Pre-contacto"
        Me.KryptonHeaderGroup1.ValuesPrimary.Image = Global.TrackingContacts.My.Resources.Resources.add_user
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = "Presione F5 para guardar los datos"
        '
        'txtReferidoPor
        '
        Me.txtReferidoPor.Location = New System.Drawing.Point(152, 266)
        Me.txtReferidoPor.Name = "txtReferidoPor"
        Me.txtReferidoPor.Size = New System.Drawing.Size(274, 21)
        Me.txtReferidoPor.TabIndex = 31
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Location = New System.Drawing.Point(73, 269)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(73, 16)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "Referido por"
        '
        'ckNoDioTelefono
        '
        Me.ckNoDioTelefono.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl
        Me.ckNoDioTelefono.Location = New System.Drawing.Point(288, 126)
        Me.ckNoDioTelefono.Name = "ckNoDioTelefono"
        Me.ckNoDioTelefono.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.ckNoDioTelefono.Size = New System.Drawing.Size(112, 20)
        Me.ckNoDioTelefono.TabIndex = 29
        Me.ckNoDioTelefono.Text = "No dio Telefono"
        Me.ckNoDioTelefono.Values.Text = "No dio Telefono"
        '
        'txtInteresEspecifico
        '
        Me.txtInteresEspecifico.Location = New System.Drawing.Point(285, 461)
        Me.txtInteresEspecifico.Name = "txtInteresEspecifico"
        Me.txtInteresEspecifico.Size = New System.Drawing.Size(138, 21)
        Me.txtInteresEspecifico.TabIndex = 10
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.Location = New System.Drawing.Point(2, 563)
        Me.ProgressBar1.MarqueeAnimationSpeed = 10
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(563, 13)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.ProgressBar1.TabIndex = 28
        Me.ProgressBar1.Visible = False
        '
        'KryptonButton3
        '
        Me.KryptonButton3.Location = New System.Drawing.Point(408, 503)
        Me.KryptonButton3.Name = "KryptonButton3"
        Me.KryptonButton3.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.KryptonButton3.Size = New System.Drawing.Size(63, 54)
        Me.KryptonButton3.TabIndex = 14
        Me.KryptonButton3.Values.Image = Global.TrackingContacts.My.Resources.Resources.a
        Me.KryptonButton3.Values.Text = ""
        '
        'KryptonButton2
        '
        Me.KryptonButton2.Location = New System.Drawing.Point(339, 503)
        Me.KryptonButton2.Name = "KryptonButton2"
        Me.KryptonButton2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.KryptonButton2.Size = New System.Drawing.Size(63, 54)
        Me.KryptonButton2.TabIndex = 13
        Me.KryptonButton2.Values.Image = Global.TrackingContacts.My.Resources.Resources.d
        Me.KryptonButton2.Values.Text = ""
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Location = New System.Drawing.Point(270, 503)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.cmdGuardar.Size = New System.Drawing.Size(63, 54)
        Me.cmdGuardar.TabIndex = 12
        Me.cmdGuardar.Values.Image = Global.TrackingContacts.My.Resources.Resources.c
        Me.cmdGuardar.Values.Text = ""
        '
        'cmbEstados
        '
        Me.cmbEstados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEstados.FormattingEnabled = True
        Me.cmbEstados.ItemHeight = 16
        Me.cmbEstados.Location = New System.Drawing.Point(149, 422)
        Me.cmbEstados.Name = "cmbEstados"
        Me.cmbEstados.Size = New System.Drawing.Size(274, 24)
        Me.cmbEstados.TabIndex = 11
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(71, 425)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(31, 16)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Lista"
        '
        'cmbIntereses
        '
        Me.cmbIntereses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbIntereses.FormattingEnabled = True
        Me.cmbIntereses.ItemHeight = 16
        Me.cmbIntereses.Location = New System.Drawing.Point(149, 461)
        Me.cmbIntereses.Name = "cmbIntereses"
        Me.cmbIntereses.Size = New System.Drawing.Size(130, 24)
        Me.cmbIntereses.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Location = New System.Drawing.Point(71, 464)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(43, 16)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Interes"
        '
        'cmbOrigenes
        '
        Me.cmbOrigenes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOrigenes.FormattingEnabled = True
        Me.cmbOrigenes.ItemHeight = 16
        Me.cmbOrigenes.Location = New System.Drawing.Point(149, 383)
        Me.cmbOrigenes.Name = "cmbOrigenes"
        Me.cmbOrigenes.Size = New System.Drawing.Size(274, 24)
        Me.cmbOrigenes.TabIndex = 8
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(71, 386)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 16)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Origen"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(20, 342)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(259, 24)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Origen del Pre-contacto"
        '
        'txtLugar
        '
        Me.txtLugar.Location = New System.Drawing.Point(152, 232)
        Me.txtLugar.Name = "txtLugar"
        Me.txtLugar.Size = New System.Drawing.Size(274, 21)
        Me.txtLugar.TabIndex = 7
        '
        'txtProvincia
        '
        Me.txtProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtProvincia.FormattingEnabled = True
        Me.txtProvincia.Location = New System.Drawing.Point(152, 196)
        Me.txtProvincia.Name = "txtProvincia"
        Me.txtProvincia.Size = New System.Drawing.Size(184, 24)
        Me.txtProvincia.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(78, 235)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 16)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Lugar"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(75, 199)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 16)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Provincia"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(78, 165)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 16)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Email"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(152, 162)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(274, 21)
        Me.txtEmail.TabIndex = 5
        '
        'txtTelefono2
        '
        Me.txtTelefono2.Location = New System.Drawing.Point(152, 135)
        Me.txtTelefono2.Name = "txtTelefono2"
        Me.txtTelefono2.Size = New System.Drawing.Size(118, 21)
        Me.txtTelefono2.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(75, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Telefono 2"
        '
        'txtTelefono1
        '
        Me.txtTelefono1.Location = New System.Drawing.Point(152, 108)
        Me.txtTelefono1.Name = "txtTelefono1"
        Me.txtTelefono1.Size = New System.Drawing.Size(118, 21)
        Me.txtTelefono1.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(75, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Telefono 1"
        '
        'txtApellido02
        '
        Me.txtApellido02.Location = New System.Drawing.Point(273, 81)
        Me.txtApellido02.Name = "txtApellido02"
        Me.txtApellido02.Size = New System.Drawing.Size(150, 21)
        Me.txtApellido02.TabIndex = 2
        '
        'txtApellido01
        '
        Me.txtApellido01.Location = New System.Drawing.Point(152, 81)
        Me.txtApellido01.Name = "txtApellido01"
        Me.txtApellido01.Size = New System.Drawing.Size(118, 21)
        Me.txtApellido01.TabIndex = 1
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.SystemColors.Window
        Me.txtNombre.Location = New System.Drawing.Point(152, 54)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(274, 21)
        Me.txtNombre.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(75, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Apellidos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(71, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(20, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(406, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Informacion Personal                              "
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Info."
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Location = New System.Drawing.Point(73, 308)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(57, 16)
        Me.Label15.TabIndex = 33
        Me.Label15.Text = "F. Ingreso"
        '
        'dtFechaIngreso
        '
        Me.dtFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaIngreso.Location = New System.Drawing.Point(152, 304)
        Me.dtFechaIngreso.Name = "dtFechaIngreso"
        Me.dtFechaIngreso.Size = New System.Drawing.Size(125, 21)
        Me.dtFechaIngreso.TabIndex = 34
        '
        'frmAgregarPrecontacto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(577, 635)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "frmAgregarPrecontacto"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pre-contactos"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.Panel.ResumeLayout(False)
        Me.KryptonHeaderGroup1.Panel.PerformLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonHeaderGroup1 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents txtInteresEspecifico As System.Windows.Forms.TextBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents KryptonButton3 As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents KryptonButton2 As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents cmdGuardar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents cmbEstados As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cmbIntereses As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cmbOrigenes As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtLugar As System.Windows.Forms.TextBox
    Friend WithEvents txtProvincia As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefono2 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTelefono1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtApellido02 As System.Windows.Forms.TextBox
    Friend WithEvents txtApellido01 As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ckNoDioTelefono As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents txtReferidoPor As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents dtFechaIngreso As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label15 As System.Windows.Forms.Label
End Class
