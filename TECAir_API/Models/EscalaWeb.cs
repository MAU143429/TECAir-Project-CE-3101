namespace TECAir_API.Models
{
    public class EscalaWeb
    {
        public string escala { get; set; }
        public int orden { get; set; }

        public EscalaWeb()
        {
        }

        public EscalaWeb(string escala, int orden)
        {
            this.escala = escala;
            this.orden = orden;
        }
    }
}
