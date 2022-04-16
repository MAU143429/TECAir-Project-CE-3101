namespace TECAir_API.Models
{
    public class Estudiante
    {
        public int id_usuario { get; set; }
        public int carnet { get; set; }
        public string universidad { get; set; }

        public Estudiante()
        {
        }

        public Estudiante(int id_usuario, int carnet, string universidad)
        {
            this.id_usuario = id_usuario;
            this.carnet = carnet;
            this.universidad = universidad;
        }
    }
}
