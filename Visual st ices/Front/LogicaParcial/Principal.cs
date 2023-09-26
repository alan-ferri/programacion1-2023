using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaParcial
{
    public class Principal
    {
        public List<ProductoTangible> Listaproductostangibles = new List<ProductoTangible>();
        public List<ProductoDigital> ListaproductoDigital = new List<ProductoDigital>(); 

        public void AltaPrductosTangibles(ProductoTangible productoTangibleP)
        {
            ProductoTangible productoTangible = new ProductoTangible();
            productoTangible.codigo = productoTangibleP.codigo;
            productoTangible.nombre = productoTangibleP.nombre;
            productoTangible.precio = productoTangibleP.precio;
            productoTangible.cantidadStock = productoTangibleP.cantidadStock;

            Listaproductostangibles.Add(productoTangible);
        }
        public void BajaProductoTangible(ProductoTangible productoTangibleP)
        {
            Listaproductostangibles.Remove(productoTangibleP);
        }

        public void AltaPrductosDigitales(ProductoDigital productoDigitalesP)
        {
            ProductoDigital productoDigital = new ProductoDigital();
            productoDigitalesP.codigo = productoDigitalesP.codigo;
            productoDigitalesP.nombre = productoDigitalesP.nombre;
            productoDigitalesP.precio = productoDigitalesP.precio;
            productoDigitalesP.tamañoArchivo = productoDigitalesP.tamañoArchivo;

            ListaproductoDigital.Add(productoDigital);
        }

        public void BajaProductoDigitales(ProductoDigital productoDigitalesP)
        {
            ListaproductoDigital.Remove(productoDigitalesP);
        }


    }
        
}
