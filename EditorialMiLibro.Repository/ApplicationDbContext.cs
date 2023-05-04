using EditorialMiLibro.Entity;
using Microsoft.EntityFrameworkCore;

namespace EditorialMiLibro.Repository
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Libro> MisLibros { get; set; }   
    }
}
