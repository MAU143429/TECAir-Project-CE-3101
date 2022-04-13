namespace TECAir_API.Models
{
    public class Pasajero
    {
        public int no_transaccion { get; set; }
        public int dni { get; set; }
        public string p_nombre { get; set; }
        public string p_apellido1 { get; set; }
        public string p_apellido2 { get; set; }
        public int cant_maletas { get; set; }
        public bool chequeado { get; set; }

        public Pasajero()
        {
        }

        public Pasajero(int transaccion, int dni, string nombre, string apellido1, string apellido2, int maletas, bool chequeado)
        {
            this.no_transaccion = transaccion;
            this.dni = dni;
            this.p_nombre = nombre;
            this.p_apellido1 = apellido1;
            this.p_apellido2 = apellido2;
            this.cant_maletas = maletas;
            this.chequeado = chequeado;
        }
    }
}
