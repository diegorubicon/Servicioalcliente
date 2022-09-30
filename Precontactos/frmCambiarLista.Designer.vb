Imports TrackingContacts.Data
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCambiarLista
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
        Me.KryptonHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbLista = New System.Windows.Forms.ComboBox()
        Me.KryptonButton2 = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.KryptonButton1 = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.lvListas = New System.Windows.Forms.ListView()
        Me.Lista = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.KryptonButton3 = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup1.Panel.SuspendLayout()
        Me.KryptonHeaderGroup1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.KryptonHeaderGroup1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(591, 521)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonHeaderGroup1
        '
        Me.KryptonHeaderGroup1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KryptonHeaderGroup1.Location = New System.Drawing.Point(3, 0)
        Me.KryptonHeaderGroup1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.KryptonHeaderGroup1.Name = "KryptonHeaderGroup1"
        '
        'KryptonHeaderGroup1.Panel
        '
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.Label3)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.cmbLista)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonButton2)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonButton1)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.lvListas)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonButton3)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.txtNombre)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.Label4)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.Label2)
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.Label1)
        Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(588, 521)
        Me.KryptonHeaderGroup1.TabIndex = 0
        Me.KryptonHeaderGroup1.ValuesPrimary.Heading = "Administracion de Listas"
        Me.KryptonHeaderGroup1.ValuesSecondary.Heading = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(71, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 16)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Nombre"
        '
        'cmbLista
        '
        Me.cmbLista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLista.FormattingEnabled = True
        Me.cmbLista.Location = New System.Drawing.Point(160, 139)
        Me.cmbLista.Name = "cmbLista"
        Me.cmbLista.Size = New System.Drawing.Size(290, 24)
        Me.cmbLista.TabIndex = 20
        '
        'KryptonButton2
        '
        Me.KryptonButton2.Location = New System.Drawing.Point(454, 348)
        Me.KryptonButton2.Name = "KryptonButton2"
        Me.KryptonButton2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.KryptonButton2.Size = New System.Drawing.Size(41, 27)
        Me.KryptonButton2.TabIndex = 19
        Me.KryptonButton2.Values.Image = Global.TrackingContacts.My.Resources.Resources.delete
        Me.KryptonButton2.Values.Text = ""
        '
        'KryptonButton1
        '
        Me.KryptonButton1.Location = New System.Drawing.Point(456, 139)
        Me.KryptonButton1.Name = "KryptonButton1"
        Me.KryptonButton1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.KryptonButton1.Size = New System.Drawing.Size(39, 29)
        Me.KryptonButton1.TabIndex = 18
        Me.KryptonButton1.Values.Image = Global.TrackingContacts.My.Resources.Resources.add
        Me.KryptonButton1.Values.Text = ""
        '
        'lvListas
        '
        Me.lvListas.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Lista})
        Me.lvListas.GridLines = True
        Me.lvListas.Location = New System.Drawing.Point(74, 174)
        Me.lvListas.Name = "lvListas"
        Me.lvListas.Size = New System.Drawing.Size(421, 168)
        Me.lvListas.TabIndex = 17
        Me.lvListas.UseCompatibleStateImageBehavior = False
        Me.lvListas.View = System.Windows.Forms.View.Details
        '
        'Lista
        '
        Me.Lista.Text = "Listas"
        Me.Lista.Width = 407
        '
        'KryptonButton3
        '
        Me.KryptonButton3.Location = New System.Drawing.Point(432, 395)
        Me.KryptonButton3.Name = "KryptonButton3"
        Me.KryptonButton3.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.KryptonButton3.Size = New System.Drawing.Size(63, 54)
        Me.KryptonButton3.TabIndex = 16
        Me.KryptonButton3.Values.Image = Global.TrackingContacts.My.Resources.Resources.a
        Me.KryptonButton3.Values.Text = ""
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(160, 62)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(335, 21)
        Me.txtNombre.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(71, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(24, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Pre-Contactos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(24, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(217, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Listas Seleccionadas"
        '
        'frmCambiarLista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(591, 521)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCambiarLista"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cambiar de Lista"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonHeaderGroup1.Panel.ResumeLayout(False)
        Me.KryptonHeaderGroup1.Panel.PerformLayout()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager

    Public Sub New(ByRef SelectedPrecontacto As Contacto)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        _precontacto = SelectedPrecontacto
        ' Add any initialization after the InitializeComponent() call.
        Dim listas As ListasRepository = New ListasRepository(Variables.db)
        For Each lst As lista In listas.ToList
            Me.cmbLista.Items.Add(lst)
        Next
        Me.cmbLista.DisplayMember = "descripcion"
        If Not SelectedPrecontacto Is Nothing Then
            With SelectedPrecontacto
                Me.txtNombre.Text = .nombre + " " + .apellido_01 + " " + .apellido_02

                For Each lst As ListaItem In SelectedPrecontacto.ListaItems
                    If Not lst.list Is Nothing Then
                        Dim item As ListViewItem = New ListViewItem(lst.list.descripcion)
                        item.Tag = lst.list
                        Me.lvListas.Items.Add(item)
                    End If
                Next
            End With
        End If



    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Friend WithEvents KryptonHeaderGroup1 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents KryptonButton3 As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents lvListas As System.Windows.Forms.ListView
    Friend WithEvents Lista As System.Windows.Forms.ColumnHeader
    Friend WithEvents KryptonButton2 As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents KryptonButton1 As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbLista As System.Windows.Forms.ComboBox
End Class
