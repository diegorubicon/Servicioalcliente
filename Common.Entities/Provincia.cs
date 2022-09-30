using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Entities
{
    public class Provincia :CommonPlace
    {
        public Canton Canton { get; set; }
    }
}
