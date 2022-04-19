namespace TECAir_API.Models
{
    public class AvionWeb
    {
        public int matricula { get; set; }
        public string av_nombre { get; set; }
        public int capacidad { get; set; }

        public AvionWeb()
        {
        }

        public AvionWeb(int matricula, string nombre, int capacidad)
        {
            this.matricula = matricula;
            this.av_nombre = nombre;
            this.capacidad = capacidad;
        }
    }
}
