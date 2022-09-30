using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generic.Entities
{
    [System.AttributeUsage(System.AttributeTargets.Property, AllowMultiple = true)]
    public class Atributo : System.Attribute
    {
       public bool Identificardor;        
    }
}