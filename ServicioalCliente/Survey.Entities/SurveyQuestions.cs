using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Survey.Entities
{
    public class SurveyQuestions
    {
        public enum Calificacion
        {
            NoDefinido = 0,
            Bueno = 3,
            Regular = 2,
            Malo = 1,
        }
        public enum Sino
        {
            No = 0,
            Si = 2
        }
        private Calificacion _ProductSatisfaction;
        private Calificacion _DistribuidorSatisfaction;
        private Calificacion _CompanySatisfaction;

        private Calificacion _knowledgeReplace;
        private Calificacion _knowledgeUse;
        private Calificacion _knowledgeNoPega;
        private Calificacion _knowledgeNoAhuma;
        private Calificacion _knowledgeHornea;
        private Calificacion _knowledgeNosePrecalienta;

        private Sino _NextVisit;

        [Category("1.1 Satisfaccion"), Description("Satisfaccion con el Producto")]
        public Calificacion Producto
        {
            get { return _ProductSatisfaction; }
            set { _ProductSatisfaction = value; }
        }
        [Category("1.1 Satisfaccion"), Description("Satisfaccion con el Distribuidor")]
        public Calificacion Distribuidor
        {
            get { return _DistribuidorSatisfaction; }
            set { _DistribuidorSatisfaction = value; }
        }
        [Category("1.1 Satisfaccion"), Description("Satisfaccion con la empresa")]
        public Calificacion Empresa
        {
            get { return _CompanySatisfaction; }
            set { _CompanySatisfaction = value; }
        }
        [Category("1.2 Conocimiento"), Description("Conocimiento sobre los tipos de garantia")]
        public Calificacion Garantias
        {
            get { return _knowledgeReplace; }
            set { _knowledgeReplace = value; }
        }
        [Category("1.2 Conocimiento"), Description("Conocimiento sobre el uso de las piezas")]
        public Calificacion Uso
        {
            get { return _knowledgeUse; }
            set { _knowledgeUse = value; }
        }
        [Category("1.2 Conocimiento"), Description("El producto no pega los alimentos")]
        public Calificacion No_Pega
        {
            get { return _knowledgeNoPega; }
            set { _knowledgeNoPega = value; }
        }
        [Category("1.2 Conocimiento"), Description("El producto no ahuma")]
        public Calificacion No_ahuma
        {
            get { return _knowledgeNoAhuma; }
            set { _knowledgeNoAhuma = value; }
        }
        [Category("1.2 Conocimiento"), Description("El producto hornea sobre el disco de la cocina")]
        public Calificacion Hornea
        {
            get { return _knowledgeHornea; }
            set { _knowledgeHornea = value; }
        }
        [Category("1.2 Conocimiento"), Description("El producto hornea sobre el disco de la cocina")]
        public Calificacion No_Se_Precalienta
        {
            get { return _knowledgeNosePrecalienta; }
            set { _knowledgeNosePrecalienta = value; }
        }
        public Sino Proxima_Visita
        {
            get { return _NextVisit; }
            set {_NextVisit = value; }
        }
    }
 }



       


   

