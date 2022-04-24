using Microsoft.AspNetCore.Mvc;
using TECAir_API.Database.Interface;
using TECAir_API.Models;
using TECAir_API.Models.Automation;
using TECAir_API.Models.WEB;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TECAir_API.Models
{
    [Route("api/[controller]")]
    [ApiController]
    public class TiqueteController : ControllerBase
    {
        private readonly ITiquete _tiqueteRepository;
        private readonly IAutomation _automationRepository;
        public List<TiqueteWeb> tiquetes = new List<TiqueteWeb>();

        public TiqueteController(ITiquete tiqueteRepository, IAutomation automationRepository)
        {
            _tiqueteRepository = tiqueteRepository;
            _automationRepository = automationRepository;
        }

        // GET api/Tiquete/Get
        /// <summary>
        /// Metodo get para obtener los datos del tiquete, buscado por el id de usuario o id de trabajador
        /// </summary>
        /// <param name="id"> id de usuario o de trabajador para busqueda en la tabla</param>
        /// <returns>reservacion con todos los datos necesarios para mostrar en la Web</returns>
        [HttpGet("Get")]
        public async Task<IActionResult> GetTiqueteById()
        {
            return Ok(await _tiqueteRepository.GetTiqueteId());
        }

        [HttpGet("GetT/{no_transaccion}")]
        public async Task<IActionResult> GetTiqueteByNoT(int no_transaccion)
        {
            return Ok(await _tiqueteRepository.GetTiqueteNoT(no_transaccion));
        }

        [HttpPut("CheckIn")]
        public async Task<IActionResult> UpdateAbordaje([FromBody] VueloAbiertoWeb transaccion)
        {
            await _tiqueteRepository.Chequear(transaccion.no_transaccion);
            return NoContent();
        }

        [HttpPost("Add")]
        public async Task<IActionResult> ingresarPasajero([FromBody] GenerarTiquete gTiquete)
        {
            TiquetesTotales tiquetes = await _automationRepository.GetTotalTiquetes();
            var created = await _tiqueteRepository.ingresarTiquete(gTiquete, tiquetes.total_tiquetes +1);

            return Created("created", created);
        }



        [HttpGet("{no_transaccion}")]
        public async Task<IActionResult> GetTiqueteVuelo(int no_transaccion)
        {
            return Ok(await _tiqueteRepository.GenerarTiquete(no_transaccion));
        }
    }
}
