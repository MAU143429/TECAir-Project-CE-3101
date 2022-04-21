namespace TECAir_API.Models.WebOutput
{
    public class VueloCerradoOutput
    {
        public string no_vuelo { get; set; }
        public string origen { get; set; }
        public string destino { get; set; }
        public string h_salida { get; set; }

        public VueloCerradoOutput(string no_vuelo, string origen, string destino, string h_salida)
        {
            this.no_vuelo = no_vuelo;
            this.origen = origen;
            this.destino = destino;
            this.h_salida = h_salida;
        }

        public VueloCerradoOutput()
        {
        }
    }
}
