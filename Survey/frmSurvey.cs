using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Survey.BusinessLayer;
using System.Threading;
using Survey;
namespace Survey
{
    public partial class frmSurvey : Form
    {
        private class Mes
        {
            public int mes { get; set; }
            public string desc { get; set; }
        }
        private string _cnnstr = "";
        private Poll MonthlyPoll = null;
        frmAddRespondentToSurvey frm;
        public frmSurvey()
        {
            InitializeComponent();

            this.cmbMes.Items.Clear();
            this.cmbMes.Items.Add(new Mes { mes = 1, desc = "Enero" });
            this.cmbMes.Items.Add(new Mes { mes = 2, desc = "Febrero" });
            this.cmbMes.Items.Add(new Mes { mes = 3, desc = "Marzo" });
            this.cmbMes.Items.Add(new Mes { mes = 4, desc = "Abril" });
            this.cmbMes.Items.Add(new Mes { mes = 5, desc = "Mayo" });
            this.cmbMes.Items.Add(new Mes { mes = 6, desc = "Junio" });
            this.cmbMes.Items.Add(new Mes { mes = 7, desc = "Julio" });
            this.cmbMes.Items.Add(new Mes { mes = 8, desc = "Agosto" });
            this.cmbMes.Items.Add(new Mes { mes = 9, desc = "Setiembre" });
            this.cmbMes.Items.Add(new Mes { mes = 10, desc = "Octubre" });
            this.cmbMes.Items.Add(new Mes { mes = 11, desc = "Noviembre" });
            this.cmbMes.Items.Add(new Mes { mes = 12, desc = "Diciembre" });

            this.cmbMes.ValueMember = "mes";
            this.cmbMes.DisplayMember = "desc";

            this.cmbAno.Items.Clear();
            for (int i = DateTime.Now.Year - 5; i <= DateTime.Now.Year; i++ )
            {
                this.cmbAno.Items.Add(i);
            }

            foreach (Mes m in this.cmbMes.Items)
            {
                if (m.mes == DateTime.Now.Month) 
                {
                    this.cmbMes.SelectedItem = m;
                }

            }
            this.cmbAno.SelectedItem = DateTime.Now.Year;

        }
        public frmSurvey(String ConnectionString)
            : this()
        {
            _cnnstr = ConnectionString;
        }
        private void LoadMonthlyPoll()
        {
            //Verifica si ya se creo la encuesta mensual
            MonthlyPoll = new Poll(_cnnstr);

            if (!MonthlyPoll.Load(DateTime.Today.Month, DateTime.Today.Year))
            {
                MonthlyPoll.Mes = DateTime.Today.Month;
                MonthlyPoll.Periodo = DateTime.Today.Year;
                MonthlyPoll.Descripcion = "Encuesta Mensual ";

                MonthlyPoll.Update();
            }
            Thread thread = new Thread(LoadTable);
            thread.Start();
        }

        private void frmSurvey_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;

            Thread thread = new Thread(LoadMonthlyPoll);
            thread.Start();
        }
        private void LoadTable()
        {
            this.lvRespondents.Items.Clear();
            foreach (Entities.Respondent resp in MonthlyPoll.Respondents)
            {
                ListViewItem item = new ListViewItem(resp.Id);
                item.SubItems.Add(resp.Nombre);
                item.SubItems.Add(resp.Agent.Nombre);
                item.SubItems.Add(resp.Zone.Nombre);

                this.lvRespondents.Items.Add(item);
            }
                
        }
        private void frm_RespondentAdded(ref Respondent resp)
        {
            ListViewItem item = new ListViewItem(resp.Id);
            item.SubItems.Add(resp.Nombre);
            item.SubItems.Add(resp.Agent.Nombre);
            item.SubItems.Add(resp.Zone.Nombre);

            this.lvRespondents.Items.Add(item);
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
          
             frm = new frmAddRespondentToSurvey(_cnnstr,MonthlyPoll);
             frm.RespondentAdded += new frmAddRespondentToSurvey.RespondentAddedEventHandler(frm_RespondentAdded);       
             frm.Show();
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kryptonLabel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            if (this.cmbMes.SelectedItem == null)
                return;

            if (this.cmbAno.SelectedItem == null)
                return;

            Mes m = (Mes) this.cmbMes.SelectedItem;

            //Verifica si ya se creo la encuesta mensual
            MonthlyPoll = new Poll(_cnnstr);

            if (!MonthlyPoll.Load(m.mes, (int) this.cmbAno.SelectedItem))
            {
                MonthlyPoll.Mes = m.mes;
                MonthlyPoll.Periodo = (int)this.cmbAno.SelectedItem;
                MonthlyPoll.Descripcion = "Encuesta Mensual ";

                MonthlyPoll.Update();
            }
            Thread thread = new Thread(LoadTable);
            thread.Start();
        }
    }
}
