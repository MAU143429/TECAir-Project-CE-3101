namespace TECAir_API.Models
{
    public class Escala
    {
        public int no_vuelo { get; set; }
        public int no_escala { get; set; }
        public string escala { get; set; }
        public int orden { get; set; }

        public Escala()
        {
        }

        public Escala(int no_vuelo, int no_escala, string escala, int orden)
        {
            this.no_vuelo = no_vuelo;
            this.no_escala = no_escala;
            this.escala = escala;
            this.orden = orden;
        }
    }
}
