using Microsoft.AspNetCore.Mvc;
using TECAir_API.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TECAir_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrabajadorController : ControllerBase
    {
        List<Trabajador> trabajadores = new List<Trabajador>();

        // GET: api/<TrabajadorController>
        [HttpGet]
        public List<Trabajador> Get()
        {
            trabajadores.Add(new Trabajador(1, "admin1"));
            trabajadores.Add(new Trabajador(2, "admin2"));

            return trabajadores;
        }

        // GET api/<TrabajadorController>/5
        [HttpGet("{id}")]
        public Trabajador Get(int id)
        {
            trabajadores.Add(new Trabajador(1, "admin1"));
            trabajadores.Add(new Trabajador(2, "admin2"));

            for (int i = 0; i < trabajadores.Count; i++)
            {
                if (trabajadores[i].id_trabajador == id)
                    return trabajadores[i];
            }
            return new Trabajador();
        }

        // POST api/<TrabajadorController>
        [HttpPost]
        public List<Trabajador> Post([FromBody] Trabajador value)
        {
            trabajadores.Add(value);
            return trabajadores;
        }
    }
}
