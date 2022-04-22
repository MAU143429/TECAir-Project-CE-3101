namespace TECAir_API.Models.Automation
{
    public class PromocionesTotales
    {
        public int total_promociones { get; set; }

        public PromocionesTotales()
        {
        }

        public PromocionesTotales(int total_promociones)
        {
            this.total_promociones = total_promociones;
        }
    }
}
