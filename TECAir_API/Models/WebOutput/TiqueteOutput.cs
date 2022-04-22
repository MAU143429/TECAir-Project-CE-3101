namespace TECAir_API.Models.WebOutput
{
    public class TiqueteOutput
    {
        public int no_vuelo { get; set; }
        public int no_transaccion { get; set; }
        public string t_dia { get; set; }
        public string t_mes { get; set; }
        public string t_ano { get; set; }
        public string h_salida { get; set; }

        public TiqueteOutput()
        {
        }

        public TiqueteOutput(int no_vuelo, int no_transaccion, string t_dia, string t_mes, string t_ano, string h_salida)
        {
            this.no_vuelo = no_vuelo;
            this.no_transaccion = no_transaccion;
            this.t_dia = t_dia;
            this.t_mes = t_mes;
            this.t_ano = t_ano;
            this.h_salida = h_salida;
        }
    }
}
