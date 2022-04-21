namespace TECAir_API.Models.WebOutput
{
    public class TiqueteOutput
    {
        public int no_vuelo { get; set; }
        public int no_transaccion { get; set; }
        public string v_dia { get; set; }
        public string v_mes { get; set; }
        public string v_ano { get; set; }
        public string h_salida { get; set; }

        public TiqueteOutput()
        {
        }

        public TiqueteOutput(int no_vuelo, int no_transaccion, string v_dia, string v_mes, string v_ano, string h_salida)
        {
            this.no_vuelo = no_vuelo;
            this.no_transaccion = no_transaccion;
            this.v_dia = v_dia;
            this.v_mes = v_mes;
            this.v_ano = v_ano;
            this.h_salida = h_salida;
        }
    }
}
