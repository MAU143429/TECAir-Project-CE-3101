namespace TECAir_API.Models
{
    public class VueloCerrado
    {
        public int no_vuelo { get; set; }
        /// <summary>
        /// Constructor de la clase modelo para controlar el cierre de vuelo
        /// </summary>
        /// <param name="no_vuelo"> numero de vuelo asociado</param>
        public VueloCerrado(int no_vuelo)
        {
            this.no_vuelo = no_vuelo;
        }

        public VueloCerrado()
        {
        }
    }
}
