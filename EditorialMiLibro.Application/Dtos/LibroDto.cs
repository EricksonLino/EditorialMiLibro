using System.ComponentModel.DataAnnotations;

namespace EditorialMiLibro.Application.Dtos
{
    public class LibroDto
    {
       
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Autor { get; set; }
        public string Descripción { get; set; }
        public string Género { get; set; }
    }
}
