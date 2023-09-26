using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaParcial
{
    public class ProductoDigital : Producto
    {
        public int tamañoArchivo { get; set; }

        public string Name
        {
            get { return "Codigo: " + codigo + ", Nombre: " + nombre + ", Precio: " + precio + ", Tamaño Archivo: " + tamañoArchivo; }

        }
    }
}
