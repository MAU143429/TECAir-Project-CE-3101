using Microsoft.AspNetCore.Mvc;
using TECAir_API.Database.Interface;
using TECAir_API.Models;
using TECAir_API.Models.Automation;
using TECAir_API.Models.WEB;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TECAir_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservacionController : ControllerBase
    {
        private readonly IReservacion _reservacionRepository;
        private readonly IAutomation _automationRepository;

        public ReservacionController(IReservacion reservacionRepository, IAutomation automationRepository)
        {
            _reservacionRepository = reservacionRepository;
            _automationRepository = automationRepository;
        }

        // GET api/Reservacion/Get
        /// <summary>
        /// Metodo get para obtener los datos de la reservacion, buscado por el id de usuario o id de trabajador
        /// </summary>
        /// <param name="id"> id de usuario o de trabajador para busqueda en la tabla</param>
        /// <returns>reservacion con todos los datos necesarios para mostrar en la Web</returns>
        [HttpGet("Get")]
        public async Task<IActionResult> GetReservacionById()
        {
            return Ok(await _reservacionRepository.GetReservacionId());
        }

        [HttpPost("Add")]
        public async Task<IActionResult> reservarVuelo(ReservacionWEB reserva)
        {
            ReservacionesTotales reservaciones = await _automationRepository.GetTotalReservaciones();
            Singleton s = Singleton.Instance();
            IdUsuario idUsuario = await _automationRepository.GetUsuario(s.usuario);
            Reservacion reservacion = new Reservacion(reservaciones.total_reservaciones+1, false, reserva.no_vuelo, idUsuario.id_usuario, null);
            if (reservacion == null)
                return BadRequest();
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var created = await _reservacionRepository.ingresarReservacion(reservacion);

            return Created("created", created);
        }

    }
}
