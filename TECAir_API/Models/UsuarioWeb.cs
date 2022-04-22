namespace TECAir_API.Models
{
    public class UsuarioWeb
    {
        public string u_nombre { get; set; }
        public string u_apellido1 { get; set; }
        public string u_apellido2 { get; set; }
        public string correo { get; set; }
        public string u_contrasena { get; set; }
        public int telefono  { get; set; }
        public string universidad { get; set; }
        public int carne { get; set; }

        public UsuarioWeb()
        {
        }

        public UsuarioWeb( string nombre, string apellido1, string apellido2, string correo, string contrasena, int telefono, string universidad, int carne)
        {
            this.u_nombre = nombre;
            this.u_apellido1 = apellido1;
            this.u_apellido2 = apellido2;
            this.correo = correo;
            this.u_contrasena = contrasena;
            this.telefono = telefono;
            this.universidad = universidad;
            this.carne = carne;
        }
    }
}