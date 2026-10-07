using DreamApi.Data;
using DreamApi.Models;

namespace DreamApi.Services
{
    public class DocumentoService
    {
        private DreamDbContext context;

        public DocumentoService(DreamDbContext context)
        {
            this.context = context;
        }

        public List<Documento> Listar()
        {
            return context.Documentos.ToList();
        }

        public void Adicionar(Documento documento)
        {
            context.Documentos.Add(documento);
            context.SaveChanges();
        }

        public void Editar(Documento documento)
        {
            Documento documentoExistente = context.Documentos.Find(documento.Id);

            if (documentoExistente != null)
            {
                documentoExistente.IdUsuario = documento.IdUsuario;
                documentoExistente.IdTipoDocumento = documento.IdTipoDocumento;
                documentoExistente.Titulo = documento.Titulo;
                documentoExistente.Conteudo = documento.Conteudo;
                documentoExistente.Revisado = documento.Revisado;
                documentoExistente.Publicado = documento.Publicado;
                documentoExistente.Visibilidade = documento.Visibilidade;
                documentoExistente.DataPublicacao = documento.DataPublicacao;

                context.SaveChanges();
            }
        }

        public void Revisar(int id)
        {
            Documento documento = context.Documentos.Find(id);

            if (documento != null)
            {
                documento.Revisado = true;
                context.SaveChanges();
            }
        }

        public void Publicar(int id)
        {
            Documento documento = context.Documentos.Find(id);

            if (documento != null)
            {
                documento.Publicado = true;
                documento.DataPublicacao = DateTime.Now;

                context.SaveChanges();
            }
        }

        public void Excluir(int id)
        {
            Documento documento = context.Documentos.Find(id);

            if (documento != null)
            {
                context.Documentos.Remove(documento);
                context.SaveChanges();
            }
        }
    }
}