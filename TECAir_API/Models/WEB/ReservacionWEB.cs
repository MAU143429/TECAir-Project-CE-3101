namespace TECAir_API.Models.WEB
{
    public class ReservacionWEB
    {
        public int no_vuelo { get; set; }

        public ReservacionWEB()
        {
        }

        public ReservacionWEB(int vuelo)
        {
            this.no_vuelo = vuelo;
        }
    }
}
