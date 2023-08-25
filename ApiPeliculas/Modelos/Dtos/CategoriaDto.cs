using System.ComponentModel.DataAnnotations;

namespace ApiPeliculas.Modelos.Dtos
{
    public class CategoriaDto 
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [MaxLength(50, ErrorMessage = "El nombre no puede tener mas de 50 caracteres")]
        public required string Nombre { get; set; }
        public DateTime FechaCreacion { get; set;}
    }
}
