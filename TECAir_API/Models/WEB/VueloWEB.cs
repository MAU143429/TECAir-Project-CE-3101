namespace TECAir_API.Models.WEB
{
    public class VueloWEB
    {
        public string no_vuelo { get; set; }
        public string origen { get; set; }
        public string destino { get; set; }
        public string cant_escalas { get; set; }
        public string fecha { get; set; }
        public string h_salida { get; set; }
        public string h_llegada { get; set; }
        public string precio { get; set; }

        public VueloWEB()
        {
        }

        public VueloWEB(string vuelo, string origen, string destino, string salida, string llegada, string fecha, string escalas, string precio)
        {
            this.no_vuelo = vuelo;
            this.origen = origen;
            this.destino = destino;
            this.h_salida = salida;
            this.h_llegada = llegada;
            this.cant_escalas = escalas;
            this.precio = precio;
            this.fecha = fecha;
        }
    }
}
