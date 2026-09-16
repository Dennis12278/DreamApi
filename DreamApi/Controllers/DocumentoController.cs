using DreamApi.Models;
using DreamApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace DreamApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DocumentoController : ControllerBase
    {
        private DocumentoService documentoService;

        public DocumentoController(DocumentoService documentoService)
        {
            this.documentoService = documentoService;
        }

        [HttpGet]
        public List<Documento> Listar()
        {
            return documentoService.Listar();
        }

        [HttpPost]
        public void Adicionar(Documento documento)
        {
            documentoService.Adicionar(documento);
        }

        [HttpPut]
        public void Editar(Documento documento)
        {
            documentoService.Editar(documento);
        }

        [HttpDelete("{id}")]
        public void Excluir(int id)
        {
            documentoService.Excluir(id);
        }
    }
}