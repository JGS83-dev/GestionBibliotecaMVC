using Microsoft.EntityFrameworkCore;

namespace GestionBibliotecaMVC.Models
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        public DbSet<Autor> autores { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder model)
        {
            base.OnModelCreating(model);
        }
    }
}
