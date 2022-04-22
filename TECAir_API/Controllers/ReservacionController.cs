﻿using Microsoft.AspNetCore.Mvc;
using TECAir_API.Database.Interface;
using TECAir_API.Models;
using TECAir_API.Models.WEB;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TECAir_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservacionController : ControllerBase
    {
        private readonly IReservacion reservacionRepository;
        private readonly IAutomation _automationRepository;

        public ReservacionController(IReservacion reservacionRepository, IAutomation automationRepository)
        {
            reservacionRepository = reservacionRepository;
            _automationRepository = automationRepository;
        }

        // GET api/Reservacion/Get
        /// <summary>
        /// Metodo get para obtener los datos de la reservacion, buscado por el id de usuario o id de trabajador
        /// </summary>
        /// <param name="id"> id de usuario o de trabajador para busqueda en la tabla</param>
        /// <returns>reservacion con todos los datos necesarios para mostrar en la Web</returns>
        [HttpGet("Get/{id}")]
        public async Task<IActionResult> GetReservacionById(int id)
        {
            return Ok(await reservacionRepository.GetReservacionId(id));
        }

        // GET api/Reservacion/Get
        /// <summary>
        /// Metodo get para obtener los datos de la reservacion, buscado por el id de usuario o id de trabajador
        /// </summary>
        /// <param name="id"> id de usuario o de trabajador para busqueda en la tabla</param>
        /// <returns>reservacion con todos los datos necesarios para mostrar en la Web</returns>
        [HttpGet("GetTrab/{id}")]
        public async Task<IActionResult> GetReservacionById(string id)
        {
            return Ok(await reservacionRepository.GetReservacionId(id));
        }
    }
}
