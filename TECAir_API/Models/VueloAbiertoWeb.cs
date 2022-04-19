namespace TECAir_API.Models
{
    public class VueloAbiertoWeb
    {
        public int no_transaccion { get; set; }
        /// <summary>
        /// Constructor de la clase modelo para controlar la apertura de vuelo
        /// </summary>
        /// <param name="no_transaccion"> numero de transaccion asociado al tiquete</param>
        public VueloAbiertoWeb(int no_transaccion)
        {
            this.no_transaccion = no_transaccion;
        }

        public VueloAbiertoWeb()
        {
        }
        
    }
}
