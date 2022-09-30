<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCrearOportunidad
    Inherits ComponentFactory.Krypton.Toolkit.KryptonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
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
        Me.KryptonButton1 = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.txtNombreDistribuidor = New System.Windows.Forms.TextBox()
        Me.KryptonButton3 = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.KryptonButton2 = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.cmdGuardar = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.txtDistribuidor = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbDistrito = New System.Windows.Forms.ComboBox()
        Me.cmbCanton = New System.Windows.Forms.ComboBox()
        Me.cmbProvincia = New System.Windows.Forms.ComboBox()
        Me.txtIdentificacion = New System.Windows.Forms.TextBox()
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
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
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
        Me.KryptonPanel.Size = New System.Drawing.Size(640, 594)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonHeaderGroup1
        '
        Me.KryptonHeaderGroup1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KryptonHeaderGroup1.Location = New System.Drawing.Point(3, 4)
        Me.KryptonHeaderGroup1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.KryptonHeaderGroup1.Name = "KryptonHeaderGroup1"
        '
        'KryptonHeaderGroup1.Panel
        '
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonButton1)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtNombreDistribuidor)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonButton3)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonButton2)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.cmdGuardar)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtDistribuidor)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.Label11)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.Label10)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtDireccion)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.Label9)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.cmbDistrito)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.cmbCanton)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.cmbProvincia)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtIdentificacion)
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
        Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(637, 590)
        Me.KryptonHeaderGroup1.TabIndex = 0
        Me.KryptonHeaderGroup1.ValuesPrimary.Heading = "Crear Oportunidad de Venta"
        '
        'KryptonButton1
        '
        Me.KryptonButton1.Location = New System.Drawing.Point(562, 402)
        Me.KryptonButton1.Name = "KryptonButton1"
        Me.KryptonButton1.Size = New System.Drawing.Size(43, 41)
        Me.KryptonButton1.TabIndex = 40
        Me.KryptonButton1.Values.Image = Global.TrackingContacts.My.Resources.Resources.buscar
        Me.KryptonButton1.Values.Text = ""
        '
        'txtNombreDistribuidor
        '
        Me.txtNombreDistribuidor.Location = New System.Drawing.Point(285, 411)
        Me.txtNombreDistribuidor.Name = "txtNombreDistribuidor"
        Me.txtNombreDistribuidor.Size = New System.Drawing.Size(271, 21)
        Me.txtNombreDistribuidor.TabIndex = 39
        '
        'KryptonButton3
        '
        Me.KryptonButton3.Location = New System.Drawing.Point(542, 465)
        Me.KryptonButton3.Name = "KryptonButton3"
        Me.KryptonButton3.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.KryptonButton3.Size = New System.Drawing.Size(63, 54)
        Me.KryptonButton3.TabIndex = 38
        Me.KryptonButton3.Values.Image = Global.TrackingContacts.My.Resources.Resources.a
        Me.KryptonButton3.Values.Text = ""
        '
        'KryptonButton2
        '
        Me.KryptonButton2.Location = New System.Drawing.Point(473, 465)
        Me.KryptonButton2.Name = "KryptonButton2"
        Me.KryptonButton2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.KryptonButton2.Size = New System.Drawing.Size(63, 54)
        Me.KryptonButton2.TabIndex = 37
        Me.KryptonButton2.Values.Image = Global.TrackingContacts.My.Resources.Resources.d
        Me.KryptonButton2.Values.Text = ""
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Location = New System.Drawing.Point(404, 465)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.cmdGuardar.Size = New System.Drawing.Size(63, 54)
        Me.cmdGuardar.TabIndex = 36
        Me.cmdGuardar.Values.Image = Global.TrackingContacts.My.Resources.Resources.c
        Me.cmdGuardar.Values.Text = ""
        '
        'txtDistribuidor
        '
        Me.txtDistribuidor.Location = New System.Drawing.Point(175, 411)
        Me.txtDistribuidor.Name = "txtDistribuidor"
        Me.txtDistribuidor.Size = New System.Drawing.Size(104, 21)
        Me.txtDistribuidor.TabIndex = 34
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(23, 378)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(198, 24)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "Agente de Ventas"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(75, 414)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 16)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Distribuidor"
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(176, 341)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(425, 21)
        Me.txtDireccion.TabIndex = 31
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(87, 303)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 16)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Direccion"
        '
        'cmbDistrito
        '
        Me.cmbDistrito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDistrito.FormattingEnabled = True
        Me.cmbDistrito.Location = New System.Drawing.Point(464, 300)
        Me.cmbDistrito.Name = "cmbDistrito"
        Me.cmbDistrito.Size = New System.Drawing.Size(137, 24)
        Me.cmbDistrito.TabIndex = 29
        '
        'cmbCanton
        '
        Me.cmbCanton.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCanton.FormattingEnabled = True
        Me.cmbCanton.Location = New System.Drawing.Point(321, 300)
        Me.cmbCanton.Name = "cmbCanton"
        Me.cmbCanton.Size = New System.Drawing.Size(137, 24)
        Me.cmbCanton.TabIndex = 28
        '
        'cmbProvincia
        '
        Me.cmbProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProvincia.FormattingEnabled = True
        Me.cmbProvincia.Location = New System.Drawing.Point(176, 300)
        Me.cmbProvincia.Name = "cmbProvincia"
        Me.cmbProvincia.Size = New System.Drawing.Size(137, 24)
        Me.cmbProvincia.TabIndex = 27
        '
        'txtIdentificacion
        '
        Me.txtIdentificacion.BackColor = System.Drawing.SystemColors.Window
        Me.txtIdentificacion.Location = New System.Drawing.Point(178, 263)
        Me.txtIdentificacion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtIdentificacion.Name = "txtIdentificacion"
        Me.txtIdentificacion.Size = New System.Drawing.Size(139, 21)
        Me.txtIdentificacion.TabIndex = 25
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(87, 266)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 16)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Identificacion*"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(23, 224)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(235, 24)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Informacion Adicional"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(87, 188)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 16)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Email"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(178, 183)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.ReadOnly = True
        Me.txtEmail.Size = New System.Drawing.Size(319, 21)
        Me.txtEmail.TabIndex = 20
        '
        'txtTelefono2
        '
        Me.txtTelefono2.Location = New System.Drawing.Point(178, 154)
        Me.txtTelefono2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTelefono2.Name = "txtTelefono2"
        Me.txtTelefono2.ReadOnly = True
        Me.txtTelefono2.Size = New System.Drawing.Size(137, 21)
        Me.txtTelefono2.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(87, 159)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 16)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Celular"
        '
        'txtTelefono1
        '
        Me.txtTelefono1.Location = New System.Drawing.Point(178, 124)
        Me.txtTelefono1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTelefono1.Name = "txtTelefono1"
        Me.txtTelefono1.ReadOnly = True
        Me.txtTelefono1.Size = New System.Drawing.Size(137, 21)
        Me.txtTelefono1.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(87, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 16)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Habitacion"
        '
        'txtApellido02
        '
        Me.txtApellido02.Location = New System.Drawing.Point(321, 95)
        Me.txtApellido02.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtApellido02.Name = "txtApellido02"
        Me.txtApellido02.ReadOnly = True
        Me.txtApellido02.Size = New System.Drawing.Size(174, 21)
        Me.txtApellido02.TabIndex = 15
        '
        'txtApellido01
        '
        Me.txtApellido01.Location = New System.Drawing.Point(178, 95)
        Me.txtApellido01.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtApellido01.Name = "txtApellido01"
        Me.txtApellido01.ReadOnly = True
        Me.txtApellido01.Size = New System.Drawing.Size(137, 21)
        Me.txtApellido01.TabIndex = 14
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.SystemColors.Window
        Me.txtNombre.Location = New System.Drawing.Point(176, 66)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(319, 21)
        Me.txtNombre.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(87, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 16)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Apellidos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(87, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 16)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(23, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Pre-Contacto"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmCrearOportunidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 594)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCrearOportunidad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Oportunidades"
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
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager
    Public Enum Actions
        MakeNew = 1
        Update = 2
    End Enum
    Public Sub New(precontactoenlista As ListaItem, ByVal _Action As Actions)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        _pre = precontactoenlista
        action = _Action
        Dim provincias As ProvinciasRepository = New ProvinciasRepository(db)
        For Each pro In provincias.ToList
            Me.cmbProvincia.Items.Add(pro)
        Next
        Me.cmbProvincia.DisplayMember = "descripcion"

        With precontactoenlista.Contacto
            Me.txtNombre.Text = .Nombre
            Me.txtApellido01.Text = .apellido_01
            Me.txtApellido02.Text = .apellido_02
            Me.txtTelefono1.Text = .telefono_01
            Me.txtTelefono2.Text = .telefono_02
            Me.txtEmail.Text = .Email
            Me.cmbProvincia.SelectedItem = .provincia1
        End With

        If _Action = Actions.Update Then

            Dim dist = New With {.distribuidor = precontactoenlista.Oportunidad.Distribuidor1.id_distribuidor, _
                                 .nombre = precontactoenlista.Oportunidad.Distribuidor1.nombre + " " + precontactoenlista.Oportunidad.Distribuidor1.apellido_01 + " " + precontactoenlista.Oportunidad.Distribuidor1.apellido_02}

            With precontactoenlista.Oportunidad
                Me.txtIdentificacion.Text = .identificacion
                Me.cmbProvincia.SelectedItem = .ParentProvincia
                Me.cmbCanton.SelectedItem = .ParentCanton
                Me.cmbDistrito.SelectedItem = .ParentDistrito
                Me.txtDireccion.Text = .direccion
                Me.txtDistribuidor.Text = .Distribuidor1.id_distribuidor
                Me.txtNombreDistribuidor.Text = .Distribuidor1.nombre + " " + .Distribuidor1.apellido_01 + " " + .Distribuidor1.apellido_02
                Me.txtDistribuidor.Tag = .Distribuidor1
            End With
        End If


    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Friend WithEvents KryptonHeaderGroup1 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDistribuidor As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmbDistrito As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCanton As System.Windows.Forms.ComboBox
    Friend WithEvents cmbProvincia As System.Windows.Forms.ComboBox
    Friend WithEvents txtIdentificacion As System.Windows.Forms.TextBox
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
    Friend WithEvents KryptonButton3 As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents KryptonButton2 As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents cmdGuardar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents KryptonButton1 As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents txtNombreDistribuidor As System.Windows.Forms.TextBox
End Class
