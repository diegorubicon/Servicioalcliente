<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarVendedor
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
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lvDistribuidores = New System.Windows.Forms.ListView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmdSeleccionar = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.cmdSalir = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.KryptonButton1 = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.SuspendLayout()
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(13, 39)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(465, 21)
        Me.txtNombre.TabIndex = 0
        '
        'lvDistribuidores
        '
        Me.lvDistribuidores.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lvDistribuidores.Location = New System.Drawing.Point(16, 90)
        Me.lvDistribuidores.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lvDistribuidores.Name = "lvDistribuidores"
        Me.lvDistribuidores.Size = New System.Drawing.Size(511, 354)
        Me.lvDistribuidores.TabIndex = 1
        Me.lvDistribuidores.UseCompatibleStateImageBehavior = False
        Me.lvDistribuidores.View = System.Windows.Forms.View.Details
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nombre"
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Distribuidor"
        Me.ColumnHeader1.Width = 107
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nombre"
        Me.ColumnHeader2.Width = 306
        '
        'cmdSeleccionar
        '
        Me.cmdSeleccionar.Location = New System.Drawing.Point(127, 470)
        Me.cmdSeleccionar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdSeleccionar.Name = "cmdSeleccionar"
        Me.cmdSeleccionar.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Silver
        Me.cmdSeleccionar.Size = New System.Drawing.Size(136, 42)
        Me.cmdSeleccionar.TabIndex = 3
        Me.cmdSeleccionar.Values.Text = "Seleccionar"
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(271, 470)
        Me.cmdSalir.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Silver
        Me.cmdSalir.Size = New System.Drawing.Size(136, 42)
        Me.cmdSalir.TabIndex = 4
        Me.cmdSalir.Values.Text = "Salir"
        '
        'KryptonButton1
        '
        Me.KryptonButton1.Location = New System.Drawing.Point(484, 28)
        Me.KryptonButton1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.KryptonButton1.Name = "KryptonButton1"
        Me.KryptonButton1.Size = New System.Drawing.Size(38, 41)
        Me.KryptonButton1.TabIndex = 5
        Me.KryptonButton1.Values.Image = Global.TrackingContacts.My.Resources.Resources.buscar
        Me.KryptonButton1.Values.Text = ""
        '
        'frmBuscarVendedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 527)
        Me.ControlBox = False
        Me.Controls.Add(Me.KryptonButton1)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdSeleccionar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lvDistribuidores)
        Me.Controls.Add(Me.txtNombre)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmBuscarVendedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar Vendedor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lvDistribuidores As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdSeleccionar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents cmdSalir As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents KryptonButton1 As ComponentFactory.Krypton.Toolkit.KryptonButton
End Class
