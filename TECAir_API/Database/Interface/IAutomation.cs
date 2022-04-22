using TECAir_API.Models.Automation;
using TECAir_API.Models.WEB;

namespace TECAir_API.Database.Interface
{
    public interface IAutomation
    {
        Task<VuelosTotales> GetTotalVuelos();
        Task<ReservacionesTotales> GetTotalReservaciones();
        Task<PromocionesTotales> GetTotalPromociones();
        Task<MaletasTotales> GetTotalMaletas();
        Task<TiquetesTotales> GetTotalTiquetes();
        Task<CantEscalas> GetEscalas(int no_vuelo);
        Task<IEnumerable<Login>> LoginUser(string correo, string contrasena);
    }
}
