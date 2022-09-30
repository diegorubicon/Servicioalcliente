using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FollowUp
{
    public class Lists : Entities.Lists
    {
        public Lists(string cnnstr)
        {
            DataAccess.ListStorage st = new DataAccess.ListStorage(cnnstr);

            st.Fill(this);

        }
    }
}
