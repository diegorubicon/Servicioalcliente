using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UserAccessManager
{
    public partial class frmAgregarPerfil : Form
    {
        int action = 0;
        Perfil p = new Perfil();
      
        public delegate void PerfilAddedEvent(Perfil p);

        public event PerfilAddedEvent Added;
        public event PerfilAddedEvent Updated;

        public frmAgregarPerfil()
        {
            InitializeComponent();
            action = 1; //Accion del formulario, crear nuevo perfil
        }
        public frmAgregarPerfil(Perfil o)
        {
            InitializeComponent();
            action = 2;  //Accio del formulario modificar el perfil
            p = o;
         
        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            this.errorProvider1.Clear();
            if (this.txtNombre.Text == "")
            {
                this.errorProvider1.SetError(this.txtNombre, "Debe ingresar el nombre del perfil");
                return ;
            }
            p.Nombre = this.txtNombre.Text;
            p.Descripcion = this.txtDescripcion.Text;

            PrintRecursive(treeView1.Nodes[0]);
            if (action == 1)
            {
                if (Added != null)
                    Added(p);
            }
            if (action == 2)
            {
                if (Updated != null)
                    Updated(p);
            }

            this.Close();
        }
        private void PrintRecursive(TreeNode treeNode)
        {
            switch (treeNode.Name)
            {
                case "Node3": p.Opciones.Clientes.BuscarCliente = treeNode.Checked; break;
                case "Node4": p.Opciones.Clientes.InformacionGeneral = treeNode.Checked; break;
                case "Node5": p.Opciones.Clientes.ActualizarDatos = treeNode.Checked; break;
                case "Node6": p.Opciones.Clientes.Facturacion = treeNode.Checked; break;
                case "Node7": p.Opciones.Clientes.Garantias = treeNode.Checked; break;
                
                case "Node8": p.Opciones.Vendedores.HistoricoCierres = treeNode.Checked; break;
                case "Node9": p.Opciones.Vendedores.NiveldelVendedor = treeNode.Checked; break;
                case "Node10": p.Opciones.Vendedores.InformacionPersonal = treeNode.Checked; break;
                case "Node11": p.Opciones.Vendedores.ActualizarDatos = treeNode.Checked; break;
                case "Node13": p.Opciones.Vendedores.Referencia = treeNode.Checked; break;
                case "Node14": p.Opciones.Vendedores.Organizacion = treeNode.Checked; break;

                case "Node16": p.Opciones.Vendedores.Ventas.Resumen = treeNode.Checked; break;
                case "Node19": p.Opciones.Vendedores.Ventas.VentasPersonales = treeNode.Checked; break;
                case "Node20": p.Opciones.Vendedores.Ventas.VentasUnidad = treeNode.Checked; break;
                case "Node21": p.Opciones.Vendedores.Ventas.DetalleVentasUnidad = treeNode.Checked; break;
                case "Node22": p.Opciones.Vendedores.Ventas.EstadoReclutamiento = treeNode.Checked; break;
                case "Node23": p.Opciones.Vendedores.Ventas.GraficoProvincias = treeNode.Checked; break;

            }
                
            foreach (TreeNode tn in treeNode.Nodes)
            {
                PrintRecursive(tn);
            }
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAgregarPerfil_Load(object sender, EventArgs e)
        {
            this.treeView1.TopNode.ExpandAll();
            if (action == 2)
            {
                this.txtNombre.Text = p.Nombre;
                this.txtDescripcion.Text = p.Descripcion;

                FillRecursive(treeView1.Nodes[0]);
            }
        }
        private void FillRecursive(TreeNode treeNode)
        {
            switch (treeNode.Name)
            {
                case "Node3": treeNode.Checked = p.Opciones.Clientes.BuscarCliente;  break;
                case "Node4": treeNode.Checked = p.Opciones.Clientes.InformacionGeneral;  break;
                case "Node5": treeNode.Checked = p.Opciones.Clientes.ActualizarDatos;  break;
                case "Node6": treeNode.Checked = p.Opciones.Clientes.Facturacion;  break;
                case "Node7": treeNode.Checked = p.Opciones.Clientes.Garantias;  break;

                case "Node8": treeNode.Checked = p.Opciones.Vendedores.HistoricoCierres;  break;
                case "Node9": treeNode.Checked = p.Opciones.Vendedores.NiveldelVendedor;  break;
                case "Node10": treeNode.Checked = p.Opciones.Vendedores.InformacionPersonal;  break;
                case "Node11": treeNode.Checked = p.Opciones.Vendedores.ActualizarDatos;  break;
                case "Node13": treeNode.Checked = p.Opciones.Vendedores.Referencia;  break;
                case "Node14": treeNode.Checked = p.Opciones.Vendedores.Organizacion;  break;

                case "Node16": treeNode.Checked = p.Opciones.Vendedores.Ventas.Resumen;  break;
                case "Node19": treeNode.Checked = p.Opciones.Vendedores.Ventas.VentasPersonales;  break;
                case "Node20": treeNode.Checked = p.Opciones.Vendedores.Ventas.VentasUnidad;  break;
                case "Node21": treeNode.Checked = p.Opciones.Vendedores.Ventas.DetalleVentasUnidad;  break;
                case "Node22": treeNode.Checked = p.Opciones.Vendedores.Ventas.EstadoReclutamiento;  break;
                case "Node23": treeNode.Checked = p.Opciones.Vendedores.Ventas.GraficoProvincias; break;

            }

            foreach (TreeNode tn in treeNode.Nodes)
            {
                FillRecursive(tn);
            }
        }

    }
}
