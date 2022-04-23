using System;
using System.Collections.Generic;

namespace TECAir_API
{
    public partial class Reservacion
    {
        public Reservacion()
        {
            Tiquetes = new HashSet<Tiquete>();
        }

        public decimal NoReservacion { get; set; }
        public bool Cancelado { get; set; }
        public decimal NoVuelo { get; set; }
        public decimal? IdUsuario { get; set; }
        public string? IdTrabajador { get; set; }

        public virtual Trabajador? IdTrabajadorNavigation { get; set; }
        public virtual Usuario? IdUsuarioNavigation { get; set; }
        public virtual Vuelo NoVueloNavigation { get; set; } = null!;
        public virtual ICollection<Tiquete> Tiquetes { get; set; }

        public Reservacion(decimal noReservacion, bool cancelado, decimal noVuelo, decimal idUsuario, string idTrabajador)
        {
            NoReservacion = noReservacion;
            Cancelado = cancelado;
            NoVuelo = noVuelo;
            IdUsuario = idUsuario;
            IdTrabajador = idTrabajador;
        }
    }
}
