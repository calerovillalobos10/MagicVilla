using MagicVilla_API.Modelos;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_API.Datos
{
    public class ApplicationDbContext: DbContext
    {
        //Normalmente se pone el nombre en plural
        public DbSet<Villa> Villas { get; set; }
    }
}
