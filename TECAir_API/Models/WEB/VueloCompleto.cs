namespace TECAir_API.Models.WEB
{
    public class VueloCompleto
    {
        public int no_vuelo { get; set; }
        public int no_reservacion { get; set; }
        public string origen { get; set; }
        public string ciudad_origen { get; set; }
        public string destino { get; set; }
        public string ciudad_destino { get; set; }
        public string av_nombre { get; set; }
        public string prt_abordaje { get; set; }
        public string v_dia { get; set; }
        public string v_mes { get; set; }
        public string v_ano { get; set; }
        public string h_salida { get; set; }
        public string h_llegada { get; set; }
        public int cant_escalas { get; set; }

        public VueloCompleto()
        {
        }

        public VueloCompleto(int no_vuelo, int no_reservacion, string origen, string ciudad_origen, string destino, string ciudad_destino, string modelo_av, string prt_abordaje, string v_dia, string v_mes, string v_ano, string h_salida, string h_llegada, int cant_escalas)
        {
            this.no_vuelo = no_vuelo;
            this.no_reservacion = no_reservacion;
            this.origen = origen;
            this.ciudad_origen = ciudad_origen;
            this.destino = destino;
            this.ciudad_destino = ciudad_destino;
            this.av_nombre = modelo_av;
            this.prt_abordaje = prt_abordaje;
            this.v_dia = v_dia;
            this.v_mes = v_mes;
            this.v_ano = v_ano;
            this.h_salida = h_salida;
            this.h_llegada = h_llegada;
            this.cant_escalas = cant_escalas;
        }
    }
}
