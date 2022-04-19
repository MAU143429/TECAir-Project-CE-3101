using Microsoft.AspNetCore.Mvc;
using TECAir_API.Models;
using TECAir_API.Models.WEB;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TECAir_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrabajadorController : ControllerBase
    {
        List<TrabajadorWeb> trabajadores = new List<TrabajadorWeb>();

        // GET: api/<TrabajadorController>
        [HttpGet]
        public List<TrabajadorWeb> Get()
        {
            trabajadores.Add(new TrabajadorWeb("admin", "admin"));
            trabajadores.Add(new TrabajadorWeb("mrivera", "mrivera"));

            return trabajadores;
        }

        // GET api/<TrabajadorController>/5
        [HttpGet("{id}")]
        public List<TrabajadorWeb> Get(string id)
        {
            trabajadores.Add(new TrabajadorWeb("admin", "admin"));
            trabajadores.Add(new TrabajadorWeb("mrivera", "mrivera"));
            List<TrabajadorWeb> resultado = new List<TrabajadorWeb>();

            for (int i = 0; i < trabajadores.Count; i++)
            {
                if (trabajadores[i].id_trabajador == id)
                    resultado.Add(trabajadores[i]);
            }
            return resultado;
        }

        [HttpGet("{id}/{contrasena}")]
        public List<Login> Get(string id, string contrasena)
        {
            trabajadores.Add(new TrabajadorWeb("admin", "admin"));
            trabajadores.Add(new TrabajadorWeb("mrivera", "mrivera"));
            List<Login> resultado = new List<Login>();

            for (int i = 0; i < trabajadores.Count; i++)
            {
                if (trabajadores[i].id_trabajador == id && trabajadores[i].t_contrasena == contrasena)
                {
                    Singleton singleton = Singleton.Instance();
                    singleton.usuario = id;
                    singleton.usua_trab = false;
                    resultado.Add(new Login(true));
                    break;
                }
            }
            if (resultado.Count == 0)
            {
                resultado.Add(new Login(false));
            }

            return resultado;
        }

        // POST api/<TrabajadorController>
        [HttpPost]
        public List<TrabajadorWeb> Post([FromBody] TrabajadorWeb value)
        {
            trabajadores.Add(value);
            return trabajadores;
        }
    }
}
