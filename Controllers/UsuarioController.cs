using DreamApi.Models;
using DreamApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace DreamApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        private UsuarioService usuarioService;

        public UsuarioController(UsuarioService usuarioService)
        {
            this.usuarioService = usuarioService;
        }

        [HttpGet]
        public List<Usuario> Listar()
        {
            return usuarioService.Listar();
        }

        [HttpPost]
        public void Adicionar(Usuario usuario)
        {
            usuarioService.Adicionar(usuario);
        }

        [HttpPut]
        public void Editar(Usuario usuario)
        {
            usuarioService.Editar(usuario);
        }

        [HttpDelete("{id}")]
        public void Excluir(int id)
        {
            usuarioService.Excluir(id);
        }
    }
}