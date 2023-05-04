using System.ComponentModel.DataAnnotations;

namespace EditorialMiLibro.Entity
{
    public class Libro
    {
        [Key]        
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }
        [Required]
        [StringLength(50)]
        public string Autor { get; set; }
        [Required]
        [StringLength(350)]
        public string Descripción { get; set; }
        [Required]
        [StringLength (100)]
        public string Género { get; set; }
        [Required]
        public DateTime FechadePublicación { get; set; }
        [StringLength(150)]
        public string EjemplaresProducidas { get; set; }
    }
}
