using Microsoft.AspNetCore.Mvc;
using TECAir_API.Database.Interface;
using TECAir_API.Models;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TECAir_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VueloAbiertoController : ControllerBase
    {
        private readonly IVuelo _vueloRepository;

        public VueloAbiertoController(IVuelo vueloRepository)
        {
            _vueloRepository = vueloRepository;
        }
        // Lista de vuelos abiertos
        List<VueloAbiertoWeb> vuelosAbiertos = new List<VueloAbiertoWeb>
        {
            new VueloAbiertoWeb(222123)
        };

        /// <summary>
        /// Metodo get para obtener los datos de apertura de vuelos de acuerdo con el usuario que abordara buscado por numero de transaccion
        /// </summary>
        /// <param name="no_transaccion"> numero de transaccion para busqueda</param>
        /// <returns>Vuelo abierto con todos los datos necesarios para mostrar en la Web</returns>
        [HttpGet("Get/{no_transaccion}")]
        public async Task<IActionResult> GetInfoVueloAbierto(int no_transaccion)
        {
            return Ok(await _vueloRepository.GetInfoVueloAbierto(no_transaccion));
        }

        /// <summary>
        /// Metodo Post para agregar vuelos abiertos desde la Web
        /// </summary>
        /// <param name="nuevoVuelo"> Objeto VueloAbierto que obtiene el numero de transaccion asociado</param>
        /// <returns></returns>
        // POST api/<VueloAbiertoController>
        [HttpPost]
        public List<VueloAbiertoWeb> Post(VueloAbiertoWeb nuevoVuelo)
        {
            vuelosAbiertos.Add(nuevoVuelo);
            return vuelosAbiertos;
        }

        // PUT api/<VueloAbiertoController>/5
        [HttpPut("updateAbordaje")]
        public async Task<IActionResult> UpdateAbordaje([FromBody] TiqueteWeb tiquete)
        {
            await _vueloRepository.UpdateEstadoAbordaje(tiquete);
            return NoContent();

        }

    }
}
