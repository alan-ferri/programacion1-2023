using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tienda_de_Electrónica;

namespace Biblioteca_Ejercicio_2
{
    public class Smartphone : ProductoElectronico
    {
        public double capacidad_almacenamiento { get; set; }
        public Smartphone(int ID, string Nombre, double Precio, double Capacidad_Almacenamiento) : base(ID, Nombre, Precio)
        {
            this.capacidad_almacenamiento = Capacidad_Almacenamiento;
        }
        public override double CalcularImpuesto()
        {
            return Precio * 0.2;
        }
        public override double CalcularTotal()
        {
            return CalcularImpuesto() + Precio;
        }
        public string texto
        {
            get { return $"Smartphone: {Nombre}. Precio con impuesto: {CalcularTotal()}."; }
        }
    }
}
