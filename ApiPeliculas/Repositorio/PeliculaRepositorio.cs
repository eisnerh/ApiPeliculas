using ApiPeliculas.Data;
using ApiPeliculas.Modelos;
using ApiPeliculas.Repositorio.IRepositorio;

namespace ApiPeliculas.Repositorio
{
    public class PeliculaRepositorio : IPeliculaRepositorio
    {
        private readonly ApplicationDbContext _Bd;
        public PeliculaRepositorio(ApplicationDbContext Bd)
        {
            _Bd = Bd;
        }

        public bool ActualizarPelicula(Pelicula _Pelicula)
        {
            _Pelicula.FechaCreacion = DateTime.Now;
            _Bd.Pelicula.Update(_Pelicula);
            return Guardar();
        }

        public bool BorrarPelicula(Pelicula _Pelicula)
        {
            _Bd.Pelicula.Remove(_Pelicula);
            return Guardar();
        }

        public bool CrearPelicula(Pelicula _Pelicula)
        {
            _Pelicula.FechaCreacion = DateTime.Now;
            _Bd.Pelicula.Add(_Pelicula);
            return Guardar();
        }

        public bool ExistePelicula(string Nombre)
        {
            bool Valor = _Bd.Pelicula.Any(c => c.Nombre.ToLower().Trim() == Nombre.ToLower().Trim());
            return Valor;
        }

        public bool ExistePelicula(int Id)
        {
            return _Bd.Pelicula.Any(c => c.Id == Id);

        }

        public Pelicula GetPelicula(int PeliculaId)
        {
            return _Bd.Pelicula.FirstOrDefault(c => c.Id == PeliculaId);

        }

        public ICollection<Pelicula> GetPeliculas()
        {
            return _Bd.Pelicula.OrderBy(c => c.Nombre).ToList();
        }

        public bool Guardar()
        {
            return _Bd.SaveChanges() >= 0;
        }
    }
}
