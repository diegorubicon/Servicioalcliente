using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Survey.Entities
{
    public class Respondent
    {
        public string Id{ get; set; }
        public string Nombre { get; set; }      
        public Zone Zone { get; set; }
        public Agent Agent { get; set; }
        public Poll Poll { get; set; }
        public SurveyQuestions Questions { get; set; }

        public Respondent()
        {
            Questions = new SurveyQuestions();
        }
    }
}
