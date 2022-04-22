namespace TECAir_API.Models.Automation
{
    public class VuelosTotales
    {
        public int total_vuelos { get; set; }

        public VuelosTotales()
        {
        }

        public VuelosTotales(int total_vuelos)
        {
            this.total_vuelos = total_vuelos;
        }
    }
}
