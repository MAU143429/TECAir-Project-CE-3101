using TECAir_API.Models.WebOutput;

namespace TECAir_API.Database.Interface
{
    public interface IReservacion
    {
        Task<ReservacionOutput> GetReservacionId(decimal idUsuario);
    }
}
