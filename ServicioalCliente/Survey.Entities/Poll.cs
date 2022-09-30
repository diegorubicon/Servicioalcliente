using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Survey.Entities
{
    public class Poll
    {
        public decimal Id { get; set; }
        public int Periodo { get; set; }
        public int Mes { get; set; }
        public string Descripcion { get; set; }
        public List<Respondent> Respondents { get; set; }

        public Poll()
        {
            Id = 0;
            Respondents = new List<Respondent>();
        }
    }
}
