using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;

namespace ProyectoFinal.Data
{
    public class BingoContext:DbContext
    {
        
        public BingoContext(DbContextOptions<BingoContext> options)
            :base(options)
        {
        }

        public DbSet<HistorialBolillero> HistorialBolilleros { get; set; }
        public DbSet<HistorialCartones> HistorialCartones { get; set; }

    }
}
