using Microsoft.AspNetCore.Mvc;
using TECAir_API.Models;
using TECAir_API.Database;
using TECAir_API.Database.Interface;
using TECAir_API.Models.Automation;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TECAir_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaletaController : ControllerBase
    {
        private readonly IMaletum _maletumRepository;
        private readonly IAutomation _automationRepository;

        public MaletaController(IMaletum maletumRepository, IAutomation automationRepository)
        {
            _maletumRepository = maletumRepository;
            _automationRepository = automationRepository;
        }


        [HttpPost("Add")]
        public async Task<IActionResult> crearMaleta(MaletaWeb nuevaMaleta)
        {
            MaletasTotales maletas = await _automationRepository.GetTotalMaletas();
            Maletum maleta = new Maletum(maletas.total_maletas + 1, nuevaMaleta.color,nuevaMaleta.peso,nuevaMaleta.dni,nuevaMaleta.no_vuelo);
            if (maleta == null)

                return BadRequest();
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var created = await _maletumRepository.ingresarMaleta(maleta);

            return Created("created", created);
        }


    }
}
