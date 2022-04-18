using System;
using System.Collections.Generic;

namespace TECAir_API
{
    public partial class Escala
    {
        public decimal NoEscala { get; set; }
        public string Escala1 { get; set; } = null!;
        public decimal Orden { get; set; }
        public decimal NoVuelo { get; set; }

        public virtual Vuelo NoVueloNavigation { get; set; } = null!;
    }
}
