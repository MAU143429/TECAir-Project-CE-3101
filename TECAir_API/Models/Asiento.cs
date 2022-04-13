namespace TECAir_API.Models
{
    public class Asiento
    {
        public int no_asiento { get; set; }
        public int no_vuelo { get; set; }
        public string ubicacion { get; set; }

        public Asiento()
        {
        }

        public Asiento(int asiento, int vuelo, string ubicacion)
        {
            this.no_asiento = asiento;
            this.no_vuelo = vuelo;
            this.ubicacion = ubicacion;
        }
    }
}
