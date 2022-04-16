namespace TECAir_API.Models
{
    public class Maleta
    {
        public int no_maleta { get; set; }
        public int no_vuelo { get; set; }
        public int dni { get; set; }
        public string color { get; set; }
        public string peso { get; set; }

        public Maleta()
        {
        }

        public Maleta(int maleta, int vuelo, int dni, string color, string peso)
        {
            this.no_maleta = maleta;
            this.no_vuelo = vuelo;
            this.dni = dni;
            this.color = color;
            this.peso = peso;
        }
    }
}
