<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEnvioMensajes
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
        Me.cmdEnviarSMS = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.KryptonButton3 = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.KryptonButton2 = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.ckProvincia = New System.Windows.Forms.CheckBox()
        Me.cmbLista = New System.Windows.Forms.ComboBox()
        Me.cmbProvincia = New System.Windows.Forms.ComboBox()
        Me.KryptonButton1 = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.lvPrecontactos = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonSeparator1 = New ComponentFactory.Krypton.Toolkit.KryptonSeparator()
        Me.txtUbicacion = New System.Windows.Forms.TextBox()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonButton4 = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup1.Panel.SuspendLayout()
        Me.KryptonHeaderGroup1.SuspendLayout()
        CType(Me.KryptonSeparator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonHeaderGroup1
        '
        Me.KryptonHeaderGroup1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KryptonHeaderGroup1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonHeaderGroup1.Name = "KryptonHeaderGroup1"
        '
        'KryptonHeaderGroup1.Panel
        '
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonButton4)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.cmdEnviarSMS)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonButton3)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonButton2)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.ckProvincia)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.cmbLista)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.cmbProvincia)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonButton1)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lvPrecontactos)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel4)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonSeparator1)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtUbicacion)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel3)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(874, 711)
        Me.KryptonHeaderGroup1.TabIndex = 0
        Me.KryptonHeaderGroup1.ValuesPrimary.Heading = "Envio de Mensajes"
        '
        'cmdEnviarSMS
        '
        Me.cmdEnviarSMS.Location = New System.Drawing.Point(515, 609)
        Me.cmdEnviarSMS.Name = "cmdEnviarSMS"
        Me.cmdEnviarSMS.Size = New System.Drawing.Size(110, 35)
        Me.cmdEnviarSMS.TabIndex = 15
        Me.cmdEnviarSMS.Values.Text = "Enviar SMS"
        '
        'KryptonButton3
        '
        Me.KryptonButton3.Location = New System.Drawing.Point(631, 609)
        Me.KryptonButton3.Name = "KryptonButton3"
        Me.KryptonButton3.Size = New System.Drawing.Size(110, 35)
        Me.KryptonButton3.TabIndex = 14
        Me.KryptonButton3.Values.Text = "Copiar Correos"
        '
        'KryptonButton2
        '
        Me.KryptonButton2.Location = New System.Drawing.Point(747, 609)
        Me.KryptonButton2.Name = "KryptonButton2"
        Me.KryptonButton2.Size = New System.Drawing.Size(110, 35)
        Me.KryptonButton2.TabIndex = 13
        Me.KryptonButton2.Values.Text = "Salir"
        '
        'ckProvincia
        '
        Me.ckProvincia.AutoSize = True
        Me.ckProvincia.BackColor = System.Drawing.Color.White
        Me.ckProvincia.Checked = True
        Me.ckProvincia.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckProvincia.Location = New System.Drawing.Point(395, 74)
        Me.ckProvincia.Name = "ckProvincia"
        Me.ckProvincia.Size = New System.Drawing.Size(58, 20)
        Me.ckProvincia.TabIndex = 12
        Me.ckProvincia.Text = "Todos"
        Me.ckProvincia.UseVisualStyleBackColor = False
        '
        'cmbLista
        '
        Me.cmbLista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLista.FormattingEnabled = True
        Me.cmbLista.Location = New System.Drawing.Point(168, 26)
        Me.cmbLista.Name = "cmbLista"
        Me.cmbLista.Size = New System.Drawing.Size(448, 24)
        Me.cmbLista.TabIndex = 11
        '
        'cmbProvincia
        '
        Me.cmbProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProvincia.FormattingEnabled = True
        Me.cmbProvincia.Location = New System.Drawing.Point(168, 70)
        Me.cmbProvincia.Name = "cmbProvincia"
        Me.cmbProvincia.Size = New System.Drawing.Size(221, 24)
        Me.cmbProvincia.TabIndex = 10
        '
        'KryptonButton1
        '
        Me.KryptonButton1.Location = New System.Drawing.Point(734, 113)
        Me.KryptonButton1.Name = "KryptonButton1"
        Me.KryptonButton1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.KryptonButton1.Size = New System.Drawing.Size(123, 34)
        Me.KryptonButton1.TabIndex = 9
        Me.KryptonButton1.Values.Text = "Iniciar Busqueda"
        '
        'lvPrecontactos
        '
        Me.lvPrecontactos.CheckBoxes = True
        Me.lvPrecontactos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.lvPrecontactos.GridLines = True
        Me.lvPrecontactos.Location = New System.Drawing.Point(13, 234)
        Me.lvPrecontactos.Name = "lvPrecontactos"
        Me.lvPrecontactos.Size = New System.Drawing.Size(844, 359)
        Me.lvPrecontactos.TabIndex = 8
        Me.lvPrecontactos.UseCompatibleStateImageBehavior = False
        Me.lvPrecontactos.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "id"
        Me.ColumnHeader1.Width = 64
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nombre"
        Me.ColumnHeader2.Width = 324
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Telefono #1"
        Me.ColumnHeader3.Width = 87
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Telefono #2"
        Me.ColumnHeader4.Width = 92
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Correo"
        Me.ColumnHeader5.Width = 270
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(13, 206)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(70, 20)
        Me.KryptonLabel4.TabIndex = 7
        Me.KryptonLabel4.Values.Text = "Resultados"
        '
        'KryptonSeparator1
        '
        Me.KryptonSeparator1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KryptonSeparator1.Location = New System.Drawing.Point(-1, 165)
        Me.KryptonSeparator1.Name = "KryptonSeparator1"
        Me.KryptonSeparator1.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.KryptonSeparator1.Size = New System.Drawing.Size(874, 21)
        Me.KryptonSeparator1.TabIndex = 6
        '
        'txtUbicacion
        '
        Me.txtUbicacion.Location = New System.Drawing.Point(168, 111)
        Me.txtUbicacion.Name = "txtUbicacion"
        Me.txtUbicacion.Size = New System.Drawing.Size(296, 21)
        Me.txtUbicacion.TabIndex = 5
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(13, 113)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(64, 20)
        Me.KryptonLabel3.TabIndex = 4
        Me.KryptonLabel3.Values.Text = "Ubicacion"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(13, 70)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(60, 20)
        Me.KryptonLabel2.TabIndex = 2
        Me.KryptonLabel2.Values.Text = "Provincia"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(13, 30)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(124, 20)
        Me.KryptonLabel1.TabIndex = 0
        Me.KryptonLabel1.Values.Text = "Lista de Seguimiento"
        '
        'KryptonButton4
        '
        Me.KryptonButton4.Location = New System.Drawing.Point(13, 609)
        Me.KryptonButton4.Name = "KryptonButton4"
        Me.KryptonButton4.Size = New System.Drawing.Size(124, 35)
        Me.KryptonButton4.TabIndex = 16
        Me.KryptonButton4.Values.Text = "Seleccionar Todos"
        '
        'frmEnvioMensajes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(873, 715)
        Me.Controls.Add(Me.KryptonHeaderGroup1)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmEnvioMensajes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Envio de Mensajes"
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.Panel.ResumeLayout(False)
        Me.KryptonHeaderGroup1.Panel.PerformLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.ResumeLayout(False)
        CType(Me.KryptonSeparator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonHeaderGroup1 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents KryptonButton1 As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents lvPrecontactos As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonSeparator1 As ComponentFactory.Krypton.Toolkit.KryptonSeparator
    Friend WithEvents txtUbicacion As System.Windows.Forms.TextBox
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cmbLista As System.Windows.Forms.ComboBox
    Friend WithEvents cmbProvincia As System.Windows.Forms.ComboBox
    Friend WithEvents ckProvincia As System.Windows.Forms.CheckBox
    Friend WithEvents cmdEnviarSMS As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents KryptonButton3 As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents KryptonButton2 As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents KryptonButton4 As ComponentFactory.Krypton.Toolkit.KryptonButton
End Class
