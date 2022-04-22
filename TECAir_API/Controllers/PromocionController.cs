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
    public class PromocionController : ControllerBase
    {
        private readonly IPromocion _promocionRepository;
        private readonly IAutomation _automationRepository;

        public PromocionController(IPromocion promocionRepository, IAutomation automationRepository)
        {
            _promocionRepository = promocionRepository;
            _automationRepository = automationRepository;
        }


        /// <summary>
        /// Metodo Post para agregar nuevas promociones desde la Web
        /// </summary>
        /// <param name="nuevaPromocion"> Objeto promocion que proviene de Web con los atributos del modelo Promocion.cs</param>
        /// <returns> Una lista de promociones creadas </returns>
        // POST api/Promocion/Add
        [HttpPost("Add")]
        public async Task<IActionResult> crearPromocion(PromocionWeb nuevaPromocion)
        {
            PromocionesTotales promos = await _automationRepository.GetTotalPromociones();
            Promocion promocion = new Promocion(promos.total_promociones + 1, nuevaPromocion.porcentaje, nuevaPromocion.periodo, nuevaPromocion.url, nuevaPromocion.getDia(), nuevaPromocion.getMes(), nuevaPromocion.getAno(), nuevaPromocion.no_vuelo);
            if (promocion == null)

                return BadRequest();
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var created = await _promocionRepository.ingresarPromocion(promocion);

            return Created("created", created);
        }

    }
}
