using TECAir_API.Models;
using TECAir_API.Models.WebOutput;

namespace TECAir_API.Database.Interface
{
    public interface IVuelo
    {
      Task<bool> ingresarVuelo(Vuelo vuelo);
      Task<VueloCerradoOutput> GetInfoVueloCerrado(int no_vuelo);
      Task<VueloAbiertoOutput> GetInfoVueloAbierto(int no_transaccion);

      Task<IEnumerable<BusquedaOutput>> GetVuelos(string origen, string destino, string v_dia, string v_mes, string v_ano);
      Task<bool> UpdateEstadoAbordaje(TiqueteWeb tiquete);
      Task<bool> UpdateEstadoAbordaje(TiqueteWeb tiquete);
    }
}
