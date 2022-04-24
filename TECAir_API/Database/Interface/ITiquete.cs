using TECAir_API.Models.WEB;
using TECAir_API.Models.WebOutput;

namespace TECAir_API.Database.Interface
{
    public interface ITiquete
    {
        Task<IEnumerable<TiqueteOutput>> GetTiqueteId();
        Task<IEnumerable<Transaccion>> GetTiqueteNoT(int no_transaccion);
        Task<bool> Chequear(int no_transaccion);
        Task<bool> ingresarTiquete(GenerarTiquete gTiquete, int no_transaccion);
        Task<TiqueteVuelo> GenerarTiquete(int no_transaccion);
    }
}
