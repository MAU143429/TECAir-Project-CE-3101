using Microsoft.AspNetCore.Mvc;
using TECAir_API.Database.Repository;
using TECAir_API.Models;
using TECAir_API.Models.Automation;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TECAir_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EscalaController : ControllerBase
    {
        public AutomationRepository _automationRepository;
        public EscalaRepository _escalaRepository;

        public EscalaController(AutomationRepository automationRepository, EscalaRepository escalaRepository)
        {
            _automationRepository = automationRepository;
            _escalaRepository = escalaRepository;
        }

        [HttpPost("Add")]
        public async Task<IActionResult> crearEscala(EscalaWeb nuevaEscala)
        {
            CantEscalas escalas = await _automationRepository.GetEscalas();
            Escala escala = new Escala(escalas.cant_escalas, nuevaEscala.escala, nuevaEscala.orden, nuevaEscala.no_vuelo);
            if (escala == null)

                return BadRequest();
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var created = await _escalaRepository.ingresarEscala(escala);

            return Created("created", created);
        }
    }
}
