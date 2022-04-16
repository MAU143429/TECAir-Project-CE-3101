namespace TECAir_API.Models
{
    public class Promocion
    {
        public int no_promocion { get; set; }
        public int no_vuelo { get; set; }
        public int porcentaje { get; set; }
        public int periodo { get; set; }
        public string url { get; set; }
        public string fecha { get; set; }
        //public string p_dia { get; set; }
        //public string p_mes { get; set; }
        //public string p_ano { get; set; }

        public Promocion()
        {
        }

        public Promocion(int promocion, int vuelo, int porcentaje, int periodo, string url, string fecha)//string dia, string mes, string ano)
        {
            this.no_promocion = promocion;
            this.no_vuelo = vuelo;
            this.porcentaje = porcentaje;
            this.periodo = periodo;
            this.url = url;
            this.fecha = fecha;
            /*this.p_dia = dia;
            this.p_mes = mes;
            this.p_ano = ano;*/
        }
    }
}
