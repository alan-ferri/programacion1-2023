using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Localidad
    {
        public Provincia provincia { get; set; }   
        public int codPostal { get; set; }
        public string nombre { get; set; }  
    }
}
