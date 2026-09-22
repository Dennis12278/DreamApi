using DreamApi.Models;

namespace DreamApi.Services
{
    public class NotificacaoService
    {
        private List<Notificacao> notificacoes = new List<Notificacao>();

        public List<Notificacao> Listar()
        {
            return notificacoes;
        }

        public void Adicionar(Notificacao notificacao)
        {
            notificacoes.Add(notificacao);
        }

        public void Editar(Notificacao notificacao)
        {
            Notificacao notificacaoExistente = notificacoes.Find(n => n.Id == notificacao.Id);

            if (notificacaoExistente != null)
            {
                notificacaoExistente.Mensagem = notificacao.Mensagem;
                notificacaoExistente.Status = notificacao.Status;
                notificacaoExistente.DataUltimaAcao = notificacao.DataUltimaAcao;
            }
        }

        public void Excluir(int id)
        {
            Notificacao notificacao = notificacoes.Find(n => n.Id == id);

            if (notificacao != null)
            {
                notificacoes.Remove(notificacao);
            }
        }
    }
}