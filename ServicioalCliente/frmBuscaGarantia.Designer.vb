<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscaGarantia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuscaGarantia))
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmdSalir = New System.Windows.Forms.Button
        Me.cmdSeleccionar = New System.Windows.Forms.Button
        Me.txtBuscarDescripcion = New System.Windows.Forms.TextBox
        Me.txtBuscarOrden = New System.Windows.Forms.TextBox
        Me.lvArticulos = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(94, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Articulo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-10, -22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Busqueda"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Boleta"
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(301, 376)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(114, 24)
        Me.cmdSalir.TabIndex = 15
        Me.cmdSalir.Text = "Salir"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'cmdSeleccionar
        '
        Me.cmdSeleccionar.Location = New System.Drawing.Point(181, 376)
        Me.cmdSeleccionar.Name = "cmdSeleccionar"
        Me.cmdSeleccionar.Size = New System.Drawing.Size(114, 24)
        Me.cmdSeleccionar.TabIndex = 14
        Me.cmdSeleccionar.Text = "Seleccionar"
        Me.cmdSeleccionar.UseVisualStyleBackColor = True
        '
        'txtBuscarDescripcion
        '
        Me.txtBuscarDescripcion.Location = New System.Drawing.Point(97, 26)
        Me.txtBuscarDescripcion.Name = "txtBuscarDescripcion"
        Me.txtBuscarDescripcion.Size = New System.Drawing.Size(497, 20)
        Me.txtBuscarDescripcion.TabIndex = 13
        '
        'txtBuscarOrden
        '
        Me.txtBuscarOrden.Location = New System.Drawing.Point(12, 26)
        Me.txtBuscarOrden.Name = "txtBuscarOrden"
        Me.txtBuscarOrden.Size = New System.Drawing.Size(79, 20)
        Me.txtBuscarOrden.TabIndex = 12
        '
        'lvArticulos
        '
        Me.lvArticulos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lvArticulos.FullRowSelect = True
        Me.lvArticulos.GridLines = True
        Me.lvArticulos.Location = New System.Drawing.Point(12, 53)
        Me.lvArticulos.Name = "lvArticulos"
        Me.lvArticulos.Size = New System.Drawing.Size(582, 315)
        Me.lvArticulos.TabIndex = 11
        Me.lvArticulos.UseCompatibleStateImageBehavior = False
        Me.lvArticulos.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Orden"
        Me.ColumnHeader1.Width = 77
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Fecha"
        Me.ColumnHeader2.Width = 99
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Articulo"
        Me.ColumnHeader3.Width = 402
        '
        'frmBuscaGarantia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(606, 412)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdSeleccionar)
        Me.Controls.Add(Me.txtBuscarDescripcion)
        Me.Controls.Add(Me.txtBuscarOrden)
        Me.Controls.Add(Me.lvArticulos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBuscaGarantia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar Boleta de Garantia"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents cmdSeleccionar As System.Windows.Forms.Button
    Friend WithEvents txtBuscarDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtBuscarOrden As System.Windows.Forms.TextBox
    Friend WithEvents lvArticulos As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
End Class
