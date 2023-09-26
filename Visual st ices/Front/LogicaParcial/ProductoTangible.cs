using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LogicaParcial
{
    public class ProductoTangible : Producto
    {
        public int cantidadStock {  get; set; }
        public string Name
        {
            get { return "Codigo: " + codigo + ", Nombre: " + nombre + ", Precio: " + precio + ", Cantidad Stock: " + cantidadStock; }

        }
    }
}
