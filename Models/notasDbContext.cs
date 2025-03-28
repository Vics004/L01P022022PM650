using Microsoft.EntityFrameworkCore;
namespace L01P022022PM650.Models
{
    public class notasDbContext : DbContext
    {
        public notasDbContext(DbContextOptions<notasDbContext> options) : base(options)
        { 

        }

        public DbSet<alumnos> alumnos { get; set; }
        public DbSet<facultades> facultades { get; set; }
        public DbSet<materias> materias { get; set; }
        public DbSet<departamentos> departamentos { get; set; }
    }
}
