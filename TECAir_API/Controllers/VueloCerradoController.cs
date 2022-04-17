using Microsoft.AspNetCore.Mvc;
using TECAir_API.Models;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TECAir_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VueloCerradoController : ControllerBase
    {
        // Lista de vuelos cerrados
        List<VueloCerrado> vuelosCerrados = new List<VueloCerrado>
        {
            new VueloCerrado(1455)
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
        /// Metodo Post para agregar vuelos cerrados desde la Web
        /// </summary>
        /// <param name="nuevoVuelo"> Objeto VueloCerrado que obtiene el numero de vuelo que desea cerrar</param>
        /// <returns></returns>
        // POST api/<VueloAbiertoController>
        [HttpPost]
        public List<VueloCerrado> Post(VueloCerrado nuevoVuelo)
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
