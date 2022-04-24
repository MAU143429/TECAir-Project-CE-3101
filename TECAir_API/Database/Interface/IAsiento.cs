namespace TECAir_API.Database.Interface
{
    public interface IAsiento
    {
        Task<bool> ingresarAsiento(Asiento asiento);
    }
}
