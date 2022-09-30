using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BonosExcelencia.Data
{
    /// <summary>
    /// Clase encargada de manipular el acceso a los datos del objeto Bono de la
    /// excelencia
    /// </summary>
    class ExcelenciaBonoAD
    {
        private DataBaseDataContext db = null;

        public ExcelenciaBonoAD (String ConnectionString)
        {
            db = new DataBaseDataContext(ConnectionString);
        }
        public IEnumerable<ExcelenciaBono> GetRow(decimal PlanMercadeo, decimal Nivel)
        {
            var query = from exc in db.ExcelenciaBonos
                        where exc.plan_mercadeo == PlanMercadeo && exc.nivel == Nivel
                        select exc;
            return query;
        }
    }
}
