using Microsoft.AspNetCore.Mvc;
using TECAir_API.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TECAir_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class AsientoController : ControllerBase
    {
        List<AsientoWeb> asientos = new List<AsientoWeb>();
        

        // GET: api/<AsientoController>
        [HttpGet]
        public List<AsientoWeb> Get()
        {
            asientos.Add(new AsientoWeb(1, 1, "5F"));
            asientos.Add(new AsientoWeb(2, 1, "3G"));
            asientos.Add(new AsientoWeb(3, 1, "8K"));
            asientos.Add(new AsientoWeb(1, 2, "2A"));
            asientos.Add(new AsientoWeb(2, 2, "5D"));

            return asientos;
        }

        // GET api/<AsientoController>/5
        [HttpGet("{id}")]
        public List<AsientoWeb> Get(int id)
        {
            asientos.Add(new AsientoWeb(1, 1, "5F"));
            asientos.Add(new AsientoWeb(2, 1, "3G"));
            asientos.Add(new AsientoWeb(3, 1, "8K"));
            asientos.Add(new AsientoWeb(4, 2, "2A"));
            asientos.Add(new AsientoWeb(5, 2, "5D"));
            List<AsientoWeb> resultado = new List<AsientoWeb>();

            for (int i = 0; i < asientos.Count; i++)
            {
                if (asientos[i].no_asiento == id)
                {
                    resultado.Add(asientos[i]);
                }
            }
            return resultado;
        }

        // POST api/<AsientoController>
        [HttpPost]
        public List<AsientoWeb> Post([FromBody] AsientoWeb value)
        {
            asientos.Add(value);
            return asientos;
        }
    }
}
