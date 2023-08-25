using ApiPeliculas.Data;
using ApiPeliculas.Modelos;
using ApiPeliculas.Repositorio.IRepositorio;

namespace ApiPeliculas.Repositorio
{
    public class CategoriaRepositorio : ICategoriaRepositorio
    {
        private readonly ApplicationDbContext _Bd;
        public CategoriaRepositorio(ApplicationDbContext Bd)
        {
            _Bd = Bd;
        }

        public bool ActualizarCategoria(Categoria _Categoria)
        {
            _Categoria.FechaCreacion = DateTime.Now;
            _Bd.Categoria.Update(_Categoria);
            return Guardar();
        }

        public bool BorrarCategoria(Categoria _Categoria)
        {
            _Bd.Categoria.Remove(_Categoria);
            return Guardar();
        }

        public bool CrearCategoria(Categoria _Categoria)
        {
            _Categoria.FechaCreacion = DateTime.Now;
            _Bd.Categoria.Add(_Categoria);
            return Guardar();
        }

        public bool ExisteCategoria(string Nombre)
        {
            bool Valor = _Bd.Categoria.Any(c => c.Nombre.ToLower().Trim() == Nombre.ToLower().Trim());
            return Valor;
        }

        public bool ExisteCategoria(int Id)
        {
            return _Bd.Categoria.Any(c => c.Id == Id);

        }

        public Categoria GetCategoria(int CategoriaId)
        {
            return _Bd.Categoria.FirstOrDefault(c => c.Id == CategoriaId);

        }

        public ICollection<Categoria> GetCategorias()
        {
            return _Bd.Categoria.OrderBy(c => c.Nombre).ToList();
        }

        public bool Guardar()
        {
            return _Bd.SaveChanges() >= 0;
        }
    }
}
