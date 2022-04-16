namespace TECAir_API.Models
{
    public class Pasajero
    {
        public int dni { get; set; }
        public string p_nombre { get; set; }
        public string p_apellido1 { get; set; }
        public string p_apellido2 { get; set; }
        public int no_reservacion { get; set; }

        public Pasajero()
        {
        }

        public Pasajero(int dni, string nombre, string apellido1, string apellido2, int reservacion)
        {
            this.dni = dni;
            this.p_nombre = nombre;
            this.p_apellido1 = apellido1;
            this.p_apellido2 = apellido2;
            this.no_reservacion = reservacion;
        }
    }
}
