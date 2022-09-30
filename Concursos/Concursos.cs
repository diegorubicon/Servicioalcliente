using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Concursos
{
    public class Concursos:List<Concurso>
    {
        private Data.ConcursoDS _DataSource = null;


        public Concursos(String ConnectionString)
        {
            _DataSource = new Data.ConcursoDS(ConnectionString);

            foreach (Concurso c in _DataSource.GetRows())
            {
                this.Add(c);
            }
        }

    }

}
