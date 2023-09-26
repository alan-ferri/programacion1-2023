using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class VehiculoAutomovil : Vehiculo
    {
        public int NdePuertas { get; set; } 
        public int NdeAsientos { get; set; }
        public string Name
        {
            get { return "Patente: " + patente + ", Marca: " + marca + ", Modelo: " + modelo + ", Precio Por Día: " + PrecioDia + ", Numero de Puertas: " + NdePuertas + ", Numero de Asientos: " + NdeAsientos; }  

        }
    }
}
