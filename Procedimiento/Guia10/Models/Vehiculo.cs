using System.ComponentModel.DataAnnotations;

namespace Guia10.Models
{
    public class Vehiculo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 3)]
        public string Nombre { get; set; } = string.Empty;

        [Required]
        public int AnioFabricacion { get; set; }

        [Required]
        public int? ModeloId { get; set; }

        public Modelo? Modelo { get; set; }
    }
}
