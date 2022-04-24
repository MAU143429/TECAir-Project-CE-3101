using TECAir_API.Models.WEB;

namespace TECAir_API.Database.Interface
{
    public interface IPasajero
    {
        Task<bool> GenerarTiquete(GenerarTiquete gTiquete, int no_transaccion);
        Task<bool> Chequear(int no_transaccion);
    }
}
