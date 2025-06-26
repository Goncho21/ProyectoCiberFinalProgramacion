using Microsoft.EntityFrameworkCore;
using ProyectoCiber.Models;

namespace ProyectoCiber.Data
{
    public class NuevoTurnoDBContext : DbContext
    {
        // Constructor sin parámetros para usar directamente en Windows Form
        public NuevoTurnoDBContext()
        {
        }

        // Constructor con opciones, NuevoTurnoDBContext, no TurnoDBContext
        public NuevoTurnoDBContext(DbContextOptions<NuevoTurnoDBContext> options) : base(options)
        {
        }

        public DbSet<PC> PCs { get; set; }
        public DbSet<Turno> Turnos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=CiberDB;Trusted_Connection=True;Encrypt=False;");
            }
        }



    }
}
