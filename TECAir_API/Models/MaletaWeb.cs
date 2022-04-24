namespace TECAir_API.Models
{
    public class MaletaWeb
    {
        public int no_vuelo { get; set; }
        public int dni { get; set; }
        public int peso { get; set; }
        public string color { get; set; }

        public MaletaWeb()
        {
        }

        public MaletaWeb(int vuelo, int dni, int peso, string color)
        {
            this.no_vuelo = vuelo;
            this.dni = dni;
            this.color = color;
            this.peso = peso;
        }
    }
}
