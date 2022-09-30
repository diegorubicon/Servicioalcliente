<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBusquedaClientes
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
        Me.cmdCancelar = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.cmdSeleccionar = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.cmdIniciarBusqueda = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lvClientes = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtTextoBusqueda = New System.Windows.Forms.TextBox()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.cmdCancelar)
        Me.KryptonPanel.Controls.Add(Me.cmdSeleccionar)
        Me.KryptonPanel.Controls.Add(Me.cmdIniciarBusqueda)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonPanel.Controls.Add(Me.lvClientes)
        Me.KryptonPanel.Controls.Add(Me.txtTextoBusqueda)
        Me.KryptonPanel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(437, 495)
        Me.KryptonPanel.TabIndex = 0
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Location = New System.Drawing.Point(221, 433)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(110, 34)
        Me.cmdCancelar.TabIndex = 6
        Me.cmdCancelar.Values.Image = Global.Clientes.My.Resources.Resources.logout_icon
        Me.cmdCancelar.Values.Text = "Cancelar"
        '
        'cmdSeleccionar
        '
        Me.cmdSeleccionar.Location = New System.Drawing.Point(105, 433)
        Me.cmdSeleccionar.Name = "cmdSeleccionar"
        Me.cmdSeleccionar.Size = New System.Drawing.Size(110, 34)
        Me.cmdSeleccionar.TabIndex = 5
        Me.cmdSeleccionar.Values.Image = Global.Clientes.My.Resources.Resources.check
        Me.cmdSeleccionar.Values.Text = "Seleccionar"
        '
        'cmdIniciarBusqueda
        '
        Me.cmdIniciarBusqueda.Location = New System.Drawing.Point(378, 28)
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
        Me.lvClientes.Size = New System.Drawing.Size(413, 317)
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
        Me.ColumnHeader2.Width = 294
        '
        'txtTextoBusqueda
        '
        Me.txtTextoBusqueda.Location = New System.Drawing.Point(12, 38)
        Me.txtTextoBusqueda.Name = "txtTextoBusqueda"
        Me.txtTextoBusqueda.Size = New System.Drawing.Size(360, 22)
        Me.txtTextoBusqueda.TabIndex = 0
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(12, 12)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(64, 20)
        Me.KryptonLabel1.TabIndex = 0
        Me.KryptonLabel1.Values.Text = "Busqueda"
        '
        'KryptonManager
        '
        Me.KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2010Silver
        '
        'frmBusquedaClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 495)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmBusquedaClientes"
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
    Friend WithEvents txtTextoBusqueda As System.Windows.Forms.TextBox
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
End Class
