using DreamApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace DreamApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        private UsuarioService usuarioService = new UsuarioService();

        [HttpGet("testar")]
        public string Testar()
        {
            return usuarioService.Testar();
        }
    }
}