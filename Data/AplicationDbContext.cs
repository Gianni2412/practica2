using Microsoft.EntityFrameworkCore;
using practica2.Models;
using practica2_1.Models;

namespace practica2_1.Data
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options)
           : base(options)
        {
        }

        public DbSet<Formulario> Formularios { get; set; }
        public DbSet<Producto> Productos { get; set; }


    }
}