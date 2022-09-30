using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Survey.BusinessLayer
{
    public class Respondent : Entities.Respondent
    {
        private string _cnnstr = "";

        public Respondent(string ConnectionString)
        {
            _cnnstr = ConnectionString;
        }
        public bool Load(string IdCliente)
        {
            Survey.DataAccess.RespondentAD objad = new Survey.DataAccess.RespondentAD(_cnnstr);

            if (objad.Load(this,IdCliente) == 1)
                return true;
            else
                return false;
        }

        
    }
}
