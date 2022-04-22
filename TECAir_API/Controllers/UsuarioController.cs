using Microsoft.AspNetCore.Mvc;
using TECAir_API.Database.Interface;
using TECAir_API.Models;
using TECAir_API.Models.Automation;
using TECAir_API.Models.WEB;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TECAir_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IAutomation _automationRepository;
        private readonly IUsuario _usuarioRepository;

        public UsuarioController (IAutomation automationRepository, IUsuario usuarioRepository)
        {
            _automationRepository = automationRepository;
            _usuarioRepository = usuarioRepository;
        }

        [HttpGet("{correo}/{contrasena}")]
        public async Task<IActionResult> GetContrasena(string correo, string contrasena)
        {

            //Bug del correo (corrector)
            string nCorreo = correo.Replace("%40", "@");
            return Ok( await _automationRepository.LoginUser(nCorreo, contrasena));
        }

        [HttpPost("Add")]
        public async Task<IActionResult> crearUsuario(UsuarioWeb nuevousuario)
        {
            UsuariosTotales users = await _automationRepository.GetTotalUsuarios();
            Usuario user = new Usuario(users.total_usuarios, nuevousuario.u_nombre,nuevousuario.u_apellido1,nuevousuario.u_apellido2,nuevousuario.correo,nuevousuario.u_contrasena,nuevousuario.telefono);

            if (nuevousuario.carne == 0 || nuevousuario.universidad == "null") {
                Estudiante student = new Estudiante(nuevousuario.carne, nuevousuario.universidad, users.total_usuarios);
                var created2 = await _usuarioRepository.ingresarEstudiante(student);
            }

            if (user == null)
                return BadRequest();
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            
            var created = await _usuarioRepository.ingresarUsuario(user);
            

            return Created("created", created);
        }


    }
}
