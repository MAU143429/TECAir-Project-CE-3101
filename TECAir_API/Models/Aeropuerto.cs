namespace TECAir_API.Models
{
    public class Aeropuerto
    {
        public string nombre { get; set; }
        public string ciudad { get; set; }
        public string pais { get; set; }
        public string codigo { get; set; }

        public Aeropuerto()
        {
        }

        public Aeropuerto(string nombre, string ciudad, string pais, string codigo)
        {
            this.nombre = nombre;
            this.ciudad = ciudad;
            this.pais = pais;
            this.codigo = codigo;
        }
    }
}
