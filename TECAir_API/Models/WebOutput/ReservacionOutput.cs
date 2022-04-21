namespace TECAir_API.Models.WebOutput
{
    public class ReservacionOutput 
    {
        public int no_vuelo { get; set; }
        public int no_reservacion { get; set; }
        public string origen { get; set; }
        public string destino { get; set; }
        public string v_dia { get; set; }
        public string v_mes { get; set; }
        public string v_ano { get; set; }
        public string h_salida { get; set; }

        public ReservacionOutput(int no_vuelo, int no_reservacion, string origen, string destino, string v_dia, string v_mes, string v_ano, string h_salida)
        {
            this.no_vuelo = no_vuelo;
            this.no_reservacion = no_reservacion;
            this.origen = origen;
            this.destino = destino;
            this.v_dia = v_dia;
            this.v_mes = v_mes;
            this.v_ano = v_ano;
            this.h_salida = h_salida;
        }

        public ReservacionOutput()
        {
        }
    }
}
