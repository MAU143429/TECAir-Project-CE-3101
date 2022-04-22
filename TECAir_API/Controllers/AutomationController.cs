using Microsoft.AspNetCore.Mvc;
using TECAir_API.Database.Interface;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TECAir_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutomationController : ControllerBase
    {
        private readonly IAutomation automationRepository;

        public AutomationController(IAutomation automationRepository)
        {
            this.automationRepository = automationRepository;
        }

        [HttpGet("TotalVuelos")]
        public async Task<IActionResult> GetTotalVuelos()
        {
            return Ok(await automationRepository.GetTotalVuelos());
        }

        [HttpGet("TotalReservaciones")]
        public async Task<IActionResult> GetTotalReservaciones()
        {
            return Ok(await automationRepository.GetTotalReservaciones());
        }

        [HttpGet("TotalPromociones")]
        public async Task<IActionResult> GetTotalPromociones()
        {
            return Ok(await automationRepository.GetTotalPromociones());
        }

        [HttpGet("TotalMaletas")]
        public async Task<IActionResult> GetTotalMaletas()
        {
            return Ok(await automationRepository.GetTotalMaletas());
        }

        [HttpGet("TotalTiquetes")]
        public async Task<IActionResult> GetTotalTiquetes()
        {
            return Ok(await automationRepository.GetTotalTiquetes());
        }
    }
}
