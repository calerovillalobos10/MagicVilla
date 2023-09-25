using MagicVilla_API.Datos;
using MagicVilla_API.Repositorio.IRepositorio;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace MagicVilla_API.Repositorio
{
    // Esta clase es la que va a implementar la interfaz IRepositorio
    public class Repositorio<T> : IRepositorio<T> where T : class
    {
        // Aquí es donde se trabajará con el Db Context y no con el controlador
        // Se debe inyectar de igual manera
        private readonly ApplicationDbContext _db;
        internal DbSet<T> dbSet;

        public Repositorio(ApplicationDbContext db)
        {
            _db = db;
            // De esta manera se está convirtiendo esa T en una entidad
            dbSet = _db.Set<T>();
        }

        public async Task Crear(T entidad)
        {
            await dbSet.AddAsync(entidad);
            await Grabar();
        }

        public async Task Grabar()
        {
            await _db.SaveChangesAsync();
        }

        public async Task<T> Obtener(Expression<Func<T, bool>> filtro = null, bool tracked = true)
        {
            // Se ocupa una variable que permita hacer querys IQueryable
            IQueryable<T> query = dbSet;

            if (!tracked)
            {
                query = query.AsNoTracking();
            }

            if (filtro != null)
            {
                // El where siempre trabaja con una expresión link
                query = query.Where(filtro);
            }

            return await query.FirstOrDefaultAsync();
        }

        public async Task<List<T>> ObtenerTodos(Expression<Func<T, bool>>? filtro = null)
        {
            // Se ocupa una variable que permita hacer querys IQueryable
            IQueryable<T> query = dbSet;

            if (filtro != null)
            {
                // El where siempre trabaja con una expresión link
                query = query.Where(filtro);
            }

            return await query.ToListAsync();
        }

        public async Task Remover(T entidad)
        {
            dbSet.Remove(entidad);
            await Grabar();
        }
    }
}
