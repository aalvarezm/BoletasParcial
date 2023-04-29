using BP_Andres.Shared.Entities.Enums;
using System.ComponentModel.DataAnnotations;

namespace BP_Andres.Shared.Entities
{
    public class Boleta
    {
        public int Id { get; set; }

        [Display(Name = "Fecha de uso")]
        public DateTime? FechaUso { get; set; }

        public bool FueUsada { get; set; }

        public Porterias? PuertaDeEntrada { get; set; } = null;

        public string NumeroBoleta { get; set; } = null!;
    }
}
