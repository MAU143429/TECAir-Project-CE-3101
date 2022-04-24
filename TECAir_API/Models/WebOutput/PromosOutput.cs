namespace TECAir_API.Models.WebOutput
{
    public class PromosOutput
    {
        public int NoPromocion { get; set; }
        public int Porcentaje { get; set; }
        public int Periodo { get; set; }
        public string Url { get; set; }
        public string PDia { get; set; }
        public string PMes { get; set; }
        public string PAno { get; set; }
        public int NoVuelo { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public int CosteVuelo { get; set; }

        public PromosOutput()
        {
        }

        public PromosOutput(int noPromocion, int porcentaje, int periodo, string url, string pDia, string pMes, string pAno, int noVuelo, string origen, string destino, int costeVuelo)
        {
            NoPromocion = noPromocion;
            Porcentaje = porcentaje;
            Periodo = periodo;
            Url = url;
            PDia = pDia;
            PMes = pMes;
            PAno = pAno;
            NoVuelo = noVuelo;
            Origen = origen;
            Destino = destino;
            CosteVuelo = costeVuelo;
        }
    }
}