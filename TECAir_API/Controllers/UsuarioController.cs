using Microsoft.AspNetCore.Mvc;
using TECAir_API.Database.Interface;
using TECAir_API.Models;
using TECAir_API.Models.WEB;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TECAir_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IAutomation _automationRepository;

        public UsuarioController (IAutomation automationRepository)
        {
            _automationRepository = automationRepository;
        }

        [HttpGet("{correo}/{contrasena}")]
        public async Task<List<Login>> GetAsync(string correo, string contrasena)
        {
            Login login = await _automationRepository.LoginUser(correo, contrasena);

            Singleton singleton = Singleton.Instance();
            singleton.usuario = correo;
            singleton.usua_trab = true;

            return new List<Login>() { login };
        }
    }
}
