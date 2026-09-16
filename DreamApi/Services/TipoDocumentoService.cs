using DreamApi.Models;

namespace DreamApi.Services
{
    public class TipoDocumentoService
    {
        private List<TipoDocumento> tipos = new List<TipoDocumento>();

        public List<TipoDocumento> Listar()
        {
            return tipos;
        }

        public void Adicionar(TipoDocumento tipo)
        {
            tipos.Add(tipo);
        }

        public void Editar(TipoDocumento tipo)
        {
            TipoDocumento tipoExistente = tipos.Find(t => t.Id == tipo.Id);

            if (tipoExistente != null)
            {
                tipoExistente.Nome = tipo.Nome;
            }
        }

        public void Excluir(int id)
        {
            TipoDocumento tipo = tipos.Find(t => t.Id == id);

            if (tipo != null)
            {
                tipos.Remove(tipo);
            }
        }
    }
}