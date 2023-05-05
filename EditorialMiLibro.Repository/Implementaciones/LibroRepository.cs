using EditorialMiLibro.Entity;
using EditorialMiLibro.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EditorialMiLibro.Repository.Implementaciones
{
    public class LibroRepository : ILibroRepository
    {
        private readonly ApplicationDbContext context;

        public LibroRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public async Task<List<Libro>> ListarLibros()
        {
            var misLibros = await context.MisLibros.ToListAsync();
            return misLibros;
        }

        public async Task<Libro> ObtenerLibro(int Id)
        {
            var libro = await context.MisLibros.FirstOrDefaultAsync(x => x.Id == Id);
            return libro;
            
        }
    }
}
