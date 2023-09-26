using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppRopa
{
    public class Buzos : Stock
    {
        public int MedidaHombrosBuzo { get; set; }
        public string MedidaAnchoBuzo { get; set; }
        public int MedidaLargoBuzo { get; set; }
        public string MedidaMangasBuzo { get; set; }
        public string TalleBuzo { get; set; }
        public bool Frizado { get; set; }   
    }
}
