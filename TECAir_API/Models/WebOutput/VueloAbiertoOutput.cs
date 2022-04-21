namespace TECAir_API.Models.WebOutput
{
    public class VueloAbiertoOutput
    {
        public string no_vuelo { get; set; }
        public string p_nombre { get; set; }
        public string origen { get; set; }
        public string destino { get; set; }
        public string abordaje { get; set; }
        public int no_transaccion { get; set; }

        public VueloAbiertoOutput(string no_vuelo, string nombre, string origen, string destino, string abordara)
        {
            this.no_vuelo = no_vuelo;
            this.p_nombre = nombre;
            this.origen = origen;
            this.destino = destino;
            this.abordaje = abordara;
        }

        public VueloAbiertoOutput()
        {
        }
    }
}
