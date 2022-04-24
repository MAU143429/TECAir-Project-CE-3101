namespace TECAir_API.Models.WEB
{
    public class GenerarTiquete
    {
        public int no_reservacion { get; set; }
        public int dni { get; set; }
        public string p_nombre { get; set; }
        public string p_apellido1 { get; set; }
        public string p_apellido2 { get; set; }
        public string v_dia { get; set; }
        public string v_mes { get; set; }
        public string v_ano { get; set; }

        public GenerarTiquete()
        {
        }

        public GenerarTiquete(int no_reservacion, int dni, string p_nombre, string p_apellido1, string p_apellido2, string v_dia, string v_mes, string v_ano)
        {
            this.no_reservacion = no_reservacion;
            this.dni = dni;
            this.p_nombre = p_nombre;
            this.p_apellido1 = p_apellido1;
            this.p_apellido2 = p_apellido2;
            this.v_dia = v_dia;
            this.v_mes = v_mes;
            this.v_ano = v_ano;
        }
    }
}
