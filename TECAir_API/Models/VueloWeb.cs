namespace TECAir_API.Models
{
    public class VueloWeb
    {
        public string modelo_av { get; set; }
        public string origen { get; set; }
        public string destino { get; set; }
        public string prt_abordaje { get; set; }
        public string h_salida { get; set; }
        public string h_llegada { get; set; }
        public string v_fecha { get; set; }
        public int coste_vuelo { get; set; }
        public string escala1 { get; set; }
        public string escala2 { get; set; }
        public string escala3 { get; set; }


        public VueloWeb()
        {
        }

        public VueloWeb(string modelo, string origen, string destino, string prt_abordaje, string salida, string llegada, string fecha, int coste, string escala1, string escala2, string escala3)
        {
            this.modelo_av = modelo;
            this.origen = origen;
            this.destino = destino;
            this.prt_abordaje = prt_abordaje;
            this.h_salida = salida;
            this.h_llegada = llegada;
            this.v_fecha = fecha;
            this.coste_vuelo = coste;
            this.escala1 = escala1;
            this.escala2 = escala2;
            this.escala3 = escala3;
        }

        public string getDia()
        {
            List<string> f_list = new List<string>();
            f_list = this.v_fecha.Split("-").ToList();
            return f_list[2];
        }

        public string getMes()
        {
            List<string> f_list = new List<string>();
            f_list = this.v_fecha.Split("-").ToList();
            return f_list[1];
        }

        public string getAno()
        {
            List<string> f_list = new List<string>();
            f_list = this.v_fecha.Split("-").ToList();
            return f_list[0];
        }
    }
}
