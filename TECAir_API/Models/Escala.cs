namespace TECAir_API.Models
{
    public class Escala
    {
        public int no_vuelo { get; set; }
        public string escala { get; set; }

        public Escala()
        {
        }

        public Escala(int vuelo, string escala)
        {
            this.no_vuelo = vuelo;
            this.escala = escala;
        }
    }
}
