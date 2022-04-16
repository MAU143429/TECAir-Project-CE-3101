namespace TECAir_API.Models
{
    public class Busqueda
    {
        public string origen { get; set; }
        public string destino { get; set; }
        public string fecha { get; set; }

        public Busqueda(string origen, string destino, string fecha)
        {
            this.origen = origen;
            this.destino = destino;
            this.fecha = fecha;
        }

        public Busqueda()
        {
        }
    }
}
