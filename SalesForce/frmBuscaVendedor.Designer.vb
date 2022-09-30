<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscaVendedor
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
        Me.KryptonHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup()
        Me.cmdCerrar = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.cmdSeleccionar = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.cmdBuscaVendedor = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.lvVendedores = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtFiltro = New System.Windows.Forms.TextBox()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup1.Panel.SuspendLayout()
        Me.KryptonHeaderGroup1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonHeaderGroup1
        '
        Me.KryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonHeaderGroup1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonHeaderGroup1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.KryptonHeaderGroup1.Name = "KryptonHeaderGroup1"
        Me.KryptonHeaderGroup1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        '
        'KryptonHeaderGroup1.Panel
        '
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.cmdCerrar)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.cmdSeleccionar)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.cmdBuscaVendedor)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lvVendedores)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtFiltro)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(563, 555)
        Me.KryptonHeaderGroup1.TabIndex = 0
        Me.KryptonHeaderGroup1.ValuesPrimary.Heading = "Busqueda de Vendedores"
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = "Ingrese el criterio de busqueda"
        '
        'cmdCerrar
        '
        Me.cmdCerrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmdCerrar.Location = New System.Drawing.Point(283, 461)
        Me.cmdCerrar.Name = "cmdCerrar"
        Me.cmdCerrar.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.cmdCerrar.Size = New System.Drawing.Size(108, 29)
        Me.cmdCerrar.TabIndex = 5
        Me.cmdCerrar.Values.Text = "Cerrar"
        '
        'cmdSeleccionar
        '
        Me.cmdSeleccionar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmdSeleccionar.Location = New System.Drawing.Point(169, 461)
        Me.cmdSeleccionar.Name = "cmdSeleccionar"
        Me.cmdSeleccionar.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.cmdSeleccionar.Size = New System.Drawing.Size(108, 29)
        Me.cmdSeleccionar.TabIndex = 4
        Me.cmdSeleccionar.Values.Text = "Seleccionar"
        '
        'cmdBuscaVendedor
        '
        Me.cmdBuscaVendedor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdBuscaVendedor.Location = New System.Drawing.Point(487, 47)
        Me.cmdBuscaVendedor.Name = "cmdBuscaVendedor"
        Me.cmdBuscaVendedor.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.cmdBuscaVendedor.Size = New System.Drawing.Size(53, 42)
        Me.cmdBuscaVendedor.TabIndex = 3
        Me.cmdBuscaVendedor.Values.Image = Global.SalesForce.My.Resources.Resources.Search_2_icon
        Me.cmdBuscaVendedor.Values.Text = ""
        '
        'lvVendedores
        '
        Me.lvVendedores.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvVendedores.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lvVendedores.FullRowSelect = True
        Me.lvVendedores.GridLines = True
        Me.lvVendedores.Location = New System.Drawing.Point(11, 105)
        Me.lvVendedores.Name = "lvVendedores"
        Me.lvVendedores.Size = New System.Drawing.Size(539, 341)
        Me.lvVendedores.TabIndex = 2
        Me.lvVendedores.UseCompatibleStateImageBehavior = False
        Me.lvVendedores.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Id"
        Me.ColumnHeader1.Width = 98
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nombre"
        Me.ColumnHeader2.Width = 421
        '
        'txtFiltro
        '
        Me.txtFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFiltro.Location = New System.Drawing.Point(11, 56)
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.Size = New System.Drawing.Size(464, 21)
        Me.txtFiltro.TabIndex = 0
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(11, 30)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(225, 20)
        Me.KryptonLabel1.TabIndex = 0
        Me.KryptonLabel1.Values.Text = "Ingrese parte de Nombre del Vendedor"
        '
        'frmBuscaVendedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(563, 555)
        Me.Controls.Add(Me.KryptonHeaderGroup1)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmBuscaVendedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vendedores"
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.Panel.ResumeLayout(False)
        Me.KryptonHeaderGroup1.Panel.PerformLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonHeaderGroup1 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents cmdBuscaVendedor As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents lvVendedores As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtFiltro As System.Windows.Forms.TextBox
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cmdCerrar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents cmdSeleccionar As ComponentFactory.Krypton.Toolkit.KryptonButton

End Class
