using Microsoft.AspNetCore.Mvc;
using TECAir_API.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TECAir_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusquedaController : ControllerBase
    {
        // Lista de promociones
        List<Busqueda> busquedas = new List<Busqueda>
        {
            new Busqueda("SJO", "MXN", "12/04/26")
        };
        // GET: api/<BusquedaController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<BusquedaController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        /// <summary>
        /// Metodo Post para enviar busquedas de vuelo desde la Web
        /// </summary>
        /// <param name="nuevaBusqueda"> El objeto busqueda que contiene aeropuerto origen, destino y fecha</param>
        /// <returns>busquedas realizadas</returns>
        // POST api/<BusquedaController>
        [HttpPost("New")]
        public List<Busqueda> Post(Busqueda nuevaBusqueda)
        {
            busquedas.Add(nuevaBusqueda);
            return busquedas;
        }

        // PUT api/<BusquedaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BusquedaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
