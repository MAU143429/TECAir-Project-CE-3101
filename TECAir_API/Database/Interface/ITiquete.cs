using TECAir_API.Models.WebOutput;

namespace TECAir_API.Database.Interface
{
    public interface ITiquete
    {
        Task<TiqueteOutput> GetReservacionId();
    }
}
