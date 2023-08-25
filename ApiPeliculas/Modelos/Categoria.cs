using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ApiPeliculas.Modelos
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }
        [Required (ErrorMessage = "El nombre es requerido")]
        public required string Nombre { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
