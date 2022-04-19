using Microsoft.AspNetCore.Mvc;
using TECAir_API.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TECAir_API.Controllers
{/*
    [Route("api/[controller]")]
    [ApiController]
    
    public class AsientoController : ControllerBase
    {
        List<Asiento> asientos = new List<Asiento>();

        // GET: api/<AsientoController>
        [HttpGet]
        public List<Asiento> Get()
        {
            asientos.Add(new Asiento(1, 1, "5F"));
            asientos.Add(new Asiento(2, 1, "3G"));
            asientos.Add(new Asiento(3, 1, "8K"));
            asientos.Add(new Asiento(1, 2, "2A"));
            asientos.Add(new Asiento(2, 2, "5D"));

            return asientos;
        }

        // GET api/<AsientoController>/5
        [HttpGet("{id}")]
        public List<Asiento> Get(int id)
        {
            asientos.Add(new Asiento(1, 1, "5F"));
            asientos.Add(new Asiento(2, 1, "3G"));
            asientos.Add(new Asiento(3, 1, "8K"));
            asientos.Add(new Asiento(4, 2, "2A"));
            asientos.Add(new Asiento(5, 2, "5D"));
            List<Asiento> resultado = new List<Asiento>();

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
        public List<Asiento> Post([FromBody] Asiento value)
        {
            asientos.Add(value);
            return asientos;
        }
    }*/
}
