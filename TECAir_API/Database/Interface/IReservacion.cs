using TECAir_API.Models.WebOutput;

namespace TECAir_API.Database.Interface
{
    public interface IReservacion
    {
        Task<IEnumerable<ReservacionOutput>> GetReservacionId();

        Task<bool> ingresarReservacion(Reservacion reservacion);
    }
}
