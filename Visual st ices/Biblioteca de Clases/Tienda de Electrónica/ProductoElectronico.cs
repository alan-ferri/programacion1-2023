using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_de_Electrónica
{
    public abstract class ProductoElectronico
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public double Precio  { get; set; }
        public abstract double CalcularImpuesto();
        public abstract double CalcularTotal();

        public ProductoElectronico( int id, string nombre, double precio)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Precio = precio;
        }       
    }
}
