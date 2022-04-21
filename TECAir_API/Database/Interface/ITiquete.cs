using TECAir_API.Models.WebOutput;

namespace TECAir_API.Database.Interface
{
    public interface ITiquete
    {
        Task<TiqueteOutput> GetReservacionId(decimal idUsuario);
        Task<TiqueteOutput> GetReservacionId(string idTrabajador);
    }
}
