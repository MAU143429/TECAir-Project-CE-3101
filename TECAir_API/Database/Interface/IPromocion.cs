using TECAir_API.Models.WEB;
using TECAir_API.Models.WebOutput;

namespace TECAir_API.Database
{
    public interface IPromocion
    {
        Task<bool> ingresarPromocion(Promocion promocion);
        Task<IEnumerable<PromosRandom>> GetPromociones();

    }
}
