<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBusquedaByAdress
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
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.cmbDistrito = New System.Windows.Forms.ComboBox()
        Me.cmbCanton = New System.Windows.Forms.ComboBox()
        Me.cmbProvincia = New System.Windows.Forms.ComboBox()
        Me.cmdCancelar = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.cmdSeleccionar = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.cmdIniciarBusqueda = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lvClientes = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel4)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel3)
        Me.KryptonPanel.Controls.Add(Me.cmbDistrito)
        Me.KryptonPanel.Controls.Add(Me.cmbCanton)
        Me.KryptonPanel.Controls.Add(Me.cmbProvincia)
        Me.KryptonPanel.Controls.Add(Me.cmdCancelar)
        Me.KryptonPanel.Controls.Add(Me.cmdSeleccionar)
        Me.KryptonPanel.Controls.Add(Me.cmdIniciarBusqueda)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonPanel.Controls.Add(Me.lvClientes)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(593, 495)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(362, 12)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(50, 20)
        Me.KryptonLabel4.TabIndex = 11
        Me.KryptonLabel4.Values.Text = "Distrito"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(187, 12)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(50, 20)
        Me.KryptonLabel3.TabIndex = 10
        Me.KryptonLabel3.Values.Text = "Canton"
        '
        'cmbDistrito
        '
        Me.cmbDistrito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDistrito.FormattingEnabled = True
        Me.cmbDistrito.Location = New System.Drawing.Point(362, 37)
        Me.cmbDistrito.Name = "cmbDistrito"
        Me.cmbDistrito.Size = New System.Drawing.Size(169, 21)
        Me.cmbDistrito.TabIndex = 9
        '
        'cmbCanton
        '
        Me.cmbCanton.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCanton.FormattingEnabled = True
        Me.cmbCanton.Location = New System.Drawing.Point(187, 37)
        Me.cmbCanton.Name = "cmbCanton"
        Me.cmbCanton.Size = New System.Drawing.Size(169, 21)
        Me.cmbCanton.TabIndex = 8
        '
        'cmbProvincia
        '
        Me.cmbProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProvincia.FormattingEnabled = True
        Me.cmbProvincia.Location = New System.Drawing.Point(12, 37)
        Me.cmbProvincia.Name = "cmbProvincia"
        Me.cmbProvincia.Size = New System.Drawing.Size(169, 21)
        Me.cmbProvincia.TabIndex = 7
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Location = New System.Drawing.Point(299, 433)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(110, 34)
        Me.cmdCancelar.TabIndex = 6
        Me.cmdCancelar.Values.Image = Global.Clientes.My.Resources.Resources.logout_icon
        Me.cmdCancelar.Values.Text = "Cancelar"
        '
        'cmdSeleccionar
        '
        Me.cmdSeleccionar.Location = New System.Drawing.Point(183, 433)
        Me.cmdSeleccionar.Name = "cmdSeleccionar"
        Me.cmdSeleccionar.Size = New System.Drawing.Size(110, 34)
        Me.cmdSeleccionar.TabIndex = 5
        Me.cmdSeleccionar.Values.Image = Global.Clientes.My.Resources.Resources.check
        Me.cmdSeleccionar.Values.Text = "Seleccionar"
        '
        'cmdIniciarBusqueda
        '
        Me.cmdIniciarBusqueda.Location = New System.Drawing.Point(537, 27)
        Me.cmdIniciarBusqueda.Name = "cmdIniciarBusqueda"
        Me.cmdIniciarBusqueda.Size = New System.Drawing.Size(47, 41)
        Me.cmdIniciarBusqueda.TabIndex = 4
        Me.cmdIniciarBusqueda.Values.Image = Global.Clientes.My.Resources.Resources.Search_2_icon
        Me.cmdIniciarBusqueda.Values.Text = ""
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(12, 64)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(169, 20)
        Me.KryptonLabel2.TabIndex = 3
        Me.KryptonLabel2.Values.Text = "(Ingrese el codigo o nombre)"
        '
        'lvClientes
        '
        Me.lvClientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvClientes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lvClientes.FullRowSelect = True
        Me.lvClientes.Location = New System.Drawing.Point(12, 91)
        Me.lvClientes.Name = "lvClientes"
        Me.lvClientes.Size = New System.Drawing.Size(572, 317)
        Me.lvClientes.TabIndex = 2
        Me.lvClientes.UseCompatibleStateImageBehavior = False
        Me.lvClientes.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Cliente"
        Me.ColumnHeader1.Width = 101
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nombre"
        Me.ColumnHeader2.Width = 401
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(12, 12)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(60, 20)
        Me.KryptonLabel1.TabIndex = 0
        Me.KryptonLabel1.Values.Text = "Provincia"
        '
        'KryptonManager
        '
        Me.KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2010Silver
        '
        'frmBusquedaByAdress
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(593, 495)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmBusquedaByAdress"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busqueda de Clientes"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager



    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Friend WithEvents cmdCancelar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents cmdSeleccionar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents cmdIniciarBusqueda As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lvClientes As System.Windows.Forms.ListView
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cmbDistrito As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCanton As System.Windows.Forms.ComboBox
    Friend WithEvents cmbProvincia As System.Windows.Forms.ComboBox
End Class
