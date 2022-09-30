<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMensajeSMS
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
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtMensaje = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtFechaEnvio = New System.Windows.Forms.DateTimePicker()
        Me.dtHoraEnvio = New System.Windows.Forms.DateTimePicker()
        Me.cmdTerminar = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.cmdCancelar = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.SuspendLayout()
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(27, 31)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(56, 20)
        Me.KryptonLabel1.TabIndex = 0
        Me.KryptonLabel1.Values.Text = "Mensaje"
        '
        'txtMensaje
        '
        Me.txtMensaje.Location = New System.Drawing.Point(27, 57)
        Me.txtMensaje.MaxLength = 160
        Me.txtMensaje.Multiline = True
        Me.txtMensaje.Name = "txtMensaje"
        Me.txtMensaje.Size = New System.Drawing.Size(499, 185)
        Me.txtMensaje.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 275)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Fecha de Envio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 323)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Hora de Envio"
        '
        'dtFechaEnvio
        '
        Me.dtFechaEnvio.CustomFormat = ""
        Me.dtFechaEnvio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaEnvio.Location = New System.Drawing.Point(134, 271)
        Me.dtFechaEnvio.Name = "dtFechaEnvio"
        Me.dtFechaEnvio.Size = New System.Drawing.Size(91, 21)
        Me.dtFechaEnvio.TabIndex = 4
        '
        'dtHoraEnvio
        '
        Me.dtHoraEnvio.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtHoraEnvio.Location = New System.Drawing.Point(134, 323)
        Me.dtHoraEnvio.Name = "dtHoraEnvio"
        Me.dtHoraEnvio.Size = New System.Drawing.Size(91, 21)
        Me.dtHoraEnvio.TabIndex = 5
        '
        'cmdTerminar
        '
        Me.cmdTerminar.Location = New System.Drawing.Point(134, 393)
        Me.cmdTerminar.Name = "cmdTerminar"
        Me.cmdTerminar.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.cmdTerminar.Size = New System.Drawing.Size(148, 34)
        Me.cmdTerminar.TabIndex = 6
        Me.cmdTerminar.Values.Text = "Enviar"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Location = New System.Drawing.Point(288, 393)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.cmdCancelar.Size = New System.Drawing.Size(132, 34)
        Me.cmdCancelar.TabIndex = 7
        Me.cmdCancelar.Values.Text = "Cacncelar"
        '
        'frmMensajeSMS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(538, 472)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdTerminar)
        Me.Controls.Add(Me.dtHoraEnvio)
        Me.Controls.Add(Me.dtFechaEnvio)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtMensaje)
        Me.Controls.Add(Me.KryptonLabel1)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMensajeSMS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMensajeSMS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtMensaje As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtFechaEnvio As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtHoraEnvio As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmdTerminar As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents cmdCancelar As ComponentFactory.Krypton.Toolkit.KryptonButton
End Class
