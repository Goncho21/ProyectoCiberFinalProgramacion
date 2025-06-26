using Microsoft.EntityFrameworkCore;
using ProyectoCiber.Models;

namespace ProyectoCiber.Data
{
    public class TurnoDBContext : DbContext
    {
        public TurnoDBContext(DbContextOptions<TurnoDBContext> options) : base(options) { }

        public DbSet<PC> PCs { get; set; }
      
        public DbSet<Turno> Turnos { get; set; }
    }
}
