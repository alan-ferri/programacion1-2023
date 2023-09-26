using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tienda_de_Electrónica;

namespace Biblioteca_Ejercicio_2
{
    public class Televisor : ProductoElectronico
    {
        public double tamanio_pantalla { get; set; }
        public Televisor(int ID, string Nombre, double Precio, double Tamanio_Pantalla) : base(ID, Nombre, Precio)
        {
            this.tamanio_pantalla = Tamanio_Pantalla;
        }
        public override double CalcularImpuesto()
        {
            return Precio * 0.1;
        }
        public override double CalcularTotal()
        {
            return CalcularImpuesto() + Precio;
        }
        public string texto
        {
            get { return $"Televisor: {Nombre}. Precio con impuesto: {CalcularTotal()}."; }
        }
    }
}

