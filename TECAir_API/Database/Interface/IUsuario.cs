namespace TECAir_API.Database.Interface
{
    public interface IUsuario
    {
        Task<bool> ingresarUsuario(Usuario usuario);

        Task<bool> ingresarEstudiante(Estudiante estudiante);
    }
}
