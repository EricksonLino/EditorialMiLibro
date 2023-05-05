using EditorialMiLibro.Entity;

namespace EditorialMiLibro.Repository.Interfaces
{
    public interface ILibroRepository
    {
        Task<List<Libro>> ListarLibros();
        Task<Libro> ObtenerLibro(int Id);
    }
}
