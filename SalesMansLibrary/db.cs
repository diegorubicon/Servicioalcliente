using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalesMansLibrary
{
    partial class vendedor
    {
        private int _generacion;
        private double _VentaMensual;

        public RecordMensual RegistroMensual(int cierre)
        {
            var query  = RecordMensuals.Where(_RecordMensuals => _RecordMensuals.cierre == cierre);
            
            if (query.Count() > 0)
                return query.First();
            else
                return null;
            
        }
        public void AddRegistro(RecordMensual _newRecord)
        {
            RecordMensuals.Add(_newRecord);
        }

        public metas_vendedor MetaPeriodo(int Periodo)
        {
            metas_vendedor me;
            try
            {
                if (metas_vendedors.Where(_metas_vendedors => _metas_vendedors.cierre == Periodo).Count() > 0)
                    me = metas_vendedors.Where(_metas_vendedors => _metas_vendedors.cierre == Periodo).First();
                else
                    me = null;

                return me;
            }
            catch (Exception ex)
            {
                return null;
            }            
        }
        public void AddMeta(metas_vendedor meta)
        {
            metas_vendedors.Add(meta);            
        }
        public IEnumerable<nota> ListNotas()
        {
            return notas.OrderByDescending(nota => nota.consecutivo);
        }
        public int Generacion
        {
            get {
                return _generacion;
                    }
            set { _generacion = value; }
        }
        public double VentaMensual{ get{return _VentaMensual;}
            set { _VentaMensual = value; }
        }

        public Decimal PuntosPremiateAcumulados 
        { 
            get 
            {
                return (Decimal) Premiates.Sum(puntos_vendedor => puntos_vendedor.puntos);
            } 
        }
        public Decimal PuntosPremiateCanjeados
        {
            get
            {
                return PuntosPremiateAcumulados - (Decimal) Premiates.Sum(puntos_vendedor => puntos_vendedor.canjeados);
            }
        }

        public Decimal PuntosPremiatexCierre(Decimal CierreInicio, Decimal CierreFinal)
        {
            return (Decimal)Premiates.Where(puntos_vendedor => puntos_vendedor.cierre >= CierreInicio && puntos_vendedor.cierre <= CierreFinal).Sum(puntos_vendedor => puntos_vendedor.puntos);
        }

    }
}
