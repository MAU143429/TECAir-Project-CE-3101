namespace TECAir_API.Models
{
    public class Tiquete
    {
        public int no_transaccion { get; set; }
        public int no_reservacion { get; set; }
        public int no_asiento { get; set; }
        public int dni { get; set; }
        public string t_dia { get; set; }
        public string t_mes { get; set; }
        public string t_ano { get; set; }
        public bool abordaje { get; set; }

        public Tiquete()
        {
        }

        public Tiquete(int transaccion, int reservacion, int asiento, int dni, string dia, string mes, string ano, bool abordaje)
        {
            this.no_transaccion = transaccion;
            this.no_reservacion = reservacion;
            this.no_asiento = asiento;
            this.dni = dni;
            this.t_dia = dia;
            this.t_mes = mes;
            this.t_ano = ano;
            this.abordaje = abordaje;
        }
    }
}
