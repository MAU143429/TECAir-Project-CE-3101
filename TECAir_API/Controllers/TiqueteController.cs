using Microsoft.AspNetCore.Mvc;
using TECAir_API.Models;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TECAir_API.Models
{
    [Route("api/[controller]")]
    [ApiController]
    public class TiqueteController : ControllerBase
    {
        // Lista de informacion de tiquetes comprados
        List<TiqueteWeb> tiquetes= new List<TiqueteWeb>
        {
            //new Tiquete(1, 10, 20, "url1", "22/04/2022")
        };
        // GET: api/<TiqueteController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<TiqueteController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TiqueteController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TiqueteController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TiqueteController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
