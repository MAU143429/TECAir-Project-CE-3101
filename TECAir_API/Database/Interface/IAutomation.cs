using TECAir_API.Models.Automation;

namespace TECAir_API.Database.Interface
{
    public interface IAutomation
    {
        Task<VuelosTotales> GetTotalVuelos();
        Task<ReservacionesTotales> GetTotalReservaciones();
        Task<PromocionesTotales> GetTotalPromociones();
        Task<MaletasTotales> GetTotalMaletas();
        Task<TiquetesTotales> GetTotalTiquetes();
        Task<TiquetesTotales> GetEscalas(int no_vuelo);
    }
}
