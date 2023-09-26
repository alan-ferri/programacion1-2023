using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Provincia
    {
        public string nombre { get; set; }  
        public int id { get; set; }
        public List<Localidad> localidades { get; set; }    
    }
}
