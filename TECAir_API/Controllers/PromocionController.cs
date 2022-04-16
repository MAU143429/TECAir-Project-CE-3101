using Microsoft.AspNetCore.Mvc;
using TECAir_API.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TECAir_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PromocionController : ControllerBase
    {
        // Lista de promociones
        List<Promocion> promociones = new List<Promocion> 
        {
            new Promocion(1, 10, 20, "url1", "22/04/2022")
        };

        // GET: api/<PromocionController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<PromocionController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        /// <summary>
        /// Metodo Post para agregar nuevas promociones desde la Web
        /// </summary>
        /// <param name="nuevaPromocion"> Objeto promocion que proviene de Web con los atributos del modelo Promocion.cs</param>
        /// <returns> Una lista de promociones creadas </returns>
        // POST api/Promocion/Add
        [HttpPost("Add")]
        public List<Promocion> Post(Promocion nuevaPromocion)
        {
            int id = promociones.Last().no_promocion + 1;
            promociones.Add(nuevaPromocion);
            return promociones;
        }

        // PUT api/<PromocionController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PromocionController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
