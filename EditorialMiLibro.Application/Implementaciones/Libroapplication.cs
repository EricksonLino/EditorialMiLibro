using AutoMapper;
using EditorialMiLibro.Application.Dtos;
using EditorialMiLibro.Application.Interfaces;
using EditorialMiLibro.Repository.Interfaces;

namespace EditorialMiLibro.Application.Implementaciones
{
    public class Libroapplication : IlibroApplication
    {
        private readonly ILibroRepository libroRepository;
        private readonly IMapper mapper;

        public Libroapplication(ILibroRepository libroRepository, IMapper mapper)
        {
            this.libroRepository = libroRepository;
            this.mapper = mapper;
        }
        public async Task<List<LibroDto>> ListarLibros()
        {
            var misLibros = await this.libroRepository.ListarLibros();
            var librosDto = this.mapper.Map<List<LibroDto>>(misLibros);
            return librosDto;

            
        }
    }
}
