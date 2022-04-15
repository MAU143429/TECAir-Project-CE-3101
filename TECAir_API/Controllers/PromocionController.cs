using Microsoft.AspNetCore.Mvc;
using TECAir_API.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TECAir_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PromocionController : ControllerBase
    {
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

        // POST api/<PromocionController>
        [HttpPost("Add")]
        public Promocion Post(Promocion promocion)
        {
            Console.WriteLine(promocion);
            return promocion;
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
