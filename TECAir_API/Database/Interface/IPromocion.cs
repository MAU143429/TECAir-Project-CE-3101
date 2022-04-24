namespace TECAir_API.Database
{
    public interface IPromocion
    {
        Task<bool> ingresarPromocion(PromocionOutput promocion);
        Task<IEnumerable<PromocionOutput>> GetPromociones();

    }
}
