namespace TECAir_API.Models.WebOutput
{
    public class PromotionOutput
    {
        public int NoPromocion { get; set; }
        public int Porcentaje { get; set; }
        public int Periodo { get; set; }
        public string Url { get; set; }
        public string PDia { get; set; }
        public string PMes { get; set; }
        public string PAno { get; set; }
        public int NoVuelo { get; set; }

        public PromotionOutput()
        {
        }

        public PromotionOutput(int noPromocion, int porcentaje, int periodo, string url, string pDia, string pMes, string pAno, int noVuelo)
        {
            NoPromocion = noPromocion;
            Porcentaje = porcentaje;
            Periodo = periodo;
            Url = url;
            PDia = pDia;
            PMes = pMes;
            PAno = pAno;
            NoVuelo = noVuelo;
        }
    }
}
