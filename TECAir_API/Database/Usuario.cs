using System;
using System.Collections.Generic;

namespace TECAir_API
{
    public partial class Usuario
    {
        public Usuario()
        {
            Estudiantes = new HashSet<Estudiante>();
            Reservacions = new HashSet<Reservacion>();
        }

        public decimal IdUsuario { get; set; }
        public string UNombre { get; set; } = null!;
        public string UApellido1 { get; set; } = null!;
        public string UApellido2 { get; set; } = null!;
        public string Correo { get; set; } = null!;
        public string UContrasena { get; set; } = null!;
        public decimal Telefono { get; set; }

        public virtual ICollection<Estudiante> Estudiantes { get; set; }
        public virtual ICollection<Reservacion> Reservacions { get; set; }
    }
}
