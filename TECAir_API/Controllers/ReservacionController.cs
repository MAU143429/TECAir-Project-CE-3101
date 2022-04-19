using Microsoft.AspNetCore.Mvc;
using TECAir_API.Models;
using TECAir_API.Models.WEB;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TECAir_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservacionController : ControllerBase
    {
        public List<Reservacion> reservaciones = new List<Reservacion>();

        // POST api/<ReservaciónController>
        [HttpPost("Add")]
        public List<Reservacion> Post([FromBody] ReservacionWEB value)
        {
            if (Singleton.Instance().usua_trab)
            {
                reservaciones.Add(new Reservacion(1, value.no_vuelo, Singleton.Instance().usuario, "", false));
            }
            else
            {
                reservaciones.Add(new Reservacion(1, value.no_vuelo, "", Singleton.Instance().usuario, false));
            }
            return reservaciones;
        }
    }
}
