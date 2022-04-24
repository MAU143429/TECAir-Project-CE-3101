using System;
using System.Collections.Generic;

namespace TECAir_API
{
    public partial class Tiquete
    {
        public Tiquete()
        {
            Pasajeros = new HashSet<Pasajero>();
        }

        public decimal NoTransaccion { get; set; }
        public string TDia { get; set; } = null!;
        public string TMes { get; set; } = null!;
        public string TAno { get; set; } = null!;
        public bool Abordaje { get; set; }
        public decimal NoReservacion { get; set; }
        public decimal NoAsiento { get; set; }

        public virtual Asiento NoAsientoNavigation { get; set; } = null!;
        public virtual Reservacion NoReservacionNavigation { get; set; } = null!;
        public virtual ICollection<Pasajero> Pasajeros { get; set; }

        public Tiquete(decimal noTransaccion, string tDia, string tMes, string tAno, bool abordaje, decimal noReservacion, decimal noAsiento)
        {
            NoTransaccion = noTransaccion;
            TDia = tDia;
            TMes = tMes;
            TAno = tAno;
            Abordaje = abordaje;
            NoReservacion = noReservacion;
            NoAsiento = noAsiento;
        }
    }
}
