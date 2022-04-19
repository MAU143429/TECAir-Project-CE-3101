namespace TECAir_API.Models
{
    public class VueloWeb
    {
        public int no_vuelo { get; set; }
        public int matricula { get; set; }
        public string origen { get; set; }
        public string destino { get; set; }
        public int prt_abordaje { get; set; }
        public string h_salida { get; set; }
        public string h_llegada { get; set; }
        public string v_dia { get; set; }
        public string v_mes { get; set; }
        public string v_ano { get; set; }
        public int coste_vuelo { get; set; }

        public VueloWeb()
        {
        }

        public VueloWeb(int vuelo, int matricula, string origen, string destino, int prt_abordaje, string salida, string llegada, string dia, string mes, string ano, int coste)
        {
            this.no_vuelo = vuelo;
            this.matricula = matricula;
            this.origen = origen;
            this.destino = destino;
            this.prt_abordaje = prt_abordaje;
            this.h_salida = salida;
            this.h_llegada = llegada;
            this.v_dia = dia;
            this.v_mes = mes;
            this.v_ano = ano;
            this.coste_vuelo = coste;
        }
    }
}
