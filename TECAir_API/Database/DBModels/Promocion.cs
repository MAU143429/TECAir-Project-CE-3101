using System;
using System.Collections.Generic;

namespace TECAir_API
{
    public partial class Promocion
    {
        public decimal NoPromocion { get; set; }
        public decimal Porcentaje { get; set; }
        public decimal Periodo { get; set; }
        public string Url { get; set; } = null!;
        public string PDia { get; set; } = null!;
        public string PMes { get; set; } = null!;
        public string PAno { get; set; } = null!;
        public decimal NoVuelo { get; set; }

        public virtual Vuelo NoVueloNavigation { get; set; } = null!;
    }
}
