using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Back
{
    public class Principal
    {
        ApplicationDBContext _context = new ApplicationDBContext();


        public void AgregarCliente(Cliente cliente)
        {
            _context.clientes.Add(cliente);
            _context.SaveChanges();
        }

        public void EnitirTarjeta_De_Credito(Tarjeta_de_Credito tarjeta_De_Credito)
        {
            _context.tarjetasDeCredito.Add(tarjeta_De_Credito);
            _context.SaveChanges();
        }
        public void PausarTarjeta_De_Credito(Tarjeta_de_Credito tarjeta_De_Credito)
        {
            _context.tarjetasDeCredito.Remove(tarjeta_De_Credito);
            _context.SaveChanges();
        }
        public void CrearCuenta_Bancaria(Cuenta_Bancaria cuenta_Bancaria)
        {
            _context.cuentasBancarias.Add(cuenta_Bancaria);
            _context.SaveChanges();
        }
        public void RealizarDeposito(Cuenta_Bancaria cuenta_Bancaria, double Monto)
        {
            cuenta_Bancaria.saldo += Monto;
            _context.SaveChanges();
        }
        public void RealizarExtraccion(Cuenta_Bancaria cuenta_Bancaria, double Monto)
        {
            if (cuenta_Bancaria.saldo >= Monto)
            {
                cuenta_Bancaria.saldo -= Monto;
                _context.SaveChanges();
            }
        }

        public void RealizarTransferencia(Cuenta_Bancaria emisor, Cuenta_Bancaria receptor, double Monto)
        {
            if (emisor.saldo >= Monto)
            {
                emisor.saldo -= Monto;
                receptor.saldo += Monto;
                _context.SaveChanges();
            }
        }

        public void PagarTarjetaCredito(Tarjeta_de_Credito tarjeta_De_Credito, double Monto) //no supe como armarlo 
        {
            _context.SaveChanges();
        }
        public void ResumenTarjetaDeCredito(Tarjeta_de_Credito tarjeta_De_Credito) //no supe como armarlo 
        {
            _context.SaveChanges();
        }
    }
}
