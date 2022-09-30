<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgregarObservacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAgregarObservacion))
        Me.dtProximaLlamada = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.rbC = New System.Windows.Forms.RadioButton()
        Me.rbB = New System.Windows.Forms.RadioButton()
        Me.rbA = New System.Windows.Forms.RadioButton()
        Me.txtObservacion = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmdAgregar = New System.Windows.Forms.Button()
        Me.cmdCerrar = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'dtProximaLlamada
        '
        Me.dtProximaLlamada.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtProximaLlamada.Location = New System.Drawing.Point(420, 62)
        Me.dtProximaLlamada.Name = "dtProximaLlamada"
        Me.dtProximaLlamada.Size = New System.Drawing.Size(134, 21)
        Me.dtProximaLlamada.TabIndex = 18
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(327, 68)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(87, 13)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "Proxima Llamada"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(13, 70)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(82, 13)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "Estado Llamada"
        '
        'rbC
        '
        Me.rbC.AutoSize = True
        Me.rbC.Location = New System.Drawing.Point(199, 66)
        Me.rbC.Name = "rbC"
        Me.rbC.Size = New System.Drawing.Size(32, 17)
        Me.rbC.TabIndex = 14
        Me.rbC.TabStop = True
        Me.rbC.Text = "C"
        Me.ToolTip1.SetToolTip(Me.rbC, "No se contacto con el vendedor, proxima llamada programada")
        Me.rbC.UseVisualStyleBackColor = True
        '
        'rbB
        '
        Me.rbB.AutoSize = True
        Me.rbB.Location = New System.Drawing.Point(162, 66)
        Me.rbB.Name = "rbB"
        Me.rbB.Size = New System.Drawing.Size(31, 17)
        Me.rbB.TabIndex = 13
        Me.rbB.TabStop = True
        Me.rbB.Text = "B"
        Me.ToolTip1.SetToolTip(Me.rbB, "Mensaje de Llamada, se dejo un mensaje en contestadora o con familiares.")
        Me.rbB.UseVisualStyleBackColor = True
        '
        'rbA
        '
        Me.rbA.AutoSize = True
        Me.rbA.Location = New System.Drawing.Point(121, 66)
        Me.rbA.Name = "rbA"
        Me.rbA.Size = New System.Drawing.Size(35, 17)
        Me.rbA.TabIndex = 12
        Me.rbA.TabStop = True
        Me.rbA.Text = "A "
        Me.ToolTip1.SetToolTip(Me.rbA, "Llamada Satisfactoria: Se comunico con el vendedor. ")
        Me.rbA.UseVisualStyleBackColor = True
        '
        'txtObservacion
        '
        Me.txtObservacion.Location = New System.Drawing.Point(121, 19)
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Size = New System.Drawing.Size(433, 21)
        Me.txtObservacion.TabIndex = 11
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 19)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(78, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Observaciones"
        '
        'cmdAgregar
        '
        Me.cmdAgregar.Image = CType(resources.GetObject("cmdAgregar.Image"), System.Drawing.Image)
        Me.cmdAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdAgregar.Location = New System.Drawing.Point(170, 98)
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(112, 36)
        Me.cmdAgregar.TabIndex = 15
        Me.cmdAgregar.Text = "Agregar"
        Me.cmdAgregar.UseVisualStyleBackColor = True
        '
        'cmdCerrar
        '
        Me.cmdCerrar.Image = CType(resources.GetObject("cmdCerrar.Image"), System.Drawing.Image)
        Me.cmdCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCerrar.Location = New System.Drawing.Point(284, 98)
        Me.cmdCerrar.Name = "cmdCerrar"
        Me.cmdCerrar.Size = New System.Drawing.Size(113, 36)
        Me.cmdCerrar.TabIndex = 19
        Me.cmdCerrar.Text = "Cerrar"
        Me.cmdCerrar.UseVisualStyleBackColor = True
        '
        'frmAgregarObservacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(566, 171)
        Me.Controls.Add(Me.cmdCerrar)
        Me.Controls.Add(Me.dtProximaLlamada)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cmdAgregar)
        Me.Controls.Add(Me.rbC)
        Me.Controls.Add(Me.rbB)
        Me.Controls.Add(Me.rbA)
        Me.Controls.Add(Me.txtObservacion)
        Me.Controls.Add(Me.Label11)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAgregarObservacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Observacion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtProximaLlamada As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cmdAgregar As System.Windows.Forms.Button
    Friend WithEvents rbC As System.Windows.Forms.RadioButton
    Friend WithEvents rbB As System.Windows.Forms.RadioButton
    Friend WithEvents rbA As System.Windows.Forms.RadioButton
    Friend WithEvents txtObservacion As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cmdCerrar As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
