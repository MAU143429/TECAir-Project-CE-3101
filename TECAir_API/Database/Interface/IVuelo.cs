using TECAir_API.Models;
using TECAir_API.Models.WEB;
using TECAir_API.Models.WebOutput;

namespace TECAir_API.Database.Interface
{
    public interface IVuelo
    {
        Task<bool> ingresarVuelo(Vuelo vuelo);
        Task<IEnumerable<VueloCerradoOutput>> GetInfoVueloCerrado(int no_vuelo);
        Task<VueloAbiertoOutput> GetInfoVueloAbierto(int no_transaccion);
        Task<IEnumerable<BusquedaOutput>> GetVuelos(string origen, string destino, string v_dia, string v_mes, string v_ano);
        Task<bool> UpdateEstadoAbordaje(TiqueteWeb tiquete);
        Task<IEnumerable<VueloCompleto>> GetVueloR(int no_vuelo, int no_reservacion, int escalas);
        Task<IEnumerable<PasajeroWeb>> GetPasajeros(int no_vuelo);
        Task<IEnumerable<MaletaOutput>> GetMaletas(int no_vuelo);
        Task<IEnumerable<ReportePasajero>> GetReportePasajeros(int no_vuelo);
    }
}
