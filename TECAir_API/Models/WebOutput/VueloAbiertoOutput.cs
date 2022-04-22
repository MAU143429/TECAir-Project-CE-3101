namespace TECAir_API.Models.WebOutput
{
    public class VueloAbiertoOutput
    {
        public int no_vuelo { get; set; }
        public string p_nombre { get; set; }
        public string p_apellido1{ get; set; }
        public string p_apellido2 { get; set; }
        public string origen { get; set; }
        public string destino { get; set; }
        public string abordaje { get; set; }
        public int no_transaccion { get; set; }

        public VueloAbiertoOutput(int no_vuelo, string nombre, string apellido1, string apellido2, string origen, string destino, string abordara)
        {
            this.no_vuelo = no_vuelo;
            this.p_nombre = nombre;
            this.p_apellido1 = apellido1;
            this.p_apellido2 = apellido2;
            this.origen = origen;
            this.destino = destino;
            this.abordaje = abordara;
        }

        public VueloAbiertoOutput()
        {
        }

    }
}
