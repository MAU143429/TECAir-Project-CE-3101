namespace TECAir_API.Models.WebOutput
{
    public class PromotionOutput
    {
        public decimal NoPromocion { get; set; }
        public decimal Porcentaje { get; set; }
        public decimal Periodo { get; set; }
        public string Url { get; set; }
        public string PDia { get; set; }
        public string PMes { get; set; }
        public string PAno { get; set; }
        public decimal NoVuelo { get; set; }

        public PromotionOutput()
        {
        }

        public PromotionOutput(decimal noPromocion, decimal porcentaje, decimal periodo, string url, string pDia, string pMes, string pAno, decimal noVuelo)
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
