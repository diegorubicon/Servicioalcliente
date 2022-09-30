<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPerfiles
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.cmdSalir = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmdPropiedades = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.cmdQuitar = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.cmdAgregar = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(438, 370)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.cmdAgregar)
        Me.TabPage1.Controls.Add(Me.cmdQuitar)
        Me.TabPage1.Controls.Add(Me.cmdPropiedades)
        Me.TabPage1.Controls.Add(Me.ListView1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(430, 344)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Perfiles"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.ListView1.Location = New System.Drawing.Point(9, 38)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(407, 233)
        Me.ListView1.TabIndex = 4
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(345, 388)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(87, 28)
        Me.cmdSalir.TabIndex = 1
        Me.cmdSalir.Values.Text = "Salir"
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Perfil"
        Me.ColumnHeader1.Width = 103
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Descripcion"
        Me.ColumnHeader2.Width = 294
        '
        'cmdPropiedades
        '
        Me.cmdPropiedades.Location = New System.Drawing.Point(326, 277)
        Me.cmdPropiedades.Name = "cmdPropiedades"
        Me.cmdPropiedades.Size = New System.Drawing.Size(90, 29)
        Me.cmdPropiedades.TabIndex = 5
        Me.cmdPropiedades.Values.Text = "Propiedades"
        '
        'cmdQuitar
        '
        Me.cmdQuitar.Location = New System.Drawing.Point(230, 277)
        Me.cmdQuitar.Name = "cmdQuitar"
        Me.cmdQuitar.Size = New System.Drawing.Size(90, 29)
        Me.cmdQuitar.TabIndex = 6
        Me.cmdQuitar.Values.Text = "Quitar"
        '
        'cmdAgregar
        '
        Me.cmdAgregar.Location = New System.Drawing.Point(134, 277)
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(90, 29)
        Me.cmdAgregar.TabIndex = 7
        Me.cmdAgregar.Values.Text = "Agregar"
        '
        'frmPerfiles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 446)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmPerfiles"
        Me.Text = "frmPerfiles"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents cmdAgregar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents cmdQuitar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents cmdPropiedades As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmdSalir As ComponentFactory.Krypton.Toolkit.KryptonButton
End Class
