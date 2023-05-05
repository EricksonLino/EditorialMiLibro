using EditorialMiLibro.Application.Dtos;
using EditorialMiLibro.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EditorialMiLibro.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibrosController : ControllerBase
    {
        private readonly IlibroApplication libroApplication;

        public LibrosController(IlibroApplication libroApplication)
        {
            this.libroApplication = libroApplication;
        }

        [HttpGet]
        public async Task<ActionResult<List<LibroDto>>> ListarLibros()
        {
            var misLibros = await this.libroApplication.ListarLibros();
            return misLibros;
        }
    }
}
