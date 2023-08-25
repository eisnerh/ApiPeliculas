using ApiPeliculas.Modelos;

namespace ApiPeliculas.Repositorio.IRepositorio
{
    public interface ICategoriaRepositorio
    {
        ICollection<Categoria> GetCategorias();
        Categoria GetCategoria(int CategoriaId);
        bool ExisteCategoria(string Nombre);
        bool ExisteCategoria(int Id);
        bool CrearCategoria(Categoria _Categoria);
        bool ActualizarCategoria(Categoria _Categoria);
        bool BorrarCategoria(Categoria _Categoria);
        bool Guardar();

    }
}
