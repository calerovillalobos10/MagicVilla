using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagicVilla_API.Modelos
{
    public class Villa
    {
        [Key] // Con esta notación se indica que esta será el primary key en la tabla de la BD
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]// hace que se generen ids autoincrementables
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Detalle { get; set; }
        [Required]
        public double Trifa { get; set; }
        public int Ocupantes { get; set; }
        public int MetrosCuadrados { get; set; }
        public string ImageUrl { get; set; }
        public string Amenidad { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaActualizacion { get; set; }
    }
}
