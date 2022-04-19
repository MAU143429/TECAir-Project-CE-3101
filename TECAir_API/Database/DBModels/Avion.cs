using System;
using System.Collections.Generic;

namespace TECAir_API
{
    public partial class Avion
    {
        public Avion()
        {
            Vuelos = new HashSet<Vuelo>();
        }

        public string Matricula { get; set; } = null!;
        public string AvNombre { get; set; } = null!;
        public decimal Capacidad { get; set; }

        public virtual ICollection<Vuelo> Vuelos { get; set; }
    }
}
