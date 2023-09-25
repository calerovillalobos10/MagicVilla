using System.Linq.Expressions;

namespace MagicVilla_API.Repositorio.IRepositorio
{
    // Esto del where hace que la interfaz sea genérica
    // Esto quiere decir que se puede recibir cualquier tipo de identidad
    public interface IRepositorio<T> where T : class
    {
        Task Crear(T entidad);
        // Lo que está dentro de los (de ObtenerTodos es como un tipo de filtro)
        // Esto de alguna manera hay que enviarlo al Repositorio genérico (esta clase), por lo que para declara una expresión I se utiliza Expression
        // Se agrega el ? para que si no se le envía el filtro retorne toda la lista, sino que aplique el filtro
        Task<List<T>> ObtenerTodos(Expression<Func<T, bool>>? filtro = null);
        // Este solo obtiene un registro
        // Se agrega el tracked=true para evitar el problema con el tracking
        Task<T> Obtener(Expression<Func<T, bool>> filtro = null, bool tracked=true);
        Task<T> Remover(T entidad);
        Task Grabar();
    }
}
