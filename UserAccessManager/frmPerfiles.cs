using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace UserAccessManager
{
    public partial class frmPerfiles : Form
    {
        private string _cnnstr;
        frmAgregarPerfil frm = null;

        public frmPerfiles()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;     
        }
        public frmPerfiles(string ConnectionString) 
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            _cnnstr = ConnectionString;
        }
        private void frmPerfiles_Load(object sender, EventArgs e)
        {
            Thread oThread = new Thread(new ThreadStart(LoadPerfiles));

            // Start the thread
            oThread.Start();
        }
        public void LoadPerfiles()
        {
            this.lvPerfiles.Items.Clear();
            Perfiles ps = new Perfiles(_cnnstr);
            foreach (Perfil p in ps.ToList())
            {
                AddPerfilToListView(p);
            }
        }
        public void AddPerfilToListView(Perfil p)
        {
            ListViewItem item = new ListViewItem(p.Nombre);
            item.SubItems.Add(p.Descripcion);
            item.Tag = p;
            this.lvPerfiles.Items.Add(item);
        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            frm = new frmAgregarPerfil();
            frm.Added += new frmAgregarPerfil.PerfilAddedEvent(PerfilAdd);
           
            frm.Show();
        }
        //Evento cuando se cre un nuveo perfil
        public void PerfilAdd(Perfil p)
        {
            info.Text = "Guardando el perfi";
            Perfiles ps = new Perfiles(_cnnstr);
            ps.Add(p);
            info.Text = "Perfil guardado";
            AddPerfilToListView(p);
        }
        //Evento cuando se modifica un perfil
        public void PerfilUpdated(Perfil p)
        {
            info.Text = "Actualizando el perfi";
            Perfiles ps = new Perfiles(_cnnstr);
            ps.Update(p);
            info.Text = "Perfil Actualizado";
            
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            if (this.lvPerfiles.SelectedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un perfil", "Servicioalcliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Perfil sel =(Perfil) this.lvPerfiles.SelectedItems[0].Tag;

            frm = new frmAgregarPerfil(sel);
            frm.Updated += new frmAgregarPerfil.PerfilAddedEvent(PerfilUpdated);

            frm.Show();
        }
    }
}
