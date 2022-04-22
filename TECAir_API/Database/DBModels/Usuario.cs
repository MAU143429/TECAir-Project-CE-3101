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

        public Usuario(decimal idUsuario, string uNombre, string uApellido1, string uApellido2, string correo, string uContrasena, decimal telefono)
        {
            IdUsuario = idUsuario;
            UNombre = uNombre;
            UApellido1 = uApellido1;
            UApellido2 = uApellido2;
            Correo = correo;
            UContrasena = uContrasena;
            Telefono = telefono;
        
        }
    }
}
