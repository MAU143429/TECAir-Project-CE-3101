namespace TECAir_API.Models.WebOutput
{
    public class ReportePasajero
    {
        public int no_transaccion { get; set; }
        public string p_nombre { get; set; }
        public string p_apellido1 { get; set; }
        public string p_apellido2 { get; set; }
        public int dni { get; set; }
        public int cant_maletas { get; set; }
        public int coste_maletas { get; set; }

        public ReportePasajero()
        {
        }

        public ReportePasajero(int no_transaccion, string p_nombre, string p_apellido1, string p_apellido2, int dni, int cant_maletas, int coste_maletas)
        {
            this.no_transaccion = no_transaccion;
            this.p_nombre = p_nombre;
            this.p_apellido1 = p_apellido1;
            this.p_apellido2 = p_apellido2;
            this.dni = dni;
            this.cant_maletas = cant_maletas;
            this.coste_maletas = coste_maletas;
        }
    }
}
