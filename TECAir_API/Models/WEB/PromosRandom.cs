namespace TECAir_API.Models.WEB
{
    public class PromosRandom
    {
        public int no_vuelo { get; set; }
        public int no_promocion { get; set; }
        public string url { get; set; }
        public string ciudad_origen { get; set; }
        public string ciudad_destino { get; set; }
        public string p_dia { get; set; }
        public string p_mes { get; set; }
        public string p_ano { get; set; }
        public int porcentaje { get; set; }
        public int precio { get; set; }

        public PromosRandom()
        {
        }

        public PromosRandom(int no_vuelo, int no_promocion, string url, string ciudad_origen, string ciudad_destino, string p_dia, string p_mes, string p_ano, int porcentaje, int precio)
        {
            this.no_vuelo = no_vuelo;
            this.no_promocion = no_promocion;
            this.url = url;
            this.ciudad_origen = ciudad_origen;
            this.ciudad_destino = ciudad_destino;
            this.p_dia = p_dia;
            this.p_mes = p_mes;
            this.p_ano = p_ano;
            this.porcentaje = porcentaje;
            this.precio = precio;
        }
    }
}