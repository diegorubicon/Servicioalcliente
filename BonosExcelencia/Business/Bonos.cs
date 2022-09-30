using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BonosExcelencia.Business
{
    public class Bonos:List<ExcelenciaBono>
    {
        private Data.ExcelenciaBonoAD _DataSource = null;

        public Bonos(String ConnectionString, Decimal PlanMercadeo, Decimal Nivel)
        {
            _DataSource = new Data.ExcelenciaBonoAD(ConnectionString);

            this.Clear();

            foreach (ExcelenciaBono exc in _DataSource.GetRow(PlanMercadeo, Nivel))
            {
                this.Add(exc);
            }           
        }
       
    }
}
