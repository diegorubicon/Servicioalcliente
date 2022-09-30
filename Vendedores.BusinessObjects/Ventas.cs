using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Vendedores.BusinessObjects
{
    public class Ventas : IEnumerator,IEnumerable
    {
        private string _CnnStr;
        private string _vendedor;
        
        private int position = 0;
        private Dictionary<int, Venta> periodlist;

        public Ventas(string ConnectionString, string IdVendedor)
        {
            _CnnStr = ConnectionString;
            _vendedor = IdVendedor;
            periodlist = new Dictionary<int, Venta>();
        }
         /// <summary>
        /// Obtiene las ventas realizadas por el vendedor en el periodo indicado
        /// </summary>
        /// <param name="Periodo">Id del periodo</param>
        /// <returns></returns>
        public Venta this[int Periodo]
        {
            get
            {
                if (periodlist.ContainsKey(Periodo))
                    return periodlist[Periodo];
                else
                {
                    DataSource.VentasQuery query = new DataSource.VentasQuery(_CnnStr);
                    Venta v = new Venta();
                    v.Linea1 = query.QueryVentaLinea1(_vendedor, Periodo);
                    periodlist.Add(Periodo, v);

                    return v;
                }
            }
        }      

        //IEnumerator and IEnumerable require these methods.
        public IEnumerator GetEnumerator()
        {
            return (IEnumerator<Venta>)this;
        }
        //IEnumerator
        public bool MoveNext()
        {
            position++;
            return (position <  this.periodlist.Count);
        }
        //IEnumerable
        public void Reset()
        { position = 0; }

        //IEnumerable
        public object Current
        {
            get { return periodlist.ToArray()[position]; }
        }
    }
}
