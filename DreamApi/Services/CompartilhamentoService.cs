using DreamApi.Models;

namespace DreamApi.Services
{
    public class CompartilhamentoService
    {
        private List<Compartilhamento> compartilhamentos = new List<Compartilhamento>();

        public List<Compartilhamento> Listar()
        {
            return compartilhamentos;
        }

        public void Adicionar(Compartilhamento compartilhamento)
        {
            compartilhamentos.Add(compartilhamento);
        }

        public void Editar(Compartilhamento compartilhamento)
        {
            Compartilhamento compartilhamentoExistente = compartilhamentos.Find(c => c.Id == compartilhamento.Id);

            if (compartilhamentoExistente != null)
            {
                compartilhamentoExistente.IdDocumento = compartilhamento.IdDocumento;
                compartilhamentoExistente.IdGrupo = compartilhamento.IdGrupo;
                compartilhamentoExistente.DataUltimaAcao = compartilhamento.DataUltimaAcao;
            }
        }

        public void Excluir(int id)
        {
            Compartilhamento compartilhamento = compartilhamentos.Find(c => c.Id == id);

            if (compartilhamento != null)
            {
                compartilhamentos.Remove(compartilhamento);
            }
        }
    }
}