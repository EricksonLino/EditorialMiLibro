using System.ComponentModel.DataAnnotations;

namespace EditorialMiLibro.Application.Dtos
{
    public class LibroDetalleDto
    {        
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Autor { get; set; }  
        public string Descripción { get; set; }      
        public string Género { get; set; }        
        public DateTime FechadePublicación { get; set; }
        public string EjemplaresProducidas { get; set; }
    }
}
