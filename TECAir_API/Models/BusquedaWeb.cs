namespace TECAir_API.Models
{
    public class BusquedaWeb
    {
        public string origen { get; set; }
        public string destino { get; set; }
        public string fecha { get; set; }

        public BusquedaWeb(string origen, string destino, string fecha)
        {
            this.origen = origen;
            this.destino = destino;
            this.fecha = fecha;
        }

        public BusquedaWeb()
        {
        }
    }
}
