using DreamApi.Models;

namespace DreamApi.Services
{
    public class DocumentoService
    {
        private List<Documento> documentos = new List<Documento>();

        public List<Documento> Listar()
        {
            return documentos;
        }

        public void Adicionar(Documento documento)
        {
            documentos.Add(documento);
        }

        public void Editar(Documento documento)
        {
            Documento documentoExistente = documentos.Find(d => d.Id == documento.Id);

            if (documentoExistente != null)
            {
                documentoExistente.IdUsuario = documento.IdUsuario;
                documentoExistente.IdTipoDocumento = documento.IdTipoDocumento;
                documentoExistente.Titulo = documento.Titulo;
                documentoExistente.Conteudo = documento.Conteudo;
            }
        }

        public void Excluir(int id)
        {
            Documento documento = documentos.Find(d => d.Id == id);

            if (documento != null)
            {
                documentos.Remove(documento);
            }
        }
    }
}