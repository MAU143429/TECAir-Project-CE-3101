using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TECAir_API.Database.DBControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioDBController : ControllerBase
    {
        private readonly Usuario usuario;
        private readonly TECAirContext context;

        public UsuarioDBController(TECAirContext context)
        {
            this.context = context;
        }

        [HttpGet("{UNombre}")]
        public async Task<ActionResult<List<Usuario>>>Get(string nombre)
        {
            var nombreUsuario = await context.Usuarios.FindAsync(nombre);
            if (nombreUsuario == null)
                return NotFound();
            return Ok(nombreUsuario);
        }
    }
}
