namespace TECAir_API.Models
{
    public class AsientoWeb
    {
        public int no_asiento { get; set; }
        public int no_vuelo { get; set; }
        public string ubicacion { get; set; }

        public AsientoWeb(int no_asiento, int no_vuelo, string ubicacion)
        {
            this.no_asiento = no_asiento;
            this.no_vuelo = no_vuelo;
            this.ubicacion = ubicacion;
        }

        public AsientoWeb()
        {
        }

       
    }
}
