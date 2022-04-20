using Microsoft.AspNetCore.Mvc;
using TECAir_API.Models;
using TECAir_API.Database;
using TECAir_API.Database.Interface;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TECAir_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaletaController : ControllerBase
    {
        private readonly IMaletum _maletumRepository;

        public MaletaController(IMaletum maletumRepository)
        {
            _maletumRepository = maletumRepository;
        }


        [HttpPost("Add")]
        public async Task<IActionResult> crearMaleta(MaletaWeb nuevaMaleta)
        {
            Maletum maleta = new Maletum(111111, nuevaMaleta.color,nuevaMaleta.peso,nuevaMaleta.dni,nuevaMaleta.no_vuelo);
            if (maleta == null)

                return BadRequest();
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var created = await _maletumRepository.ingresarMaleta(maleta);

            return Created("created", created);
        }


    }
}
