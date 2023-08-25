using ApiPeliculas.Modelos;

namespace ApiPeliculas.Repositorio.IRepositorio
{
    public interface IPeliculaRepositorio
    {
        ICollection<Pelicula> GetPeliculas();
        Pelicula GetPelicula(int PeliculaId);
        bool ExistePelicula(string Nombre);
        bool ExistePelicula(int Id);
        bool CrearPelicula(Pelicula _Pelicula);
        bool ActualizarPelicula(Pelicula _Pelicula);
        bool BorrarPelicula(Pelicula _Pelicula);
        bool Guardar();

    }
}
