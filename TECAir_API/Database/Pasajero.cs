using System;
using System.Collections.Generic;

namespace TECAir_API
{
    public partial class Pasajero
    {
        public Pasajero()
        {
            Maleta = new HashSet<Maletum>();
        }

        public decimal Dni { get; set; }
        public string PNombre { get; set; } = null!;
        public string PApellido1 { get; set; } = null!;
        public string PApellido2 { get; set; } = null!;
        public decimal CantMaletas { get; set; }
        public bool Chequeado { get; set; }
        public decimal NoTransaccion { get; set; }

        public virtual Tiquete NoTransaccionNavigation { get; set; } = null!;
        public virtual ICollection<Maletum> Maleta { get; set; }
    }
}
