using BP_Andres.Shared.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP_Andres.Shared
{
    public class DTO
    {
        public int Id { get; set; }
        public string NumeroBoleta { get; set; } = null!;

        public DateTime? FechaUso { get; set; } = null;

        public bool FueUsada { get; set; } = false;

        public Porterias? Porterias { get; set; } = null;

    }
}
