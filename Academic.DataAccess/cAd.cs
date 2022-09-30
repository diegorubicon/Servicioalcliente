using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Academic.DataAccess
{
    public class cAd : Generic2<Entities.c>
    {
          public cAd(string ConnectionString) : base(ConnectionString) { }
    }
}
