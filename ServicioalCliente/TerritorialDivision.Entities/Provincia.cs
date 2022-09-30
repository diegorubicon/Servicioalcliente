using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace TerritorialDivision.Entities
{
    [Table(Name = "dbo.Provincias")]
    public class Provincia 
    {
        [Column(Name = "provincia",IsPrimaryKey = true)]
        public int Id { get; set; }
        [Column(Name = "descripcion")]
        public string Descripcion { get; set; }

        private EntitySet<Canton> _cantones;

        [AssociationAttribute(Name = "provincias_cantones", Storage = "_cantones", ThisKey = "Id", OtherKey = "Id_provincia")]
        public EntitySet<Canton> Cantones
        {
            get{return _cantones;}
            set{_cantones.Assign(value);}
        }

        public Provincia()
        {
        }
            /*Me._cantones = New EntitySet(Of cantone)(AddressOf Me.attach_cantones, AddressOf Me.detach_cantones)}*/
           /* this.Cantones = new List<Canton>();        
        } 
        /* private void attach_cantones(canton entity )
         {   
            entity.provincia1 = Me
         }
         

        Private Sub detach_cantones(ByVal entity As cantone)
            Me.SendPropertyChanging()
            entity.provincia1 = Nothing
        End Sub */

    }
}
