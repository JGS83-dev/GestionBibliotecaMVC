using Microsoft.EntityFrameworkCore;
using GestionBibliotecaMVC.Models;

namespace GestionBibliotecaMVC.Models
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        public DbSet<Autor> autores { get; set; } = null!;
        public DbSet<Libro> Libro { get; set; } = null!;
        public DbSet<Categoria> Categoria { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder model)
        {
            base.OnModelCreating(model);
        }
    }
}
