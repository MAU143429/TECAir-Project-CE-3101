using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TECAir_API.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TECAir_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AeropuertoController : ControllerBase
    {
        List<Aeropuerto> aeropuertoList = new List<Aeropuerto>();

        // GET: api/<AeropuertoController>
        [HttpGet]
        public List<Aeropuerto> Get()
        {
            List<Aeropuerto> aeropuertos;
            using (StreamReader r = new StreamReader("Assets/airports.json"))
            {
                string json = r.ReadToEnd();
                aeropuertos = JsonConvert.DeserializeObject<List<Aeropuerto>>(json);
            }
            return aeropuertos;
        }
    }
}
