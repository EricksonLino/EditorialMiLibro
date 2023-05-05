using AutoMapper;
using EditorialMiLibro.Application.Dtos;
using EditorialMiLibro.Entity;

namespace EditorialMiLibro.Application.Profiles
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Libro, LibroDto>();
            
        }
    }
}
