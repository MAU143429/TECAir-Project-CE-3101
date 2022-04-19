namespace TECAir_API.Database
{
    public interface IPromocion
    {
        Task<bool> ingresarPromocion(PromocionWeb promocion);
        //Task<Promocion> GetPromocion(decimal noPromocion);

    }
}
