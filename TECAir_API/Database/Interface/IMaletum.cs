namespace TECAir_API.Database.Interface
{
    public interface IMaletum
    {
        Task<bool> ingresarMaleta(Maletum maleta);
        //Task<Promocion> GetPromocion(decimal noPromocion);
    }
}
