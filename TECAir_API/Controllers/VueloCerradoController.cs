using Microsoft.AspNetCore.Mvc;
using TECAir_API.Database.Interface;
using TECAir_API.Models;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TECAir_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VueloCerradoController : ControllerBase
    {
        private readonly IVuelo _vueloRepository;

        public VueloCerradoController(IVuelo vueloRepository)
        {
            _vueloRepository = vueloRepository;
        }

        // Lista de vuelos cerrados
        List<VueloCerradoWeb> vuelosCerrados = new List<VueloCerradoWeb>
        {
            new VueloCerradoWeb(1455)
        };
        // GET: api/<VueloCerradoController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<VueloCerradoController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        /// <summary>
        /// Metodo get para obtener los datos de cierre de vuelos buscado por numero de vuelo
        /// </summary>
        /// <param name="no_vuelo"> numero de vuelo para busqueda</param>
        /// <returns>Vuelo cerrado con todos los datos necesarios para mostrar en la Web</returns>
        [HttpGet("Get/{no_vuelo}")]
        public async Task<IActionResult> GetInfoVueloCerrado(int no_vuelo)
        {
            return Ok(await _vueloRepository.GetInfoVueloCerrado(no_vuelo));
        }

        /// <summary>
        /// Metodo Post para agregar vuelos cerrados desde la Web
        /// </summary>
        /// <param name="nuevoVuelo"> Objeto VueloCerrado que obtiene el numero de vuelo que desea cerrar</param>
        /// <returns></returns>
        // POST api/<VueloAbiertoController>
        [HttpPost]
        public List<VueloCerradoWeb> Post(VueloCerradoWeb nuevoVuelo)
        {
            vuelosCerrados.Add(nuevoVuelo);
            return vuelosCerrados;
        }

        // PUT api/<VueloCerradoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<VueloCerradoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
