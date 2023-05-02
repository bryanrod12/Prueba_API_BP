using Microsoft.EntityFrameworkCore;
using BancoApi.Modelo;

namespace BancoApi.Acceso_Datos
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options)
            : base(options)
        { 
        
        }


        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Cuenta> Cuentas { get; set; }

        public DbSet<Movimiento> Movimientos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().ToTable("Cliente");
            modelBuilder.Entity<Cuenta>().ToTable("Cuenta");
            modelBuilder.Entity<Movimiento>().ToTable("Movimiento");
        }
    }
}
