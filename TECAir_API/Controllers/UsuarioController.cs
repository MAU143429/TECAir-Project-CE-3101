using Microsoft.AspNetCore.Mvc;
using TECAir_API.Database.Interface;
using TECAir_API.Models;
using TECAir_API.Models.Automation;
using TECAir_API.Models.WEB;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TECAir_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IAutomation _automationRepository;

        public UsuarioController (IAutomation automationRepository)
        {
            _automationRepository = automationRepository;
        }

        [HttpGet("{correo}/{contrasena}")]
        public async Task<List<Login>> GetAsync(string correo, string contrasena)
        {
            List<string> listaC = correo.Split("%40").ToList();
            for (int i = listaC.Count-1; i >= 0; i--)
            {
                if (listaC[i] == "%40")
                {
                    listaC[i] = "@";
                    break;
                }  
            }
            correo = listaC.ToString();

            Contrasena temp = await _automationRepository.LoginUser(correo, contrasena);
            Login resultlogin = new Login();


            if (temp.contrasena == contrasena)
                resultlogin.status = true;
            else
                resultlogin.status = false;

            Singleton singleton = Singleton.Instance();
            singleton.usuario = correo;
            singleton.usua_trab = true;

            return new List<Login>() { resultlogin };
        }
    }
}
