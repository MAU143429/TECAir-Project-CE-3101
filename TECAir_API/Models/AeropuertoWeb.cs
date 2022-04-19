namespace TECAir_API.Models
{
    public class AeropuertoWeb
    {
        public string nombre { get; set; }
        public string ciudad { get; set; }
        public string pais { get; set; }
        public string codigo { get; set; }

        public AeropuertoWeb()
        {
        }

        public AeropuertoWeb(string nombre, string ciudad, string pais, string codigo)
        {
            this.nombre = nombre;
            this.ciudad = ciudad;
            this.pais = pais;
            this.codigo = codigo;
        }
    }
}
