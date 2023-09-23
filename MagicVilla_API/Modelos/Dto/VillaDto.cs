using System.ComponentModel.DataAnnotations;

namespace MagicVilla_API.Modelos.Dto
{
    public class VillaDto
    {
        public int Id { get; set; }
        [Required] //Hace que el parámetro sea requerido
        [MaxLength(30)] //Hace que tenga un máximo que uno define
        public string Nombre { get; set; }

        public int Ocupantes { get; set; }
        public int MetrosCuadrados { get; set; }
    }
}
