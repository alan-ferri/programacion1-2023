using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_Clases
{
    public class MotoDeportiva : Moto
    {
        public int Cilindrada { get; set; }


        public string Name
        {
            get { return "ID: " + Id + ", Marca: " + Marca + ", Modelo: " + Modelo + ", Cilindrada: " + Cilindrada; }

        }
    }
}
