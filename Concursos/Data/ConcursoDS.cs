using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Concursos.Data
{
    class ConcursoDS
    {
        private DataBaseDataContext db = null;

        public ConcursoDS(String ConnectionString)
        {
            db = new DataBaseDataContext(ConnectionString);
        }
        public IEnumerable<Concurso> GetRows()
        {
            var query = from concurso in db.Concursos
                        where concurso.estado == 1
                        select concurso;
            return query;
        }
    }
}
