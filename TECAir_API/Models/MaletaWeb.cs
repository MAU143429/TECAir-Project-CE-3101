namespace TECAir_API.Models
{
    public class MaletaWeb
    {
        public int no_maleta { get; set; }
        public int dni { get; set; }
        public int peso { get; set; }
        public string color { get; set; }

        public MaletaWeb()
        {
        }

        public MaletaWeb(int maleta, int dni, int peso, string color)
        {
            this.no_maleta = maleta;
            this.dni = dni;
            this.color = color;
            this.peso = peso;
        }
    }
}
