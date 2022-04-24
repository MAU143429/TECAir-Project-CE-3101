using Microsoft.AspNetCore.Mvc;
using TECAir_API.Database.Repository;
using TECAir_API.Models.Automation;
using TECAir_API.Models.WEB;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TECAir_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PasajeroController : ControllerBase
    {
        public AutomationRepository _automationRepository;
        public PasajeroRepository _pasajeroRepository;

        public PasajeroController(AutomationRepository automationRepository, PasajeroRepository pasajeroRepository)
        {
            _automationRepository = automationRepository;
            _pasajeroRepository = pasajeroRepository;
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add(GenerarTiquete gTiquete)
        {
            TiquetesTotales tiquetes = await _automationRepository.GetTotalTiquetes();
            var created = await _pasajeroRepository.GenerarTiquete(gTiquete, 35);

            return Created("created", created);
        }
    }
}
