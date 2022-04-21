using Microsoft.AspNetCore.Mvc;
using TECAir_API.Database.Interface;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TECAir_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AvionController : ControllerBase
    {
        private readonly IAvion _vueloRepository;

        public AvionController(IAvion vueloRepository)
        {
            _vueloRepository = vueloRepository;
        }

        [HttpGet("ListaAvion")]
        public async Task<IActionResult> ListaAvion()
        {
            return Ok(await _vueloRepository.GetAviones());
        }
    }
}
