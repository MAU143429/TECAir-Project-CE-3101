using System;
using System.Collections.Generic;

namespace TECAir_API
{
    public partial class Asiento
    {
        public Asiento()
        {
            Tiquetes = new HashSet<Tiquete>();
        }

        public decimal NoAsiento { get; set; }
        public string Ubicacion { get; set; } = null!;
        public decimal NoVuelo { get; set; }

        public virtual Vuelo NoVueloNavigation { get; set; } = null!;
        public virtual ICollection<Tiquete> Tiquetes { get; set; }

        public Asiento(decimal noAsiento, string ubicacion, decimal noVuelo)
        {
            NoAsiento = noAsiento;
            Ubicacion = ubicacion;
            NoVuelo = noVuelo;
        }
    }
}
