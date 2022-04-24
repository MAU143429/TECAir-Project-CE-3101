namespace TECAir_API.Models.WebOutput
{
    public class PromotionOutput
    {
        public int no_promocion { get; set; }
        public int porcentaje { get; set; }
        public int periodo { get; set; }
        public string url { get; set; }
        public string p_dia { get; set; }
        public string p_mes { get; set; }
        public string p_ano { get; set; }
        public int no_vuelo { get; set; }

        public PromotionOutput()
        {
        }

        public PromotionOutput(int noPromocion, int porcentaje, int periodo, string url, string pDia, string pMes, string pAno, int noVuelo)
        {
            this.no_promocion = noPromocion;
            this.porcentaje = porcentaje;
            this.periodo = periodo;
            this.url = url;
            this.p_dia = pDia;
            this.p_mes = pMes;
            this.p_ano = pAno;
            this.no_vuelo = noVuelo;
        }
    }
}
