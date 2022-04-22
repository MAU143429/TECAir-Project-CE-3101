namespace TECAir_API.Models.Automation
{
    public class ReservacionesTotales
    {
        public int total_reservaciones { get; set; }

        public ReservacionesTotales()
        {
        }

        public ReservacionesTotales(int total_reservaciones)
        {
            this.total_reservaciones = total_reservaciones;
        }
    }
}
