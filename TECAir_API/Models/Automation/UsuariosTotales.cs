namespace TECAir_API.Models.Automation
{
    public class UsuariosTotales
    {
        public int total_usuarios { get; set; }

        public UsuariosTotales()
        {
        }

        public UsuariosTotales(int total_usuario)
        {
            this.total_usuarios = total_usuario;
        }
    }
}
