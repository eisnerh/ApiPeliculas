﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiPeliculas.Modelos
{
    public class Pelicula
    {
        [Key]
        public int Id { get; set; }
        public required string Nombre { get; set; }
        public string RutaImagen { get; set; }
        [Required]
        public required string Descripcion { get; set; }
        [Required]
        public int Duracion { get; set; }
        public enum TipoClasificacion { Siete, Trece, Dieciseis, Dieciocho }
        public TipoClasificacion Clasificacion { get; set; }
        public  DateTime FechaCreacion { get; set; }
        [ForeignKey("CategoriaId")]
        public  int CategoriaId { get; set; }
        public required Categoria Categoria { get; set; }
    }
}
