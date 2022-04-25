using TECAir_API.Models.Automation;
using TECAir_API.Models.WEB;

namespace TECAir_API.Database.Interface
{
    public interface IAutomation
    {
        Task<VuelosTotales> GetTotalVuelos();
        Task<AsientosTotales> GetTotalAsientos();
        Task<ReservacionesTotales> GetTotalReservaciones();
        Task<PromocionesTotales> GetTotalPromociones();
        Task<MaletasTotales> GetTotalMaletas();
        Task<MaletasTotales> GetMaletas(int dni);
        Task<UsuariosTotales> GetTotalUsuarios();
        Task<TiquetesTotales> GetTotalTiquetes();
        Task<CantEscalas> GetEscalas();
        Task<CantEscalas> GetEscalasVuelo(int no_vuelo);
        Task<IEnumerable<Login>> LoginUser(string correo, string contrasena);
        Task<IEnumerable<Login>> LoginTrabajador(string id_trabajador, string contrasena);
        Task<IdUsuario> GetUsuario(string correo);
    }
}
