using Microsoft.AspNetCore.Mvc;
using TECAir_API.Database.Interface;
using TECAir_API.Models;
using TECAir_API.Models.WEB;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TECAir_API.Models
{
    [Route("api/[controller]")]
    [ApiController]
    public class TiqueteController : ControllerBase
    {
        private readonly ITiquete tiqueteRepository;
        public List<TiqueteWeb> tiquetes = new List<TiqueteWeb>();

        public TiqueteController(ITiquete tiqueteRepository)
        {
            this.tiqueteRepository = tiqueteRepository;
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
            return Ok(await tiqueteRepository.GetTiqueteId());
        }

        [HttpGet("GetT/{no_transaccion}")]
        public async Task<IActionResult> GetTiqueteByNoT(int no_transaccion)
        {
            return Ok(await tiqueteRepository.GetTiqueteNoT(no_transaccion));
        }
    }
}
