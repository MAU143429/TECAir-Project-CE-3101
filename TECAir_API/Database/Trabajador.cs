using System;
using System.Collections.Generic;

namespace TECAir_API
{
    public partial class Trabajador
    {
        public Trabajador()
        {
            Reservacions = new HashSet<Reservacion>();
        }

        public string IdTrabajador { get; set; } = null!;
        public string TContrasena { get; set; } = null!;

        public virtual ICollection<Reservacion> Reservacions { get; set; }
    }
}
