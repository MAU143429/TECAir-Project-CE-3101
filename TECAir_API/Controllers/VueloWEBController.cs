using Microsoft.AspNetCore.Mvc;
using TECAir_API.Models.WEB;
using TECAir_API.Database;
using TECAir_API.Database.Interface;
using TECAir_API.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TECAir_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VueloWEBController : ControllerBase
    {
        private readonly IVuelo _vueloRepository;

        public VueloWEBController(IVuelo vueloRepository)
        {
            _vueloRepository = vueloRepository;
        }

        [HttpPost("Add")]
        public async Task<IActionResult> crearVuelo(VueloWeb nuevoVuelo)
        {
            Vuelo vuelo = new Vuelo(1, nuevoVuelo.origen, nuevoVuelo.destino, nuevoVuelo.prt_abordaje, nuevoVuelo.h_salida, nuevoVuelo.h_salida, nuevoVuelo.getDia(), nuevoVuelo.getMes(), nuevoVuelo.getAno(), nuevoVuelo.coste_vuelo, nuevoVuelo.modelo_av, false); 
            if (vuelo == null)
                return BadRequest();
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var created = await _vueloRepository.ingresarVuelo(vuelo);

            return Created("created", created);
        }

    }
}
