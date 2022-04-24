namespace TECAir_API.Models.WebOutput
{
    public class PromosOutput
    {
        public int no_promocion { get; set; }
        public int porcentaje { get; set; }
        public string url { get; set; }
        public string p_dia { get; set; }
        public string p_mes { get; set; }
        public string p_ano { get; set; }
        public int no_vuelo { get; set; }
        public string origen { get; set; }
        public string destino { get; set; }
        public int coste_vuelo { get; set; }

        public PromosOutput()
        {
        }

        public PromosOutput(int no_promocion, int porcentaje, string url, string p_dia, string p_mes, string p_ano, int no_vuelo, string origen, string destino, int coste_vuelo)
        {
            this.no_promocion = no_promocion;
            this.porcentaje = porcentaje;
            this.url = url;
            this.p_dia = p_dia;
            this.p_mes = p_mes;
            this.p_ano = p_ano;
            this.no_vuelo = no_vuelo;
            this.origen = origen;
            this.destino = destino;
            this.coste_vuelo = coste_vuelo;
        }
    }
}