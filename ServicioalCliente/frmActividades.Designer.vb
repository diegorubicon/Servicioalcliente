<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmActividades
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmActividades))
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbActividades = New System.Windows.Forms.ComboBox()
        Me.lvVendedores = New System.Windows.Forms.ListView()
        Me.Vendedor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lbContador = New System.Windows.Forms.Label()
        Me.cmdCerrar = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.cmdEliminar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape3, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(682, 486)
        Me.ShapeContainer1.TabIndex = 0
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape3
        '
        Me.LineShape3.BorderColor = System.Drawing.Color.White
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 12
        Me.LineShape3.X2 = 676
        Me.LineShape3.Y1 = 38
        Me.LineShape3.Y2 = 38
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.Gray
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 12
        Me.LineShape1.X2 = 676
        Me.LineShape1.Y1 = 37
        Me.LineShape1.Y2 = 37
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Actividad"
        '
        'cmbActividades
        '
        Me.cmbActividades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbActividades.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbActividades.FormattingEnabled = True
        Me.cmbActividades.Location = New System.Drawing.Point(87, 7)
        Me.cmbActividades.Name = "cmbActividades"
        Me.cmbActividades.Size = New System.Drawing.Size(431, 24)
        Me.cmbActividades.TabIndex = 2
        '
        'lvVendedores
        '
        Me.lvVendedores.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvVendedores.CheckBoxes = True
        Me.lvVendedores.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Vendedor, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lvVendedores.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lvVendedores.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvVendedores.FullRowSelect = True
        Me.lvVendedores.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvVendedores.Location = New System.Drawing.Point(16, 69)
        Me.lvVendedores.Name = "lvVendedores"
        Me.lvVendedores.Size = New System.Drawing.Size(649, 345)
        Me.lvVendedores.SmallImageList = Me.ImageList1
        Me.lvVendedores.TabIndex = 3
        Me.lvVendedores.UseCompatibleStateImageBehavior = False
        Me.lvVendedores.View = System.Windows.Forms.View.Details
        '
        'Vendedor
        '
        Me.Vendedor.Text = "Vendedor "
        Me.Vendedor.Width = 71
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Contrato"
        Me.ColumnHeader1.Width = 72
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nombre"
        Me.ColumnHeader2.Width = 348
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Telefono 1"
        Me.ColumnHeader3.Width = 83
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Telefono 2"
        Me.ColumnHeader4.Width = 69
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "blue.png")
        Me.ImageList1.Images.SetKeyName(1, "gray.png")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(257, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Lista de distribuidores asistentes a la actividad"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 464)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(682, 22)
        Me.StatusStrip1.TabIndex = 5
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lbContador
        '
        Me.lbContador.AutoSize = True
        Me.lbContador.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbContador.Location = New System.Drawing.Point(245, 426)
        Me.lbContador.Name = "lbContador"
        Me.lbContador.Size = New System.Drawing.Size(0, 16)
        Me.lbContador.TabIndex = 9
        '
        'cmdCerrar
        '
        Me.cmdCerrar.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCerrar.Location = New System.Drawing.Point(552, 423)
        Me.cmdCerrar.Name = "cmdCerrar"
        Me.cmdCerrar.Size = New System.Drawing.Size(113, 23)
        Me.cmdCerrar.TabIndex = 10
        Me.cmdCerrar.Text = "Cerrar"
        Me.cmdCerrar.UseVisualStyleBackColor = True
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'Button4
        '
        Me.Button4.Image = Global.ServicioalCliente.My.Resources.Resources.add1
        Me.Button4.Location = New System.Drawing.Point(62, 420)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(40, 26)
        Me.Button4.TabIndex = 12
        Me.ToolTip1.SetToolTip(Me.Button4, "Agregar Vendedor")
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = Global.ServicioalCliente.My.Resources.Resources.accept
        Me.Button2.Location = New System.Drawing.Point(108, 421)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(43, 25)
        Me.Button2.TabIndex = 11
        Me.ToolTip1.SetToolTip(Me.Button2, "Vendedor Asistio a la actividad")
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Image = Global.ServicioalCliente.My.Resources.Resources.printer
        Me.Button3.Location = New System.Drawing.Point(157, 421)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(43, 25)
        Me.Button3.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.Button3, "Informe de Asistencia a la actividad")
        Me.Button3.UseVisualStyleBackColor = True
        '
        'cmdEliminar
        '
        Me.cmdEliminar.Image = Global.ServicioalCliente.My.Resources.Resources.gray
        Me.cmdEliminar.Location = New System.Drawing.Point(16, 420)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(40, 26)
        Me.cmdEliminar.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.cmdEliminar, "Inactivar Distribuidor de la Actividad")
        Me.cmdEliminar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = Global.ServicioalCliente.My.Resources.Resources.viewmag
        Me.Button1.Location = New System.Drawing.Point(524, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(40, 28)
        Me.Button1.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.Button1, "Mostrar los distribuidores confirmados en la actividad")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.Location = New System.Drawing.Point(524, 466)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(141, 17)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.ProgressBar1.TabIndex = 13
        Me.ProgressBar1.Visible = False
        '
        'Button5
        '
        Me.Button5.Image = Global.ServicioalCliente.My.Resources.Resources.sms
        Me.Button5.Location = New System.Drawing.Point(206, 421)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(39, 25)
        Me.Button5.TabIndex = 14
        Me.Button5.UseVisualStyleBackColor = True
        '
        'frmActividades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(682, 486)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.cmdCerrar)
        Me.Controls.Add(Me.lbContador)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.cmdEliminar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lvVendedores)
        Me.Controls.Add(Me.cmbActividades)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.MaximizeBox = False
        Me.Name = "frmActividades"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Asistencia Actividades"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbActividades As System.Windows.Forms.ComboBox
    Friend WithEvents lvVendedores As System.Windows.Forms.ListView
    Friend WithEvents Vendedor As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cmdEliminar As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents lbContador As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents cmdCerrar As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Button5 As System.Windows.Forms.Button
End Class
