using System;
using System.Collections.Generic;

namespace TECAir_API
{
    public partial class Estudiante
    {
        public decimal Carne { get; set; }
        public string Universidad { get; set; } = null!;
        public decimal IdUsuario { get; set; }

        public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
    }
}
