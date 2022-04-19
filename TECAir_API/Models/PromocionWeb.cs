namespace TECAir_API.Models
{
    public class PromocionWeb
    {
        public int no_promocion { get; set; }
        public int no_vuelo { get; set; }
        public int porcentaje { get; set; }
        public int periodo { get; set; }
        public string url { get; set; }
        public string fecha { get; set; }

        public PromocionWeb()
        {
        }

        public PromocionWeb(int vuelo, int porcentaje, int periodo, string url, string fecha)
        {
            this.no_vuelo = vuelo;
            this.porcentaje = porcentaje;
            this.periodo = periodo;
            this.url = url;
            this.fecha = fecha;
        }
    }
}
