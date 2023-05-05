using EditorialMiLibro.Application.Dtos;
using EditorialMiLibro.Entity;

namespace EditorialMiLibro.Application.Interfaces
{
    public interface IlibroApplication
    {
        Task<List<LibroDto>> ListarLibros();
        Task<LibroDetalleDto> ObtenerLibro(int id);
    }
}
