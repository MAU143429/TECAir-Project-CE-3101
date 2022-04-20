namespace TECAir_API.Database
{
    public interface IPromocion
    {
        Task<bool> ingresarPromocion(Promocion promocion);
        //Task<Promocion> GetPromocion(decimal noPromocion);

    }
}
