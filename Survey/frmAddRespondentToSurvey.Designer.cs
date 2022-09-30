namespace Survey
{
    partial class frmAddRespondentToSurvey
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbCodigoCliente = new System.Windows.Forms.Label();
            this.lbNombreCliente = new System.Windows.Forms.Label();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.cmdSeleccionar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.cmdAgregar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.cmdSalir = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Cliente:";
            // 
            // lbCodigoCliente
            // 
            this.lbCodigoCliente.AutoSize = true;
            this.lbCodigoCliente.Location = new System.Drawing.Point(138, 26);
            this.lbCodigoCliente.Name = "lbCodigoCliente";
            this.lbCodigoCliente.Size = new System.Drawing.Size(0, 16);
            this.lbCodigoCliente.TabIndex = 2;
            // 
            // lbNombreCliente
            // 
            this.lbNombreCliente.AutoSize = true;
            this.lbNombreCliente.Location = new System.Drawing.Point(138, 66);
            this.lbNombreCliente.Name = "lbNombreCliente";
            this.lbNombreCliente.Size = new System.Drawing.Size(0, 16);
            this.lbNombreCliente.TabIndex = 3;
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Location = new System.Drawing.Point(41, 108);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(469, 358);
            this.propertyGrid1.TabIndex = 12;
            // 
            // cmdSeleccionar
            // 
            this.cmdSeleccionar.Location = new System.Drawing.Point(433, 26);
            this.cmdSeleccionar.Name = "cmdSeleccionar";
            this.cmdSeleccionar.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.cmdSeleccionar.Size = new System.Drawing.Size(36, 28);
            this.cmdSeleccionar.TabIndex = 13;
            this.toolTip1.SetToolTip(this.cmdSeleccionar, "Seleccionar Cliente por Ubicacion");
            this.cmdSeleccionar.Values.Text = "Seleccionar";
            this.cmdSeleccionar.Click += new System.EventHandler(this.cmdSeleccionar_Click);
            // 
            // cmdAgregar
            // 
            this.cmdAgregar.Location = new System.Drawing.Point(151, 490);
            this.cmdAgregar.Name = "cmdAgregar";
            this.cmdAgregar.Size = new System.Drawing.Size(118, 24);
            this.cmdAgregar.TabIndex = 14;
            this.cmdAgregar.Values.Text = "Agregar";
            this.cmdAgregar.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // cmdSalir
            // 
            this.cmdSalir.Location = new System.Drawing.Point(275, 490);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(118, 24);
            this.cmdSalir.TabIndex = 15;
            this.cmdSalir.Values.Text = "Cerrar";
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(475, 26);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.kryptonButton1.Size = new System.Drawing.Size(36, 28);
            this.kryptonButton1.TabIndex = 16;
            this.toolTip1.SetToolTip(this.kryptonButton1, "Seleccionar cliente por nombre");
            this.kryptonButton1.Values.Text = "Seleccionar";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click_1);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Info.";
            // 
            // frmAddRespondentToSurvey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(544, 536);
            this.Controls.Add(this.kryptonButton1);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdAgregar);
            this.Controls.Add(this.cmdSeleccionar);
            this.Controls.Add(this.propertyGrid1);
            this.Controls.Add(this.lbNombreCliente);
            this.Controls.Add(this.lbCodigoCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddRespondentToSurvey";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Cliente a Estudio";
            this.Load += new System.EventHandler(this.frmAddRespondentToSurvey_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbCodigoCliente;
        private System.Windows.Forms.Label lbNombreCliente;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton cmdSeleccionar;
        private ComponentFactory.Krypton.Toolkit.KryptonButton cmdAgregar;
        private ComponentFactory.Krypton.Toolkit.KryptonButton cmdSalir;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}