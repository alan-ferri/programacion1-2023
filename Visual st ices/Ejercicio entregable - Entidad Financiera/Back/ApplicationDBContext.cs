using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<Cliente> clientes { get; set; }
        public DbSet<Cuenta_Bancaria> cuentasBancarias { get; set; }
        public DbSet<Tarjeta_de_Credito> tarjetasDeCredito { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("&quot; server = DESKTOP-E1BS63E\\SQLEXPRESS; database = EntidadFinanciera; trusted_connection = true; Encrypt = False & quot");
        }
    }
}
