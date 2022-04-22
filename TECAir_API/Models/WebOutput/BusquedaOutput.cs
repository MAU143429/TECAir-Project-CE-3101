namespace TECAir_API.Models.WebOutput
{
    public class BusquedaOutput
    {
      
        public string no_vuelo { get; set; }
        public string origen { get; set; }
        public string destino { get; set; }
        public string v_dia { get; set; }
        public string v_mes { get; set; }
        public string v_ano { get; set; }
        public string h_salida { get; set; }
        public string h_llegada { get; set; }
        public string coste_vuelo { get; set; }

        public BusquedaOutput(string no_vuelo, string origen, string destino, string v_dia, string v_mes, string v_ano, string h_salida, string h_llegada, string coste_vuelo)
        {
            this.no_vuelo = no_vuelo;
            this.origen = origen;
            this.destino = destino;
            this.v_dia = v_dia;
            this.v_mes = v_mes;
            this.v_ano = v_ano;
            this.h_salida = h_salida;
            this.h_llegada = h_llegada;
            this.coste_vuelo = coste_vuelo;
        }

        public BusquedaOutput()
        {

        }


    }
}
