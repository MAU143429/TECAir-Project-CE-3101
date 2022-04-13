using Microsoft.AspNetCore.Mvc;
using TECAir_API.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TECAir_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        List<Usuario> usuarios = new List<Usuario>();

        // GET: api/<UsuarioController>
        [HttpGet]
        public List<Usuario> Get()
        {
            usuarios.Add(new Usuario(1, "Victor", "Castrillo", "Munoz", "victor.castrillo.99@estudiantec.cr", "2017110244", 83592900));
            usuarios.Add(new Usuario(2, "Andrés", "Monge", "Salas", "andres.monge.00@estudiantec.cr", "2018403365", 88390462));
            usuarios.Add(new Usuario(3, "Valeria", "Herrera", "López", "valeria.herrera.98@estudiantec.cr", "2016992042", 86708269));

            return usuarios;
        }

        // GET api/<UsuarioController>/5
        [HttpGet("{id}")]
        public Usuario Get(int id)
        {
            usuarios.Add(new Usuario(1, "Victor", "Castrillo", "Munoz", "victor.castrillo.99@estudiantec.cr", "2017110244", 83592900));
            usuarios.Add(new Usuario(2, "Andrés", "Monge", "Salas", "andres.monge.00@estudiantec.cr", "2018403365", 88390462));
            usuarios.Add(new Usuario(3, "Valeria", "Herrera", "López", "valeria.herrera.98@estudiantec.cr", "2016992042", 86708269));

            for (int i = 0; i < usuarios.Count; i++)
            {
                if (usuarios[i].id_usuario == id)
                    return usuarios[i];
            }
            return new Usuario();
        }

        // POST api/<UsuarioController>
        [HttpPost]
        public List<Usuario> Post([FromBody] Usuario value)
        {
            usuarios.Add(value);
            return usuarios;
        }
    }
}
