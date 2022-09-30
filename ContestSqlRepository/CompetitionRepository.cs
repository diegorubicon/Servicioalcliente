using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SFC.ContestsLib.Entities;
using System.Data.SqlClient;

namespace SFC.ContestsLib.Repositories.SqlRepository
{
    public class CompetitionRepository : Contract.ICompetitionRepository
    {
        private string _cnnstr = "";    //cadena de conexion a la base de datos

        public CompetitionRepository()
        {
            _cnnstr = ConnectionStringManager.Manager.GetFirstConnectionString();
        }

        public int Add(ref Competition NewCompetition)
        {
            int tipo = 0;

            if (NewCompetition.GetType().Name == "CompetitionByDate") 
            {
                tipo = 1;
            }
            if (NewCompetition.GetType().Name == "CompetitionByPeriod")
            {
                tipo = 2;
            }
            DataManager.SqlDataQuery db = new DataManager.SqlDataQuery (_cnnstr);
            
                db.StoreProcedureName = "[sac.Contest].[InsertHeaderCompetition]";
                db.AddParametro("nombre", NewCompetition.Name);
                db.AddParametro("tipo", tipo);
                try
                {
                    double id = db.RetrieveDouble();
                    NewCompetition.IdNumber = Convert.ToInt32(id);
                    //Inserta en la tabla dependiendo del tipo  de concurso
                    if (tipo ==1)
                    {
                        CompetitionByDate cbd = (CompetitionByDate) NewCompetition;

                        db.StoreProcedureName = "[sac.Contest].[InsertDatedCompetition]";
                        db.AddParametro("id",NewCompetition.IdNumber);
                        db.AddParametro("fecha_inicio",cbd.DateStart);
                        db.AddParametro("fecha_cierre",cbd.DateEnd);
                        
                    }
                    if (tipo == 2)
                    {
                        CompetitionByPeriod cbp = (CompetitionByPeriod) NewCompetition;

                    }



                    //Inserta los niveles del concurso
                    foreach (Entities.Level lvl in NewCompetition.Levels.Values)
                    {   
                      
                    }

                    return 1;
                }
                catch (Exception ex)
                {
                    return 0;
                }                                         

                     
        }
        public int Add(CompetitionByDate NewCompetition)
        {
            return 1;
        }
        public int Add(CompetitionByPeriod NewCompetition)
        {
            return 0;
        }

    }
}
