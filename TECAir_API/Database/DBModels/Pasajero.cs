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

        public Pasajero(decimal dni, string pNombre, string pApellido1, string pApellido2, decimal cantMaletas, bool chequeado, decimal noTransaccion)
        {
            Dni = dni;
            PNombre = pNombre;
            PApellido1 = pApellido1;
            PApellido2 = pApellido2;
            CantMaletas = cantMaletas;
            Chequeado = chequeado;
            NoTransaccion = noTransaccion;
        }
    }
}
