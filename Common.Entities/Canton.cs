using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Entities
{
    public class Canton : CommonPlace
    {
        public CommonPlace Distrito { get; set; }
    }
}
