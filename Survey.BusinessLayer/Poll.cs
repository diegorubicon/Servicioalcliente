using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Survey.BusinessLayer
{
    public class Poll : Survey.Entities.Poll
    {
        private string _cnnstr;

        public Poll(string ConnectionString)
        {
            _cnnstr = ConnectionString;
        }
        public bool Load(int mes, int periodo)
        {
            Survey.DataAccess.PollAD objad = new Survey.DataAccess.PollAD(_cnnstr);

            if (objad.Fill(this, mes, periodo) == 1)
                return true;
            else
                return false;
        }
        public bool Load()
        {
            Survey.DataAccess.PollAD objad = new Survey.DataAccess.PollAD(_cnnstr);

            if (objad.Fill(this) == 1)
                return true;
            else
                return false;
        }
        
        public void Update()
        {
            Survey.DataAccess.PollAD objad = new Survey.DataAccess.PollAD(_cnnstr);

            if (objad.Exist(this))
                objad.Update(this);
            else
                objad.Insert(this);
        }
        
    }
}
