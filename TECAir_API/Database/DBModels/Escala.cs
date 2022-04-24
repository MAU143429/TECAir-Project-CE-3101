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

        public Escala(decimal noEscala, string escala1, decimal orden, decimal noVuelo)
        {
            NoEscala = noEscala;
            Escala1 = escala1;
            Orden = orden;
            NoVuelo = noVuelo;
        }
    }
}
