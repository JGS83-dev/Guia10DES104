using System.ComponentModel.DataAnnotations;

namespace Guia10.Models
{
    public class Marca
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 3)]
        public string Nombre { get; set; } = string.Empty;

        public ICollection<Modelo>? Modelo { get; set; }
    }
}
