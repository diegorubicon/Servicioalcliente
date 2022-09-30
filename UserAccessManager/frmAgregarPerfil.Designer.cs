namespace UserAccessManager
{
    partial class frmAgregarPerfil
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Buscar Cliente");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Informacion General");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Actualizar Datos");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Facturacion");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Garantias");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Informacion del Cliente", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Historico de Cierres");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Niveles");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Informacion Personal");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Actualizar Datos");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Referencias");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Organizacion");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Resumen de Ventas y Reclutamiento");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Informacion Personal");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Informacion Unidad");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Informacion Detalle Unidad");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Estado Reclutamiento");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Graficos por Provincias");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Ventas", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16,
            treeNode17,
            treeNode18});
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Informacion del Vendedor", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode19});
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Servicio al Cliente", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode20});
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtDescripcion = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.cmdAceptar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion";
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Location = new System.Drawing.Point(141, 16);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(288, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescripcion.Location = new System.Drawing.Point(141, 46);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(288, 20);
            this.txtDescripcion.TabIndex = 3;
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.CheckBoxes = true;
            this.treeView1.Location = new System.Drawing.Point(12, 81);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node3";
            treeNode1.Text = "Buscar Cliente";
            treeNode2.Name = "Node4";
            treeNode2.Text = "Informacion General";
            treeNode3.Name = "Node5";
            treeNode3.Text = "Actualizar Datos";
            treeNode4.Name = "Node6";
            treeNode4.Text = "Facturacion";
            treeNode5.Name = "Node7";
            treeNode5.Text = "Garantias";
            treeNode6.Name = "Node1";
            treeNode6.Text = "Informacion del Cliente";
            treeNode7.Name = "Node8";
            treeNode7.Text = "Historico de Cierres";
            treeNode8.Name = "Node9";
            treeNode8.Text = "Niveles";
            treeNode9.Name = "Node10";
            treeNode9.Text = "Informacion Personal";
            treeNode10.Name = "Node11";
            treeNode10.Text = "Actualizar Datos";
            treeNode11.Name = "Node13";
            treeNode11.Text = "Referencias";
            treeNode12.Name = "Node14";
            treeNode12.Text = "Organizacion";
            treeNode13.Name = "Node16";
            treeNode13.Text = "Resumen de Ventas y Reclutamiento";
            treeNode14.Name = "Node19";
            treeNode14.Text = "Informacion Personal";
            treeNode15.Name = "Node20";
            treeNode15.Text = "Informacion Unidad";
            treeNode16.Name = "Node21";
            treeNode16.Text = "Informacion Detalle Unidad";
            treeNode17.Name = "Node22";
            treeNode17.Text = "Estado Reclutamiento";
            treeNode18.Name = "Node23";
            treeNode18.Text = "Graficos por Provincias";
            treeNode19.Name = "Node15";
            treeNode19.Text = "Ventas";
            treeNode20.Name = "Node2";
            treeNode20.Text = "Informacion del Vendedor";
            treeNode21.Name = "Node0";
            treeNode21.Text = "Servicio al Cliente";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode21});
            this.treeView1.Size = new System.Drawing.Size(478, 324);
            this.treeView1.TabIndex = 4;
            // 
            // cmdAceptar
            // 
            this.cmdAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdAceptar.Location = new System.Drawing.Point(258, 417);
            this.cmdAceptar.Name = "cmdAceptar";
            this.cmdAceptar.Size = new System.Drawing.Size(113, 34);
            this.cmdAceptar.TabIndex = 5;
            this.cmdAceptar.Values.Text = "Aceptar";
            this.cmdAceptar.Click += new System.EventHandler(this.cmdAceptar_Click);
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonButton1.Location = new System.Drawing.Point(377, 417);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(113, 34);
            this.kryptonButton1.TabIndex = 6;
            this.kryptonButton1.Values.Text = "Salir";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAgregarPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 475);
            this.Controls.Add(this.kryptonButton1);
            this.Controls.Add(this.cmdAceptar);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAgregarPerfil";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informacion de Perfil";
            this.Load += new System.EventHandler(this.frmAgregarPerfil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtNombre;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtDescripcion;
        private System.Windows.Forms.TreeView treeView1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton cmdAceptar;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}