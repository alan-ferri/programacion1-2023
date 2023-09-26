using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back
{
    public class Tarjeta_de_Credito
    {
        public int idTC { get; set; }
        public int numerotarjeta { get; set; }
        public decimal limitecredito { get; set; }
        public decimal saldodisponible { get; set; }
        public EstadoTarjeta Estado { get; set; } = EstadoTarjeta.Activa;

        public Tarjeta_de_Credito ( int numerotarjeta, decimal limitecredito, decimal saldodisponible, EstadoTarjeta estado)
        {
            this.numerotarjeta = numerotarjeta;
            this.limitecredito = limitecredito;
            this.saldodisponible = saldodisponible; 
            this.Estado = estado;   

        }

        public enum EstadoTarjeta
        {
            Activa,
            Pausada,
            Bloqueada
        }
    }
}
