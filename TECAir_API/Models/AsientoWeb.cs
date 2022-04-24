namespace TECAir_API.Models
{
    public class AsientoWeb
    {
        public int no_vuelo { get; set; }
        public int no_transaccion { get; set; }
        public string ubicacion { get; set; }

        public AsientoWeb(int no_vuelo, int no_transaccion, string ubicacion)
        {
            this.no_vuelo = no_vuelo;
            this.no_transaccion = no_transaccion;
            this.ubicacion = ubicacion;
        }

        public AsientoWeb()
        {
        }

       
    }
}
