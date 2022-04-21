using TECAir_API.Models.WebOutput;

namespace TECAir_API.Database.Interface
{
    public interface IVuelo
    {
      Task<bool> ingresarVuelo(Vuelo vuelo);
      Task<VueloCerradoOutput> GetInfoVueloCerrado(int no_vuelo);
      Task<VueloAbiertoOutput> GetInfoVueloAbierto(int no_transaccion);
    }
}
