namespace TECAir_API.Models
{
    public class PasajeroWeb
    {
        public int no_transaccion { get; set; }
        public string nombre { get; set; }
        public int dni { get; set; }
        public int cant_maletas { get; set; }
        public int coste_maletas { get; set; }

        public PasajeroWeb()
        {
        }

        public PasajeroWeb(int no_transaccion, string p_nombre, string p_apellido1, string p_apellido2, int dni, int cant_maletas)
        {
            this.no_transaccion = no_transaccion;
            this.nombre = p_nombre + " " + p_apellido1 + " " + p_apellido2;
            this.dni = dni;
            this.cant_maletas = cant_maletas;
            this.coste_maletas = cant_maletas * 300;
        }
    }
}
