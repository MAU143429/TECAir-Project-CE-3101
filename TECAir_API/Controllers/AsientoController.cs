using Microsoft.AspNetCore.Mvc;
using TECAir_API.Database.Interface;
using TECAir_API.Models;
using TECAir_API.Models.Automation;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TECAir_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class AsientoController : ControllerBase
    {
        private readonly IAsiento _asientoRepository;
        private readonly IAutomation _automationRepository;

        public AsientoController(IAsiento asientoRepository, IAutomation automationRepository)
        {
            _asientoRepository = asientoRepository;
            _automationRepository = automationRepository;
        }
        // POST api/<AsientoController>
        [HttpPost("Add")]
        public async Task<IActionResult> IngresarAsiento([FromBody] AsientoWeb asientoWeb)
        {
            AsientosTotales asientos = await _automationRepository.GetTotalAsientos();
            Asiento asiento = new Asiento(asientos.asientos, asientoWeb.ubicacion, asientoWeb.no_vuelo);
            if (asiento == null)
                return BadRequest();
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var created = await _asientoRepository.ingresarAsiento(asiento);

            return Created("created", created);
        }
    }
}
