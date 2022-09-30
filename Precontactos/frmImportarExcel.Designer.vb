<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImportarExcel
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
        Me.KryptonGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonGroup()
        Me.cmbHojas = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PropertyGrid1 = New System.Windows.Forms.PropertyGrid()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.KryptonSeparator1 = New ComponentFactory.Krypton.Toolkit.KryptonSeparator()
        Me.KryptonButton1 = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.txtDocumento = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.KryptonButton4 = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.KryptonButton3 = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.KryptonButton2 = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lvPrecontactos = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup1.Panel.SuspendLayout()
        Me.KryptonHeaderGroup1.SuspendLayout()
        CType(Me.KryptonGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonGroup1.Panel.SuspendLayout()
        Me.KryptonGroup1.SuspendLayout()
        CType(Me.KryptonSeparator1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonHeaderGroup1
        '
        Me.KryptonHeaderGroup1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonHeaderGroup1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.KryptonHeaderGroup1.Name = "KryptonHeaderGroup1"
        '
        'KryptonHeaderGroup1.Panel
        '
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.PictureBox2)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonButton4)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonButton3)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonButton2)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonGroup1)
        Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(626, 738)
        Me.KryptonHeaderGroup1.TabIndex = 0
        Me.KryptonHeaderGroup1.ValuesPrimary.Heading = "Importar Contactos desde Documento de Excel"
        '
        'KryptonGroup1
        '
        Me.KryptonGroup1.Location = New System.Drawing.Point(11, 17)
        Me.KryptonGroup1.Name = "KryptonGroup1"
        '
        'KryptonGroup1.Panel
        '
        Me.KryptonGroup1.Panel.Controls.Add(Me.lvPrecontactos)
        Me.KryptonGroup1.Panel.Controls.Add(Me.PictureBox1)
        Me.KryptonGroup1.Panel.Controls.Add(Me.cmbHojas)
        Me.KryptonGroup1.Panel.Controls.Add(Me.Label3)
        Me.KryptonGroup1.Panel.Controls.Add(Me.PropertyGrid1)
        Me.KryptonGroup1.Panel.Controls.Add(Me.Label1)
        Me.KryptonGroup1.Panel.Controls.Add(Me.KryptonSeparator1)
        Me.KryptonGroup1.Panel.Controls.Add(Me.KryptonButton1)
        Me.KryptonGroup1.Panel.Controls.Add(Me.txtDocumento)
        Me.KryptonGroup1.Panel.Controls.Add(Me.Label2)
        Me.KryptonGroup1.Size = New System.Drawing.Size(602, 573)
        Me.KryptonGroup1.TabIndex = 13
        '
        'cmbHojas
        '
        Me.cmbHojas.FormattingEnabled = True
        Me.cmbHojas.Location = New System.Drawing.Point(19, 88)
        Me.cmbHojas.Name = "cmbHojas"
        Me.cmbHojas.Size = New System.Drawing.Size(451, 24)
        Me.cmbHojas.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(16, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 16)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Hoja"
        '
        'PropertyGrid1
        '
        Me.PropertyGrid1.Location = New System.Drawing.Point(19, 162)
        Me.PropertyGrid1.Name = "PropertyGrid1"
        Me.PropertyGrid1.Size = New System.Drawing.Size(560, 393)
        Me.PropertyGrid1.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(16, 143)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(277, 16)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Ubicacion de los Datos en el documento de Excel"
        '
        'KryptonSeparator1
        '
        Me.KryptonSeparator1.Location = New System.Drawing.Point(19, 118)
        Me.KryptonSeparator1.Name = "KryptonSeparator1"
        Me.KryptonSeparator1.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.KryptonSeparator1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.KryptonSeparator1.Size = New System.Drawing.Size(565, 10)
        Me.KryptonSeparator1.TabIndex = 13
        '
        'KryptonButton1
        '
        Me.KryptonButton1.Location = New System.Drawing.Point(485, 24)
        Me.KryptonButton1.Name = "KryptonButton1"
        Me.KryptonButton1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.KryptonButton1.Size = New System.Drawing.Size(94, 32)
        Me.KryptonButton1.TabIndex = 12
        Me.KryptonButton1.Values.Text = "Examinar"
        '
        'txtDocumento
        '
        Me.txtDocumento.Location = New System.Drawing.Point(19, 35)
        Me.txtDocumento.Name = "txtDocumento"
        Me.txtDocumento.Size = New System.Drawing.Size(451, 21)
        Me.txtDocumento.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(16, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(336, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Ingrese la direccion del archivo de Excel que desea importar"
        '
        'KryptonButton4
        '
        Me.KryptonButton4.Enabled = False
        Me.KryptonButton4.Location = New System.Drawing.Point(261, 615)
        Me.KryptonButton4.Name = "KryptonButton4"
        Me.KryptonButton4.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.KryptonButton4.Size = New System.Drawing.Size(105, 28)
        Me.KryptonButton4.TabIndex = 12
        Me.KryptonButton4.Values.Text = "<< Anterior"
        '
        'KryptonButton3
        '
        Me.KryptonButton3.Location = New System.Drawing.Point(372, 615)
        Me.KryptonButton3.Name = "KryptonButton3"
        Me.KryptonButton3.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.KryptonButton3.Size = New System.Drawing.Size(105, 28)
        Me.KryptonButton3.TabIndex = 11
        Me.KryptonButton3.Values.Text = "Siguiente >>"
        '
        'KryptonButton2
        '
        Me.KryptonButton2.Location = New System.Drawing.Point(481, 615)
        Me.KryptonButton2.Name = "KryptonButton2"
        Me.KryptonButton2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.KryptonButton2.Size = New System.Drawing.Size(105, 28)
        Me.KryptonButton2.TabIndex = 10
        Me.KryptonButton2.Values.Text = "Terminar"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.TrackingContacts.My.Resources.Resources.loader
        Me.PictureBox1.Location = New System.Drawing.Point(485, 78)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(42, 34)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.TrackingContacts.My.Resources.Resources.loader
        Me.PictureBox2.Location = New System.Drawing.Point(213, 615)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(42, 34)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 20
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'lvPrecontactos
        '
        Me.lvPrecontactos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9})
        Me.lvPrecontactos.Location = New System.Drawing.Point(19, 162)
        Me.lvPrecontactos.Name = "lvPrecontactos"
        Me.lvPrecontactos.Size = New System.Drawing.Size(560, 393)
        Me.lvPrecontactos.TabIndex = 20
        Me.lvPrecontactos.UseCompatibleStateImageBehavior = False
        Me.lvPrecontactos.View = System.Windows.Forms.View.Details
        Me.lvPrecontactos.Visible = False
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "F. Ingreso"
        Me.ColumnHeader1.Width = 75
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nombre"
        Me.ColumnHeader2.Width = 224
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Telefono 1"
        Me.ColumnHeader3.Width = 78
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Telefono 2"
        Me.ColumnHeader4.Width = 73
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Email"
        Me.ColumnHeader5.Width = 94
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Provincia"
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Zona"
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Referido"
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Interes"
        '
        'frmImportarExcel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(628, 739)
        Me.Controls.Add(Me.KryptonHeaderGroup1)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmImportarExcel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmImportarExcel"
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.Panel.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.ResumeLayout(False)
        CType(Me.KryptonGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup1.Panel.ResumeLayout(False)
        Me.KryptonGroup1.Panel.PerformLayout()
        CType(Me.KryptonGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup1.ResumeLayout(False)
        CType(Me.KryptonSeparator1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonHeaderGroup1 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents KryptonGroup1 As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents PropertyGrid1 As System.Windows.Forms.PropertyGrid
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents KryptonSeparator1 As ComponentFactory.Krypton.Toolkit.KryptonSeparator
    Friend WithEvents KryptonButton1 As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents txtDocumento As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents KryptonButton4 As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents KryptonButton3 As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents KryptonButton2 As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents cmbHojas As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents lvPrecontactos As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
End Class
