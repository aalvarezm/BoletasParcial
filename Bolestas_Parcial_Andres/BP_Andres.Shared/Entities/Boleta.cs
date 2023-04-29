using System.ComponentModel.DataAnnotations;

namespace BP_Andres.Shared.Entities
{
    public class Boleta
    {
        public int Id { get; set; }

        [Display(Name = "Fecha de uso")]
        public DateTime FechaUso { get; set; }

        [Required]
        public bool FueUsada { get; set; }
    }
}
