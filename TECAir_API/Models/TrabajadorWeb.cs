namespace TECAir_API.Models
{
    public class TrabajadorWeb
    {
        public string id_trabajador { get; set; }
        public string t_contrasena { get; set; }

        public TrabajadorWeb()
        {
        }

        public TrabajadorWeb(string id, string contrasena)
        {
            this.id_trabajador = id;
            this.t_contrasena = contrasena;
        }
    }
}
