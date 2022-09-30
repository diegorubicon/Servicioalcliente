using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UserAccessManager
{
    public class main
    {   
        public void ShowPerfilesWindow(String ConnectionString)
        {
            frmPerfiles frm = new frmPerfiles(ConnectionString);
            frm.Show();
        }
    }
}
