using Microsoft.AspNetCore.Mvc;
using TECAir_API.Database.Interface;
using TECAir_API.Models;
using TECAir_API.Models.WEB;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TECAir_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrabajadorController : ControllerBase
    {
        private readonly IAutomation _automationRepository;

        public TrabajadorController(IAutomation automationRepository)
        {
            _automationRepository = automationRepository;
        }

        // GET: api/<TrabajadorController>
        [HttpGet("{id_trabajador}/{contrasena}")]
        public async Task<IActionResult> GetContrasena(string id_trabajador, string contrasena)
        {
            return Ok(await _automationRepository.LoginUser(id_trabajador, contrasena));
        }
    }
}
