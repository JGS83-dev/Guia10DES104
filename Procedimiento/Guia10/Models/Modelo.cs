using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Guia10.Models
{
    public class Modelo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 3)]
        public string Nombre { get; set; } = string.Empty;

        public int? MarcaId { get; set; }

        public Marca? Marca { get; set; }

        public ICollection<Vehiculo>? Vehiculos { get; set; }
    }
}
