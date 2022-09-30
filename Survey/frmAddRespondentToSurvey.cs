using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Survey.BusinessLayer;

namespace Survey
{
    public partial class frmAddRespondentToSurvey : Form
    {
        private string _cnnstr;
        //private Clientes.frmBusquedaByAdress frm;
        //private Clientes.frmBusquedaClientes frmBus;

        public delegate void RespondentAddedEventHandler(ref Respondent NewRespondent);
        public event RespondentAddedEventHandler RespondentAdded;


        Poll CurrentPoll;


        public frmAddRespondentToSurvey(string connectionstring, Poll _Current)
        {
            InitializeComponent();

          // frm = new Clientes.frmBusquedaByAdress(connectionstring);
           //frm.ClientSelected += new Clientes.frmBusquedaByAdress.ClientSelectedEventHandler(this.frm_ClientSelected);

           //frmBus = new Clientes.frmBusquedaClientes(connectionstring);
           //frmBus.ClientSelected += new Clientes.frmBusquedaClientes.ClientSelectedEventHandler(this.frm_ClientSelected);

           CurrentPoll = _Current;
           _cnnstr = connectionstring;
        }

        private void frmAddRespondentToSurvey_Load(object sender, EventArgs e)
        {
            propertyGrid1.SelectedObject = new Entities.SurveyQuestions();
        }

       private void cmdSeleccionar_Click(object sender, EventArgs e)
        {           
            //frm.Show();
        }        
        /*
        private void frm_ClientSelected(ref Clientes.Entities.Cliente cli)
        {
            if (cli != null)
            {
                this.lbCodigoCliente.Text = cli.Codigo;
                this.lbNombreCliente.Text = cli.NombreCompleto;               
            }
        }*/

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            if (lbCodigoCliente.Text == "")
            {
                MessageBox.Show("Debe seleccionar el cliente", "Encuestas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Survey.Entities.SurveyQuestions questions = (Survey.Entities.SurveyQuestions) propertyGrid1.SelectedObject;
            if (questions.Distribuidor == Entities.SurveyQuestions.Calificacion.NoDefinido
               || questions.Empresa == Entities.SurveyQuestions.Calificacion.NoDefinido
               || questions.Garantias == Entities.SurveyQuestions.Calificacion.NoDefinido
               || questions.Hornea == Entities.SurveyQuestions.Calificacion.NoDefinido
                || questions.No_ahuma == Entities.SurveyQuestions.Calificacion.NoDefinido
                || questions.No_Pega == Entities.SurveyQuestions.Calificacion.NoDefinido
                || questions.No_Se_Precalienta == Entities.SurveyQuestions.Calificacion.NoDefinido
                || questions.Producto == Entities.SurveyQuestions.Calificacion.NoDefinido
                || questions.Uso == Entities.SurveyQuestions.Calificacion.NoDefinido)
            {
                MessageBox.Show("Debe seleccionar la respuesta a todas las preguntas", "Encuestas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Respondent resp = new Respondent(_cnnstr);
            if (resp.Load(this.lbCodigoCliente.Text))
            {
                resp.Poll = CurrentPoll;
                resp.Questions = (Survey.Entities.SurveyQuestions) propertyGrid1.SelectedObject;
                CurrentPoll.Respondents.Add(resp);
                CurrentPoll.Update();
                if (RespondentAdded != null)
                {
                    RespondentAdded(ref resp);
                }
                this.Close();
            }
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kryptonButton1_Click_1(object sender, EventArgs e)
        {
           // frmBus.Show();
        }
    }
}
