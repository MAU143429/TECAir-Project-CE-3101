namespace TECAir_API.Models.WEB
{
    public class Transaccion
    {
        public int no_transaccion { get; set; }
        public int no_vuelo { get; set; }
        public string p_nombre { get; set; }
        public string p_apellido1 { get; set; }
        public string p_apellido2 { get; set; }
        public string h_salida { get; set; }

        public Transaccion()
        {
        }

        public Transaccion(int no_transaccion, int no_vuelo, string p_nombre, string p_apellido1, string p_apellido2, string h_salida)
        {
            this.no_transaccion = no_transaccion;
            this.no_vuelo = no_vuelo;
            this.p_nombre = p_nombre;
            this.p_apellido1 = p_apellido1;
            this.p_apellido2 = p_apellido2;
            this.h_salida = h_salida;
        }
    }
}
