namespace TECAir_API.Models.WEB
{
    public class VueloReserva
    {
        public int no_vuelo { get; set; }
        public int no_reservacion { get; set; }

        public VueloReserva()
        {
        }

        public VueloReserva(int no_vuelo, int no_reservacion)
        {
            this.no_vuelo = no_vuelo;
            this.no_reservacion = no_reservacion;
        }
    }
}
