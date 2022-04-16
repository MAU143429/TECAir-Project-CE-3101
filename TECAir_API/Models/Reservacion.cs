namespace TECAir_API.Models
{
    public class Reservacion
    {
        public int no_reservacion { get; set; }
        public int no_vuelo { get; set; }
        public int id_usuario { get; set; }
        public int id_trabajador { get; set; }
        public bool cancelado { get; set; }

        public Reservacion()
        {
        }

        public Reservacion(int reservacion, int vuelo, int usuario, int trabajador, bool calcelado)
        {
            this.no_reservacion = reservacion;
            this.no_vuelo = vuelo;
            this.id_usuario = usuario;
            this.id_trabajador = trabajador;
            this.cancelado = calcelado;
        }
    }
}
