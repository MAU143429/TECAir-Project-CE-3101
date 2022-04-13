namespace TECAir_API.Models
{
    public class Trabajador
    {
        public int id_trabajador { get; set; }
        public string t_contrasena { get; set; }

        public Trabajador()
        {
        }

        public Trabajador(int id, string contrasena)
        {
            this.id_trabajador = id;
            this.t_contrasena = contrasena;
        }
    }
}
