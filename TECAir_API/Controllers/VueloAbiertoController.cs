using Microsoft.AspNetCore.Mvc;
using TECAir_API.Models;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TECAir_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VueloAbiertoController : ControllerBase
    {
        // Lista de vuelos abiertos
        List<VueloAbiertoWeb> vuelosAbiertos = new List<VueloAbiertoWeb>
        {
            new VueloAbiertoWeb(222123)
        };
        // GET: api/<VueloAbiertoController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<VueloAbiertoController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
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
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<VueloAbiertoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
