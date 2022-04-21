using TECAir_API.Models.WEB;

namespace TECAir_API.Database.Interface
{
    public interface IAvion
    {
        Task<IEnumerable<ListaAvion>> GetAviones();
    }
}
