namespace TECAir_API.Models
{
    public class VueloBusquedaWeb
    {
        public string no_vuelo { get; set; }
        public string origen { get; set; }
        public string destino { get; set; }
        public string fecha { get; set; }
        public string h_salida { get; set; }
        public string h_llegada { get; set; }
        public string precio { get; set; }

        public VueloBusquedaWeb()
        {
        }

        public VueloBusquedaWeb(string vuelo, string origen, string destino, string salida, string llegada, string fecha, string precio)
        {
            this.no_vuelo = vuelo;
            this.origen = origen;
            this.destino = destino;
            this.h_salida = salida;
            this.h_llegada = llegada;
            this.precio = precio;
            this.fecha = fecha;
        }

        public VueloBusquedaWeb(string origen, string destino, string fecha)
        {
            this.origen = origen;
            this.destino = destino;
            this.fecha = fecha;
        }

        public string getDia()
        {
            List<string> f_list = new List<string>();
            f_list = this.fecha.Split("-").ToList();
            return f_list[2];
        }

        public string getMes()
        {
            List<string> f_list = new List<string>();
            f_list = this.fecha.Split("-").ToList();
            return f_list[1];
        }

        public string getAno()
        {
            List<string> f_list = new List<string>();
            f_list = this.fecha.Split("-").ToList();
            return f_list[0];
        }
    }
}
