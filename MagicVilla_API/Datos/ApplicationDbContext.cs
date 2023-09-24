using MagicVilla_API.Modelos;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_API.Datos
{
    public class ApplicationDbContext: DbContext
    {
        //Esto indica que nuestra base (la clase Db Context) indica el padre DbContext
        //El :base siempre indica el padre
        //Después se le envía toda la configuración por medio de inyección de dependencias

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {
            
        }

        //Normalmente se pone el nombre en plural
        public DbSet<Villa> Villas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Para agregar datos se le agrega el HasData
            // Con esto se pueden agregar registros a la tabla de SQL una vez que se crea
            // Para agregar estos datos se debe ejecutar una nueva migración add-migration
            // Después se debe ejecutar el update-database
            modelBuilder.Entity<Villa>().HasData(
                new Villa()
                {
                    Id = 1,
                    Nombre = "Villa Real",
                    Detalle = "Detalle de la Villa...",
                    ImageUrl = "",
                    Ocupantes = 5,
                    MetrosCuadrados = 50,
                    Trifa = 200,
                    Amenidad = "",
                    FechaCreacion = DateTime.Now,
                    FechaActualizacion = DateTime.Now
                },
                new Villa()
                {
                    Id = 2,
                    Nombre = "Premium Vista a la Piscina",
                    Detalle = "Detalle de la Villa...",
                    ImageUrl = "",
                    Ocupantes = 4,
                    MetrosCuadrados = 40,
                    Trifa = 150,
                    Amenidad = "",
                    FechaCreacion = DateTime.Now,
                    FechaActualizacion = DateTime.Now
                }
            );
        }
    }
}
