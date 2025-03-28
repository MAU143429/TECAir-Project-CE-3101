﻿using System;
using System.Collections.Generic;

namespace TECAir_API
{
    public partial class Maletum
    {
        public decimal NoMaleta { get; set; }
        public string Color { get; set; } = null!;
        public decimal Peso { get; set; }
        public decimal Dni { get; set; }
        public decimal NoVuelo { get; set; }

        public Maletum()
        {
        }

        public virtual Pasajero DniNavigation { get; set; } = null!;
        public virtual Vuelo NoVueloNavigation { get; set; } = null!;

        public Maletum(decimal noMaleta, string color, decimal peso, decimal dni, decimal noVuelo)
        {
            NoMaleta = noMaleta;
            Color = color;
            Peso = peso;
            Dni = dni;
            NoVuelo = noVuelo;
        }
    }
}
