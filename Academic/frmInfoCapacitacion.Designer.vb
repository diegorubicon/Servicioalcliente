<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInfoCapacitacion
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
        Me.KryptonHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup()
        Me.KryptonButton6 = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.cmdGuardarInfo = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.KryptonGroupBox1 = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
        Me.cmdBajarNivel = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.cmdSubirNivel = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.cmdEliminarModulo = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.cmdAgregarModulo = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.lvModulos = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtDescripcionModulo = New System.Windows.Forms.TextBox()
        Me.txtNombreModulo = New System.Windows.Forms.TextBox()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup1.Panel.SuspendLayout()
        Me.KryptonHeaderGroup1.SuspendLayout()
        CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonGroupBox1.Panel.SuspendLayout()
        Me.KryptonGroupBox1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonButton6)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.cmdGuardarInfo)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtNombre)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonGroupBox1)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(771, 572)
        Me.KryptonHeaderGroup1.TabIndex = 0
        Me.KryptonHeaderGroup1.ValuesPrimary.Heading = "Inf. Capacitacion"
        '
        'KryptonButton6
        '
        Me.KryptonButton6.Location = New System.Drawing.Point(695, 464)
        Me.KryptonButton6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.KryptonButton6.Name = "KryptonButton6"
        Me.KryptonButton6.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.KryptonButton6.Size = New System.Drawing.Size(53, 39)
        Me.KryptonButton6.TabIndex = 4
        Me.KryptonButton6.Values.Image = Global.Academic.My.Resources.Resources.logout_icon
        Me.KryptonButton6.Values.Text = ""
        '
        'cmdGuardarInfo
        '
        Me.cmdGuardarInfo.Location = New System.Drawing.Point(636, 464)
        Me.cmdGuardarInfo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdGuardarInfo.Name = "cmdGuardarInfo"
        Me.cmdGuardarInfo.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.cmdGuardarInfo.Size = New System.Drawing.Size(53, 39)
        Me.cmdGuardarInfo.TabIndex = 3
        Me.cmdGuardarInfo.Values.Image = Global.Academic.My.Resources.Resources.Save_icon
        Me.cmdGuardarInfo.Values.Text = ""
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(103, 27)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(577, 21)
        Me.txtNombre.TabIndex = 0
        '
        'KryptonGroupBox1
        '
        Me.KryptonGroupBox1.Location = New System.Drawing.Point(20, 58)
        Me.KryptonGroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.KryptonGroupBox1.Name = "KryptonGroupBox1"
        Me.KryptonGroupBox1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        '
        'KryptonGroupBox1.Panel
        '
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.cmdBajarNivel)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.cmdSubirNivel)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.cmdEliminarModulo)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.cmdAgregarModulo)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.lvModulos)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtDescripcionModulo)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.txtNombreModulo)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel3)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonGroupBox1.Size = New System.Drawing.Size(727, 387)
        Me.KryptonGroupBox1.TabIndex = 1
        Me.KryptonGroupBox1.Text = "Modulos"
        Me.KryptonGroupBox1.Values.Heading = "Modulos"
        '
        'cmdBajarNivel
        '
        Me.cmdBajarNivel.Location = New System.Drawing.Point(662, 181)
        Me.cmdBajarNivel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdBajarNivel.Name = "cmdBajarNivel"
        Me.cmdBajarNivel.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.cmdBajarNivel.Size = New System.Drawing.Size(40, 38)
        Me.cmdBajarNivel.TabIndex = 8
        Me.cmdBajarNivel.Values.Image = Global.Academic.My.Resources.Resources.arrow_down_icon
        Me.cmdBajarNivel.Values.Text = ""
        '
        'cmdSubirNivel
        '
        Me.cmdSubirNivel.Location = New System.Drawing.Point(662, 135)
        Me.cmdSubirNivel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdSubirNivel.Name = "cmdSubirNivel"
        Me.cmdSubirNivel.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.cmdSubirNivel.Size = New System.Drawing.Size(40, 38)
        Me.cmdSubirNivel.TabIndex = 7
        Me.cmdSubirNivel.Values.Image = Global.Academic.My.Resources.Resources.arrow_up_icon
        Me.cmdSubirNivel.Values.Text = ""
        '
        'cmdEliminarModulo
        '
        Me.cmdEliminarModulo.Location = New System.Drawing.Point(662, 89)
        Me.cmdEliminarModulo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdEliminarModulo.Name = "cmdEliminarModulo"
        Me.cmdEliminarModulo.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.cmdEliminarModulo.Size = New System.Drawing.Size(40, 38)
        Me.cmdEliminarModulo.TabIndex = 6
        Me.cmdEliminarModulo.Values.Image = Global.Academic.My.Resources.Resources.math_minus_icon__1_
        Me.cmdEliminarModulo.Values.Text = ""
        '
        'cmdAgregarModulo
        '
        Me.cmdAgregarModulo.Location = New System.Drawing.Point(662, 32)
        Me.cmdAgregarModulo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdAgregarModulo.Name = "cmdAgregarModulo"
        Me.cmdAgregarModulo.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.cmdAgregarModulo.Size = New System.Drawing.Size(40, 38)
        Me.cmdAgregarModulo.TabIndex = 5
        Me.cmdAgregarModulo.Values.Image = Global.Academic.My.Resources.Resources.add_16
        Me.cmdAgregarModulo.Values.Text = ""
        '
        'lvModulos
        '
        Me.lvModulos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lvModulos.FullRowSelect = True
        Me.lvModulos.Location = New System.Drawing.Point(17, 61)
        Me.lvModulos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lvModulos.Name = "lvModulos"
        Me.lvModulos.Size = New System.Drawing.Size(629, 282)
        Me.lvModulos.TabIndex = 4
        Me.lvModulos.UseCompatibleStateImageBehavior = False
        Me.lvModulos.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Nombre"
        Me.ColumnHeader1.Width = 204
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Descripcion"
        Me.ColumnHeader2.Width = 320
        '
        'txtDescripcionModulo
        '
        Me.txtDescripcionModulo.Location = New System.Drawing.Point(263, 32)
        Me.txtDescripcionModulo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDescripcionModulo.Name = "txtDescripcionModulo"
        Me.txtDescripcionModulo.Size = New System.Drawing.Size(382, 21)
        Me.txtDescripcionModulo.TabIndex = 2
        '
        'txtNombreModulo
        '
        Me.txtNombreModulo.Location = New System.Drawing.Point(17, 32)
        Me.txtNombreModulo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNombreModulo.Name = "txtNombreModulo"
        Me.txtNombreModulo.Size = New System.Drawing.Size(240, 21)
        Me.txtNombreModulo.TabIndex = 1
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(265, 4)
        Me.KryptonLabel3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(74, 20)
        Me.KryptonLabel3.TabIndex = 1
        Me.KryptonLabel3.Values.Text = "Descripcion"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(17, 4)
        Me.KryptonLabel2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(56, 20)
        Me.KryptonLabel2.TabIndex = 0
        Me.KryptonLabel2.Values.Text = "Nombre"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(30, 30)
        Me.KryptonLabel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(56, 20)
        Me.KryptonLabel1.TabIndex = 0
        Me.KryptonLabel1.Values.Text = "Nombre"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmInfoCapacitacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(771, 572)
        Me.Controls.Add(Me.KryptonHeaderGroup1)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmInfoCapacitacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Capacitaciones"
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.Panel.ResumeLayout(False)
        Me.KryptonHeaderGroup1.Panel.PerformLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.ResumeLayout(False)
        CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroupBox1.Panel.ResumeLayout(False)
        Me.KryptonGroupBox1.Panel.PerformLayout()
        CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroupBox1.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonHeaderGroup1 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents KryptonButton6 As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents cmdGuardarInfo As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents KryptonGroupBox1 As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
    Friend WithEvents cmdBajarNivel As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents cmdSubirNivel As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents cmdEliminarModulo As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents cmdAgregarModulo As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents lvModulos As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtDescripcionModulo As System.Windows.Forms.TextBox
    Friend WithEvents txtNombreModulo As System.Windows.Forms.TextBox
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
