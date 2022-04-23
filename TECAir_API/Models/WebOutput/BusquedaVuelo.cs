namespace TECAir_API.Models.WebOutput
{
    public class BusquedaVuelo
    {
        public string origen { get; set; }
        public string destino { get; set; }
        public string h_salida { get; set; }
        public string h_llegada { get; set; }
        public string v_dia { get; set; }
        public string v_mes { get; set; }
        public string v_ano { get; set; }
        public string av_nombre { get; set; }
        public string prt_abordaje { get; set; }

        public BusquedaVuelo()
        {
        }

        public BusquedaVuelo(string origen, string destino, string h_salida, string h_llegada, string v_dia, string v_mes, string v_ano, string av_nombre, string prt_abordaje)
        {
            this.origen = origen;
            this.destino = destino;
            this.h_salida = h_salida;
            this.h_llegada = h_llegada;
            this.v_dia = v_dia;
            this.v_mes = v_mes;
            this.v_ano = v_ano;
            this.av_nombre = av_nombre;
            this.prt_abordaje = prt_abordaje;
        }
    }
}
