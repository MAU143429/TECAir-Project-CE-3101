namespace TECAir_API.Models
{
    public class EscalaWeb
    {
        public int no_vuelo { get; set; }
        public string escala { get; set; }
        public int orden { get; set; }

        public EscalaWeb()
        {
        }

        public EscalaWeb(int no_vuelo, int no_escala, string escala, int orden)
        {
            this.no_vuelo = no_vuelo;
            this.escala = escala;
            this.orden = orden;
        }
    }
}
