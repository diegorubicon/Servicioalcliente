Imports TrackingContacts.Data
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmObservaciones
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
        Me.txtInteresEspecifico = New System.Windows.Forms.TextBox()
        Me.txtTelefono02 = New System.Windows.Forms.TextBox()
        Me.txtTelefono01 = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.KryptonButton3 = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.cmdGuardar = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.cmbIntereses = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtObservacion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtObservaciones = New ComponentFactory.Krypton.Toolkit.KryptonRichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.KryptonManager1 = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.KryptonPanel.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue
        Me.KryptonPanel.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.FormMain
        Me.KryptonPanel.Size = New System.Drawing.Size(663, 572)
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
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtInteresEspecifico)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtTelefono02)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtTelefono01)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtNombre)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.Label8)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.Label7)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.Label6)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonButton3)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.cmdGuardar)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.cmbEstado)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.cmbIntereses)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.Label5)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.Label4)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtObservacion)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.Label3)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtObservaciones)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.Label2)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.Label1)
        Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(659, 564)
        Me.KryptonHeaderGroup1.TabIndex = 0
        Me.KryptonHeaderGroup1.ValuesPrimary.Heading = "Bitacora de Seguimiento"
        '
        'txtInteresEspecifico
        '
        Me.txtInteresEspecifico.Location = New System.Drawing.Point(336, 357)
        Me.txtInteresEspecifico.Name = "txtInteresEspecifico"
        Me.txtInteresEspecifico.Size = New System.Drawing.Size(166, 21)
        Me.txtInteresEspecifico.TabIndex = 2
        '
        'txtTelefono02
        '
        Me.txtTelefono02.Location = New System.Drawing.Point(238, 226)
        Me.txtTelefono02.Name = "txtTelefono02"
        Me.txtTelefono02.ReadOnly = True
        Me.txtTelefono02.Size = New System.Drawing.Size(104, 21)
        Me.txtTelefono02.TabIndex = 19
        '
        'txtTelefono01
        '
        Me.txtTelefono01.Location = New System.Drawing.Point(128, 226)
        Me.txtTelefono01.Name = "txtTelefono01"
        Me.txtTelefono01.ReadOnly = True
        Me.txtTelefono01.Size = New System.Drawing.Size(104, 21)
        Me.txtTelefono01.TabIndex = 18
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(128, 197)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(385, 21)
        Me.txtNombre.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(28, 229)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 16)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Telefonos"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(28, 200)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 16)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Nombre"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(25, 152)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(146, 24)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Pre-contacto"
        '
        'KryptonButton3
        '
        Me.KryptonButton3.Location = New System.Drawing.Point(559, 438)
        Me.KryptonButton3.Name = "KryptonButton3"
        Me.KryptonButton3.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.KryptonButton3.Size = New System.Drawing.Size(53, 52)
        Me.KryptonButton3.TabIndex = 6
        Me.KryptonButton3.Values.Image = Global.TrackingContacts.My.Resources.Resources.a
        Me.KryptonButton3.Values.Text = ""
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Location = New System.Drawing.Point(495, 438)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.cmdGuardar.Size = New System.Drawing.Size(58, 52)
        Me.cmdGuardar.TabIndex = 4
        Me.cmdGuardar.Values.Image = Global.TrackingContacts.My.Resources.Resources.c
        Me.cmdGuardar.Values.Text = ""
        '
        'cmbEstado
        '
        Me.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Location = New System.Drawing.Point(117, 396)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(241, 24)
        Me.cmbEstado.TabIndex = 3
        '
        'cmbIntereses
        '
        Me.cmbIntereses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbIntereses.FormattingEnabled = True
        Me.cmbIntereses.Location = New System.Drawing.Point(117, 357)
        Me.cmbIntereses.Name = "cmbIntereses"
        Me.cmbIntereses.Size = New System.Drawing.Size(213, 24)
        Me.cmbIntereses.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(18, 399)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Estado"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(18, 360)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Interes"
        '
        'txtObservacion
        '
        Me.txtObservacion.Location = New System.Drawing.Point(117, 321)
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Size = New System.Drawing.Size(385, 21)
        Me.txtObservacion.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(18, 324)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Observacion"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(25, 49)
        Me.txtObservaciones.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.ReadOnly = True
        Me.txtObservaciones.Size = New System.Drawing.Size(610, 99)
        Me.txtObservaciones.StateCommon.Content.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.StateNormal.Content.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.TabIndex = 4
        Me.txtObservaciones.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(24, 264)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(230, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Agregar Observacion"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(25, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Observaciones"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmObservaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(663, 572)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmObservaciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Observaciones"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonHeaderGroup1.Panel.ResumeLayout(False)
        Me.KryptonHeaderGroup1.Panel.PerformLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel

    Public Sub New(ByRef _miembroSelected As ListaItem)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.       

        Dim _Estado As StatusRepository = New StatusRepository(db)
        For Each st As InteresStatus In _Estado.ToList
            Me.cmbEstado.Items.Add(st)
        Next
        Me.cmbEstado.DisplayMember = "descripcion"
        Me.cmbEstado.ValueMember = "estado"



        _miembro = _miembroSelected

        If Not _miembro Is Nothing Then

            For Each i As InteresType In _miembro.list.InteresTypes
                Me.cmbIntereses.Items.Add(i)
            Next
            Me.cmbIntereses.DisplayMember = "descripcion"
            Me.cmbIntereses.ValueMember = "interes"

            Me.txtNombre.Text = _miembro.Contacto.Nombre + " " + _miembro.Contacto.apellido_01 + " " + _miembro.Contacto.apellido_02
            Me.txtTelefono01.Text = _miembro.Contacto.telefono_01
            Me.txtTelefono02.Text = _miembro.Contacto.telefono_02

            Me.cmbIntereses.SelectedItem = _miembro.InteresType
            Me.cmbEstado.SelectedItem = _miembro.InteresStatus
            Me.txtInteresEspecifico.Text = _miembro.interes_especifico

            If _miembro.estado = 10 Then
                'El precontacto ya se movio a oportunidad, no se permiete el cambio de estado
                Me.cmbEstado.Enabled = False
                Me.cmbIntereses.Enabled = False
                Me.txtInteresEspecifico.Enabled = False
            End If
            For Each nota In _miembro.notas

                Me.txtObservaciones.Text += CType(nota.fecha, DateTime).ToShortDateString + "-" + nota.observacion + ". "
            Next

        End If
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Friend WithEvents KryptonHeaderGroup1 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTelefono01 As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents KryptonButton3 As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents cmdGuardar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents cmbEstado As System.Windows.Forms.ComboBox
    Friend WithEvents cmbIntereses As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtObservacion As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtObservaciones As ComponentFactory.Krypton.Toolkit.KryptonRichTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTelefono02 As System.Windows.Forms.TextBox
    Friend WithEvents KryptonManager1 As ComponentFactory.Krypton.Toolkit.KryptonManager
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents txtInteresEspecifico As System.Windows.Forms.TextBox
End Class
