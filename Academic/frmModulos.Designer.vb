<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModulos
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
        Me.cmdBuscaVendedor = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.cmdEliminarAsistente = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.cmdAgregarVendedor = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lvModulos = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.dtFecha = New System.Windows.Forms.DateTimePicker()
        Me.cmbModulos = New System.Windows.Forms.ComboBox()
        Me.txtNombreVendedor = New System.Windows.Forms.TextBox()
        Me.txtVendedor = New System.Windows.Forms.TextBox()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtNombreCapacitacion = New System.Windows.Forms.TextBox()
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
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.cmdBuscaVendedor)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.cmdEliminarAsistente)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.cmdAgregarVendedor)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel5)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel4)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lvModulos)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.dtFecha)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.cmbModulos)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtNombreVendedor)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtVendedor)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel3)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtNombreCapacitacion)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(965, 654)
        Me.KryptonHeaderGroup1.TabIndex = 0
        Me.KryptonHeaderGroup1.ValuesPrimary.Heading = "Asistencia Capacitacion"
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = "Vendedores Asistieron a capacitacion"
        '
        'cmdBuscaVendedor
        '
        Me.cmdBuscaVendedor.Location = New System.Drawing.Point(184, 126)
        Me.cmdBuscaVendedor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdBuscaVendedor.Name = "cmdBuscaVendedor"
        Me.cmdBuscaVendedor.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.cmdBuscaVendedor.Size = New System.Drawing.Size(47, 38)
        Me.cmdBuscaVendedor.TabIndex = 13
        Me.cmdBuscaVendedor.Values.Image = Global.Academic.My.Resources.Resources.search_icon2
        Me.cmdBuscaVendedor.Values.Text = ""
        '
        'cmdEliminarAsistente
        '
        Me.cmdEliminarAsistente.Location = New System.Drawing.Point(906, 188)
        Me.cmdEliminarAsistente.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdEliminarAsistente.Name = "cmdEliminarAsistente"
        Me.cmdEliminarAsistente.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.cmdEliminarAsistente.Size = New System.Drawing.Size(40, 40)
        Me.cmdEliminarAsistente.TabIndex = 12
        Me.cmdEliminarAsistente.Values.Image = Global.Academic.My.Resources.Resources.math_minus_icon__1_
        Me.cmdEliminarAsistente.Values.Text = ""
        '
        'cmdAgregarVendedor
        '
        Me.cmdAgregarVendedor.Location = New System.Drawing.Point(906, 126)
        Me.cmdAgregarVendedor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdAgregarVendedor.Name = "cmdAgregarVendedor"
        Me.cmdAgregarVendedor.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.cmdAgregarVendedor.Size = New System.Drawing.Size(40, 40)
        Me.cmdAgregarVendedor.TabIndex = 11
        Me.cmdAgregarVendedor.Values.Image = Global.Academic.My.Resources.Resources.add_16
        Me.cmdAgregarVendedor.Values.Text = ""
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(784, 111)
        Me.KryptonLabel5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(42, 20)
        Me.KryptonLabel5.TabIndex = 10
        Me.KryptonLabel5.Values.Text = "Fecha"
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(596, 110)
        Me.KryptonLabel4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(53, 20)
        Me.KryptonLabel4.TabIndex = 9
        Me.KryptonLabel4.Values.Text = "Modulo"
        '
        'lvModulos
        '
        Me.lvModulos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lvModulos.FullRowSelect = True
        Me.lvModulos.Location = New System.Drawing.Point(40, 188)
        Me.lvModulos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lvModulos.Name = "lvModulos"
        Me.lvModulos.Size = New System.Drawing.Size(860, 377)
        Me.lvModulos.TabIndex = 8
        Me.lvModulos.UseCompatibleStateImageBehavior = False
        Me.lvModulos.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Vendedor"
        Me.ColumnHeader1.Width = 145
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nombre"
        Me.ColumnHeader2.Width = 465
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Fecha"
        Me.ColumnHeader3.Width = 118
        '
        'dtFecha
        '
        Me.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFecha.Location = New System.Drawing.Point(784, 139)
        Me.dtFecha.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtFecha.Name = "dtFecha"
        Me.dtFecha.Size = New System.Drawing.Size(116, 21)
        Me.dtFecha.TabIndex = 2
        '
        'cmbModulos
        '
        Me.cmbModulos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbModulos.FormattingEnabled = True
        Me.cmbModulos.Location = New System.Drawing.Point(596, 138)
        Me.cmbModulos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbModulos.Name = "cmbModulos"
        Me.cmbModulos.Size = New System.Drawing.Size(180, 24)
        Me.cmbModulos.TabIndex = 1
        '
        'txtNombreVendedor
        '
        Me.txtNombreVendedor.Location = New System.Drawing.Point(237, 138)
        Me.txtNombreVendedor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNombreVendedor.Name = "txtNombreVendedor"
        Me.txtNombreVendedor.ReadOnly = True
        Me.txtNombreVendedor.Size = New System.Drawing.Size(353, 21)
        Me.txtNombreVendedor.TabIndex = 5
        '
        'txtVendedor
        '
        Me.txtVendedor.Location = New System.Drawing.Point(40, 138)
        Me.txtVendedor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtVendedor.Name = "txtVendedor"
        Me.txtVendedor.Size = New System.Drawing.Size(137, 21)
        Me.txtVendedor.TabIndex = 0
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(237, 110)
        Me.KryptonLabel3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(56, 20)
        Me.KryptonLabel3.TabIndex = 3
        Me.KryptonLabel3.Values.Text = "Nombre"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(40, 110)
        Me.KryptonLabel2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(64, 20)
        Me.KryptonLabel2.TabIndex = 2
        Me.KryptonLabel2.Values.Text = "Vendedor"
        '
        'txtNombreCapacitacion
        '
        Me.txtNombreCapacitacion.Location = New System.Drawing.Point(155, 34)
        Me.txtNombreCapacitacion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNombreCapacitacion.Name = "txtNombreCapacitacion"
        Me.txtNombreCapacitacion.ReadOnly = True
        Me.txtNombreCapacitacion.Size = New System.Drawing.Size(609, 21)
        Me.txtNombreCapacitacion.TabIndex = 1
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(40, 34)
        Me.KryptonLabel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(80, 20)
        Me.KryptonLabel1.TabIndex = 0
        Me.KryptonLabel1.Values.Text = "Capacitacion"
        '
        'frmModulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(965, 654)
        Me.Controls.Add(Me.KryptonHeaderGroup1)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmModulos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Capacitaciones"
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.Panel.ResumeLayout(False)
        Me.KryptonHeaderGroup1.Panel.PerformLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonHeaderGroup1 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lvModulos As System.Windows.Forms.ListView
    Friend WithEvents dtFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbModulos As System.Windows.Forms.ComboBox
    Friend WithEvents txtNombreVendedor As System.Windows.Forms.TextBox
    Friend WithEvents txtVendedor As System.Windows.Forms.TextBox
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtNombreCapacitacion As System.Windows.Forms.TextBox
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cmdAgregarVendedor As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents cmdEliminarAsistente As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmdBuscaVendedor As ComponentFactory.Krypton.Toolkit.KryptonButton
End Class
