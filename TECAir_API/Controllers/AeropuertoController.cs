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
        List<AeropuertoWeb> aeropuertoList = new List<AeropuertoWeb>();

        // GET: api/<AeropuertoController>
        [HttpGet]
        public List<AeropuertoWeb> Get()
        {
            List<AeropuertoWeb> aeropuertos;
            using (StreamReader r = new StreamReader("Assets/airports.json"))
            {
                string json = r.ReadToEnd();
                aeropuertos = JsonConvert.DeserializeObject<List<AeropuertoWeb>>(json);
            }
            return aeropuertos;
        }
    }
}
