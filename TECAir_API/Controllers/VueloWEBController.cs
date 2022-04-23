using Microsoft.AspNetCore.Mvc;
using TECAir_API.Models.WEB;
using TECAir_API.Database;
using TECAir_API.Database.Interface;
using TECAir_API.Models;
using TECAir_API.Models.Automation;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TECAir_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VueloWEBController : ControllerBase
    {
        private readonly IVuelo _vueloRepository;
        private readonly IAutomation _automationRepository;

        public VueloWEBController(IVuelo vueloRepository, IAutomation automationRepository)
        {
            _vueloRepository = vueloRepository;
            _automationRepository = automationRepository;
        }

        // POST api//Add
        /// <summary>
        /// Metodo Post para crear y agregar un vuelo nuevo a la base de datos desde web
        /// </summary>
        /// <param name="nuevoVuelo"> objeto de tipo VueloWeb que almacena los valores necesarios para crear un Vuelo</param>
        /// <returns>Estado de creado en la base</returns>
        [HttpPost("Add")]
        public async Task<IActionResult> crearVuelo(VueloWeb nuevoVuelo)
        {
            VuelosTotales vuelos = await _automationRepository.GetTotalVuelos();
            Vuelo vuelo = new Vuelo(vuelos.total_vuelos + 1, nuevoVuelo.origen, nuevoVuelo.destino, nuevoVuelo.prt_abordaje, nuevoVuelo.h_salida, nuevoVuelo.h_llegada, nuevoVuelo.getDia(), nuevoVuelo.getMes(), nuevoVuelo.getAno(), nuevoVuelo.coste_vuelo, nuevoVuelo.modelo_av, false); 
            if (vuelo == null)
                return BadRequest();
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var created = await _vueloRepository.ingresarVuelo(vuelo);

            return Created("created", created);
        }
        

        // GET: api/<VueloWEBController>
        [HttpGet("{origen}/{destino}/{fecha}")]
        public async Task<IActionResult> GetVuelos(string origen, string destino, string fecha)
        {
            VueloBusquedaWeb nuevaBusqueda = new VueloBusquedaWeb(origen, destino, fecha);
            return Ok(await _vueloRepository.GetVuelos(nuevaBusqueda.origen, nuevaBusqueda.destino, nuevaBusqueda.getDia(), nuevaBusqueda.getMes(), nuevaBusqueda.getAno()));
        }

        [HttpGet("Get/{ReservacionWEB}")]
        public async Task<IActionResult> GetVuelo(VueloReserva vueloReserva)
        {
            return Ok(await _vueloRepository.GetVueloR(vueloReserva.no_vuelo, vueloReserva.no_reservacion));
        }
    }
}
