using AutoMapper;

namespace ApiPeliculas.Peliculas_Mapper
{
    public class PeliculasMapper : Profile
    {
        public PeliculasMapper()
        {
            CreateMap<Modelos.Categoria, Modelos.Dtos.CategoriaDto>().ReverseMap();
            CreateMap<Modelos.Categoria, Modelos.Dtos.CrearCategoriaDto>().ReverseMap();
            CreateMap<Modelos.Pelicula, Modelos.Dtos.PeliculaDto>().ReverseMap();
        }
    }
}
