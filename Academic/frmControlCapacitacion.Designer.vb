<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmControlCapacitacion
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
        Me.cmdAsistentes = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtNumCapacitaciones = New System.Windows.Forms.TextBox()
        Me.cmdInforme = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.KryptonButton4 = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.KryptonButton3 = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.KryptonButton2 = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.cmdEliminar = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.cmdEditar = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.KryptonButton1 = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.lvCapacitaciones = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.cmdAsistentes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdAsistentes.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmdAsistentes.Panel.SuspendLayout()
        Me.cmdAsistentes.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdAsistentes
        '
        Me.cmdAsistentes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdAsistentes.Location = New System.Drawing.Point(0, 0)
        Me.cmdAsistentes.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdAsistentes.Name = "cmdAsistentes"
        Me.cmdAsistentes.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        '
        'cmdAsistentes.Panel
        '
        Me.cmdAsistentes.Panel.Controls.Add(Me.KryptonLabel1)
        Me.cmdAsistentes.Panel.Controls.Add(Me.txtNumCapacitaciones)
        Me.cmdAsistentes.Panel.Controls.Add(Me.cmdInforme)
        Me.cmdAsistentes.Panel.Controls.Add(Me.KryptonButton4)
        Me.cmdAsistentes.Panel.Controls.Add(Me.KryptonButton3)
        Me.cmdAsistentes.Panel.Controls.Add(Me.KryptonButton2)
        Me.cmdAsistentes.Panel.Controls.Add(Me.cmdEliminar)
        Me.cmdAsistentes.Panel.Controls.Add(Me.cmdEditar)
        Me.cmdAsistentes.Panel.Controls.Add(Me.KryptonButton1)
        Me.cmdAsistentes.Panel.Controls.Add(Me.lvCapacitaciones)
        Me.cmdAsistentes.Size = New System.Drawing.Size(1147, 687)
        Me.cmdAsistentes.TabIndex = 0
        Me.cmdAsistentes.ValuesPrimary.Heading = "Control de Capacitaciones"
        Me.cmdAsistentes.ValuesPrimary.Image = Global.Academic.My.Resources.Resources.Teacher_icon
        Me.cmdAsistentes.ValuesSecondary.Heading = "Listado de Capacitaciones"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KryptonLabel1.Location = New System.Drawing.Point(904, 568)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(92, 20)
        Me.KryptonLabel1.TabIndex = 9
        Me.KryptonLabel1.Values.Text = "Capacitaciones"
        '
        'txtNumCapacitaciones
        '
        Me.txtNumCapacitaciones.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNumCapacitaciones.Location = New System.Drawing.Point(999, 567)
        Me.txtNumCapacitaciones.Name = "txtNumCapacitaciones"
        Me.txtNumCapacitaciones.ReadOnly = True
        Me.txtNumCapacitaciones.Size = New System.Drawing.Size(117, 21)
        Me.txtNumCapacitaciones.TabIndex = 8
        Me.txtNumCapacitaciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmdInforme
        '
        Me.cmdInforme.Location = New System.Drawing.Point(940, 28)
        Me.cmdInforme.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdInforme.Name = "cmdInforme"
        Me.cmdInforme.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.cmdInforme.Size = New System.Drawing.Size(53, 39)
        Me.cmdInforme.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.cmdInforme, "Imprimir Capacitacion")
        Me.cmdInforme.Values.Image = Global.Academic.My.Resources.Resources.print_icon
        Me.cmdInforme.Values.Text = ""
        '
        'KryptonButton4
        '
        Me.KryptonButton4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KryptonButton4.Location = New System.Drawing.Point(1063, 28)
        Me.KryptonButton4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.KryptonButton4.Name = "KryptonButton4"
        Me.KryptonButton4.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.KryptonButton4.Size = New System.Drawing.Size(53, 39)
        Me.KryptonButton4.TabIndex = 6
        Me.KryptonButton4.Values.Image = Global.Academic.My.Resources.Resources.logout_icon
        Me.KryptonButton4.Values.Text = ""
        '
        'KryptonButton3
        '
        Me.KryptonButton3.Location = New System.Drawing.Point(881, 28)
        Me.KryptonButton3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.KryptonButton3.Name = "KryptonButton3"
        Me.KryptonButton3.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.KryptonButton3.Size = New System.Drawing.Size(53, 39)
        Me.KryptonButton3.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.KryptonButton3, "Actualizar Lista")
        Me.KryptonButton3.Values.Image = Global.Academic.My.Resources.Resources.Refresh_icon
        Me.KryptonButton3.Values.Text = ""
        '
        'KryptonButton2
        '
        Me.KryptonButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KryptonButton2.Location = New System.Drawing.Point(999, 28)
        Me.KryptonButton2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.KryptonButton2.Name = "KryptonButton2"
        Me.KryptonButton2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.KryptonButton2.Size = New System.Drawing.Size(58, 39)
        Me.KryptonButton2.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.KryptonButton2, "Agregar Vendedores a la Capacitacion")
        Me.KryptonButton2.Values.Image = Global.Academic.My.Resources.Resources.User_Group_icon
        Me.KryptonButton2.Values.Text = ""
        '
        'cmdEliminar
        '
        Me.cmdEliminar.Location = New System.Drawing.Point(822, 28)
        Me.cmdEliminar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.cmdEliminar.Size = New System.Drawing.Size(53, 39)
        Me.cmdEliminar.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.cmdEliminar, "Eliminar Capacitacion")
        Me.cmdEliminar.Values.Image = Global.Academic.My.Resources.Resources.math_minus_icon
        Me.cmdEliminar.Values.Text = ""
        '
        'cmdEditar
        '
        Me.cmdEditar.Location = New System.Drawing.Point(763, 28)
        Me.cmdEditar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdEditar.Name = "cmdEditar"
        Me.cmdEditar.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.cmdEditar.Size = New System.Drawing.Size(53, 39)
        Me.cmdEditar.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.cmdEditar, "Editar Capacitacion")
        Me.cmdEditar.Values.Image = Global.Academic.My.Resources.Resources.pencil_icon
        Me.cmdEditar.Values.Text = ""
        '
        'KryptonButton1
        '
        Me.KryptonButton1.Location = New System.Drawing.Point(704, 28)
        Me.KryptonButton1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.KryptonButton1.Name = "KryptonButton1"
        Me.KryptonButton1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.KryptonButton1.Size = New System.Drawing.Size(53, 39)
        Me.KryptonButton1.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.KryptonButton1, "Agregar Nueva Capacitacion")
        Me.KryptonButton1.Values.Image = Global.Academic.My.Resources.Resources.add_24
        Me.KryptonButton1.Values.Text = ""
        '
        'lvCapacitaciones
        '
        Me.lvCapacitaciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvCapacitaciones.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lvCapacitaciones.FullRowSelect = True
        Me.lvCapacitaciones.GridLines = True
        Me.lvCapacitaciones.Location = New System.Drawing.Point(23, 87)
        Me.lvCapacitaciones.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lvCapacitaciones.Name = "lvCapacitaciones"
        Me.lvCapacitaciones.Size = New System.Drawing.Size(1093, 463)
        Me.lvCapacitaciones.TabIndex = 0
        Me.lvCapacitaciones.UseCompatibleStateImageBehavior = False
        Me.lvCapacitaciones.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Id"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Descricion"
        Me.ColumnHeader2.Width = 507
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "# Modulos"
        Me.ColumnHeader3.Width = 82
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'frmControlCapacitacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1147, 687)
        Me.Controls.Add(Me.cmdAsistentes)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmControlCapacitacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Capacitaciones"
        CType(Me.cmdAsistentes.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmdAsistentes.Panel.ResumeLayout(False)
        Me.cmdAsistentes.Panel.PerformLayout()
        CType(Me.cmdAsistentes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmdAsistentes.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdAsistentes As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents KryptonButton1 As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents lvCapacitaciones As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmdEditar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents cmdEliminar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents KryptonButton2 As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents KryptonButton3 As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtNumCapacitaciones As System.Windows.Forms.TextBox
    Friend WithEvents cmdInforme As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents KryptonButton4 As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

End Class
