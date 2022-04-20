namespace TECAir_API.Database.Interface
{
    public interface IVuelo
    {
      Task<bool> ingresarVuelo(Vuelo vuelo);
    }
}
